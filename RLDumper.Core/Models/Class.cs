using RLDumper.Core.Classes;

namespace RLDumper.Core.Models;

public class Class : Object {
    public static Dictionary<string, Class> AllClasses { get; set; } = [];

    public int Size { get; set; }
    public ulong Flags { get; set; }
    public Class BaseClass { get; set; }
    public List<Property> Properties { get; set; } = [];
    public List<Function> Functions { get; set; } = [];
    public List<Enum> Enums { get; set; } = [];
    public List<Struct> Structs { get; set; } = [];
    public List<Const> Constants { get; set; } = [];

    public static Class BuildClass(UClass @class) {
        var fullName = @class.GetFullName();

        if (AllClasses.TryGetValue(fullName, out var foundClass))
            return foundClass;

        var newClass = new Class {
            Prefix = @class.GetPrefix(),
            FullName = fullName,
            Outer = @class.Outer != null ? BuildObject(@class.Outer) : null,
            Size = @class.PropertiesSize,
            Flags = @class.ClassFlags
        };

        AllClasses.Add(fullName, newClass);

        if (@class.SuperField != null) newClass.BaseClass = BuildClass(@class.SuperField.As<UClass>());

        for (var property = @class.Children?.As<UProperty>(); property != null; property = property.Next?.As<UProperty>()) {
            if (property.IsA<UFunction>())
                newClass.Functions.Add(Function.BuildFunction(property.As<UFunction>()));
            else if (property.IsA<UConst>())
                newClass.Constants.Add(Const.BuildConst(property.As<UConst>()));
            else if (property.IsA<UEnum>())
                newClass.Enums.Add(Enum.BuildEnum(property.As<UEnum>()));
            else if (property.IsA<UScriptStruct>())
                newClass.Structs.Add(Struct.BuildStruct(property.As<UStruct>()));
            else if (property.IsA<UState>())
                continue;
            else
                newClass.Properties.Add(Property.BuildProperty(property));
        }

        return newClass;
    }
}
