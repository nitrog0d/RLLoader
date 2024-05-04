namespace RLDumper.Core.Classes;

public class FName : BaseObject {
    public FName() : base() { }
    public FName(nint address) : base(address) { }

    public int Index => RLDumper.ReadMemory<int>(Address);

    public int Number => RLDumper.ReadMemory<int>(Address + 4);

    private static readonly Dictionary<int, string> NameCache = [];
    public override string ToString() {
        var index = Index;

        if (!NameCache.TryGetValue(index, out var name)) {
            var nameOut = RLDumper.GNames[index];
            if (nameOut == null) name = "None";
            else name = nameOut.Name;

            NameCache.Add(index, name);
        }

        var number = Number;

        return number > 0 ? $"{name}_{number}" : name;
    }
}
