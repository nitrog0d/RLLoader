using RLDumper.Core.Classes;

namespace RLDumper.Core.Models;

public class Const : Object {
    public static Dictionary<string, Const> AllConsts { get; set; } = [];
    public string Value { get; set; }

    public static Const BuildConst(UConst @const) {
        var fullName = @const.GetFullName();

        if (AllConsts.TryGetValue(fullName, out var foundConst))
            return foundConst;

        var newConst = new Const() {
            FullName = @const.GetFullName(),
            Value = @const.Value.ToString()
        };

        AllConsts.Add(fullName, newConst);

        return newConst;
    }
}
