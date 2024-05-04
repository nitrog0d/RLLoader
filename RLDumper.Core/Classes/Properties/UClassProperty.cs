namespace RLDumper.Core.Classes.Properties;

public class UClassProperty : UObjectProperty {
    public UClass MetaClass {
        get {
            var address = RLDumper.ReadMemory<nint>(Address + 216);
            return address == nint.Zero ? null : new(address);
        }
    }

    private static UClass _staticClass;
    public static new UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class Core.ClassProperty");
            return _staticClass;
        }
    }
}
