namespace RLDumper.Core.Classes.Properties;

public class UStrProperty : UProperty {
    private static UClass _staticClass;
    public static new UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class Core.StrProperty");
            return _staticClass;
        }
    }
}
