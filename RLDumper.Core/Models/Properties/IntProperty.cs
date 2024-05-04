using RLDumper.Core.Classes.Properties;

namespace RLDumper.Core.Models.Properties;

public class IntProperty : Property {
    public static IntProperty BuildIntProperty(UIntProperty property) => new();
}
