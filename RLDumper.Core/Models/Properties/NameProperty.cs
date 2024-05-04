using RLDumper.Core.Classes.Properties;

namespace RLDumper.Core.Models.Properties;

public class NameProperty : Property {
    public static NameProperty BuildNameProperty(UNameProperty property) => new();
}
