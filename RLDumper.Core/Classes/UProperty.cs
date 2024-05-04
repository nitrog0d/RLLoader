namespace RLDumper.Core.Classes;

public class UProperty : UField {
    public UProperty() : base() { }
    public UProperty(nint address) : base(address) { }

    public int ArrayDim => RLDumper.ReadMemory<int>(Address + 112);

    public int ElementSize => RLDumper.ReadMemory<int>(Address + 116);

    public ulong PropertyFlags => RLDumper.ReadMemory<ulong>(Address + 120);

    public int Offset => RLDumper.ReadMemory<int>(Address + 152);

    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class Core.Property");
            return _staticClass;
        }
    }
}
