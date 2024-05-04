namespace RLDumper.Core.Classes;

public class UClass : UState {
    public UClass() : base() { }
    public UClass(nint address) : base(address) { }

    public ulong ClassFlags => RLDumper.ReadMemory<ulong>(Address + 400);

    private static UClass _staticClass;
    public static new UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class Core.Class");
            return _staticClass;
        }
    }
}
