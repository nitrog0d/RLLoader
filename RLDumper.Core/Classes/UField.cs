namespace RLDumper.Core.Classes;

public class UField : UObject {
    public UField() : base() { }
    public UField(nint address) : base(address) { }

    public UField Next {
        get {
            var address = RLDumper.ReadMemory<nint>(Address + 96);
            return address == nint.Zero ? null : new(address);
        }
    }
}
