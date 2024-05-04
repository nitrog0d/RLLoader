namespace RLDumper.Core.Classes.Properties;

public class UComponentProperty : UObjectProperty {
    private static UClass _staticClass;
    public static new UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class Core.ComponentProperty");
            return _staticClass;
        }
    }
}
