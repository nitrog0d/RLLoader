using RLDumper.Core.Classes.Properties;

namespace RLDumper.Core.Models.Properties;

public class MapProperty : Property {
    public Property Key { get; set; }
    public Property Value { get; set; }

    public static MapProperty BuildMapProperty(UMapProperty property) {
        return new() {
            Key = property.Key != null ? BuildProperty(property.Key) : null,
            Value = property.Value != null ? BuildProperty(property.Value) : null
        };
    }
}
