namespace RLDumper.Core.Classes;

public class UScriptStruct : UStruct {
    public UScriptStruct() : base() { }
    public UScriptStruct(nint address) : base(address) { }

    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class Core.ScriptStruct");
            return _staticClass;
        }
    }
}
