namespace RLLoader.Shared;

public static class PatternScanner {
    public struct PatternByte(byte value, bool wildcard = false) {
        public static PatternByte EMPTY = new(0, true);

        public byte Value = value;
        public bool Wildcard = wildcard;
    };

    public static int FindPattern(string stringPattern, byte[] data, int startIndex = 0) {
        var pattern = ParsePatternString(stringPattern);

        // Search every possible position within the data.
        // TODO: This could be optimized a lot.
        for (var i = startIndex; i < data.Length; i++) {
            var found = true;

            // Ignore if the first byte of the pattern does not match.
            if (data[i] != pattern[0].Value)
                continue;

            // Compare with every byte in the pattern.
            for (var j = 0; j < pattern.Length; j++) {
                // We ignore empty bytes (aka wildcards).
                if (pattern[j].Wildcard)
                    continue;

                // If the values don't match, this can't be the pattern we are looking for ...
                if (pattern[j].Value != data[i + j]) {
                    found = false;
                    break;
                }
            }

            // If we haven't found the pattern at this index, continue with the next index.
            if (!found)
                continue;

            // If we reach here without ever having set 'found' to 'false', we must have found the pattern.
            return i;
        }

        return -1;
    }

    private static PatternByte[] ParsePatternString(string pattern) {
        var patternBytes = new List<PatternByte>();

        foreach (var sByte in pattern.Split(' '))
            patternBytes.Add((sByte is "?" or "??") ? PatternByte.EMPTY : new PatternByte(Convert.ToByte(sByte, 16)));

        return patternBytes.ToArray();
    }
}
