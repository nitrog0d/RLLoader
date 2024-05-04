namespace RLDumper.Core.Classes.Properties;

public class UDelegateProperty : UProperty {
    private static UClass _staticClass;
    public static new UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class Core.DelegateProperty");
            return _staticClass;
        }
    }
}
