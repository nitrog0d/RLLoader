using RLDumper.Core.Classes.Properties;

namespace RLDumper.Core.Models.Properties;

public class InterfaceProperty : Property {
    public Class InterfaceClass { get; set; }

    public static InterfaceProperty BuildInterfaceProperty(UInterfaceProperty property) {
        return new() {
            InterfaceClass = Class.BuildClass(property.InterfaceClass)
        };
    }
}
