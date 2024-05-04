using RLDumper.Core.Classes.Properties;

namespace RLDumper.Core.Models.Properties;

public class StrProperty : Property {
    public static StrProperty BuildStrProperty(UStrProperty property) => new();
}
