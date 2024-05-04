using RLDumper.Core.Classes;

namespace RLDumper.Core.Models;

public class Object {
    public static readonly Dictionary<string, Object> AllObjects = [];

    public string Prefix { get; set; }
    public string FullName { get; set; }
    public Object Outer { get; set; }

    public static Object BuildObject(UObject @object) {
        var fullName = @object.GetFullName();

        if (AllObjects.TryGetValue(fullName, out var foundObject))
            return foundObject;

        var newObject = new Object() {
            Prefix = @object.GetPrefix(),
            FullName = fullName
        };

        AllObjects.Add(fullName, newObject);

        if (@object.Outer != null) newObject.Outer = BuildObject(@object.Outer);

        return newObject;
    }
}
