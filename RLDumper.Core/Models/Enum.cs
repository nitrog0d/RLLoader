using RLDumper.Core.Classes;

namespace RLDumper.Core.Models;

public class Enum : Object {
    public static Dictionary<string, Enum> AllEnums { get; set; } = [];

    public List<string> Values { get; set; } = [];

    public static Enum BuildEnum(UEnum @enum) {
        var fullName = @enum.GetFullName();

        if (AllEnums.TryGetValue(fullName, out var foundEnum))
            return foundEnum;

        var newEnum = new Enum() {
            FullName = @enum.GetFullName(),
            Outer = @enum.Outer != null ? BuildObject(@enum.Outer) : null,
            Values = @enum.Names.Select(x => x.ToString()).ToList()
        };

        AllEnums.Add(fullName, newEnum);

        return newEnum;
    }
}
