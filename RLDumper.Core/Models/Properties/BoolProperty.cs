using RLDumper.Core.Classes.Properties;

namespace RLDumper.Core.Models.Properties;

public class BoolProperty : Property {
    public ulong BitMask { get; set; }

    public static BoolProperty BuildBoolProperty(UBoolProperty property) {
        return new() {
            BitMask = property.BitMask
        };
    }
}
