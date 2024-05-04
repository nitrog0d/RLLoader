namespace RLDumper.Core.Classes.Properties;

public class UInterfaceProperty : UProperty {
    private static UClass _staticClass;

    public UClass InterfaceClass {
        get {
            var address = RLDumper.ReadMemory<nint>(Address + 200);
            return address == nint.Zero ? null : new(address);
        }
    }

    public static new UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class Core.InterfaceProperty");
            return _staticClass;
        }
    }
}
