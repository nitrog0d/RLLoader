namespace RLDumper.Core.Classes.Properties;

public class UIntProperty : UProperty {
    private static UClass _staticClass;
    public static new UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class Core.IntProperty");
            return _staticClass;
        }
    }
}
