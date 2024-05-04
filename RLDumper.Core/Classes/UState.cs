namespace RLDumper.Core.Classes;

public class UState : UStruct {
    public UState() : base() { }
    public UState(nint address) : base(address) { }

    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class Core.State");
            return _staticClass;
        }
    }
}
