namespace RLDumper.Core.Classes;

public class UStruct : UField {
    public UStruct() : base() { }
    public UStruct(nint address) : base(address) { }

    public UField SuperField {
        get {
            var address = RLDumper.ReadMemory<nint>(Address + 128);
            return address == nint.Zero ? null : new(address);
        }
    }

    public UField Children {
        get {
            var address = RLDumper.ReadMemory<nint>(Address + 136);
            return address == nint.Zero ? null : new(address);
        }
    }

    public int PropertiesSize => RLDumper.ReadMemory<int>(Address + 144);
}
