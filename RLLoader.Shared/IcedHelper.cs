using Iced.Intel;

namespace RLLoader.Shared;

public static class IcedHelper {
    public static Decoder DecoderForAddress(byte[] buffer, nint codeStart, int lengthLimit = 1000) {
        if (codeStart == nint.Zero)
            throw new NullReferenceException(nameof(codeStart));

        var stream = new MemoryStream(buffer, (int)codeStart, lengthLimit);
        var codeReader = new StreamCodeReader(stream);
        var decoder = Decoder.Create(nint.Size * 8, codeReader);
        decoder.IP = (ulong)codeStart;

        return decoder;
    }

    public static nint GetMovAtAddress(byte[] buffer, nint address) {
        var decoder = DecoderForAddress(buffer, address, 7);
        return (nint)decoder.Decode().NearBranch64;
    }
}
