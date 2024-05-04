using RLDumper.Core.Classes.Properties;

namespace RLDumper.Core.Models.Properties;

public class FloatProperty : Property {
    public static FloatProperty BuildFloatProperty(UFloatProperty property) => new();
}
