using RLDumper.Core.Classes.Properties;

namespace RLDumper.Core.Models.Properties;

public class DelegateProperty : Property {
    public static DelegateProperty BuildDelegateProperty(UDelegateProperty property) => new();
}
