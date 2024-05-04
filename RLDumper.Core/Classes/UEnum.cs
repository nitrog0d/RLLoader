namespace RLDumper.Core.Classes;

public class UEnum : UField {
    public UEnum() : base() { }
    public UEnum(nint address) : base(address) { }

    public ObjectTArray<FName> Names => new(Address + 112);

    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class Core.Enum");
            return _staticClass;
        }
    }
}
