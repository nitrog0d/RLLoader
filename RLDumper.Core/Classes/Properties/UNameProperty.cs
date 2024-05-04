namespace RLDumper.Core.Classes.Properties;

public class UNameProperty : UProperty {
    private static UClass _staticClass;
    public static new UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class Core.NameProperty");
            return _staticClass;
        }
    }
}
