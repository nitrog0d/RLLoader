using RLDumper.Core.Classes;


namespace RLDumper.Core.Models;

public class Struct : Object {
    public static Dictionary<string, Struct> AllStructs { get; set; } = [];

    public Struct BaseStruct { get; set; }
    public List<Property> Properties { get; set; } = [];
    public int Size { get; set; }

    public static Struct BuildStruct(UStruct @struct) {
        var fullName = @struct.GetFullName();

        if (AllStructs.TryGetValue(fullName, out var foundStruct))
            return foundStruct;

        var newStruct = new Struct() {
            FullName = fullName,
            Outer = @struct.Outer != null ? BuildObject(@struct.Outer) : null,
            Size = @struct.PropertiesSize
        };

        AllStructs.Add(fullName, newStruct);

        newStruct.BaseStruct = @struct.SuperField != null ? BuildStruct(@struct.SuperField.As<UStruct>()) : null;

        for (var property = @struct.Children?.As<UProperty>(); property != null; property = property.Next?.As<UProperty>()) {
            newStruct.Properties.Add(Property.BuildProperty(property));
        }

        return newStruct;
    }
}
