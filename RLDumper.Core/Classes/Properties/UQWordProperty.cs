namespace RLDumper.Core.Classes.Properties;

public class UQWordProperty : UProperty {
    private static UClass _staticClass;
    public static new UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class Core.QWordProperty");
            return _staticClass;
        }
    }
}
