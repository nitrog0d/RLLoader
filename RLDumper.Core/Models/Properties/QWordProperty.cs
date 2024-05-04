using RLDumper.Core.Classes.Properties;

namespace RLDumper.Core.Models.Properties;

public class QWordProperty : Property {
    public static QWordProperty BuildQWordProperty(UQWordProperty property) => new();
}
