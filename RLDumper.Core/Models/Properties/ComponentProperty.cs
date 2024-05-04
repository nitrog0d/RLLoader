using RLDumper.Core.Classes;
using RLDumper.Core.Classes.Properties;

namespace RLDumper.Core.Models.Properties;

public class ComponentProperty : ObjectProperty {
    public static ComponentProperty BuildComponentProperty(UComponentProperty property) {
        return new() {
            PropertyClass = Class.BuildClass(property.PropertyClass.As<UClass>())
        };
    }
}
