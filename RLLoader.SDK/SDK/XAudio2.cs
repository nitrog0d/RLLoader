using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace RLLoader.SDK;

#pragma warning disable CS0108, CS0114

// Class XAudio2.XAudio2Device
// 0xBC (0x3A4 - 0x460)
// (Config | Transient | Native | Hidden | Intrinsic)
public unsafe partial class UXAudio2Device : UAudioDevice {
    public UXAudio2Device() { }
    public UXAudio2Device(nint pointer) : base(pointer) { }


    // MISSED OFFSET: 0xBC


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class XAudio2.XAudio2Device");
            return _staticClass;
        }
    }
}

#pragma warning restore CS0108, CS0114
