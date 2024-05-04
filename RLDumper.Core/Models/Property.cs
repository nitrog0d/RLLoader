using RLDumper.Core.Classes;
using RLDumper.Core.Classes.Properties;
using RLDumper.Core.Models.Properties;
using RLLoader.Shared;

namespace RLDumper.Core.Models;

public class Property : Object {
    public static Dictionary<string, Property> AllProperties { get; set; } = [];

    public int ArrayDim { get; set; }
    public int Size { get; set; }
    public ulong Flags { get; set; }
    public int Offset { get; set; }


    public static Property BuildProperty(UProperty property) {
        var fullName = property.GetFullName();

        if (AllProperties.TryGetValue(fullName, out var foundProperty)) return foundProperty;

        Property newProperty;

        if (property.IsA<UStructProperty>()) newProperty = StructProperty.BuildStructProperty(property.As<UStructProperty>());
        else if (property.IsA<UClassProperty>()) newProperty = ClassProperty.BuildClassProperty(property.As<UClassProperty>());
        else if (property.IsA<UObjectProperty>()) newProperty = ObjectProperty.BuildObjectProperty(property.As<UObjectProperty>());
        else if (property.IsA<UComponentProperty>()) newProperty = ComponentProperty.BuildComponentProperty(property.As<UComponentProperty>());
        else if (property.IsA<UFloatProperty>()) newProperty = FloatProperty.BuildFloatProperty(property.As<UFloatProperty>());
        else if (property.IsA<UBoolProperty>()) newProperty = BoolProperty.BuildBoolProperty(property.As<UBoolProperty>());
        else if (property.IsA<UIntProperty>()) newProperty = IntProperty.BuildIntProperty(property.As<UIntProperty>());
        else if (property.IsA<UStrProperty>()) newProperty = StrProperty.BuildStrProperty(property.As<UStrProperty>());
        else if (property.IsA<UQWordProperty>()) newProperty = QWordProperty.BuildQWordProperty(property.As<UQWordProperty>());
        else if (property.IsA<UNameProperty>()) newProperty = NameProperty.BuildNameProperty(property.As<UNameProperty>());
        else if (property.IsA<UArrayProperty>()) newProperty = ArrayProperty.BuildArrayProperty(property.As<UArrayProperty>());
        else if (property.IsA<UByteProperty>()) newProperty = ByteProperty.BuildByteProperty(property.As<UByteProperty>());
        else if (property.IsA<UInterfaceProperty>()) newProperty = InterfaceProperty.BuildInterfaceProperty(property.As<UInterfaceProperty>());
        else if (property.IsA<UDelegateProperty>()) newProperty = DelegateProperty.BuildDelegateProperty(property.As<UDelegateProperty>());
        else if (property.IsA<UMapProperty>()) newProperty = MapProperty.BuildMapProperty(property.As<UMapProperty>());
        else {
            Logger.ErrorLine($"UNKNOWN PROPERTY TYPE: {property.GetFullName()}", "RLDumper");
            return null;
        }

        newProperty.FullName = property.GetFullName();
        if (property.Outer != null) newProperty.Outer = BuildObject(property.Outer);
        newProperty.ArrayDim = property.ArrayDim;
        newProperty.Size = property.ElementSize;
        newProperty.Flags = property.PropertyFlags;
        newProperty.Offset = property.Offset;

        AllProperties.Add(fullName, newProperty);

        return newProperty;
    }
}
