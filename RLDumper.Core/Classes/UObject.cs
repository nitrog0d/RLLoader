using System.Diagnostics.CodeAnalysis;

namespace RLDumper.Core.Classes;

public class UObject : BaseObject {
    public UObject() : base() { }
    public UObject(nint address) : base(address) { }

    public int ObjectInternalInteger => RLDumper.ReadMemory<int>(Address + 56);
    public int NetIndex => RLDumper.ReadMemory<int>(Address + 60);

    public UObject Outer {
        get {
            var address = RLDumper.ReadMemory<nint>(Address + 64);
            return address == nint.Zero ? null : new(address);
        }
    }

    public FName Name => new(Address + 72);

    public UClass Class {
        get {
            var address = RLDumper.ReadMemory<nint>(Address + 80);
            return address == nint.Zero ? null : new(address);
        }
    }

    public UObject ObjectArchetype {
        get {
            var address = RLDumper.ReadMemory<nint>(Address + 88);
            return address == nint.Zero ? null : new(address);
        }
    }

    public string GetPrefix() {
        if (IsA<UClass>()) {
            for (var uClass = As<UClass>(); uClass != null; uClass = uClass.SuperField?.As<UClass>()) {
                var className = uClass.GetName();

                if (className == "Actor")
                    return "A";
                else if (className == "Object")
                    return "U";
            }
        }
        return "F";
    }

    public string GetName() => Name.ToString();

    public string GetFullName() {
        var name = GetName();

        for (var outer = Outer; outer != null; outer = outer.Outer) {
            name = $"{outer.GetName()}.{name}";
        }

        name = $"{Class.GetName()} {name}";

        return name;
    }

    public bool IsA<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)] T>() where T : UObject {
        var staticClass = (UClass)typeof(T).GetProperty("StaticClass").GetValue(null);
        return IsA(staticClass);
    }

    public bool IsA(UClass @class) {
        for (var superClass = Class; superClass != null; superClass = superClass.SuperField?.As<UClass>()) {
            if (superClass.Address == @class.Address)
                return true;
        }

        return false;
    }

    public UObject GetPackage() {
        UObject package = null;

        for (var outer = Outer; outer != null; outer = outer.Outer) {
            package = outer;
        }

        return package;
    }

    public static UClass FindClass(string fullName) {
        foreach (var uObject in RLDumper.GObjects) {
            if (uObject == null) continue;

            if (uObject.GetFullName() == fullName) {
                return uObject.As<UClass>();
            }
        }

        return null;
    }
}
