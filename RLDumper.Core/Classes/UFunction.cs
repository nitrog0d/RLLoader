namespace RLDumper.Core.Classes;

public class UFunction : UStruct {
    public UFunction() : base() { }
    public UFunction(nint address) : base(address) { }

    public ulong FunctionFlags => RLDumper.ReadMemory<ulong>(Address + 304);

    public ushort iNative => RLDumper.ReadMemory<ushort>(Address + 312);

    public nint Func => RLDumper.ReadMemory<nint>(Address + 344);

    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class Core.Function");
            return _staticClass;
        }
    }
}
