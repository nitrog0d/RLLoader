using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace RLLoader.SDK;

#pragma warning disable CS0108, CS0114

// Class GFxUI.GFxEngine
// 0xC8 (0x60 - 0x128)
// (Compiled | Config | Parsed | Localized | Native)
public unsafe partial class UGFxEngine : UObject {
    public UGFxEngine() { }
    public UGFxEngine(nint pointer) : base(pointer) { }


    // ArrayProperty GFxUI.GFxEngine.GCReferences
    // 0x60 (0x10)
    // (Transient | NeedCtorLink)
    public StructTArray<FGCReference> GCReferences {
        get => new(Pointer + 96, 16);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 96), 16, 16);
    }

    // IntProperty GFxUI.GFxEngine.RefCount
    // 0x70 (0x4)
    // (Transient)
    public int RefCount {
        get => *(int*)(Pointer + 112);
        set => *(int*)(Pointer + 112) = value;
    }

    // MISSED OFFSET: 0x4

    // StructProperty GFxUI.GFxEngine.LoadingScreenInfo
    // 0x78 (0xA0)
    // (NeedCtorLink)
    public FLoadingMovieMapInfo LoadingScreenInfo {
        get => new(Pointer + 120);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 120), 160, 160);
    }

    // ArrayProperty GFxUI.GFxEngine.IgnoreWarningsThatStartWith
    // 0x118 (0x10)
    // (Config | NeedCtorLink)
    public StructTArray<FString> IgnoreWarningsThatStartWith {
        get => new(Pointer + 280, 16);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 280), 16, 16);
    }


    // Function GFxUI.GFxEngine.UpdateMovieLoadingInfo
    // 0xC25840
    // (Final | Native | Public | HasOutParams)
    public unsafe class UpdateMovieLoadingInfo_Parameters : BaseObject {
        public UpdateMovieLoadingInfo_Parameters() { }
        public UpdateMovieLoadingInfo_Parameters(nint pointer) : base(pointer) { }

        // StructProperty GFxUI.GFxEngine.UpdateMovieLoadingInfo.LoadingInfo
        // 0x0 (0xA0)
        // (Const | Param | OutParam | NeedCtorLink)
        public FLoadingMovieMapInfo LoadingInfo {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 160, 160);
        }
    }
    private static UFunction _ptrUpdateMovieLoadingInfo;
    public void UpdateMovieLoadingInfo(ref FLoadingMovieMapInfo LoadingInfo) {
        _ptrUpdateMovieLoadingInfo ??= FindFunction("Function GFxUI.GFxEngine.UpdateMovieLoadingInfo");

        var @params = stackalloc byte[160];
        System.Buffer.MemoryCopy((void*)LoadingInfo.Pointer, @params, 160, 160);

        _ptrUpdateMovieLoadingInfo.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrUpdateMovieLoadingInfo, @params);
        _ptrUpdateMovieLoadingInfo.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _LoadingInfoPtr = Marshal.AllocHGlobal(160);
        System.Buffer.MemoryCopy(@params, (void*)_LoadingInfoPtr, 160, 160);
        LoadingInfo = new(_LoadingInfoPtr) { Allocated = true };
    }

    // Function GFxUI.GFxEngine.Tick
    // 0x3750E0
    // (Event | Public)
    public unsafe class Tick_Parameters : BaseObject {
        public Tick_Parameters() { }
        public Tick_Parameters(nint pointer) : base(pointer) { }

        // FloatProperty GFxUI.GFxEngine.Tick.DeltaTime
        // 0x0 (0x4)
        // (Param)
        public float DeltaTime {
            get => *(float*)Pointer;
            set => *(float*)Pointer = value;
        }
    }
    private static UFunction _ptrTick;
    public void Tick(float DeltaTime) {
        _ptrTick ??= FindFunction("Function GFxUI.GFxEngine.Tick");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&DeltaTime, @params, 4, 4);

        ProcessEvent(_ptrTick, @params);
    }


    // ScriptStruct GFxUI.GFxEngine.LoadingMovieMapInfo
    // 0x9C
    public unsafe class FLoadingMovieMapInfo : BaseObject {
        public FLoadingMovieMapInfo() {
            Pointer = Marshal.AllocHGlobal(156);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 156);
            Allocated = true;
        }
        public FLoadingMovieMapInfo(nint pointer) : base(pointer) { }

        // ByteProperty GFxUI.GFxEngine.LoadingMovieMapInfo.InputType
        // 0x0 (0x1)
        public UEngineTypes.EInputPlatformType InputType {
            get => *(UEngineTypes.EInputPlatformType*)Pointer;
            set => *(UEngineTypes.EInputPlatformType*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StrProperty GFxUI.GFxEngine.LoadingMovieMapInfo.MapBaseName
        // 0x8 (0x10)
        // (NeedCtorLink)
        public FString MapBaseName {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // StrProperty GFxUI.GFxEngine.LoadingMovieMapInfo.PlaylistName
        // 0x18 (0x10)
        // (NeedCtorLink)
        public FString PlaylistName {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }

        // StrProperty GFxUI.GFxEngine.LoadingMovieMapInfo.MapVariantName
        // 0x28 (0x10)
        // (NeedCtorLink)
        public FString MapVariantName {
            get => new(Pointer + 40);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 40), 16, 16);
        }

        // StrProperty GFxUI.GFxEngine.LoadingMovieMapInfo.MaximumPlayerCounts
        // 0x38 (0x10)
        // (NeedCtorLink)
        public FString MaximumPlayerCounts {
            get => new(Pointer + 56);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 56), 16, 16);
        }

        // StrProperty GFxUI.GFxEngine.LoadingMovieMapInfo.ProtipMessage
        // 0x48 (0x10)
        // (NeedCtorLink)
        public FString ProtipMessage {
            get => new(Pointer + 72);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 72), 16, 16);
        }

        // StrProperty GFxUI.GFxEngine.LoadingMovieMapInfo.Language
        // 0x58 (0x10)
        // (NeedCtorLink)
        public FString Language {
            get => new(Pointer + 88);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 88), 16, 16);
        }

        // StrProperty GFxUI.GFxEngine.LoadingMovieMapInfo.BuildEdition
        // 0x68 (0x10)
        // (NeedCtorLink)
        public FString BuildEdition {
            get => new(Pointer + 104);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 104), 16, 16);
        }

        // StrProperty GFxUI.GFxEngine.LoadingMovieMapInfo.ProtipTitle
        // 0x78 (0x10)
        // (Const | Localized | NeedCtorLink)
        public FString ProtipTitle {
            get => new(Pointer + 120);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 120), 16, 16);
        }

        // ByteProperty GFxUI.GFxEngine.LoadingMovieMapInfo.WeatherVariant
        // 0x88 (0x1)
        public EWeatherVariant WeatherVariant {
            get => *(EWeatherVariant*)(Pointer + 136);
            set => *(EWeatherVariant*)(Pointer + 136) = value;
        }

        // MISSED OFFSET: 0x7

        // ObjectProperty GFxUI.GFxEngine.LoadingMovieMapInfo.LargeMapImage
        // 0x90 (0x8)
        public UTexture2D LargeMapImage {
            get {
                var pointer = *(nint*)(Pointer + 144);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 144) = value.Pointer;
        }

        // BoolProperty GFxUI.GFxEngine.LoadingMovieMapInfo.bSetBackgroundVisible
        // 0x98 (0x4)
        // Bitmask: 0x00000001
        public bool bSetBackgroundVisible {
            get => (*(uint*)(Pointer + 152) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 152) |= 0x1;
                else *(uint*)(Pointer + 152) &= ~(uint)0x1;
            }
        }

        // BoolProperty GFxUI.GFxEngine.LoadingMovieMapInfo.bDisplayGenericBackground
        // 0x98 (0x4)
        // Bitmask: 0x00000002
        public bool bDisplayGenericBackground {
            get => (*(uint*)(Pointer + 152) & 0x2) != 0;
            set {
                if (value) *(uint*)(Pointer + 152) |= 0x2;
                else *(uint*)(Pointer + 152) &= ~(uint)0x2;
            }
        }
    }

    // ScriptStruct GFxUI.GFxEngine.GCReference
    // 0x10
    public unsafe class FGCReference : BaseObject {
        public FGCReference() {
            Pointer = Marshal.AllocHGlobal(16);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 16);
            Allocated = true;
        }
        public FGCReference(nint pointer) : base(pointer) { }

        // ObjectProperty GFxUI.GFxEngine.GCReference.m_object
        // 0x0 (0x8)
        // (Const)
        public UObject m_object {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // IntProperty GFxUI.GFxEngine.GCReference.m_count
        // 0x8 (0x4)
        public int m_count {
            get => *(int*)(Pointer + 8);
            set => *(int*)(Pointer + 8) = value;
        }

        // IntProperty GFxUI.GFxEngine.GCReference.m_statid
        // 0xC (0x4)
        public int m_statid {
            get => *(int*)(Pointer + 12);
            set => *(int*)(Pointer + 12) = value;
        }
    }


    // Enum GFxUI.GFxEngine.EWeatherVariant
    public enum EWeatherVariant : byte {
        WeatherVariant_None = 0,
        WeatherVariant_Dawn = 1,
        WeatherVariant_Day = 2,
        WeatherVariant_Dusk = 3,
        WeatherVariant_Lab = 4,
        WeatherVariant_Night = 5,
        WeatherVariant_Rain = 6,
        WeatherVariant_Snow = 7,
        WeatherVariant_MAX = 8
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class GFxUI.GFxEngine");
            return _staticClass;
        }
    }
}

// Class GFxUI.GFxFSCmdHandler
// 0x0 (0x60 - 0x60)
// (Abstract | Compiled | Parsed | Native)
public unsafe partial class UGFxFSCmdHandler : UObject {
    public UGFxFSCmdHandler() { }
    public UGFxFSCmdHandler(nint pointer) : base(pointer) { }


    // Function GFxUI.GFxFSCmdHandler.FSCommand
    // 0x3750E0
    // (Event | Public)
    public unsafe class FSCommand_Parameters : BaseObject {
        public FSCommand_Parameters() { }
        public FSCommand_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty GFxUI.GFxFSCmdHandler.FSCommand.Movie
        // 0x0 (0x8)
        // (Param)
        public UGFxMoviePlayer Movie {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // ObjectProperty GFxUI.GFxFSCmdHandler.FSCommand.Event
        // 0x8 (0x8)
        // (Param)
        public UGFxEvent_FSCommand Event {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // StrProperty GFxUI.GFxFSCmdHandler.FSCommand.Cmd
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString Cmd {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // StrProperty GFxUI.GFxFSCmdHandler.FSCommand.Arg
        // 0x20 (0x10)
        // (Param | NeedCtorLink)
        public FString Arg {
            get => new(Pointer + 32);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 32), 16, 16);
        }

        // BoolProperty GFxUI.GFxFSCmdHandler.FSCommand.ReturnValue
        // 0x30 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 48) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 48) |= 0x1;
                else *(uint*)(Pointer + 48) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrFSCommand;
    public bool FSCommand(UGFxMoviePlayer Movie, UGFxEvent_FSCommand Event, FString Cmd, FString Arg) {
        _ptrFSCommand ??= FindFunction("Function GFxUI.GFxFSCmdHandler.FSCommand");

        var @params = stackalloc byte[52];
        System.Buffer.MemoryCopy((void*)Movie.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Event.Pointer, @params + 8, 8, 8);
        System.Buffer.MemoryCopy((void*)Cmd.Pointer, @params + 16, 16, 16);
        System.Buffer.MemoryCopy((void*)Arg.Pointer, @params + 32, 16, 16);

        ProcessEvent(_ptrFSCommand, @params);

        return *(bool*)(@params + 48);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class GFxUI.GFxFSCmdHandler");
            return _staticClass;
        }
    }
}

// Class GFxUI.GFxInteraction
// 0xC (0xD0 - 0xDC)
// (Compiled | Config | Parsed | Native)
public unsafe partial class UGFxInteraction : UInteraction {
    public UGFxInteraction() { }
    public UGFxInteraction(nint pointer) : base(pointer) { }


    // StructProperty GFxUI.GFxInteraction.VfTable_FCallbackEventDevice
    // 0xD0 (0x8)
    // (Const | Native | NoExport)
    public nint VfTable_FCallbackEventDevice {
        get => *(nint*)(Pointer + 208);
        set => *(nint*)(Pointer + 208) = value;
    }

    // BoolProperty GFxUI.GFxInteraction.bFakeMobileTouches
    // 0xD8 (0x4)
    // Bitmask: 0x00000001
    public bool bFakeMobileTouches {
        get => (*(uint*)(Pointer + 216) & 0x1) != 0;
        set {
            if (value) *(uint*)(Pointer + 216) |= 0x1;
            else *(uint*)(Pointer + 216) &= ~(uint)0x1;
        }
    }


    // Function GFxUI.GFxInteraction.DebugInputKey
    // 0xC25BA0
    // (Final | Native | Public)
    public unsafe class DebugInputKey_Parameters : BaseObject {
        public DebugInputKey_Parameters() { }
        public DebugInputKey_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxInteraction.DebugInputKey.ControllerId
        // 0x0 (0x4)
        // (Param)
        public int ControllerId {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // NameProperty GFxUI.GFxInteraction.DebugInputKey.Key
        // 0x4 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer + 4);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 4), 8, 8);
        }

        // ByteProperty GFxUI.GFxInteraction.DebugInputKey.Event
        // 0xC (0x1)
        // (Param)
        public UObject.EInputEvent Event {
            get => *(UObject.EInputEvent*)(Pointer + 12);
            set => *(UObject.EInputEvent*)(Pointer + 12) = value;
        }

        // MISSED OFFSET: 0x3

        // FloatProperty GFxUI.GFxInteraction.DebugInputKey.AmountDepressed
        // 0x10 (0x4)
        // (Param)
        public float AmountDepressed {
            get => *(float*)(Pointer + 16);
            set => *(float*)(Pointer + 16) = value;
        }

        // BoolProperty GFxUI.GFxInteraction.DebugInputKey.bGamepad
        // 0x14 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bGamepad {
            get => (*(uint*)(Pointer + 20) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 20) |= 0x1;
                else *(uint*)(Pointer + 20) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrDebugInputKey;
    public void DebugInputKey(int ControllerId, FName Key, UObject.EInputEvent Event, float AmountDepressed, bool bGamepad) {
        _ptrDebugInputKey ??= FindFunction("Function GFxUI.GFxInteraction.DebugInputKey");

        var @params = stackalloc byte[21];
        System.Buffer.MemoryCopy(&ControllerId, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params + 4, 8, 8);
        System.Buffer.MemoryCopy(&Event, @params + 12, 1, 1);
        System.Buffer.MemoryCopy(&AmountDepressed, @params + 16, 4, 4);
        System.Buffer.MemoryCopy(&bGamepad, @params + 20, 4, 4);

        _ptrDebugInputKey.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrDebugInputKey, @params);
        _ptrDebugInputKey.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxInteraction.CloseAllMoviePlayers
    // 0xC25B60
    // (Final | Native | Public)
    public unsafe class CloseAllMoviePlayers_Parameters : BaseObject {
        public CloseAllMoviePlayers_Parameters() { }
        public CloseAllMoviePlayers_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrCloseAllMoviePlayers;
    public void CloseAllMoviePlayers() {
        _ptrCloseAllMoviePlayers ??= FindFunction("Function GFxUI.GFxInteraction.CloseAllMoviePlayers");

        _ptrCloseAllMoviePlayers.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrCloseAllMoviePlayers, null);
        _ptrCloseAllMoviePlayers.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxInteraction.NotifySplitscreenLayoutChanged
    // 0xC25B20
    // (Final | Native | Public)
    public unsafe class NotifySplitscreenLayoutChanged_Parameters : BaseObject {
        public NotifySplitscreenLayoutChanged_Parameters() { }
        public NotifySplitscreenLayoutChanged_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrNotifySplitscreenLayoutChanged;
    public void NotifySplitscreenLayoutChanged() {
        _ptrNotifySplitscreenLayoutChanged ??= FindFunction("Function GFxUI.GFxInteraction.NotifySplitscreenLayoutChanged");

        _ptrNotifySplitscreenLayoutChanged.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrNotifySplitscreenLayoutChanged, null);
        _ptrNotifySplitscreenLayoutChanged.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxInteraction.NotifyPlayerRemoved
    // 0xC25A60
    // (Native | Public)
    public unsafe class NotifyPlayerRemoved_Parameters : BaseObject {
        public NotifyPlayerRemoved_Parameters() { }
        public NotifyPlayerRemoved_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxInteraction.NotifyPlayerRemoved.PlayerIndex
        // 0x0 (0x4)
        // (Param)
        public int PlayerIndex {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // ObjectProperty GFxUI.GFxInteraction.NotifyPlayerRemoved.RemovedPlayer
        // 0x8 (0x8)
        // (Param)
        public ULocalPlayer RemovedPlayer {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }
    }
    private static UFunction _ptrNotifyPlayerRemoved;
    public void NotifyPlayerRemoved(int PlayerIndex, ULocalPlayer RemovedPlayer) {
        _ptrNotifyPlayerRemoved ??= FindFunction("Function GFxUI.GFxInteraction.NotifyPlayerRemoved");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy(&PlayerIndex, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)RemovedPlayer.Pointer, @params + 8, 8, 8);

        _ptrNotifyPlayerRemoved.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrNotifyPlayerRemoved, @params);
        _ptrNotifyPlayerRemoved.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxInteraction.NotifyPlayerAdded
    // 0xC259A0
    // (Native | Public)
    public unsafe class NotifyPlayerAdded_Parameters : BaseObject {
        public NotifyPlayerAdded_Parameters() { }
        public NotifyPlayerAdded_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxInteraction.NotifyPlayerAdded.PlayerIndex
        // 0x0 (0x4)
        // (Param)
        public int PlayerIndex {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // ObjectProperty GFxUI.GFxInteraction.NotifyPlayerAdded.AddedPlayer
        // 0x8 (0x8)
        // (Param)
        public ULocalPlayer AddedPlayer {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }
    }
    private static UFunction _ptrNotifyPlayerAdded;
    public void NotifyPlayerAdded(int PlayerIndex, ULocalPlayer AddedPlayer) {
        _ptrNotifyPlayerAdded ??= FindFunction("Function GFxUI.GFxInteraction.NotifyPlayerAdded");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy(&PlayerIndex, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)AddedPlayer.Pointer, @params + 8, 8, 8);

        _ptrNotifyPlayerAdded.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrNotifyPlayerAdded, @params);
        _ptrNotifyPlayerAdded.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxInteraction.NotifyGameSessionEnded
    // 0x656CF0
    // (Native | Public)
    public unsafe class NotifyGameSessionEnded_Parameters : BaseObject {
        public NotifyGameSessionEnded_Parameters() { }
        public NotifyGameSessionEnded_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrNotifyGameSessionEnded;
    public void NotifyGameSessionEnded() {
        _ptrNotifyGameSessionEnded ??= FindFunction("Function GFxUI.GFxInteraction.NotifyGameSessionEnded");

        _ptrNotifyGameSessionEnded.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrNotifyGameSessionEnded, null);
        _ptrNotifyGameSessionEnded.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxInteraction.GetFocusMovie
    // 0xC25910
    // (Final | Native | Public)
    public unsafe class GetFocusMovie_Parameters : BaseObject {
        public GetFocusMovie_Parameters() { }
        public GetFocusMovie_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxInteraction.GetFocusMovie.ControllerId
        // 0x0 (0x4)
        // (Param)
        public int ControllerId {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // ObjectProperty GFxUI.GFxInteraction.GetFocusMovie.ReturnValue
        // 0x8 (0x8)
        // (Param | OutParam | ReturnParam)
        public UGFxMoviePlayer ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }
    }
    private static UFunction _ptrGetFocusMovie;
    public UGFxMoviePlayer GetFocusMovie(int ControllerId) {
        _ptrGetFocusMovie ??= FindFunction("Function GFxUI.GFxInteraction.GetFocusMovie");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy(&ControllerId, @params, 4, 4);

        _ptrGetFocusMovie.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetFocusMovie, @params);
        _ptrGetFocusMovie.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)(@params + 8));
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class GFxUI.GFxInteraction");
            return _staticClass;
        }
    }
}

// Class GFxUI.GFxMoviePlayer
// 0x1B8 (0x60 - 0x218)
// (Compiled | Config | Parsed | Native)
public unsafe partial class UGFxMoviePlayer : UObject {
    public UGFxMoviePlayer() { }
    public UGFxMoviePlayer(nint pointer) : base(pointer) { }


    // StructProperty GFxUI.GFxMoviePlayer.pMovie
    // 0x60 (0x8)
    // (Const | Native | Transient)
    public nint pMovie {
        get => *(nint*)(Pointer + 96);
        set => *(nint*)(Pointer + 96) = value;
    }

    // StructProperty GFxUI.GFxMoviePlayer.pCaptureKeys
    // 0x68 (0x8)
    // (Const | Native | Transient)
    public nint pCaptureKeys {
        get => *(nint*)(Pointer + 104);
        set => *(nint*)(Pointer + 104) = value;
    }

    // StructProperty GFxUI.GFxMoviePlayer.pFocusIgnoreKeys
    // 0x70 (0x8)
    // (Const | Native | Transient)
    public nint pFocusIgnoreKeys {
        get => *(nint*)(Pointer + 112);
        set => *(nint*)(Pointer + 112) = value;
    }

    // MapProperty GFxUI.GFxMoviePlayer.ASUClasses
    // 0x78 (0x50)
    // (Const | Native | Transient)
    public /* TMap<> */ nint ASUClasses {
        get => *(/* TMap<> */ nint*)(Pointer + 120);
        set => *(/* TMap<> */ nint*)(Pointer + 120) = value;
    }

    // MapProperty GFxUI.GFxMoviePlayer.ASUObjects
    // 0xC8 (0x50)
    // (Const | Native | Transient)
    public /* TMap<> */ nint ASUObjects {
        get => *(/* TMap<> */ nint*)(Pointer + 200);
        set => *(/* TMap<> */ nint*)(Pointer + 200) = value;
    }

    // IntProperty GFxUI.GFxMoviePlayer.NextASUObject
    // 0x118 (0x4)
    // (Const | Transient)
    public int NextASUObject {
        get => *(int*)(Pointer + 280);
        set => *(int*)(Pointer + 280) = value;
    }

    // MISSED OFFSET: 0x4

    // ObjectProperty GFxUI.GFxMoviePlayer.MovieInfo
    // 0x120 (0x8)
    public USwfMovie MovieInfo {
        get {
            var pointer = *(nint*)(Pointer + 288);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 288) = value.Pointer;
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bMovieIsOpen
    // 0x128 (0x4)
    // Bitmask: 0x00000001
    // (Const)
    public bool bMovieIsOpen {
        get => (*(uint*)(Pointer + 296) & 0x1) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x1;
            else *(uint*)(Pointer + 296) &= ~(uint)0x1;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bDisplayWithHudOff
    // 0x128 (0x4)
    // Bitmask: 0x00000002
    public bool bDisplayWithHudOff {
        get => (*(uint*)(Pointer + 296) & 0x2) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x2;
            else *(uint*)(Pointer + 296) &= ~(uint)0x2;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bEnableGammaCorrection
    // 0x128 (0x4)
    // Bitmask: 0x00000004
    public bool bEnableGammaCorrection {
        get => (*(uint*)(Pointer + 296) & 0x4) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x4;
            else *(uint*)(Pointer + 296) &= ~(uint)0x4;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bWidgetsInitializedThisFrame
    // 0x128 (0x4)
    // Bitmask: 0x00000008
    // (Const | Transient)
    public bool bWidgetsInitializedThisFrame {
        get => (*(uint*)(Pointer + 296) & 0x8) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x8;
            else *(uint*)(Pointer + 296) &= ~(uint)0x8;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bLogUnhandedWidgetInitializations
    // 0x128 (0x4)
    // Bitmask: 0x00000010
    public bool bLogUnhandedWidgetInitializations {
        get => (*(uint*)(Pointer + 296) & 0x10) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x10;
            else *(uint*)(Pointer + 296) &= ~(uint)0x10;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bAllowInput
    // 0x128 (0x4)
    // Bitmask: 0x00000020
    public bool bAllowInput {
        get => (*(uint*)(Pointer + 296) & 0x20) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x20;
            else *(uint*)(Pointer + 296) &= ~(uint)0x20;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bAllowFocus
    // 0x128 (0x4)
    // Bitmask: 0x00000040
    public bool bAllowFocus {
        get => (*(uint*)(Pointer + 296) & 0x40) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x40;
            else *(uint*)(Pointer + 296) &= ~(uint)0x40;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bAutoPlay
    // 0x128 (0x4)
    // Bitmask: 0x00000080
    public bool bAutoPlay {
        get => (*(uint*)(Pointer + 296) & 0x80) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x80;
            else *(uint*)(Pointer + 296) &= ~(uint)0x80;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bPauseGameWhileActive
    // 0x128 (0x4)
    // Bitmask: 0x00000100
    public bool bPauseGameWhileActive {
        get => (*(uint*)(Pointer + 296) & 0x100) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x100;
            else *(uint*)(Pointer + 296) &= ~(uint)0x100;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bDisableWorldRendering
    // 0x128 (0x4)
    // Bitmask: 0x00000200
    public bool bDisableWorldRendering {
        get => (*(uint*)(Pointer + 296) & 0x200) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x200;
            else *(uint*)(Pointer + 296) &= ~(uint)0x200;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bCaptureWorldRendering
    // 0x128 (0x4)
    // Bitmask: 0x00000400
    public bool bCaptureWorldRendering {
        get => (*(uint*)(Pointer + 296) & 0x400) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x400;
            else *(uint*)(Pointer + 296) &= ~(uint)0x400;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bCloseOnLevelChange
    // 0x128 (0x4)
    // Bitmask: 0x00000800
    public bool bCloseOnLevelChange {
        get => (*(uint*)(Pointer + 296) & 0x800) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x800;
            else *(uint*)(Pointer + 296) &= ~(uint)0x800;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bOnlyOwnerFocusable
    // 0x128 (0x4)
    // Bitmask: 0x00001000
    public bool bOnlyOwnerFocusable {
        get => (*(uint*)(Pointer + 296) & 0x1000) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x1000;
            else *(uint*)(Pointer + 296) &= ~(uint)0x1000;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bForceFullViewport
    // 0x128 (0x4)
    // Bitmask: 0x00002000
    public bool bForceFullViewport {
        get => (*(uint*)(Pointer + 296) & 0x2000) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x2000;
            else *(uint*)(Pointer + 296) &= ~(uint)0x2000;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bDiscardNonOwnerInput
    // 0x128 (0x4)
    // Bitmask: 0x00004000
    public bool bDiscardNonOwnerInput {
        get => (*(uint*)(Pointer + 296) & 0x4000) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x4000;
            else *(uint*)(Pointer + 296) &= ~(uint)0x4000;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bCaptureInput
    // 0x128 (0x4)
    // Bitmask: 0x00008000
    public bool bCaptureInput {
        get => (*(uint*)(Pointer + 296) & 0x8000) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x8000;
            else *(uint*)(Pointer + 296) &= ~(uint)0x8000;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bCaptureMouseInput
    // 0x128 (0x4)
    // Bitmask: 0x00010000
    public bool bCaptureMouseInput {
        get => (*(uint*)(Pointer + 296) & 0x10000) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x10000;
            else *(uint*)(Pointer + 296) &= ~(uint)0x10000;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bIgnoreMouseInput
    // 0x128 (0x4)
    // Bitmask: 0x00020000
    public bool bIgnoreMouseInput {
        get => (*(uint*)(Pointer + 296) & 0x20000) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x20000;
            else *(uint*)(Pointer + 296) &= ~(uint)0x20000;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bIsSplitscreenLayoutModified
    // 0x128 (0x4)
    // Bitmask: 0x00040000
    // (Transient)
    public bool bIsSplitscreenLayoutModified {
        get => (*(uint*)(Pointer + 296) & 0x40000) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x40000;
            else *(uint*)(Pointer + 296) &= ~(uint)0x40000;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bShowHardwareMouseCursor
    // 0x128 (0x4)
    // Bitmask: 0x00080000
    public bool bShowHardwareMouseCursor {
        get => (*(uint*)(Pointer + 296) & 0x80000) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x80000;
            else *(uint*)(Pointer + 296) &= ~(uint)0x80000;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bForceFullScreen
    // 0x128 (0x4)
    // Bitmask: 0x00100000
    public bool bForceFullScreen {
        get => (*(uint*)(Pointer + 296) & 0x100000) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x100000;
            else *(uint*)(Pointer + 296) &= ~(uint)0x100000;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bBlurLesserMovies
    // 0x128 (0x4)
    // Bitmask: 0x00200000
    public bool bBlurLesserMovies {
        get => (*(uint*)(Pointer + 296) & 0x200000) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x200000;
            else *(uint*)(Pointer + 296) &= ~(uint)0x200000;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bHideLesserMovies
    // 0x128 (0x4)
    // Bitmask: 0x00400000
    public bool bHideLesserMovies {
        get => (*(uint*)(Pointer + 296) & 0x400000) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x400000;
            else *(uint*)(Pointer + 296) &= ~(uint)0x400000;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bIsPriorityBlurred
    // 0x128 (0x4)
    // Bitmask: 0x00800000
    public bool bIsPriorityBlurred {
        get => (*(uint*)(Pointer + 296) & 0x800000) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x800000;
            else *(uint*)(Pointer + 296) &= ~(uint)0x800000;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bIsPriorityHidden
    // 0x128 (0x4)
    // Bitmask: 0x01000000
    public bool bIsPriorityHidden {
        get => (*(uint*)(Pointer + 296) & 0x1000000) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x1000000;
            else *(uint*)(Pointer + 296) &= ~(uint)0x1000000;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bIgnoreVisibilityEffect
    // 0x128 (0x4)
    // Bitmask: 0x02000000
    public bool bIgnoreVisibilityEffect {
        get => (*(uint*)(Pointer + 296) & 0x2000000) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x2000000;
            else *(uint*)(Pointer + 296) &= ~(uint)0x2000000;
        }
    }

    // BoolProperty GFxUI.GFxMoviePlayer.bIgnoreBlurEffect
    // 0x128 (0x4)
    // Bitmask: 0x04000000
    public bool bIgnoreBlurEffect {
        get => (*(uint*)(Pointer + 296) & 0x4000000) != 0;
        set {
            if (value) *(uint*)(Pointer + 296) |= 0x4000000;
            else *(uint*)(Pointer + 296) &= ~(uint)0x4000000;
        }
    }

    // MISSED OFFSET: 0x4

    // ObjectProperty GFxUI.GFxMoviePlayer.RenderTexture
    // 0x130 (0x8)
    // (Edit)
    public UTextureRenderTarget2D RenderTexture {
        get {
            var pointer = *(nint*)(Pointer + 304);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 304) = value.Pointer;
    }

    // IntProperty GFxUI.GFxMoviePlayer.LocalPlayerOwnerIndex
    // 0x138 (0x4)
    // (Transient)
    public int LocalPlayerOwnerIndex {
        get => *(int*)(Pointer + 312);
        set => *(int*)(Pointer + 312) = value;
    }

    // MISSED OFFSET: 0x4

    // ObjectProperty GFxUI.GFxMoviePlayer.ExternalInterface
    // 0x140 (0x8)
    public UObject ExternalInterface {
        get {
            var pointer = *(nint*)(Pointer + 320);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 320) = value.Pointer;
    }

    // ArrayProperty GFxUI.GFxMoviePlayer.CaptureKeys
    // 0x148 (0x10)
    // (NeedCtorLink)
    public StructTArray<FName> CaptureKeys {
        get => new(Pointer + 328, 8);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 328), 16, 16);
    }

    // ArrayProperty GFxUI.GFxMoviePlayer.FocusIgnoreKeys
    // 0x158 (0x10)
    // (NeedCtorLink)
    public StructTArray<FName> FocusIgnoreKeys {
        get => new(Pointer + 344, 8);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 344), 16, 16);
    }

    // ArrayProperty GFxUI.GFxMoviePlayer.ExternalTextures
    // 0x168 (0x10)
    // (NeedCtorLink)
    public StructTArray<FExternalTexture> ExternalTextures {
        get => new(Pointer + 360, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 360), 16, 16);
    }

    // ArrayProperty GFxUI.GFxMoviePlayer.SoundThemes
    // 0x178 (0x10)
    // (Edit | NeedCtorLink)
    public StructTArray<FSoundThemeBinding> SoundThemes {
        get => new(Pointer + 376, 32);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 376), 16, 16);
    }

    // ByteProperty GFxUI.GFxMoviePlayer.TimingMode
    // 0x188 (0x1)
    public GFxTimingMode TimingMode {
        get => *(GFxTimingMode*)(Pointer + 392);
        set => *(GFxTimingMode*)(Pointer + 392) = value;
    }

    // ByteProperty GFxUI.GFxMoviePlayer.RenderTextureMode
    // 0x189 (0x1)
    public GFxRenderTextureMode RenderTextureMode {
        get => *(GFxRenderTextureMode*)(Pointer + 393);
        set => *(GFxRenderTextureMode*)(Pointer + 393) = value;
    }

    // ByteProperty GFxUI.GFxMoviePlayer.Priority
    // 0x18A (0x1)
    public byte Priority {
        get => *(byte*)(Pointer + 394);
        set => *(byte*)(Pointer + 394) = value;
    }

    // MISSED OFFSET: 0x5

    // ArrayProperty GFxUI.GFxMoviePlayer.WidgetBindings
    // 0x190 (0x10)
    // (NeedCtorLink)
    public StructTArray<FGFxWidgetBinding> WidgetBindings {
        get => new(Pointer + 400, 16);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 400), 16, 16);
    }

    // MapProperty GFxUI.GFxMoviePlayer.WidgetPathBindings
    // 0x1A0 (0x50)
    // (Const | Native)
    public /* TMap<> */ nint WidgetPathBindings {
        get => *(/* TMap<> */ nint*)(Pointer + 416);
        set => *(/* TMap<> */ nint*)(Pointer + 416) = value;
    }

    // ObjectProperty GFxUI.GFxMoviePlayer.SplitscreenLayoutObject
    // 0x1F0 (0x8)
    // (Transient)
    public UGFxObject SplitscreenLayoutObject {
        get {
            var pointer = *(nint*)(Pointer + 496);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 496) = value.Pointer;
    }

    // IntProperty GFxUI.GFxMoviePlayer.SplitscreenLayoutYAdjust
    // 0x1F8 (0x4)
    // (Config)
    public int SplitscreenLayoutYAdjust {
        get => *(int*)(Pointer + 504);
        set => *(int*)(Pointer + 504) = value;
    }

    // MISSED OFFSET: 0x4

    // DelegateProperty GFxUI.GFxMoviePlayer.__OnPostAdvance__Delegate
    // 0x200 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnPostAdvance__Delegate {
        get => new(Pointer + 512);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 512), 24, 24);
    }


    // Function GFxUI.GFxMoviePlayer.SetFullScreen
    // 0xC22030
    // (Final | Native | Public)
    public unsafe class SetFullScreen_Parameters : BaseObject {
        public SetFullScreen_Parameters() { }
        public SetFullScreen_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty GFxUI.GFxMoviePlayer.SetFullScreen.bFullScreen
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bFullScreen {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetFullScreen;
    public void SetFullScreen(bool bFullScreen) {
        _ptrSetFullScreen ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetFullScreen");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bFullScreen, @params, 4, 4);

        _ptrSetFullScreen.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetFullScreen, @params);
        _ptrSetFullScreen.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.IsHidden
    // 0xC21FE0
    // (Final | Native | Public)
    public unsafe class IsHidden_Parameters : BaseObject {
        public IsHidden_Parameters() { }
        public IsHidden_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty GFxUI.GFxMoviePlayer.IsHidden.ReturnValue
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrIsHidden;
    public bool IsHidden() {
        _ptrIsHidden ??= FindFunction("Function GFxUI.GFxMoviePlayer.IsHidden");

        var @params = stackalloc byte[4];

        _ptrIsHidden.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrIsHidden, @params);
        _ptrIsHidden.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)@params;
    }

    // Function GFxUI.GFxMoviePlayer.SetHidden
    // 0xC21F50
    // (Final | Native | Public)
    public unsafe class SetHidden_Parameters : BaseObject {
        public SetHidden_Parameters() { }
        public SetHidden_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty GFxUI.GFxMoviePlayer.SetHidden.bHidden
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bHidden {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetHidden;
    public void SetHidden(bool bHidden) {
        _ptrSetHidden ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetHidden");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bHidden, @params, 4, 4);

        _ptrSetHidden.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetHidden, @params);
        _ptrSetHidden.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.RenderOnce
    // 0xC21F10
    // (Final | Native | Public)
    public unsafe class RenderOnce_Parameters : BaseObject {
        public RenderOnce_Parameters() { }
        public RenderOnce_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrRenderOnce;
    public void RenderOnce() {
        _ptrRenderOnce ??= FindFunction("Function GFxUI.GFxMoviePlayer.RenderOnce");

        _ptrRenderOnce.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrRenderOnce, null);
        _ptrRenderOnce.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.UpdateSplitscreenLayout
    // 0xC21ED0
    // (Final | Native | Public)
    public unsafe class UpdateSplitscreenLayout_Parameters : BaseObject {
        public UpdateSplitscreenLayout_Parameters() { }
        public UpdateSplitscreenLayout_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrUpdateSplitscreenLayout;
    public void UpdateSplitscreenLayout() {
        _ptrUpdateSplitscreenLayout ??= FindFunction("Function GFxUI.GFxMoviePlayer.UpdateSplitscreenLayout");

        _ptrUpdateSplitscreenLayout.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrUpdateSplitscreenLayout, null);
        _ptrUpdateSplitscreenLayout.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.ApplyPriorityVisibilityEffect
    // 0x3750E0
    // (Final | Public)
    public unsafe class ApplyPriorityVisibilityEffect_Parameters : BaseObject {
        public ApplyPriorityVisibilityEffect_Parameters() { }
        public ApplyPriorityVisibilityEffect_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty GFxUI.GFxMoviePlayer.ApplyPriorityVisibilityEffect.bRemoveEffect
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bRemoveEffect {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrApplyPriorityVisibilityEffect;
    public void ApplyPriorityVisibilityEffect(bool bRemoveEffect) {
        _ptrApplyPriorityVisibilityEffect ??= FindFunction("Function GFxUI.GFxMoviePlayer.ApplyPriorityVisibilityEffect");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bRemoveEffect, @params, 4, 4);

        ProcessEvent(_ptrApplyPriorityVisibilityEffect, @params);
    }

    // Function GFxUI.GFxMoviePlayer.ApplyPriorityBlurEffect
    // 0x3750E0
    // (Final | Public)
    public unsafe class ApplyPriorityBlurEffect_Parameters : BaseObject {
        public ApplyPriorityBlurEffect_Parameters() { }
        public ApplyPriorityBlurEffect_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty GFxUI.GFxMoviePlayer.ApplyPriorityBlurEffect.bRemoveEffect
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bRemoveEffect {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrApplyPriorityBlurEffect;
    public void ApplyPriorityBlurEffect(bool bRemoveEffect) {
        _ptrApplyPriorityBlurEffect ??= FindFunction("Function GFxUI.GFxMoviePlayer.ApplyPriorityBlurEffect");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bRemoveEffect, @params, 4, 4);

        ProcessEvent(_ptrApplyPriorityBlurEffect, @params);
    }

    // Function GFxUI.GFxMoviePlayer.ApplyPriorityEffect
    // 0x3750E0
    // (Final | Defined | Event | Public)
    public unsafe class ApplyPriorityEffect_Parameters : BaseObject {
        public ApplyPriorityEffect_Parameters() { }
        public ApplyPriorityEffect_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty GFxUI.GFxMoviePlayer.ApplyPriorityEffect.bRequestedBlurState
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bRequestedBlurState {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }

        // BoolProperty GFxUI.GFxMoviePlayer.ApplyPriorityEffect.bRequestedHiddenState
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bRequestedHiddenState {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrApplyPriorityEffect;
    public void ApplyPriorityEffect(bool bRequestedBlurState, bool bRequestedHiddenState) {
        _ptrApplyPriorityEffect ??= FindFunction("Function GFxUI.GFxMoviePlayer.ApplyPriorityEffect");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&bRequestedBlurState, @params, 4, 4);
        System.Buffer.MemoryCopy(&bRequestedHiddenState, @params + 4, 4, 4);

        ProcessEvent(_ptrApplyPriorityEffect, @params);
    }

    // Function GFxUI.GFxMoviePlayer.PlaySoundFromTheme
    // 0x3750E0
    // (Defined | Event | HasOptionalParams | Public)
    public unsafe class PlaySoundFromTheme_Parameters : BaseObject {
        public PlaySoundFromTheme_Parameters() { }
        public PlaySoundFromTheme_Parameters(nint pointer) : base(pointer) { }

        // NameProperty GFxUI.GFxMoviePlayer.PlaySoundFromTheme.EventName
        // 0x0 (0x8)
        // (Param)
        public FName EventName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // NameProperty GFxUI.GFxMoviePlayer.PlaySoundFromTheme.SoundThemeName
        // 0x8 (0x8)
        // (OptionalParam | Param)
        public FName SoundThemeName {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 8, 8);
        }
    }
    private static UFunction _ptrPlaySoundFromTheme;
    public void PlaySoundFromTheme(FName EventName, FName SoundThemeName = null) {
        _ptrPlaySoundFromTheme ??= FindFunction("Function GFxUI.GFxMoviePlayer.PlaySoundFromTheme");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)EventName.Pointer, @params, 8, 8);
        if (SoundThemeName != null) System.Buffer.MemoryCopy((void*)SoundThemeName.Pointer, @params + 8, 8, 8);

        ProcessEvent(_ptrPlaySoundFromTheme, @params);
    }

    // Function GFxUI.GFxMoviePlayer.OnFocusLost
    // 0x3750E0
    // (Final | Event | Public)
    public unsafe class OnFocusLost_Parameters : BaseObject {
        public OnFocusLost_Parameters() { }
        public OnFocusLost_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxMoviePlayer.OnFocusLost.LocalPlayerIndex
        // 0x0 (0x4)
        // (Param)
        public int LocalPlayerIndex {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrOnFocusLost;
    public void OnFocusLost(int LocalPlayerIndex) {
        _ptrOnFocusLost ??= FindFunction("Function GFxUI.GFxMoviePlayer.OnFocusLost");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&LocalPlayerIndex, @params, 4, 4);

        ProcessEvent(_ptrOnFocusLost, @params);
    }

    // Function GFxUI.GFxMoviePlayer.OnFocusGained
    // 0x3750E0
    // (Final | Event | Public)
    public unsafe class OnFocusGained_Parameters : BaseObject {
        public OnFocusGained_Parameters() { }
        public OnFocusGained_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxMoviePlayer.OnFocusGained.LocalPlayerIndex
        // 0x0 (0x4)
        // (Param)
        public int LocalPlayerIndex {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrOnFocusGained;
    public void OnFocusGained(int LocalPlayerIndex) {
        _ptrOnFocusGained ??= FindFunction("Function GFxUI.GFxMoviePlayer.OnFocusGained");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&LocalPlayerIndex, @params, 4, 4);

        ProcessEvent(_ptrOnFocusGained, @params);
    }

    // Function GFxUI.GFxMoviePlayer.ConsoleCommand
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ConsoleCommand_Parameters : BaseObject {
        public ConsoleCommand_Parameters() { }
        public ConsoleCommand_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.ConsoleCommand.Command
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Command {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrConsoleCommand;
    public void ConsoleCommand(FString Command) {
        _ptrConsoleCommand ??= FindFunction("Function GFxUI.GFxMoviePlayer.ConsoleCommand");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)Command.Pointer, @params, 16, 16);

        ProcessEvent(_ptrConsoleCommand, @params);
    }

    // Function GFxUI.GFxMoviePlayer.GetPC
    // 0x3750E0
    // (Final | Defined | Event | Public)
    public unsafe class GetPC_Parameters : BaseObject {
        public GetPC_Parameters() { }
        public GetPC_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty GFxUI.GFxMoviePlayer.GetPC.ReturnValue
        // 0x0 (0x8)
        // (Param | OutParam | ReturnParam)
        public APlayerController ReturnValue {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrGetPC;
    public APlayerController GetPC() {
        _ptrGetPC ??= FindFunction("Function GFxUI.GFxMoviePlayer.GetPC");

        var @params = stackalloc byte[8];

        ProcessEvent(_ptrGetPC, @params);

        return new(*(nint*)@params);
    }

    // Function GFxUI.GFxMoviePlayer.GetLP
    // 0x3750E0
    // (Final | Defined | Event | Public)
    public unsafe class GetLP_Parameters : BaseObject {
        public GetLP_Parameters() { }
        public GetLP_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty GFxUI.GFxMoviePlayer.GetLP.ReturnValue
        // 0x0 (0x8)
        // (Param | OutParam | ReturnParam)
        public ULocalPlayer ReturnValue {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrGetLP;
    public ULocalPlayer GetLP() {
        _ptrGetLP ??= FindFunction("Function GFxUI.GFxMoviePlayer.GetLP");

        var @params = stackalloc byte[8];

        ProcessEvent(_ptrGetLP, @params);

        return new(*(nint*)@params);
    }

    // Function GFxUI.GFxMoviePlayer.Init
    // 0x3750E0
    // (Final | Defined | HasOptionalParams | Public)
    public unsafe class Init_Parameters : BaseObject {
        public Init_Parameters() { }
        public Init_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty GFxUI.GFxMoviePlayer.Init.LocPlay
        // 0x0 (0x8)
        // (OptionalParam | Param)
        public ULocalPlayer LocPlay {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrInit;
    public void Init(ULocalPlayer LocPlay = null) {
        _ptrInit ??= FindFunction("Function GFxUI.GFxMoviePlayer.Init");

        var @params = stackalloc byte[8];
        if (LocPlay != null) System.Buffer.MemoryCopy((void*)LocPlay.Pointer, @params, 8, 8);

        ProcessEvent(_ptrInit, @params);
    }

    // Function GFxUI.GFxMoviePlayer.SetWidgetPathBinding
    // 0xC21E10
    // (Final | Native | Public)
    public unsafe class SetWidgetPathBinding_Parameters : BaseObject {
        public SetWidgetPathBinding_Parameters() { }
        public SetWidgetPathBinding_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty GFxUI.GFxMoviePlayer.SetWidgetPathBinding.WidgetToBind
        // 0x0 (0x8)
        // (Param)
        public UGFxObject WidgetToBind {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // NameProperty GFxUI.GFxMoviePlayer.SetWidgetPathBinding.Path
        // 0x8 (0x8)
        // (Param)
        public FName Path {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 8, 8);
        }
    }
    private static UFunction _ptrSetWidgetPathBinding;
    public void SetWidgetPathBinding(UGFxObject WidgetToBind, FName Path) {
        _ptrSetWidgetPathBinding ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetWidgetPathBinding");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)WidgetToBind.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params + 8, 8, 8);

        _ptrSetWidgetPathBinding.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetWidgetPathBinding, @params);
        _ptrSetWidgetPathBinding.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.PostWidgetInit
    // 0x3750E0
    // (Final | Event | Public)
    public unsafe class PostWidgetInit_Parameters : BaseObject {
        public PostWidgetInit_Parameters() { }
        public PostWidgetInit_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrPostWidgetInit;
    public void PostWidgetInit() {
        _ptrPostWidgetInit ??= FindFunction("Function GFxUI.GFxMoviePlayer.PostWidgetInit");

        ProcessEvent(_ptrPostWidgetInit, null);
    }

    // Function GFxUI.GFxMoviePlayer.WidgetUnloaded
    // 0x3750E0
    // (Final | Event | Public)
    public unsafe class WidgetUnloaded_Parameters : BaseObject {
        public WidgetUnloaded_Parameters() { }
        public WidgetUnloaded_Parameters(nint pointer) : base(pointer) { }

        // NameProperty GFxUI.GFxMoviePlayer.WidgetUnloaded.WidgetName
        // 0x0 (0x8)
        // (Param)
        public FName WidgetName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // NameProperty GFxUI.GFxMoviePlayer.WidgetUnloaded.WidgetPath
        // 0x8 (0x8)
        // (Param)
        public FName WidgetPath {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 8, 8);
        }

        // ObjectProperty GFxUI.GFxMoviePlayer.WidgetUnloaded.Widget
        // 0x10 (0x8)
        // (Param)
        public UGFxObject Widget {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }

        // BoolProperty GFxUI.GFxMoviePlayer.WidgetUnloaded.ReturnValue
        // 0x18 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 24) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 24) |= 0x1;
                else *(uint*)(Pointer + 24) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrWidgetUnloaded;
    public bool WidgetUnloaded(FName WidgetName, FName WidgetPath, UGFxObject Widget) {
        _ptrWidgetUnloaded ??= FindFunction("Function GFxUI.GFxMoviePlayer.WidgetUnloaded");

        var @params = stackalloc byte[28];
        System.Buffer.MemoryCopy((void*)WidgetName.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)WidgetPath.Pointer, @params + 8, 8, 8);
        System.Buffer.MemoryCopy((void*)Widget.Pointer, @params + 16, 8, 8);

        ProcessEvent(_ptrWidgetUnloaded, @params);

        return *(bool*)(@params + 24);
    }

    // Function GFxUI.GFxMoviePlayer.WidgetInitialized
    // 0x3750E0
    // (Final | Event | Public)
    public unsafe class WidgetInitialized_Parameters : BaseObject {
        public WidgetInitialized_Parameters() { }
        public WidgetInitialized_Parameters(nint pointer) : base(pointer) { }

        // NameProperty GFxUI.GFxMoviePlayer.WidgetInitialized.WidgetName
        // 0x0 (0x8)
        // (Param)
        public FName WidgetName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // NameProperty GFxUI.GFxMoviePlayer.WidgetInitialized.WidgetPath
        // 0x8 (0x8)
        // (Param)
        public FName WidgetPath {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 8, 8);
        }

        // ObjectProperty GFxUI.GFxMoviePlayer.WidgetInitialized.Widget
        // 0x10 (0x8)
        // (Param)
        public UGFxObject Widget {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }

        // BoolProperty GFxUI.GFxMoviePlayer.WidgetInitialized.ReturnValue
        // 0x18 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 24) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 24) |= 0x1;
                else *(uint*)(Pointer + 24) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrWidgetInitialized;
    public bool WidgetInitialized(FName WidgetName, FName WidgetPath, UGFxObject Widget) {
        _ptrWidgetInitialized ??= FindFunction("Function GFxUI.GFxMoviePlayer.WidgetInitialized");

        var @params = stackalloc byte[28];
        System.Buffer.MemoryCopy((void*)WidgetName.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)WidgetPath.Pointer, @params + 8, 8, 8);
        System.Buffer.MemoryCopy((void*)Widget.Pointer, @params + 16, 8, 8);

        ProcessEvent(_ptrWidgetInitialized, @params);

        return *(bool*)(@params + 24);
    }

    // Function GFxUI.GFxMoviePlayer.ActionScriptConstructor
    // 0xCD9660
    // (Final | Native | Public)
    public unsafe class ActionScriptConstructor_Parameters : BaseObject {
        public ActionScriptConstructor_Parameters() { }
        public ActionScriptConstructor_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.ActionScriptConstructor.ClassName
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString ClassName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ObjectProperty GFxUI.GFxMoviePlayer.ActionScriptConstructor.ReturnValue
        // 0x10 (0x8)
        // (Param | OutParam | ReturnParam)
        public UGFxObject ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }
    }
    private static UFunction _ptrActionScriptConstructor;
    public UGFxObject ActionScriptConstructor(FString ClassName) {
        _ptrActionScriptConstructor ??= FindFunction("Function GFxUI.GFxMoviePlayer.ActionScriptConstructor");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)ClassName.Pointer, @params, 16, 16);

        _ptrActionScriptConstructor.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrActionScriptConstructor, @params);
        _ptrActionScriptConstructor.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)(@params + 16));
    }

    // Function GFxUI.GFxMoviePlayer.ActionScriptObject
    // 0xCD9A00
    // (Final | Native | Public)
    public unsafe class ActionScriptObject_Parameters : BaseObject {
        public ActionScriptObject_Parameters() { }
        public ActionScriptObject_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.ActionScriptObject.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ObjectProperty GFxUI.GFxMoviePlayer.ActionScriptObject.ReturnValue
        // 0x10 (0x8)
        // (Param | OutParam | ReturnParam)
        public UGFxObject ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }
    }
    private static UFunction _ptrActionScriptObject;
    public UGFxObject ActionScriptObject(FString Path) {
        _ptrActionScriptObject ??= FindFunction("Function GFxUI.GFxMoviePlayer.ActionScriptObject");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);

        _ptrActionScriptObject.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrActionScriptObject, @params);
        _ptrActionScriptObject.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)(@params + 16));
    }

    // Function GFxUI.GFxMoviePlayer.ActionScriptString
    // 0xCDA260
    // (Final | Native | Public)
    public unsafe class ActionScriptString_Parameters : BaseObject {
        public ActionScriptString_Parameters() { }
        public ActionScriptString_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.ActionScriptString.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty GFxUI.GFxMoviePlayer.ActionScriptString.ReturnValue
        // 0x10 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }
    }
    private static UFunction _ptrActionScriptString;
    public FString ActionScriptString(FString Path) {
        _ptrActionScriptString ??= FindFunction("Function GFxUI.GFxMoviePlayer.ActionScriptString");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);

        _ptrActionScriptString.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrActionScriptString, @params);
        _ptrActionScriptString.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 16, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxMoviePlayer.ActionScriptFloat
    // 0xCD96E0
    // (Final | Native | Public)
    public unsafe class ActionScriptFloat_Parameters : BaseObject {
        public ActionScriptFloat_Parameters() { }
        public ActionScriptFloat_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.ActionScriptFloat.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // FloatProperty GFxUI.GFxMoviePlayer.ActionScriptFloat.ReturnValue
        // 0x10 (0x4)
        // (Param | OutParam | ReturnParam)
        public float ReturnValue {
            get => *(float*)(Pointer + 16);
            set => *(float*)(Pointer + 16) = value;
        }
    }
    private static UFunction _ptrActionScriptFloat;
    public float ActionScriptFloat(FString Path) {
        _ptrActionScriptFloat ??= FindFunction("Function GFxUI.GFxMoviePlayer.ActionScriptFloat");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);

        _ptrActionScriptFloat.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrActionScriptFloat, @params);
        _ptrActionScriptFloat.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(float*)(@params + 16);
    }

    // Function GFxUI.GFxMoviePlayer.ActionScriptInt
    // 0xCD9870
    // (Final | Native | Public)
    public unsafe class ActionScriptInt_Parameters : BaseObject {
        public ActionScriptInt_Parameters() { }
        public ActionScriptInt_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.ActionScriptInt.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // IntProperty GFxUI.GFxMoviePlayer.ActionScriptInt.ReturnValue
        // 0x10 (0x4)
        // (Param | OutParam | ReturnParam)
        public int ReturnValue {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }
    }
    private static UFunction _ptrActionScriptInt;
    public int ActionScriptInt(FString Path) {
        _ptrActionScriptInt ??= FindFunction("Function GFxUI.GFxMoviePlayer.ActionScriptInt");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);

        _ptrActionScriptInt.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrActionScriptInt, @params);
        _ptrActionScriptInt.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(int*)(@params + 16);
    }

    // Function GFxUI.GFxMoviePlayer.ActionScriptVoid
    // 0xCDA3F0
    // (Final | Native | Public)
    public unsafe class ActionScriptVoid_Parameters : BaseObject {
        public ActionScriptVoid_Parameters() { }
        public ActionScriptVoid_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.ActionScriptVoid.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrActionScriptVoid;
    public void ActionScriptVoid(FString Path) {
        _ptrActionScriptVoid ??= FindFunction("Function GFxUI.GFxMoviePlayer.ActionScriptVoid");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);

        _ptrActionScriptVoid.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrActionScriptVoid, @params);
        _ptrActionScriptVoid.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.Invoke
    // 0xC21CA0
    // (Final | Native | Public)
    public unsafe class Invoke_Parameters : BaseObject {
        public Invoke_Parameters() { }
        public Invoke_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.Invoke.method
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString method {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ArrayProperty GFxUI.GFxMoviePlayer.Invoke.args
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public StructTArray<FASValue> args {
            get => new(Pointer + 16, 40);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // StructProperty GFxUI.GFxMoviePlayer.Invoke.ReturnValue
        // 0x20 (0x28)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FASValue ReturnValue {
            get => new(Pointer + 32);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 32), 40, 40);
        }
    }
    private static UFunction _ptrInvoke;
    public FASValue Invoke(FString method, StructTArray<FASValue> args) {
        _ptrInvoke ??= FindFunction("Function GFxUI.GFxMoviePlayer.Invoke");

        var @params = stackalloc byte[72];
        System.Buffer.MemoryCopy((void*)method.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)args.Pointer, @params + 16, 16, 16);

        _ptrInvoke.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrInvoke, @params);
        _ptrInvoke.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(40);
        System.Buffer.MemoryCopy(@params + 32, (void*)_ReturnValuePtr, 40, 40);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxMoviePlayer.ActionScriptSetFunction
    // 0xCD9AB0
    // (Final | Native | Protected)
    public unsafe class ActionScriptSetFunction_Parameters : BaseObject {
        public ActionScriptSetFunction_Parameters() { }
        public ActionScriptSetFunction_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty GFxUI.GFxMoviePlayer.ActionScriptSetFunction.Object
        // 0x0 (0x8)
        // (Param)
        public UGFxObject Object {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // StrProperty GFxUI.GFxMoviePlayer.ActionScriptSetFunction.Member
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrActionScriptSetFunction;
    public void ActionScriptSetFunction(UGFxObject Object, FString Member) {
        _ptrActionScriptSetFunction ??= FindFunction("Function GFxUI.GFxMoviePlayer.ActionScriptSetFunction");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)Object.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params + 8, 16, 16);

        _ptrActionScriptSetFunction.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrActionScriptSetFunction, @params);
        _ptrActionScriptSetFunction.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.CreateArray
    // 0xC21C50
    // (Final | Native | Public)
    public unsafe class CreateArray_Parameters : BaseObject {
        public CreateArray_Parameters() { }
        public CreateArray_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty GFxUI.GFxMoviePlayer.CreateArray.ReturnValue
        // 0x0 (0x8)
        // (Param | OutParam | ReturnParam)
        public UGFxObject ReturnValue {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrCreateArray;
    public UGFxObject CreateArray() {
        _ptrCreateArray ??= FindFunction("Function GFxUI.GFxMoviePlayer.CreateArray");

        var @params = stackalloc byte[8];

        _ptrCreateArray.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrCreateArray, @params);
        _ptrCreateArray.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)@params);
    }

    // Function GFxUI.GFxMoviePlayer.CreateObject
    // 0xC21A60
    // (Final | Native | HasOptionalParams | Public)
    public unsafe class CreateObject_Parameters : BaseObject {
        public CreateObject_Parameters() { }
        public CreateObject_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.CreateObject.ASClass
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString ASClass {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ClassProperty GFxUI.GFxMoviePlayer.CreateObject.Type
        // 0x10 (0x8)
        // (OptionalParam | Param)
        public UClass Type {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }

        // ArrayProperty GFxUI.GFxMoviePlayer.CreateObject.args
        // 0x18 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public StructTArray<FASValue> args {
            get => new(Pointer + 24, 40);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }

        // ObjectProperty GFxUI.GFxMoviePlayer.CreateObject.ReturnValue
        // 0x28 (0x8)
        // (Param | OutParam | ReturnParam)
        public UGFxObject ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 40);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 40) = value.Pointer;
        }
    }
    private static UFunction _ptrCreateObject;
    public UGFxObject CreateObject(FString ASClass, UClass Type = null, StructTArray<FASValue> args = null) {
        _ptrCreateObject ??= FindFunction("Function GFxUI.GFxMoviePlayer.CreateObject");

        var @params = stackalloc byte[48];
        System.Buffer.MemoryCopy((void*)ASClass.Pointer, @params, 16, 16);
        if (Type != null) System.Buffer.MemoryCopy((void*)Type.Pointer, @params + 16, 8, 8);
        if (args != null) System.Buffer.MemoryCopy((void*)args.Pointer, @params + 24, 16, 16);

        _ptrCreateObject.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrCreateObject, @params);
        _ptrCreateObject.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)(@params + 40));
    }

    // Function GFxUI.GFxMoviePlayer.SetVariableStringArray
    // 0xC21900
    // (Final | Native | Public)
    public unsafe class SetVariableStringArray_Parameters : BaseObject {
        public SetVariableStringArray_Parameters() { }
        public SetVariableStringArray_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.SetVariableStringArray.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // IntProperty GFxUI.GFxMoviePlayer.SetVariableStringArray.Index
        // 0x10 (0x4)
        // (Param)
        public int Index {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }

        // MISSED OFFSET: 0x4

        // ArrayProperty GFxUI.GFxMoviePlayer.SetVariableStringArray.Arg
        // 0x18 (0x10)
        // (Param | NeedCtorLink)
        public StructTArray<FString> Arg {
            get => new(Pointer + 24, 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }

        // BoolProperty GFxUI.GFxMoviePlayer.SetVariableStringArray.ReturnValue
        // 0x28 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 40) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x1;
                else *(uint*)(Pointer + 40) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetVariableStringArray;
    public bool SetVariableStringArray(FString Path, int Index, StructTArray<FString> Arg) {
        _ptrSetVariableStringArray ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetVariableStringArray");

        var @params = stackalloc byte[40];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&Index, @params + 16, 4, 4);
        System.Buffer.MemoryCopy((void*)Arg.Pointer, @params + 24, 16, 16);

        _ptrSetVariableStringArray.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetVariableStringArray, @params);
        _ptrSetVariableStringArray.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 40);
    }

    // Function GFxUI.GFxMoviePlayer.SetVariableFloatArray
    // 0xC217D0
    // (Final | Native | Public)
    public unsafe class SetVariableFloatArray_Parameters : BaseObject {
        public SetVariableFloatArray_Parameters() { }
        public SetVariableFloatArray_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.SetVariableFloatArray.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // IntProperty GFxUI.GFxMoviePlayer.SetVariableFloatArray.Index
        // 0x10 (0x4)
        // (Param)
        public int Index {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }

        // MISSED OFFSET: 0x4

        // ArrayProperty GFxUI.GFxMoviePlayer.SetVariableFloatArray.Arg
        // 0x18 (0x10)
        // (Param | NeedCtorLink)
        public UnmanagedTArray<float> Arg {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }

        // BoolProperty GFxUI.GFxMoviePlayer.SetVariableFloatArray.ReturnValue
        // 0x28 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 40) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x1;
                else *(uint*)(Pointer + 40) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetVariableFloatArray;
    public bool SetVariableFloatArray(FString Path, int Index, UnmanagedTArray<float> Arg) {
        _ptrSetVariableFloatArray ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetVariableFloatArray");

        var @params = stackalloc byte[40];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&Index, @params + 16, 4, 4);
        System.Buffer.MemoryCopy((void*)Arg.Pointer, @params + 24, 16, 16);

        _ptrSetVariableFloatArray.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetVariableFloatArray, @params);
        _ptrSetVariableFloatArray.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 40);
    }

    // Function GFxUI.GFxMoviePlayer.SetVariableIntArray
    // 0xC216A0
    // (Final | Native | Public)
    public unsafe class SetVariableIntArray_Parameters : BaseObject {
        public SetVariableIntArray_Parameters() { }
        public SetVariableIntArray_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.SetVariableIntArray.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // IntProperty GFxUI.GFxMoviePlayer.SetVariableIntArray.Index
        // 0x10 (0x4)
        // (Param)
        public int Index {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }

        // MISSED OFFSET: 0x4

        // ArrayProperty GFxUI.GFxMoviePlayer.SetVariableIntArray.Arg
        // 0x18 (0x10)
        // (Param | NeedCtorLink)
        public UnmanagedTArray<int> Arg {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }

        // BoolProperty GFxUI.GFxMoviePlayer.SetVariableIntArray.ReturnValue
        // 0x28 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 40) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x1;
                else *(uint*)(Pointer + 40) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetVariableIntArray;
    public bool SetVariableIntArray(FString Path, int Index, UnmanagedTArray<int> Arg) {
        _ptrSetVariableIntArray ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetVariableIntArray");

        var @params = stackalloc byte[40];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&Index, @params + 16, 4, 4);
        System.Buffer.MemoryCopy((void*)Arg.Pointer, @params + 24, 16, 16);

        _ptrSetVariableIntArray.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetVariableIntArray, @params);
        _ptrSetVariableIntArray.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 40);
    }

    // Function GFxUI.GFxMoviePlayer.SetVariableArray
    // 0xC21540
    // (Final | Native | Public)
    public unsafe class SetVariableArray_Parameters : BaseObject {
        public SetVariableArray_Parameters() { }
        public SetVariableArray_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.SetVariableArray.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // IntProperty GFxUI.GFxMoviePlayer.SetVariableArray.Index
        // 0x10 (0x4)
        // (Param)
        public int Index {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }

        // MISSED OFFSET: 0x4

        // ArrayProperty GFxUI.GFxMoviePlayer.SetVariableArray.Arg
        // 0x18 (0x10)
        // (Param | NeedCtorLink)
        public StructTArray<FASValue> Arg {
            get => new(Pointer + 24, 40);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }

        // BoolProperty GFxUI.GFxMoviePlayer.SetVariableArray.ReturnValue
        // 0x28 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 40) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x1;
                else *(uint*)(Pointer + 40) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetVariableArray;
    public bool SetVariableArray(FString Path, int Index, StructTArray<FASValue> Arg) {
        _ptrSetVariableArray ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetVariableArray");

        var @params = stackalloc byte[40];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&Index, @params + 16, 4, 4);
        System.Buffer.MemoryCopy((void*)Arg.Pointer, @params + 24, 16, 16);

        _ptrSetVariableArray.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetVariableArray, @params);
        _ptrSetVariableArray.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 40);
    }

    // Function GFxUI.GFxMoviePlayer.GetVariableStringArray
    // 0xC213A0
    // (Final | Native | Public | HasOutParams)
    public unsafe class GetVariableStringArray_Parameters : BaseObject {
        public GetVariableStringArray_Parameters() { }
        public GetVariableStringArray_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.GetVariableStringArray.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // IntProperty GFxUI.GFxMoviePlayer.GetVariableStringArray.Index
        // 0x10 (0x4)
        // (Param)
        public int Index {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }

        // MISSED OFFSET: 0x4

        // ArrayProperty GFxUI.GFxMoviePlayer.GetVariableStringArray.Arg
        // 0x18 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public StructTArray<FString> Arg {
            get => new(Pointer + 24, 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }

        // BoolProperty GFxUI.GFxMoviePlayer.GetVariableStringArray.ReturnValue
        // 0x28 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 40) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x1;
                else *(uint*)(Pointer + 40) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrGetVariableStringArray;
    public bool GetVariableStringArray(FString Path, int Index, ref StructTArray<FString> Arg) {
        _ptrGetVariableStringArray ??= FindFunction("Function GFxUI.GFxMoviePlayer.GetVariableStringArray");

        var @params = stackalloc byte[40];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&Index, @params + 16, 4, 4);
        System.Buffer.MemoryCopy((void*)Arg.Pointer, @params + 24, 16, 16);

        _ptrGetVariableStringArray.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetVariableStringArray, @params);
        _ptrGetVariableStringArray.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ArgPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 24, (void*)_ArgPtr, 16, 16);
        Arg = new(_ArgPtr, 16) { Allocated = true };

        return *(bool*)(@params + 40);
    }

    // Function GFxUI.GFxMoviePlayer.GetVariableFloatArray
    // 0xC21240
    // (Final | Native | Public | HasOutParams)
    public unsafe class GetVariableFloatArray_Parameters : BaseObject {
        public GetVariableFloatArray_Parameters() { }
        public GetVariableFloatArray_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.GetVariableFloatArray.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // IntProperty GFxUI.GFxMoviePlayer.GetVariableFloatArray.Index
        // 0x10 (0x4)
        // (Param)
        public int Index {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }

        // MISSED OFFSET: 0x4

        // ArrayProperty GFxUI.GFxMoviePlayer.GetVariableFloatArray.Arg
        // 0x18 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public UnmanagedTArray<float> Arg {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }

        // BoolProperty GFxUI.GFxMoviePlayer.GetVariableFloatArray.ReturnValue
        // 0x28 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 40) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x1;
                else *(uint*)(Pointer + 40) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrGetVariableFloatArray;
    public bool GetVariableFloatArray(FString Path, int Index, ref UnmanagedTArray<float> Arg) {
        _ptrGetVariableFloatArray ??= FindFunction("Function GFxUI.GFxMoviePlayer.GetVariableFloatArray");

        var @params = stackalloc byte[40];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&Index, @params + 16, 4, 4);
        System.Buffer.MemoryCopy((void*)Arg.Pointer, @params + 24, 16, 16);

        _ptrGetVariableFloatArray.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetVariableFloatArray, @params);
        _ptrGetVariableFloatArray.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ArgPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 24, (void*)_ArgPtr, 16, 16);
        Arg = new(_ArgPtr) { Allocated = true };

        return *(bool*)(@params + 40);
    }

    // Function GFxUI.GFxMoviePlayer.GetVariableIntArray
    // 0xC210E0
    // (Final | Native | Public | HasOutParams)
    public unsafe class GetVariableIntArray_Parameters : BaseObject {
        public GetVariableIntArray_Parameters() { }
        public GetVariableIntArray_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.GetVariableIntArray.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // IntProperty GFxUI.GFxMoviePlayer.GetVariableIntArray.Index
        // 0x10 (0x4)
        // (Param)
        public int Index {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }

        // MISSED OFFSET: 0x4

        // ArrayProperty GFxUI.GFxMoviePlayer.GetVariableIntArray.Arg
        // 0x18 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public UnmanagedTArray<int> Arg {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }

        // BoolProperty GFxUI.GFxMoviePlayer.GetVariableIntArray.ReturnValue
        // 0x28 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 40) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x1;
                else *(uint*)(Pointer + 40) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrGetVariableIntArray;
    public bool GetVariableIntArray(FString Path, int Index, ref UnmanagedTArray<int> Arg) {
        _ptrGetVariableIntArray ??= FindFunction("Function GFxUI.GFxMoviePlayer.GetVariableIntArray");

        var @params = stackalloc byte[40];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&Index, @params + 16, 4, 4);
        System.Buffer.MemoryCopy((void*)Arg.Pointer, @params + 24, 16, 16);

        _ptrGetVariableIntArray.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetVariableIntArray, @params);
        _ptrGetVariableIntArray.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ArgPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 24, (void*)_ArgPtr, 16, 16);
        Arg = new(_ArgPtr) { Allocated = true };

        return *(bool*)(@params + 40);
    }

    // Function GFxUI.GFxMoviePlayer.GetVariableArray
    // 0xC20F40
    // (Final | Native | Public | HasOutParams)
    public unsafe class GetVariableArray_Parameters : BaseObject {
        public GetVariableArray_Parameters() { }
        public GetVariableArray_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.GetVariableArray.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // IntProperty GFxUI.GFxMoviePlayer.GetVariableArray.Index
        // 0x10 (0x4)
        // (Param)
        public int Index {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }

        // MISSED OFFSET: 0x4

        // ArrayProperty GFxUI.GFxMoviePlayer.GetVariableArray.Arg
        // 0x18 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public StructTArray<FASValue> Arg {
            get => new(Pointer + 24, 40);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }

        // BoolProperty GFxUI.GFxMoviePlayer.GetVariableArray.ReturnValue
        // 0x28 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 40) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x1;
                else *(uint*)(Pointer + 40) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrGetVariableArray;
    public bool GetVariableArray(FString Path, int Index, ref StructTArray<FASValue> Arg) {
        _ptrGetVariableArray ??= FindFunction("Function GFxUI.GFxMoviePlayer.GetVariableArray");

        var @params = stackalloc byte[40];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&Index, @params + 16, 4, 4);
        System.Buffer.MemoryCopy((void*)Arg.Pointer, @params + 24, 16, 16);

        _ptrGetVariableArray.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetVariableArray, @params);
        _ptrGetVariableArray.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ArgPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 24, (void*)_ArgPtr, 16, 16);
        Arg = new(_ArgPtr, 40) { Allocated = true };

        return *(bool*)(@params + 40);
    }

    // Function GFxUI.GFxMoviePlayer.SetVariableObject
    // 0xC20E60
    // (Final | Native | Public)
    public unsafe class SetVariableObject_Parameters : BaseObject {
        public SetVariableObject_Parameters() { }
        public SetVariableObject_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.SetVariableObject.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ObjectProperty GFxUI.GFxMoviePlayer.SetVariableObject.Object
        // 0x10 (0x8)
        // (Param)
        public UGFxObject Object {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }
    }
    private static UFunction _ptrSetVariableObject;
    public void SetVariableObject(FString Path, UGFxObject Object) {
        _ptrSetVariableObject ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetVariableObject");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)Object.Pointer, @params + 16, 8, 8);

        _ptrSetVariableObject.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetVariableObject, @params);
        _ptrSetVariableObject.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.SetVariableString
    // 0xC20D60
    // (Final | Native | Public)
    public unsafe class SetVariableString_Parameters : BaseObject {
        public SetVariableString_Parameters() { }
        public SetVariableString_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.SetVariableString.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty GFxUI.GFxMoviePlayer.SetVariableString.S
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString S {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }
    }
    private static UFunction _ptrSetVariableString;
    public void SetVariableString(FString Path, FString S) {
        _ptrSetVariableString ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetVariableString");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)S.Pointer, @params + 16, 16, 16);

        _ptrSetVariableString.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetVariableString, @params);
        _ptrSetVariableString.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.SetVariableInt
    // 0xC20C80
    // (Final | Native | Public)
    public unsafe class SetVariableInt_Parameters : BaseObject {
        public SetVariableInt_Parameters() { }
        public SetVariableInt_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.SetVariableInt.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // IntProperty GFxUI.GFxMoviePlayer.SetVariableInt.I
        // 0x10 (0x4)
        // (Param)
        public int I {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }
    }
    private static UFunction _ptrSetVariableInt;
    public void SetVariableInt(FString Path, int I) {
        _ptrSetVariableInt ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetVariableInt");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&I, @params + 16, 4, 4);

        _ptrSetVariableInt.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetVariableInt, @params);
        _ptrSetVariableInt.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.SetVariableNumber
    // 0xC20BA0
    // (Final | Native | Public)
    public unsafe class SetVariableNumber_Parameters : BaseObject {
        public SetVariableNumber_Parameters() { }
        public SetVariableNumber_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.SetVariableNumber.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // FloatProperty GFxUI.GFxMoviePlayer.SetVariableNumber.F
        // 0x10 (0x4)
        // (Param)
        public float F {
            get => *(float*)(Pointer + 16);
            set => *(float*)(Pointer + 16) = value;
        }
    }
    private static UFunction _ptrSetVariableNumber;
    public void SetVariableNumber(FString Path, float F) {
        _ptrSetVariableNumber ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetVariableNumber");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&F, @params + 16, 4, 4);

        _ptrSetVariableNumber.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetVariableNumber, @params);
        _ptrSetVariableNumber.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.SetVariableBool
    // 0xC20AB0
    // (Final | Native | Public)
    public unsafe class SetVariableBool_Parameters : BaseObject {
        public SetVariableBool_Parameters() { }
        public SetVariableBool_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.SetVariableBool.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // BoolProperty GFxUI.GFxMoviePlayer.SetVariableBool.B
        // 0x10 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool B {
            get => (*(uint*)(Pointer + 16) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 16) |= 0x1;
                else *(uint*)(Pointer + 16) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetVariableBool;
    public void SetVariableBool(FString Path, bool B) {
        _ptrSetVariableBool ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetVariableBool");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&B, @params + 16, 4, 4);

        _ptrSetVariableBool.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetVariableBool, @params);
        _ptrSetVariableBool.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.SetVariable
    // 0xC20960
    // (Final | Native | Public)
    public unsafe class SetVariable_Parameters : BaseObject {
        public SetVariable_Parameters() { }
        public SetVariable_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.SetVariable.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StructProperty GFxUI.GFxMoviePlayer.SetVariable.Arg
        // 0x10 (0x28)
        // (Param | NeedCtorLink)
        public FASValue Arg {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 40, 40);
        }
    }
    private static UFunction _ptrSetVariable;
    public void SetVariable(FString Path, FASValue Arg) {
        _ptrSetVariable ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetVariable");

        var @params = stackalloc byte[56];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)Arg.Pointer, @params + 16, 40, 40);

        _ptrSetVariable.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetVariable, @params);
        _ptrSetVariable.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.GetVariableObject
    // 0xC20870
    // (Final | Native | HasOptionalParams | Public)
    public unsafe class GetVariableObject_Parameters : BaseObject {
        public GetVariableObject_Parameters() { }
        public GetVariableObject_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.GetVariableObject.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ClassProperty GFxUI.GFxMoviePlayer.GetVariableObject.Type
        // 0x10 (0x8)
        // (OptionalParam | Param)
        public UClass Type {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }

        // ObjectProperty GFxUI.GFxMoviePlayer.GetVariableObject.ReturnValue
        // 0x18 (0x8)
        // (Param | OutParam | ReturnParam)
        public UGFxObject ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 24);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 24) = value.Pointer;
        }
    }
    private static UFunction _ptrGetVariableObject;
    public UGFxObject GetVariableObject(FString Path, UClass Type = null) {
        _ptrGetVariableObject ??= FindFunction("Function GFxUI.GFxMoviePlayer.GetVariableObject");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);
        if (Type != null) System.Buffer.MemoryCopy((void*)Type.Pointer, @params + 16, 8, 8);

        _ptrGetVariableObject.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetVariableObject, @params);
        _ptrGetVariableObject.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)(@params + 24));
    }

    // Function GFxUI.GFxMoviePlayer.GetVariableString
    // 0xC20770
    // (Final | Native | Public)
    public unsafe class GetVariableString_Parameters : BaseObject {
        public GetVariableString_Parameters() { }
        public GetVariableString_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.GetVariableString.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty GFxUI.GFxMoviePlayer.GetVariableString.ReturnValue
        // 0x10 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }
    }
    private static UFunction _ptrGetVariableString;
    public FString GetVariableString(FString Path) {
        _ptrGetVariableString ??= FindFunction("Function GFxUI.GFxMoviePlayer.GetVariableString");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);

        _ptrGetVariableString.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetVariableString, @params);
        _ptrGetVariableString.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 16, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxMoviePlayer.GetVariableInt
    // 0xC206B0
    // (Final | Native | Public)
    public unsafe class GetVariableInt_Parameters : BaseObject {
        public GetVariableInt_Parameters() { }
        public GetVariableInt_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.GetVariableInt.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // IntProperty GFxUI.GFxMoviePlayer.GetVariableInt.ReturnValue
        // 0x10 (0x4)
        // (Param | OutParam | ReturnParam)
        public int ReturnValue {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }
    }
    private static UFunction _ptrGetVariableInt;
    public int GetVariableInt(FString Path) {
        _ptrGetVariableInt ??= FindFunction("Function GFxUI.GFxMoviePlayer.GetVariableInt");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);

        _ptrGetVariableInt.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetVariableInt, @params);
        _ptrGetVariableInt.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(int*)(@params + 16);
    }

    // Function GFxUI.GFxMoviePlayer.GetVariableNumber
    // 0xC205F0
    // (Final | Native | Public)
    public unsafe class GetVariableNumber_Parameters : BaseObject {
        public GetVariableNumber_Parameters() { }
        public GetVariableNumber_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.GetVariableNumber.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // FloatProperty GFxUI.GFxMoviePlayer.GetVariableNumber.ReturnValue
        // 0x10 (0x4)
        // (Param | OutParam | ReturnParam)
        public float ReturnValue {
            get => *(float*)(Pointer + 16);
            set => *(float*)(Pointer + 16) = value;
        }
    }
    private static UFunction _ptrGetVariableNumber;
    public float GetVariableNumber(FString Path) {
        _ptrGetVariableNumber ??= FindFunction("Function GFxUI.GFxMoviePlayer.GetVariableNumber");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);

        _ptrGetVariableNumber.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetVariableNumber, @params);
        _ptrGetVariableNumber.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(float*)(@params + 16);
    }

    // Function GFxUI.GFxMoviePlayer.GetVariableBool
    // 0xC20530
    // (Final | Native | Public)
    public unsafe class GetVariableBool_Parameters : BaseObject {
        public GetVariableBool_Parameters() { }
        public GetVariableBool_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.GetVariableBool.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // BoolProperty GFxUI.GFxMoviePlayer.GetVariableBool.ReturnValue
        // 0x10 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 16) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 16) |= 0x1;
                else *(uint*)(Pointer + 16) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrGetVariableBool;
    public bool GetVariableBool(FString Path) {
        _ptrGetVariableBool ??= FindFunction("Function GFxUI.GFxMoviePlayer.GetVariableBool");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);

        _ptrGetVariableBool.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetVariableBool, @params);
        _ptrGetVariableBool.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 16);
    }

    // Function GFxUI.GFxMoviePlayer.GetVariable
    // 0xC20450
    // (Final | Native | Public)
    public unsafe class GetVariable_Parameters : BaseObject {
        public GetVariable_Parameters() { }
        public GetVariable_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.GetVariable.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StructProperty GFxUI.GFxMoviePlayer.GetVariable.ReturnValue
        // 0x10 (0x28)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FASValue ReturnValue {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 40, 40);
        }
    }
    private static UFunction _ptrGetVariable;
    public FASValue GetVariable(FString Path) {
        _ptrGetVariable ??= FindFunction("Function GFxUI.GFxMoviePlayer.GetVariable");

        var @params = stackalloc byte[56];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);

        _ptrGetVariable.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetVariable, @params);
        _ptrGetVariable.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(40);
        System.Buffer.MemoryCopy(@params + 16, (void*)_ReturnValuePtr, 40, 40);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxMoviePlayer.GetAVMVersion
    // 0xC20400
    // (Final | Native | Public)
    public unsafe class GetAVMVersion_Parameters : BaseObject {
        public GetAVMVersion_Parameters() { }
        public GetAVMVersion_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxMoviePlayer.GetAVMVersion.ReturnValue
        // 0x0 (0x4)
        // (Param | OutParam | ReturnParam)
        public int ReturnValue {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrGetAVMVersion;
    public int GetAVMVersion() {
        _ptrGetAVMVersion ??= FindFunction("Function GFxUI.GFxMoviePlayer.GetAVMVersion");

        var @params = stackalloc byte[4];

        _ptrGetAVMVersion.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetAVMVersion, @params);
        _ptrGetAVMVersion.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(int*)@params;
    }

    // Function GFxUI.GFxMoviePlayer.FilterButtonInput
    // 0x3750E0
    // (Final | Event | Public)
    public unsafe class FilterButtonInput_Parameters : BaseObject {
        public FilterButtonInput_Parameters() { }
        public FilterButtonInput_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxMoviePlayer.FilterButtonInput.ControllerId
        // 0x0 (0x4)
        // (Param)
        public int ControllerId {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // NameProperty GFxUI.GFxMoviePlayer.FilterButtonInput.ButtonName
        // 0x4 (0x8)
        // (Param)
        public FName ButtonName {
            get => new(Pointer + 4);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 4), 8, 8);
        }

        // ByteProperty GFxUI.GFxMoviePlayer.FilterButtonInput.InputEvent
        // 0xC (0x1)
        // (Param)
        public UObject.EInputEvent InputEvent {
            get => *(UObject.EInputEvent*)(Pointer + 12);
            set => *(UObject.EInputEvent*)(Pointer + 12) = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty GFxUI.GFxMoviePlayer.FilterButtonInput.ReturnValue
        // 0x10 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 16) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 16) |= 0x1;
                else *(uint*)(Pointer + 16) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrFilterButtonInput;
    public bool FilterButtonInput(int ControllerId, FName ButtonName, UObject.EInputEvent InputEvent) {
        _ptrFilterButtonInput ??= FindFunction("Function GFxUI.GFxMoviePlayer.FilterButtonInput");

        var @params = stackalloc byte[17];
        System.Buffer.MemoryCopy(&ControllerId, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)ButtonName.Pointer, @params + 4, 8, 8);
        System.Buffer.MemoryCopy(&InputEvent, @params + 12, 1, 1);

        ProcessEvent(_ptrFilterButtonInput, @params);

        return *(bool*)(@params + 16);
    }

    // Function GFxUI.GFxMoviePlayer.FlushPlayerInput
    // 0xC20370
    // (Final | Native | Public)
    public unsafe class FlushPlayerInput_Parameters : BaseObject {
        public FlushPlayerInput_Parameters() { }
        public FlushPlayerInput_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty GFxUI.GFxMoviePlayer.FlushPlayerInput.capturekeysonly
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool capturekeysonly {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrFlushPlayerInput;
    public void FlushPlayerInput(bool capturekeysonly) {
        _ptrFlushPlayerInput ??= FindFunction("Function GFxUI.GFxMoviePlayer.FlushPlayerInput");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&capturekeysonly, @params, 4, 4);

        _ptrFlushPlayerInput.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrFlushPlayerInput, @params);
        _ptrFlushPlayerInput.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.ClearFocusIgnoreKeys
    // 0xC20330
    // (Final | Native | Public)
    public unsafe class ClearFocusIgnoreKeys_Parameters : BaseObject {
        public ClearFocusIgnoreKeys_Parameters() { }
        public ClearFocusIgnoreKeys_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrClearFocusIgnoreKeys;
    public void ClearFocusIgnoreKeys() {
        _ptrClearFocusIgnoreKeys ??= FindFunction("Function GFxUI.GFxMoviePlayer.ClearFocusIgnoreKeys");

        _ptrClearFocusIgnoreKeys.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrClearFocusIgnoreKeys, null);
        _ptrClearFocusIgnoreKeys.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.AddFocusIgnoreKey
    // 0xC202B0
    // (Final | Native | Public)
    public unsafe class AddFocusIgnoreKey_Parameters : BaseObject {
        public AddFocusIgnoreKey_Parameters() { }
        public AddFocusIgnoreKey_Parameters(nint pointer) : base(pointer) { }

        // NameProperty GFxUI.GFxMoviePlayer.AddFocusIgnoreKey.Key
        // 0x0 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }
    }
    private static UFunction _ptrAddFocusIgnoreKey;
    public void AddFocusIgnoreKey(FName Key) {
        _ptrAddFocusIgnoreKey ??= FindFunction("Function GFxUI.GFxMoviePlayer.AddFocusIgnoreKey");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params, 8, 8);

        _ptrAddFocusIgnoreKey.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrAddFocusIgnoreKey, @params);
        _ptrAddFocusIgnoreKey.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.ClearCaptureKeys
    // 0xC20270
    // (Final | Native | Public)
    public unsafe class ClearCaptureKeys_Parameters : BaseObject {
        public ClearCaptureKeys_Parameters() { }
        public ClearCaptureKeys_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrClearCaptureKeys;
    public void ClearCaptureKeys() {
        _ptrClearCaptureKeys ??= FindFunction("Function GFxUI.GFxMoviePlayer.ClearCaptureKeys");

        _ptrClearCaptureKeys.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrClearCaptureKeys, null);
        _ptrClearCaptureKeys.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.AddCaptureKey
    // 0xC201F0
    // (Final | Native | Public)
    public unsafe class AddCaptureKey_Parameters : BaseObject {
        public AddCaptureKey_Parameters() { }
        public AddCaptureKey_Parameters(nint pointer) : base(pointer) { }

        // NameProperty GFxUI.GFxMoviePlayer.AddCaptureKey.Key
        // 0x0 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }
    }
    private static UFunction _ptrAddCaptureKey;
    public void AddCaptureKey(FName Key) {
        _ptrAddCaptureKey ??= FindFunction("Function GFxUI.GFxMoviePlayer.AddCaptureKey");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params, 8, 8);

        _ptrAddCaptureKey.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrAddCaptureKey, @params);
        _ptrAddCaptureKey.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.SetMovieCanReceiveInput
    // 0xC20160
    // (Final | Native | Public)
    public unsafe class SetMovieCanReceiveInput_Parameters : BaseObject {
        public SetMovieCanReceiveInput_Parameters() { }
        public SetMovieCanReceiveInput_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty GFxUI.GFxMoviePlayer.SetMovieCanReceiveInput.bCanReceiveInput
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bCanReceiveInput {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetMovieCanReceiveInput;
    public void SetMovieCanReceiveInput(bool bCanReceiveInput) {
        _ptrSetMovieCanReceiveInput ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetMovieCanReceiveInput");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bCanReceiveInput, @params, 4, 4);

        _ptrSetMovieCanReceiveInput.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetMovieCanReceiveInput, @params);
        _ptrSetMovieCanReceiveInput.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.SetMovieCanReceiveFocus
    // 0xC200D0
    // (Final | Native | Public)
    public unsafe class SetMovieCanReceiveFocus_Parameters : BaseObject {
        public SetMovieCanReceiveFocus_Parameters() { }
        public SetMovieCanReceiveFocus_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty GFxUI.GFxMoviePlayer.SetMovieCanReceiveFocus.bCanReceiveFocus
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bCanReceiveFocus {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetMovieCanReceiveFocus;
    public void SetMovieCanReceiveFocus(bool bCanReceiveFocus) {
        _ptrSetMovieCanReceiveFocus ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetMovieCanReceiveFocus");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bCanReceiveFocus, @params, 4, 4);

        _ptrSetMovieCanReceiveFocus.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetMovieCanReceiveFocus, @params);
        _ptrSetMovieCanReceiveFocus.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.SetPerspective3D
    // 0xC20030
    // (Final | Native | Public | HasOutParams)
    public unsafe class SetPerspective3D_Parameters : BaseObject {
        public SetPerspective3D_Parameters() { }
        public SetPerspective3D_Parameters(nint pointer) : base(pointer) { }

        // StructProperty GFxUI.GFxMoviePlayer.SetPerspective3D.matPersp
        // 0x0 (0x40)
        // (Const | Param | OutParam)
        public FMatrix matPersp {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 64, 64);
        }
    }
    private static UFunction _ptrSetPerspective3D;
    public void SetPerspective3D(ref FMatrix matPersp) {
        _ptrSetPerspective3D ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetPerspective3D");

        var @params = stackalloc byte[64];
        System.Buffer.MemoryCopy((void*)matPersp.Pointer, @params, 64, 64);

        _ptrSetPerspective3D.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetPerspective3D, @params);
        _ptrSetPerspective3D.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _matPerspPtr = Marshal.AllocHGlobal(64);
        System.Buffer.MemoryCopy(@params, (void*)_matPerspPtr, 64, 64);
        matPersp = new(_matPerspPtr) { Allocated = true };
    }

    // Function GFxUI.GFxMoviePlayer.SetView3D
    // 0xC1FF90
    // (Final | Native | Public | HasOutParams)
    public unsafe class SetView3D_Parameters : BaseObject {
        public SetView3D_Parameters() { }
        public SetView3D_Parameters(nint pointer) : base(pointer) { }

        // StructProperty GFxUI.GFxMoviePlayer.SetView3D.matView
        // 0x0 (0x40)
        // (Const | Param | OutParam)
        public FMatrix matView {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 64, 64);
        }
    }
    private static UFunction _ptrSetView3D;
    public void SetView3D(ref FMatrix matView) {
        _ptrSetView3D ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetView3D");

        var @params = stackalloc byte[64];
        System.Buffer.MemoryCopy((void*)matView.Pointer, @params, 64, 64);

        _ptrSetView3D.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetView3D, @params);
        _ptrSetView3D.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _matViewPtr = Marshal.AllocHGlobal(64);
        System.Buffer.MemoryCopy(@params, (void*)_matViewPtr, 64, 64);
        matView = new(_matViewPtr) { Allocated = true };
    }

    // Function GFxUI.GFxMoviePlayer.GetVisibleFrameRect
    // 0xC1FD90
    // (Final | Native | Public | HasOutParams)
    public unsafe class GetVisibleFrameRect_Parameters : BaseObject {
        public GetVisibleFrameRect_Parameters() { }
        public GetVisibleFrameRect_Parameters(nint pointer) : base(pointer) { }

        // FloatProperty GFxUI.GFxMoviePlayer.GetVisibleFrameRect.x0
        // 0x0 (0x4)
        // (Param | OutParam)
        public float x0 {
            get => *(float*)Pointer;
            set => *(float*)Pointer = value;
        }

        // FloatProperty GFxUI.GFxMoviePlayer.GetVisibleFrameRect.y0
        // 0x4 (0x4)
        // (Param | OutParam)
        public float y0 {
            get => *(float*)(Pointer + 4);
            set => *(float*)(Pointer + 4) = value;
        }

        // FloatProperty GFxUI.GFxMoviePlayer.GetVisibleFrameRect.X1
        // 0x8 (0x4)
        // (Param | OutParam)
        public float X1 {
            get => *(float*)(Pointer + 8);
            set => *(float*)(Pointer + 8) = value;
        }

        // FloatProperty GFxUI.GFxMoviePlayer.GetVisibleFrameRect.Y1
        // 0xC (0x4)
        // (Param | OutParam)
        public float Y1 {
            get => *(float*)(Pointer + 12);
            set => *(float*)(Pointer + 12) = value;
        }
    }
    private static UFunction _ptrGetVisibleFrameRect;
    public void GetVisibleFrameRect(ref float x0, ref float y0, ref float X1, ref float Y1) {
        _ptrGetVisibleFrameRect ??= FindFunction("Function GFxUI.GFxMoviePlayer.GetVisibleFrameRect");

        var @params = stackalloc byte[16];
        var _x0 = x0;
        System.Buffer.MemoryCopy(&_x0, @params, 4, 4);
        var _y0 = y0;
        System.Buffer.MemoryCopy(&_y0, @params + 4, 4, 4);
        var _X1 = X1;
        System.Buffer.MemoryCopy(&_X1, @params + 8, 4, 4);
        var _Y1 = Y1;
        System.Buffer.MemoryCopy(&_Y1, @params + 12, 4, 4);

        _ptrGetVisibleFrameRect.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetVisibleFrameRect, @params);
        _ptrGetVisibleFrameRect.FunctionFlags |= (ulong)EFunctionFlags.Native;

        x0 = *(float*)@params;
        y0 = *(float*)(@params + 4);
        X1 = *(float*)(@params + 8);
        Y1 = *(float*)(@params + 12);
    }

    // Function GFxUI.GFxMoviePlayer.SetAlignment
    // 0xC1FD10
    // (Final | Native | Public)
    public unsafe class SetAlignment_Parameters : BaseObject {
        public SetAlignment_Parameters() { }
        public SetAlignment_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty GFxUI.GFxMoviePlayer.SetAlignment.A
        // 0x0 (0x1)
        // (Param)
        public GFxAlign A {
            get => *(GFxAlign*)Pointer;
            set => *(GFxAlign*)Pointer = value;
        }
    }
    private static UFunction _ptrSetAlignment;
    public void SetAlignment(GFxAlign A) {
        _ptrSetAlignment ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetAlignment");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&A, @params, 1, 1);

        _ptrSetAlignment.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetAlignment, @params);
        _ptrSetAlignment.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.SetViewScaleMode
    // 0xC1FC90
    // (Final | Native | Public)
    public unsafe class SetViewScaleMode_Parameters : BaseObject {
        public SetViewScaleMode_Parameters() { }
        public SetViewScaleMode_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty GFxUI.GFxMoviePlayer.SetViewScaleMode.SM
        // 0x0 (0x1)
        // (Param)
        public GFxScaleMode SM {
            get => *(GFxScaleMode*)Pointer;
            set => *(GFxScaleMode*)Pointer = value;
        }
    }
    private static UFunction _ptrSetViewScaleMode;
    public void SetViewScaleMode(GFxScaleMode SM) {
        _ptrSetViewScaleMode ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetViewScaleMode");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&SM, @params, 1, 1);

        _ptrSetViewScaleMode.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetViewScaleMode, @params);
        _ptrSetViewScaleMode.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.SetViewport
    // 0xC1FB90
    // (Final | Native | Public)
    public unsafe class SetViewport_Parameters : BaseObject {
        public SetViewport_Parameters() { }
        public SetViewport_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxMoviePlayer.SetViewport.X
        // 0x0 (0x4)
        // (Param)
        public int X {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // IntProperty GFxUI.GFxMoviePlayer.SetViewport.Y
        // 0x4 (0x4)
        // (Param)
        public int Y {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }

        // IntProperty GFxUI.GFxMoviePlayer.SetViewport.Width
        // 0x8 (0x4)
        // (Param)
        public int Width {
            get => *(int*)(Pointer + 8);
            set => *(int*)(Pointer + 8) = value;
        }

        // IntProperty GFxUI.GFxMoviePlayer.SetViewport.Height
        // 0xC (0x4)
        // (Param)
        public int Height {
            get => *(int*)(Pointer + 12);
            set => *(int*)(Pointer + 12) = value;
        }
    }
    private static UFunction _ptrSetViewport;
    public void SetViewport(int X, int Y, int Width, int Height) {
        _ptrSetViewport ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetViewport");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy(&X, @params, 4, 4);
        System.Buffer.MemoryCopy(&Y, @params + 4, 4, 4);
        System.Buffer.MemoryCopy(&Width, @params + 8, 4, 4);
        System.Buffer.MemoryCopy(&Height, @params + 12, 4, 4);

        _ptrSetViewport.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetViewport, @params);
        _ptrSetViewport.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.GetGameViewportClient
    // 0xC1FB40
    // (Final | Native | Public)
    public unsafe class GetGameViewportClient_Parameters : BaseObject {
        public GetGameViewportClient_Parameters() { }
        public GetGameViewportClient_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty GFxUI.GFxMoviePlayer.GetGameViewportClient.ReturnValue
        // 0x0 (0x8)
        // (Param | OutParam | ReturnParam)
        public UGameViewportClient ReturnValue {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrGetGameViewportClient;
    public UGameViewportClient GetGameViewportClient() {
        _ptrGetGameViewportClient ??= FindFunction("Function GFxUI.GFxMoviePlayer.GetGameViewportClient");

        var @params = stackalloc byte[8];

        _ptrGetGameViewportClient.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetGameViewportClient, @params);
        _ptrGetGameViewportClient.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)@params);
    }

    // Function GFxUI.GFxMoviePlayer.SetPriority
    // 0xC1FAC0
    // (Final | Native | Public)
    public unsafe class SetPriority_Parameters : BaseObject {
        public SetPriority_Parameters() { }
        public SetPriority_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty GFxUI.GFxMoviePlayer.SetPriority.NewPriority
        // 0x0 (0x1)
        // (Param)
        public byte NewPriority {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }
    }
    private static UFunction _ptrSetPriority;
    public void SetPriority(byte NewPriority) {
        _ptrSetPriority ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetPriority");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&NewPriority, @params, 1, 1);

        _ptrSetPriority.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetPriority, @params);
        _ptrSetPriority.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.SetExternalTexture
    // 0xC1F9E0
    // (Final | Native | Public)
    public unsafe class SetExternalTexture_Parameters : BaseObject {
        public SetExternalTexture_Parameters() { }
        public SetExternalTexture_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.SetExternalTexture.Resource
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Resource {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ObjectProperty GFxUI.GFxMoviePlayer.SetExternalTexture.Texture
        // 0x10 (0x8)
        // (Param)
        public UTexture Texture {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }

        // BoolProperty GFxUI.GFxMoviePlayer.SetExternalTexture.ReturnValue
        // 0x18 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 24) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 24) |= 0x1;
                else *(uint*)(Pointer + 24) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetExternalTexture;
    public bool SetExternalTexture(FString Resource, UTexture Texture) {
        _ptrSetExternalTexture ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetExternalTexture");

        var @params = stackalloc byte[28];
        System.Buffer.MemoryCopy((void*)Resource.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)Texture.Pointer, @params + 16, 8, 8);

        _ptrSetExternalTexture.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetExternalTexture, @params);
        _ptrSetExternalTexture.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 24);
    }

    // Function GFxUI.GFxMoviePlayer.SetExternalInterface
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class SetExternalInterface_Parameters : BaseObject {
        public SetExternalInterface_Parameters() { }
        public SetExternalInterface_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty GFxUI.GFxMoviePlayer.SetExternalInterface.H
        // 0x0 (0x8)
        // (Param)
        public UObject H {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrSetExternalInterface;
    public void SetExternalInterface(UObject H) {
        _ptrSetExternalInterface ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetExternalInterface");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy((void*)H.Pointer, @params, 8, 8);

        ProcessEvent(_ptrSetExternalInterface, @params);
    }

    // Function GFxUI.GFxMoviePlayer.SetTimingMode
    // 0xC1F960
    // (Final | Native | Public)
    public unsafe class SetTimingMode_Parameters : BaseObject {
        public SetTimingMode_Parameters() { }
        public SetTimingMode_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty GFxUI.GFxMoviePlayer.SetTimingMode.Mode
        // 0x0 (0x1)
        // (Param)
        public GFxTimingMode Mode {
            get => *(GFxTimingMode*)Pointer;
            set => *(GFxTimingMode*)Pointer = value;
        }
    }
    private static UFunction _ptrSetTimingMode;
    public void SetTimingMode(GFxTimingMode Mode) {
        _ptrSetTimingMode ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetTimingMode");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&Mode, @params, 1, 1);

        _ptrSetTimingMode.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetTimingMode, @params);
        _ptrSetTimingMode.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.SetMovieInfo
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class SetMovieInfo_Parameters : BaseObject {
        public SetMovieInfo_Parameters() { }
        public SetMovieInfo_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty GFxUI.GFxMoviePlayer.SetMovieInfo.Data
        // 0x0 (0x8)
        // (Param)
        public USwfMovie Data {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrSetMovieInfo;
    public void SetMovieInfo(USwfMovie Data) {
        _ptrSetMovieInfo ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetMovieInfo");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy((void*)Data.Pointer, @params, 8, 8);

        ProcessEvent(_ptrSetMovieInfo, @params);
    }

    // Function GFxUI.GFxMoviePlayer.ConditionalClearPause
    // 0x3750E0
    // (Final | Defined | Event | Public)
    public unsafe class ConditionalClearPause_Parameters : BaseObject {
        public ConditionalClearPause_Parameters() { }
        public ConditionalClearPause_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrConditionalClearPause;
    public void ConditionalClearPause() {
        _ptrConditionalClearPause ??= FindFunction("Function GFxUI.GFxMoviePlayer.ConditionalClearPause");

        ProcessEvent(_ptrConditionalClearPause, null);
    }

    // Function GFxUI.GFxMoviePlayer.OnCleanup
    // 0x3750E0
    // (Final | Event | Public)
    public unsafe class OnCleanup_Parameters : BaseObject {
        public OnCleanup_Parameters() { }
        public OnCleanup_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrOnCleanup;
    public void OnCleanup() {
        _ptrOnCleanup ??= FindFunction("Function GFxUI.GFxMoviePlayer.OnCleanup");

        ProcessEvent(_ptrOnCleanup, null);
    }

    // Function GFxUI.GFxMoviePlayer.OnClose
    // 0x3750E0
    // (Event | Public)
    public unsafe class OnClose_Parameters : BaseObject {
        public OnClose_Parameters() { }
        public OnClose_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrOnClose;
    public void OnClose() {
        _ptrOnClose ??= FindFunction("Function GFxUI.GFxMoviePlayer.OnClose");

        ProcessEvent(_ptrOnClose, null);
    }

    // Function GFxUI.GFxMoviePlayer.Close
    // 0xC1F8D0
    // (Final | Native | HasOptionalParams | Public)
    public unsafe class Close_Parameters : BaseObject {
        public Close_Parameters() { }
        public Close_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty GFxUI.GFxMoviePlayer.Close.Unload
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool Unload {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrClose;
    public void Close(bool Unload = false) {
        _ptrClose ??= FindFunction("Function GFxUI.GFxMoviePlayer.Close");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&Unload, @params, 4, 4);

        _ptrClose.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrClose, @params);
        _ptrClose.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.SetPause
    // 0xC1F840
    // (Final | Native | HasOptionalParams | Public)
    public unsafe class SetPause_Parameters : BaseObject {
        public SetPause_Parameters() { }
        public SetPause_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty GFxUI.GFxMoviePlayer.SetPause.bPausePlayback
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bPausePlayback {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetPause;
    public void SetPause(bool bPausePlayback = false) {
        _ptrSetPause ??= FindFunction("Function GFxUI.GFxMoviePlayer.SetPause");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bPausePlayback, @params, 4, 4);

        _ptrSetPause.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetPause, @params);
        _ptrSetPause.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.OnPostAdvance
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnPostAdvance_Parameters : BaseObject {
        public OnPostAdvance_Parameters() { }
        public OnPostAdvance_Parameters(nint pointer) : base(pointer) { }

        // FloatProperty GFxUI.GFxMoviePlayer.OnPostAdvance.DeltaTime
        // 0x0 (0x4)
        // (Param)
        public float DeltaTime {
            get => *(float*)Pointer;
            set => *(float*)Pointer = value;
        }
    }
    private static UFunction _ptrOnPostAdvance;
    public void OnPostAdvance(float DeltaTime) {
        _ptrOnPostAdvance ??= FindFunction("Function GFxUI.GFxMoviePlayer.OnPostAdvance");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&DeltaTime, @params, 4, 4);

        ProcessEvent(_ptrOnPostAdvance, @params);
    }

    // Function GFxUI.GFxMoviePlayer.PostAdvance
    // 0xC1F7C0
    // (Final | Native | Public)
    public unsafe class PostAdvance_Parameters : BaseObject {
        public PostAdvance_Parameters() { }
        public PostAdvance_Parameters(nint pointer) : base(pointer) { }

        // FloatProperty GFxUI.GFxMoviePlayer.PostAdvance.DeltaTime
        // 0x0 (0x4)
        // (Param)
        public float DeltaTime {
            get => *(float*)Pointer;
            set => *(float*)Pointer = value;
        }
    }
    private static UFunction _ptrPostAdvance;
    public void PostAdvance(float DeltaTime) {
        _ptrPostAdvance ??= FindFunction("Function GFxUI.GFxMoviePlayer.PostAdvance");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&DeltaTime, @params, 4, 4);

        _ptrPostAdvance.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrPostAdvance, @params);
        _ptrPostAdvance.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.Advance
    // 0xC1F740
    // (Final | Native | Public)
    public unsafe class Advance_Parameters : BaseObject {
        public Advance_Parameters() { }
        public Advance_Parameters(nint pointer) : base(pointer) { }

        // FloatProperty GFxUI.GFxMoviePlayer.Advance.Time
        // 0x0 (0x4)
        // (Param)
        public float Time {
            get => *(float*)Pointer;
            set => *(float*)Pointer = value;
        }
    }
    private static UFunction _ptrAdvance;
    public void Advance(float Time) {
        _ptrAdvance ??= FindFunction("Function GFxUI.GFxMoviePlayer.Advance");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&Time, @params, 4, 4);

        _ptrAdvance.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrAdvance, @params);
        _ptrAdvance.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxMoviePlayer.Start
    // 0xC1F690
    // (Native | Event | HasOptionalParams | Public)
    public unsafe class Start_Parameters : BaseObject {
        public Start_Parameters() { }
        public Start_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty GFxUI.GFxMoviePlayer.Start.StartPaused
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool StartPaused {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }

        // BoolProperty GFxUI.GFxMoviePlayer.Start.ReturnValue
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrStart;
    public bool Start(bool StartPaused = false) {
        _ptrStart ??= FindFunction("Function GFxUI.GFxMoviePlayer.Start");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&StartPaused, @params, 4, 4);

        _ptrStart.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrStart, @params);
        _ptrStart.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 4);
    }


    // ScriptStruct GFxUI.GFxMoviePlayer.ASValue
    // 0x28
    public unsafe class FASValue : BaseObject {
        public FASValue() {
            Pointer = Marshal.AllocHGlobal(40);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 40);
            Allocated = true;
        }
        public FASValue(nint pointer) : base(pointer) { }

        // ByteProperty GFxUI.GFxMoviePlayer.ASValue.Type
        // 0x0 (0x1)
        // (Edit)
        public ASType Type {
            get => *(ASType*)Pointer;
            set => *(ASType*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty GFxUI.GFxMoviePlayer.ASValue.B
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (Edit)
        public bool B {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // FloatProperty GFxUI.GFxMoviePlayer.ASValue.N
        // 0x8 (0x4)
        // (Edit)
        public float N {
            get => *(float*)(Pointer + 8);
            set => *(float*)(Pointer + 8) = value;
        }

        // IntProperty GFxUI.GFxMoviePlayer.ASValue.I
        // 0xC (0x4)
        // (Edit)
        public int I {
            get => *(int*)(Pointer + 12);
            set => *(int*)(Pointer + 12) = value;
        }

        // StrProperty GFxUI.GFxMoviePlayer.ASValue.S
        // 0x10 (0x10)
        // (Edit | AlwaysInit | NeedCtorLink)
        public FString S {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // ObjectProperty GFxUI.GFxMoviePlayer.ASValue.T
        // 0x20 (0x8)
        // (Edit)
        public UTexture T {
            get {
                var pointer = *(nint*)(Pointer + 32);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 32) = value.Pointer;
        }
    }

    // ScriptStruct GFxUI.GFxMoviePlayer.GFxWidgetBinding
    // 0x10
    public unsafe class FGFxWidgetBinding : BaseObject {
        public FGFxWidgetBinding() {
            Pointer = Marshal.AllocHGlobal(16);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 16);
            Allocated = true;
        }
        public FGFxWidgetBinding(nint pointer) : base(pointer) { }

        // NameProperty GFxUI.GFxMoviePlayer.GFxWidgetBinding.WidgetName
        // 0x0 (0x8)
        // (Edit)
        public FName WidgetName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // ClassProperty GFxUI.GFxMoviePlayer.GFxWidgetBinding.WidgetClass
        // 0x8 (0x8)
        // (Edit)
        public UClass WidgetClass {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }
    }

    // ScriptStruct GFxUI.GFxMoviePlayer.SoundThemeBinding
    // 0x20
    public unsafe class FSoundThemeBinding : BaseObject {
        public FSoundThemeBinding() {
            Pointer = Marshal.AllocHGlobal(32);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 32);
            Allocated = true;
        }
        public FSoundThemeBinding(nint pointer) : base(pointer) { }

        // NameProperty GFxUI.GFxMoviePlayer.SoundThemeBinding.ThemeName
        // 0x0 (0x8)
        // (Edit)
        public FName ThemeName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // ObjectProperty GFxUI.GFxMoviePlayer.SoundThemeBinding.Theme
        // 0x8 (0x8)
        // (Edit)
        public UUISoundTheme Theme {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // StrProperty GFxUI.GFxMoviePlayer.SoundThemeBinding.ThemeClassName
        // 0x10 (0x10)
        // (Edit | NeedCtorLink)
        public FString ThemeClassName {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }
    }

    // ScriptStruct GFxUI.GFxMoviePlayer.ExternalTexture
    // 0x18
    public unsafe class FExternalTexture : BaseObject {
        public FExternalTexture() {
            Pointer = Marshal.AllocHGlobal(24);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 24);
            Allocated = true;
        }
        public FExternalTexture(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxMoviePlayer.ExternalTexture.Resource
        // 0x0 (0x10)
        // (Edit | NeedCtorLink)
        public FString Resource {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ObjectProperty GFxUI.GFxMoviePlayer.ExternalTexture.Texture
        // 0x10 (0x8)
        // (Edit)
        public UTexture Texture {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }
    }


    // Enum GFxUI.GFxMoviePlayer.GFxAlign
    public enum GFxAlign : byte {
        Align_Center = 0,
        Align_TopCenter = 1,
        Align_BottomCenter = 2,
        Align_CenterLeft = 3,
        Align_CenterRight = 4,
        Align_TopLeft = 5,
        Align_TopRight = 6,
        Align_BottomLeft = 7,
        Align_BottomRight = 8,
        Align_MAX = 9
    }

    // Enum GFxUI.GFxMoviePlayer.GFxScaleMode
    public enum GFxScaleMode : byte {
        SM_NoScale = 0,
        SM_ShowAll = 1,
        SM_ExactFit = 2,
        SM_NoBorder = 3,
        SM_MAX = 4
    }

    // Enum GFxUI.GFxMoviePlayer.ASType
    public enum ASType : byte {
        AS_Undefined = 0,
        AS_Null = 1,
        AS_Number = 2,
        AS_Int = 3,
        AS_String = 4,
        AS_Boolean = 5,
        AS_Texture = 6,
        AS_UInt = 7,
        AS_MAX = 8
    }

    // Enum GFxUI.GFxMoviePlayer.GFxRenderTextureMode
    public enum GFxRenderTextureMode : byte {
        RTM_Opaque = 0,
        RTM_Alpha = 1,
        RTM_AlphaComposite = 2,
        RTM_MAX = 3
    }

    // Enum GFxUI.GFxMoviePlayer.GFxTimingMode
    public enum GFxTimingMode : byte {
        TM_Game = 0,
        TM_Real = 1,
        TM_MAX = 2
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class GFxUI.GFxMoviePlayer");
            return _staticClass;
        }
    }
}

// Class GFxUI.GFxObject
// 0x40 (0x60 - 0xA0)
// (Compiled | Parsed | Native)
public unsafe partial class UGFxObject : UObject {
    public UGFxObject() { }
    public UGFxObject(nint pointer) : base(pointer) { }


    // IntProperty GFxUI.GFxObject.Value
    // 0x60 (0x30)
    // (Const | Native)
    // Fixed array size: 12
    public UnmanagedFixedArray<int> Value {
        get => new(Pointer + 96, 12);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 96), 48, 48);
    }

    // ArrayProperty GFxUI.GFxObject.SubWidgetBindings
    // 0x90 (0x10)
    // (NeedCtorLink)
    public StructTArray<UGFxMoviePlayer.FGFxWidgetBinding> SubWidgetBindings {
        get => new(Pointer + 144, 16);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 144), 16, 16);
    }


    // Function GFxUI.GFxObject.WidgetUnloaded
    // 0x3750E0
    // (Final | Event | Public)
    public unsafe class WidgetUnloaded_Parameters : BaseObject {
        public WidgetUnloaded_Parameters() { }
        public WidgetUnloaded_Parameters(nint pointer) : base(pointer) { }

        // NameProperty GFxUI.GFxObject.WidgetUnloaded.WidgetName
        // 0x0 (0x8)
        // (Param)
        public FName WidgetName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // NameProperty GFxUI.GFxObject.WidgetUnloaded.WidgetPath
        // 0x8 (0x8)
        // (Param)
        public FName WidgetPath {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 8, 8);
        }

        // ObjectProperty GFxUI.GFxObject.WidgetUnloaded.Widget
        // 0x10 (0x8)
        // (Param)
        public UGFxObject Widget {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }

        // BoolProperty GFxUI.GFxObject.WidgetUnloaded.ReturnValue
        // 0x18 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 24) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 24) |= 0x1;
                else *(uint*)(Pointer + 24) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrWidgetUnloaded;
    public bool WidgetUnloaded(FName WidgetName, FName WidgetPath, UGFxObject Widget) {
        _ptrWidgetUnloaded ??= FindFunction("Function GFxUI.GFxObject.WidgetUnloaded");

        var @params = stackalloc byte[28];
        System.Buffer.MemoryCopy((void*)WidgetName.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)WidgetPath.Pointer, @params + 8, 8, 8);
        System.Buffer.MemoryCopy((void*)Widget.Pointer, @params + 16, 8, 8);

        ProcessEvent(_ptrWidgetUnloaded, @params);

        return *(bool*)(@params + 24);
    }

    // Function GFxUI.GFxObject.WidgetInitialized
    // 0x3750E0
    // (Final | Event | Public)
    public unsafe class WidgetInitialized_Parameters : BaseObject {
        public WidgetInitialized_Parameters() { }
        public WidgetInitialized_Parameters(nint pointer) : base(pointer) { }

        // NameProperty GFxUI.GFxObject.WidgetInitialized.WidgetName
        // 0x0 (0x8)
        // (Param)
        public FName WidgetName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // NameProperty GFxUI.GFxObject.WidgetInitialized.WidgetPath
        // 0x8 (0x8)
        // (Param)
        public FName WidgetPath {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 8, 8);
        }

        // ObjectProperty GFxUI.GFxObject.WidgetInitialized.Widget
        // 0x10 (0x8)
        // (Param)
        public UGFxObject Widget {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }

        // BoolProperty GFxUI.GFxObject.WidgetInitialized.ReturnValue
        // 0x18 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 24) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 24) |= 0x1;
                else *(uint*)(Pointer + 24) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrWidgetInitialized;
    public bool WidgetInitialized(FName WidgetName, FName WidgetPath, UGFxObject Widget) {
        _ptrWidgetInitialized ??= FindFunction("Function GFxUI.GFxObject.WidgetInitialized");

        var @params = stackalloc byte[28];
        System.Buffer.MemoryCopy((void*)WidgetName.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)WidgetPath.Pointer, @params + 8, 8, 8);
        System.Buffer.MemoryCopy((void*)Widget.Pointer, @params + 16, 8, 8);

        ProcessEvent(_ptrWidgetInitialized, @params);

        return *(bool*)(@params + 24);
    }

    // Function GFxUI.GFxObject.AttachMovie
    // 0xC25520
    // (Final | Native | HasOptionalParams | Public)
    public unsafe class AttachMovie_Parameters : BaseObject {
        public AttachMovie_Parameters() { }
        public AttachMovie_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.AttachMovie.symbolname
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString symbolname {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty GFxUI.GFxObject.AttachMovie.instancename
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString instancename {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // IntProperty GFxUI.GFxObject.AttachMovie.Depth
        // 0x20 (0x4)
        // (OptionalParam | Param)
        public int Depth {
            get => *(int*)(Pointer + 32);
            set => *(int*)(Pointer + 32) = value;
        }

        // MISSED OFFSET: 0x4

        // ClassProperty GFxUI.GFxObject.AttachMovie.Type
        // 0x28 (0x8)
        // (OptionalParam | Param)
        public UClass Type {
            get {
                var pointer = *(nint*)(Pointer + 40);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 40) = value.Pointer;
        }

        // ObjectProperty GFxUI.GFxObject.AttachMovie.ReturnValue
        // 0x30 (0x8)
        // (Param | OutParam | ReturnParam)
        public UGFxObject ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 48);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 48) = value.Pointer;
        }
    }
    private static UFunction _ptrAttachMovie;
    public UGFxObject AttachMovie(FString symbolname, FString instancename, int Depth = 0, UClass Type = null) {
        _ptrAttachMovie ??= FindFunction("Function GFxUI.GFxObject.AttachMovie");

        var @params = stackalloc byte[52];
        System.Buffer.MemoryCopy((void*)symbolname.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)instancename.Pointer, @params + 16, 16, 16);
        System.Buffer.MemoryCopy(&Depth, @params + 32, 4, 4);
        if (Type != null) System.Buffer.MemoryCopy((void*)Type.Pointer, @params + 40, 8, 8);

        _ptrAttachMovie.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrAttachMovie, @params);
        _ptrAttachMovie.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)(@params + 48));
    }

    // Function GFxUI.GFxObject.CreateEmptyMovieClip
    // 0xC253D0
    // (Final | Native | HasOptionalParams | Public)
    public unsafe class CreateEmptyMovieClip_Parameters : BaseObject {
        public CreateEmptyMovieClip_Parameters() { }
        public CreateEmptyMovieClip_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.CreateEmptyMovieClip.instancename
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString instancename {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // IntProperty GFxUI.GFxObject.CreateEmptyMovieClip.Depth
        // 0x10 (0x4)
        // (OptionalParam | Param)
        public int Depth {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }

        // MISSED OFFSET: 0x4

        // ClassProperty GFxUI.GFxObject.CreateEmptyMovieClip.Type
        // 0x18 (0x8)
        // (OptionalParam | Param)
        public UClass Type {
            get {
                var pointer = *(nint*)(Pointer + 24);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 24) = value.Pointer;
        }

        // ObjectProperty GFxUI.GFxObject.CreateEmptyMovieClip.ReturnValue
        // 0x20 (0x8)
        // (Param | OutParam | ReturnParam)
        public UGFxObject ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 32);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 32) = value.Pointer;
        }
    }
    private static UFunction _ptrCreateEmptyMovieClip;
    public UGFxObject CreateEmptyMovieClip(FString instancename, int Depth = 0, UClass Type = null) {
        _ptrCreateEmptyMovieClip ??= FindFunction("Function GFxUI.GFxObject.CreateEmptyMovieClip");

        var @params = stackalloc byte[36];
        System.Buffer.MemoryCopy((void*)instancename.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&Depth, @params + 16, 4, 4);
        if (Type != null) System.Buffer.MemoryCopy((void*)Type.Pointer, @params + 24, 8, 8);

        _ptrCreateEmptyMovieClip.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrCreateEmptyMovieClip, @params);
        _ptrCreateEmptyMovieClip.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)(@params + 32));
    }

    // Function GFxUI.GFxObject.GotoAndStopI
    // 0xC25350
    // (Final | Native | Public)
    public unsafe class GotoAndStopI_Parameters : BaseObject {
        public GotoAndStopI_Parameters() { }
        public GotoAndStopI_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.GotoAndStopI.frame
        // 0x0 (0x4)
        // (Param)
        public int frame {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrGotoAndStopI;
    public void GotoAndStopI(int frame) {
        _ptrGotoAndStopI ??= FindFunction("Function GFxUI.GFxObject.GotoAndStopI");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&frame, @params, 4, 4);

        _ptrGotoAndStopI.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGotoAndStopI, @params);
        _ptrGotoAndStopI.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.GotoAndStop
    // 0xC252A0
    // (Final | Native | Public)
    public unsafe class GotoAndStop_Parameters : BaseObject {
        public GotoAndStop_Parameters() { }
        public GotoAndStop_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.GotoAndStop.frame
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString frame {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGotoAndStop;
    public void GotoAndStop(FString frame) {
        _ptrGotoAndStop ??= FindFunction("Function GFxUI.GFxObject.GotoAndStop");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)frame.Pointer, @params, 16, 16);

        _ptrGotoAndStop.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGotoAndStop, @params);
        _ptrGotoAndStop.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.GotoAndPlayI
    // 0xC25220
    // (Final | Native | Public)
    public unsafe class GotoAndPlayI_Parameters : BaseObject {
        public GotoAndPlayI_Parameters() { }
        public GotoAndPlayI_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.GotoAndPlayI.frame
        // 0x0 (0x4)
        // (Param)
        public int frame {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrGotoAndPlayI;
    public void GotoAndPlayI(int frame) {
        _ptrGotoAndPlayI ??= FindFunction("Function GFxUI.GFxObject.GotoAndPlayI");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&frame, @params, 4, 4);

        _ptrGotoAndPlayI.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGotoAndPlayI, @params);
        _ptrGotoAndPlayI.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.GotoAndPlay
    // 0xC25170
    // (Final | Native | Public)
    public unsafe class GotoAndPlay_Parameters : BaseObject {
        public GotoAndPlay_Parameters() { }
        public GotoAndPlay_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.GotoAndPlay.frame
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString frame {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGotoAndPlay;
    public void GotoAndPlay(FString frame) {
        _ptrGotoAndPlay ??= FindFunction("Function GFxUI.GFxObject.GotoAndPlay");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)frame.Pointer, @params, 16, 16);

        _ptrGotoAndPlay.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGotoAndPlay, @params);
        _ptrGotoAndPlay.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.ActionScriptArray
    // 0xCD95A0
    // (Final | Native | Public)
    public unsafe class ActionScriptArray_Parameters : BaseObject {
        public ActionScriptArray_Parameters() { }
        public ActionScriptArray_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.ActionScriptArray.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ArrayProperty GFxUI.GFxObject.ActionScriptArray.ReturnValue
        // 0x10 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public PointerTArray<UGFxObject> ReturnValue {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }
    }
    private static UFunction _ptrActionScriptArray;
    public PointerTArray<UGFxObject> ActionScriptArray(FString Path) {
        _ptrActionScriptArray ??= FindFunction("Function GFxUI.GFxObject.ActionScriptArray");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);

        _ptrActionScriptArray.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrActionScriptArray, @params);
        _ptrActionScriptArray.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 16, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxObject.ActionScriptObject
    // 0xCD95A0
    // (Final | Native | Public)
    public unsafe class ActionScriptObject_Parameters : BaseObject {
        public ActionScriptObject_Parameters() { }
        public ActionScriptObject_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.ActionScriptObject.Path
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Path {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ObjectProperty GFxUI.GFxObject.ActionScriptObject.ReturnValue
        // 0x10 (0x8)
        // (Param | OutParam | ReturnParam)
        public UGFxObject ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }
    }
    private static UFunction _ptrActionScriptObject;
    public UGFxObject ActionScriptObject(FString Path) {
        _ptrActionScriptObject ??= FindFunction("Function GFxUI.GFxObject.ActionScriptObject");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)Path.Pointer, @params, 16, 16);

        _ptrActionScriptObject.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrActionScriptObject, @params);
        _ptrActionScriptObject.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)(@params + 16));
    }

    // Function GFxUI.GFxObject.ActionScriptString
    // 0xCDA320
    // (Final | Native | Public)
    public unsafe class ActionScriptString_Parameters : BaseObject {
        public ActionScriptString_Parameters() { }
        public ActionScriptString_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.ActionScriptString.method
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString method {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty GFxUI.GFxObject.ActionScriptString.ReturnValue
        // 0x10 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }
    }
    private static UFunction _ptrActionScriptString;
    public FString ActionScriptString(FString method) {
        _ptrActionScriptString ??= FindFunction("Function GFxUI.GFxObject.ActionScriptString");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)method.Pointer, @params, 16, 16);

        _ptrActionScriptString.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrActionScriptString, @params);
        _ptrActionScriptString.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 16, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxObject.ActionScriptFloat
    // 0xCD97A0
    // (Final | Native | Public)
    public unsafe class ActionScriptFloat_Parameters : BaseObject {
        public ActionScriptFloat_Parameters() { }
        public ActionScriptFloat_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.ActionScriptFloat.method
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString method {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // FloatProperty GFxUI.GFxObject.ActionScriptFloat.ReturnValue
        // 0x10 (0x4)
        // (Param | OutParam | ReturnParam)
        public float ReturnValue {
            get => *(float*)(Pointer + 16);
            set => *(float*)(Pointer + 16) = value;
        }
    }
    private static UFunction _ptrActionScriptFloat;
    public float ActionScriptFloat(FString method) {
        _ptrActionScriptFloat ??= FindFunction("Function GFxUI.GFxObject.ActionScriptFloat");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)method.Pointer, @params, 16, 16);

        _ptrActionScriptFloat.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrActionScriptFloat, @params);
        _ptrActionScriptFloat.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(float*)(@params + 16);
    }

    // Function GFxUI.GFxObject.ActionScriptInt
    // 0xCD9930
    // (Final | Native | Public)
    public unsafe class ActionScriptInt_Parameters : BaseObject {
        public ActionScriptInt_Parameters() { }
        public ActionScriptInt_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.ActionScriptInt.method
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString method {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // IntProperty GFxUI.GFxObject.ActionScriptInt.ReturnValue
        // 0x10 (0x4)
        // (Param | OutParam | ReturnParam)
        public int ReturnValue {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }
    }
    private static UFunction _ptrActionScriptInt;
    public int ActionScriptInt(FString method) {
        _ptrActionScriptInt ??= FindFunction("Function GFxUI.GFxObject.ActionScriptInt");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)method.Pointer, @params, 16, 16);

        _ptrActionScriptInt.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrActionScriptInt, @params);
        _ptrActionScriptInt.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(int*)(@params + 16);
    }

    // Function GFxUI.GFxObject.ActionScriptVoid
    // 0xCDA4B0
    // (Final | Native | Public)
    public unsafe class ActionScriptVoid_Parameters : BaseObject {
        public ActionScriptVoid_Parameters() { }
        public ActionScriptVoid_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.ActionScriptVoid.method
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString method {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrActionScriptVoid;
    public void ActionScriptVoid(FString method) {
        _ptrActionScriptVoid ??= FindFunction("Function GFxUI.GFxObject.ActionScriptVoid");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)method.Pointer, @params, 16, 16);

        _ptrActionScriptVoid.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrActionScriptVoid, @params);
        _ptrActionScriptVoid.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.Invoke
    // 0xC25000
    // (Final | Native | Public)
    public unsafe class Invoke_Parameters : BaseObject {
        public Invoke_Parameters() { }
        public Invoke_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.Invoke.Member
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ArrayProperty GFxUI.GFxObject.Invoke.args
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public StructTArray<UGFxMoviePlayer.FASValue> args {
            get => new(Pointer + 16, 40);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // StructProperty GFxUI.GFxObject.Invoke.ReturnValue
        // 0x20 (0x28)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public UGFxMoviePlayer.FASValue ReturnValue {
            get => new(Pointer + 32);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 32), 40, 40);
        }
    }
    private static UFunction _ptrInvoke;
    public UGFxMoviePlayer.FASValue Invoke(FString Member, StructTArray<UGFxMoviePlayer.FASValue> args) {
        _ptrInvoke ??= FindFunction("Function GFxUI.GFxObject.Invoke");

        var @params = stackalloc byte[72];
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)args.Pointer, @params + 16, 16, 16);

        _ptrInvoke.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrInvoke, @params);
        _ptrInvoke.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(40);
        System.Buffer.MemoryCopy(@params + 32, (void*)_ReturnValuePtr, 40, 40);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxObject.ActionScriptSetFunctionOn
    // 0xCD9FC0
    // (Final | Native | Protected)
    public unsafe class ActionScriptSetFunctionOn_Parameters : BaseObject {
        public ActionScriptSetFunctionOn_Parameters() { }
        public ActionScriptSetFunctionOn_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty GFxUI.GFxObject.ActionScriptSetFunctionOn.Target
        // 0x0 (0x8)
        // (Param)
        public UGFxObject Target {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // StrProperty GFxUI.GFxObject.ActionScriptSetFunctionOn.Member
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrActionScriptSetFunctionOn;
    public void ActionScriptSetFunctionOn(UGFxObject Target, FString Member) {
        _ptrActionScriptSetFunctionOn ??= FindFunction("Function GFxUI.GFxObject.ActionScriptSetFunctionOn");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)Target.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params + 8, 16, 16);

        _ptrActionScriptSetFunctionOn.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrActionScriptSetFunctionOn, @params);
        _ptrActionScriptSetFunctionOn.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.ActionScriptSetFunction
    // 0xCD9D50
    // (Final | Native | Protected)
    public unsafe class ActionScriptSetFunction_Parameters : BaseObject {
        public ActionScriptSetFunction_Parameters() { }
        public ActionScriptSetFunction_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.ActionScriptSetFunction.Member
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrActionScriptSetFunction;
    public void ActionScriptSetFunction(FString Member) {
        _ptrActionScriptSetFunction ??= FindFunction("Function GFxUI.GFxObject.ActionScriptSetFunction");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params, 16, 16);

        _ptrActionScriptSetFunction.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrActionScriptSetFunction, @params);
        _ptrActionScriptSetFunction.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetElementMemberString
    // 0xC24ED0
    // (Final | Native | Public)
    public unsafe class SetElementMemberString_Parameters : BaseObject {
        public SetElementMemberString_Parameters() { }
        public SetElementMemberString_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.SetElementMemberString.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty GFxUI.GFxObject.SetElementMemberString.Member
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // StrProperty GFxUI.GFxObject.SetElementMemberString.S
        // 0x18 (0x10)
        // (Param | NeedCtorLink)
        public FString S {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }
    }
    private static UFunction _ptrSetElementMemberString;
    public void SetElementMemberString(int Index, FString Member, FString S) {
        _ptrSetElementMemberString ??= FindFunction("Function GFxUI.GFxObject.SetElementMemberString");

        var @params = stackalloc byte[36];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy((void*)S.Pointer, @params + 24, 16, 16);

        _ptrSetElementMemberString.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetElementMemberString, @params);
        _ptrSetElementMemberString.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetElementMemberInt
    // 0xC24DD0
    // (Final | Native | Public)
    public unsafe class SetElementMemberInt_Parameters : BaseObject {
        public SetElementMemberInt_Parameters() { }
        public SetElementMemberInt_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.SetElementMemberInt.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty GFxUI.GFxObject.SetElementMemberInt.Member
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // IntProperty GFxUI.GFxObject.SetElementMemberInt.I
        // 0x18 (0x4)
        // (Param)
        public int I {
            get => *(int*)(Pointer + 24);
            set => *(int*)(Pointer + 24) = value;
        }
    }
    private static UFunction _ptrSetElementMemberInt;
    public void SetElementMemberInt(int Index, FString Member, int I) {
        _ptrSetElementMemberInt ??= FindFunction("Function GFxUI.GFxObject.SetElementMemberInt");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy(&I, @params + 24, 4, 4);

        _ptrSetElementMemberInt.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetElementMemberInt, @params);
        _ptrSetElementMemberInt.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetElementMemberFloat
    // 0xC24CD0
    // (Final | Native | Public)
    public unsafe class SetElementMemberFloat_Parameters : BaseObject {
        public SetElementMemberFloat_Parameters() { }
        public SetElementMemberFloat_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.SetElementMemberFloat.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty GFxUI.GFxObject.SetElementMemberFloat.Member
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // FloatProperty GFxUI.GFxObject.SetElementMemberFloat.F
        // 0x18 (0x4)
        // (Param)
        public float F {
            get => *(float*)(Pointer + 24);
            set => *(float*)(Pointer + 24) = value;
        }
    }
    private static UFunction _ptrSetElementMemberFloat;
    public void SetElementMemberFloat(int Index, FString Member, float F) {
        _ptrSetElementMemberFloat ??= FindFunction("Function GFxUI.GFxObject.SetElementMemberFloat");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy(&F, @params + 24, 4, 4);

        _ptrSetElementMemberFloat.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetElementMemberFloat, @params);
        _ptrSetElementMemberFloat.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetElementMemberBool
    // 0xC24BC0
    // (Final | Native | Public)
    public unsafe class SetElementMemberBool_Parameters : BaseObject {
        public SetElementMemberBool_Parameters() { }
        public SetElementMemberBool_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.SetElementMemberBool.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty GFxUI.GFxObject.SetElementMemberBool.Member
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty GFxUI.GFxObject.SetElementMemberBool.B
        // 0x18 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool B {
            get => (*(uint*)(Pointer + 24) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 24) |= 0x1;
                else *(uint*)(Pointer + 24) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetElementMemberBool;
    public void SetElementMemberBool(int Index, FString Member, bool B) {
        _ptrSetElementMemberBool ??= FindFunction("Function GFxUI.GFxObject.SetElementMemberBool");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy(&B, @params + 24, 4, 4);

        _ptrSetElementMemberBool.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetElementMemberBool, @params);
        _ptrSetElementMemberBool.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetElementMemberObject
    // 0xC24AC0
    // (Final | Native | Public)
    public unsafe class SetElementMemberObject_Parameters : BaseObject {
        public SetElementMemberObject_Parameters() { }
        public SetElementMemberObject_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.SetElementMemberObject.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty GFxUI.GFxObject.SetElementMemberObject.Member
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // ObjectProperty GFxUI.GFxObject.SetElementMemberObject.val
        // 0x18 (0x8)
        // (Param)
        public UGFxObject val {
            get {
                var pointer = *(nint*)(Pointer + 24);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 24) = value.Pointer;
        }
    }
    private static UFunction _ptrSetElementMemberObject;
    public void SetElementMemberObject(int Index, FString Member, UGFxObject val) {
        _ptrSetElementMemberObject ??= FindFunction("Function GFxUI.GFxObject.SetElementMemberObject");

        var @params = stackalloc byte[28];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy((void*)val.Pointer, @params + 24, 8, 8);

        _ptrSetElementMemberObject.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetElementMemberObject, @params);
        _ptrSetElementMemberObject.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetElementMember
    // 0xC24950
    // (Final | Native | Public)
    public unsafe class SetElementMember_Parameters : BaseObject {
        public SetElementMember_Parameters() { }
        public SetElementMember_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.SetElementMember.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty GFxUI.GFxObject.SetElementMember.Member
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // StructProperty GFxUI.GFxObject.SetElementMember.Arg
        // 0x18 (0x28)
        // (Param | NeedCtorLink)
        public UGFxMoviePlayer.FASValue Arg {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 40, 40);
        }
    }
    private static UFunction _ptrSetElementMember;
    public void SetElementMember(int Index, FString Member, UGFxMoviePlayer.FASValue Arg) {
        _ptrSetElementMember ??= FindFunction("Function GFxUI.GFxObject.SetElementMember");

        var @params = stackalloc byte[60];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy((void*)Arg.Pointer, @params + 24, 40, 40);

        _ptrSetElementMember.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetElementMember, @params);
        _ptrSetElementMember.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.GetElementMemberString
    // 0xC24820
    // (Final | Native | Public)
    public unsafe class GetElementMemberString_Parameters : BaseObject {
        public GetElementMemberString_Parameters() { }
        public GetElementMemberString_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.GetElementMemberString.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty GFxUI.GFxObject.GetElementMemberString.Member
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // StrProperty GFxUI.GFxObject.GetElementMemberString.ReturnValue
        // 0x18 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }
    }
    private static UFunction _ptrGetElementMemberString;
    public FString GetElementMemberString(int Index, FString Member) {
        _ptrGetElementMemberString ??= FindFunction("Function GFxUI.GFxObject.GetElementMemberString");

        var @params = stackalloc byte[36];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params + 8, 16, 16);

        _ptrGetElementMemberString.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetElementMemberString, @params);
        _ptrGetElementMemberString.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 24, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxObject.GetElementMemberInt
    // 0xC24740
    // (Final | Native | Public)
    public unsafe class GetElementMemberInt_Parameters : BaseObject {
        public GetElementMemberInt_Parameters() { }
        public GetElementMemberInt_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.GetElementMemberInt.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty GFxUI.GFxObject.GetElementMemberInt.Member
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // IntProperty GFxUI.GFxObject.GetElementMemberInt.ReturnValue
        // 0x18 (0x4)
        // (Param | OutParam | ReturnParam)
        public int ReturnValue {
            get => *(int*)(Pointer + 24);
            set => *(int*)(Pointer + 24) = value;
        }
    }
    private static UFunction _ptrGetElementMemberInt;
    public int GetElementMemberInt(int Index, FString Member) {
        _ptrGetElementMemberInt ??= FindFunction("Function GFxUI.GFxObject.GetElementMemberInt");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params + 8, 16, 16);

        _ptrGetElementMemberInt.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetElementMemberInt, @params);
        _ptrGetElementMemberInt.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(int*)(@params + 24);
    }

    // Function GFxUI.GFxObject.GetElementMemberFloat
    // 0xC24660
    // (Final | Native | Public)
    public unsafe class GetElementMemberFloat_Parameters : BaseObject {
        public GetElementMemberFloat_Parameters() { }
        public GetElementMemberFloat_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.GetElementMemberFloat.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty GFxUI.GFxObject.GetElementMemberFloat.Member
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // FloatProperty GFxUI.GFxObject.GetElementMemberFloat.ReturnValue
        // 0x18 (0x4)
        // (Param | OutParam | ReturnParam)
        public float ReturnValue {
            get => *(float*)(Pointer + 24);
            set => *(float*)(Pointer + 24) = value;
        }
    }
    private static UFunction _ptrGetElementMemberFloat;
    public float GetElementMemberFloat(int Index, FString Member) {
        _ptrGetElementMemberFloat ??= FindFunction("Function GFxUI.GFxObject.GetElementMemberFloat");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params + 8, 16, 16);

        _ptrGetElementMemberFloat.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetElementMemberFloat, @params);
        _ptrGetElementMemberFloat.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(float*)(@params + 24);
    }

    // Function GFxUI.GFxObject.GetElementMemberBool
    // 0xC24580
    // (Final | Native | Public)
    public unsafe class GetElementMemberBool_Parameters : BaseObject {
        public GetElementMemberBool_Parameters() { }
        public GetElementMemberBool_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.GetElementMemberBool.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty GFxUI.GFxObject.GetElementMemberBool.Member
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty GFxUI.GFxObject.GetElementMemberBool.ReturnValue
        // 0x18 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 24) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 24) |= 0x1;
                else *(uint*)(Pointer + 24) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrGetElementMemberBool;
    public bool GetElementMemberBool(int Index, FString Member) {
        _ptrGetElementMemberBool ??= FindFunction("Function GFxUI.GFxObject.GetElementMemberBool");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params + 8, 16, 16);

        _ptrGetElementMemberBool.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetElementMemberBool, @params);
        _ptrGetElementMemberBool.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 24);
    }

    // Function GFxUI.GFxObject.GetElementMemberObject
    // 0xC24440
    // (Final | Native | HasOptionalParams | Public)
    public unsafe class GetElementMemberObject_Parameters : BaseObject {
        public GetElementMemberObject_Parameters() { }
        public GetElementMemberObject_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.GetElementMemberObject.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty GFxUI.GFxObject.GetElementMemberObject.Member
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // ClassProperty GFxUI.GFxObject.GetElementMemberObject.Type
        // 0x18 (0x8)
        // (OptionalParam | Param)
        public UClass Type {
            get {
                var pointer = *(nint*)(Pointer + 24);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 24) = value.Pointer;
        }

        // ObjectProperty GFxUI.GFxObject.GetElementMemberObject.ReturnValue
        // 0x20 (0x8)
        // (Param | OutParam | ReturnParam)
        public UGFxObject ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 32);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 32) = value.Pointer;
        }
    }
    private static UFunction _ptrGetElementMemberObject;
    public UGFxObject GetElementMemberObject(int Index, FString Member, UClass Type = null) {
        _ptrGetElementMemberObject ??= FindFunction("Function GFxUI.GFxObject.GetElementMemberObject");

        var @params = stackalloc byte[36];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params + 8, 16, 16);
        if (Type != null) System.Buffer.MemoryCopy((void*)Type.Pointer, @params + 24, 8, 8);

        _ptrGetElementMemberObject.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetElementMemberObject, @params);
        _ptrGetElementMemberObject.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)(@params + 32));
    }

    // Function GFxUI.GFxObject.GetElementMember
    // 0xC24330
    // (Final | Native | Public)
    public unsafe class GetElementMember_Parameters : BaseObject {
        public GetElementMember_Parameters() { }
        public GetElementMember_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.GetElementMember.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty GFxUI.GFxObject.GetElementMember.Member
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // StructProperty GFxUI.GFxObject.GetElementMember.ReturnValue
        // 0x18 (0x28)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public UGFxMoviePlayer.FASValue ReturnValue {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 40, 40);
        }
    }
    private static UFunction _ptrGetElementMember;
    public UGFxMoviePlayer.FASValue GetElementMember(int Index, FString Member) {
        _ptrGetElementMember ??= FindFunction("Function GFxUI.GFxObject.GetElementMember");

        var @params = stackalloc byte[60];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params + 8, 16, 16);

        _ptrGetElementMember.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetElementMember, @params);
        _ptrGetElementMember.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(40);
        System.Buffer.MemoryCopy(@params + 24, (void*)_ReturnValuePtr, 40, 40);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxObject.SetElementColorTransform
    // 0xC24270
    // (Final | Native | Public)
    public unsafe class SetElementColorTransform_Parameters : BaseObject {
        public SetElementColorTransform_Parameters() { }
        public SetElementColorTransform_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.SetElementColorTransform.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // StructProperty GFxUI.GFxObject.SetElementColorTransform.cxform
        // 0x4 (0x20)
        // (Param)
        public FASColorTransform cxform {
            get => new(Pointer + 4);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 4), 32, 32);
        }
    }
    private static UFunction _ptrSetElementColorTransform;
    public void SetElementColorTransform(int Index, FASColorTransform cxform) {
        _ptrSetElementColorTransform ??= FindFunction("Function GFxUI.GFxObject.SetElementColorTransform");

        var @params = stackalloc byte[36];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)cxform.Pointer, @params + 4, 32, 32);

        _ptrSetElementColorTransform.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetElementColorTransform, @params);
        _ptrSetElementColorTransform.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetElementPosition
    // 0xC24190
    // (Final | Native | Public)
    public unsafe class SetElementPosition_Parameters : BaseObject {
        public SetElementPosition_Parameters() { }
        public SetElementPosition_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.SetElementPosition.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // FloatProperty GFxUI.GFxObject.SetElementPosition.X
        // 0x4 (0x4)
        // (Param)
        public float X {
            get => *(float*)(Pointer + 4);
            set => *(float*)(Pointer + 4) = value;
        }

        // FloatProperty GFxUI.GFxObject.SetElementPosition.Y
        // 0x8 (0x4)
        // (Param)
        public float Y {
            get => *(float*)(Pointer + 8);
            set => *(float*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrSetElementPosition;
    public void SetElementPosition(int Index, float X, float Y) {
        _ptrSetElementPosition ??= FindFunction("Function GFxUI.GFxObject.SetElementPosition");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy(&X, @params + 4, 4, 4);
        System.Buffer.MemoryCopy(&Y, @params + 8, 4, 4);

        _ptrSetElementPosition.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetElementPosition, @params);
        _ptrSetElementPosition.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetElementVisible
    // 0xC240D0
    // (Final | Native | Public)
    public unsafe class SetElementVisible_Parameters : BaseObject {
        public SetElementVisible_Parameters() { }
        public SetElementVisible_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.SetElementVisible.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // BoolProperty GFxUI.GFxObject.SetElementVisible.Visible
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool Visible {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetElementVisible;
    public void SetElementVisible(int Index, bool Visible) {
        _ptrSetElementVisible ??= FindFunction("Function GFxUI.GFxObject.SetElementVisible");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy(&Visible, @params + 4, 4, 4);

        _ptrSetElementVisible.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetElementVisible, @params);
        _ptrSetElementVisible.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetElementDisplayMatrix
    // 0xCDA7C0
    // (Final | Native | Public)
    public unsafe class SetElementDisplayMatrix_Parameters : BaseObject {
        public SetElementDisplayMatrix_Parameters() { }
        public SetElementDisplayMatrix_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.SetElementDisplayMatrix.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0xC

        // StructProperty GFxUI.GFxObject.SetElementDisplayMatrix.M
        // 0x10 (0x40)
        // (Param)
        public FMatrix M {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 64, 64);
        }
    }
    private static UFunction _ptrSetElementDisplayMatrix;
    public void SetElementDisplayMatrix(int Index, FMatrix M) {
        _ptrSetElementDisplayMatrix ??= FindFunction("Function GFxUI.GFxObject.SetElementDisplayMatrix");

        var @params = stackalloc byte[68];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)M.Pointer, @params + 16, 64, 64);

        _ptrSetElementDisplayMatrix.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetElementDisplayMatrix, @params);
        _ptrSetElementDisplayMatrix.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetElementDisplayInfo
    // 0xC23FF0
    // (Final | Native | Public)
    public unsafe class SetElementDisplayInfo_Parameters : BaseObject {
        public SetElementDisplayInfo_Parameters() { }
        public SetElementDisplayInfo_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.SetElementDisplayInfo.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // StructProperty GFxUI.GFxObject.SetElementDisplayInfo.D
        // 0x4 (0x2C)
        // (Param)
        public FASDisplayInfo D {
            get => new(Pointer + 4);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 4), 44, 44);
        }
    }
    private static UFunction _ptrSetElementDisplayInfo;
    public void SetElementDisplayInfo(int Index, FASDisplayInfo D) {
        _ptrSetElementDisplayInfo ??= FindFunction("Function GFxUI.GFxObject.SetElementDisplayInfo");

        var @params = stackalloc byte[48];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)D.Pointer, @params + 4, 44, 44);

        _ptrSetElementDisplayInfo.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetElementDisplayInfo, @params);
        _ptrSetElementDisplayInfo.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.GetElementDisplayMatrix
    // 0xC23F40
    // (Final | Native | Public)
    public unsafe class GetElementDisplayMatrix_Parameters : BaseObject {
        public GetElementDisplayMatrix_Parameters() { }
        public GetElementDisplayMatrix_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.GetElementDisplayMatrix.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0xC

        // StructProperty GFxUI.GFxObject.GetElementDisplayMatrix.ReturnValue
        // 0x10 (0x40)
        // (Param | OutParam | ReturnParam)
        public FMatrix ReturnValue {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 64, 64);
        }
    }
    private static UFunction _ptrGetElementDisplayMatrix;
    public FMatrix GetElementDisplayMatrix(int Index) {
        _ptrGetElementDisplayMatrix ??= FindFunction("Function GFxUI.GFxObject.GetElementDisplayMatrix");

        var @params = stackalloc byte[68];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);

        _ptrGetElementDisplayMatrix.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetElementDisplayMatrix, @params);
        _ptrGetElementDisplayMatrix.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(64);
        System.Buffer.MemoryCopy(@params + 16, (void*)_ReturnValuePtr, 64, 64);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxObject.GetElementDisplayInfo
    // 0xC23E90
    // (Final | Native | Public)
    public unsafe class GetElementDisplayInfo_Parameters : BaseObject {
        public GetElementDisplayInfo_Parameters() { }
        public GetElementDisplayInfo_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.GetElementDisplayInfo.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // StructProperty GFxUI.GFxObject.GetElementDisplayInfo.ReturnValue
        // 0x4 (0x2C)
        // (Param | OutParam | ReturnParam)
        public FASDisplayInfo ReturnValue {
            get => new(Pointer + 4);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 4), 44, 44);
        }
    }
    private static UFunction _ptrGetElementDisplayInfo;
    public FASDisplayInfo GetElementDisplayInfo(int Index) {
        _ptrGetElementDisplayInfo ??= FindFunction("Function GFxUI.GFxObject.GetElementDisplayInfo");

        var @params = stackalloc byte[48];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);

        _ptrGetElementDisplayInfo.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetElementDisplayInfo, @params);
        _ptrGetElementDisplayInfo.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(44);
        System.Buffer.MemoryCopy(@params + 4, (void*)_ReturnValuePtr, 44, 44);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxObject.SetElementString
    // 0xC23DB0
    // (Final | Native | Public)
    public unsafe class SetElementString_Parameters : BaseObject {
        public SetElementString_Parameters() { }
        public SetElementString_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.SetElementString.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty GFxUI.GFxObject.SetElementString.S
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString S {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrSetElementString;
    public void SetElementString(int Index, FString S) {
        _ptrSetElementString ??= FindFunction("Function GFxUI.GFxObject.SetElementString");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)S.Pointer, @params + 8, 16, 16);

        _ptrSetElementString.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetElementString, @params);
        _ptrSetElementString.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetElementInt
    // 0xC23D00
    // (Final | Native | Public)
    public unsafe class SetElementInt_Parameters : BaseObject {
        public SetElementInt_Parameters() { }
        public SetElementInt_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.SetElementInt.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // IntProperty GFxUI.GFxObject.SetElementInt.I
        // 0x4 (0x4)
        // (Param)
        public int I {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }
    }
    private static UFunction _ptrSetElementInt;
    public void SetElementInt(int Index, int I) {
        _ptrSetElementInt ??= FindFunction("Function GFxUI.GFxObject.SetElementInt");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy(&I, @params + 4, 4, 4);

        _ptrSetElementInt.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetElementInt, @params);
        _ptrSetElementInt.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetElementFloat
    // 0xC23C50
    // (Final | Native | Public)
    public unsafe class SetElementFloat_Parameters : BaseObject {
        public SetElementFloat_Parameters() { }
        public SetElementFloat_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.SetElementFloat.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // FloatProperty GFxUI.GFxObject.SetElementFloat.F
        // 0x4 (0x4)
        // (Param)
        public float F {
            get => *(float*)(Pointer + 4);
            set => *(float*)(Pointer + 4) = value;
        }
    }
    private static UFunction _ptrSetElementFloat;
    public void SetElementFloat(int Index, float F) {
        _ptrSetElementFloat ??= FindFunction("Function GFxUI.GFxObject.SetElementFloat");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy(&F, @params + 4, 4, 4);

        _ptrSetElementFloat.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetElementFloat, @params);
        _ptrSetElementFloat.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetElementBool
    // 0xC23B90
    // (Final | Native | Public)
    public unsafe class SetElementBool_Parameters : BaseObject {
        public SetElementBool_Parameters() { }
        public SetElementBool_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.SetElementBool.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // BoolProperty GFxUI.GFxObject.SetElementBool.B
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool B {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetElementBool;
    public void SetElementBool(int Index, bool B) {
        _ptrSetElementBool ??= FindFunction("Function GFxUI.GFxObject.SetElementBool");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy(&B, @params + 4, 4, 4);

        _ptrSetElementBool.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetElementBool, @params);
        _ptrSetElementBool.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetElementObject
    // 0xC23AD0
    // (Final | Native | Public)
    public unsafe class SetElementObject_Parameters : BaseObject {
        public SetElementObject_Parameters() { }
        public SetElementObject_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.SetElementObject.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // ObjectProperty GFxUI.GFxObject.SetElementObject.val
        // 0x8 (0x8)
        // (Param)
        public UGFxObject val {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }
    }
    private static UFunction _ptrSetElementObject;
    public void SetElementObject(int Index, UGFxObject val) {
        _ptrSetElementObject ??= FindFunction("Function GFxUI.GFxObject.SetElementObject");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)val.Pointer, @params + 8, 8, 8);

        _ptrSetElementObject.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetElementObject, @params);
        _ptrSetElementObject.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetElement
    // 0xC239A0
    // (Final | Native | Public)
    public unsafe class SetElement_Parameters : BaseObject {
        public SetElement_Parameters() { }
        public SetElement_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.SetElement.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StructProperty GFxUI.GFxObject.SetElement.Arg
        // 0x8 (0x28)
        // (Param | NeedCtorLink)
        public UGFxMoviePlayer.FASValue Arg {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 40, 40);
        }
    }
    private static UFunction _ptrSetElement;
    public void SetElement(int Index, UGFxMoviePlayer.FASValue Arg) {
        _ptrSetElement ??= FindFunction("Function GFxUI.GFxObject.SetElement");

        var @params = stackalloc byte[44];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)Arg.Pointer, @params + 8, 40, 40);

        _ptrSetElement.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetElement, @params);
        _ptrSetElement.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.GetElementString
    // 0xC238B0
    // (Final | Native | Public)
    public unsafe class GetElementString_Parameters : BaseObject {
        public GetElementString_Parameters() { }
        public GetElementString_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.GetElementString.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty GFxUI.GFxObject.GetElementString.ReturnValue
        // 0x8 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrGetElementString;
    public FString GetElementString(int Index) {
        _ptrGetElementString ??= FindFunction("Function GFxUI.GFxObject.GetElementString");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);

        _ptrGetElementString.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetElementString, @params);
        _ptrGetElementString.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxObject.GetElementInt
    // 0xC23820
    // (Final | Native | Public)
    public unsafe class GetElementInt_Parameters : BaseObject {
        public GetElementInt_Parameters() { }
        public GetElementInt_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.GetElementInt.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // IntProperty GFxUI.GFxObject.GetElementInt.ReturnValue
        // 0x4 (0x4)
        // (Param | OutParam | ReturnParam)
        public int ReturnValue {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }
    }
    private static UFunction _ptrGetElementInt;
    public int GetElementInt(int Index) {
        _ptrGetElementInt ??= FindFunction("Function GFxUI.GFxObject.GetElementInt");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);

        _ptrGetElementInt.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetElementInt, @params);
        _ptrGetElementInt.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(int*)(@params + 4);
    }

    // Function GFxUI.GFxObject.GetElementFloat
    // 0xC23790
    // (Final | Native | Public)
    public unsafe class GetElementFloat_Parameters : BaseObject {
        public GetElementFloat_Parameters() { }
        public GetElementFloat_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.GetElementFloat.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // FloatProperty GFxUI.GFxObject.GetElementFloat.ReturnValue
        // 0x4 (0x4)
        // (Param | OutParam | ReturnParam)
        public float ReturnValue {
            get => *(float*)(Pointer + 4);
            set => *(float*)(Pointer + 4) = value;
        }
    }
    private static UFunction _ptrGetElementFloat;
    public float GetElementFloat(int Index) {
        _ptrGetElementFloat ??= FindFunction("Function GFxUI.GFxObject.GetElementFloat");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);

        _ptrGetElementFloat.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetElementFloat, @params);
        _ptrGetElementFloat.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(float*)(@params + 4);
    }

    // Function GFxUI.GFxObject.GetElementBool
    // 0xC23700
    // (Final | Native | Public)
    public unsafe class GetElementBool_Parameters : BaseObject {
        public GetElementBool_Parameters() { }
        public GetElementBool_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.GetElementBool.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // BoolProperty GFxUI.GFxObject.GetElementBool.ReturnValue
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrGetElementBool;
    public bool GetElementBool(int Index) {
        _ptrGetElementBool ??= FindFunction("Function GFxUI.GFxObject.GetElementBool");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);

        _ptrGetElementBool.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetElementBool, @params);
        _ptrGetElementBool.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 4);
    }

    // Function GFxUI.GFxObject.GetElementObject
    // 0xC23620
    // (Final | Native | HasOptionalParams | Public)
    public unsafe class GetElementObject_Parameters : BaseObject {
        public GetElementObject_Parameters() { }
        public GetElementObject_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.GetElementObject.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // ClassProperty GFxUI.GFxObject.GetElementObject.Type
        // 0x8 (0x8)
        // (OptionalParam | Param)
        public UClass Type {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // ObjectProperty GFxUI.GFxObject.GetElementObject.ReturnValue
        // 0x10 (0x8)
        // (Param | OutParam | ReturnParam)
        public UGFxObject ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }
    }
    private static UFunction _ptrGetElementObject;
    public UGFxObject GetElementObject(int Index, UClass Type = null) {
        _ptrGetElementObject ??= FindFunction("Function GFxUI.GFxObject.GetElementObject");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);
        if (Type != null) System.Buffer.MemoryCopy((void*)Type.Pointer, @params + 8, 8, 8);

        _ptrGetElementObject.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetElementObject, @params);
        _ptrGetElementObject.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)(@params + 16));
    }

    // Function GFxUI.GFxObject.GetElement
    // 0xC23550
    // (Final | Native | Public)
    public unsafe class GetElement_Parameters : BaseObject {
        public GetElement_Parameters() { }
        public GetElement_Parameters(nint pointer) : base(pointer) { }

        // IntProperty GFxUI.GFxObject.GetElement.Index
        // 0x0 (0x4)
        // (Param)
        public int Index {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StructProperty GFxUI.GFxObject.GetElement.ReturnValue
        // 0x8 (0x28)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public UGFxMoviePlayer.FASValue ReturnValue {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 40, 40);
        }
    }
    private static UFunction _ptrGetElement;
    public UGFxMoviePlayer.FASValue GetElement(int Index) {
        _ptrGetElement ??= FindFunction("Function GFxUI.GFxObject.GetElement");

        var @params = stackalloc byte[44];
        System.Buffer.MemoryCopy(&Index, @params, 4, 4);

        _ptrGetElement.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetElement, @params);
        _ptrGetElement.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(40);
        System.Buffer.MemoryCopy(@params + 8, (void*)_ReturnValuePtr, 40, 40);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxObject.SetText
    // 0xC23460
    // (Final | Native | HasOptionalParams | Public)
    public unsafe class SetText_Parameters : BaseObject {
        public SetText_Parameters() { }
        public SetText_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.SetText.Text
        // 0x0 (0x10)
        // (Param | CoerceParam | NeedCtorLink)
        public FString Text {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ObjectProperty GFxUI.GFxObject.SetText.InContext
        // 0x10 (0x8)
        // (OptionalParam | Param)
        public UTranslationContext InContext {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }
    }
    private static UFunction _ptrSetText;
    public void SetText(FString Text, UTranslationContext InContext = null) {
        _ptrSetText ??= FindFunction("Function GFxUI.GFxObject.SetText");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)Text.Pointer, @params, 16, 16);
        if (InContext != null) System.Buffer.MemoryCopy((void*)InContext.Pointer, @params + 16, 8, 8);

        _ptrSetText.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetText, @params);
        _ptrSetText.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.GetText
    // 0xC233B0
    // (Final | Native | Public)
    public unsafe class GetText_Parameters : BaseObject {
        public GetText_Parameters() { }
        public GetText_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.GetText.ReturnValue
        // 0x0 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetText;
    public FString GetText() {
        _ptrGetText ??= FindFunction("Function GFxUI.GFxObject.GetText");

        var @params = stackalloc byte[16];

        _ptrGetText.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetText, @params);
        _ptrGetText.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxObject.SetVisible
    // 0xC23320
    // (Final | Native | Public)
    public unsafe class SetVisible_Parameters : BaseObject {
        public SetVisible_Parameters() { }
        public SetVisible_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty GFxUI.GFxObject.SetVisible.Visible
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool Visible {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetVisible;
    public void SetVisible(bool Visible) {
        _ptrSetVisible ??= FindFunction("Function GFxUI.GFxObject.SetVisible");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&Visible, @params, 4, 4);

        _ptrSetVisible.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetVisible, @params);
        _ptrSetVisible.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetDisplayMatrix3D
    // 0xCDA570
    // (Final | Native | Public)
    public unsafe class SetDisplayMatrix3D_Parameters : BaseObject {
        public SetDisplayMatrix3D_Parameters() { }
        public SetDisplayMatrix3D_Parameters(nint pointer) : base(pointer) { }

        // StructProperty GFxUI.GFxObject.SetDisplayMatrix3D.M
        // 0x0 (0x40)
        // (Param)
        public FMatrix M {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 64, 64);
        }
    }
    private static UFunction _ptrSetDisplayMatrix3D;
    public void SetDisplayMatrix3D(FMatrix M) {
        _ptrSetDisplayMatrix3D ??= FindFunction("Function GFxUI.GFxObject.SetDisplayMatrix3D");

        var @params = stackalloc byte[64];
        System.Buffer.MemoryCopy((void*)M.Pointer, @params, 64, 64);

        _ptrSetDisplayMatrix3D.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetDisplayMatrix3D, @params);
        _ptrSetDisplayMatrix3D.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetDisplayMatrix
    // 0xCDA6B0
    // (Final | Native | Public)
    public unsafe class SetDisplayMatrix_Parameters : BaseObject {
        public SetDisplayMatrix_Parameters() { }
        public SetDisplayMatrix_Parameters(nint pointer) : base(pointer) { }

        // StructProperty GFxUI.GFxObject.SetDisplayMatrix.M
        // 0x0 (0x40)
        // (Param)
        public FMatrix M {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 64, 64);
        }
    }
    private static UFunction _ptrSetDisplayMatrix;
    public void SetDisplayMatrix(FMatrix M) {
        _ptrSetDisplayMatrix ??= FindFunction("Function GFxUI.GFxObject.SetDisplayMatrix");

        var @params = stackalloc byte[64];
        System.Buffer.MemoryCopy((void*)M.Pointer, @params, 64, 64);

        _ptrSetDisplayMatrix.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetDisplayMatrix, @params);
        _ptrSetDisplayMatrix.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetColorTransform
    // 0xC23290
    // (Final | Native | Public)
    public unsafe class SetColorTransform_Parameters : BaseObject {
        public SetColorTransform_Parameters() { }
        public SetColorTransform_Parameters(nint pointer) : base(pointer) { }

        // StructProperty GFxUI.GFxObject.SetColorTransform.cxform
        // 0x0 (0x20)
        // (Param)
        public FASColorTransform cxform {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 32, 32);
        }
    }
    private static UFunction _ptrSetColorTransform;
    public void SetColorTransform(FASColorTransform cxform) {
        _ptrSetColorTransform ??= FindFunction("Function GFxUI.GFxObject.SetColorTransform");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)cxform.Pointer, @params, 32, 32);

        _ptrSetColorTransform.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetColorTransform, @params);
        _ptrSetColorTransform.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetPosition
    // 0xC231D0
    // (Final | Native | Public)
    public unsafe class SetPosition_Parameters : BaseObject {
        public SetPosition_Parameters() { }
        public SetPosition_Parameters(nint pointer) : base(pointer) { }

        // FloatProperty GFxUI.GFxObject.SetPosition.X
        // 0x0 (0x4)
        // (Param)
        public float X {
            get => *(float*)Pointer;
            set => *(float*)Pointer = value;
        }

        // FloatProperty GFxUI.GFxObject.SetPosition.Y
        // 0x4 (0x4)
        // (Param)
        public float Y {
            get => *(float*)(Pointer + 4);
            set => *(float*)(Pointer + 4) = value;
        }
    }
    private static UFunction _ptrSetPosition;
    public void SetPosition(float X, float Y) {
        _ptrSetPosition ??= FindFunction("Function GFxUI.GFxObject.SetPosition");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&X, @params, 4, 4);
        System.Buffer.MemoryCopy(&Y, @params + 4, 4, 4);

        _ptrSetPosition.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetPosition, @params);
        _ptrSetPosition.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetDisplayInfo
    // 0xC23120
    // (Final | Native | Public)
    public unsafe class SetDisplayInfo_Parameters : BaseObject {
        public SetDisplayInfo_Parameters() { }
        public SetDisplayInfo_Parameters(nint pointer) : base(pointer) { }

        // StructProperty GFxUI.GFxObject.SetDisplayInfo.D
        // 0x0 (0x2C)
        // (Param)
        public FASDisplayInfo D {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 44, 44);
        }
    }
    private static UFunction _ptrSetDisplayInfo;
    public void SetDisplayInfo(FASDisplayInfo D) {
        _ptrSetDisplayInfo ??= FindFunction("Function GFxUI.GFxObject.SetDisplayInfo");

        var @params = stackalloc byte[44];
        System.Buffer.MemoryCopy((void*)D.Pointer, @params, 44, 44);

        _ptrSetDisplayInfo.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetDisplayInfo, @params);
        _ptrSetDisplayInfo.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.GetDisplayMatrix3D
    // 0xC230B0
    // (Final | Native | Public)
    public unsafe class GetDisplayMatrix3D_Parameters : BaseObject {
        public GetDisplayMatrix3D_Parameters() { }
        public GetDisplayMatrix3D_Parameters(nint pointer) : base(pointer) { }

        // StructProperty GFxUI.GFxObject.GetDisplayMatrix3D.ReturnValue
        // 0x0 (0x40)
        // (Param | OutParam | ReturnParam)
        public FMatrix ReturnValue {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 64, 64);
        }
    }
    private static UFunction _ptrGetDisplayMatrix3D;
    public FMatrix GetDisplayMatrix3D() {
        _ptrGetDisplayMatrix3D ??= FindFunction("Function GFxUI.GFxObject.GetDisplayMatrix3D");

        var @params = stackalloc byte[64];

        _ptrGetDisplayMatrix3D.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetDisplayMatrix3D, @params);
        _ptrGetDisplayMatrix3D.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(64);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 64, 64);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxObject.GetDisplayMatrix
    // 0xC23040
    // (Final | Native | Public)
    public unsafe class GetDisplayMatrix_Parameters : BaseObject {
        public GetDisplayMatrix_Parameters() { }
        public GetDisplayMatrix_Parameters(nint pointer) : base(pointer) { }

        // StructProperty GFxUI.GFxObject.GetDisplayMatrix.ReturnValue
        // 0x0 (0x40)
        // (Param | OutParam | ReturnParam)
        public FMatrix ReturnValue {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 64, 64);
        }
    }
    private static UFunction _ptrGetDisplayMatrix;
    public FMatrix GetDisplayMatrix() {
        _ptrGetDisplayMatrix ??= FindFunction("Function GFxUI.GFxObject.GetDisplayMatrix");

        var @params = stackalloc byte[64];

        _ptrGetDisplayMatrix.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetDisplayMatrix, @params);
        _ptrGetDisplayMatrix.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(64);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 64, 64);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxObject.GetColorTransform
    // 0xC22FE0
    // (Final | Native | Public)
    public unsafe class GetColorTransform_Parameters : BaseObject {
        public GetColorTransform_Parameters() { }
        public GetColorTransform_Parameters(nint pointer) : base(pointer) { }

        // StructProperty GFxUI.GFxObject.GetColorTransform.ReturnValue
        // 0x0 (0x20)
        // (Param | OutParam | ReturnParam)
        public FASColorTransform ReturnValue {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 32, 32);
        }
    }
    private static UFunction _ptrGetColorTransform;
    public FASColorTransform GetColorTransform() {
        _ptrGetColorTransform ??= FindFunction("Function GFxUI.GFxObject.GetColorTransform");

        var @params = stackalloc byte[32];

        _ptrGetColorTransform.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetColorTransform, @params);
        _ptrGetColorTransform.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(32);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 32, 32);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxObject.GetPosition
    // 0xC22EB0
    // (Final | Native | Public | HasOutParams)
    public unsafe class GetPosition_Parameters : BaseObject {
        public GetPosition_Parameters() { }
        public GetPosition_Parameters(nint pointer) : base(pointer) { }

        // FloatProperty GFxUI.GFxObject.GetPosition.X
        // 0x0 (0x4)
        // (Param | OutParam)
        public float X {
            get => *(float*)Pointer;
            set => *(float*)Pointer = value;
        }

        // FloatProperty GFxUI.GFxObject.GetPosition.Y
        // 0x4 (0x4)
        // (Param | OutParam)
        public float Y {
            get => *(float*)(Pointer + 4);
            set => *(float*)(Pointer + 4) = value;
        }

        // BoolProperty GFxUI.GFxObject.GetPosition.ReturnValue
        // 0x8 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 8) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 8) |= 0x1;
                else *(uint*)(Pointer + 8) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrGetPosition;
    public bool GetPosition(ref float X, ref float Y) {
        _ptrGetPosition ??= FindFunction("Function GFxUI.GFxObject.GetPosition");

        var @params = stackalloc byte[12];
        var _X = X;
        System.Buffer.MemoryCopy(&_X, @params, 4, 4);
        var _Y = Y;
        System.Buffer.MemoryCopy(&_Y, @params + 4, 4, 4);

        _ptrGetPosition.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetPosition, @params);
        _ptrGetPosition.FunctionFlags |= (ulong)EFunctionFlags.Native;

        X = *(float*)@params;
        Y = *(float*)(@params + 4);

        return *(bool*)(@params + 8);
    }

    // Function GFxUI.GFxObject.GetDisplayInfo
    // 0xC22E40
    // (Final | Native | Public)
    public unsafe class GetDisplayInfo_Parameters : BaseObject {
        public GetDisplayInfo_Parameters() { }
        public GetDisplayInfo_Parameters(nint pointer) : base(pointer) { }

        // StructProperty GFxUI.GFxObject.GetDisplayInfo.ReturnValue
        // 0x0 (0x2C)
        // (Param | OutParam | ReturnParam)
        public FASDisplayInfo ReturnValue {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 44, 44);
        }
    }
    private static UFunction _ptrGetDisplayInfo;
    public FASDisplayInfo GetDisplayInfo() {
        _ptrGetDisplayInfo ??= FindFunction("Function GFxUI.GFxObject.GetDisplayInfo");

        var @params = stackalloc byte[44];

        _ptrGetDisplayInfo.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetDisplayInfo, @params);
        _ptrGetDisplayInfo.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(44);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 44, 44);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxObject.TranslateString
    // 0xC22D10
    // (Final | Native | Static | HasOptionalParams | Public)
    public unsafe class TranslateString_Parameters : BaseObject {
        public TranslateString_Parameters() { }
        public TranslateString_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.TranslateString.StringToTranslate
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString StringToTranslate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ObjectProperty GFxUI.GFxObject.TranslateString.InContext
        // 0x10 (0x8)
        // (OptionalParam | Param)
        public UTranslationContext InContext {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }

        // StrProperty GFxUI.GFxObject.TranslateString.ReturnValue
        // 0x18 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }
    }
    private static UFunction _ptrTranslateString;
    public static FString TranslateString(FString StringToTranslate, UTranslationContext InContext = null) {
        _ptrTranslateString ??= FindFunction("Function GFxUI.GFxObject.TranslateString");

        var @params = stackalloc byte[40];
        System.Buffer.MemoryCopy((void*)StringToTranslate.Pointer, @params, 16, 16);
        if (InContext != null) System.Buffer.MemoryCopy((void*)InContext.Pointer, @params + 16, 8, 8);

        _ptrTranslateString.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrTranslateString, @params);
        _ptrTranslateString.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 24, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxObject.SetFunction
    // 0xC22C10
    // (Final | Native | Public)
    public unsafe class SetFunction_Parameters : BaseObject {
        public SetFunction_Parameters() { }
        public SetFunction_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.SetFunction.Member
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ObjectProperty GFxUI.GFxObject.SetFunction.Context
        // 0x10 (0x8)
        // (Param)
        public UObject Context {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }

        // NameProperty GFxUI.GFxObject.SetFunction.fname
        // 0x18 (0x8)
        // (Param)
        public FName fname {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 8, 8);
        }
    }
    private static UFunction _ptrSetFunction;
    public void SetFunction(FString Member, UObject Context, FName fname) {
        _ptrSetFunction ??= FindFunction("Function GFxUI.GFxObject.SetFunction");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)Context.Pointer, @params + 16, 8, 8);
        System.Buffer.MemoryCopy((void*)fname.Pointer, @params + 24, 8, 8);

        _ptrSetFunction.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetFunction, @params);
        _ptrSetFunction.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetObject
    // 0xC22B30
    // (Final | Native | Public)
    public unsafe class SetObject_Parameters : BaseObject {
        public SetObject_Parameters() { }
        public SetObject_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.SetObject.Member
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ObjectProperty GFxUI.GFxObject.SetObject.val
        // 0x10 (0x8)
        // (Param)
        public UGFxObject val {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }
    }
    private static UFunction _ptrSetObject;
    public void SetObject(FString Member, UGFxObject val) {
        _ptrSetObject ??= FindFunction("Function GFxUI.GFxObject.SetObject");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)val.Pointer, @params + 16, 8, 8);

        _ptrSetObject.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetObject, @params);
        _ptrSetObject.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetString
    // 0xC22A00
    // (Final | Native | HasOptionalParams | Public)
    public unsafe class SetString_Parameters : BaseObject {
        public SetString_Parameters() { }
        public SetString_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.SetString.Member
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty GFxUI.GFxObject.SetString.S
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString S {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // ObjectProperty GFxUI.GFxObject.SetString.InContext
        // 0x20 (0x8)
        // (OptionalParam | Param)
        public UTranslationContext InContext {
            get {
                var pointer = *(nint*)(Pointer + 32);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 32) = value.Pointer;
        }
    }
    private static UFunction _ptrSetString;
    public void SetString(FString Member, FString S, UTranslationContext InContext = null) {
        _ptrSetString ??= FindFunction("Function GFxUI.GFxObject.SetString");

        var @params = stackalloc byte[40];
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)S.Pointer, @params + 16, 16, 16);
        if (InContext != null) System.Buffer.MemoryCopy((void*)InContext.Pointer, @params + 32, 8, 8);

        _ptrSetString.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetString, @params);
        _ptrSetString.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetInt
    // 0xC22920
    // (Final | Native | Public)
    public unsafe class SetInt_Parameters : BaseObject {
        public SetInt_Parameters() { }
        public SetInt_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.SetInt.Member
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // IntProperty GFxUI.GFxObject.SetInt.I
        // 0x10 (0x4)
        // (Param)
        public int I {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }
    }
    private static UFunction _ptrSetInt;
    public void SetInt(FString Member, int I) {
        _ptrSetInt ??= FindFunction("Function GFxUI.GFxObject.SetInt");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&I, @params + 16, 4, 4);

        _ptrSetInt.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetInt, @params);
        _ptrSetInt.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetFloat
    // 0xC22840
    // (Final | Native | Public)
    public unsafe class SetFloat_Parameters : BaseObject {
        public SetFloat_Parameters() { }
        public SetFloat_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.SetFloat.Member
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // FloatProperty GFxUI.GFxObject.SetFloat.F
        // 0x10 (0x4)
        // (Param)
        public float F {
            get => *(float*)(Pointer + 16);
            set => *(float*)(Pointer + 16) = value;
        }
    }
    private static UFunction _ptrSetFloat;
    public void SetFloat(FString Member, float F) {
        _ptrSetFloat ??= FindFunction("Function GFxUI.GFxObject.SetFloat");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&F, @params + 16, 4, 4);

        _ptrSetFloat.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetFloat, @params);
        _ptrSetFloat.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.SetBool
    // 0xC22750
    // (Final | Native | Public)
    public unsafe class SetBool_Parameters : BaseObject {
        public SetBool_Parameters() { }
        public SetBool_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.SetBool.Member
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // BoolProperty GFxUI.GFxObject.SetBool.B
        // 0x10 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool B {
            get => (*(uint*)(Pointer + 16) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 16) |= 0x1;
                else *(uint*)(Pointer + 16) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetBool;
    public void SetBool(FString Member, bool B) {
        _ptrSetBool ??= FindFunction("Function GFxUI.GFxObject.SetBool");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&B, @params + 16, 4, 4);

        _ptrSetBool.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetBool, @params);
        _ptrSetBool.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.Set
    // 0xC22600
    // (Final | Native | Public)
    public unsafe class Set_Parameters : BaseObject {
        public Set_Parameters() { }
        public Set_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.Set.Member
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StructProperty GFxUI.GFxObject.Set.Arg
        // 0x10 (0x28)
        // (Param | NeedCtorLink)
        public UGFxMoviePlayer.FASValue Arg {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 40, 40);
        }
    }
    private static UFunction _ptrSet;
    public void Set(FString Member, UGFxMoviePlayer.FASValue Arg) {
        _ptrSet ??= FindFunction("Function GFxUI.GFxObject.Set");

        var @params = stackalloc byte[56];
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)Arg.Pointer, @params + 16, 40, 40);

        _ptrSet.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSet, @params);
        _ptrSet.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function GFxUI.GFxObject.GetObject
    // 0xC224E0
    // (Final | Native | HasOptionalParams | Public)
    public unsafe class GetObject_Parameters : BaseObject {
        public GetObject_Parameters() { }
        public GetObject_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.GetObject.Member
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ClassProperty GFxUI.GFxObject.GetObject.Type
        // 0x10 (0x8)
        // (OptionalParam | Param)
        public UClass Type {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }

        // ObjectProperty GFxUI.GFxObject.GetObject.ReturnValue
        // 0x18 (0x8)
        // (Param | OutParam | ReturnParam)
        public UGFxObject ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 24);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 24) = value.Pointer;
        }
    }
    private static UFunction _ptrGetObject;
    public UGFxObject GetObject(FString Member, UClass Type = null) {
        _ptrGetObject ??= FindFunction("Function GFxUI.GFxObject.GetObject");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params, 16, 16);
        if (Type != null) System.Buffer.MemoryCopy((void*)Type.Pointer, @params + 16, 8, 8);

        _ptrGetObject.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetObject, @params);
        _ptrGetObject.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)(@params + 24));
    }

    // Function GFxUI.GFxObject.GetString
    // 0xC223E0
    // (Final | Native | Public)
    public unsafe class GetString_Parameters : BaseObject {
        public GetString_Parameters() { }
        public GetString_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.GetString.Member
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty GFxUI.GFxObject.GetString.ReturnValue
        // 0x10 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }
    }
    private static UFunction _ptrGetString;
    public FString GetString(FString Member) {
        _ptrGetString ??= FindFunction("Function GFxUI.GFxObject.GetString");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params, 16, 16);

        _ptrGetString.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetString, @params);
        _ptrGetString.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 16, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxObject.GetInt
    // 0xC22320
    // (Final | Native | Public)
    public unsafe class GetInt_Parameters : BaseObject {
        public GetInt_Parameters() { }
        public GetInt_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.GetInt.Member
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // IntProperty GFxUI.GFxObject.GetInt.ReturnValue
        // 0x10 (0x4)
        // (Param | OutParam | ReturnParam)
        public int ReturnValue {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }
    }
    private static UFunction _ptrGetInt;
    public int GetInt(FString Member) {
        _ptrGetInt ??= FindFunction("Function GFxUI.GFxObject.GetInt");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params, 16, 16);

        _ptrGetInt.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetInt, @params);
        _ptrGetInt.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(int*)(@params + 16);
    }

    // Function GFxUI.GFxObject.GetFloat
    // 0xC22260
    // (Final | Native | Public)
    public unsafe class GetFloat_Parameters : BaseObject {
        public GetFloat_Parameters() { }
        public GetFloat_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.GetFloat.Member
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // FloatProperty GFxUI.GFxObject.GetFloat.ReturnValue
        // 0x10 (0x4)
        // (Param | OutParam | ReturnParam)
        public float ReturnValue {
            get => *(float*)(Pointer + 16);
            set => *(float*)(Pointer + 16) = value;
        }
    }
    private static UFunction _ptrGetFloat;
    public float GetFloat(FString Member) {
        _ptrGetFloat ??= FindFunction("Function GFxUI.GFxObject.GetFloat");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params, 16, 16);

        _ptrGetFloat.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetFloat, @params);
        _ptrGetFloat.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(float*)(@params + 16);
    }

    // Function GFxUI.GFxObject.GetBool
    // 0xC221A0
    // (Final | Native | Public)
    public unsafe class GetBool_Parameters : BaseObject {
        public GetBool_Parameters() { }
        public GetBool_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.GetBool.Member
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // BoolProperty GFxUI.GFxObject.GetBool.ReturnValue
        // 0x10 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 16) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 16) |= 0x1;
                else *(uint*)(Pointer + 16) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrGetBool;
    public bool GetBool(FString Member) {
        _ptrGetBool ??= FindFunction("Function GFxUI.GFxObject.GetBool");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params, 16, 16);

        _ptrGetBool.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetBool, @params);
        _ptrGetBool.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 16);
    }

    // Function GFxUI.GFxObject.Get
    // 0xC220C0
    // (Final | Native | Public)
    public unsafe class Get_Parameters : BaseObject {
        public Get_Parameters() { }
        public Get_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxObject.Get.Member
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StructProperty GFxUI.GFxObject.Get.ReturnValue
        // 0x10 (0x28)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public UGFxMoviePlayer.FASValue ReturnValue {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 40, 40);
        }
    }
    private static UFunction _ptrGet;
    public UGFxMoviePlayer.FASValue Get(FString Member) {
        _ptrGet ??= FindFunction("Function GFxUI.GFxObject.Get");

        var @params = stackalloc byte[56];
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params, 16, 16);

        _ptrGet.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGet, @params);
        _ptrGet.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(40);
        System.Buffer.MemoryCopy(@params + 16, (void*)_ReturnValuePtr, 40, 40);
        return new(_ReturnValuePtr) { Allocated = true };
    }


    // ScriptStruct GFxUI.GFxObject.ASColorTransform
    // 0x20
    public unsafe class FASColorTransform : BaseObject {
        public FASColorTransform() {
            Pointer = Marshal.AllocHGlobal(32);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 32);
            Allocated = true;
        }
        public FASColorTransform(nint pointer) : base(pointer) { }

        // StructProperty GFxUI.GFxObject.ASColorTransform.Multiply
        // 0x0 (0x10)
        // (Edit)
        public FLinearColor Multiply {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StructProperty GFxUI.GFxObject.ASColorTransform.Add
        // 0x10 (0x10)
        // (Edit)
        public FLinearColor Add {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }
    }

    // ScriptStruct GFxUI.GFxObject.ASDisplayInfo
    // 0x2C
    public unsafe class FASDisplayInfo : BaseObject {
        public FASDisplayInfo() {
            Pointer = Marshal.AllocHGlobal(44);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 44);
            Allocated = true;
        }
        public FASDisplayInfo(nint pointer) : base(pointer) { }

        // FloatProperty GFxUI.GFxObject.ASDisplayInfo.X
        // 0x0 (0x4)
        // (Edit)
        public float X {
            get => *(float*)Pointer;
            set => *(float*)Pointer = value;
        }

        // FloatProperty GFxUI.GFxObject.ASDisplayInfo.Y
        // 0x4 (0x4)
        // (Edit)
        public float Y {
            get => *(float*)(Pointer + 4);
            set => *(float*)(Pointer + 4) = value;
        }

        // FloatProperty GFxUI.GFxObject.ASDisplayInfo.Z
        // 0x8 (0x4)
        // (Edit)
        public float Z {
            get => *(float*)(Pointer + 8);
            set => *(float*)(Pointer + 8) = value;
        }

        // FloatProperty GFxUI.GFxObject.ASDisplayInfo.Rotation
        // 0xC (0x4)
        // (Edit)
        public float Rotation {
            get => *(float*)(Pointer + 12);
            set => *(float*)(Pointer + 12) = value;
        }

        // FloatProperty GFxUI.GFxObject.ASDisplayInfo.XRotation
        // 0x10 (0x4)
        // (Edit)
        public float XRotation {
            get => *(float*)(Pointer + 16);
            set => *(float*)(Pointer + 16) = value;
        }

        // FloatProperty GFxUI.GFxObject.ASDisplayInfo.YRotation
        // 0x14 (0x4)
        // (Edit)
        public float YRotation {
            get => *(float*)(Pointer + 20);
            set => *(float*)(Pointer + 20) = value;
        }

        // FloatProperty GFxUI.GFxObject.ASDisplayInfo.XScale
        // 0x18 (0x4)
        // (Edit)
        public float XScale {
            get => *(float*)(Pointer + 24);
            set => *(float*)(Pointer + 24) = value;
        }

        // FloatProperty GFxUI.GFxObject.ASDisplayInfo.YScale
        // 0x1C (0x4)
        // (Edit)
        public float YScale {
            get => *(float*)(Pointer + 28);
            set => *(float*)(Pointer + 28) = value;
        }

        // FloatProperty GFxUI.GFxObject.ASDisplayInfo.ZScale
        // 0x20 (0x4)
        // (Edit)
        public float ZScale {
            get => *(float*)(Pointer + 32);
            set => *(float*)(Pointer + 32) = value;
        }

        // FloatProperty GFxUI.GFxObject.ASDisplayInfo.Alpha
        // 0x24 (0x4)
        // (Edit)
        public float Alpha {
            get => *(float*)(Pointer + 36);
            set => *(float*)(Pointer + 36) = value;
        }

        // BoolProperty GFxUI.GFxObject.ASDisplayInfo.Visible
        // 0x28 (0x4)
        // Bitmask: 0x00000001
        // (Edit)
        public bool Visible {
            get => (*(uint*)(Pointer + 40) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x1;
                else *(uint*)(Pointer + 40) &= ~(uint)0x1;
            }
        }

        // BoolProperty GFxUI.GFxObject.ASDisplayInfo.hasX
        // 0x28 (0x4)
        // Bitmask: 0x00000002
        // (Edit)
        public bool hasX {
            get => (*(uint*)(Pointer + 40) & 0x2) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x2;
                else *(uint*)(Pointer + 40) &= ~(uint)0x2;
            }
        }

        // BoolProperty GFxUI.GFxObject.ASDisplayInfo.hasY
        // 0x28 (0x4)
        // Bitmask: 0x00000004
        // (Edit)
        public bool hasY {
            get => (*(uint*)(Pointer + 40) & 0x4) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x4;
                else *(uint*)(Pointer + 40) &= ~(uint)0x4;
            }
        }

        // BoolProperty GFxUI.GFxObject.ASDisplayInfo.hasZ
        // 0x28 (0x4)
        // Bitmask: 0x00000008
        // (Edit)
        public bool hasZ {
            get => (*(uint*)(Pointer + 40) & 0x8) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x8;
                else *(uint*)(Pointer + 40) &= ~(uint)0x8;
            }
        }

        // BoolProperty GFxUI.GFxObject.ASDisplayInfo.hasRotation
        // 0x28 (0x4)
        // Bitmask: 0x00000010
        // (Edit)
        public bool hasRotation {
            get => (*(uint*)(Pointer + 40) & 0x10) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x10;
                else *(uint*)(Pointer + 40) &= ~(uint)0x10;
            }
        }

        // BoolProperty GFxUI.GFxObject.ASDisplayInfo.hasXRotation
        // 0x28 (0x4)
        // Bitmask: 0x00000020
        // (Edit)
        public bool hasXRotation {
            get => (*(uint*)(Pointer + 40) & 0x20) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x20;
                else *(uint*)(Pointer + 40) &= ~(uint)0x20;
            }
        }

        // BoolProperty GFxUI.GFxObject.ASDisplayInfo.hasYRotation
        // 0x28 (0x4)
        // Bitmask: 0x00000040
        // (Edit)
        public bool hasYRotation {
            get => (*(uint*)(Pointer + 40) & 0x40) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x40;
                else *(uint*)(Pointer + 40) &= ~(uint)0x40;
            }
        }

        // BoolProperty GFxUI.GFxObject.ASDisplayInfo.hasXScale
        // 0x28 (0x4)
        // Bitmask: 0x00000080
        // (Edit)
        public bool hasXScale {
            get => (*(uint*)(Pointer + 40) & 0x80) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x80;
                else *(uint*)(Pointer + 40) &= ~(uint)0x80;
            }
        }

        // BoolProperty GFxUI.GFxObject.ASDisplayInfo.hasYScale
        // 0x28 (0x4)
        // Bitmask: 0x00000100
        // (Edit)
        public bool hasYScale {
            get => (*(uint*)(Pointer + 40) & 0x100) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x100;
                else *(uint*)(Pointer + 40) &= ~(uint)0x100;
            }
        }

        // BoolProperty GFxUI.GFxObject.ASDisplayInfo.hasZScale
        // 0x28 (0x4)
        // Bitmask: 0x00000200
        // (Edit)
        public bool hasZScale {
            get => (*(uint*)(Pointer + 40) & 0x200) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x200;
                else *(uint*)(Pointer + 40) &= ~(uint)0x200;
            }
        }

        // BoolProperty GFxUI.GFxObject.ASDisplayInfo.hasAlpha
        // 0x28 (0x4)
        // Bitmask: 0x00000400
        // (Edit)
        public bool hasAlpha {
            get => (*(uint*)(Pointer + 40) & 0x400) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x400;
                else *(uint*)(Pointer + 40) &= ~(uint)0x400;
            }
        }

        // BoolProperty GFxUI.GFxObject.ASDisplayInfo.hasVisible
        // 0x28 (0x4)
        // Bitmask: 0x00000800
        // (Edit)
        public bool hasVisible {
            get => (*(uint*)(Pointer + 40) & 0x800) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x800;
                else *(uint*)(Pointer + 40) &= ~(uint)0x800;
            }
        }
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class GFxUI.GFxObject");
            return _staticClass;
        }
    }
}

// Class GFxUI.GFxRawData
// 0x40 (0x60 - 0xA0)
// (Compiled | Parsed | Native | EditInlineNew)
public unsafe partial class UGFxRawData : UObject {
    public UGFxRawData() { }
    public UGFxRawData(nint pointer) : base(pointer) { }


    // ArrayProperty GFxUI.GFxRawData.RawData
    // 0x60 (0x10)
    // (Const | NeedCtorLink)
    public UnmanagedTArray<byte> RawData {
        get => new(Pointer + 96);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 96), 16, 16);
    }

    // ArrayProperty GFxUI.GFxRawData.ReferencedSwfs
    // 0x70 (0x10)
    // (Edit | EditConst | NeedCtorLink)
    public StructTArray<FString> ReferencedSwfs {
        get => new(Pointer + 112, 16);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 112), 16, 16);
    }

    // ArrayProperty GFxUI.GFxRawData.References
    // 0x80 (0x10)
    // (Edit | EditConst | NeedCtorLink)
    public PointerTArray<UObject> References {
        get => new(Pointer + 128);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 128), 16, 16);
    }

    // ArrayProperty GFxUI.GFxRawData.UserReferences
    // 0x90 (0x10)
    // (Edit | NeedCtorLink)
    public PointerTArray<UObject> UserReferences {
        get => new(Pointer + 144);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 144), 16, 16);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class GFxUI.GFxRawData");
            return _staticClass;
        }
    }
}

// Class GFxUI.SwfMovie
// 0x78 (0xA0 - 0x118)
// (Compiled | Parsed | Native | EditInlineNew)
public unsafe partial class USwfMovie : UGFxRawData {
    public USwfMovie() { }
    public USwfMovie(nint pointer) : base(pointer) { }


    // BoolProperty GFxUI.SwfMovie.bUsesFontlib
    // 0xA0 (0x4)
    // Bitmask: 0x00000001
    // (Edit)
    public bool bUsesFontlib {
        get => (*(uint*)(Pointer + 160) & 0x1) != 0;
        set {
            if (value) *(uint*)(Pointer + 160) |= 0x1;
            else *(uint*)(Pointer + 160) &= ~(uint)0x1;
        }
    }

    // BoolProperty GFxUI.SwfMovie.bSetSRGBOnImportedTextures
    // 0xA0 (0x4)
    // Bitmask: 0x00000002
    // (Edit | EditConst)
    public bool bSetSRGBOnImportedTextures {
        get => (*(uint*)(Pointer + 160) & 0x2) != 0;
        set {
            if (value) *(uint*)(Pointer + 160) |= 0x2;
            else *(uint*)(Pointer + 160) &= ~(uint)0x2;
        }
    }

    // BoolProperty GFxUI.SwfMovie.bPackTextures
    // 0xA0 (0x4)
    // Bitmask: 0x00000004
    // (Edit)
    public bool bPackTextures {
        get => (*(uint*)(Pointer + 160) & 0x4) != 0;
        set {
            if (value) *(uint*)(Pointer + 160) |= 0x4;
            else *(uint*)(Pointer + 160) &= ~(uint)0x4;
        }
    }

    // BoolProperty GFxUI.SwfMovie.bForceSquarePacking
    // 0xA0 (0x4)
    // Bitmask: 0x00000008
    // (Edit)
    public bool bForceSquarePacking {
        get => (*(uint*)(Pointer + 160) & 0x8) != 0;
        set {
            if (value) *(uint*)(Pointer + 160) |= 0x8;
            else *(uint*)(Pointer + 160) &= ~(uint)0x8;
        }
    }

    // MISSED OFFSET: 0x4

    // StrProperty GFxUI.SwfMovie.SourceFile
    // 0xA8 (0x10)
    // (Edit | NeedCtorLink)
    public FString SourceFile {
        get => new(Pointer + 168);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 168), 16, 16);
    }

    // IntProperty GFxUI.SwfMovie.PackTextureSize
    // 0xB8 (0x4)
    // (Edit)
    public int PackTextureSize {
        get => *(int*)(Pointer + 184);
        set => *(int*)(Pointer + 184) = value;
    }

    // ByteProperty GFxUI.SwfMovie.TextureRescale
    // 0xBC (0x1)
    // (Edit)
    public FlashTextureRescale TextureRescale {
        get => *(FlashTextureRescale*)(Pointer + 188);
        set => *(FlashTextureRescale*)(Pointer + 188) = value;
    }

    // MISSED OFFSET: 0x3

    // StrProperty GFxUI.SwfMovie.TextureFormat
    // 0xC0 (0x10)
    // (Edit | EditConst | NeedCtorLink)
    public FString TextureFormat {
        get => new(Pointer + 192);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 192), 16, 16);
    }

    // StrProperty GFxUI.SwfMovie.SourceFileTimestamp
    // 0xD0 (0x10)
    // (Edit | EditConst | NeedCtorLink)
    public FString SourceFileTimestamp {
        get => new(Pointer + 208);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 208), 16, 16);
    }

    // IntProperty GFxUI.SwfMovie.SourceFileCRC
    // 0xE0 (0x4)
    // (Edit | EditConst)
    public int SourceFileCRC {
        get => *(int*)(Pointer + 224);
        set => *(int*)(Pointer + 224) = value;
    }

    // MISSED OFFSET: 0x4

    // ArrayProperty GFxUI.SwfMovie.Editions
    // 0xE8 (0x10)
    // (Edit | NeedCtorLink)
    public UnmanagedTArray<EEdition> Editions {
        get => new(Pointer + 232);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 232), 16, 16);
    }

    // ArrayProperty GFxUI.SwfMovie.Features
    // 0xF8 (0x10)
    // (Edit | NeedCtorLink)
    public StructTArray<FName> Features {
        get => new(Pointer + 248, 8);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 248), 16, 16);
    }

    // IntProperty GFxUI.SwfMovie.RTTextures
    // 0x108 (0x4)
    public int RTTextures {
        get => *(int*)(Pointer + 264);
        set => *(int*)(Pointer + 264) = value;
    }

    // IntProperty GFxUI.SwfMovie.RTVideoTextures
    // 0x10C (0x4)
    public int RTVideoTextures {
        get => *(int*)(Pointer + 268);
        set => *(int*)(Pointer + 268) = value;
    }

    // QWordProperty GFxUI.SwfMovie.ImportTimeStamp
    // 0x110 (0x8)
    // (Const | Transient | EditorOnly)
    public ulong ImportTimeStamp {
        get => *(ulong*)(Pointer + 272);
        set => *(ulong*)(Pointer + 272) = value;
    }


    // Enum GFxUI.SwfMovie.FlashTextureRescale
    public enum FlashTextureRescale : byte {
        FlashTextureScale_High = 0,
        FlashTextureScale_Low = 1,
        FlashTextureScale_NextLow = 2,
        FlashTextureScale_Mult4 = 3,
        FlashTextureScale_None = 4,
        FlashTextureScale_MAX = 5
    }

    // Enum GFxUI.SwfMovie.EEdition
    public enum EEdition : byte {
        Edition_Default = 0,
        Edition_China = 1,
        Edition_MAX = 2
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class GFxUI.SwfMovie");
            return _staticClass;
        }
    }
}

// Class GFxUI.FlashMovie
// 0x0 (0x118 - 0x118)
// (Compiled | Parsed | Native | EditInlineNew)
public unsafe partial class UFlashMovie : USwfMovie {
    public UFlashMovie() { }
    public UFlashMovie(nint pointer) : base(pointer) { }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class GFxUI.FlashMovie");
            return _staticClass;
        }
    }
}

// Class GFxUI.GFxAction_CloseMovie
// 0xC (0x160 - 0x16C)
// (Compiled | Parsed | Native)
public unsafe partial class UGFxAction_CloseMovie : USequenceAction {
    public UGFxAction_CloseMovie() { }
    public UGFxAction_CloseMovie(nint pointer) : base(pointer) { }


    // ObjectProperty GFxUI.GFxAction_CloseMovie.Movie
    // 0x160 (0x8)
    public UGFxMoviePlayer Movie {
        get {
            var pointer = *(nint*)(Pointer + 352);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 352) = value.Pointer;
    }

    // BoolProperty GFxUI.GFxAction_CloseMovie.bUnload
    // 0x168 (0x4)
    // Bitmask: 0x00000001
    // (Edit)
    public bool bUnload {
        get => (*(uint*)(Pointer + 360) & 0x1) != 0;
        set {
            if (value) *(uint*)(Pointer + 360) |= 0x1;
            else *(uint*)(Pointer + 360) &= ~(uint)0x1;
        }
    }


    // Function GFxUI.GFxAction_CloseMovie.IsValidLevelSequenceObject
    // 0x3750E0
    // (Defined | Event | Public)
    public unsafe class IsValidLevelSequenceObject_Parameters : BaseObject {
        public IsValidLevelSequenceObject_Parameters() { }
        public IsValidLevelSequenceObject_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty GFxUI.GFxAction_CloseMovie.IsValidLevelSequenceObject.ReturnValue
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrIsValidLevelSequenceObject;
    public bool IsValidLevelSequenceObject() {
        _ptrIsValidLevelSequenceObject ??= FindFunction("Function GFxUI.GFxAction_CloseMovie.IsValidLevelSequenceObject");

        var @params = stackalloc byte[4];

        ProcessEvent(_ptrIsValidLevelSequenceObject, @params);

        return *(bool*)@params;
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class GFxUI.GFxAction_CloseMovie");
            return _staticClass;
        }
    }
}

// Class GFxUI.GFxAction_GetVariable
// 0x18 (0x160 - 0x178)
// (Compiled | Parsed | Native)
public unsafe partial class UGFxAction_GetVariable : USequenceAction {
    public UGFxAction_GetVariable() { }
    public UGFxAction_GetVariable(nint pointer) : base(pointer) { }


    // ObjectProperty GFxUI.GFxAction_GetVariable.Movie
    // 0x160 (0x8)
    public UGFxMoviePlayer Movie {
        get {
            var pointer = *(nint*)(Pointer + 352);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 352) = value.Pointer;
    }

    // StrProperty GFxUI.GFxAction_GetVariable.Variable
    // 0x168 (0x10)
    // (Edit | NeedCtorLink)
    public FString Variable {
        get => new(Pointer + 360);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 360), 16, 16);
    }


    // Function GFxUI.GFxAction_GetVariable.IsValidLevelSequenceObject
    // 0x3750E0
    // (Defined | Event | Public)
    public unsafe class IsValidLevelSequenceObject_Parameters : BaseObject {
        public IsValidLevelSequenceObject_Parameters() { }
        public IsValidLevelSequenceObject_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty GFxUI.GFxAction_GetVariable.IsValidLevelSequenceObject.ReturnValue
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrIsValidLevelSequenceObject;
    public bool IsValidLevelSequenceObject() {
        _ptrIsValidLevelSequenceObject ??= FindFunction("Function GFxUI.GFxAction_GetVariable.IsValidLevelSequenceObject");

        var @params = stackalloc byte[4];

        ProcessEvent(_ptrIsValidLevelSequenceObject, @params);

        return *(bool*)@params;
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class GFxUI.GFxAction_GetVariable");
            return _staticClass;
        }
    }
}

// Class GFxUI.GFxAction_Invoke
// 0x28 (0x160 - 0x188)
// (Compiled | Parsed | Native)
public unsafe partial class UGFxAction_Invoke : USequenceAction {
    public UGFxAction_Invoke() { }
    public UGFxAction_Invoke(nint pointer) : base(pointer) { }


    // ObjectProperty GFxUI.GFxAction_Invoke.Movie
    // 0x160 (0x8)
    public UGFxMoviePlayer Movie {
        get {
            var pointer = *(nint*)(Pointer + 352);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 352) = value.Pointer;
    }

    // StrProperty GFxUI.GFxAction_Invoke.MethodName
    // 0x168 (0x10)
    // (Edit | NeedCtorLink)
    public FString MethodName {
        get => new(Pointer + 360);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 360), 16, 16);
    }

    // ArrayProperty GFxUI.GFxAction_Invoke.Arguments
    // 0x178 (0x10)
    // (Edit | NeedCtorLink)
    public StructTArray<UGFxMoviePlayer.FASValue> Arguments {
        get => new(Pointer + 376, 40);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 376), 16, 16);
    }


    // Function GFxUI.GFxAction_Invoke.IsValidLevelSequenceObject
    // 0x3750E0
    // (Defined | Event | Public)
    public unsafe class IsValidLevelSequenceObject_Parameters : BaseObject {
        public IsValidLevelSequenceObject_Parameters() { }
        public IsValidLevelSequenceObject_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty GFxUI.GFxAction_Invoke.IsValidLevelSequenceObject.ReturnValue
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrIsValidLevelSequenceObject;
    public bool IsValidLevelSequenceObject() {
        _ptrIsValidLevelSequenceObject ??= FindFunction("Function GFxUI.GFxAction_Invoke.IsValidLevelSequenceObject");

        var @params = stackalloc byte[4];

        ProcessEvent(_ptrIsValidLevelSequenceObject, @params);

        return *(bool*)@params;
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class GFxUI.GFxAction_Invoke");
            return _staticClass;
        }
    }
}

// Class GFxUI.GFxAction_OpenMovie
// 0x48 (0x160 - 0x1A8)
// (Compiled | Parsed | Native)
public unsafe partial class UGFxAction_OpenMovie : USequenceAction {
    public UGFxAction_OpenMovie() { }
    public UGFxAction_OpenMovie(nint pointer) : base(pointer) { }


    // ObjectProperty GFxUI.GFxAction_OpenMovie.Movie
    // 0x160 (0x8)
    // (Edit)
    public USwfMovie Movie {
        get {
            var pointer = *(nint*)(Pointer + 352);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 352) = value.Pointer;
    }

    // ClassProperty GFxUI.GFxAction_OpenMovie.MoviePlayerClass
    // 0x168 (0x8)
    // (Edit)
    public UClass MoviePlayerClass {
        get {
            var pointer = *(nint*)(Pointer + 360);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 360) = value.Pointer;
    }

    // ObjectProperty GFxUI.GFxAction_OpenMovie.MoviePlayer
    // 0x170 (0x8)
    public UGFxMoviePlayer MoviePlayer {
        get {
            var pointer = *(nint*)(Pointer + 368);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 368) = value.Pointer;
    }

    // BoolProperty GFxUI.GFxAction_OpenMovie.bTakeFocus
    // 0x178 (0x4)
    // Bitmask: 0x00000001
    // (Edit)
    public bool bTakeFocus {
        get => (*(uint*)(Pointer + 376) & 0x1) != 0;
        set {
            if (value) *(uint*)(Pointer + 376) |= 0x1;
            else *(uint*)(Pointer + 376) &= ~(uint)0x1;
        }
    }

    // BoolProperty GFxUI.GFxAction_OpenMovie.bCaptureInput
    // 0x178 (0x4)
    // Bitmask: 0x00000002
    // (Edit)
    public bool bCaptureInput {
        get => (*(uint*)(Pointer + 376) & 0x2) != 0;
        set {
            if (value) *(uint*)(Pointer + 376) |= 0x2;
            else *(uint*)(Pointer + 376) &= ~(uint)0x2;
        }
    }

    // BoolProperty GFxUI.GFxAction_OpenMovie.bStartPaused
    // 0x178 (0x4)
    // Bitmask: 0x00000004
    // (Edit)
    public bool bStartPaused {
        get => (*(uint*)(Pointer + 376) & 0x4) != 0;
        set {
            if (value) *(uint*)(Pointer + 376) |= 0x4;
            else *(uint*)(Pointer + 376) &= ~(uint)0x4;
        }
    }

    // BoolProperty GFxUI.GFxAction_OpenMovie.bEnableGammaCorrection
    // 0x178 (0x4)
    // Bitmask: 0x00000008
    public bool bEnableGammaCorrection {
        get => (*(uint*)(Pointer + 376) & 0x8) != 0;
        set {
            if (value) *(uint*)(Pointer + 376) |= 0x8;
            else *(uint*)(Pointer + 376) &= ~(uint)0x8;
        }
    }

    // BoolProperty GFxUI.GFxAction_OpenMovie.bDisplayWithHudOff
    // 0x178 (0x4)
    // Bitmask: 0x00000010
    // (Edit)
    public bool bDisplayWithHudOff {
        get => (*(uint*)(Pointer + 376) & 0x10) != 0;
        set {
            if (value) *(uint*)(Pointer + 376) |= 0x10;
            else *(uint*)(Pointer + 376) &= ~(uint)0x10;
        }
    }

    // ByteProperty GFxUI.GFxAction_OpenMovie.RenderTextureMode
    // 0x17C (0x1)
    // (Edit)
    public UGFxMoviePlayer.GFxRenderTextureMode RenderTextureMode {
        get => *(UGFxMoviePlayer.GFxRenderTextureMode*)(Pointer + 380);
        set => *(UGFxMoviePlayer.GFxRenderTextureMode*)(Pointer + 380) = value;
    }

    // MISSED OFFSET: 0x3

    // ObjectProperty GFxUI.GFxAction_OpenMovie.RenderTexture
    // 0x180 (0x8)
    // (Edit)
    public UTextureRenderTarget2D RenderTexture {
        get {
            var pointer = *(nint*)(Pointer + 384);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 384) = value.Pointer;
    }

    // ArrayProperty GFxUI.GFxAction_OpenMovie.CaptureKeys
    // 0x188 (0x10)
    // (Edit | NeedCtorLink)
    public StructTArray<FName> CaptureKeys {
        get => new(Pointer + 392, 8);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 392), 16, 16);
    }

    // ArrayProperty GFxUI.GFxAction_OpenMovie.FocusIgnoreKeys
    // 0x198 (0x10)
    // (Edit | NeedCtorLink)
    public StructTArray<FName> FocusIgnoreKeys {
        get => new(Pointer + 408, 8);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 408), 16, 16);
    }


    // Function GFxUI.GFxAction_OpenMovie.IsValidLevelSequenceObject
    // 0x3750E0
    // (Defined | Event | Public)
    public unsafe class IsValidLevelSequenceObject_Parameters : BaseObject {
        public IsValidLevelSequenceObject_Parameters() { }
        public IsValidLevelSequenceObject_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty GFxUI.GFxAction_OpenMovie.IsValidLevelSequenceObject.ReturnValue
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrIsValidLevelSequenceObject;
    public bool IsValidLevelSequenceObject() {
        _ptrIsValidLevelSequenceObject ??= FindFunction("Function GFxUI.GFxAction_OpenMovie.IsValidLevelSequenceObject");

        var @params = stackalloc byte[4];

        ProcessEvent(_ptrIsValidLevelSequenceObject, @params);

        return *(bool*)@params;
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class GFxUI.GFxAction_OpenMovie");
            return _staticClass;
        }
    }
}

// Class GFxUI.GFxAction_SetCaptureKeys
// 0x18 (0x160 - 0x178)
// (Compiled | Parsed | Native)
public unsafe partial class UGFxAction_SetCaptureKeys : USequenceAction {
    public UGFxAction_SetCaptureKeys() { }
    public UGFxAction_SetCaptureKeys(nint pointer) : base(pointer) { }


    // ObjectProperty GFxUI.GFxAction_SetCaptureKeys.Movie
    // 0x160 (0x8)
    public UGFxMoviePlayer Movie {
        get {
            var pointer = *(nint*)(Pointer + 352);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 352) = value.Pointer;
    }

    // ArrayProperty GFxUI.GFxAction_SetCaptureKeys.CaptureKeys
    // 0x168 (0x10)
    // (Edit | NeedCtorLink)
    public StructTArray<FName> CaptureKeys {
        get => new(Pointer + 360, 8);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 360), 16, 16);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class GFxUI.GFxAction_SetCaptureKeys");
            return _staticClass;
        }
    }
}

// Class GFxUI.GFxAction_SetVariable
// 0x18 (0x160 - 0x178)
// (Compiled | Parsed | Native)
public unsafe partial class UGFxAction_SetVariable : USequenceAction {
    public UGFxAction_SetVariable() { }
    public UGFxAction_SetVariable(nint pointer) : base(pointer) { }


    // ObjectProperty GFxUI.GFxAction_SetVariable.Movie
    // 0x160 (0x8)
    public UGFxMoviePlayer Movie {
        get {
            var pointer = *(nint*)(Pointer + 352);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 352) = value.Pointer;
    }

    // StrProperty GFxUI.GFxAction_SetVariable.Variable
    // 0x168 (0x10)
    // (Edit | NeedCtorLink)
    public FString Variable {
        get => new(Pointer + 360);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 360), 16, 16);
    }


    // Function GFxUI.GFxAction_SetVariable.IsValidLevelSequenceObject
    // 0x3750E0
    // (Defined | Event | Public)
    public unsafe class IsValidLevelSequenceObject_Parameters : BaseObject {
        public IsValidLevelSequenceObject_Parameters() { }
        public IsValidLevelSequenceObject_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty GFxUI.GFxAction_SetVariable.IsValidLevelSequenceObject.ReturnValue
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrIsValidLevelSequenceObject;
    public bool IsValidLevelSequenceObject() {
        _ptrIsValidLevelSequenceObject ??= FindFunction("Function GFxUI.GFxAction_SetVariable.IsValidLevelSequenceObject");

        var @params = stackalloc byte[4];

        ProcessEvent(_ptrIsValidLevelSequenceObject, @params);

        return *(bool*)@params;
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class GFxUI.GFxAction_SetVariable");
            return _staticClass;
        }
    }
}

// Class GFxUI.GFxEvent_FSCommand
// 0x24 (0x17C - 0x1A0)
// (Compiled | Parsed | Native)
public unsafe partial class UGFxEvent_FSCommand : USequenceEvent {
    public UGFxEvent_FSCommand() { }
    public UGFxEvent_FSCommand(nint pointer) : base(pointer) { }


    // MISSED OFFSET: 0x4

    // ObjectProperty GFxUI.GFxEvent_FSCommand.Movie
    // 0x180 (0x8)
    // (Edit)
    public USwfMovie Movie {
        get {
            var pointer = *(nint*)(Pointer + 384);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 384) = value.Pointer;
    }

    // StrProperty GFxUI.GFxEvent_FSCommand.FSCommand
    // 0x188 (0x10)
    // (Edit | NeedCtorLink)
    public FString FSCommand {
        get => new(Pointer + 392);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 392), 16, 16);
    }

    // ObjectProperty GFxUI.GFxEvent_FSCommand.Handler
    // 0x198 (0x8)
    public UGFxFSCmdHandler_Kismet Handler {
        get {
            var pointer = *(nint*)(Pointer + 408);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 408) = value.Pointer;
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class GFxUI.GFxEvent_FSCommand");
            return _staticClass;
        }
    }
}

// Class GFxUI.GFxFSCmdHandler_Kismet
// 0x0 (0x60 - 0x60)
// (Compiled | Parsed | Native)
public unsafe partial class UGFxFSCmdHandler_Kismet : UGFxFSCmdHandler {
    public UGFxFSCmdHandler_Kismet() { }
    public UGFxFSCmdHandler_Kismet(nint pointer) : base(pointer) { }


    // Function GFxUI.GFxFSCmdHandler_Kismet.FSCommand
    // 0xC256D0
    // (Native | Event | Public)
    public unsafe class FSCommand_Parameters : BaseObject {
        public FSCommand_Parameters() { }
        public FSCommand_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty GFxUI.GFxFSCmdHandler_Kismet.FSCommand.Movie
        // 0x0 (0x8)
        // (Param)
        public UGFxMoviePlayer Movie {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // ObjectProperty GFxUI.GFxFSCmdHandler_Kismet.FSCommand.Event
        // 0x8 (0x8)
        // (Param)
        public UGFxEvent_FSCommand Event {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // StrProperty GFxUI.GFxFSCmdHandler_Kismet.FSCommand.Cmd
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString Cmd {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // StrProperty GFxUI.GFxFSCmdHandler_Kismet.FSCommand.Arg
        // 0x20 (0x10)
        // (Param | NeedCtorLink)
        public FString Arg {
            get => new(Pointer + 32);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 32), 16, 16);
        }

        // BoolProperty GFxUI.GFxFSCmdHandler_Kismet.FSCommand.ReturnValue
        // 0x30 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 48) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 48) |= 0x1;
                else *(uint*)(Pointer + 48) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrFSCommand;
    public bool FSCommand(UGFxMoviePlayer Movie, UGFxEvent_FSCommand Event, FString Cmd, FString Arg) {
        _ptrFSCommand ??= FindFunction("Function GFxUI.GFxFSCmdHandler_Kismet.FSCommand");

        var @params = stackalloc byte[52];
        System.Buffer.MemoryCopy((void*)Movie.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Event.Pointer, @params + 8, 8, 8);
        System.Buffer.MemoryCopy((void*)Cmd.Pointer, @params + 16, 16, 16);
        System.Buffer.MemoryCopy((void*)Arg.Pointer, @params + 32, 16, 16);

        _ptrFSCommand.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrFSCommand, @params);
        _ptrFSCommand.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 48);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class GFxUI.GFxFSCmdHandler_Kismet");
            return _staticClass;
        }
    }
}

// Class GFxUI.GFxClikWidget
// 0x18 (0xA0 - 0xB8)
// (Compiled | Parsed)
public unsafe partial class UGFxClikWidget : UGFxObject {
    public UGFxClikWidget() { }
    public UGFxClikWidget(nint pointer) : base(pointer) { }


    // DelegateProperty GFxUI.GFxClikWidget.__EventListener__Delegate
    // 0xA0 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventListener__Delegate {
        get => new(Pointer + 160);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 160), 24, 24);
    }


    // Function GFxUI.GFxClikWidget.ASRemoveAllEventListeners
    // 0x3750E0
    // (Final | Defined | Private)
    public unsafe class ASRemoveAllEventListeners_Parameters : BaseObject {
        public ASRemoveAllEventListeners_Parameters() { }
        public ASRemoveAllEventListeners_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxClikWidget.ASRemoveAllEventListeners.Event
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Event {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrASRemoveAllEventListeners;
    public void ASRemoveAllEventListeners(FString Event) {
        _ptrASRemoveAllEventListeners ??= FindFunction("Function GFxUI.GFxClikWidget.ASRemoveAllEventListeners");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)Event.Pointer, @params, 16, 16);

        ProcessEvent(_ptrASRemoveAllEventListeners, @params);
    }

    // Function GFxUI.GFxClikWidget.AS3AddEventListener
    // 0x3750E0
    // (Final | Defined | HasOptionalParams | Private)
    public unsafe class AS3AddEventListener_Parameters : BaseObject {
        public AS3AddEventListener_Parameters() { }
        public AS3AddEventListener_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxClikWidget.AS3AddEventListener.Type
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Type {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ObjectProperty GFxUI.GFxClikWidget.AS3AddEventListener.O
        // 0x10 (0x8)
        // (Param)
        public UGFxObject O {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }

        // BoolProperty GFxUI.GFxClikWidget.AS3AddEventListener.useCapture
        // 0x18 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool useCapture {
            get => (*(uint*)(Pointer + 24) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 24) |= 0x1;
                else *(uint*)(Pointer + 24) &= ~(uint)0x1;
            }
        }

        // IntProperty GFxUI.GFxClikWidget.AS3AddEventListener.listenerPriority
        // 0x1C (0x4)
        // (OptionalParam | Param)
        public int listenerPriority {
            get => *(int*)(Pointer + 28);
            set => *(int*)(Pointer + 28) = value;
        }

        // BoolProperty GFxUI.GFxClikWidget.AS3AddEventListener.useWeakReference
        // 0x20 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool useWeakReference {
            get => (*(uint*)(Pointer + 32) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 32) |= 0x1;
                else *(uint*)(Pointer + 32) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrAS3AddEventListener;
    public void AS3AddEventListener(FString Type, UGFxObject O, bool useCapture = false, int listenerPriority = 0, bool useWeakReference = false) {
        _ptrAS3AddEventListener ??= FindFunction("Function GFxUI.GFxClikWidget.AS3AddEventListener");

        var @params = stackalloc byte[36];
        System.Buffer.MemoryCopy((void*)Type.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)O.Pointer, @params + 16, 8, 8);
        System.Buffer.MemoryCopy(&useCapture, @params + 24, 4, 4);
        System.Buffer.MemoryCopy(&listenerPriority, @params + 28, 4, 4);
        System.Buffer.MemoryCopy(&useWeakReference, @params + 32, 4, 4);

        ProcessEvent(_ptrAS3AddEventListener, @params);
    }

    // Function GFxUI.GFxClikWidget.ASAddEventListener
    // 0x3750E0
    // (Final | Defined | Private)
    public unsafe class ASAddEventListener_Parameters : BaseObject {
        public ASAddEventListener_Parameters() { }
        public ASAddEventListener_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxClikWidget.ASAddEventListener.Type
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Type {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ObjectProperty GFxUI.GFxClikWidget.ASAddEventListener.O
        // 0x10 (0x8)
        // (Param)
        public UGFxObject O {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }

        // StrProperty GFxUI.GFxClikWidget.ASAddEventListener.func
        // 0x18 (0x10)
        // (Param | NeedCtorLink)
        public FString func {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }
    }
    private static UFunction _ptrASAddEventListener;
    public void ASAddEventListener(FString Type, UGFxObject O, FString func) {
        _ptrASAddEventListener ??= FindFunction("Function GFxUI.GFxClikWidget.ASAddEventListener");

        var @params = stackalloc byte[40];
        System.Buffer.MemoryCopy((void*)Type.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)O.Pointer, @params + 16, 8, 8);
        System.Buffer.MemoryCopy((void*)func.Pointer, @params + 24, 16, 16);

        ProcessEvent(_ptrASAddEventListener, @params);
    }

    // Function GFxUI.GFxClikWidget.SetListener
    // 0x3750E0
    // (Final | Defined | Private)
    public unsafe class SetListener_Parameters : BaseObject {
        public SetListener_Parameters() { }
        public SetListener_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty GFxUI.GFxClikWidget.SetListener.O
        // 0x0 (0x8)
        // (Param)
        public UGFxObject O {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // StrProperty GFxUI.GFxClikWidget.SetListener.Member
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString Member {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // DelegateProperty GFxUI.GFxClikWidget.SetListener.Listener
        // 0x18 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate Listener {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 24, 24);
        }
    }
    private static UFunction _ptrSetListener;
    public void SetListener(UGFxObject O, FString Member, FScriptDelegate Listener) {
        _ptrSetListener ??= FindFunction("Function GFxUI.GFxClikWidget.SetListener");

        var @params = stackalloc byte[48];
        System.Buffer.MemoryCopy((void*)O.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Member.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy((void*)Listener.Pointer, @params + 24, 24, 24);

        ProcessEvent(_ptrSetListener, @params);
    }

    // Function GFxUI.GFxClikWidget.GetEventStringFromTypename
    // 0x3750E0
    // (Final | Defined | Private)
    public unsafe class GetEventStringFromTypename_Parameters : BaseObject {
        public GetEventStringFromTypename_Parameters() { }
        public GetEventStringFromTypename_Parameters(nint pointer) : base(pointer) { }

        // NameProperty GFxUI.GFxClikWidget.GetEventStringFromTypename.Typename
        // 0x0 (0x8)
        // (Param)
        public FName Typename {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // StrProperty GFxUI.GFxClikWidget.GetEventStringFromTypename.ReturnValue
        // 0x8 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrGetEventStringFromTypename;
    public FString GetEventStringFromTypename(FName Typename) {
        _ptrGetEventStringFromTypename ??= FindFunction("Function GFxUI.GFxClikWidget.GetEventStringFromTypename");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)Typename.Pointer, @params, 8, 8);

        ProcessEvent(_ptrGetEventStringFromTypename, @params);

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function GFxUI.GFxClikWidget.RemoveAllEventListeners
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class RemoveAllEventListeners_Parameters : BaseObject {
        public RemoveAllEventListeners_Parameters() { }
        public RemoveAllEventListeners_Parameters(nint pointer) : base(pointer) { }

        // StrProperty GFxUI.GFxClikWidget.RemoveAllEventListeners.Event
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Event {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrRemoveAllEventListeners;
    public void RemoveAllEventListeners(FString Event) {
        _ptrRemoveAllEventListeners ??= FindFunction("Function GFxUI.GFxClikWidget.RemoveAllEventListeners");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)Event.Pointer, @params, 16, 16);

        ProcessEvent(_ptrRemoveAllEventListeners, @params);
    }

    // Function GFxUI.GFxClikWidget.AddEventListener
    // 0x3750E0
    // (Final | Defined | HasOptionalParams | Public)
    public unsafe class AddEventListener_Parameters : BaseObject {
        public AddEventListener_Parameters() { }
        public AddEventListener_Parameters(nint pointer) : base(pointer) { }

        // NameProperty GFxUI.GFxClikWidget.AddEventListener.Type
        // 0x0 (0x8)
        // (Param)
        public FName Type {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // DelegateProperty GFxUI.GFxClikWidget.AddEventListener.Listener
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate Listener {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }

        // BoolProperty GFxUI.GFxClikWidget.AddEventListener.useCapture
        // 0x20 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool useCapture {
            get => (*(uint*)(Pointer + 32) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 32) |= 0x1;
                else *(uint*)(Pointer + 32) &= ~(uint)0x1;
            }
        }

        // IntProperty GFxUI.GFxClikWidget.AddEventListener.listenerPriority
        // 0x24 (0x4)
        // (OptionalParam | Param)
        public int listenerPriority {
            get => *(int*)(Pointer + 36);
            set => *(int*)(Pointer + 36) = value;
        }

        // BoolProperty GFxUI.GFxClikWidget.AddEventListener.useWeakReference
        // 0x28 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool useWeakReference {
            get => (*(uint*)(Pointer + 40) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x1;
                else *(uint*)(Pointer + 40) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrAddEventListener;
    public void AddEventListener(FName Type, FScriptDelegate Listener, bool useCapture = false, int listenerPriority = 0, bool useWeakReference = false) {
        _ptrAddEventListener ??= FindFunction("Function GFxUI.GFxClikWidget.AddEventListener");

        var @params = stackalloc byte[44];
        System.Buffer.MemoryCopy((void*)Type.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Listener.Pointer, @params + 8, 24, 24);
        System.Buffer.MemoryCopy(&useCapture, @params + 32, 4, 4);
        System.Buffer.MemoryCopy(&listenerPriority, @params + 36, 4, 4);
        System.Buffer.MemoryCopy(&useWeakReference, @params + 40, 4, 4);

        ProcessEvent(_ptrAddEventListener, @params);
    }

    // Function GFxUI.GFxClikWidget.EventListener
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventListener_Parameters : BaseObject {
        public EventListener_Parameters() { }
        public EventListener_Parameters(nint pointer) : base(pointer) { }

        // StructProperty GFxUI.GFxClikWidget.EventListener.Data
        // 0x0 (0x38)
        // (Param | NeedCtorLink)
        public FEventData Data {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 56, 56);
        }
    }
    private static UFunction _ptrEventListener;
    public void EventListener(FEventData Data) {
        _ptrEventListener ??= FindFunction("Function GFxUI.GFxClikWidget.EventListener");

        var @params = stackalloc byte[56];
        System.Buffer.MemoryCopy((void*)Data.Pointer, @params, 56, 56);

        ProcessEvent(_ptrEventListener, @params);
    }


    // ScriptStruct GFxUI.GFxClikWidget.EventData
    // 0x34
    public unsafe class FEventData : BaseObject {
        public FEventData() {
            Pointer = Marshal.AllocHGlobal(52);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 52);
            Allocated = true;
        }
        public FEventData(nint pointer) : base(pointer) { }

        // ObjectProperty GFxUI.GFxClikWidget.EventData._this
        // 0x0 (0x8)
        public UGFxObject _this {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // ObjectProperty GFxUI.GFxClikWidget.EventData.Target
        // 0x8 (0x8)
        public UGFxObject Target {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // StrProperty GFxUI.GFxClikWidget.EventData.Type
        // 0x10 (0x10)
        // (NeedCtorLink)
        public FString Type {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // IntProperty GFxUI.GFxClikWidget.EventData.Data
        // 0x20 (0x4)
        public int Data {
            get => *(int*)(Pointer + 32);
            set => *(int*)(Pointer + 32) = value;
        }

        // IntProperty GFxUI.GFxClikWidget.EventData.mouseIndex
        // 0x24 (0x4)
        public int mouseIndex {
            get => *(int*)(Pointer + 36);
            set => *(int*)(Pointer + 36) = value;
        }

        // IntProperty GFxUI.GFxClikWidget.EventData.Button
        // 0x28 (0x4)
        public int Button {
            get => *(int*)(Pointer + 40);
            set => *(int*)(Pointer + 40) = value;
        }

        // IntProperty GFxUI.GFxClikWidget.EventData.Index
        // 0x2C (0x4)
        public int Index {
            get => *(int*)(Pointer + 44);
            set => *(int*)(Pointer + 44) = value;
        }

        // IntProperty GFxUI.GFxClikWidget.EventData.lastIndex
        // 0x30 (0x4)
        public int lastIndex {
            get => *(int*)(Pointer + 48);
            set => *(int*)(Pointer + 48) = value;
        }
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class GFxUI.GFxClikWidget");
            return _staticClass;
        }
    }
}

#pragma warning restore CS0108, CS0114
