namespace RLDumper.Core.Classes.Properties;

public class UArrayProperty : UProperty {
    public UProperty Inner {
        get {
            var address = RLDumper.ReadMemory<nint>(Address + 200);
            return address == nint.Zero ? null : new(address);
        }
    }

    private static UClass _staticClass;
    public static new UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class Core.ArrayProperty");
            return _staticClass;
        }
    }
}
