using RLDumper.Core.Classes.Properties;

namespace RLDumper.Core.Models.Properties;

public class ObjectProperty : Property {
    public Class PropertyClass { get; set; }

    public static ObjectProperty BuildObjectProperty(UObjectProperty property) {
        return new() {
            PropertyClass = Class.BuildClass(property.PropertyClass)
        };
    }
}
