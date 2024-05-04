namespace RLDumper.Core.Classes;

public class FNameEntry : BaseObject {
    public FNameEntry() : base() { }
    public FNameEntry(nint address) : base(address) { }

    public ulong Flags => RLDumper.ReadMemory<ulong>(Address);

    public int Index => RLDumper.ReadMemory<int>(Address + 8);

    public unsafe string Name => RLDumper.ReadString(Address + 24, 1024);
}
