using RLDumper.Core.Classes.Properties;

namespace RLDumper.Core.Models.Properties;

public class ArrayProperty : Property {
    public Property Element { get; set; }

    public static ArrayProperty BuildArrayProperty(UArrayProperty property) {
        return new() {
            Element = BuildProperty(property.Inner)
        };
    }
}
