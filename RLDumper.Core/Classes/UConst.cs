namespace RLDumper.Core.Classes;

public class UConst : UField {
    public UConst() : base() { }
    public UConst(nint address) : base(address) { }

    public FString Value => new(Address + 112);

    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class Core.Const");
            return _staticClass;
        }
    }
}
