namespace RLLoader.Shared;

public static class Offsets {
    private static nint _gNamesRva;
    public static nint GetGNamesRVA(byte[] data) {
        if (_gNamesRva != nint.Zero) return _gNamesRva;

        // Function that initializes engine names, has a bunch of strings like "None", "ByteProperty", "IntProperty", etc...
        var foundGNames = PatternScanner.FindPattern("48 8B 3D ?? ?? ?? ?? 48 89 05 ?? ?? ?? ?? 48 89 05 ?? ?? ?? ?? 48 8B 05 ?? ?? ?? ??", data);

        _gNamesRva = IcedHelper.GetMovAtAddress(data, foundGNames + 7);

        return _gNamesRva;
    }

    private static nint _gObjectsRva;
    public static nint GetGObjectsRVA(byte[] data) {
        if (_gObjectsRva != nint.Zero) return _gObjectsRva;

        // Not sure what function this is, but it seemed like it'd be stable
        var foundGObjects = PatternScanner.FindPattern("48 8B 15 ?? ?? ?? ?? 48 8B 44 CA 08", data);

        _gObjectsRva = IcedHelper.GetMovAtAddress(data, foundGObjects);

        return _gObjectsRva;
    }
}
