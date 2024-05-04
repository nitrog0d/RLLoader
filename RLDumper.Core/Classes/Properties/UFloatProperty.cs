namespace RLDumper.Core.Classes.Properties;

public class UFloatProperty : UProperty {
    private static UClass _staticClass;
    public static new UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class Core.FloatProperty");
            return _staticClass;
        }
    }
}
