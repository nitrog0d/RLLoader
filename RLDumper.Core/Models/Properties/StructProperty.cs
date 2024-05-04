using RLDumper.Core.Classes.Properties;

namespace RLDumper.Core.Models.Properties;

public class StructProperty : Property {
    public Struct Struct { get; set; }

    public static StructProperty BuildStructProperty(UStructProperty property) {
        return new() {
            Struct = Struct.BuildStruct(property.Struct)
        };
    }
}
