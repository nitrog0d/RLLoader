namespace RLDumper.Core.Classes.Properties;

public class UBoolProperty : UProperty {
    public ulong BitMask => RLDumper.ReadMemory<ulong>(Address + 200);

    private static UClass _staticClass;
    public static new UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class Core.BoolProperty");
            return _staticClass;
        }
    }
}
