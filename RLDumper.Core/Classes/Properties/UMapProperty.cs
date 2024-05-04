namespace RLDumper.Core.Classes.Properties;

public class UMapProperty : UProperty {
    public UProperty Key {
        get {
            var address = RLDumper.ReadMemory<nint>(Address + 200);
            return address == nint.Zero ? null : new(address);
        }
    }

    public UProperty Value {
        get {
            var address = RLDumper.ReadMemory<nint>(Address + 208);
            return address == nint.Zero ? null : new(address);
        }
    }

    private static UClass _staticClass;
    public static new UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class Core.MapProperty");
            return _staticClass;
        }
    }
}
