namespace RLDumper.Core.Classes;

public class FString : UnmanagedTArray<char> {
    public FString() : base() { }
    public FString(nint address) : base(address) { }

    public override string ToString() => RLDumper.ReadString(RLDumper.ReadMemory<nint>(Address), Count);
}
