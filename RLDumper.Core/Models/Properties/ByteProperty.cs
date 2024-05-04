using RLDumper.Core.Classes.Properties;

namespace RLDumper.Core.Models.Properties;

public class ByteProperty : Property {
    public Enum Enum { get; set; }

    public static ByteProperty BuildByteProperty(UByteProperty property) {
        return new() {
            Enum = property.Enum != null ? Enum.BuildEnum(property.Enum) : null
        };
    }
}
