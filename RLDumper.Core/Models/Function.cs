using RLDumper.Core.Classes;

namespace RLDumper.Core.Models;

public class Function : Object {
    public static Dictionary<string, Function> AllFunctions { get; set; } = [];

    public ulong Flags { get; set; }
    public ushort iNative {  get; set; }
    public long RVA { get; set; }
    public List<Property> Parameters { get; set; } = [];

    public static Function BuildFunction(UFunction function) {
        var fullName = function.GetFullName();

        if (AllFunctions.TryGetValue(fullName, out var foundFunction))
            return foundFunction;

        var newFunction = new Function() {
            FullName = function.GetFullName(),
            Flags = function.FunctionFlags,
            iNative = function.iNative,
            RVA = function.Func - RLDumper.BaseAddress
        };

        AllFunctions.Add(fullName, newFunction);

        for (var property = function.Children?.As<UProperty>(); property != null; property = property.Next?.As<UProperty>())
            newFunction.Parameters.Add(Property.BuildProperty(property));

        return newFunction;
    }
}
