using RLDumper.Core.Classes;
using RLDumper.Core.Models;
using RLDumper.Core.Models.Properties;
using RLLoader.Shared;
using System.Diagnostics;
using Enum = RLDumper.Core.Models.Enum;

namespace RLDumper.Core.OutputFormats;

public static class CSharp {
    private static Logger Logger { get; } = new("RLDumper.CSharp");
    public const int DefaultPaddingSize = 4;

    public static void OutputToFolder(List<Package> packages, string path) {
        if (Directory.Exists(path))
            Directory.Delete(path, true);

        _ = Directory.CreateDirectory(path);

        foreach (var package in packages) {
            var writer = new StreamWriter($"{path}/{package.FullName[(package.FullName.LastIndexOf(' ') + 1)..]}.cs");

            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine("using System.Runtime.CompilerServices;");
            writer.WriteLine();
            writer.WriteLine("namespace RLLoader.SDK;");
            writer.WriteLine();
            writer.WriteLine("#pragma warning disable CS0108, CS0114");
            writer.WriteLine();

            foreach (var @class in package.Classes) {
                WriteClass(writer, @class);
            }

            writer.WriteLine("#pragma warning restore CS0108, CS0114");
            writer.Close();
        }
    }

    public static void WriteClass(StreamWriter writer, Class @class) {
        writer.WriteLine($"// {@class.FullName}");
        WriteSizeInformation(writer, @class.Size, @class.BaseClass != null ? @class.BaseClass.Size : 0);
        WriteFlags<Flags.EClassFlags>(writer, @class.Flags);

        var className = $"{@class.Prefix}{GetShortName(@class.FullName)}";
        var isUObject = className == "UObject";

        writer.WriteLine($"public unsafe partial class {className}{(@class.BaseClass != null ? $" : {@class.BaseClass.Prefix}{GetShortName(@class.BaseClass.FullName)}" : "")}{(isUObject ? " : BaseObject" : "")} {{");
        writer.WriteLine($"{P(1)}public {className}() {{ }}");
        writer.WriteLine($"{P(1)}public {className}(nint pointer) : base(pointer) {{ }}");
        writer.WriteLine();
        if (@class.Constants.Count > 0) {
            writer.WriteLine();
            WriteConstants(writer, @class.Constants);
            writer.WriteLine();
        }
        if (@class.Properties.Count > 0 || @class.Size != @class.BaseClass.Size) {
            writer.WriteLine();
            WriteProperties(writer, @class.Properties, @class.BaseClass != null ? @class.BaseClass.Size : 0, @class.Size);
            writer.WriteLine();
        }
        if (@class.Functions.Count > 0) {
            writer.WriteLine();
            WriteFunctions(writer, @class.Functions);
            writer.WriteLine();
        }
        if (@class.Structs.Count > 0) {
            writer.WriteLine();
            WriteStructs(writer, @class.Structs);
            writer.WriteLine();
        }
        if (@class.Enums.Count > 0) {
            writer.WriteLine();
            WriteEnums(writer, @class.Enums);
            writer.WriteLine();
        }
        writer.WriteLine();
        WriteStaticClassGetter(writer, @class.FullName);
        writer.WriteLine("}");

        writer.WriteLine();
    }

    public static void WriteSizeInformation(StreamWriter writer, int size, int baseSize, int depth = 0) {
        writer.WriteLine($"{P(depth)}// 0x{size - baseSize:X}{(baseSize != 0 ? $" (0x{baseSize:X} - 0x{size:X})" : "")}");
    }

    public static void WriteFlags<T>(StreamWriter writer, ulong flags, int depth = 0) where T : struct, System.Enum {
        var flagsStr = Flags.ConvertFlagsToString<T>(flags);
        if (flagsStr != "") writer.WriteLine($"{P(depth)}// ({flagsStr})");
    }

    public static void WriteConstants(StreamWriter writer, List<Const> consts) {
        foreach (var @const in consts)
            writer.WriteLine($"{P(1)}public const string {GetShortName(@const.FullName)} = \"{ClearConstant(@const.Value)}\";");
    }

    public static void WriteProperties(StreamWriter writer, List<Property> properties, int baseSize, int classSize, int depth = 0) {
        var lastOffset = baseSize;

        if (properties.Count > 0) {
            properties = [.. properties.OrderBy(p => p.Offset)];

            for (var i = 0; i < properties.Count; i++) {
                var property = properties[i];

                if (i != 0)
                    writer.WriteLine();

                if (lastOffset < property.Offset) {
                    writer.WriteLine($"{P(1 + depth)}// MISSED OFFSET: 0x{property.Offset - lastOffset:X}");
                    writer.WriteLine();
                }

                writer.WriteLine($"{P(1 + depth)}// {property.FullName}");
                writer.WriteLine($"{P(1 + depth)}// 0x{property.Offset:X} (0x{property.Size * property.ArrayDim:X})");
                if (property is BoolProperty boolProp) writer.WriteLine($"{P(1 + depth)}// Bitmask: 0x{boolProp.BitMask:X8}");
                WriteFlags<Flags.EPropertyFlags>(writer, property.Flags, 1 + depth);

                var propertyType = GetPropertyType(property, depth);
                var isUnmanaged = IsPropertyUnmanaged(property);
                var pointerStr = property.Offset != 0 ? $"(Pointer + {property.Offset})" : "Pointer";
                if (property.ArrayDim > 1) {
                    writer.WriteLine($"{P(1 + depth)}// Fixed array size: {property.ArrayDim}");

                    var arrayType = GetFixedArrayTypeForProperty(property);
                    writer.WriteLine($"{P(1 + depth)}public {arrayType}<{propertyType}> {GetShortName(property.FullName)} {{");

                    writer.WriteLine($"{P(2 + depth)}get => new({(property.Offset != 0 ? $"Pointer + {property.Offset}" : "Pointer")}, {(arrayType == "StructFixedArray" ? $"{property.Size}, " : "")}{property.ArrayDim});");
                    writer.WriteLine($"{P(2 + depth)}set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*){pointerStr}, {property.Size * property.ArrayDim}, {property.Size * property.ArrayDim});");
                }
                else {
                    writer.WriteLine($"{P(1 + depth)}public {propertyType} {GetShortName(property.FullName)} {{");

                    if (isUnmanaged) {
                        if (property is BoolProperty boolProperty) {
                            writer.WriteLine($"{P(2 + depth)}get => (*(uint*){pointerStr} & 0x{boolProperty.BitMask:X}) != 0;");
                            writer.WriteLine($"{P(2 + depth)}set {{");
                            writer.WriteLine($"{P(3 + depth)}if (value) *(uint*){pointerStr} |= 0x{boolProperty.BitMask:X};");
                            writer.WriteLine($"{P(3 + depth)}else *(uint*){pointerStr} &= ~(uint)0x{boolProperty.BitMask:X};");
                            writer.WriteLine($"{P(2 + depth)}}}");
                        }
                        else {
                            writer.WriteLine($"{P(2 + depth)}get => *({propertyType}*){pointerStr};");
                            writer.WriteLine($"{P(2 + depth)}set => *({propertyType}*){pointerStr} = value;");
                        }
                    }
                    else {
                        if (property is ClassProperty or ObjectProperty) {
                            writer.WriteLine($"{P(2 + depth)}get {{");
                            writer.WriteLine($"{P(3 + depth)}var pointer = *(nint*){pointerStr};");
                            writer.WriteLine($"{P(3 + depth)}return pointer != nint.Zero ? new(pointer) : null;");
                            writer.WriteLine($"{P(2 + depth)}}}");
                            writer.WriteLine($"{P(2 + depth)}set => *(nint*){pointerStr} = value.Pointer;");
                        }
                        else {
                            if (property is ArrayProperty arrayProp) {
                                var arrayTypeIsStruct = GetTArrayTypeForProperty(arrayProp.Element) == "StructTArray";
                                writer.WriteLine($"{P(2 + depth)}get => new({(property.Offset != 0 ? $"Pointer + {property.Offset}" : "Pointer")}{(arrayTypeIsStruct ? $", {arrayProp.Element.Size}" : "")});");
                            }
                            else {
                                writer.WriteLine($"{P(2 + depth)}get => new({(property.Offset != 0 ? $"Pointer + {property.Offset}" : "Pointer")});");
                            }
                            writer.WriteLine($"{P(2 + depth)}set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*){pointerStr}, {property.Size}, {property.Size});");
                        }
                    }
                }
                
                writer.WriteLine($"{P(1 + depth)}}}");

                lastOffset = property.Offset + (property.Size * property.ArrayDim);
            }
        }

        if (lastOffset < classSize) {
            if (properties.Count > 0)
                writer.WriteLine();
            writer.WriteLine($"{P(1 + depth)}// MISSED OFFSET: 0x{classSize - lastOffset:X}");
        }
    }

    public static void WriteFunctions(StreamWriter writer, List<Function> functions) {
        for (var i = 0; i < functions.Count; i++) {
            var function = functions[i];
            if (i != 0)
                writer.WriteLine();

            var isStatic = (function.Flags & (ulong)Flags.EFunctionFlags.Static) != 0;
            var functionName = GetShortName(function.FullName);

            writer.WriteLine($"{P(1)}// {function.FullName}");
            writer.WriteLine($"{P(1)}// 0x{function.RVA:X}{(function.iNative > 0 ? $" (iNative: {function.iNative})" : "")}");
            WriteFlags<Flags.EFunctionFlags>(writer, function.Flags, 1);
            /*if (function.Parameters.Count > 0) {
                writer.WriteLine($"{P(1)}// Parameters:");
                foreach (var parameter in function.Parameters) {
                    writer.WriteLine($"{P(1)}// {GetPropertyType(parameter)} {GetShortName(parameter.FullName)} (0x{parameter.Offset:X} - 0x{parameter.Size * parameter.ArrayDim:X}){(parameter.Flags != 0 ? $" ({Flags.ConvertFlagsToString<Flags.EPropertyFlags>(parameter.Flags)})" : "")}");
                }
            }*/

            Property returnParameter = null;
            List<Property> allParameters = [];
            List<Property> otherParameters = [];
            List<Property> outParams = [];
            var paramSize = 0;

            foreach (var parameter in function.Parameters) {
                if ((parameter.Flags & (ulong)Flags.EPropertyFlags.ReturnParam) != 0) {
                    returnParameter = parameter;
                    allParameters.Add(parameter);
                    paramSize += parameter.Size * parameter.ArrayDim;
                }
                else if ((parameter.Flags & (ulong)Flags.EPropertyFlags.Param) != 0) {
                    otherParameters.Add(parameter);
                    allParameters.Add(parameter);
                    paramSize += parameter.Size * parameter.ArrayDim;
                    if ((parameter.Flags & (ulong)Flags.EPropertyFlags.OutParam) != 0) outParams.Add(parameter);
                }
            }

            writer.WriteLine($"{P(1)}public unsafe class {functionName}_Parameters : BaseObject {{");
            writer.WriteLine($"{P(2)}public {functionName}_Parameters() {{ }}");
            writer.WriteLine($"{P(2)}public {functionName}_Parameters(nint pointer) : base(pointer) {{ }}");
            if (allParameters.Count > 0) {
                writer.WriteLine();
                WriteProperties(writer, allParameters, 0, 0, 1);
            }
            writer.WriteLine($"{P(1)}}}");

            writer.WriteLine($"{P(1)}private static UFunction _ptr{functionName};");
            writer.Write($"{P(1)}public {(isStatic ? "static " : "")}");

            if (returnParameter != null) writer.Write($"{GetPropertyType(returnParameter, 1)}");
            else writer.Write("void");

            writer.Write($" {functionName}(");

            var sortedOtherParameters = otherParameters.OrderBy(p => (((p.Flags & (ulong)Flags.EPropertyFlags.OptionalParam) != 0) && !((p.Flags & (ulong)Flags.EPropertyFlags.OutParam) != 0)) ? 1 : 0).ToList();

            for (var j = 0; j < sortedOtherParameters.Count; j++) {
                var parameter = sortedOtherParameters[j];
                var isOut = (parameter.Flags & (ulong)Flags.EPropertyFlags.OutParam) != 0;
                var isOptional = (parameter.Flags & (ulong)Flags.EPropertyFlags.OptionalParam) != 0;
                var isFixedArray = parameter.ArrayDim > 1;
                writer.Write($"{(isOut ? "ref " : "")}{(isFixedArray ? $"{GetFixedArrayTypeForProperty(parameter)}<" : "")}{GetPropertyType(parameter, 1)}{(isFixedArray ? ">" : "")} {GetShortName(parameter.FullName)}{(isOptional && !isOut ? $" = {GetOptionalParamDefaultValue(parameter)}" : "")}");

                if (j != sortedOtherParameters.Count - 1) writer.Write(", ");
            }

            writer.WriteLine(") {");

            writer.WriteLine($"{P(2)}_ptr{functionName} ??= FindFunction(\"{function.FullName}\");");
            writer.WriteLine();
            if (paramSize > 0) {
                writer.WriteLine($"{P(2)}var @params = stackalloc byte[{paramSize}];");
                foreach (var parameter in otherParameters) {
                    var parameterName = GetShortName(parameter.FullName);
                    var isOutParam = (parameter.Flags & (ulong)Flags.EPropertyFlags.OutParam) != 0;
                    var isUnmanaged = IsPropertyUnmanaged(parameter) && parameter.ArrayDim == 1;
                    if (isOutParam && isUnmanaged) writer.WriteLine($"{P(2)}var _{parameterName} = {parameterName};");

                    var isOptionalAndManaged = !isUnmanaged && (parameter.Flags & (ulong)Flags.EPropertyFlags.OptionalParam) != 0;
                    if (isOptionalAndManaged) writer.Write($"{P(2)}if ({parameterName} != null) ");
                    writer.WriteLine($"{(!isOptionalAndManaged ? P(2) : "")}System.Buffer.MemoryCopy({(isUnmanaged ? $"&{(isOutParam ? "_" : "")}{parameterName}" : $"(void*){parameterName}.Pointer")}, @params{(parameter.Offset != 0 ? $" + {parameter.Offset}" : "")}, {parameter.Size * parameter.ArrayDim}, {parameter.Size * parameter.ArrayDim});");
                }
                writer.WriteLine();
            }

            if (function.iNative > 0) writer.WriteLine($"{P(2)}_ptr{functionName}.iNative = 0;");

            var isNative = (function.Flags & (ulong)Flags.EFunctionFlags.Native) != 0;
            if (isNative) writer.WriteLine($"{P(2)}_ptr{functionName}.FunctionFlags &= (ulong)~EFunctionFlags.Native;");
            writer.WriteLine($"{P(2)}{(isStatic ? "StaticClass." : "")}ProcessEvent(_ptr{functionName}, {(paramSize > 0 ? "@params" : "null")});");
            if (isNative) writer.WriteLine($"{P(2)}_ptr{functionName}.FunctionFlags |= (ulong)EFunctionFlags.Native;");

            if (function.iNative > 0) writer.WriteLine($"{P(2)}_ptr{functionName}.iNative = {function.iNative};");

            if (paramSize > 0) {
                if (outParams.Count > 0) writer.WriteLine();
                foreach (var parameter in outParams) {
                    if ((parameter.Flags & (ulong)Flags.EPropertyFlags.OutParam) == 0) continue;

                    var parameterType = GetPropertyType(parameter, 1);
                    var parameterName = GetShortName(parameter.FullName);
                    if (IsPropertyUnmanaged(parameter) && parameter.ArrayDim == 1) {
                        writer.WriteLine($"{P(2)}{parameterName} = *({parameterType}*){(parameter.Offset != 0 ? $"(@params + {parameter.Offset})" : "@params")};");
                    }
                    else {
                        if (parameter is ClassProperty or ObjectProperty) {
                            writer.WriteLine($"{P(2)}{parameterName} = new(*(nint*){(parameter.Offset != 0 ? $"(@params + {parameter.Offset})" : "@params")});");
                        }
                        else {
                            writer.WriteLine($"{P(2)}var _{parameterName}Ptr = Marshal.AllocHGlobal({parameter.Size * parameter.ArrayDim});");
                            writer.WriteLine($"{P(2)}System.Buffer.MemoryCopy({(parameter.Offset != 0 ? $"@params + {parameter.Offset}" : "@params")}, (void*)_{parameterName}Ptr, {parameter.Size * parameter.ArrayDim}, {parameter.Size * parameter.ArrayDim});");
                            if (parameter is ArrayProperty arrayProp) {
                                var arrayTypeIsStruct = GetTArrayTypeForProperty(arrayProp.Element) == "StructTArray";
                                writer.WriteLine($"{P(2)}{parameterName} = new(_{parameterName}Ptr{(arrayTypeIsStruct ? $", {arrayProp.Element.Size}" : "")}{(parameter.ArrayDim > 1 ? $"{(GetFixedArrayTypeForProperty(parameter) == "StructFixedArray" ? $", {parameter.Size}" : "")}, {parameter.ArrayDim}" : "")}) {{ Allocated = true }};");
                            }
                            else {
                                writer.WriteLine($"{P(2)}{parameterName} = new(_{parameterName}Ptr{(parameter.ArrayDim > 1 ? $"{(GetFixedArrayTypeForProperty(parameter) == "StructFixedArray" ? $", {parameter.Size}" : "")}, {parameter.ArrayDim}" : "")}) {{ Allocated = true }};");
                            }
                        }
                    }
                }
                if (returnParameter != null) {
                    writer.WriteLine();
                    var parameterType = GetPropertyType(returnParameter, 1);
                    var parameterName = GetShortName(returnParameter.FullName);
                    if (IsPropertyUnmanaged(returnParameter) && returnParameter.ArrayDim == 1) {
                        writer.WriteLine($"{P(2)}return *({parameterType}*){(returnParameter.Offset != 0 ? $"(@params + {returnParameter.Offset})" : "@params")};");
                    }
                    else {
                        if (returnParameter is ClassProperty or ObjectProperty) {
                            writer.WriteLine($"{P(2)}return new(*(nint*){(returnParameter.Offset != 0 ? $"(@params + {returnParameter.Offset})" : "@params")});");
                        }
                        else {
                            writer.WriteLine($"{P(2)}var _{parameterName}Ptr = Marshal.AllocHGlobal({returnParameter.Size * returnParameter.ArrayDim});");
                            writer.WriteLine($"{P(2)}System.Buffer.MemoryCopy({(returnParameter.Offset != 0 ? $"@params + {returnParameter.Offset}" : "@params")}, (void*)_{parameterName}Ptr, {returnParameter.Size * returnParameter.ArrayDim}, {returnParameter.Size * returnParameter.ArrayDim});");

                            if (returnParameter is ArrayProperty arrayProp) {
                                var arrayTypeIsStruct = GetTArrayTypeForProperty(arrayProp.Element) == "StructTArray";
                                writer.WriteLine($"{P(2)}return new(_{parameterName}Ptr{(arrayTypeIsStruct ? $", {arrayProp.Element.Size}" : "")}{(returnParameter.ArrayDim > 1 ? $"{(GetFixedArrayTypeForProperty(returnParameter) == "StructFixedArray" ? $", {returnParameter.Size}" : "")}, {returnParameter.ArrayDim}" : "")}) {{ Allocated = true }};");
                            }
                            else {
                                writer.WriteLine($"{P(2)}return new(_{parameterName}Ptr{(returnParameter.ArrayDim > 1 ? $"{(GetFixedArrayTypeForProperty(returnParameter) == "StructFixedArray" ? $", {returnParameter.Size}" : "")}, {returnParameter.ArrayDim}" : "")}) {{ Allocated = true }};");
                            }
                        }
                    }
                }
            }
            writer.WriteLine($"{P(1)}}}");
        }
    }

    public static void WriteStructs(StreamWriter writer, List<Struct> structs) {
        for (var i = 0; i < structs.Count; i++) {
            var @struct = structs[i];
            if (i != 0)
                writer.WriteLine();

            writer.WriteLine($"{P(1)}// {@struct.FullName}");
            WriteSizeInformation(writer, @struct.Size, @struct.BaseStruct != null ? @struct.BaseStruct.Size : 0, 1);
            var structName = $"F{GetShortName(@struct.FullName)}";
            writer.WriteLine($"{P(1)}public unsafe class {structName} : {GetStructBase(@struct)} {{");
            writer.WriteLine($"{P(2)}public {structName}() {{");
            writer.WriteLine($"{P(3)}Pointer = Marshal.AllocHGlobal({@struct.Size});");
            writer.WriteLine($"{P(3)}Unsafe.InitBlockUnaligned((void*)Pointer, 0, {@struct.Size});");
            writer.WriteLine($"{P(3)}Allocated = true;");
            writer.WriteLine($"{P(2)}}}");
            writer.WriteLine($"{P(2)}public {structName}(nint pointer) : base(pointer) {{ }}");
            if (@struct.Properties.Count > 0) {
                writer.WriteLine();
                WriteProperties(writer, @struct.Properties, @struct.BaseStruct != null ? @struct.BaseStruct.Size : 0, @struct.Size, 1);
            }
            writer.WriteLine($"{P(1)}}}");
        }
    }

    public static void WriteEnums(StreamWriter writer, List<Enum> enums) {
        for (var i = 0; i < enums.Count; i++) {
            var @enum = enums[i];
            if (i != 0)
                writer.WriteLine();

            writer.WriteLine($"{P(1)}// {@enum.FullName}");
            writer.WriteLine($"{P(1)}public enum {GetShortName(@enum.FullName)} : byte {{");
            for (var j = 0; j < @enum.Values.Count; j++) {
                writer.Write($"{P(2)}{@enum.Values[j]} = {j}");
                if (j + 1 != @enum.Values.Count)
                    writer.WriteLine(',');
                else
                    writer.WriteLine();
            }
            writer.WriteLine($"{P(1)}}}");
        }
    }

    public static void WriteStaticClassGetter(StreamWriter writer, string fullName) {
        writer.WriteLine($"{P(1)}private static UClass _staticClass;");
        writer.WriteLine($"{P(1)}public static UClass StaticClass {{");
        writer.WriteLine($"{P(2)}get {{");
        writer.WriteLine($"{P(3)}_staticClass ??= FindClass(\"{fullName}\");");
        writer.WriteLine($"{P(3)}return _staticClass;");
        writer.WriteLine($"{P(2)}}}");
        writer.WriteLine($"{P(1)}}}");
    }

    public static bool IsPropertyUnmanaged(Property property) {
        switch (property) {
            case QWordProperty:
            case IntProperty:
            case FloatProperty:
            case BoolProperty:
            case ByteProperty:
            case MapProperty: // Unimplemented
                return true;
            case StructProperty structProperty:
                if (structProperty.Struct.FullName == "ScriptStruct Core.Object.Pointer") return true;
                return false;
            default:
                return false;
        }
    }

    public static string GetOptionalParamDefaultValue(Property property) {
        switch (property) {
            case FloatProperty:
            case ByteProperty:
            case QWordProperty:
            case IntProperty:
                return "0";
            case BoolProperty:
                return "false";
            case StrProperty:
            case NameProperty:
            case ClassProperty:
            case ObjectProperty:
            case InterfaceProperty:
            case DelegateProperty:
            case StructProperty:
            case ArrayProperty:
                return "null";
            default:
                Logger.ErrorLine($"Found unknown property type in default values! {property.GetType().Name}");
                return "UNKNOWN_PROPERTY_TYPE";
        }
    }

    public static string GetPropertyType(Property property, int depth = 0) {
        switch (property) {
            case QWordProperty:
                return "ulong";
            case IntProperty:
                return "int";
            case FloatProperty:
                return "float";
            case BoolProperty:
                return "bool";
            case NameProperty:
                return "FName";
            case StrProperty:
                return "FString";
            case DelegateProperty:
                return "FScriptDelegate";
            case MapProperty:
                return "/* TMap<> */ nint"; // Unimplemented
            case InterfaceProperty interfaceProperty:
                return $"TInterface<{interfaceProperty.InterfaceClass.Prefix}{GetShortName(interfaceProperty.InterfaceClass.FullName)}>";
            case ByteProperty byteProperty:
                if (byteProperty.Enum == null) return "byte";
                return GetPropertyTypeWithDependency(byteProperty, depth);
            case StructProperty structProperty:
                if (structProperty.Struct.FullName == "ScriptStruct Core.Object.Pointer") return "nint";
                return GetPropertyTypeWithDependency(structProperty, depth);
            case ObjectProperty objectProperty:
                return $"{objectProperty.PropertyClass.Prefix}{GetShortName(objectProperty.PropertyClass.FullName)}";
            case ArrayProperty arrayProperty:
                return $"{GetTArrayTypeForProperty(arrayProperty.Element)}<{GetPropertyType(arrayProperty.Element, depth + 1)}>";
            default:
                Logger.ErrorLine($"Found unknown property type! {property.GetType().Name}");
                return "UNKNOWN_PROPERTY_TYPE";
        }
    }

    public static string GetTArrayTypeForProperty(Property property) {
        switch (property) {
            case FloatProperty:
            case IntProperty:
            case QWordProperty:
            case ByteProperty:
            case BoolProperty:
                return "UnmanagedTArray";
            case StrProperty:
            case NameProperty:
            case DelegateProperty:
                return "StructTArray";
            case ClassProperty:
            case ObjectProperty:
            case InterfaceProperty:
                return "PointerTArray";
            case StructProperty structProperty:
                if (structProperty.Struct.FullName == "ScriptStruct Core.Object.Pointer") return "UnmanagedTArray";
                return "StructTArray";
            default:
                Logger.ErrorLine($"Found unknown property type in TArrays! {property.GetType().Name}");
                return "UNKNOWN_TARRAY_TYPE";
        }
    }

    public static string GetFixedArrayTypeForProperty(Property property) {
        switch (property) {
            case FloatProperty:
            case IntProperty:
            case QWordProperty:
            case ByteProperty:
            case BoolProperty:
                return "UnmanagedFixedArray";
            case StrProperty:
            case NameProperty:
            case DelegateProperty:
                return "StructFixedArray";
            case ClassProperty:
            case ObjectProperty:
            case InterfaceProperty:
                return "PointerFixedArray";
            case StructProperty structProperty:
                if (structProperty.Struct.FullName == "ScriptStruct Core.Object.Pointer") return "UnmanagedFixedArray";
                return "StructFixedArray";
            default:
                Logger.ErrorLine($"Found unknown property type in fixed arrays! {property.GetType().Name}");
                return "UNKNOWN_FIXEDARRAY_TYPE";
        }
    }

    public static string P(int size) => size == 0 ? "" : new string(' ', size * DefaultPaddingSize);

    public static string ClearConstant(string @const) => $"{@const.Replace("\"", "").Replace("\'", "")}";

    public static string GetShortName(string fullName) {
        var dotIndex = fullName.LastIndexOf('.');
        return dotIndex == -1 ? fullName : fullName[(dotIndex + 1)..];
    }

    public static string GetStructBase(Struct @struct) {
        if (@struct.BaseStruct == null) return "BaseObject";

        var baseStructName = $"F{GetShortName(@struct.BaseStruct.FullName)}";

        if (@struct.BaseStruct.Outer.FullName != @struct.Outer.FullName)
            return $"{@struct.BaseStruct.Outer.Prefix}{GetShortName(@struct.BaseStruct.Outer.FullName)}.{baseStructName}";
        else return baseStructName;
    }

    public static string GetPropertyTypeWithDependency(Property property, int depth) {
        switch (property) {
            case ByteProperty byteProperty:
                var enumName = GetShortName(byteProperty.Enum.FullName);

                var bytePropertyActualOuter = byteProperty.Outer;
                for (var i = 0; i < depth; i++)
                    bytePropertyActualOuter = bytePropertyActualOuter.Outer;

                return byteProperty.Enum.Outer == bytePropertyActualOuter
                    ? enumName
                    : $"{byteProperty.Enum.Outer.Prefix}{GetShortName(byteProperty.Enum.Outer.FullName)}.{enumName}";

            case StructProperty structProperty:
                var structName = $"F{GetShortName(structProperty.Struct.FullName)}";
                var structOuterName = GetShortName(structProperty.Struct.Outer.FullName);
                if (structOuterName == "Object") return structName;

                var structPropertyActualOuter = structProperty.Outer;
                for (var i = 0; i < depth; i++)
                    structPropertyActualOuter = structPropertyActualOuter.Outer;

                return structProperty.Struct.Outer == structPropertyActualOuter
                    ? structName
                    : $"{structProperty.Struct.Outer.Prefix}{structOuterName}.{structName}";
            default:
                Debugger.Break();
                return "";
        }
    }
}
