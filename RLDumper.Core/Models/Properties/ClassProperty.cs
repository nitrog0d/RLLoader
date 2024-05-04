using RLDumper.Core.Classes;
using RLDumper.Core.Classes.Properties;

namespace RLDumper.Core.Models.Properties;

public class ClassProperty : ObjectProperty {
    public Class MetaClass { get; set; }

    public static ClassProperty BuildClassProperty(UClassProperty property) {
        return new() {
            PropertyClass = Class.BuildClass(property.PropertyClass.As<UClass>()),
            MetaClass = Class.BuildClass(property.MetaClass)
        };
    }
}
