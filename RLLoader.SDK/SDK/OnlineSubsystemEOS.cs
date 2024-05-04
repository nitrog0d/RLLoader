using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace RLLoader.SDK;

#pragma warning disable CS0108, CS0114

// Class OnlineSubsystemEOS.AudioDevicesChangedEvent
// 0x0 (0x60 - 0x60)
// (Compiled | Parsed | Native)
public unsafe partial class UAudioDevicesChangedEvent : UObject {
    public UAudioDevicesChangedEvent() { }
    public UAudioDevicesChangedEvent(nint pointer) : base(pointer) { }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class OnlineSubsystemEOS.AudioDevicesChangedEvent");
            return _staticClass;
        }
    }
}

// Class OnlineSubsystemEOS.EOSErrors
// 0x78 (0x80 - 0xF8)
// (Compiled | Parsed | Native)
public unsafe partial class UEOSErrors : UErrorList {
    public UEOSErrors() { }
    public UEOSErrors(nint pointer) : base(pointer) { }


    // ObjectProperty OnlineSubsystemEOS.EOSErrors.EpicUnknownError
    // 0x80 (0x8)
    // (Const)
    public UErrorType EpicUnknownError {
        get {
            var pointer = *(nint*)(Pointer + 128);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 128) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.EOSErrors.BlockedListNotFound
    // 0x88 (0x8)
    // (Const)
    public UErrorType BlockedListNotFound {
        get {
            var pointer = *(nint*)(Pointer + 136);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 136) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.EOSErrors.AcceptFriendRequestFailed
    // 0x90 (0x8)
    // (Const)
    public UErrorType AcceptFriendRequestFailed {
        get {
            var pointer = *(nint*)(Pointer + 144);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 144) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.EOSErrors.RejectFriendRequestFailed
    // 0x98 (0x8)
    // (Const)
    public UErrorType RejectFriendRequestFailed {
        get {
            var pointer = *(nint*)(Pointer + 152);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 152) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.EOSErrors.GameClipsActivationFailed
    // 0xA0 (0x8)
    // (Const)
    public UErrorType GameClipsActivationFailed {
        get {
            var pointer = *(nint*)(Pointer + 160);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 160) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.EOSErrors.GameClipsCleanAudioFailed
    // 0xA8 (0x8)
    // (Const)
    public UErrorType GameClipsCleanAudioFailed {
        get {
            var pointer = *(nint*)(Pointer + 168);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 168) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.EOSErrors.GameClipsRecorderInitFailed
    // 0xB0 (0x8)
    // (Const)
    public UErrorType GameClipsRecorderInitFailed {
        get {
            var pointer = *(nint*)(Pointer + 176);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 176) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.EOSErrors.GameClipsStartRecordingFailed
    // 0xB8 (0x8)
    // (Const)
    public UErrorType GameClipsStartRecordingFailed {
        get {
            var pointer = *(nint*)(Pointer + 184);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 184) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.EOSErrors.GameClipsMaskAreaInvalid
    // 0xC0 (0x8)
    // (Const)
    public UErrorType GameClipsMaskAreaInvalid {
        get {
            var pointer = *(nint*)(Pointer + 192);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 192) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.EOSErrors.GameClipsStatusListenerFailed
    // 0xC8 (0x8)
    // (Const)
    public UErrorType GameClipsStatusListenerFailed {
        get {
            var pointer = *(nint*)(Pointer + 200);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 200) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.EOSErrors.GameClipsUserStatusListenerFailed
    // 0xD0 (0x8)
    // (Const)
    public UErrorType GameClipsUserStatusListenerFailed {
        get {
            var pointer = *(nint*)(Pointer + 208);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 208) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.EOSErrors.GameClipsNotAvailable
    // 0xD8 (0x8)
    // (Const)
    public UErrorType GameClipsNotAvailable {
        get {
            var pointer = *(nint*)(Pointer + 216);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 216) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.EOSErrors.GameClipsFailedToUpload
    // 0xE0 (0x8)
    // (Const)
    public UErrorType GameClipsFailedToUpload {
        get {
            var pointer = *(nint*)(Pointer + 224);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 224) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.EOSErrors.GameClipsCoolingDown
    // 0xE8 (0x8)
    // (Const)
    public UErrorType GameClipsCoolingDown {
        get {
            var pointer = *(nint*)(Pointer + 232);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 232) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.EOSErrors.GameClipsUploadLimitReached
    // 0xF0 (0x8)
    // (Const)
    public UErrorType GameClipsUploadLimitReached {
        get {
            var pointer = *(nint*)(Pointer + 240);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 240) = value.Pointer;
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class OnlineSubsystemEOS.EOSErrors");
            return _staticClass;
        }
    }
}

// Class OnlineSubsystemEOS.OnlineSubsystemEOS
// 0x2F8 (0x3B8 - 0x6B0)
// (Compiled | Config | Parsed | Native | Hidden)
public unsafe partial class UOnlineSubsystemEOS : UOnlineSubsystemCommonImpl {
    public UOnlineSubsystemEOS() { }
    public UOnlineSubsystemEOS(nint pointer) : base(pointer) { }


    // ObjectProperty OnlineSubsystemEOS.OnlineSubsystemEOS.PlayerInterfaceEOS
    // 0x3B8 (0x8)
    public UOnlinePlayerInterfaceEOS PlayerInterfaceEOS {
        get {
            var pointer = *(nint*)(Pointer + 952);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 952) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GameInterfaceEOS
    // 0x3C0 (0x8)
    public UOnlineGameInterfaceEOS GameInterfaceEOS {
        get {
            var pointer = *(nint*)(Pointer + 960);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 960) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.OnlineSubsystemEOS.StatsInterfaceEOS
    // 0x3C8 (0x8)
    public UOnlineStatsInterfaceEOS StatsInterfaceEOS {
        get {
            var pointer = *(nint*)(Pointer + 968);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 968) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AuthInterfaceEOS
    // 0x3D0 (0x8)
    public UOnlineAuthInterfaceEOS AuthInterfaceEOS {
        get {
            var pointer = *(nint*)(Pointer + 976);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 976) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.OnlineSubsystemEOS.PersistentAuthInterfaceEOS
    // 0x3D8 (0x8)
    public UOnlinePersistentAuthInterfaceEOS PersistentAuthInterfaceEOS {
        get {
            var pointer = *(nint*)(Pointer + 984);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 984) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.OnlineSubsystemEOS.FriendsInterfaceEOS
    // 0x3E0 (0x8)
    public UOnlineFriendsInterfaceEOS FriendsInterfaceEOS {
        get {
            var pointer = *(nint*)(Pointer + 992);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 992) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.OnlineSubsystemEOS.UserCloudFileInterfaceEOS
    // 0x3E8 (0x8)
    public UOnlineUserCloudFileInterfaceEOS UserCloudFileInterfaceEOS {
        get {
            var pointer = *(nint*)(Pointer + 1000);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 1000) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.OnlineSubsystemEOS.VoiceInterfaceEOS
    // 0x3F0 (0x8)
    public UOnlineVoiceInterfaceEOS VoiceInterfaceEOS {
        get {
            var pointer = *(nint*)(Pointer + 1008);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 1008) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GameClipsInterfaceEOS
    // 0x3F8 (0x8)
    public UOnlineGameClipsInterfaceEOS GameClipsInterfaceEOS {
        get {
            var pointer = *(nint*)(Pointer + 1016);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 1016) = value.Pointer;
    }

    // ArrayProperty OnlineSubsystemEOS.OnlineSubsystemEOS.SpeechRecognitionCompleteDelegates
    // 0x400 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> SpeechRecognitionCompleteDelegates {
        get => new(Pointer + 1024, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1024), 16, 16);
    }

    // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AuthHandle
    // 0x410 (0x8)
    // (Const | Native | Transient)
    public nint AuthHandle {
        get => *(nint*)(Pointer + 1040);
        set => *(nint*)(Pointer + 1040) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.FriendsHandle
    // 0x418 (0x8)
    // (Const | Native | Transient)
    public nint FriendsHandle {
        get => *(nint*)(Pointer + 1048);
        set => *(nint*)(Pointer + 1048) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.UserInfoHandle
    // 0x420 (0x8)
    // (Const | Native | Transient)
    public nint UserInfoHandle {
        get => *(nint*)(Pointer + 1056);
        set => *(nint*)(Pointer + 1056) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.PresenceHandle
    // 0x428 (0x8)
    // (Const | Native | Transient)
    public nint PresenceHandle {
        get => *(nint*)(Pointer + 1064);
        set => *(nint*)(Pointer + 1064) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ConnectHandle
    // 0x430 (0x8)
    // (Const | Native | Transient)
    public nint ConnectHandle {
        get => *(nint*)(Pointer + 1072);
        set => *(nint*)(Pointer + 1072) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.SessionsHandle
    // 0x438 (0x8)
    // (Const | Native | Transient)
    public nint SessionsHandle {
        get => *(nint*)(Pointer + 1080);
        set => *(nint*)(Pointer + 1080) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.PDSHandle
    // 0x440 (0x8)
    // (Const | Native | Transient)
    public nint PDSHandle {
        get => *(nint*)(Pointer + 1088);
        set => *(nint*)(Pointer + 1088) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.StatsHandle
    // 0x448 (0x8)
    // (Const | Native | Transient)
    public nint StatsHandle {
        get => *(nint*)(Pointer + 1096);
        set => *(nint*)(Pointer + 1096) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AchievementsHandle
    // 0x450 (0x8)
    // (Const | Native | Transient)
    public nint AchievementsHandle {
        get => *(nint*)(Pointer + 1104);
        set => *(nint*)(Pointer + 1104) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.EcomHandle
    // 0x458 (0x8)
    // (Const | Native | Transient)
    public nint EcomHandle {
        get => *(nint*)(Pointer + 1112);
        set => *(nint*)(Pointer + 1112) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.UIHandle
    // 0x460 (0x8)
    // (Const | Native | Transient)
    public nint UIHandle {
        get => *(nint*)(Pointer + 1120);
        set => *(nint*)(Pointer + 1120) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.RTCHandle
    // 0x468 (0x8)
    // (Const | Native | Transient)
    public nint RTCHandle {
        get => *(nint*)(Pointer + 1128);
        set => *(nint*)(Pointer + 1128) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.RTCAudioHandle
    // 0x470 (0x8)
    // (Const | Native | Transient)
    public nint RTCAudioHandle {
        get => *(nint*)(Pointer + 1136);
        set => *(nint*)(Pointer + 1136) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.RTCAdminHandle
    // 0x478 (0x8)
    // (Const | Native | Transient)
    public nint RTCAdminHandle {
        get => *(nint*)(Pointer + 1144);
        set => *(nint*)(Pointer + 1144) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GameClipsHandle
    // 0x480 (0x8)
    // (Const | Native | Transient)
    public nint GameClipsHandle {
        get => *(nint*)(Pointer + 1152);
        set => *(nint*)(Pointer + 1152) = value;
    }

    // ArrayProperty OnlineSubsystemEOS.OnlineSubsystemEOS.UnlockedDLC
    // 0x488 (0x10)
    // (Transient | NeedCtorLink)
    public StructTArray<FName> UnlockedDLC {
        get => new(Pointer + 1160, 8);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1160), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlineSubsystemEOS.UnlockedDLCDelegates
    // 0x498 (0x10)
    // (Transient | NeedCtorLink)
    public StructTArray<FScriptDelegate> UnlockedDLCDelegates {
        get => new(Pointer + 1176, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1176), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ExternalUIChangeDelegates
    // 0x4A8 (0x10)
    // (Transient | NeedCtorLink)
    public StructTArray<FScriptDelegate> ExternalUIChangeDelegates {
        get => new(Pointer + 1192, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1192), 16, 16);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__OnMicroTxnResponse__Delegate
    // 0x4B8 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnMicroTxnResponse__Delegate {
        get => new(Pointer + 1208);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1208), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__EventGetAppPriceInfoComplete__Delegate
    // 0x4D0 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventGetAppPriceInfoComplete__Delegate {
        get => new(Pointer + 1232);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1232), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__OnPlayerTalking__Delegate
    // 0x4E8 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnPlayerTalking__Delegate {
        get => new(Pointer + 1256);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1256), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__OnRecognitionComplete__Delegate
    // 0x500 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnRecognitionComplete__Delegate {
        get => new(Pointer + 1280);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1280), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__OnReadOnlineStatsComplete__Delegate
    // 0x518 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnReadOnlineStatsComplete__Delegate {
        get => new(Pointer + 1304);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1304), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__OnRegisterHostStatGuidComplete__Delegate
    // 0x530 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnRegisterHostStatGuidComplete__Delegate {
        get => new(Pointer + 1328);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1328), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__OnFlushOnlineStatsComplete__Delegate
    // 0x548 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnFlushOnlineStatsComplete__Delegate {
        get => new(Pointer + 1352);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1352), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__OnLinkStatusChange__Delegate
    // 0x560 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnLinkStatusChange__Delegate {
        get => new(Pointer + 1376);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1376), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__OnExternalUIChange__Delegate
    // 0x578 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnExternalUIChange__Delegate {
        get => new(Pointer + 1400);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1400), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__OnControllerChange__Delegate
    // 0x590 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnControllerChange__Delegate {
        get => new(Pointer + 1424);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1424), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__OnConnectionStatusChange__Delegate
    // 0x5A8 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnConnectionStatusChange__Delegate {
        get => new(Pointer + 1448);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1448), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__OnStorageDeviceChange__Delegate
    // 0x5C0 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnStorageDeviceChange__Delegate {
        get => new(Pointer + 1472);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1472), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__OnCreateOnlineAccountCompleted__Delegate
    // 0x5D8 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnCreateOnlineAccountCompleted__Delegate {
        get => new(Pointer + 1496);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1496), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__OnPlayerTalkingStateChange__Delegate
    // 0x5F0 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnPlayerTalkingStateChange__Delegate {
        get => new(Pointer + 1520);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1520), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__OnCloseKickPlayerDialog__Delegate
    // 0x608 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnCloseKickPlayerDialog__Delegate {
        get => new(Pointer + 1544);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1544), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__OnCommerceDialogClosed__Delegate
    // 0x620 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnCommerceDialogClosed__Delegate {
        get => new(Pointer + 1568);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1568), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__OnErrorDialogClosed__Delegate
    // 0x638 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnErrorDialogClosed__Delegate {
        get => new(Pointer + 1592);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1592), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__OnUnlockedDLCChange__Delegate
    // 0x650 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnUnlockedDLCChange__Delegate {
        get => new(Pointer + 1616);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1616), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__OnStorePurchaseCompleteDelegate__Delegate
    // 0x668 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnStorePurchaseCompleteDelegate__Delegate {
        get => new(Pointer + 1640);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1640), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__OnUserOrphaned__Delegate
    // 0x680 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnUserOrphaned__Delegate {
        get => new(Pointer + 1664);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1664), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.__OnUserRestored__Delegate
    // 0x698 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnUserRestored__Delegate {
        get => new(Pointer + 1688);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1688), 24, 24);
    }


    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.TickEOSPlatform
    // 0xCDE0E0
    // (Final | Native | Public)
    public unsafe class TickEOSPlatform_Parameters : BaseObject {
        public TickEOSPlatform_Parameters() { }
        public TickEOSPlatform_Parameters(nint pointer) : base(pointer) { }

        // FloatProperty OnlineSubsystemEOS.OnlineSubsystemEOS.TickEOSPlatform.DeltaTime
        // 0x0 (0x4)
        // (Param)
        public float DeltaTime {
            get => *(float*)Pointer;
            set => *(float*)Pointer = value;
        }
    }
    private static UFunction _ptrTickEOSPlatform;
    public void TickEOSPlatform(float DeltaTime) {
        _ptrTickEOSPlatform ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.TickEOSPlatform");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&DeltaTime, @params, 4, 4);

        _ptrTickEOSPlatform.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrTickEOSPlatform, @params);
        _ptrTickEOSPlatform.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ManuallyTickEOSPlatform
    // 0xCDE090
    // (Final | Native | Public)
    public unsafe class ManuallyTickEOSPlatform_Parameters : BaseObject {
        public ManuallyTickEOSPlatform_Parameters() { }
        public ManuallyTickEOSPlatform_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ManuallyTickEOSPlatform.ReturnValue
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
    private static UFunction _ptrManuallyTickEOSPlatform;
    public bool ManuallyTickEOSPlatform() {
        _ptrManuallyTickEOSPlatform ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ManuallyTickEOSPlatform");

        var @params = stackalloc byte[4];

        _ptrManuallyTickEOSPlatform.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrManuallyTickEOSPlatform, @params);
        _ptrManuallyTickEOSPlatform.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)@params;
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.FormatCurrency
    // 0x3750E0
    // (Final | Defined | Event | Public)
    public unsafe class FormatCurrency_Parameters : BaseObject {
        public FormatCurrency_Parameters() { }
        public FormatCurrency_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.FormatCurrency.Currency
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Currency {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // IntProperty OnlineSubsystemEOS.OnlineSubsystemEOS.FormatCurrency.Price
        // 0x10 (0x4)
        // (Param)
        public int Price {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.FormatCurrency.ReturnValue
        // 0x18 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }
    }
    private static UFunction _ptrFormatCurrency;
    public FString FormatCurrency(FString Currency, int Price) {
        _ptrFormatCurrency ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.FormatCurrency");

        var @params = stackalloc byte[36];
        System.Buffer.MemoryCopy((void*)Currency.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&Price, @params + 16, 4, 4);

        ProcessEvent(_ptrFormatCurrency, @params);

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 24, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearMicroTxnResponseDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearMicroTxnResponseDelegate_Parameters : BaseObject {
        public ClearMicroTxnResponseDelegate_Parameters() { }
        public ClearMicroTxnResponseDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ClearMicroTxnResponseDelegate.ResponseMicroTxnDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ResponseMicroTxnDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearMicroTxnResponseDelegate;
    public void ClearMicroTxnResponseDelegate(FScriptDelegate ResponseMicroTxnDelegate) {
        _ptrClearMicroTxnResponseDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearMicroTxnResponseDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)ResponseMicroTxnDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearMicroTxnResponseDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddMicroTxnResponseDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddMicroTxnResponseDelegate_Parameters : BaseObject {
        public AddMicroTxnResponseDelegate_Parameters() { }
        public AddMicroTxnResponseDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AddMicroTxnResponseDelegate.ResponseMicroTxnDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ResponseMicroTxnDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddMicroTxnResponseDelegate;
    public void AddMicroTxnResponseDelegate(FScriptDelegate ResponseMicroTxnDelegate) {
        _ptrAddMicroTxnResponseDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddMicroTxnResponseDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)ResponseMicroTxnDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddMicroTxnResponseDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetAppPriceInfo
    // 0xCDDED0
    // (Final | Native | Public | HasOutParams)
    public unsafe class GetAppPriceInfo_Parameters : BaseObject {
        public GetAppPriceInfo_Parameters() { }
        public GetAppPriceInfo_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetAppPriceInfo.PlayerID
        // 0x0 (0x48)
        // (Const | Param | OutParam | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // ArrayProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetAppPriceInfo.AppNames
        // 0x48 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public StructTArray<FName> AppNames {
            get => new(Pointer + 72, 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 72), 16, 16);
        }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetAppPriceInfo.Callback
        // 0x58 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate Callback {
            get => new(Pointer + 88);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 88), 24, 24);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetAppPriceInfo.ReturnValue
        // 0x70 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 112) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 112) |= 0x1;
                else *(uint*)(Pointer + 112) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrGetAppPriceInfo;
    public bool GetAppPriceInfo(ref U_Types_Core.FUniqueNetId PlayerID, ref StructTArray<FName> AppNames, FScriptDelegate Callback) {
        _ptrGetAppPriceInfo ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetAppPriceInfo");

        var @params = stackalloc byte[116];
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params, 72, 72);
        System.Buffer.MemoryCopy((void*)AppNames.Pointer, @params + 72, 16, 16);
        System.Buffer.MemoryCopy((void*)Callback.Pointer, @params + 88, 24, 24);

        _ptrGetAppPriceInfo.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetAppPriceInfo, @params);
        _ptrGetAppPriceInfo.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _PlayerIDPtr = Marshal.AllocHGlobal(72);
        System.Buffer.MemoryCopy(@params, (void*)_PlayerIDPtr, 72, 72);
        PlayerID = new(_PlayerIDPtr) { Allocated = true };
        var _AppNamesPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 72, (void*)_AppNamesPtr, 16, 16);
        AppNames = new(_AppNamesPtr, 8) { Allocated = true };

        return *(bool*)(@params + 112);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.HandleBootMessage
    // 0x678840
    // (Final | Native | Public)
    public unsafe class HandleBootMessage_Parameters : BaseObject {
        public HandleBootMessage_Parameters() { }
        public HandleBootMessage_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.HandleBootMessage.ReturnValue
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
    private static UFunction _ptrHandleBootMessage;
    public bool HandleBootMessage() {
        _ptrHandleBootMessage ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.HandleBootMessage");

        var @params = stackalloc byte[4];

        _ptrHandleBootMessage.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrHandleBootMessage, @params);
        _ptrHandleBootMessage.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)@params;
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetOverlayEnabled
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class GetOverlayEnabled_Parameters : BaseObject {
        public GetOverlayEnabled_Parameters() { }
        public GetOverlayEnabled_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetOverlayEnabled.ReturnValue
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
    private static UFunction _ptrGetOverlayEnabled;
    public bool GetOverlayEnabled() {
        _ptrGetOverlayEnabled ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetOverlayEnabled");

        var @params = stackalloc byte[4];

        ProcessEvent(_ptrGetOverlayEnabled, @params);

        return *(bool*)@params;
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.RefreshNetworkErrorToggle
    // 0x3750E0
    // (Final | Public)
    public unsafe class RefreshNetworkErrorToggle_Parameters : BaseObject {
        public RefreshNetworkErrorToggle_Parameters() { }
        public RefreshNetworkErrorToggle_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.RefreshNetworkErrorToggle.ReturnValue
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
    private static UFunction _ptrRefreshNetworkErrorToggle;
    public bool RefreshNetworkErrorToggle() {
        _ptrRefreshNetworkErrorToggle ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.RefreshNetworkErrorToggle");

        var @params = stackalloc byte[4];

        ProcessEvent(_ptrRefreshNetworkErrorToggle, @params);

        return *(bool*)@params;
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearUserRestoredDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearUserRestoredDelegate_Parameters : BaseObject {
        public ClearUserRestoredDelegate_Parameters() { }
        public ClearUserRestoredDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ClearUserRestoredDelegate.UserRestoredDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate UserRestoredDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearUserRestoredDelegate;
    public void ClearUserRestoredDelegate(FScriptDelegate UserRestoredDelegate) {
        _ptrClearUserRestoredDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearUserRestoredDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)UserRestoredDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearUserRestoredDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddUserRestoredDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddUserRestoredDelegate_Parameters : BaseObject {
        public AddUserRestoredDelegate_Parameters() { }
        public AddUserRestoredDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AddUserRestoredDelegate.UserRestoredDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate UserRestoredDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddUserRestoredDelegate;
    public void AddUserRestoredDelegate(FScriptDelegate UserRestoredDelegate) {
        _ptrAddUserRestoredDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddUserRestoredDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)UserRestoredDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddUserRestoredDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnUserRestored
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnUserRestored_Parameters : BaseObject {
        public OnUserRestored_Parameters() { }
        public OnUserRestored_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OnUserRestored.ControllerId
        // 0x0 (0x1)
        // (Param)
        public byte ControllerId {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }
    }
    private static UFunction _ptrOnUserRestored;
    public void OnUserRestored(byte ControllerId) {
        _ptrOnUserRestored ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnUserRestored");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&ControllerId, @params, 1, 1);

        ProcessEvent(_ptrOnUserRestored, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearUserOrphanedDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearUserOrphanedDelegate_Parameters : BaseObject {
        public ClearUserOrphanedDelegate_Parameters() { }
        public ClearUserOrphanedDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ClearUserOrphanedDelegate.UserOrphanedDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate UserOrphanedDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearUserOrphanedDelegate;
    public void ClearUserOrphanedDelegate(FScriptDelegate UserOrphanedDelegate) {
        _ptrClearUserOrphanedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearUserOrphanedDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)UserOrphanedDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearUserOrphanedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddUserOrphanedDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddUserOrphanedDelegate_Parameters : BaseObject {
        public AddUserOrphanedDelegate_Parameters() { }
        public AddUserOrphanedDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AddUserOrphanedDelegate.UserOrphanedDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate UserOrphanedDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddUserOrphanedDelegate;
    public void AddUserOrphanedDelegate(FScriptDelegate UserOrphanedDelegate) {
        _ptrAddUserOrphanedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddUserOrphanedDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)UserOrphanedDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddUserOrphanedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnUserOrphaned
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnUserOrphaned_Parameters : BaseObject {
        public OnUserOrphaned_Parameters() { }
        public OnUserOrphaned_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OnUserOrphaned.ControllerId
        // 0x0 (0x1)
        // (Param)
        public byte ControllerId {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }
    }
    private static UFunction _ptrOnUserOrphaned;
    public void OnUserOrphaned(byte ControllerId) {
        _ptrOnUserOrphaned ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnUserOrphaned");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&ControllerId, @params, 1, 1);

        ProcessEvent(_ptrOnUserOrphaned, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OpenStoreForItemsAsync
    // 0x3750E0
    // (Final | Public)
    public unsafe class OpenStoreForItemsAsync_Parameters : BaseObject {
        public OpenStoreForItemsAsync_Parameters() { }
        public OpenStoreForItemsAsync_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OpenStoreForItemsAsync.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ArrayProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OpenStoreForItemsAsync.Targets
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public StructTArray<FString> Targets {
            get => new(Pointer + 8, 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OpenStoreForItemsAsync.OnStorePurchaseCompleteDelegate
        // 0x18 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate OnStorePurchaseCompleteDelegate {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 24, 24);
        }
    }
    private static UFunction _ptrOpenStoreForItemsAsync;
    public void OpenStoreForItemsAsync(byte LocalUserNum, StructTArray<FString> Targets, FScriptDelegate OnStorePurchaseCompleteDelegate) {
        _ptrOpenStoreForItemsAsync ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OpenStoreForItemsAsync");

        var @params = stackalloc byte[41];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)Targets.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy((void*)OnStorePurchaseCompleteDelegate.Pointer, @params + 24, 24, 24);

        ProcessEvent(_ptrOpenStoreForItemsAsync, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnStorePurchaseCompleteDelegate
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnStorePurchaseCompleteDelegate_Parameters : BaseObject {
        public OnStorePurchaseCompleteDelegate_Parameters() { }
        public OnStorePurchaseCompleteDelegate_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrOnStorePurchaseCompleteDelegate;
    public void OnStorePurchaseCompleteDelegate() {
        _ptrOnStorePurchaseCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnStorePurchaseCompleteDelegate");

        ProcessEvent(_ptrOnStorePurchaseCompleteDelegate, null);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OpenStoreForItems
    // 0xCDDDB0
    // (Final | Native | Public)
    public unsafe class OpenStoreForItems_Parameters : BaseObject {
        public OpenStoreForItems_Parameters() { }
        public OpenStoreForItems_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OpenStoreForItems.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ArrayProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OpenStoreForItems.Targets
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public StructTArray<FString> Targets {
            get => new(Pointer + 8, 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrOpenStoreForItems;
    public void OpenStoreForItems(byte LocalUserNum, StructTArray<FString> Targets) {
        _ptrOpenStoreForItems ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OpenStoreForItems");

        var @params = stackalloc byte[17];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)Targets.Pointer, @params + 8, 16, 16);

        _ptrOpenStoreForItems.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrOpenStoreForItems, @params);
        _ptrOpenStoreForItems.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OpenStoreForDLC
    // 0x3750E0
    // (Final | Public)
    public unsafe class OpenStoreForDLC_Parameters : BaseObject {
        public OpenStoreForDLC_Parameters() { }
        public OpenStoreForDLC_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OpenStoreForDLC.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // NameProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OpenStoreForDLC.DLC
        // 0x4 (0x8)
        // (Param)
        public FName DLC {
            get => new(Pointer + 4);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 4), 8, 8);
        }
    }
    private static UFunction _ptrOpenStoreForDLC;
    public void OpenStoreForDLC(byte LocalUserNum, FName DLC) {
        _ptrOpenStoreForDLC ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OpenStoreForDLC");

        var @params = stackalloc byte[9];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)DLC.Pointer, @params + 4, 8, 8);

        ProcessEvent(_ptrOpenStoreForDLC, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OpenErrorDialog
    // 0x3750E0
    // (Final | Public)
    public unsafe class OpenErrorDialog_Parameters : BaseObject {
        public OpenErrorDialog_Parameters() { }
        public OpenErrorDialog_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OpenErrorDialog.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OpenErrorDialog.ErrorCode
        // 0x1 (0x1)
        // (Param)
        public UOnlineSubsystem.EPS4ErrorDialog ErrorCode {
            get => *(UOnlineSubsystem.EPS4ErrorDialog*)(Pointer + 1);
            set => *(UOnlineSubsystem.EPS4ErrorDialog*)(Pointer + 1) = value;
        }
    }
    private static UFunction _ptrOpenErrorDialog;
    public void OpenErrorDialog(byte LocalUserNum, UOnlineSubsystem.EPS4ErrorDialog ErrorCode) {
        _ptrOpenErrorDialog ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OpenErrorDialog");

        var @params = stackalloc byte[2];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&ErrorCode, @params + 1, 1, 1);

        ProcessEvent(_ptrOpenErrorDialog, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OpenPS4DisplayMode
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class OpenPS4DisplayMode_Parameters : BaseObject {
        public OpenPS4DisplayMode_Parameters() { }
        public OpenPS4DisplayMode_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OpenPS4DisplayMode.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OpenPS4DisplayMode.DisplayMode
        // 0x1 (0x1)
        // (Param)
        public UOnlineSubsystem.EPS4DisplayMode DisplayMode {
            get => *(UOnlineSubsystem.EPS4DisplayMode*)(Pointer + 1);
            set => *(UOnlineSubsystem.EPS4DisplayMode*)(Pointer + 1) = value;
        }

        // MISSED OFFSET: 0x6

        // ArrayProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OpenPS4DisplayMode.Targets
        // 0x8 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public StructTArray<FString> Targets {
            get => new(Pointer + 8, 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // IntProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OpenPS4DisplayMode.ServiceLabel
        // 0x18 (0x4)
        // (OptionalParam | Param)
        public int ServiceLabel {
            get => *(int*)(Pointer + 24);
            set => *(int*)(Pointer + 24) = value;
        }
    }
    private static UFunction _ptrOpenPS4DisplayMode;
    public void OpenPS4DisplayMode(byte LocalUserNum, UOnlineSubsystem.EPS4DisplayMode DisplayMode, StructTArray<FString> Targets = null, int ServiceLabel = 0) {
        _ptrOpenPS4DisplayMode ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OpenPS4DisplayMode");

        var @params = stackalloc byte[22];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&DisplayMode, @params + 1, 1, 1);
        if (Targets != null) System.Buffer.MemoryCopy((void*)Targets.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy(&ServiceLabel, @params + 24, 4, 4);

        ProcessEvent(_ptrOpenPS4DisplayMode, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ResetControllerColor
    // 0x3750E0
    // (Final | Public)
    public unsafe class ResetControllerColor_Parameters : BaseObject {
        public ResetControllerColor_Parameters() { }
        public ResetControllerColor_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ResetControllerColor.ControllerId
        // 0x0 (0x4)
        // (Param)
        public int ControllerId {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrResetControllerColor;
    public void ResetControllerColor(int ControllerId) {
        _ptrResetControllerColor ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ResetControllerColor");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&ControllerId, @params, 4, 4);

        ProcessEvent(_ptrResetControllerColor, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.SetControllerColor
    // 0x3750E0
    // (Final | Public)
    public unsafe class SetControllerColor_Parameters : BaseObject {
        public SetControllerColor_Parameters() { }
        public SetControllerColor_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlineSubsystemEOS.SetControllerColor.ControllerId
        // 0x0 (0x4)
        // (Param)
        public int ControllerId {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.SetControllerColor.NewColor
        // 0x4 (0x4)
        // (Param)
        public FColor NewColor {
            get => new(Pointer + 4);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 4), 4, 4);
        }
    }
    private static UFunction _ptrSetControllerColor;
    public void SetControllerColor(int ControllerId, FColor NewColor) {
        _ptrSetControllerColor ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.SetControllerColor");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&ControllerId, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)NewColor.Pointer, @params + 4, 4, 4);

        ProcessEvent(_ptrSetControllerColor, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.InitializeTrophyAPI
    // 0x3750E0
    // (Final | Public)
    public unsafe class InitializeTrophyAPI_Parameters : BaseObject {
        public InitializeTrophyAPI_Parameters() { }
        public InitializeTrophyAPI_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrInitializeTrophyAPI;
    public void InitializeTrophyAPI() {
        _ptrInitializeTrophyAPI ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.InitializeTrophyAPI");

        ProcessEvent(_ptrInitializeTrophyAPI, null);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.AnyPlayerChatRestricted
    // 0x3750E0
    // (Final | Public)
    public unsafe class AnyPlayerChatRestricted_Parameters : BaseObject {
        public AnyPlayerChatRestricted_Parameters() { }
        public AnyPlayerChatRestricted_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AnyPlayerChatRestricted.ReturnValue
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
    private static UFunction _ptrAnyPlayerChatRestricted;
    public bool AnyPlayerChatRestricted() {
        _ptrAnyPlayerChatRestricted ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.AnyPlayerChatRestricted");

        var @params = stackalloc byte[4];

        ProcessEvent(_ptrAnyPlayerChatRestricted, @params);

        return *(bool*)@params;
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearUnlockedDLCChangeDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearUnlockedDLCChangeDelegate_Parameters : BaseObject {
        public ClearUnlockedDLCChangeDelegate_Parameters() { }
        public ClearUnlockedDLCChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ClearUnlockedDLCChangeDelegate.InDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearUnlockedDLCChangeDelegate;
    public void ClearUnlockedDLCChangeDelegate(FScriptDelegate InDelegate) {
        _ptrClearUnlockedDLCChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearUnlockedDLCChangeDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearUnlockedDLCChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddUnlockedDLCChangeDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddUnlockedDLCChangeDelegate_Parameters : BaseObject {
        public AddUnlockedDLCChangeDelegate_Parameters() { }
        public AddUnlockedDLCChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AddUnlockedDLCChangeDelegate.InDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddUnlockedDLCChangeDelegate;
    public void AddUnlockedDLCChangeDelegate(FScriptDelegate InDelegate) {
        _ptrAddUnlockedDLCChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddUnlockedDLCChangeDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddUnlockedDLCChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetUnlockedDLC
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class GetUnlockedDLC_Parameters : BaseObject {
        public GetUnlockedDLC_Parameters() { }
        public GetUnlockedDLC_Parameters(nint pointer) : base(pointer) { }

        // ArrayProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetUnlockedDLC.ReturnValue
        // 0x0 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public StructTArray<FName> ReturnValue {
            get => new(Pointer, 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetUnlockedDLC;
    public StructTArray<FName> GetUnlockedDLC() {
        _ptrGetUnlockedDLC ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetUnlockedDLC");

        var @params = stackalloc byte[16];

        ProcessEvent(_ptrGetUnlockedDLC, @params);

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr, 8) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnUnlockedDLCChange
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnUnlockedDLCChange_Parameters : BaseObject {
        public OnUnlockedDLCChange_Parameters() { }
        public OnUnlockedDLCChange_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrOnUnlockedDLCChange;
    public void OnUnlockedDLCChange() {
        _ptrOnUnlockedDLCChange ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnUnlockedDLCChange");

        ProcessEvent(_ptrOnUnlockedDLCChange, null);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.UpdateSessionStatusFromPlayers
    // 0x3750E0
    // (Final | Public)
    public unsafe class UpdateSessionStatusFromPlayers_Parameters : BaseObject {
        public UpdateSessionStatusFromPlayers_Parameters() { }
        public UpdateSessionStatusFromPlayers_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlineSubsystemEOS.UpdateSessionStatusFromPlayers.CurrentPlayerCount
        // 0x0 (0x4)
        // (Param)
        public int CurrentPlayerCount {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // IntProperty OnlineSubsystemEOS.OnlineSubsystemEOS.UpdateSessionStatusFromPlayers.numBotPlayers
        // 0x4 (0x4)
        // (Param)
        public int numBotPlayers {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }
    }
    private static UFunction _ptrUpdateSessionStatusFromPlayers;
    public void UpdateSessionStatusFromPlayers(int CurrentPlayerCount, int numBotPlayers) {
        _ptrUpdateSessionStatusFromPlayers ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.UpdateSessionStatusFromPlayers");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&CurrentPlayerCount, @params, 4, 4);
        System.Buffer.MemoryCopy(&numBotPlayers, @params + 4, 4, 4);

        ProcessEvent(_ptrUpdateSessionStatusFromPlayers, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearErrorDialogClosedDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearErrorDialogClosedDelegate_Parameters : BaseObject {
        public ClearErrorDialogClosedDelegate_Parameters() { }
        public ClearErrorDialogClosedDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ClearErrorDialogClosedDelegate.InDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearErrorDialogClosedDelegate;
    public void ClearErrorDialogClosedDelegate(FScriptDelegate InDelegate) {
        _ptrClearErrorDialogClosedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearErrorDialogClosedDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearErrorDialogClosedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddErrorDialogClosedDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddErrorDialogClosedDelegate_Parameters : BaseObject {
        public AddErrorDialogClosedDelegate_Parameters() { }
        public AddErrorDialogClosedDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AddErrorDialogClosedDelegate.InDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddErrorDialogClosedDelegate;
    public void AddErrorDialogClosedDelegate(FScriptDelegate InDelegate) {
        _ptrAddErrorDialogClosedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddErrorDialogClosedDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddErrorDialogClosedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnErrorDialogClosed
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnErrorDialogClosed_Parameters : BaseObject {
        public OnErrorDialogClosed_Parameters() { }
        public OnErrorDialogClosed_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OnErrorDialogClosed.LocalUserNum
        // 0x0 (0x4)
        // (Param)
        public int LocalUserNum {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrOnErrorDialogClosed;
    public void OnErrorDialogClosed(int LocalUserNum) {
        _ptrOnErrorDialogClosed ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnErrorDialogClosed");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 4, 4);

        ProcessEvent(_ptrOnErrorDialogClosed, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearCommerceDialogClosedDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearCommerceDialogClosedDelegate_Parameters : BaseObject {
        public ClearCommerceDialogClosedDelegate_Parameters() { }
        public ClearCommerceDialogClosedDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ClearCommerceDialogClosedDelegate.InDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearCommerceDialogClosedDelegate;
    public void ClearCommerceDialogClosedDelegate(FScriptDelegate InDelegate) {
        _ptrClearCommerceDialogClosedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearCommerceDialogClosedDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearCommerceDialogClosedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddCommerceDialogClosedDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddCommerceDialogClosedDelegate_Parameters : BaseObject {
        public AddCommerceDialogClosedDelegate_Parameters() { }
        public AddCommerceDialogClosedDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AddCommerceDialogClosedDelegate.InDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddCommerceDialogClosedDelegate;
    public void AddCommerceDialogClosedDelegate(FScriptDelegate InDelegate) {
        _ptrAddCommerceDialogClosedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddCommerceDialogClosedDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddCommerceDialogClosedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnCommerceDialogClosed
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnCommerceDialogClosed_Parameters : BaseObject {
        public OnCommerceDialogClosed_Parameters() { }
        public OnCommerceDialogClosed_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrOnCommerceDialogClosed;
    public void OnCommerceDialogClosed() {
        _ptrOnCommerceDialogClosed ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnCommerceDialogClosed");

        ProcessEvent(_ptrOnCommerceDialogClosed, null);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetCurrentConnectionStatus
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class GetCurrentConnectionStatus_Parameters : BaseObject {
        public GetCurrentConnectionStatus_Parameters() { }
        public GetCurrentConnectionStatus_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetCurrentConnectionStatus.ReturnValue
        // 0x0 (0x1)
        // (Param | OutParam | ReturnParam)
        public UOnlineSubsystem.EOnlineServerConnectionStatus ReturnValue {
            get => *(UOnlineSubsystem.EOnlineServerConnectionStatus*)Pointer;
            set => *(UOnlineSubsystem.EOnlineServerConnectionStatus*)Pointer = value;
        }
    }
    private static UFunction _ptrGetCurrentConnectionStatus;
    public UOnlineSubsystem.EOnlineServerConnectionStatus GetCurrentConnectionStatus() {
        _ptrGetCurrentConnectionStatus ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetCurrentConnectionStatus");

        var @params = stackalloc byte[1];

        ProcessEvent(_ptrGetCurrentConnectionStatus, @params);

        return *(UOnlineSubsystem.EOnlineServerConnectionStatus*)@params;
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearCloseKickPlayerDialogDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearCloseKickPlayerDialogDelegate_Parameters : BaseObject {
        public ClearCloseKickPlayerDialogDelegate_Parameters() { }
        public ClearCloseKickPlayerDialogDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ClearCloseKickPlayerDialogDelegate.InDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearCloseKickPlayerDialogDelegate;
    public void ClearCloseKickPlayerDialogDelegate(FScriptDelegate InDelegate) {
        _ptrClearCloseKickPlayerDialogDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearCloseKickPlayerDialogDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearCloseKickPlayerDialogDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddCloseKickPlayerDialogDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddCloseKickPlayerDialogDelegate_Parameters : BaseObject {
        public AddCloseKickPlayerDialogDelegate_Parameters() { }
        public AddCloseKickPlayerDialogDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AddCloseKickPlayerDialogDelegate.InDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddCloseKickPlayerDialogDelegate;
    public void AddCloseKickPlayerDialogDelegate(FScriptDelegate InDelegate) {
        _ptrAddCloseKickPlayerDialogDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddCloseKickPlayerDialogDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddCloseKickPlayerDialogDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnCloseKickPlayerDialog
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnCloseKickPlayerDialog_Parameters : BaseObject {
        public OnCloseKickPlayerDialog_Parameters() { }
        public OnCloseKickPlayerDialog_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrOnCloseKickPlayerDialog;
    public void OnCloseKickPlayerDialog() {
        _ptrOnCloseKickPlayerDialog ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnCloseKickPlayerDialog");

        ProcessEvent(_ptrOnCloseKickPlayerDialog, null);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnPlayerTalkingStateChange
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnPlayerTalkingStateChange_Parameters : BaseObject {
        public OnPlayerTalkingStateChange_Parameters() { }
        public OnPlayerTalkingStateChange_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OnPlayerTalkingStateChange.Player
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId Player {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OnPlayerTalkingStateChange.bIsTalking
        // 0x48 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bIsTalking {
            get => (*(uint*)(Pointer + 72) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 72) |= 0x1;
                else *(uint*)(Pointer + 72) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnPlayerTalkingStateChange;
    public void OnPlayerTalkingStateChange(U_Types_Core.FUniqueNetId Player, bool bIsTalking) {
        _ptrOnPlayerTalkingStateChange ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnPlayerTalkingStateChange");

        var @params = stackalloc byte[76];
        System.Buffer.MemoryCopy((void*)Player.Pointer, @params, 72, 72);
        System.Buffer.MemoryCopy(&bIsTalking, @params + 72, 4, 4);

        ProcessEvent(_ptrOnPlayerTalkingStateChange, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.SetVoiceReceiveVolume
    // 0x3750E0
    // (Final | Public)
    public unsafe class SetVoiceReceiveVolume_Parameters : BaseObject {
        public SetVoiceReceiveVolume_Parameters() { }
        public SetVoiceReceiveVolume_Parameters(nint pointer) : base(pointer) { }

        // FloatProperty OnlineSubsystemEOS.OnlineSubsystemEOS.SetVoiceReceiveVolume.VoiceVolume
        // 0x0 (0x4)
        // (Param)
        public float VoiceVolume {
            get => *(float*)Pointer;
            set => *(float*)Pointer = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.SetVoiceReceiveVolume.ReturnValue
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
    private static UFunction _ptrSetVoiceReceiveVolume;
    public bool SetVoiceReceiveVolume(float VoiceVolume) {
        _ptrSetVoiceReceiveVolume ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.SetVoiceReceiveVolume");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&VoiceVolume, @params, 4, 4);

        ProcessEvent(_ptrSetVoiceReceiveVolume, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetDLCPurchaseTime
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class GetDLCPurchaseTime_Parameters : BaseObject {
        public GetDLCPurchaseTime_Parameters() { }
        public GetDLCPurchaseTime_Parameters(nint pointer) : base(pointer) { }

        // NameProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetDLCPurchaseTime.AppName
        // 0x0 (0x8)
        // (Param)
        public FName AppName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // IntProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetDLCPurchaseTime.ReturnValue
        // 0x8 (0x4)
        // (Param | OutParam | ReturnParam)
        public int ReturnValue {
            get => *(int*)(Pointer + 8);
            set => *(int*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrGetDLCPurchaseTime;
    public int GetDLCPurchaseTime(FName AppName) {
        _ptrGetDLCPurchaseTime ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetDLCPurchaseTime");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)AppName.Pointer, @params, 8, 8);

        ProcessEvent(_ptrGetDLCPurchaseTime, @params);

        return *(int*)(@params + 8);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.SaveKey
    // 0x3750E0
    // (Final | Public)
    public unsafe class SaveKey_Parameters : BaseObject {
        public SaveKey_Parameters() { }
        public SaveKey_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.SaveKey.ProductKey
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString ProductKey {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.SaveKey.ReturnValue
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
    private static UFunction _ptrSaveKey;
    public bool SaveKey(FString ProductKey) {
        _ptrSaveKey ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.SaveKey");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)ProductKey.Pointer, @params, 16, 16);

        ProcessEvent(_ptrSaveKey, @params);

        return *(bool*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetLocalAccountNames
    // 0x3750E0
    // (Final | Public | HasOutParams)
    public unsafe class GetLocalAccountNames_Parameters : BaseObject {
        public GetLocalAccountNames_Parameters() { }
        public GetLocalAccountNames_Parameters(nint pointer) : base(pointer) { }

        // ArrayProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetLocalAccountNames.Accounts
        // 0x0 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public StructTArray<FString> Accounts {
            get => new(Pointer, 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetLocalAccountNames.ReturnValue
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
    private static UFunction _ptrGetLocalAccountNames;
    public bool GetLocalAccountNames(ref StructTArray<FString> Accounts) {
        _ptrGetLocalAccountNames ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetLocalAccountNames");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)Accounts.Pointer, @params, 16, 16);

        ProcessEvent(_ptrGetLocalAccountNames, @params);

        var _AccountsPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_AccountsPtr, 16, 16);
        Accounts = new(_AccountsPtr, 16) { Allocated = true };

        return *(bool*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.DeleteLocalAccount
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class DeleteLocalAccount_Parameters : BaseObject {
        public DeleteLocalAccount_Parameters() { }
        public DeleteLocalAccount_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.DeleteLocalAccount.Username
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Username {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.DeleteLocalAccount.Password
        // 0x10 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Password {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.DeleteLocalAccount.ReturnValue
        // 0x20 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 32) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 32) |= 0x1;
                else *(uint*)(Pointer + 32) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrDeleteLocalAccount;
    public bool DeleteLocalAccount(FString Username, FString Password = null) {
        _ptrDeleteLocalAccount ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.DeleteLocalAccount");

        var @params = stackalloc byte[36];
        System.Buffer.MemoryCopy((void*)Username.Pointer, @params, 16, 16);
        if (Password != null) System.Buffer.MemoryCopy((void*)Password.Pointer, @params + 16, 16, 16);

        ProcessEvent(_ptrDeleteLocalAccount, @params);

        return *(bool*)(@params + 32);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.RenameLocalAccount
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class RenameLocalAccount_Parameters : BaseObject {
        public RenameLocalAccount_Parameters() { }
        public RenameLocalAccount_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.RenameLocalAccount.NewUserName
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString NewUserName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.RenameLocalAccount.OldUserName
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString OldUserName {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.RenameLocalAccount.Password
        // 0x20 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Password {
            get => new(Pointer + 32);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 32), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.RenameLocalAccount.ReturnValue
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
    private static UFunction _ptrRenameLocalAccount;
    public bool RenameLocalAccount(FString NewUserName, FString OldUserName, FString Password = null) {
        _ptrRenameLocalAccount ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.RenameLocalAccount");

        var @params = stackalloc byte[52];
        System.Buffer.MemoryCopy((void*)NewUserName.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)OldUserName.Pointer, @params + 16, 16, 16);
        if (Password != null) System.Buffer.MemoryCopy((void*)Password.Pointer, @params + 32, 16, 16);

        ProcessEvent(_ptrRenameLocalAccount, @params);

        return *(bool*)(@params + 48);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.CreateLocalAccount
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class CreateLocalAccount_Parameters : BaseObject {
        public CreateLocalAccount_Parameters() { }
        public CreateLocalAccount_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.CreateLocalAccount.Username
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Username {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.CreateLocalAccount.Password
        // 0x10 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Password {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.CreateLocalAccount.ReturnValue
        // 0x20 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 32) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 32) |= 0x1;
                else *(uint*)(Pointer + 32) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrCreateLocalAccount;
    public bool CreateLocalAccount(FString Username, FString Password = null) {
        _ptrCreateLocalAccount ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.CreateLocalAccount");

        var @params = stackalloc byte[36];
        System.Buffer.MemoryCopy((void*)Username.Pointer, @params, 16, 16);
        if (Password != null) System.Buffer.MemoryCopy((void*)Password.Pointer, @params + 16, 16, 16);

        ProcessEvent(_ptrCreateLocalAccount, @params);

        return *(bool*)(@params + 32);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearCreateOnlineAccountCompletedDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearCreateOnlineAccountCompletedDelegate_Parameters : BaseObject {
        public ClearCreateOnlineAccountCompletedDelegate_Parameters() { }
        public ClearCreateOnlineAccountCompletedDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ClearCreateOnlineAccountCompletedDelegate.AccountCreateDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate AccountCreateDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearCreateOnlineAccountCompletedDelegate;
    public void ClearCreateOnlineAccountCompletedDelegate(FScriptDelegate AccountCreateDelegate) {
        _ptrClearCreateOnlineAccountCompletedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearCreateOnlineAccountCompletedDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)AccountCreateDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearCreateOnlineAccountCompletedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddCreateOnlineAccountCompletedDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddCreateOnlineAccountCompletedDelegate_Parameters : BaseObject {
        public AddCreateOnlineAccountCompletedDelegate_Parameters() { }
        public AddCreateOnlineAccountCompletedDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AddCreateOnlineAccountCompletedDelegate.AccountCreateDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate AccountCreateDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddCreateOnlineAccountCompletedDelegate;
    public void AddCreateOnlineAccountCompletedDelegate(FScriptDelegate AccountCreateDelegate) {
        _ptrAddCreateOnlineAccountCompletedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddCreateOnlineAccountCompletedDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)AccountCreateDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddCreateOnlineAccountCompletedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnCreateOnlineAccountCompleted
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnCreateOnlineAccountCompleted_Parameters : BaseObject {
        public OnCreateOnlineAccountCompleted_Parameters() { }
        public OnCreateOnlineAccountCompleted_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OnCreateOnlineAccountCompleted.ErrorStatus
        // 0x0 (0x1)
        // (Param)
        public UOnlineSubsystem.EOnlineAccountCreateStatus ErrorStatus {
            get => *(UOnlineSubsystem.EOnlineAccountCreateStatus*)Pointer;
            set => *(UOnlineSubsystem.EOnlineAccountCreateStatus*)Pointer = value;
        }
    }
    private static UFunction _ptrOnCreateOnlineAccountCompleted;
    public void OnCreateOnlineAccountCompleted(UOnlineSubsystem.EOnlineAccountCreateStatus ErrorStatus) {
        _ptrOnCreateOnlineAccountCompleted ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnCreateOnlineAccountCompleted");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&ErrorStatus, @params, 1, 1);

        ProcessEvent(_ptrOnCreateOnlineAccountCompleted, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.CreateOnlineAccount
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class CreateOnlineAccount_Parameters : BaseObject {
        public CreateOnlineAccount_Parameters() { }
        public CreateOnlineAccount_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.CreateOnlineAccount.Username
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Username {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.CreateOnlineAccount.Password
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString Password {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.CreateOnlineAccount.EmailAddress
        // 0x20 (0x10)
        // (Param | NeedCtorLink)
        public FString EmailAddress {
            get => new(Pointer + 32);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 32), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.CreateOnlineAccount.ProductKey
        // 0x30 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString ProductKey {
            get => new(Pointer + 48);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 48), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.CreateOnlineAccount.ReturnValue
        // 0x40 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 64) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 64) |= 0x1;
                else *(uint*)(Pointer + 64) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrCreateOnlineAccount;
    public bool CreateOnlineAccount(FString Username, FString Password, FString EmailAddress, FString ProductKey = null) {
        _ptrCreateOnlineAccount ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.CreateOnlineAccount");

        var @params = stackalloc byte[68];
        System.Buffer.MemoryCopy((void*)Username.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)Password.Pointer, @params + 16, 16, 16);
        System.Buffer.MemoryCopy((void*)EmailAddress.Pointer, @params + 32, 16, 16);
        if (ProductKey != null) System.Buffer.MemoryCopy((void*)ProductKey.Pointer, @params + 48, 16, 16);

        ProcessEvent(_ptrCreateOnlineAccount, @params);

        return *(bool*)(@params + 64);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.IsKeyValid
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class IsKeyValid_Parameters : BaseObject {
        public IsKeyValid_Parameters() { }
        public IsKeyValid_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.IsKeyValid.ReturnValue
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
    private static UFunction _ptrIsKeyValid;
    public bool IsKeyValid() {
        _ptrIsKeyValid ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.IsKeyValid");

        var @params = stackalloc byte[4];

        ProcessEvent(_ptrIsKeyValid, @params);

        return *(bool*)@params;
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearStorageDeviceChangeDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearStorageDeviceChangeDelegate_Parameters : BaseObject {
        public ClearStorageDeviceChangeDelegate_Parameters() { }
        public ClearStorageDeviceChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ClearStorageDeviceChangeDelegate.StorageDeviceChangeDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate StorageDeviceChangeDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearStorageDeviceChangeDelegate;
    public void ClearStorageDeviceChangeDelegate(FScriptDelegate StorageDeviceChangeDelegate) {
        _ptrClearStorageDeviceChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearStorageDeviceChangeDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)StorageDeviceChangeDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearStorageDeviceChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddStorageDeviceChangeDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddStorageDeviceChangeDelegate_Parameters : BaseObject {
        public AddStorageDeviceChangeDelegate_Parameters() { }
        public AddStorageDeviceChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AddStorageDeviceChangeDelegate.StorageDeviceChangeDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate StorageDeviceChangeDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddStorageDeviceChangeDelegate;
    public void AddStorageDeviceChangeDelegate(FScriptDelegate StorageDeviceChangeDelegate) {
        _ptrAddStorageDeviceChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddStorageDeviceChangeDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)StorageDeviceChangeDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddStorageDeviceChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnStorageDeviceChange
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnStorageDeviceChange_Parameters : BaseObject {
        public OnStorageDeviceChange_Parameters() { }
        public OnStorageDeviceChange_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrOnStorageDeviceChange;
    public void OnStorageDeviceChange() {
        _ptrOnStorageDeviceChange ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnStorageDeviceChange");

        ProcessEvent(_ptrOnStorageDeviceChange, null);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetNATType
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class GetNATType_Parameters : BaseObject {
        public GetNATType_Parameters() { }
        public GetNATType_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetNATType.ReturnValue
        // 0x0 (0x1)
        // (Param | OutParam | ReturnParam)
        public UOnlineSubsystem.ENATType ReturnValue {
            get => *(UOnlineSubsystem.ENATType*)Pointer;
            set => *(UOnlineSubsystem.ENATType*)Pointer = value;
        }
    }
    private static UFunction _ptrGetNATType;
    public UOnlineSubsystem.ENATType GetNATType() {
        _ptrGetNATType ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetNATType");

        var @params = stackalloc byte[1];

        ProcessEvent(_ptrGetNATType, @params);

        return *(UOnlineSubsystem.ENATType*)@params;
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearConnectionStatusChangeDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearConnectionStatusChangeDelegate_Parameters : BaseObject {
        public ClearConnectionStatusChangeDelegate_Parameters() { }
        public ClearConnectionStatusChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ClearConnectionStatusChangeDelegate.ConnectionStatusDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ConnectionStatusDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearConnectionStatusChangeDelegate;
    public void ClearConnectionStatusChangeDelegate(FScriptDelegate ConnectionStatusDelegate) {
        _ptrClearConnectionStatusChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearConnectionStatusChangeDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)ConnectionStatusDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearConnectionStatusChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddConnectionStatusChangeDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddConnectionStatusChangeDelegate_Parameters : BaseObject {
        public AddConnectionStatusChangeDelegate_Parameters() { }
        public AddConnectionStatusChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AddConnectionStatusChangeDelegate.ConnectionStatusDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ConnectionStatusDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddConnectionStatusChangeDelegate;
    public void AddConnectionStatusChangeDelegate(FScriptDelegate ConnectionStatusDelegate) {
        _ptrAddConnectionStatusChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddConnectionStatusChangeDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)ConnectionStatusDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddConnectionStatusChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnConnectionStatusChange
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnConnectionStatusChange_Parameters : BaseObject {
        public OnConnectionStatusChange_Parameters() { }
        public OnConnectionStatusChange_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OnConnectionStatusChange.ConnectionStatus
        // 0x0 (0x1)
        // (Param)
        public UOnlineSubsystem.EOnlineServerConnectionStatus ConnectionStatus {
            get => *(UOnlineSubsystem.EOnlineServerConnectionStatus*)Pointer;
            set => *(UOnlineSubsystem.EOnlineServerConnectionStatus*)Pointer = value;
        }
    }
    private static UFunction _ptrOnConnectionStatusChange;
    public void OnConnectionStatusChange(UOnlineSubsystem.EOnlineServerConnectionStatus ConnectionStatus) {
        _ptrOnConnectionStatusChange ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnConnectionStatusChange");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&ConnectionStatus, @params, 1, 1);

        ProcessEvent(_ptrOnConnectionStatusChange, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.IsControllerConnected
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class IsControllerConnected_Parameters : BaseObject {
        public IsControllerConnected_Parameters() { }
        public IsControllerConnected_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlineSubsystemEOS.IsControllerConnected.ControllerId
        // 0x0 (0x4)
        // (Param)
        public int ControllerId {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.IsControllerConnected.ReturnValue
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
    private static UFunction _ptrIsControllerConnected;
    public bool IsControllerConnected(int ControllerId) {
        _ptrIsControllerConnected ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.IsControllerConnected");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&ControllerId, @params, 4, 4);

        ProcessEvent(_ptrIsControllerConnected, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearControllerChangeDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearControllerChangeDelegate_Parameters : BaseObject {
        public ClearControllerChangeDelegate_Parameters() { }
        public ClearControllerChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ClearControllerChangeDelegate.ControllerChangeDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ControllerChangeDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearControllerChangeDelegate;
    public void ClearControllerChangeDelegate(FScriptDelegate ControllerChangeDelegate) {
        _ptrClearControllerChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearControllerChangeDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)ControllerChangeDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearControllerChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddControllerChangeDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddControllerChangeDelegate_Parameters : BaseObject {
        public AddControllerChangeDelegate_Parameters() { }
        public AddControllerChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AddControllerChangeDelegate.ControllerChangeDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ControllerChangeDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddControllerChangeDelegate;
    public void AddControllerChangeDelegate(FScriptDelegate ControllerChangeDelegate) {
        _ptrAddControllerChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddControllerChangeDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)ControllerChangeDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddControllerChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnControllerChange
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnControllerChange_Parameters : BaseObject {
        public OnControllerChange_Parameters() { }
        public OnControllerChange_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OnControllerChange.ControllerId
        // 0x0 (0x4)
        // (Param)
        public int ControllerId {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OnControllerChange.bIsConnected
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bIsConnected {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnControllerChange;
    public void OnControllerChange(int ControllerId, bool bIsConnected) {
        _ptrOnControllerChange ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnControllerChange");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&ControllerId, @params, 4, 4);
        System.Buffer.MemoryCopy(&bIsConnected, @params + 4, 4, 4);

        ProcessEvent(_ptrOnControllerChange, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.SetNetworkNotificationPosition
    // 0x3750E0
    // (Final | Public)
    public unsafe class SetNetworkNotificationPosition_Parameters : BaseObject {
        public SetNetworkNotificationPosition_Parameters() { }
        public SetNetworkNotificationPosition_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.SetNetworkNotificationPosition.NewPos
        // 0x0 (0x1)
        // (Param)
        public UOnlineSubsystem.ENetworkNotificationPosition NewPos {
            get => *(UOnlineSubsystem.ENetworkNotificationPosition*)Pointer;
            set => *(UOnlineSubsystem.ENetworkNotificationPosition*)Pointer = value;
        }
    }
    private static UFunction _ptrSetNetworkNotificationPosition;
    public void SetNetworkNotificationPosition(UOnlineSubsystem.ENetworkNotificationPosition NewPos) {
        _ptrSetNetworkNotificationPosition ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.SetNetworkNotificationPosition");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&NewPos, @params, 1, 1);

        ProcessEvent(_ptrSetNetworkNotificationPosition, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetNetworkNotificationPosition
    // 0x3750E0
    // (Final | Public)
    public unsafe class GetNetworkNotificationPosition_Parameters : BaseObject {
        public GetNetworkNotificationPosition_Parameters() { }
        public GetNetworkNotificationPosition_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetNetworkNotificationPosition.ReturnValue
        // 0x0 (0x1)
        // (Param | OutParam | ReturnParam)
        public UOnlineSubsystem.ENetworkNotificationPosition ReturnValue {
            get => *(UOnlineSubsystem.ENetworkNotificationPosition*)Pointer;
            set => *(UOnlineSubsystem.ENetworkNotificationPosition*)Pointer = value;
        }
    }
    private static UFunction _ptrGetNetworkNotificationPosition;
    public UOnlineSubsystem.ENetworkNotificationPosition GetNetworkNotificationPosition() {
        _ptrGetNetworkNotificationPosition ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetNetworkNotificationPosition");

        var @params = stackalloc byte[1];

        ProcessEvent(_ptrGetNetworkNotificationPosition, @params);

        return *(UOnlineSubsystem.ENetworkNotificationPosition*)@params;
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.NotifyExternalUIChanged
    // 0xCDDD10
    // (Final | Native | Public)
    public unsafe class NotifyExternalUIChanged_Parameters : BaseObject {
        public NotifyExternalUIChanged_Parameters() { }
        public NotifyExternalUIChanged_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.NotifyExternalUIChanged.bIsOpening
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bIsOpening {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrNotifyExternalUIChanged;
    public void NotifyExternalUIChanged(bool bIsOpening) {
        _ptrNotifyExternalUIChanged ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.NotifyExternalUIChanged");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bIsOpening, @params, 4, 4);

        _ptrNotifyExternalUIChanged.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrNotifyExternalUIChanged, @params);
        _ptrNotifyExternalUIChanged.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearExternalUIChangeDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearExternalUIChangeDelegate_Parameters : BaseObject {
        public ClearExternalUIChangeDelegate_Parameters() { }
        public ClearExternalUIChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ClearExternalUIChangeDelegate.InDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearExternalUIChangeDelegate;
    public void ClearExternalUIChangeDelegate(FScriptDelegate InDelegate) {
        _ptrClearExternalUIChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearExternalUIChangeDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearExternalUIChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddExternalUIChangeDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddExternalUIChangeDelegate_Parameters : BaseObject {
        public AddExternalUIChangeDelegate_Parameters() { }
        public AddExternalUIChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AddExternalUIChangeDelegate.InDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddExternalUIChangeDelegate;
    public void AddExternalUIChangeDelegate(FScriptDelegate InDelegate) {
        _ptrAddExternalUIChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddExternalUIChangeDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddExternalUIChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnExternalUIChange
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnExternalUIChange_Parameters : BaseObject {
        public OnExternalUIChange_Parameters() { }
        public OnExternalUIChange_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OnExternalUIChange.bIsOpening
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bIsOpening {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnExternalUIChange;
    public void OnExternalUIChange(bool bIsOpening) {
        _ptrOnExternalUIChange ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnExternalUIChange");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bIsOpening, @params, 4, 4);

        ProcessEvent(_ptrOnExternalUIChange, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearLinkStatusChangeDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearLinkStatusChangeDelegate_Parameters : BaseObject {
        public ClearLinkStatusChangeDelegate_Parameters() { }
        public ClearLinkStatusChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ClearLinkStatusChangeDelegate.LinkStatusDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate LinkStatusDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearLinkStatusChangeDelegate;
    public void ClearLinkStatusChangeDelegate(FScriptDelegate LinkStatusDelegate) {
        _ptrClearLinkStatusChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearLinkStatusChangeDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)LinkStatusDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearLinkStatusChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddLinkStatusChangeDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddLinkStatusChangeDelegate_Parameters : BaseObject {
        public AddLinkStatusChangeDelegate_Parameters() { }
        public AddLinkStatusChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AddLinkStatusChangeDelegate.LinkStatusDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate LinkStatusDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddLinkStatusChangeDelegate;
    public void AddLinkStatusChangeDelegate(FScriptDelegate LinkStatusDelegate) {
        _ptrAddLinkStatusChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddLinkStatusChangeDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)LinkStatusDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddLinkStatusChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnLinkStatusChange
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnLinkStatusChange_Parameters : BaseObject {
        public OnLinkStatusChange_Parameters() { }
        public OnLinkStatusChange_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OnLinkStatusChange.bIsConnected
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bIsConnected {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnLinkStatusChange;
    public void OnLinkStatusChange(bool bIsConnected) {
        _ptrOnLinkStatusChange ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnLinkStatusChange");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bIsConnected, @params, 4, 4);

        ProcessEvent(_ptrOnLinkStatusChange, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.HasLinkConnection
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class HasLinkConnection_Parameters : BaseObject {
        public HasLinkConnection_Parameters() { }
        public HasLinkConnection_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.HasLinkConnection.ReturnValue
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
    private static UFunction _ptrHasLinkConnection;
    public bool HasLinkConnection() {
        _ptrHasLinkConnection ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.HasLinkConnection");

        var @params = stackalloc byte[4];

        ProcessEvent(_ptrHasLinkConnection, @params);

        return *(bool*)@params;
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.RegisterStatGuid
    // 0x3750E0
    // (Final | Public | HasOutParams)
    public unsafe class RegisterStatGuid_Parameters : BaseObject {
        public RegisterStatGuid_Parameters() { }
        public RegisterStatGuid_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.RegisterStatGuid.PlayerID
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.RegisterStatGuid.ClientStatGuid
        // 0x48 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString ClientStatGuid {
            get => new(Pointer + 72);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 72), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.RegisterStatGuid.ReturnValue
        // 0x58 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 88) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 88) |= 0x1;
                else *(uint*)(Pointer + 88) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrRegisterStatGuid;
    public bool RegisterStatGuid(U_Types_Core.FUniqueNetId PlayerID, ref FString ClientStatGuid) {
        _ptrRegisterStatGuid ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.RegisterStatGuid");

        var @params = stackalloc byte[92];
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params, 72, 72);
        System.Buffer.MemoryCopy((void*)ClientStatGuid.Pointer, @params + 72, 16, 16);

        ProcessEvent(_ptrRegisterStatGuid, @params);

        var _ClientStatGuidPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 72, (void*)_ClientStatGuidPtr, 16, 16);
        ClientStatGuid = new(_ClientStatGuidPtr) { Allocated = true };

        return *(bool*)(@params + 88);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetClientStatGuid
    // 0x3750E0
    // (Final | Public)
    public unsafe class GetClientStatGuid_Parameters : BaseObject {
        public GetClientStatGuid_Parameters() { }
        public GetClientStatGuid_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetClientStatGuid.ReturnValue
        // 0x0 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetClientStatGuid;
    public FString GetClientStatGuid() {
        _ptrGetClientStatGuid ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetClientStatGuid");

        var @params = stackalloc byte[16];

        ProcessEvent(_ptrGetClientStatGuid, @params);

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearRegisterHostStatGuidCompleteDelegateDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearRegisterHostStatGuidCompleteDelegateDelegate_Parameters : BaseObject {
        public ClearRegisterHostStatGuidCompleteDelegateDelegate_Parameters() { }
        public ClearRegisterHostStatGuidCompleteDelegateDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ClearRegisterHostStatGuidCompleteDelegateDelegate.RegisterHostStatGuidCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate RegisterHostStatGuidCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearRegisterHostStatGuidCompleteDelegateDelegate;
    public void ClearRegisterHostStatGuidCompleteDelegateDelegate(FScriptDelegate RegisterHostStatGuidCompleteDelegate) {
        _ptrClearRegisterHostStatGuidCompleteDelegateDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearRegisterHostStatGuidCompleteDelegateDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)RegisterHostStatGuidCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearRegisterHostStatGuidCompleteDelegateDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddRegisterHostStatGuidCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddRegisterHostStatGuidCompleteDelegate_Parameters : BaseObject {
        public AddRegisterHostStatGuidCompleteDelegate_Parameters() { }
        public AddRegisterHostStatGuidCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AddRegisterHostStatGuidCompleteDelegate.RegisterHostStatGuidCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate RegisterHostStatGuidCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddRegisterHostStatGuidCompleteDelegate;
    public void AddRegisterHostStatGuidCompleteDelegate(FScriptDelegate RegisterHostStatGuidCompleteDelegate) {
        _ptrAddRegisterHostStatGuidCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddRegisterHostStatGuidCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)RegisterHostStatGuidCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddRegisterHostStatGuidCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnFlushOnlineStatsComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnFlushOnlineStatsComplete_Parameters : BaseObject {
        public OnFlushOnlineStatsComplete_Parameters() { }
        public OnFlushOnlineStatsComplete_Parameters(nint pointer) : base(pointer) { }

        // NameProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OnFlushOnlineStatsComplete.SessionName
        // 0x0 (0x8)
        // (Param)
        public FName SessionName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OnFlushOnlineStatsComplete.bWasSuccessful
        // 0x8 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)(Pointer + 8) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 8) |= 0x1;
                else *(uint*)(Pointer + 8) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnFlushOnlineStatsComplete;
    public void OnFlushOnlineStatsComplete(FName SessionName, bool bWasSuccessful) {
        _ptrOnFlushOnlineStatsComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnFlushOnlineStatsComplete");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)SessionName.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&bWasSuccessful, @params + 8, 4, 4);

        ProcessEvent(_ptrOnFlushOnlineStatsComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnRegisterHostStatGuidComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnRegisterHostStatGuidComplete_Parameters : BaseObject {
        public OnRegisterHostStatGuidComplete_Parameters() { }
        public OnRegisterHostStatGuidComplete_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OnRegisterHostStatGuidComplete.bWasSuccessful
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnRegisterHostStatGuidComplete;
    public void OnRegisterHostStatGuidComplete(bool bWasSuccessful) {
        _ptrOnRegisterHostStatGuidComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnRegisterHostStatGuidComplete");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bWasSuccessful, @params, 4, 4);

        ProcessEvent(_ptrOnRegisterHostStatGuidComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.RegisterHostStatGuid
    // 0x3750E0
    // (Final | Public | HasOutParams)
    public unsafe class RegisterHostStatGuid_Parameters : BaseObject {
        public RegisterHostStatGuid_Parameters() { }
        public RegisterHostStatGuid_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.RegisterHostStatGuid.HostStatGuid
        // 0x0 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString HostStatGuid {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.RegisterHostStatGuid.ReturnValue
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
    private static UFunction _ptrRegisterHostStatGuid;
    public bool RegisterHostStatGuid(ref FString HostStatGuid) {
        _ptrRegisterHostStatGuid ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.RegisterHostStatGuid");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)HostStatGuid.Pointer, @params, 16, 16);

        ProcessEvent(_ptrRegisterHostStatGuid, @params);

        var _HostStatGuidPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_HostStatGuidPtr, 16, 16);
        HostStatGuid = new(_HostStatGuidPtr) { Allocated = true };

        return *(bool*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetHostStatGuid
    // 0x3750E0
    // (Final | Public)
    public unsafe class GetHostStatGuid_Parameters : BaseObject {
        public GetHostStatGuid_Parameters() { }
        public GetHostStatGuid_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetHostStatGuid.ReturnValue
        // 0x0 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetHostStatGuid;
    public FString GetHostStatGuid() {
        _ptrGetHostStatGuid ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetHostStatGuid");

        var @params = stackalloc byte[16];

        ProcessEvent(_ptrGetHostStatGuid, @params);

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.WriteOnlinePlayerScores
    // 0x3750E0
    // (Final | Public | HasOutParams)
    public unsafe class WriteOnlinePlayerScores_Parameters : BaseObject {
        public WriteOnlinePlayerScores_Parameters() { }
        public WriteOnlinePlayerScores_Parameters(nint pointer) : base(pointer) { }

        // ArrayProperty OnlineSubsystemEOS.OnlineSubsystemEOS.WriteOnlinePlayerScores.PlayerScores
        // 0x0 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public StructTArray<UOnlineSubsystem.FOnlinePlayerScore> PlayerScores {
            get => new(Pointer, 80);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.WriteOnlinePlayerScores.ReturnValue
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
    private static UFunction _ptrWriteOnlinePlayerScores;
    public bool WriteOnlinePlayerScores(ref StructTArray<UOnlineSubsystem.FOnlinePlayerScore> PlayerScores) {
        _ptrWriteOnlinePlayerScores ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.WriteOnlinePlayerScores");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)PlayerScores.Pointer, @params, 16, 16);

        ProcessEvent(_ptrWriteOnlinePlayerScores, @params);

        var _PlayerScoresPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_PlayerScoresPtr, 16, 16);
        PlayerScores = new(_PlayerScoresPtr, 80) { Allocated = true };

        return *(bool*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.FreeStats
    // 0x3750E0
    // (Final | Public)
    public unsafe class FreeStats_Parameters : BaseObject {
        public FreeStats_Parameters() { }
        public FreeStats_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty OnlineSubsystemEOS.OnlineSubsystemEOS.FreeStats.StatsRead
        // 0x0 (0x8)
        // (Param)
        public UOnlineStatsRead StatsRead {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrFreeStats;
    public void FreeStats(UOnlineStatsRead StatsRead) {
        _ptrFreeStats ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.FreeStats");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy((void*)StatsRead.Pointer, @params, 8, 8);

        ProcessEvent(_ptrFreeStats, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearReadOnlineStatsCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearReadOnlineStatsCompleteDelegate_Parameters : BaseObject {
        public ClearReadOnlineStatsCompleteDelegate_Parameters() { }
        public ClearReadOnlineStatsCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ClearReadOnlineStatsCompleteDelegate.ReadOnlineStatsCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ReadOnlineStatsCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearReadOnlineStatsCompleteDelegate;
    public void ClearReadOnlineStatsCompleteDelegate(FScriptDelegate ReadOnlineStatsCompleteDelegate) {
        _ptrClearReadOnlineStatsCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearReadOnlineStatsCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)ReadOnlineStatsCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearReadOnlineStatsCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddReadOnlineStatsCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddReadOnlineStatsCompleteDelegate_Parameters : BaseObject {
        public AddReadOnlineStatsCompleteDelegate_Parameters() { }
        public AddReadOnlineStatsCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AddReadOnlineStatsCompleteDelegate.ReadOnlineStatsCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ReadOnlineStatsCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddReadOnlineStatsCompleteDelegate;
    public void AddReadOnlineStatsCompleteDelegate(FScriptDelegate ReadOnlineStatsCompleteDelegate) {
        _ptrAddReadOnlineStatsCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddReadOnlineStatsCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)ReadOnlineStatsCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddReadOnlineStatsCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnReadOnlineStatsComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnReadOnlineStatsComplete_Parameters : BaseObject {
        public OnReadOnlineStatsComplete_Parameters() { }
        public OnReadOnlineStatsComplete_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OnReadOnlineStatsComplete.bWasSuccessful
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnReadOnlineStatsComplete;
    public void OnReadOnlineStatsComplete(bool bWasSuccessful) {
        _ptrOnReadOnlineStatsComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnReadOnlineStatsComplete");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bWasSuccessful, @params, 4, 4);

        ProcessEvent(_ptrOnReadOnlineStatsComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStatsByRankAroundPlayer
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class ReadOnlineStatsByRankAroundPlayer_Parameters : BaseObject {
        public ReadOnlineStatsByRankAroundPlayer_Parameters() { }
        public ReadOnlineStatsByRankAroundPlayer_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStatsByRankAroundPlayer.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ObjectProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStatsByRankAroundPlayer.StatsRead
        // 0x8 (0x8)
        // (Param)
        public UOnlineStatsRead StatsRead {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // IntProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStatsByRankAroundPlayer.NumRows
        // 0x10 (0x4)
        // (OptionalParam | Param)
        public int NumRows {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStatsByRankAroundPlayer.ReturnValue
        // 0x14 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 20) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 20) |= 0x1;
                else *(uint*)(Pointer + 20) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrReadOnlineStatsByRankAroundPlayer;
    public bool ReadOnlineStatsByRankAroundPlayer(byte LocalUserNum, UOnlineStatsRead StatsRead, int NumRows = 0) {
        _ptrReadOnlineStatsByRankAroundPlayer ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStatsByRankAroundPlayer");

        var @params = stackalloc byte[17];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)StatsRead.Pointer, @params + 8, 8, 8);
        System.Buffer.MemoryCopy(&NumRows, @params + 16, 4, 4);

        ProcessEvent(_ptrReadOnlineStatsByRankAroundPlayer, @params);

        return *(bool*)(@params + 20);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStatsByRank
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class ReadOnlineStatsByRank_Parameters : BaseObject {
        public ReadOnlineStatsByRank_Parameters() { }
        public ReadOnlineStatsByRank_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStatsByRank.StatsRead
        // 0x0 (0x8)
        // (Param)
        public UOnlineStatsRead StatsRead {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // IntProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStatsByRank.StartIndex
        // 0x8 (0x4)
        // (OptionalParam | Param)
        public int StartIndex {
            get => *(int*)(Pointer + 8);
            set => *(int*)(Pointer + 8) = value;
        }

        // IntProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStatsByRank.NumToRead
        // 0xC (0x4)
        // (OptionalParam | Param)
        public int NumToRead {
            get => *(int*)(Pointer + 12);
            set => *(int*)(Pointer + 12) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStatsByRank.ReturnValue
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
    private static UFunction _ptrReadOnlineStatsByRank;
    public bool ReadOnlineStatsByRank(UOnlineStatsRead StatsRead, int StartIndex = 0, int NumToRead = 0) {
        _ptrReadOnlineStatsByRank ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStatsByRank");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)StatsRead.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&StartIndex, @params + 8, 4, 4);
        System.Buffer.MemoryCopy(&NumToRead, @params + 12, 4, 4);

        ProcessEvent(_ptrReadOnlineStatsByRank, @params);

        return *(bool*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStatsForFriends
    // 0x3750E0
    // (Final | Public)
    public unsafe class ReadOnlineStatsForFriends_Parameters : BaseObject {
        public ReadOnlineStatsForFriends_Parameters() { }
        public ReadOnlineStatsForFriends_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStatsForFriends.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ObjectProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStatsForFriends.StatsRead
        // 0x8 (0x8)
        // (Param)
        public UOnlineStatsRead StatsRead {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStatsForFriends.ReturnValue
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
    private static UFunction _ptrReadOnlineStatsForFriends;
    public bool ReadOnlineStatsForFriends(byte LocalUserNum, UOnlineStatsRead StatsRead) {
        _ptrReadOnlineStatsForFriends ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStatsForFriends");

        var @params = stackalloc byte[13];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)StatsRead.Pointer, @params + 8, 8, 8);

        ProcessEvent(_ptrReadOnlineStatsForFriends, @params);

        return *(bool*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStats
    // 0x3750E0
    // (Final | Public | HasOutParams)
    public unsafe class ReadOnlineStats_Parameters : BaseObject {
        public ReadOnlineStats_Parameters() { }
        public ReadOnlineStats_Parameters(nint pointer) : base(pointer) { }

        // ArrayProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStats.Players
        // 0x0 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public StructTArray<U_Types_Core.FUniqueNetId> Players {
            get => new(Pointer, 72);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ObjectProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStats.StatsRead
        // 0x10 (0x8)
        // (Param)
        public UOnlineStatsRead StatsRead {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStats.ReturnValue
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
    private static UFunction _ptrReadOnlineStats;
    public bool ReadOnlineStats(ref StructTArray<U_Types_Core.FUniqueNetId> Players, UOnlineStatsRead StatsRead) {
        _ptrReadOnlineStats ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ReadOnlineStats");

        var @params = stackalloc byte[28];
        System.Buffer.MemoryCopy((void*)Players.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)StatsRead.Pointer, @params + 16, 8, 8);

        ProcessEvent(_ptrReadOnlineStats, @params);

        var _PlayersPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_PlayersPtr, 16, 16);
        Players = new(_PlayersPtr, 72) { Allocated = true };

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.UnmuteAll
    // 0x3750E0
    // (Final | Public)
    public unsafe class UnmuteAll_Parameters : BaseObject {
        public UnmuteAll_Parameters() { }
        public UnmuteAll_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.UnmuteAll.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.UnmuteAll.ReturnValue
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
    private static UFunction _ptrUnmuteAll;
    public bool UnmuteAll(byte LocalUserNum) {
        _ptrUnmuteAll ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.UnmuteAll");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrUnmuteAll, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.MuteAll
    // 0x3750E0
    // (Final | Public)
    public unsafe class MuteAll_Parameters : BaseObject {
        public MuteAll_Parameters() { }
        public MuteAll_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.MuteAll.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.MuteAll.bAllowFriends
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bAllowFriends {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.MuteAll.ReturnValue
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
    private static UFunction _ptrMuteAll;
    public bool MuteAll(byte LocalUserNum, bool bAllowFriends) {
        _ptrMuteAll ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.MuteAll");

        var @params = stackalloc byte[9];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&bAllowFriends, @params + 4, 4, 4);

        ProcessEvent(_ptrMuteAll, @params);

        return *(bool*)(@params + 8);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.SetSpeechRecognitionObject
    // 0x3750E0
    // (Final | Public)
    public unsafe class SetSpeechRecognitionObject_Parameters : BaseObject {
        public SetSpeechRecognitionObject_Parameters() { }
        public SetSpeechRecognitionObject_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.SetSpeechRecognitionObject.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ObjectProperty OnlineSubsystemEOS.OnlineSubsystemEOS.SetSpeechRecognitionObject.SpeechRecogObj
        // 0x8 (0x8)
        // (Param)
        public USpeechRecognition SpeechRecogObj {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.SetSpeechRecognitionObject.ReturnValue
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
    private static UFunction _ptrSetSpeechRecognitionObject;
    public bool SetSpeechRecognitionObject(byte LocalUserNum, USpeechRecognition SpeechRecogObj) {
        _ptrSetSpeechRecognitionObject ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.SetSpeechRecognitionObject");

        var @params = stackalloc byte[13];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)SpeechRecogObj.Pointer, @params + 8, 8, 8);

        ProcessEvent(_ptrSetSpeechRecognitionObject, @params);

        return *(bool*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.SelectVocabulary
    // 0x3750E0
    // (Final | Public)
    public unsafe class SelectVocabulary_Parameters : BaseObject {
        public SelectVocabulary_Parameters() { }
        public SelectVocabulary_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.SelectVocabulary.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // IntProperty OnlineSubsystemEOS.OnlineSubsystemEOS.SelectVocabulary.VocabularyId
        // 0x4 (0x4)
        // (Param)
        public int VocabularyId {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.SelectVocabulary.ReturnValue
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
    private static UFunction _ptrSelectVocabulary;
    public bool SelectVocabulary(byte LocalUserNum, int VocabularyId) {
        _ptrSelectVocabulary ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.SelectVocabulary");

        var @params = stackalloc byte[9];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&VocabularyId, @params + 4, 4, 4);

        ProcessEvent(_ptrSelectVocabulary, @params);

        return *(bool*)(@params + 8);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearRecognitionCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearRecognitionCompleteDelegate_Parameters : BaseObject {
        public ClearRecognitionCompleteDelegate_Parameters() { }
        public ClearRecognitionCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ClearRecognitionCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ClearRecognitionCompleteDelegate.RecognitionDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate RecognitionDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearRecognitionCompleteDelegate;
    public void ClearRecognitionCompleteDelegate(byte LocalUserNum, FScriptDelegate RecognitionDelegate) {
        _ptrClearRecognitionCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearRecognitionCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)RecognitionDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearRecognitionCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddRecognitionCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddRecognitionCompleteDelegate_Parameters : BaseObject {
        public AddRecognitionCompleteDelegate_Parameters() { }
        public AddRecognitionCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AddRecognitionCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AddRecognitionCompleteDelegate.RecognitionDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate RecognitionDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddRecognitionCompleteDelegate;
    public void AddRecognitionCompleteDelegate(byte LocalUserNum, FScriptDelegate RecognitionDelegate) {
        _ptrAddRecognitionCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddRecognitionCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)RecognitionDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddRecognitionCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnRecognitionComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnRecognitionComplete_Parameters : BaseObject {
        public OnRecognitionComplete_Parameters() { }
        public OnRecognitionComplete_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrOnRecognitionComplete;
    public void OnRecognitionComplete() {
        _ptrOnRecognitionComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnRecognitionComplete");

        ProcessEvent(_ptrOnRecognitionComplete, null);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetRecognitionResults
    // 0x3750E0
    // (Final | Public | HasOutParams)
    public unsafe class GetRecognitionResults_Parameters : BaseObject {
        public GetRecognitionResults_Parameters() { }
        public GetRecognitionResults_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetRecognitionResults.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ArrayProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetRecognitionResults.Words
        // 0x8 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public StructTArray<UOnlineSubsystem.FSpeechRecognizedWord> Words {
            get => new(Pointer + 8, 32);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetRecognitionResults.ReturnValue
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
    private static UFunction _ptrGetRecognitionResults;
    public bool GetRecognitionResults(byte LocalUserNum, ref StructTArray<UOnlineSubsystem.FSpeechRecognizedWord> Words) {
        _ptrGetRecognitionResults ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetRecognitionResults");

        var @params = stackalloc byte[21];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)Words.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrGetRecognitionResults, @params);

        var _WordsPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_WordsPtr, 16, 16);
        Words = new(_WordsPtr, 32) { Allocated = true };

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.StopSpeechRecognition
    // 0x3750E0
    // (Final | Public)
    public unsafe class StopSpeechRecognition_Parameters : BaseObject {
        public StopSpeechRecognition_Parameters() { }
        public StopSpeechRecognition_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.StopSpeechRecognition.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.StopSpeechRecognition.ReturnValue
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
    private static UFunction _ptrStopSpeechRecognition;
    public bool StopSpeechRecognition(byte LocalUserNum) {
        _ptrStopSpeechRecognition ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.StopSpeechRecognition");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrStopSpeechRecognition, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.StartSpeechRecognition
    // 0x3750E0
    // (Final | Public)
    public unsafe class StartSpeechRecognition_Parameters : BaseObject {
        public StartSpeechRecognition_Parameters() { }
        public StartSpeechRecognition_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.StartSpeechRecognition.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.StartSpeechRecognition.ReturnValue
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
    private static UFunction _ptrStartSpeechRecognition;
    public bool StartSpeechRecognition(byte LocalUserNum) {
        _ptrStartSpeechRecognition ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.StartSpeechRecognition");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrStartSpeechRecognition, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.StopNetworkedVoice
    // 0x3750E0
    // (Final | Public)
    public unsafe class StopNetworkedVoice_Parameters : BaseObject {
        public StopNetworkedVoice_Parameters() { }
        public StopNetworkedVoice_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.StopNetworkedVoice.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }
    }
    private static UFunction _ptrStopNetworkedVoice;
    public void StopNetworkedVoice(byte LocalUserNum) {
        _ptrStopNetworkedVoice ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.StopNetworkedVoice");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrStopNetworkedVoice, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.StartNetworkedVoice
    // 0x3750E0
    // (Final | Public)
    public unsafe class StartNetworkedVoice_Parameters : BaseObject {
        public StartNetworkedVoice_Parameters() { }
        public StartNetworkedVoice_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.StartNetworkedVoice.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }
    }
    private static UFunction _ptrStartNetworkedVoice;
    public void StartNetworkedVoice(byte LocalUserNum) {
        _ptrStartNetworkedVoice ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.StartNetworkedVoice");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrStartNetworkedVoice, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearPlayerTalkingDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearPlayerTalkingDelegate_Parameters : BaseObject {
        public ClearPlayerTalkingDelegate_Parameters() { }
        public ClearPlayerTalkingDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.ClearPlayerTalkingDelegate.TalkerDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate TalkerDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearPlayerTalkingDelegate;
    public void ClearPlayerTalkingDelegate(FScriptDelegate TalkerDelegate) {
        _ptrClearPlayerTalkingDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.ClearPlayerTalkingDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)TalkerDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearPlayerTalkingDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddPlayerTalkingDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddPlayerTalkingDelegate_Parameters : BaseObject {
        public AddPlayerTalkingDelegate_Parameters() { }
        public AddPlayerTalkingDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineSubsystemEOS.AddPlayerTalkingDelegate.TalkerDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate TalkerDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddPlayerTalkingDelegate;
    public void AddPlayerTalkingDelegate(FScriptDelegate TalkerDelegate) {
        _ptrAddPlayerTalkingDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.AddPlayerTalkingDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)TalkerDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddPlayerTalkingDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnPlayerTalking
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnPlayerTalking_Parameters : BaseObject {
        public OnPlayerTalking_Parameters() { }
        public OnPlayerTalking_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OnPlayerTalking.Player
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId Player {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }
    }
    private static UFunction _ptrOnPlayerTalking;
    public void OnPlayerTalking(U_Types_Core.FUniqueNetId Player) {
        _ptrOnPlayerTalking ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnPlayerTalking");

        var @params = stackalloc byte[72];
        System.Buffer.MemoryCopy((void*)Player.Pointer, @params, 72, 72);

        ProcessEvent(_ptrOnPlayerTalking, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.UnmuteRemoteTalker
    // 0x3750E0
    // (Final | Public)
    public unsafe class UnmuteRemoteTalker_Parameters : BaseObject {
        public UnmuteRemoteTalker_Parameters() { }
        public UnmuteRemoteTalker_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.UnmuteRemoteTalker.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.UnmuteRemoteTalker.PlayerID
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.UnmuteRemoteTalker.ReturnValue
        // 0x50 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 80) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 80) |= 0x1;
                else *(uint*)(Pointer + 80) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrUnmuteRemoteTalker;
    public bool UnmuteRemoteTalker(byte LocalUserNum, U_Types_Core.FUniqueNetId PlayerID) {
        _ptrUnmuteRemoteTalker ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.UnmuteRemoteTalker");

        var @params = stackalloc byte[77];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params + 8, 72, 72);

        ProcessEvent(_ptrUnmuteRemoteTalker, @params);

        return *(bool*)(@params + 80);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.MuteRemoteTalker
    // 0x3750E0
    // (Final | Public)
    public unsafe class MuteRemoteTalker_Parameters : BaseObject {
        public MuteRemoteTalker_Parameters() { }
        public MuteRemoteTalker_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.MuteRemoteTalker.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.MuteRemoteTalker.PlayerID
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.MuteRemoteTalker.ReturnValue
        // 0x50 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 80) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 80) |= 0x1;
                else *(uint*)(Pointer + 80) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrMuteRemoteTalker;
    public bool MuteRemoteTalker(byte LocalUserNum, U_Types_Core.FUniqueNetId PlayerID) {
        _ptrMuteRemoteTalker ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.MuteRemoteTalker");

        var @params = stackalloc byte[77];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params + 8, 72, 72);

        ProcessEvent(_ptrMuteRemoteTalker, @params);

        return *(bool*)(@params + 80);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.SetRemoteTalkerPriority
    // 0x3750E0
    // (Final | Public)
    public unsafe class SetRemoteTalkerPriority_Parameters : BaseObject {
        public SetRemoteTalkerPriority_Parameters() { }
        public SetRemoteTalkerPriority_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.SetRemoteTalkerPriority.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.SetRemoteTalkerPriority.PlayerID
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // IntProperty OnlineSubsystemEOS.OnlineSubsystemEOS.SetRemoteTalkerPriority.Priority
        // 0x50 (0x4)
        // (Param)
        public int Priority {
            get => *(int*)(Pointer + 80);
            set => *(int*)(Pointer + 80) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.SetRemoteTalkerPriority.ReturnValue
        // 0x54 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 84) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 84) |= 0x1;
                else *(uint*)(Pointer + 84) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetRemoteTalkerPriority;
    public bool SetRemoteTalkerPriority(byte LocalUserNum, U_Types_Core.FUniqueNetId PlayerID, int Priority) {
        _ptrSetRemoteTalkerPriority ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.SetRemoteTalkerPriority");

        var @params = stackalloc byte[81];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params + 8, 72, 72);
        System.Buffer.MemoryCopy(&Priority, @params + 80, 4, 4);

        ProcessEvent(_ptrSetRemoteTalkerPriority, @params);

        return *(bool*)(@params + 84);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.IsHeadsetPresent
    // 0x3750E0
    // (Final | Public)
    public unsafe class IsHeadsetPresent_Parameters : BaseObject {
        public IsHeadsetPresent_Parameters() { }
        public IsHeadsetPresent_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.IsHeadsetPresent.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.IsHeadsetPresent.ReturnValue
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
    private static UFunction _ptrIsHeadsetPresent;
    public bool IsHeadsetPresent(byte LocalUserNum) {
        _ptrIsHeadsetPresent ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.IsHeadsetPresent");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrIsHeadsetPresent, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.IsRemotePlayerTalking
    // 0x3750E0
    // (Final | Public)
    public unsafe class IsRemotePlayerTalking_Parameters : BaseObject {
        public IsRemotePlayerTalking_Parameters() { }
        public IsRemotePlayerTalking_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.IsRemotePlayerTalking.PlayerID
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.IsRemotePlayerTalking.ReturnValue
        // 0x48 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 72) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 72) |= 0x1;
                else *(uint*)(Pointer + 72) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrIsRemotePlayerTalking;
    public bool IsRemotePlayerTalking(U_Types_Core.FUniqueNetId PlayerID) {
        _ptrIsRemotePlayerTalking ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.IsRemotePlayerTalking");

        var @params = stackalloc byte[76];
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params, 72, 72);

        ProcessEvent(_ptrIsRemotePlayerTalking, @params);

        return *(bool*)(@params + 72);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.IsLocalPlayerTalking
    // 0x3750E0
    // (Final | Public)
    public unsafe class IsLocalPlayerTalking_Parameters : BaseObject {
        public IsLocalPlayerTalking_Parameters() { }
        public IsLocalPlayerTalking_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.IsLocalPlayerTalking.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.IsLocalPlayerTalking.ReturnValue
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
    private static UFunction _ptrIsLocalPlayerTalking;
    public bool IsLocalPlayerTalking(byte LocalUserNum) {
        _ptrIsLocalPlayerTalking ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.IsLocalPlayerTalking");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrIsLocalPlayerTalking, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.UnregisterRemoteTalker
    // 0x3750E0
    // (Final | Public)
    public unsafe class UnregisterRemoteTalker_Parameters : BaseObject {
        public UnregisterRemoteTalker_Parameters() { }
        public UnregisterRemoteTalker_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.UnregisterRemoteTalker.PlayerID
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.UnregisterRemoteTalker.ReturnValue
        // 0x48 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 72) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 72) |= 0x1;
                else *(uint*)(Pointer + 72) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrUnregisterRemoteTalker;
    public bool UnregisterRemoteTalker(U_Types_Core.FUniqueNetId PlayerID) {
        _ptrUnregisterRemoteTalker ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.UnregisterRemoteTalker");

        var @params = stackalloc byte[76];
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params, 72, 72);

        ProcessEvent(_ptrUnregisterRemoteTalker, @params);

        return *(bool*)(@params + 72);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.RegisterRemoteTalker
    // 0x3750E0
    // (Final | Public)
    public unsafe class RegisterRemoteTalker_Parameters : BaseObject {
        public RegisterRemoteTalker_Parameters() { }
        public RegisterRemoteTalker_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.RegisterRemoteTalker.PlayerID
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.RegisterRemoteTalker.ReturnValue
        // 0x48 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 72) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 72) |= 0x1;
                else *(uint*)(Pointer + 72) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrRegisterRemoteTalker;
    public bool RegisterRemoteTalker(U_Types_Core.FUniqueNetId PlayerID) {
        _ptrRegisterRemoteTalker ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.RegisterRemoteTalker");

        var @params = stackalloc byte[76];
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params, 72, 72);

        ProcessEvent(_ptrRegisterRemoteTalker, @params);

        return *(bool*)(@params + 72);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.UnregisterLocalTalker
    // 0x3750E0
    // (Final | Public)
    public unsafe class UnregisterLocalTalker_Parameters : BaseObject {
        public UnregisterLocalTalker_Parameters() { }
        public UnregisterLocalTalker_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.UnregisterLocalTalker.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.UnregisterLocalTalker.ReturnValue
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
    private static UFunction _ptrUnregisterLocalTalker;
    public bool UnregisterLocalTalker(byte LocalUserNum) {
        _ptrUnregisterLocalTalker ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.UnregisterLocalTalker");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrUnregisterLocalTalker, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.RegisterLocalTalker
    // 0x3750E0
    // (Final | Public)
    public unsafe class RegisterLocalTalker_Parameters : BaseObject {
        public RegisterLocalTalker_Parameters() { }
        public RegisterLocalTalker_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineSubsystemEOS.RegisterLocalTalker.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.RegisterLocalTalker.ReturnValue
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
    private static UFunction _ptrRegisterLocalTalker;
    public bool RegisterLocalTalker(byte LocalUserNum) {
        _ptrRegisterLocalTalker ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.RegisterLocalTalker");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrRegisterLocalTalker, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetPlayerUniqueNetIdFromIndex
    // 0x3750E0
    // (Defined | Event | Public | HasDefaults)
    public unsafe class GetPlayerUniqueNetIdFromIndex_Parameters : BaseObject {
        public GetPlayerUniqueNetIdFromIndex_Parameters() { }
        public GetPlayerUniqueNetIdFromIndex_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetPlayerUniqueNetIdFromIndex.UserIndex
        // 0x0 (0x4)
        // (Param)
        public int UserIndex {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StructProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetPlayerUniqueNetIdFromIndex.ReturnValue
        // 0x8 (0x48)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public U_Types_Core.FUniqueNetId ReturnValue {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }
    }
    private static UFunction _ptrGetPlayerUniqueNetIdFromIndex;
    public U_Types_Core.FUniqueNetId GetPlayerUniqueNetIdFromIndex(int UserIndex) {
        _ptrGetPlayerUniqueNetIdFromIndex ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetPlayerUniqueNetIdFromIndex");

        var @params = stackalloc byte[76];
        System.Buffer.MemoryCopy(&UserIndex, @params, 4, 4);

        ProcessEvent(_ptrGetPlayerUniqueNetIdFromIndex, @params);

        var _ReturnValuePtr = Marshal.AllocHGlobal(72);
        System.Buffer.MemoryCopy(@params + 8, (void*)_ReturnValuePtr, 72, 72);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetPlayerNicknameFromIndex
    // 0x3750E0
    // (Defined | Event | Public)
    public unsafe class GetPlayerNicknameFromIndex_Parameters : BaseObject {
        public GetPlayerNicknameFromIndex_Parameters() { }
        public GetPlayerNicknameFromIndex_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetPlayerNicknameFromIndex.UserIndex
        // 0x0 (0x4)
        // (Param)
        public int UserIndex {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.GetPlayerNicknameFromIndex.ReturnValue
        // 0x8 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrGetPlayerNicknameFromIndex;
    public FString GetPlayerNicknameFromIndex(int UserIndex) {
        _ptrGetPlayerNicknameFromIndex ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.GetPlayerNicknameFromIndex");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy(&UserIndex, @params, 4, 4);

        ProcessEvent(_ptrGetPlayerNicknameFromIndex, @params);

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.Init
    // 0x659230
    // (Native | Event | Public)
    public unsafe class Init_Parameters : BaseObject {
        public Init_Parameters() { }
        public Init_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.Init.ReturnValue
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
    private static UFunction _ptrInit;
    public bool Init() {
        _ptrInit ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.Init");

        var @params = stackalloc byte[4];

        _ptrInit.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrInit, @params);
        _ptrInit.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)@params;
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.InitEOS
    // 0xCDDBD0
    // (Final | Native | Public | HasOutParams)
    public unsafe class InitEOS_Parameters : BaseObject {
        public InitEOS_Parameters() { }
        public InitEOS_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.InitEOS.SandboxId
        // 0x0 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString SandboxId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.InitEOS.DeploymentId
        // 0x10 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString DeploymentId {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.InitEOS.ReturnValue
        // 0x20 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 32) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 32) |= 0x1;
                else *(uint*)(Pointer + 32) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrInitEOS;
    public bool InitEOS(ref FString SandboxId, ref FString DeploymentId) {
        _ptrInitEOS ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.InitEOS");

        var @params = stackalloc byte[36];
        System.Buffer.MemoryCopy((void*)SandboxId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)DeploymentId.Pointer, @params + 16, 16, 16);

        _ptrInitEOS.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrInitEOS, @params);
        _ptrInitEOS.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _SandboxIdPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_SandboxIdPtr, 16, 16);
        SandboxId = new(_SandboxIdPtr) { Allocated = true };
        var _DeploymentIdPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 16, (void*)_DeploymentIdPtr, 16, 16);
        DeploymentId = new(_DeploymentIdPtr) { Allocated = true };

        return *(bool*)(@params + 32);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.EventGetAppPriceInfoComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventGetAppPriceInfoComplete_Parameters : BaseObject {
        public EventGetAppPriceInfoComplete_Parameters() { }
        public EventGetAppPriceInfoComplete_Parameters(nint pointer) : base(pointer) { }

        // NameProperty OnlineSubsystemEOS.OnlineSubsystemEOS.EventGetAppPriceInfoComplete.AppName
        // 0x0 (0x8)
        // (Param)
        public FName AppName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.EventGetAppPriceInfoComplete.Price
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString Price {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineSubsystemEOS.EventGetAppPriceInfoComplete.DiscountPrice
        // 0x18 (0x10)
        // (Param | NeedCtorLink)
        public FString DiscountPrice {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }

        // IntProperty OnlineSubsystemEOS.OnlineSubsystemEOS.EventGetAppPriceInfoComplete.DiscountPercentage
        // 0x28 (0x4)
        // (Param)
        public int DiscountPercentage {
            get => *(int*)(Pointer + 40);
            set => *(int*)(Pointer + 40) = value;
        }
    }
    private static UFunction _ptrEventGetAppPriceInfoComplete;
    public void EventGetAppPriceInfoComplete(FName AppName, FString Price, FString DiscountPrice, int DiscountPercentage) {
        _ptrEventGetAppPriceInfoComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.EventGetAppPriceInfoComplete");

        var @params = stackalloc byte[44];
        System.Buffer.MemoryCopy((void*)AppName.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Price.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy((void*)DiscountPrice.Pointer, @params + 24, 16, 16);
        System.Buffer.MemoryCopy(&DiscountPercentage, @params + 40, 4, 4);

        ProcessEvent(_ptrEventGetAppPriceInfoComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnMicroTxnResponse
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnMicroTxnResponse_Parameters : BaseObject {
        public OnMicroTxnResponse_Parameters() { }
        public OnMicroTxnResponse_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OnMicroTxnResponse.bAuthorized
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bAuthorized {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }

        // MISSED OFFSET: 0x4

        // QWordProperty OnlineSubsystemEOS.OnlineSubsystemEOS.OnMicroTxnResponse.OrderId
        // 0x8 (0x8)
        // (Param)
        public ulong OrderId {
            get => *(ulong*)(Pointer + 8);
            set => *(ulong*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrOnMicroTxnResponse;
    public void OnMicroTxnResponse(bool bAuthorized, ulong OrderId) {
        _ptrOnMicroTxnResponse ??= FindFunction("Function OnlineSubsystemEOS.OnlineSubsystemEOS.OnMicroTxnResponse");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy(&bAuthorized, @params, 4, 4);
        System.Buffer.MemoryCopy(&OrderId, @params + 8, 8, 8);

        ProcessEvent(_ptrOnMicroTxnResponse, @params);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class OnlineSubsystemEOS.OnlineSubsystemEOS");
            return _staticClass;
        }
    }
}

// Class OnlineSubsystemEOS.OnlineAuthInterfaceEOS
// 0x8 (0x3C8 - 0x3D0)
// (Compiled | Parsed | Native)
public unsafe partial class UOnlineAuthInterfaceEOS : UOnlineAuthInterfaceImpl {
    public UOnlineAuthInterfaceEOS() { }
    public UOnlineAuthInterfaceEOS(nint pointer) : base(pointer) { }


    // ObjectProperty OnlineSubsystemEOS.OnlineAuthInterfaceEOS.PlayerInterfaceEOS
    // 0x3C8 (0x8)
    // (PrivateWrite)
    public UOnlinePlayerInterfaceEOS PlayerInterfaceEOS {
        get {
            var pointer = *(nint*)(Pointer + 968);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 968) = value.Pointer;
    }


    // Function OnlineSubsystemEOS.OnlineAuthInterfaceEOS.RequiresAuthTicket
    // 0x3750E0
    // (Defined | Public)
    public unsafe class RequiresAuthTicket_Parameters : BaseObject {
        public RequiresAuthTicket_Parameters() { }
        public RequiresAuthTicket_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineAuthInterfaceEOS.RequiresAuthTicket.ReturnValue
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
    private static UFunction _ptrRequiresAuthTicket;
    public bool RequiresAuthTicket() {
        _ptrRequiresAuthTicket ??= FindFunction("Function OnlineSubsystemEOS.OnlineAuthInterfaceEOS.RequiresAuthTicket");

        var @params = stackalloc byte[4];

        ProcessEvent(_ptrRequiresAuthTicket, @params);

        return *(bool*)@params;
    }

    // Function OnlineSubsystemEOS.OnlineAuthInterfaceEOS.RequestAuthTicket
    // 0xCDFED0
    // (Native | Public)
    public unsafe class RequestAuthTicket_Parameters : BaseObject {
        public RequestAuthTicket_Parameters() { }
        public RequestAuthTicket_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlineAuthInterfaceEOS.RequestAuthTicket.PlayerID
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // DelegateProperty OnlineSubsystemEOS.OnlineAuthInterfaceEOS.RequestAuthTicket.Callback
        // 0x48 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate Callback {
            get => new(Pointer + 72);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 72), 24, 24);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineAuthInterfaceEOS.RequestAuthTicket.ReturnValue
        // 0x60 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 96) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 96) |= 0x1;
                else *(uint*)(Pointer + 96) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrRequestAuthTicket;
    public bool RequestAuthTicket(U_Types_Core.FUniqueNetId PlayerID, FScriptDelegate Callback) {
        _ptrRequestAuthTicket ??= FindFunction("Function OnlineSubsystemEOS.OnlineAuthInterfaceEOS.RequestAuthTicket");

        var @params = stackalloc byte[100];
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params, 72, 72);
        System.Buffer.MemoryCopy((void*)Callback.Pointer, @params + 72, 24, 24);

        _ptrRequestAuthTicket.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrRequestAuthTicket, @params);
        _ptrRequestAuthTicket.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 96);
    }

    // Function OnlineSubsystemEOS.OnlineAuthInterfaceEOS.RequestMtxCode
    // 0xCDFD10
    // (Native | Public)
    public unsafe class RequestMtxCode_Parameters : BaseObject {
        public RequestMtxCode_Parameters() { }
        public RequestMtxCode_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlineAuthInterfaceEOS.RequestMtxCode.PlayerID
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // DelegateProperty OnlineSubsystemEOS.OnlineAuthInterfaceEOS.RequestMtxCode.Callback
        // 0x48 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate Callback {
            get => new(Pointer + 72);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 72), 24, 24);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineAuthInterfaceEOS.RequestMtxCode.ReturnValue
        // 0x60 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 96) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 96) |= 0x1;
                else *(uint*)(Pointer + 96) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrRequestMtxCode;
    public bool RequestMtxCode(U_Types_Core.FUniqueNetId PlayerID, FScriptDelegate Callback) {
        _ptrRequestMtxCode ??= FindFunction("Function OnlineSubsystemEOS.OnlineAuthInterfaceEOS.RequestMtxCode");

        var @params = stackalloc byte[100];
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params, 72, 72);
        System.Buffer.MemoryCopy((void*)Callback.Pointer, @params + 72, 24, 24);

        _ptrRequestMtxCode.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrRequestMtxCode, @params);
        _ptrRequestMtxCode.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 96);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class OnlineSubsystemEOS.OnlineAuthInterfaceEOS");
            return _staticClass;
        }
    }
}

// Class OnlineSubsystemEOS.OnlineFriendsInterfaceEOS
// 0x8 (0x80 - 0x88)
// (Compiled | Parsed | Native)
public unsafe partial class UOnlineFriendsInterfaceEOS : UOnlineFriendsInterfaceImpl {
    public UOnlineFriendsInterfaceEOS() { }
    public UOnlineFriendsInterfaceEOS(nint pointer) : base(pointer) { }


    // ObjectProperty OnlineSubsystemEOS.OnlineFriendsInterfaceEOS.PlayerInterfaceEOS
    // 0x80 (0x8)
    // (PrivateWrite)
    public UOnlinePlayerInterfaceEOS PlayerInterfaceEOS {
        get {
            var pointer = *(nint*)(Pointer + 128);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 128) = value.Pointer;
    }


    // Function OnlineSubsystemEOS.OnlineFriendsInterfaceEOS.GetActivePlatformId
    // 0xCE0200
    // (Native | Public | HasOutParams)
    public unsafe class GetActivePlatformId_Parameters : BaseObject {
        public GetActivePlatformId_Parameters() { }
        public GetActivePlatformId_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineFriendsInterfaceEOS.GetActivePlatformId.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlineFriendsInterfaceEOS.GetActivePlatformId.AccountId
        // 0x8 (0x48)
        // (Const | Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId AccountId {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // StructProperty OnlineSubsystemEOS.OnlineFriendsInterfaceEOS.GetActivePlatformId.PlatformId
        // 0x50 (0x48)
        // (Param | OutParam | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlatformId {
            get => new(Pointer + 80);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 80), 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineFriendsInterfaceEOS.GetActivePlatformId.ReturnValue
        // 0x98 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 152) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 152) |= 0x1;
                else *(uint*)(Pointer + 152) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrGetActivePlatformId;
    public bool GetActivePlatformId(byte LocalUserNum, U_Types_Core.FUniqueNetId AccountId, ref U_Types_Core.FUniqueNetId PlatformId) {
        _ptrGetActivePlatformId ??= FindFunction("Function OnlineSubsystemEOS.OnlineFriendsInterfaceEOS.GetActivePlatformId");

        var @params = stackalloc byte[149];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)AccountId.Pointer, @params + 8, 72, 72);
        System.Buffer.MemoryCopy((void*)PlatformId.Pointer, @params + 80, 72, 72);

        _ptrGetActivePlatformId.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetActivePlatformId, @params);
        _ptrGetActivePlatformId.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _PlatformIdPtr = Marshal.AllocHGlobal(72);
        System.Buffer.MemoryCopy(@params + 80, (void*)_PlatformIdPtr, 72, 72);
        PlatformId = new(_PlatformIdPtr) { Allocated = true };

        return *(bool*)(@params + 152);
    }

    // Function OnlineSubsystemEOS.OnlineFriendsInterfaceEOS.RequestLinkedAccounts
    // 0xCE0090
    // (Native | Public)
    public unsafe class RequestLinkedAccounts_Parameters : BaseObject {
        public RequestLinkedAccounts_Parameters() { }
        public RequestLinkedAccounts_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineFriendsInterfaceEOS.RequestLinkedAccounts.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ArrayProperty OnlineSubsystemEOS.OnlineFriendsInterfaceEOS.RequestLinkedAccounts.AccountIds
        // 0x8 (0x10)
        // (Const | Param | NeedCtorLink)
        public StructTArray<U_Types_Core.FUniqueNetId> AccountIds {
            get => new(Pointer + 8, 72);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // DelegateProperty OnlineSubsystemEOS.OnlineFriendsInterfaceEOS.RequestLinkedAccounts.Callback
        // 0x18 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate Callback {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 24, 24);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineFriendsInterfaceEOS.RequestLinkedAccounts.ReturnValue
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
    private static UFunction _ptrRequestLinkedAccounts;
    public bool RequestLinkedAccounts(byte LocalUserNum, StructTArray<U_Types_Core.FUniqueNetId> AccountIds, FScriptDelegate Callback) {
        _ptrRequestLinkedAccounts ??= FindFunction("Function OnlineSubsystemEOS.OnlineFriendsInterfaceEOS.RequestLinkedAccounts");

        var @params = stackalloc byte[45];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)AccountIds.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy((void*)Callback.Pointer, @params + 24, 24, 24);

        _ptrRequestLinkedAccounts.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrRequestLinkedAccounts, @params);
        _ptrRequestLinkedAccounts.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 48);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class OnlineSubsystemEOS.OnlineFriendsInterfaceEOS");
            return _staticClass;
        }
    }
}

// Class OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS
// 0xB0 (0x60 - 0x110)
// (Compiled | Parsed | Native)
public unsafe partial class UOnlineGameClipsInterfaceEOS : UObject {
    public UOnlineGameClipsInterfaceEOS() { }
    public UOnlineGameClipsInterfaceEOS(nint pointer) : base(pointer) { }


    // StructProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.GameClipsHandle
    // 0x60 (0x8)
    // (Const | Native | Transient)
    public nint GameClipsHandle {
        get => *(nint*)(Pointer + 96);
        set => *(nint*)(Pointer + 96) = value;
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.__EventAvailabilityChanged__Delegate
    // 0x68 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventAvailabilityChanged__Delegate {
        get => new(Pointer + 104);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 104), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.__EventRecordingChanged__Delegate
    // 0x80 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventRecordingChanged__Delegate {
        get => new(Pointer + 128);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 128), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.__EventConnectionStatusChanged__Delegate
    // 0x98 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventConnectionStatusChanged__Delegate {
        get => new(Pointer + 152);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 152), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.__EventClipStatusChanged__Delegate
    // 0xB0 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventClipStatusChanged__Delegate {
        get => new(Pointer + 176);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 176), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.__EventMaskStatusChanged__Delegate
    // 0xC8 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventMaskStatusChanged__Delegate {
        get => new(Pointer + 200);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 200), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.__EventGeneralErrorOccurred__Delegate
    // 0xE0 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventGeneralErrorOccurred__Delegate {
        get => new(Pointer + 224);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 224), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.__EventClipErrorOccurred__Delegate
    // 0xF8 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventClipErrorOccurred__Delegate {
        get => new(Pointer + 248);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 248), 24, 24);
    }


    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventClipErrorOccurred
    // 0x3750E0
    // (Defined | Public)
    public unsafe class NotifyEventClipErrorOccurred_Parameters : BaseObject {
        public NotifyEventClipErrorOccurred_Parameters() { }
        public NotifyEventClipErrorOccurred_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventClipErrorOccurred.InCallback
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InCallback {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrNotifyEventClipErrorOccurred;
    public void NotifyEventClipErrorOccurred(FScriptDelegate InCallback) {
        _ptrNotifyEventClipErrorOccurred ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventClipErrorOccurred");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InCallback.Pointer, @params, 24, 24);

        ProcessEvent(_ptrNotifyEventClipErrorOccurred, @params);
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventClipErrorOccurred
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventClipErrorOccurred_Parameters : BaseObject {
        public EventClipErrorOccurred_Parameters() { }
        public EventClipErrorOccurred_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventClipErrorOccurred.InEpicAccountId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString InEpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // IntProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventClipErrorOccurred.ClipId
        // 0x10 (0x4)
        // (Param)
        public int ClipId {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }

        // MISSED OFFSET: 0x4

        // ObjectProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventClipErrorOccurred.InErrorType
        // 0x18 (0x8)
        // (Param)
        public UErrorType InErrorType {
            get {
                var pointer = *(nint*)(Pointer + 24);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 24) = value.Pointer;
        }
    }
    private static UFunction _ptrEventClipErrorOccurred;
    public void EventClipErrorOccurred(FString InEpicAccountId, int ClipId, UErrorType InErrorType) {
        _ptrEventClipErrorOccurred ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventClipErrorOccurred");

        var @params = stackalloc byte[28];
        System.Buffer.MemoryCopy((void*)InEpicAccountId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&ClipId, @params + 16, 4, 4);
        System.Buffer.MemoryCopy((void*)InErrorType.Pointer, @params + 24, 8, 8);

        ProcessEvent(_ptrEventClipErrorOccurred, @params);
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventGeneralErrorOccurred
    // 0x3750E0
    // (Defined | Public)
    public unsafe class NotifyEventGeneralErrorOccurred_Parameters : BaseObject {
        public NotifyEventGeneralErrorOccurred_Parameters() { }
        public NotifyEventGeneralErrorOccurred_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventGeneralErrorOccurred.InCallback
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InCallback {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrNotifyEventGeneralErrorOccurred;
    public void NotifyEventGeneralErrorOccurred(FScriptDelegate InCallback) {
        _ptrNotifyEventGeneralErrorOccurred ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventGeneralErrorOccurred");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InCallback.Pointer, @params, 24, 24);

        ProcessEvent(_ptrNotifyEventGeneralErrorOccurred, @params);
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventGeneralErrorOccurred
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventGeneralErrorOccurred_Parameters : BaseObject {
        public EventGeneralErrorOccurred_Parameters() { }
        public EventGeneralErrorOccurred_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventGeneralErrorOccurred.InErrorType
        // 0x0 (0x8)
        // (Param)
        public UErrorType InErrorType {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrEventGeneralErrorOccurred;
    public void EventGeneralErrorOccurred(UErrorType InErrorType) {
        _ptrEventGeneralErrorOccurred ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventGeneralErrorOccurred");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy((void*)InErrorType.Pointer, @params, 8, 8);

        ProcessEvent(_ptrEventGeneralErrorOccurred, @params);
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventMaskStatusChanged
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class NotifyEventMaskStatusChanged_Parameters : BaseObject {
        public NotifyEventMaskStatusChanged_Parameters() { }
        public NotifyEventMaskStatusChanged_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventMaskStatusChanged.InCallback
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InCallback {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrNotifyEventMaskStatusChanged;
    public void NotifyEventMaskStatusChanged(FScriptDelegate InCallback) {
        _ptrNotifyEventMaskStatusChanged ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventMaskStatusChanged");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InCallback.Pointer, @params, 24, 24);

        ProcessEvent(_ptrNotifyEventMaskStatusChanged, @params);
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventMaskStatusChanged
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventMaskStatusChanged_Parameters : BaseObject {
        public EventMaskStatusChanged_Parameters() { }
        public EventMaskStatusChanged_Parameters(nint pointer) : base(pointer) { }

        // QWordProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventMaskStatusChanged.InMaskAreaHandle
        // 0x0 (0x8)
        // (Param)
        public ulong InMaskAreaHandle {
            get => *(ulong*)Pointer;
            set => *(ulong*)Pointer = value;
        }

        // StructProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventMaskStatusChanged.InMaskArea
        // 0x8 (0x18)
        // (Const | Param)
        public U_Types_Engine.FGameClipsMaskArea InMaskArea {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }

        // ByteProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventMaskStatusChanged.InNewMaskStatus
        // 0x20 (0x1)
        // (Param)
        public U_Types_Engine.EGameClipsMaskStatus InNewMaskStatus {
            get => *(U_Types_Engine.EGameClipsMaskStatus*)(Pointer + 32);
            set => *(U_Types_Engine.EGameClipsMaskStatus*)(Pointer + 32) = value;
        }
    }
    private static UFunction _ptrEventMaskStatusChanged;
    public void EventMaskStatusChanged(ulong InMaskAreaHandle, U_Types_Engine.FGameClipsMaskArea InMaskArea, U_Types_Engine.EGameClipsMaskStatus InNewMaskStatus) {
        _ptrEventMaskStatusChanged ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventMaskStatusChanged");

        var @params = stackalloc byte[33];
        System.Buffer.MemoryCopy(&InMaskAreaHandle, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)InMaskArea.Pointer, @params + 8, 24, 24);
        System.Buffer.MemoryCopy(&InNewMaskStatus, @params + 32, 1, 1);

        ProcessEvent(_ptrEventMaskStatusChanged, @params);
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventClipStatusChanged
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class NotifyEventClipStatusChanged_Parameters : BaseObject {
        public NotifyEventClipStatusChanged_Parameters() { }
        public NotifyEventClipStatusChanged_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventClipStatusChanged.InCallback
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InCallback {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrNotifyEventClipStatusChanged;
    public void NotifyEventClipStatusChanged(FScriptDelegate InCallback) {
        _ptrNotifyEventClipStatusChanged ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventClipStatusChanged");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InCallback.Pointer, @params, 24, 24);

        ProcessEvent(_ptrNotifyEventClipStatusChanged, @params);
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventClipStatusChanged
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventClipStatusChanged_Parameters : BaseObject {
        public EventClipStatusChanged_Parameters() { }
        public EventClipStatusChanged_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventClipStatusChanged.InEpicAccountId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString InEpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // IntProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventClipStatusChanged.InClipId
        // 0x10 (0x4)
        // (Param)
        public int InClipId {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventClipStatusChanged.InNewClipStatus
        // 0x14 (0x1)
        // (Param)
        public U_Types_Engine.EGameClipsClipStatus InNewClipStatus {
            get => *(U_Types_Engine.EGameClipsClipStatus*)(Pointer + 20);
            set => *(U_Types_Engine.EGameClipsClipStatus*)(Pointer + 20) = value;
        }
    }
    private static UFunction _ptrEventClipStatusChanged;
    public void EventClipStatusChanged(FString InEpicAccountId, int InClipId, U_Types_Engine.EGameClipsClipStatus InNewClipStatus) {
        _ptrEventClipStatusChanged ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventClipStatusChanged");

        var @params = stackalloc byte[21];
        System.Buffer.MemoryCopy((void*)InEpicAccountId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&InClipId, @params + 16, 4, 4);
        System.Buffer.MemoryCopy(&InNewClipStatus, @params + 20, 1, 1);

        ProcessEvent(_ptrEventClipStatusChanged, @params);
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventConnectionStatusChanged
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class NotifyEventConnectionStatusChanged_Parameters : BaseObject {
        public NotifyEventConnectionStatusChanged_Parameters() { }
        public NotifyEventConnectionStatusChanged_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventConnectionStatusChanged.InCallback
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InCallback {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrNotifyEventConnectionStatusChanged;
    public void NotifyEventConnectionStatusChanged(FScriptDelegate InCallback) {
        _ptrNotifyEventConnectionStatusChanged ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventConnectionStatusChanged");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InCallback.Pointer, @params, 24, 24);

        ProcessEvent(_ptrNotifyEventConnectionStatusChanged, @params);
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventConnectionStatusChanged
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventConnectionStatusChanged_Parameters : BaseObject {
        public EventConnectionStatusChanged_Parameters() { }
        public EventConnectionStatusChanged_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventConnectionStatusChanged.InEpicAccountId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString InEpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ByteProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventConnectionStatusChanged.InConnection
        // 0x10 (0x1)
        // (Param)
        public U_Types_Engine.EGameClipsConnection InConnection {
            get => *(U_Types_Engine.EGameClipsConnection*)(Pointer + 16);
            set => *(U_Types_Engine.EGameClipsConnection*)(Pointer + 16) = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventConnectionStatusChanged.InNewConnectionStatus
        // 0x11 (0x1)
        // (Param)
        public U_Types_Engine.EGameClipsConnectionStatus InNewConnectionStatus {
            get => *(U_Types_Engine.EGameClipsConnectionStatus*)(Pointer + 17);
            set => *(U_Types_Engine.EGameClipsConnectionStatus*)(Pointer + 17) = value;
        }
    }
    private static UFunction _ptrEventConnectionStatusChanged;
    public void EventConnectionStatusChanged(FString InEpicAccountId, U_Types_Engine.EGameClipsConnection InConnection, U_Types_Engine.EGameClipsConnectionStatus InNewConnectionStatus) {
        _ptrEventConnectionStatusChanged ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventConnectionStatusChanged");

        var @params = stackalloc byte[18];
        System.Buffer.MemoryCopy((void*)InEpicAccountId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&InConnection, @params + 16, 1, 1);
        System.Buffer.MemoryCopy(&InNewConnectionStatus, @params + 17, 1, 1);

        ProcessEvent(_ptrEventConnectionStatusChanged, @params);
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventRecordingChanged
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class NotifyEventRecordingChanged_Parameters : BaseObject {
        public NotifyEventRecordingChanged_Parameters() { }
        public NotifyEventRecordingChanged_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventRecordingChanged.InCallback
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InCallback {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrNotifyEventRecordingChanged;
    public void NotifyEventRecordingChanged(FScriptDelegate InCallback) {
        _ptrNotifyEventRecordingChanged ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventRecordingChanged");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InCallback.Pointer, @params, 24, 24);

        ProcessEvent(_ptrNotifyEventRecordingChanged, @params);
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventRecordingChanged
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventRecordingChanged_Parameters : BaseObject {
        public EventRecordingChanged_Parameters() { }
        public EventRecordingChanged_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventRecordingChanged.InNewRecording
        // 0x0 (0x1)
        // (Param)
        public U_Types_Engine.EGameClipsRecording InNewRecording {
            get => *(U_Types_Engine.EGameClipsRecording*)Pointer;
            set => *(U_Types_Engine.EGameClipsRecording*)Pointer = value;
        }
    }
    private static UFunction _ptrEventRecordingChanged;
    public void EventRecordingChanged(U_Types_Engine.EGameClipsRecording InNewRecording) {
        _ptrEventRecordingChanged ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventRecordingChanged");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&InNewRecording, @params, 1, 1);

        ProcessEvent(_ptrEventRecordingChanged, @params);
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventAvailabilityChanged
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class NotifyEventAvailabilityChanged_Parameters : BaseObject {
        public NotifyEventAvailabilityChanged_Parameters() { }
        public NotifyEventAvailabilityChanged_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventAvailabilityChanged.InCallback
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InCallback {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrNotifyEventAvailabilityChanged;
    public void NotifyEventAvailabilityChanged(FScriptDelegate InCallback) {
        _ptrNotifyEventAvailabilityChanged ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.NotifyEventAvailabilityChanged");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InCallback.Pointer, @params, 24, 24);

        ProcessEvent(_ptrNotifyEventAvailabilityChanged, @params);
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventAvailabilityChanged
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventAvailabilityChanged_Parameters : BaseObject {
        public EventAvailabilityChanged_Parameters() { }
        public EventAvailabilityChanged_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventAvailabilityChanged.InNewAvailability
        // 0x0 (0x1)
        // (Param)
        public U_Types_Engine.EGameClipsAvailability InNewAvailability {
            get => *(U_Types_Engine.EGameClipsAvailability*)Pointer;
            set => *(U_Types_Engine.EGameClipsAvailability*)Pointer = value;
        }
    }
    private static UFunction _ptrEventAvailabilityChanged;
    public void EventAvailabilityChanged(U_Types_Engine.EGameClipsAvailability InNewAvailability) {
        _ptrEventAvailabilityChanged ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EventAvailabilityChanged");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&InNewAvailability, @params, 1, 1);

        ProcessEvent(_ptrEventAvailabilityChanged, @params);
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.IsUploading
    // 0xCE0BB0
    // (Final | Native | Public)
    public unsafe class IsUploading_Parameters : BaseObject {
        public IsUploading_Parameters() { }
        public IsUploading_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.IsUploading.ReturnValue
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
    private static UFunction _ptrIsUploading;
    public bool IsUploading() {
        _ptrIsUploading ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.IsUploading");

        var @params = stackalloc byte[4];

        _ptrIsUploading.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrIsUploading, @params);
        _ptrIsUploading.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)@params;
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.IsRecording
    // 0xCE0AF0
    // (Final | Native | Public)
    public unsafe class IsRecording_Parameters : BaseObject {
        public IsRecording_Parameters() { }
        public IsRecording_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.IsRecording.ReturnValue
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
    private static UFunction _ptrIsRecording;
    public bool IsRecording() {
        _ptrIsRecording ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.IsRecording");

        var @params = stackalloc byte[4];

        _ptrIsRecording.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrIsRecording, @params);
        _ptrIsRecording.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)@params;
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.IsAvailable
    // 0xCE0AB0
    // (Final | Native | Public)
    public unsafe class IsAvailable_Parameters : BaseObject {
        public IsAvailable_Parameters() { }
        public IsAvailable_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.IsAvailable.ReturnValue
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
    private static UFunction _ptrIsAvailable;
    public bool IsAvailable() {
        _ptrIsAvailable ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.IsAvailable");

        var @params = stackalloc byte[4];

        _ptrIsAvailable.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrIsAvailable, @params);
        _ptrIsAvailable.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)@params;
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.GetTimeUntilUnthrottled
    // 0xCE09E0
    // (Final | Native | Public)
    public unsafe class GetTimeUntilUnthrottled_Parameters : BaseObject {
        public GetTimeUntilUnthrottled_Parameters() { }
        public GetTimeUntilUnthrottled_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.GetTimeUntilUnthrottled.InEpicAccountId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString InEpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // FloatProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.GetTimeUntilUnthrottled.ReturnValue
        // 0x10 (0x4)
        // (Param | OutParam | ReturnParam)
        public float ReturnValue {
            get => *(float*)(Pointer + 16);
            set => *(float*)(Pointer + 16) = value;
        }
    }
    private static UFunction _ptrGetTimeUntilUnthrottled;
    public float GetTimeUntilUnthrottled(FString InEpicAccountId) {
        _ptrGetTimeUntilUnthrottled ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.GetTimeUntilUnthrottled");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)InEpicAccountId.Pointer, @params, 16, 16);

        _ptrGetTimeUntilUnthrottled.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetTimeUntilUnthrottled, @params);
        _ptrGetTimeUntilUnthrottled.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(float*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.IsClipUploadingLimitReached
    // 0xCE08B0
    // (Final | Native | Public)
    public unsafe class IsClipUploadingLimitReached_Parameters : BaseObject {
        public IsClipUploadingLimitReached_Parameters() { }
        public IsClipUploadingLimitReached_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.IsClipUploadingLimitReached.InEpicAccountId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString InEpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.IsClipUploadingLimitReached.ReturnValue
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
    private static UFunction _ptrIsClipUploadingLimitReached;
    public bool IsClipUploadingLimitReached(FString InEpicAccountId) {
        _ptrIsClipUploadingLimitReached ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.IsClipUploadingLimitReached");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)InEpicAccountId.Pointer, @params, 16, 16);

        _ptrIsClipUploadingLimitReached.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrIsClipUploadingLimitReached, @params);
        _ptrIsClipUploadingLimitReached.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.SetUserMaxClipUploadsPerMinute
    // 0xCE0840
    // (Final | Native | Public)
    public unsafe class SetUserMaxClipUploadsPerMinute_Parameters : BaseObject {
        public SetUserMaxClipUploadsPerMinute_Parameters() { }
        public SetUserMaxClipUploadsPerMinute_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.SetUserMaxClipUploadsPerMinute.InMaxClipUploadsPerMinute
        // 0x0 (0x4)
        // (Param)
        public int InMaxClipUploadsPerMinute {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrSetUserMaxClipUploadsPerMinute;
    public void SetUserMaxClipUploadsPerMinute(int InMaxClipUploadsPerMinute) {
        _ptrSetUserMaxClipUploadsPerMinute ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.SetUserMaxClipUploadsPerMinute");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&InMaxClipUploadsPerMinute, @params, 4, 4);

        _ptrSetUserMaxClipUploadsPerMinute.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetUserMaxClipUploadsPerMinute, @params);
        _ptrSetUserMaxClipUploadsPerMinute.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.IsAccountLinked
    // 0xCE0780
    // (Final | Native | Public)
    public unsafe class IsAccountLinked_Parameters : BaseObject {
        public IsAccountLinked_Parameters() { }
        public IsAccountLinked_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.IsAccountLinked.InEpicAccountId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString InEpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.IsAccountLinked.ReturnValue
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
    private static UFunction _ptrIsAccountLinked;
    public bool IsAccountLinked(FString InEpicAccountId) {
        _ptrIsAccountLinked ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.IsAccountLinked");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)InEpicAccountId.Pointer, @params, 16, 16);

        _ptrIsAccountLinked.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrIsAccountLinked, @params);
        _ptrIsAccountLinked.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.CreateClip
    // 0xCE0670
    // (Final | Native | Public)
    public unsafe class CreateClip_Parameters : BaseObject {
        public CreateClip_Parameters() { }
        public CreateClip_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.CreateClip.InEpicAccountId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString InEpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.CreateClip.InClipType
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString InClipType {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // IntProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.CreateClip.ReturnValue
        // 0x20 (0x4)
        // (Param | OutParam | ReturnParam)
        public int ReturnValue {
            get => *(int*)(Pointer + 32);
            set => *(int*)(Pointer + 32) = value;
        }
    }
    private static UFunction _ptrCreateClip;
    public int CreateClip(FString InEpicAccountId, FString InClipType) {
        _ptrCreateClip ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.CreateClip");

        var @params = stackalloc byte[36];
        System.Buffer.MemoryCopy((void*)InEpicAccountId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)InClipType.Pointer, @params + 16, 16, 16);

        _ptrCreateClip.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrCreateClip, @params);
        _ptrCreateClip.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(int*)(@params + 32);
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.DisableMaskArea
    // 0xCE05F0
    // (Final | Native | Public)
    public unsafe class DisableMaskArea_Parameters : BaseObject {
        public DisableMaskArea_Parameters() { }
        public DisableMaskArea_Parameters(nint pointer) : base(pointer) { }

        // QWordProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.DisableMaskArea.InMaskAreaHandle
        // 0x0 (0x8)
        // (Param)
        public ulong InMaskAreaHandle {
            get => *(ulong*)Pointer;
            set => *(ulong*)Pointer = value;
        }
    }
    private static UFunction _ptrDisableMaskArea;
    public void DisableMaskArea(ulong InMaskAreaHandle) {
        _ptrDisableMaskArea ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.DisableMaskArea");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&InMaskAreaHandle, @params, 8, 8);

        _ptrDisableMaskArea.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrDisableMaskArea, @params);
        _ptrDisableMaskArea.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EnableMaskArea
    // 0xCE0520
    // (Final | Native | Public | HasOutParams)
    public unsafe class EnableMaskArea_Parameters : BaseObject {
        public EnableMaskArea_Parameters() { }
        public EnableMaskArea_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EnableMaskArea.InMaskArea
        // 0x0 (0x18)
        // (Param | OutParam)
        public U_Types_Engine.FGameClipsMaskArea InMaskArea {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }

        // QWordProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EnableMaskArea.ReturnValue
        // 0x18 (0x8)
        // (Param | OutParam | ReturnParam)
        public ulong ReturnValue {
            get => *(ulong*)(Pointer + 24);
            set => *(ulong*)(Pointer + 24) = value;
        }
    }
    private static UFunction _ptrEnableMaskArea;
    public ulong EnableMaskArea(ref U_Types_Engine.FGameClipsMaskArea InMaskArea) {
        _ptrEnableMaskArea ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.EnableMaskArea");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)InMaskArea.Pointer, @params, 24, 24);

        _ptrEnableMaskArea.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrEnableMaskArea, @params);
        _ptrEnableMaskArea.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _InMaskAreaPtr = Marshal.AllocHGlobal(24);
        System.Buffer.MemoryCopy(@params, (void*)_InMaskAreaPtr, 24, 24);
        InMaskArea = new(_InMaskAreaPtr) { Allocated = true };

        return *(ulong*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.StopRecording
    // 0xCE04A0
    // (Final | Native | Public)
    public unsafe class StopRecording_Parameters : BaseObject {
        public StopRecording_Parameters() { }
        public StopRecording_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrStopRecording;
    public void StopRecording() {
        _ptrStopRecording ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.StopRecording");

        _ptrStopRecording.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrStopRecording, null);
        _ptrStopRecording.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.StartRecording
    // 0xCE0420
    // (Final | Native | Public)
    public unsafe class StartRecording_Parameters : BaseObject {
        public StartRecording_Parameters() { }
        public StartRecording_Parameters(nint pointer) : base(pointer) { }

        // QWordProperty OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.StartRecording.InClipDuration
        // 0x0 (0x8)
        // (Param)
        public ulong InClipDuration {
            get => *(ulong*)Pointer;
            set => *(ulong*)Pointer = value;
        }
    }
    private static UFunction _ptrStartRecording;
    public void StartRecording(ulong InClipDuration) {
        _ptrStartRecording ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS.StartRecording");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&InClipDuration, @params, 8, 8);

        _ptrStartRecording.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrStartRecording, @params);
        _ptrStartRecording.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class OnlineSubsystemEOS.OnlineGameClipsInterfaceEOS");
            return _staticClass;
        }
    }
}

// Class OnlineSubsystemEOS.OnlineGameInterfaceEOS
// 0x1C (0x318 - 0x334)
// (Compiled | Config | Parsed | Native)
public unsafe partial class UOnlineGameInterfaceEOS : UOnlineGameInterfaceImpl {
    public UOnlineGameInterfaceEOS() { }
    public UOnlineGameInterfaceEOS(nint pointer) : base(pointer) { }


    // StructProperty OnlineSubsystemEOS.OnlineGameInterfaceEOS.SessionsHandle
    // 0x318 (0x8)
    // (Const | Native | Transient)
    public nint SessionsHandle {
        get => *(nint*)(Pointer + 792);
        set => *(nint*)(Pointer + 792) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlineGameInterfaceEOS.CurrentSearchHandle
    // 0x320 (0x8)
    // (Const | Native | Transient)
    public nint CurrentSearchHandle {
        get => *(nint*)(Pointer + 800);
        set => *(nint*)(Pointer + 800) = value;
    }

    // ObjectProperty OnlineSubsystemEOS.OnlineGameInterfaceEOS.PlayerInterfaceEOS
    // 0x328 (0x8)
    public UOnlinePlayerInterfaceEOS PlayerInterfaceEOS {
        get {
            var pointer = *(nint*)(Pointer + 808);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 808) = value.Pointer;
    }

    // BoolProperty OnlineSubsystemEOS.OnlineGameInterfaceEOS.bGameSessionUpdateInProgress
    // 0x330 (0x4)
    // Bitmask: 0x00000001
    public bool bGameSessionUpdateInProgress {
        get => (*(uint*)(Pointer + 816) & 0x1) != 0;
        set {
            if (value) *(uint*)(Pointer + 816) |= 0x1;
            else *(uint*)(Pointer + 816) &= ~(uint)0x1;
        }
    }


    // Function OnlineSubsystemEOS.OnlineGameInterfaceEOS.AcceptGameInvite
    // 0xCDAE90
    // (Native | Public)
    public unsafe class AcceptGameInvite_Parameters : BaseObject {
        public AcceptGameInvite_Parameters() { }
        public AcceptGameInvite_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineGameInterfaceEOS.AcceptGameInvite.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // NameProperty OnlineSubsystemEOS.OnlineGameInterfaceEOS.AcceptGameInvite.SessionName
        // 0x4 (0x8)
        // (Param)
        public FName SessionName {
            get => new(Pointer + 4);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 4), 8, 8);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineGameInterfaceEOS.AcceptGameInvite.ReturnValue
        // 0xC (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 12) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 12) |= 0x1;
                else *(uint*)(Pointer + 12) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrAcceptGameInvite;
    public bool AcceptGameInvite(byte LocalUserNum, FName SessionName) {
        _ptrAcceptGameInvite ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameInterfaceEOS.AcceptGameInvite");

        var @params = stackalloc byte[13];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)SessionName.Pointer, @params + 4, 8, 8);

        _ptrAcceptGameInvite.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrAcceptGameInvite, @params);
        _ptrAcceptGameInvite.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 12);
    }

    // Function OnlineSubsystemEOS.OnlineGameInterfaceEOS.FreeSearchResults
    // 0xBA7E90
    // (Native | Public)
    public unsafe class FreeSearchResults_Parameters : BaseObject {
        public FreeSearchResults_Parameters() { }
        public FreeSearchResults_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty OnlineSubsystemEOS.OnlineGameInterfaceEOS.FreeSearchResults.Search
        // 0x0 (0x8)
        // (Param)
        public UOnlineGameSearch Search {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineGameInterfaceEOS.FreeSearchResults.ReturnValue
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
    private static UFunction _ptrFreeSearchResults;
    public bool FreeSearchResults(UOnlineGameSearch Search) {
        _ptrFreeSearchResults ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameInterfaceEOS.FreeSearchResults");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)Search.Pointer, @params, 8, 8);

        _ptrFreeSearchResults.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrFreeSearchResults, @params);
        _ptrFreeSearchResults.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 8);
    }

    // Function OnlineSubsystemEOS.OnlineGameInterfaceEOS.UpdateOnlineGame
    // 0xCDADA0
    // (Native | HasOptionalParams | Public)
    public unsafe class UpdateOnlineGame_Parameters : BaseObject {
        public UpdateOnlineGame_Parameters() { }
        public UpdateOnlineGame_Parameters(nint pointer) : base(pointer) { }

        // NameProperty OnlineSubsystemEOS.OnlineGameInterfaceEOS.UpdateOnlineGame.SessionName
        // 0x0 (0x8)
        // (Param)
        public FName SessionName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // ObjectProperty OnlineSubsystemEOS.OnlineGameInterfaceEOS.UpdateOnlineGame.UpdatedGameSettings
        // 0x8 (0x8)
        // (Param)
        public UOnlineGameSettings UpdatedGameSettings {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineGameInterfaceEOS.UpdateOnlineGame.bShouldRefreshOnlineData
        // 0x10 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bShouldRefreshOnlineData {
            get => (*(uint*)(Pointer + 16) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 16) |= 0x1;
                else *(uint*)(Pointer + 16) &= ~(uint)0x1;
            }
        }

        // BoolProperty OnlineSubsystemEOS.OnlineGameInterfaceEOS.UpdateOnlineGame.ReturnValue
        // 0x14 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 20) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 20) |= 0x1;
                else *(uint*)(Pointer + 20) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrUpdateOnlineGame;
    public bool UpdateOnlineGame(FName SessionName, UOnlineGameSettings UpdatedGameSettings, bool bShouldRefreshOnlineData = false) {
        _ptrUpdateOnlineGame ??= FindFunction("Function OnlineSubsystemEOS.OnlineGameInterfaceEOS.UpdateOnlineGame");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)SessionName.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)UpdatedGameSettings.Pointer, @params + 8, 8, 8);
        System.Buffer.MemoryCopy(&bShouldRefreshOnlineData, @params + 16, 4, 4);

        _ptrUpdateOnlineGame.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrUpdateOnlineGame, @params);
        _ptrUpdateOnlineGame.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 20);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class OnlineSubsystemEOS.OnlineGameInterfaceEOS");
            return _staticClass;
        }
    }
}

// Class OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS
// 0x8 (0xB8 - 0xC0)
// (Compiled | Parsed | Native)
public unsafe partial class UOnlinePersistentAuthInterfaceEOS : UOnlinePersistentAuthInterfaceImpl {
    public UOnlinePersistentAuthInterfaceEOS() { }
    public UOnlinePersistentAuthInterfaceEOS(nint pointer) : base(pointer) { }


    // ObjectProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.PlayerInterfaceEOS
    // 0xB8 (0x8)
    // (PrivateWrite)
    public UOnlinePlayerInterfaceEOS PlayerInterfaceEOS {
        get {
            var pointer = *(nint*)(Pointer + 184);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 184) = value.Pointer;
    }


    // Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.AuthWithNintendoAccountToken
    // 0xCDB5C0
    // (Native | Public | HasOutParams)
    public unsafe class AuthWithNintendoAccountToken_Parameters : BaseObject {
        public AuthWithNintendoAccountToken_Parameters() { }
        public AuthWithNintendoAccountToken_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.AuthWithNintendoAccountToken.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StrProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.AuthWithNintendoAccountToken.NintendoAccountToken
        // 0x8 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString NintendoAccountToken {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.AuthWithNintendoAccountToken.ReturnValue
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
    private static UFunction _ptrAuthWithNintendoAccountToken;
    public bool AuthWithNintendoAccountToken(byte LocalUserNum, ref FString NintendoAccountToken) {
        _ptrAuthWithNintendoAccountToken ??= FindFunction("Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.AuthWithNintendoAccountToken");

        var @params = stackalloc byte[21];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)NintendoAccountToken.Pointer, @params + 8, 16, 16);

        _ptrAuthWithNintendoAccountToken.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrAuthWithNintendoAccountToken, @params);
        _ptrAuthWithNintendoAccountToken.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _NintendoAccountTokenPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_NintendoAccountTokenPtr, 16, 16);
        NintendoAccountToken = new(_NintendoAccountTokenPtr) { Allocated = true };

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetTimeUntilAuthExpiration
    // 0xCDB530
    // (Native | Public)
    public unsafe class GetTimeUntilAuthExpiration_Parameters : BaseObject {
        public GetTimeUntilAuthExpiration_Parameters() { }
        public GetTimeUntilAuthExpiration_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetTimeUntilAuthExpiration.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // QWordProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetTimeUntilAuthExpiration.ReturnValue
        // 0x8 (0x8)
        // (Param | OutParam | ReturnParam)
        public ulong ReturnValue {
            get => *(ulong*)(Pointer + 8);
            set => *(ulong*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrGetTimeUntilAuthExpiration;
    public ulong GetTimeUntilAuthExpiration(byte LocalUserNum) {
        _ptrGetTimeUntilAuthExpiration ??= FindFunction("Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetTimeUntilAuthExpiration");

        var @params = stackalloc byte[9];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        _ptrGetTimeUntilAuthExpiration.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetTimeUntilAuthExpiration, @params);
        _ptrGetTimeUntilAuthExpiration.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(ulong*)(@params + 8);
    }

    // Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetAuthExpirationTimestamp
    // 0xCDB4A0
    // (Native | Public)
    public unsafe class GetAuthExpirationTimestamp_Parameters : BaseObject {
        public GetAuthExpirationTimestamp_Parameters() { }
        public GetAuthExpirationTimestamp_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetAuthExpirationTimestamp.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ObjectProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetAuthExpirationTimestamp.ReturnValue
        // 0x8 (0x8)
        // (Param | OutParam | ReturnParam)
        public UDateTime ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }
    }
    private static UFunction _ptrGetAuthExpirationTimestamp;
    public UDateTime GetAuthExpirationTimestamp(byte LocalUserNum) {
        _ptrGetAuthExpirationTimestamp ??= FindFunction("Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetAuthExpirationTimestamp");

        var @params = stackalloc byte[9];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        _ptrGetAuthExpirationTimestamp.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetAuthExpirationTimestamp, @params);
        _ptrGetAuthExpirationTimestamp.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)(@params + 8));
    }

    // Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.LaunchAccountPortal
    // 0xCDB410
    // (Native | Public)
    public unsafe class LaunchAccountPortal_Parameters : BaseObject {
        public LaunchAccountPortal_Parameters() { }
        public LaunchAccountPortal_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.LaunchAccountPortal.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.LaunchAccountPortal.ReturnValue
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
    private static UFunction _ptrLaunchAccountPortal;
    public bool LaunchAccountPortal(byte LocalUserNum) {
        _ptrLaunchAccountPortal ??= FindFunction("Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.LaunchAccountPortal");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        _ptrLaunchAccountPortal.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrLaunchAccountPortal, @params);
        _ptrLaunchAccountPortal.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetClientSecret
    // 0xCDB360
    // (Native | Public)
    public unsafe class GetClientSecret_Parameters : BaseObject {
        public GetClientSecret_Parameters() { }
        public GetClientSecret_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetClientSecret.ReturnValue
        // 0x0 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetClientSecret;
    public FString GetClientSecret() {
        _ptrGetClientSecret ??= FindFunction("Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetClientSecret");

        var @params = stackalloc byte[16];

        _ptrGetClientSecret.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetClientSecret, @params);
        _ptrGetClientSecret.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetClientID
    // 0x67CBD0
    // (Native | Public)
    public unsafe class GetClientID_Parameters : BaseObject {
        public GetClientID_Parameters() { }
        public GetClientID_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetClientID.ReturnValue
        // 0x0 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetClientID;
    public FString GetClientID() {
        _ptrGetClientID ??= FindFunction("Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetClientID");

        var @params = stackalloc byte[16];

        _ptrGetClientID.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetClientID, @params);
        _ptrGetClientID.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetClientCredentials
    // 0xCDB2B0
    // (Native | Public)
    public unsafe class GetClientCredentials_Parameters : BaseObject {
        public GetClientCredentials_Parameters() { }
        public GetClientCredentials_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetClientCredentials.ReturnValue
        // 0x0 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetClientCredentials;
    public FString GetClientCredentials() {
        _ptrGetClientCredentials ??= FindFunction("Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetClientCredentials");

        var @params = stackalloc byte[16];

        _ptrGetClientCredentials.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetClientCredentials, @params);
        _ptrGetClientCredentials.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetContinuanceToken
    // 0xCDB1C0
    // (Native | Public)
    public unsafe class GetContinuanceToken_Parameters : BaseObject {
        public GetContinuanceToken_Parameters() { }
        public GetContinuanceToken_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetContinuanceToken.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StrProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetContinuanceToken.ReturnValue
        // 0x8 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrGetContinuanceToken;
    public FString GetContinuanceToken(byte LocalUserNum) {
        _ptrGetContinuanceToken ??= FindFunction("Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetContinuanceToken");

        var @params = stackalloc byte[17];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        _ptrGetContinuanceToken.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetContinuanceToken, @params);
        _ptrGetContinuanceToken.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.UseRefreshToken
    // 0xCDB0D0
    // (Native | Public)
    public unsafe class UseRefreshToken_Parameters : BaseObject {
        public UseRefreshToken_Parameters() { }
        public UseRefreshToken_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.UseRefreshToken.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StrProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.UseRefreshToken.RefreshToken
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString RefreshToken {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.UseRefreshToken.ReturnValue
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
    private static UFunction _ptrUseRefreshToken;
    public bool UseRefreshToken(byte LocalUserNum, FString RefreshToken) {
        _ptrUseRefreshToken ??= FindFunction("Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.UseRefreshToken");

        var @params = stackalloc byte[21];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)RefreshToken.Pointer, @params + 8, 16, 16);

        _ptrUseRefreshToken.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrUseRefreshToken, @params);
        _ptrUseRefreshToken.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetRefreshToken
    // 0xCDAFE0
    // (Native | Public)
    public unsafe class GetRefreshToken_Parameters : BaseObject {
        public GetRefreshToken_Parameters() { }
        public GetRefreshToken_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetRefreshToken.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StrProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetRefreshToken.ReturnValue
        // 0x8 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrGetRefreshToken;
    public FString GetRefreshToken(byte LocalUserNum) {
        _ptrGetRefreshToken ??= FindFunction("Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.GetRefreshToken");

        var @params = stackalloc byte[17];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        _ptrGetRefreshToken.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetRefreshToken, @params);
        _ptrGetRefreshToken.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.RequestPinGrantCode
    // 0xCDAF50
    // (Native | Public)
    public unsafe class RequestPinGrantCode_Parameters : BaseObject {
        public RequestPinGrantCode_Parameters() { }
        public RequestPinGrantCode_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.RequestPinGrantCode.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.RequestPinGrantCode.ReturnValue
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
    private static UFunction _ptrRequestPinGrantCode;
    public bool RequestPinGrantCode(byte LocalUserNum) {
        _ptrRequestPinGrantCode ??= FindFunction("Function OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS.RequestPinGrantCode");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        _ptrRequestPinGrantCode.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrRequestPinGrantCode, @params);
        _ptrRequestPinGrantCode.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 4);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class OnlineSubsystemEOS.OnlinePersistentAuthInterfaceEOS");
            return _staticClass;
        }
    }
}

// Class OnlineSubsystemEOS.OnlinePlayerInterfaceEOS
// 0x650 (0x60 - 0x6B0)
// (Compiled | Config | Parsed | Localized | Native)
public unsafe partial class UOnlinePlayerInterfaceEOS : UObject {
    public UOnlinePlayerInterfaceEOS() { }
    public UOnlinePlayerInterfaceEOS(nint pointer) : base(pointer) { }


    // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AuthHandle
    // 0x60 (0x8)
    // (Const | Native | Transient)
    public nint AuthHandle {
        get => *(nint*)(Pointer + 96);
        set => *(nint*)(Pointer + 96) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.FriendsHandle
    // 0x68 (0x8)
    // (Const | Native | Transient)
    public nint FriendsHandle {
        get => *(nint*)(Pointer + 104);
        set => *(nint*)(Pointer + 104) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UserInfoHandle
    // 0x70 (0x8)
    // (Const | Native | Transient)
    public nint UserInfoHandle {
        get => *(nint*)(Pointer + 112);
        set => *(nint*)(Pointer + 112) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.PresenceHandle
    // 0x78 (0x8)
    // (Const | Native | Transient)
    public nint PresenceHandle {
        get => *(nint*)(Pointer + 120);
        set => *(nint*)(Pointer + 120) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ConnectHandle
    // 0x80 (0x8)
    // (Const | Native | Transient)
    public nint ConnectHandle {
        get => *(nint*)(Pointer + 128);
        set => *(nint*)(Pointer + 128) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.PDSHandle
    // 0x88 (0x8)
    // (Const | Native | Transient)
    public nint PDSHandle {
        get => *(nint*)(Pointer + 136);
        set => *(nint*)(Pointer + 136) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.EcomHandle
    // 0x90 (0x8)
    // (Const | Native | Transient)
    public nint EcomHandle {
        get => *(nint*)(Pointer + 144);
        set => *(nint*)(Pointer + 144) = value;
    }

    // ObjectProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OwningSubsystem
    // 0x98 (0x8)
    public UOnlineSubsystemCommonImpl OwningSubsystem {
        get {
            var pointer = *(nint*)(Pointer + 152);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 152) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GameInterfaceEOS
    // 0xA0 (0x8)
    public UOnlineGameInterfaceEOS GameInterfaceEOS {
        get {
            var pointer = *(nint*)(Pointer + 160);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 160) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.PersistentAuthInterfaceEOS
    // 0xA8 (0x8)
    public UOnlinePersistentAuthInterfaceEOS PersistentAuthInterfaceEOS {
        get {
            var pointer = *(nint*)(Pointer + 168);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 168) = value.Pointer;
    }

    // ObjectProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.VoiceInterfaceEOS
    // 0xB0 (0x8)
    public UOnlineVoiceInterfaceEOS VoiceInterfaceEOS {
        get {
            var pointer = *(nint*)(Pointer + 176);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 176) = value.Pointer;
    }

    // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.DefaultLocalUser
    // 0xB8 (0x4)
    public int DefaultLocalUser {
        get => *(int*)(Pointer + 184);
        set => *(int*)(Pointer + 184) = value;
    }

    // MISSED OFFSET: 0x4

    // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ProfileDataDirectory
    // 0xC0 (0x10)
    // (Config | NeedCtorLink)
    public FString ProfileDataDirectory {
        get => new(Pointer + 192);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 192), 16, 16);
    }

    // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ProfileDataExtension
    // 0xD0 (0x10)
    // (Config | NeedCtorLink)
    public FString ProfileDataExtension {
        get => new(Pointer + 208);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 208), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadProfileSettingsDelegates
    // 0xE0 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> ReadProfileSettingsDelegates {
        get => new(Pointer + 224, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 224), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.WriteProfileSettingsDelegates
    // 0xF0 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> WriteProfileSettingsDelegates {
        get => new(Pointer + 240, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 240), 16, 16);
    }

    // ObjectProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CachedProfile
    // 0x100 (0x8)
    public UOnlineProfileSettings CachedProfile {
        get {
            var pointer = *(nint*)(Pointer + 256);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 256) = value.Pointer;
    }

    // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.LastProfileSettings
    // 0x108 (0x10)
    // (NeedCtorLink)
    public StructTArray<UOnlinePlayerStorage.FOnlineProfileSetting> LastProfileSettings {
        get => new(Pointer + 264, 40);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 264), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadFriendsDelegates
    // 0x118 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> ReadFriendsDelegates {
        get => new(Pointer + 280, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 280), 16, 16);
    }

    // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.FriendsReadState
    // 0x128 (0x1)
    public UOnlineSubsystem.EOnlineEnumerationReadState FriendsReadState {
        get => *(UOnlineSubsystem.EOnlineEnumerationReadState*)(Pointer + 296);
        set => *(UOnlineSubsystem.EOnlineEnumerationReadState*)(Pointer + 296) = value;
    }

    // MISSED OFFSET: 0x7

    // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.FriendsChangeDelegates
    // 0x130 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> FriendsChangeDelegates {
        get => new(Pointer + 304, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 304), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.LoginFailedDelegates
    // 0x140 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> LoginFailedDelegates {
        get => new(Pointer + 320, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 320), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.LoginCancelledDelegates
    // 0x150 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> LoginCancelledDelegates {
        get => new(Pointer + 336, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 336), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.LogoutCompletedDelegates
    // 0x160 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> LogoutCompletedDelegates {
        get => new(Pointer + 352, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 352), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.MutingChangeDelegates
    // 0x170 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> MutingChangeDelegates {
        get => new(Pointer + 368, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 368), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.StatusMappings
    // 0x180 (0x10)
    // (Const | Config | NeedCtorLink)
    public StructTArray<FOnlineStatusMappingEOS> StatusMappings {
        get => new(Pointer + 384, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 384), 16, 16);
    }

    // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.DefaultStatus
    // 0x190 (0x10)
    // (Const | Localized | NeedCtorLink)
    public FString DefaultStatus {
        get => new(Pointer + 400);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 400), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReceivedGameInviteDelegates
    // 0x1A0 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> ReceivedGameInviteDelegates {
        get => new(Pointer + 416, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 416), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CachedFriendMessages
    // 0x1B0 (0x10)
    // (NeedCtorLink)
    public StructTArray<UOnlineSubsystem.FOnlineFriendMessage> CachedFriendMessages {
        get => new(Pointer + 432, 112);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 432), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.JoinFriendGameCompleteDelegates
    // 0x1C0 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> JoinFriendGameCompleteDelegates {
        get => new(Pointer + 448, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 448), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AchievementDelegates
    // 0x1D0 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> AchievementDelegates {
        get => new(Pointer + 464, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 464), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AchievementReadDelegates
    // 0x1E0 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> AchievementReadDelegates {
        get => new(Pointer + 480, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 480), 16, 16);
    }

    // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AchievementsHandle
    // 0x1F0 (0x8)
    // (Const | Native | Transient)
    public nint AchievementsHandle {
        get => *(nint*)(Pointer + 496);
        set => *(nint*)(Pointer + 496) = value;
    }

    // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.LoginChangeDelegates
    // 0x1F8 (0x10)
    // (Transient | NeedCtorLink)
    public StructTArray<FScriptDelegate> LoginChangeDelegates {
        get => new(Pointer + 504, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 504), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReceivedPinGrantDelegates
    // 0x208 (0x10)
    // (Transient | NeedCtorLink)
    public StructTArray<FScriptDelegate> ReceivedPinGrantDelegates {
        get => new(Pointer + 520, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 520), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.BlockListUpdatedDelegates
    // 0x218 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> BlockListUpdatedDelegates {
        get => new(Pointer + 536, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 536), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.PlayerBlockedDelegates
    // 0x228 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> PlayerBlockedDelegates {
        get => new(Pointer + 552, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 552), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.PlayerUnblockedDelegates
    // 0x238 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> PlayerUnblockedDelegates {
        get => new(Pointer + 568, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 568), 16, 16);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnBlockListUpdated__Delegate
    // 0x248 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnBlockListUpdated__Delegate {
        get => new(Pointer + 584);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 584), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnPlayerBlocked__Delegate
    // 0x260 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnPlayerBlocked__Delegate {
        get => new(Pointer + 608);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 608), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnPlayerUnblocked__Delegate
    // 0x278 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnPlayerUnblocked__Delegate {
        get => new(Pointer + 632);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 632), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnLoginChange__Delegate
    // 0x290 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnLoginChange__Delegate {
        get => new(Pointer + 656);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 656), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnLoginCancelled__Delegate
    // 0x2A8 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnLoginCancelled__Delegate {
        get => new(Pointer + 680);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 680), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnMutingChange__Delegate
    // 0x2C0 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnMutingChange__Delegate {
        get => new(Pointer + 704);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 704), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnFriendsChange__Delegate
    // 0x2D8 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnFriendsChange__Delegate {
        get => new(Pointer + 728);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 728), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnLoginFailed__Delegate
    // 0x2F0 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnLoginFailed__Delegate {
        get => new(Pointer + 752);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 752), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnReceievedPinGrantCode__Delegate
    // 0x308 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnReceievedPinGrantCode__Delegate {
        get => new(Pointer + 776);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 776), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnLogoutCompleted__Delegate
    // 0x320 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnLogoutCompleted__Delegate {
        get => new(Pointer + 800);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 800), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnReadProfileSettingsComplete__Delegate
    // 0x338 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnReadProfileSettingsComplete__Delegate {
        get => new(Pointer + 824);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 824), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnWriteProfileSettingsComplete__Delegate
    // 0x350 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnWriteProfileSettingsComplete__Delegate {
        get => new(Pointer + 848);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 848), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnReadFriendsComplete__Delegate
    // 0x368 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnReadFriendsComplete__Delegate {
        get => new(Pointer + 872);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 872), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnKeyboardInputComplete__Delegate
    // 0x380 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnKeyboardInputComplete__Delegate {
        get => new(Pointer + 896);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 896), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnAddFriendComplete__Delegate
    // 0x398 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnAddFriendComplete__Delegate {
        get => new(Pointer + 920);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 920), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnQueryUserByDisplayName__Delegate
    // 0x3B0 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnQueryUserByDisplayName__Delegate {
        get => new(Pointer + 944);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 944), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnAddFriendByNameComplete__Delegate
    // 0x3C8 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnAddFriendByNameComplete__Delegate {
        get => new(Pointer + 968);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 968), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnAcceptFriendInviteComplete__Delegate
    // 0x3E0 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnAcceptFriendInviteComplete__Delegate {
        get => new(Pointer + 992);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 992), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnDenyFriendInviteComplete__Delegate
    // 0x3F8 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnDenyFriendInviteComplete__Delegate {
        get => new(Pointer + 1016);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1016), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnRemoveFriendComplete__Delegate
    // 0x410 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnRemoveFriendComplete__Delegate {
        get => new(Pointer + 1040);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1040), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnFriendInviteReceived__Delegate
    // 0x428 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnFriendInviteReceived__Delegate {
        get => new(Pointer + 1064);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1064), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnFriendInviteCanceled__Delegate
    // 0x440 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnFriendInviteCanceled__Delegate {
        get => new(Pointer + 1088);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1088), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnReceivedGameInvite__Delegate
    // 0x458 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnReceivedGameInvite__Delegate {
        get => new(Pointer + 1112);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1112), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnJoinFriendGameComplete__Delegate
    // 0x470 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnJoinFriendGameComplete__Delegate {
        get => new(Pointer + 1136);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1136), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnFriendMessageReceived__Delegate
    // 0x488 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnFriendMessageReceived__Delegate {
        get => new(Pointer + 1160);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1160), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnRequestNativePlatformAuthTicketComplete__Delegate
    // 0x4A0 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnRequestNativePlatformAuthTicketComplete__Delegate {
        get => new(Pointer + 1184);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1184), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnReadPlayerStorageComplete__Delegate
    // 0x4B8 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnReadPlayerStorageComplete__Delegate {
        get => new(Pointer + 1208);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1208), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnReadPlayerStorageForNetIdComplete__Delegate
    // 0x4D0 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnReadPlayerStorageForNetIdComplete__Delegate {
        get => new(Pointer + 1232);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1232), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnWritePlayerStorageComplete__Delegate
    // 0x4E8 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnWritePlayerStorageComplete__Delegate {
        get => new(Pointer + 1256);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1256), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnReadCrossTitleProfileSettingsComplete__Delegate
    // 0x500 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnReadCrossTitleProfileSettingsComplete__Delegate {
        get => new(Pointer + 1280);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1280), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnUserSignInComplete__Delegate
    // 0x518 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnUserSignInComplete__Delegate {
        get => new(Pointer + 1304);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1304), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__CanPlayOnlineChanged__Delegate
    // 0x530 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __CanPlayOnlineChanged__Delegate {
        get => new(Pointer + 1328);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1328), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnSaveDataNoSpaceDialogComplete__Delegate
    // 0x548 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnSaveDataNoSpaceDialogComplete__Delegate {
        get => new(Pointer + 1352);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1352), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnRegisteredController__Delegate
    // 0x560 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnRegisteredController__Delegate {
        get => new(Pointer + 1376);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1376), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnUnregisteredController__Delegate
    // 0x578 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnUnregisteredController__Delegate {
        get => new(Pointer + 1400);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1400), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnInputAPIChanged__Delegate
    // 0x590 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnInputAPIChanged__Delegate {
        get => new(Pointer + 1424);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1424), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnLoginStatusChange__Delegate
    // 0x5A8 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnLoginStatusChange__Delegate {
        get => new(Pointer + 1448);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1448), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnUserSwitchComplete__Delegate
    // 0x5C0 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnUserSwitchComplete__Delegate {
        get => new(Pointer + 1472);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1472), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnDeviceSelectionComplete__Delegate
    // 0x5D8 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnDeviceSelectionComplete__Delegate {
        get => new(Pointer + 1496);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1496), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnProfileDataChanged__Delegate
    // 0x5F0 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnProfileDataChanged__Delegate {
        get => new(Pointer + 1520);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1520), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnUnlockAchievementComplete__Delegate
    // 0x608 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnUnlockAchievementComplete__Delegate {
        get => new(Pointer + 1544);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1544), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnReadAchievementsComplete__Delegate
    // 0x620 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnReadAchievementsComplete__Delegate {
        get => new(Pointer + 1568);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1568), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnAvatarChange__Delegate
    // 0x638 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnAvatarChange__Delegate {
        get => new(Pointer + 1592);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1592), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__FriendPresenceChange__Delegate
    // 0x650 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __FriendPresenceChange__Delegate {
        get => new(Pointer + 1616);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1616), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnPlayerCountryRetrieved__Delegate
    // 0x668 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnPlayerCountryRetrieved__Delegate {
        get => new(Pointer + 1640);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1640), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__OnSanitizeStringComplete__Delegate
    // 0x680 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnSanitizeStringComplete__Delegate {
        get => new(Pointer + 1664);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1664), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.__EpicIDToPlatformIDCallback__Delegate
    // 0x698 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EpicIDToPlatformIDCallback__Delegate {
        get => new(Pointer + 1688);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 1688), 24, 24);
    }


    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadBlockList
    // 0x3750E0
    // (Final | Public)
    public unsafe class ReadBlockList_Parameters : BaseObject {
        public ReadBlockList_Parameters() { }
        public ReadBlockList_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadBlockList.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadBlockList.ReturnValue
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
    private static UFunction _ptrReadBlockList;
    public bool ReadBlockList(byte LocalUserNum) {
        _ptrReadBlockList ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadBlockList");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrReadBlockList, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetBlockList
    // 0xCDD710
    // (Final | Native | Public | HasOutParams)
    public unsafe class GetBlockList_Parameters : BaseObject {
        public GetBlockList_Parameters() { }
        public GetBlockList_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetBlockList.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetBlockList.OutBlockList
        // 0x8 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public StructTArray<UOnlineSubsystem.FOnlineFriend> OutBlockList {
            get => new(Pointer + 8, 280);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrGetBlockList;
    public void GetBlockList(byte LocalUserNum, ref StructTArray<UOnlineSubsystem.FOnlineFriend> OutBlockList) {
        _ptrGetBlockList ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetBlockList");

        var @params = stackalloc byte[17];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)OutBlockList.Pointer, @params + 8, 16, 16);

        _ptrGetBlockList.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetBlockList, @params);
        _ptrGetBlockList.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _OutBlockListPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_OutBlockListPtr, 16, 16);
        OutBlockList = new(_OutBlockListPtr, 280) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddPlayerUnblockedDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddPlayerUnblockedDelegate_Parameters : BaseObject {
        public AddPlayerUnblockedDelegate_Parameters() { }
        public AddPlayerUnblockedDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddPlayerUnblockedDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddPlayerUnblockedDelegate.InDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddPlayerUnblockedDelegate;
    public void AddPlayerUnblockedDelegate(byte LocalUserNum, FScriptDelegate InDelegate) {
        _ptrAddPlayerUnblockedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddPlayerUnblockedDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddPlayerUnblockedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddPlayerBlockedDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddPlayerBlockedDelegate_Parameters : BaseObject {
        public AddPlayerBlockedDelegate_Parameters() { }
        public AddPlayerBlockedDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddPlayerBlockedDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddPlayerBlockedDelegate.InDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddPlayerBlockedDelegate;
    public void AddPlayerBlockedDelegate(byte LocalUserNum, FScriptDelegate InDelegate) {
        _ptrAddPlayerBlockedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddPlayerBlockedDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddPlayerBlockedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddBlockListUpdatedDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddBlockListUpdatedDelegate_Parameters : BaseObject {
        public AddBlockListUpdatedDelegate_Parameters() { }
        public AddBlockListUpdatedDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddBlockListUpdatedDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddBlockListUpdatedDelegate.InDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddBlockListUpdatedDelegate;
    public void AddBlockListUpdatedDelegate(byte LocalUserNum, FScriptDelegate InDelegate) {
        _ptrAddBlockListUpdatedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddBlockListUpdatedDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddBlockListUpdatedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.EpicIDToPlatformID
    // 0xCDD530
    // (Final | Native | Public)
    public unsafe class EpicIDToPlatformID_Parameters : BaseObject {
        public EpicIDToPlatformID_Parameters() { }
        public EpicIDToPlatformID_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.EpicIDToPlatformID.EpicAccountId
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId EpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.EpicIDToPlatformID.TargetPlatform
        // 0x48 (0x1)
        // (Param)
        public U_Types_Core.OnlinePlatform TargetPlatform {
            get => *(U_Types_Core.OnlinePlatform*)(Pointer + 72);
            set => *(U_Types_Core.OnlinePlatform*)(Pointer + 72) = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.EpicIDToPlatformID.Callback
        // 0x50 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate Callback {
            get => new(Pointer + 80);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 80), 24, 24);
        }
    }
    private static UFunction _ptrEpicIDToPlatformID;
    public void EpicIDToPlatformID(U_Types_Core.FUniqueNetId EpicAccountId, U_Types_Core.OnlinePlatform TargetPlatform, FScriptDelegate Callback) {
        _ptrEpicIDToPlatformID ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.EpicIDToPlatformID");

        var @params = stackalloc byte[97];
        System.Buffer.MemoryCopy((void*)EpicAccountId.Pointer, @params, 72, 72);
        System.Buffer.MemoryCopy(&TargetPlatform, @params + 72, 1, 1);
        System.Buffer.MemoryCopy((void*)Callback.Pointer, @params + 80, 24, 24);

        _ptrEpicIDToPlatformID.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrEpicIDToPlatformID, @params);
        _ptrEpicIDToPlatformID.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.EpicIDToPlatformIDCallback
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EpicIDToPlatformIDCallback_Parameters : BaseObject {
        public EpicIDToPlatformIDCallback_Parameters() { }
        public EpicIDToPlatformIDCallback_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.EpicIDToPlatformIDCallback.PlatformAccountId
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlatformAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.EpicIDToPlatformIDCallback.Error
        // 0x48 (0x10)
        // (Param | NeedCtorLink)
        public FString Error {
            get => new(Pointer + 72);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 72), 16, 16);
        }
    }
    private static UFunction _ptrEpicIDToPlatformIDCallback;
    public void EpicIDToPlatformIDCallback(U_Types_Core.FUniqueNetId PlatformAccountId, FString Error) {
        _ptrEpicIDToPlatformIDCallback ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.EpicIDToPlatformIDCallback");

        var @params = stackalloc byte[88];
        System.Buffer.MemoryCopy((void*)PlatformAccountId.Pointer, @params, 72, 72);
        System.Buffer.MemoryCopy((void*)Error.Pointer, @params + 72, 16, 16);

        ProcessEvent(_ptrEpicIDToPlatformIDCallback, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetEpicAccountId
    // 0xCDD390
    // (Final | Native | Public)
    public unsafe class GetEpicAccountId_Parameters : BaseObject {
        public GetEpicAccountId_Parameters() { }
        public GetEpicAccountId_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetEpicAccountId.PlatformId
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlatformId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetEpicAccountId.ReturnValue
        // 0x48 (0x48)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public U_Types_Core.FUniqueNetId ReturnValue {
            get => new(Pointer + 72);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 72), 72, 72);
        }
    }
    private static UFunction _ptrGetEpicAccountId;
    public U_Types_Core.FUniqueNetId GetEpicAccountId(U_Types_Core.FUniqueNetId PlatformId) {
        _ptrGetEpicAccountId ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetEpicAccountId");

        var @params = stackalloc byte[144];
        System.Buffer.MemoryCopy((void*)PlatformId.Pointer, @params, 72, 72);

        _ptrGetEpicAccountId.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetEpicAccountId, @params);
        _ptrGetEpicAccountId.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(72);
        System.Buffer.MemoryCopy(@params + 72, (void*)_ReturnValuePtr, 72, 72);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowInviteUI
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class ShowInviteUI_Parameters : BaseObject {
        public ShowInviteUI_Parameters() { }
        public ShowInviteUI_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowInviteUI.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowInviteUI.InviteText
        // 0x8 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString InviteText {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowInviteUI.ReturnValue
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
    private static UFunction _ptrShowInviteUI;
    public bool ShowInviteUI(byte LocalUserNum, FString InviteText = null) {
        _ptrShowInviteUI ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowInviteUI");

        var @params = stackalloc byte[21];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        if (InviteText != null) System.Buffer.MemoryCopy((void*)InviteText.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrShowInviteUI, @params);

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowGamerCardUI
    // 0x3750E0
    // (Final | Public)
    public unsafe class ShowGamerCardUI_Parameters : BaseObject {
        public ShowGamerCardUI_Parameters() { }
        public ShowGamerCardUI_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowGamerCardUI.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowGamerCardUI.PlayerID
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowGamerCardUI.ReturnValue
        // 0x50 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 80) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 80) |= 0x1;
                else *(uint*)(Pointer + 80) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrShowGamerCardUI;
    public bool ShowGamerCardUI(byte LocalUserNum, U_Types_Core.FUniqueNetId PlayerID) {
        _ptrShowGamerCardUI ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowGamerCardUI");

        var @params = stackalloc byte[77];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params + 8, 72, 72);

        ProcessEvent(_ptrShowGamerCardUI, @params);

        return *(bool*)(@params + 80);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetRichPresence
    // 0xCDD260
    // (Final | Native | Public)
    public unsafe class SetRichPresence_Parameters : BaseObject {
        public SetRichPresence_Parameters() { }
        public SetRichPresence_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetRichPresence.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetRichPresence.PresenceString
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString PresenceString {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetRichPresence.GameDataString
        // 0x18 (0x10)
        // (Param | NeedCtorLink)
        public FString GameDataString {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }
    }
    private static UFunction _ptrSetRichPresence;
    public void SetRichPresence(byte LocalUserNum, FString PresenceString, FString GameDataString) {
        _ptrSetRichPresence ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetRichPresence");

        var @params = stackalloc byte[33];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)PresenceString.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy((void*)GameDataString.Pointer, @params + 24, 16, 16);

        _ptrSetRichPresence.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetRichPresence, @params);
        _ptrSetRichPresence.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetFriendPresence
    // 0xCDD150
    // (Final | Native | Public | HasOutParams)
    public unsafe class GetFriendPresence_Parameters : BaseObject {
        public GetFriendPresence_Parameters() { }
        public GetFriendPresence_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetFriendPresence.FriendData
        // 0x0 (0x118)
        // (Param | OutParam | NeedCtorLink)
        public UOnlineSubsystem.FOnlineFriend FriendData {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 280, 280);
        }
    }
    private static UFunction _ptrGetFriendPresence;
    public void GetFriendPresence(ref UOnlineSubsystem.FOnlineFriend FriendData) {
        _ptrGetFriendPresence ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetFriendPresence");

        var @params = stackalloc byte[280];
        System.Buffer.MemoryCopy((void*)FriendData.Pointer, @params, 280, 280);

        _ptrGetFriendPresence.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetFriendPresence, @params);
        _ptrGetFriendPresence.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _FriendDataPtr = Marshal.AllocHGlobal(280);
        System.Buffer.MemoryCopy(@params, (void*)_FriendDataPtr, 280, 280);
        FriendData = new(_FriendDataPtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RecordPlayersRecentlyMet
    // 0x3750E0
    // (Final | Public | HasOutParams)
    public unsafe class RecordPlayersRecentlyMet_Parameters : BaseObject {
        public RecordPlayersRecentlyMet_Parameters() { }
        public RecordPlayersRecentlyMet_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RecordPlayersRecentlyMet.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RecordPlayersRecentlyMet.Players
        // 0x8 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public StructTArray<U_Types_Core.FUniqueNetId> Players {
            get => new(Pointer + 8, 72);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RecordPlayersRecentlyMet.GameDescription
        // 0x18 (0x10)
        // (Param | NeedCtorLink)
        public FString GameDescription {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RecordPlayersRecentlyMet.ReturnValue
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
    private static UFunction _ptrRecordPlayersRecentlyMet;
    public bool RecordPlayersRecentlyMet(byte LocalUserNum, ref StructTArray<U_Types_Core.FUniqueNetId> Players, FString GameDescription) {
        _ptrRecordPlayersRecentlyMet ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RecordPlayersRecentlyMet");

        var @params = stackalloc byte[37];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)Players.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy((void*)GameDescription.Pointer, @params + 24, 16, 16);

        ProcessEvent(_ptrRecordPlayersRecentlyMet, @params);

        var _PlayersPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_PlayersPtr, 16, 16);
        Players = new(_PlayersPtr, 72) { Allocated = true };

        return *(bool*)(@params + 40);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.WordFilterSanitizeString
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class WordFilterSanitizeString_Parameters : BaseObject {
        public WordFilterSanitizeString_Parameters() { }
        public WordFilterSanitizeString_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.WordFilterSanitizeString.Comment
        // 0x0 (0x10)
        // (Const | Param | NeedCtorLink)
        public FString Comment {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.WordFilterSanitizeString.SanitizeDelegate
        // 0x10 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate SanitizeDelegate {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 24, 24);
        }

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.WordFilterSanitizeString.PlayerID
        // 0x28 (0x48)
        // (OptionalParam | Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer + 40);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 40), 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.WordFilterSanitizeString.ReturnValue
        // 0x70 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 112) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 112) |= 0x1;
                else *(uint*)(Pointer + 112) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrWordFilterSanitizeString;
    public bool WordFilterSanitizeString(FString Comment, FScriptDelegate SanitizeDelegate, U_Types_Core.FUniqueNetId PlayerID = null) {
        _ptrWordFilterSanitizeString ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.WordFilterSanitizeString");

        var @params = stackalloc byte[116];
        System.Buffer.MemoryCopy((void*)Comment.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)SanitizeDelegate.Pointer, @params + 16, 24, 24);
        if (PlayerID != null) System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params + 40, 72, 72);

        ProcessEvent(_ptrWordFilterSanitizeString, @params);

        return *(bool*)(@params + 112);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnSanitizeStringComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnSanitizeStringComplete_Parameters : BaseObject {
        public OnSanitizeStringComplete_Parameters() { }
        public OnSanitizeStringComplete_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnSanitizeStringComplete.Result
        // 0x0 (0x38)
        // (Param | NeedCtorLink)
        public UOnlineSubsystem.FWordFilterResult Result {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 56, 56);
        }
    }
    private static UFunction _ptrOnSanitizeStringComplete;
    public void OnSanitizeStringComplete(UOnlineSubsystem.FWordFilterResult Result) {
        _ptrOnSanitizeStringComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnSanitizeStringComplete");

        var @params = stackalloc byte[56];
        System.Buffer.MemoryCopy((void*)Result.Pointer, @params, 56, 56);

        ProcessEvent(_ptrOnSanitizeStringComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.HideKeyboardUI
    // 0x3750E0
    // (Final | Public)
    public unsafe class HideKeyboardUI_Parameters : BaseObject {
        public HideKeyboardUI_Parameters() { }
        public HideKeyboardUI_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.HideKeyboardUI.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.HideKeyboardUI.ReturnValue
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
    private static UFunction _ptrHideKeyboardUI;
    public bool HideKeyboardUI(byte LocalUserNum) {
        _ptrHideKeyboardUI ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.HideKeyboardUI");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrHideKeyboardUI, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadPlayerCountryDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearReadPlayerCountryDelegate_Parameters : BaseObject {
        public ClearReadPlayerCountryDelegate_Parameters() { }
        public ClearReadPlayerCountryDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadPlayerCountryDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadPlayerCountryDelegate.ReadPlayerCountryDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ReadPlayerCountryDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearReadPlayerCountryDelegate;
    public void ClearReadPlayerCountryDelegate(byte LocalUserNum, FScriptDelegate ReadPlayerCountryDelegate) {
        _ptrClearReadPlayerCountryDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadPlayerCountryDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)ReadPlayerCountryDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearReadPlayerCountryDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadPlayerCountryDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddReadPlayerCountryDelegate_Parameters : BaseObject {
        public AddReadPlayerCountryDelegate_Parameters() { }
        public AddReadPlayerCountryDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadPlayerCountryDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadPlayerCountryDelegate.ReadPlayerCountryDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ReadPlayerCountryDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddReadPlayerCountryDelegate;
    public void AddReadPlayerCountryDelegate(byte LocalUserNum, FScriptDelegate ReadPlayerCountryDelegate) {
        _ptrAddReadPlayerCountryDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadPlayerCountryDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)ReadPlayerCountryDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddReadPlayerCountryDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnPlayerCountryRetrieved
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnPlayerCountryRetrieved_Parameters : BaseObject {
        public OnPlayerCountryRetrieved_Parameters() { }
        public OnPlayerCountryRetrieved_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnPlayerCountryRetrieved.PlayerID
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnPlayerCountryRetrieved.Country
        // 0x48 (0x10)
        // (Param | NeedCtorLink)
        public FString Country {
            get => new(Pointer + 72);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 72), 16, 16);
        }
    }
    private static UFunction _ptrOnPlayerCountryRetrieved;
    public void OnPlayerCountryRetrieved(U_Types_Core.FUniqueNetId PlayerID, FString Country) {
        _ptrOnPlayerCountryRetrieved ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnPlayerCountryRetrieved");

        var @params = stackalloc byte[88];
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params, 72, 72);
        System.Buffer.MemoryCopy((void*)Country.Pointer, @params + 72, 16, 16);

        ProcessEvent(_ptrOnPlayerCountryRetrieved, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetPlayerCountry
    // 0x3750E0
    // (Final | Public)
    public unsafe class GetPlayerCountry_Parameters : BaseObject {
        public GetPlayerCountry_Parameters() { }
        public GetPlayerCountry_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetPlayerCountry.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }
    }
    private static UFunction _ptrGetPlayerCountry;
    public void GetPlayerCountry(byte LocalUserNum) {
        _ptrGetPlayerCountry ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetPlayerCountry");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrGetPlayerCountry, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearAvatarChangeDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearAvatarChangeDelegate_Parameters : BaseObject {
        public ClearAvatarChangeDelegate_Parameters() { }
        public ClearAvatarChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearAvatarChangeDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearAvatarChangeDelegate.AvatarDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate AvatarDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearAvatarChangeDelegate;
    public void ClearAvatarChangeDelegate(byte LocalUserNum, FScriptDelegate AvatarDelegate) {
        _ptrClearAvatarChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearAvatarChangeDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)AvatarDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearAvatarChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddAvatarChangeDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddAvatarChangeDelegate_Parameters : BaseObject {
        public AddAvatarChangeDelegate_Parameters() { }
        public AddAvatarChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddAvatarChangeDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddAvatarChangeDelegate.AvatarDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate AvatarDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddAvatarChangeDelegate;
    public void AddAvatarChangeDelegate(byte LocalUserNum, FScriptDelegate AvatarDelegate) {
        _ptrAddAvatarChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddAvatarChangeDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)AvatarDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddAvatarChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearFriendPresenceChangeDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearFriendPresenceChangeDelegate_Parameters : BaseObject {
        public ClearFriendPresenceChangeDelegate_Parameters() { }
        public ClearFriendPresenceChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearFriendPresenceChangeDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearFriendPresenceChangeDelegate.PresenceDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate PresenceDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearFriendPresenceChangeDelegate;
    public void ClearFriendPresenceChangeDelegate(byte LocalUserNum, FScriptDelegate PresenceDelegate) {
        _ptrClearFriendPresenceChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearFriendPresenceChangeDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)PresenceDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearFriendPresenceChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendPresenceChangeDelegate
    // 0x3750E0
    // (Final | Defined | Event | Public)
    public unsafe class AddFriendPresenceChangeDelegate_Parameters : BaseObject {
        public AddFriendPresenceChangeDelegate_Parameters() { }
        public AddFriendPresenceChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendPresenceChangeDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendPresenceChangeDelegate.PresenceDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate PresenceDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddFriendPresenceChangeDelegate;
    public void AddFriendPresenceChangeDelegate(byte LocalUserNum, FScriptDelegate PresenceDelegate) {
        _ptrAddFriendPresenceChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendPresenceChangeDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)PresenceDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddFriendPresenceChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.FriendPresenceChange
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class FriendPresenceChange_Parameters : BaseObject {
        public FriendPresenceChange_Parameters() { }
        public FriendPresenceChange_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.FriendPresenceChange.PlayerID
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }
    }
    private static UFunction _ptrFriendPresenceChange;
    public void FriendPresenceChange(U_Types_Core.FUniqueNetId PlayerID) {
        _ptrFriendPresenceChange ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.FriendPresenceChange");

        var @params = stackalloc byte[72];
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params, 72, 72);

        ProcessEvent(_ptrFriendPresenceChange, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnAvatarChange
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnAvatarChange_Parameters : BaseObject {
        public OnAvatarChange_Parameters() { }
        public OnAvatarChange_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnAvatarChange.PlayerID
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }
    }
    private static UFunction _ptrOnAvatarChange;
    public void OnAvatarChange(U_Types_Core.FUniqueNetId PlayerID) {
        _ptrOnAvatarChange ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnAvatarChange");

        var @params = stackalloc byte[72];
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params, 72, 72);

        ProcessEvent(_ptrOnAvatarChange, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UnlockAchievement
    // 0xCDD060
    // (Final | Native | HasOptionalParams | Public)
    public unsafe class UnlockAchievement_Parameters : BaseObject {
        public UnlockAchievement_Parameters() { }
        public UnlockAchievement_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UnlockAchievement.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UnlockAchievement.AchievementId
        // 0x4 (0x4)
        // (Param)
        public int AchievementId {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }

        // FloatProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UnlockAchievement.PercentComplete
        // 0x8 (0x4)
        // (OptionalParam | Param)
        public float PercentComplete {
            get => *(float*)(Pointer + 8);
            set => *(float*)(Pointer + 8) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UnlockAchievement.ReturnValue
        // 0xC (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 12) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 12) |= 0x1;
                else *(uint*)(Pointer + 12) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrUnlockAchievement;
    public bool UnlockAchievement(byte LocalUserNum, int AchievementId, float PercentComplete = 0) {
        _ptrUnlockAchievement ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UnlockAchievement");

        var @params = stackalloc byte[13];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&AchievementId, @params + 4, 4, 4);
        System.Buffer.MemoryCopy(&PercentComplete, @params + 8, 4, 4);

        _ptrUnlockAchievement.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrUnlockAchievement, @params);
        _ptrUnlockAchievement.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 12);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadAchievements
    // 0xCDCF10
    // (Final | Native | HasOptionalParams | Public)
    public unsafe class ReadAchievements_Parameters : BaseObject {
        public ReadAchievements_Parameters() { }
        public ReadAchievements_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadAchievements.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadAchievements.TitleId
        // 0x4 (0x4)
        // (OptionalParam | Param)
        public int TitleId {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadAchievements.bShouldReadText
        // 0x8 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bShouldReadText {
            get => (*(uint*)(Pointer + 8) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 8) |= 0x1;
                else *(uint*)(Pointer + 8) &= ~(uint)0x1;
            }
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadAchievements.bShouldReadImages
        // 0xC (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bShouldReadImages {
            get => (*(uint*)(Pointer + 12) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 12) |= 0x1;
                else *(uint*)(Pointer + 12) &= ~(uint)0x1;
            }
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadAchievements.ReturnValue
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
    private static UFunction _ptrReadAchievements;
    public bool ReadAchievements(byte LocalUserNum, int TitleId = 0, bool bShouldReadText = false, bool bShouldReadImages = false) {
        _ptrReadAchievements ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadAchievements");

        var @params = stackalloc byte[17];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&TitleId, @params + 4, 4, 4);
        System.Buffer.MemoryCopy(&bShouldReadText, @params + 8, 4, 4);
        System.Buffer.MemoryCopy(&bShouldReadImages, @params + 12, 4, 4);

        _ptrReadAchievements.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrReadAchievements, @params);
        _ptrReadAchievements.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetAchievements
    // 0xCDCD90
    // (Final | Native | HasOptionalParams | Public | HasOutParams)
    public unsafe class GetAchievements_Parameters : BaseObject {
        public GetAchievements_Parameters() { }
        public GetAchievements_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetAchievements.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetAchievements.Achievements
        // 0x8 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public StructTArray<UOnlineSubsystem.FAchievementDetails> Achievements {
            get => new(Pointer + 8, 248);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetAchievements.TitleId
        // 0x18 (0x4)
        // (OptionalParam | Param)
        public int TitleId {
            get => *(int*)(Pointer + 24);
            set => *(int*)(Pointer + 24) = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetAchievements.ReturnValue
        // 0x1C (0x1)
        // (Param | OutParam | ReturnParam)
        public UOnlineSubsystem.EOnlineEnumerationReadState ReturnValue {
            get => *(UOnlineSubsystem.EOnlineEnumerationReadState*)(Pointer + 28);
            set => *(UOnlineSubsystem.EOnlineEnumerationReadState*)(Pointer + 28) = value;
        }
    }
    private static UFunction _ptrGetAchievements;
    public UOnlineSubsystem.EOnlineEnumerationReadState GetAchievements(byte LocalUserNum, ref StructTArray<UOnlineSubsystem.FAchievementDetails> Achievements, int TitleId = 0) {
        _ptrGetAchievements ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetAchievements");

        var @params = stackalloc byte[22];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)Achievements.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy(&TitleId, @params + 24, 4, 4);

        _ptrGetAchievements.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetAchievements, @params);
        _ptrGetAchievements.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _AchievementsPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_AchievementsPtr, 16, 16);
        Achievements = new(_AchievementsPtr, 248) { Allocated = true };

        return *(UOnlineSubsystem.EOnlineEnumerationReadState*)(@params + 28);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadAchievementsCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearReadAchievementsCompleteDelegate_Parameters : BaseObject {
        public ClearReadAchievementsCompleteDelegate_Parameters() { }
        public ClearReadAchievementsCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadAchievementsCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadAchievementsCompleteDelegate.InDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearReadAchievementsCompleteDelegate;
    public void ClearReadAchievementsCompleteDelegate(byte LocalUserNum, FScriptDelegate InDelegate) {
        _ptrClearReadAchievementsCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadAchievementsCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearReadAchievementsCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearUnlockAchievementCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearUnlockAchievementCompleteDelegate_Parameters : BaseObject {
        public ClearUnlockAchievementCompleteDelegate_Parameters() { }
        public ClearUnlockAchievementCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearUnlockAchievementCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearUnlockAchievementCompleteDelegate.InDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearUnlockAchievementCompleteDelegate;
    public void ClearUnlockAchievementCompleteDelegate(byte LocalUserNum, FScriptDelegate InDelegate) {
        _ptrClearUnlockAchievementCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearUnlockAchievementCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearUnlockAchievementCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadAchievementsCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddReadAchievementsCompleteDelegate_Parameters : BaseObject {
        public AddReadAchievementsCompleteDelegate_Parameters() { }
        public AddReadAchievementsCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadAchievementsCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadAchievementsCompleteDelegate.InDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddReadAchievementsCompleteDelegate;
    public void AddReadAchievementsCompleteDelegate(byte LocalUserNum, FScriptDelegate InDelegate) {
        _ptrAddReadAchievementsCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadAchievementsCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddReadAchievementsCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddUnlockAchievementCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddUnlockAchievementCompleteDelegate_Parameters : BaseObject {
        public AddUnlockAchievementCompleteDelegate_Parameters() { }
        public AddUnlockAchievementCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddUnlockAchievementCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddUnlockAchievementCompleteDelegate.InDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddUnlockAchievementCompleteDelegate;
    public void AddUnlockAchievementCompleteDelegate(byte LocalUserNum, FScriptDelegate InDelegate) {
        _ptrAddUnlockAchievementCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddUnlockAchievementCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddUnlockAchievementCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadAchievementsComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnReadAchievementsComplete_Parameters : BaseObject {
        public OnReadAchievementsComplete_Parameters() { }
        public OnReadAchievementsComplete_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadAchievementsComplete.TitleId
        // 0x0 (0x4)
        // (Param)
        public int TitleId {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrOnReadAchievementsComplete;
    public void OnReadAchievementsComplete(int TitleId) {
        _ptrOnReadAchievementsComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadAchievementsComplete");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&TitleId, @params, 4, 4);

        ProcessEvent(_ptrOnReadAchievementsComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnUnlockAchievementComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnUnlockAchievementComplete_Parameters : BaseObject {
        public OnUnlockAchievementComplete_Parameters() { }
        public OnUnlockAchievementComplete_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnUnlockAchievementComplete.bWasSuccessful
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnUnlockAchievementComplete;
    public void OnUnlockAchievementComplete(bool bWasSuccessful) {
        _ptrOnUnlockAchievementComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnUnlockAchievementComplete");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bWasSuccessful, @params, 4, 4);

        ProcessEvent(_ptrOnUnlockAchievementComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowControllerUI
    // 0x3750E0
    // (Final | Public)
    public unsafe class ShowControllerUI_Parameters : BaseObject {
        public ShowControllerUI_Parameters() { }
        public ShowControllerUI_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowControllerUI.ReturnValue
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
    private static UFunction _ptrShowControllerUI;
    public bool ShowControllerUI() {
        _ptrShowControllerUI ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowControllerUI");

        var @params = stackalloc byte[4];

        ProcessEvent(_ptrShowControllerUI, @params);

        return *(bool*)@params;
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetPlayerLanguage
    // 0x3750E0
    // (Final | Public)
    public unsafe class GetPlayerLanguage_Parameters : BaseObject {
        public GetPlayerLanguage_Parameters() { }
        public GetPlayerLanguage_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetPlayerLanguage.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetPlayerLanguage.ReturnValue
        // 0x8 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrGetPlayerLanguage;
    public FString GetPlayerLanguage(byte LocalUserNum) {
        _ptrGetPlayerLanguage ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetPlayerLanguage");

        var @params = stackalloc byte[17];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrGetPlayerLanguage, @params);

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowPlayersUI
    // 0x3750E0
    // (Final | Public)
    public unsafe class ShowPlayersUI_Parameters : BaseObject {
        public ShowPlayersUI_Parameters() { }
        public ShowPlayersUI_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowPlayersUI.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowPlayersUI.ReturnValue
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
    private static UFunction _ptrShowPlayersUI;
    public bool ShowPlayersUI(byte LocalUserNum) {
        _ptrShowPlayersUI ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowPlayersUI");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrShowPlayersUI, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearProfileDataChangedDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearProfileDataChangedDelegate_Parameters : BaseObject {
        public ClearProfileDataChangedDelegate_Parameters() { }
        public ClearProfileDataChangedDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearProfileDataChangedDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearProfileDataChangedDelegate.ProfileDataChangedDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ProfileDataChangedDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearProfileDataChangedDelegate;
    public void ClearProfileDataChangedDelegate(byte LocalUserNum, FScriptDelegate ProfileDataChangedDelegate) {
        _ptrClearProfileDataChangedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearProfileDataChangedDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)ProfileDataChangedDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearProfileDataChangedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddProfileDataChangedDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddProfileDataChangedDelegate_Parameters : BaseObject {
        public AddProfileDataChangedDelegate_Parameters() { }
        public AddProfileDataChangedDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddProfileDataChangedDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddProfileDataChangedDelegate.ProfileDataChangedDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ProfileDataChangedDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddProfileDataChangedDelegate;
    public void AddProfileDataChangedDelegate(byte LocalUserNum, FScriptDelegate ProfileDataChangedDelegate) {
        _ptrAddProfileDataChangedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddProfileDataChangedDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)ProfileDataChangedDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddProfileDataChangedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnProfileDataChanged
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnProfileDataChanged_Parameters : BaseObject {
        public OnProfileDataChanged_Parameters() { }
        public OnProfileDataChanged_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrOnProfileDataChanged;
    public void OnProfileDataChanged() {
        _ptrOnProfileDataChanged ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnProfileDataChanged");

        ProcessEvent(_ptrOnProfileDataChanged, null);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UnlockGamerPicture
    // 0x3750E0
    // (Final | Public)
    public unsafe class UnlockGamerPicture_Parameters : BaseObject {
        public UnlockGamerPicture_Parameters() { }
        public UnlockGamerPicture_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UnlockGamerPicture.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UnlockGamerPicture.PictureId
        // 0x4 (0x4)
        // (Param)
        public int PictureId {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UnlockGamerPicture.ReturnValue
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
    private static UFunction _ptrUnlockGamerPicture;
    public bool UnlockGamerPicture(byte LocalUserNum, int PictureId) {
        _ptrUnlockGamerPicture ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UnlockGamerPicture");

        var @params = stackalloc byte[9];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&PictureId, @params + 4, 4, 4);

        ProcessEvent(_ptrUnlockGamerPicture, @params);

        return *(bool*)(@params + 8);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsDeviceValid
    // 0x3750E0
    // (Final | Public)
    public unsafe class IsDeviceValid_Parameters : BaseObject {
        public IsDeviceValid_Parameters() { }
        public IsDeviceValid_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsDeviceValid.DeviceID
        // 0x0 (0x4)
        // (Param)
        public int DeviceID {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsDeviceValid.ReturnValue
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
    private static UFunction _ptrIsDeviceValid;
    public bool IsDeviceValid(int DeviceID) {
        _ptrIsDeviceValid ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsDeviceValid");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&DeviceID, @params, 4, 4);

        ProcessEvent(_ptrIsDeviceValid, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetDeviceSelectionResults
    // 0x3750E0
    // (Final | Public | HasOutParams)
    public unsafe class GetDeviceSelectionResults_Parameters : BaseObject {
        public GetDeviceSelectionResults_Parameters() { }
        public GetDeviceSelectionResults_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetDeviceSelectionResults.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetDeviceSelectionResults.DeviceName
        // 0x8 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public FString DeviceName {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetDeviceSelectionResults.ReturnValue
        // 0x18 (0x4)
        // (Param | OutParam | ReturnParam)
        public int ReturnValue {
            get => *(int*)(Pointer + 24);
            set => *(int*)(Pointer + 24) = value;
        }
    }
    private static UFunction _ptrGetDeviceSelectionResults;
    public int GetDeviceSelectionResults(byte LocalUserNum, ref FString DeviceName) {
        _ptrGetDeviceSelectionResults ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetDeviceSelectionResults");

        var @params = stackalloc byte[21];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)DeviceName.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrGetDeviceSelectionResults, @params);

        var _DeviceNamePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_DeviceNamePtr, 16, 16);
        DeviceName = new(_DeviceNamePtr) { Allocated = true };

        return *(int*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearDeviceSelectionDoneDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearDeviceSelectionDoneDelegate_Parameters : BaseObject {
        public ClearDeviceSelectionDoneDelegate_Parameters() { }
        public ClearDeviceSelectionDoneDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearDeviceSelectionDoneDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearDeviceSelectionDoneDelegate.DeviceDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate DeviceDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearDeviceSelectionDoneDelegate;
    public void ClearDeviceSelectionDoneDelegate(byte LocalUserNum, FScriptDelegate DeviceDelegate) {
        _ptrClearDeviceSelectionDoneDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearDeviceSelectionDoneDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)DeviceDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearDeviceSelectionDoneDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddDeviceSelectionDoneDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddDeviceSelectionDoneDelegate_Parameters : BaseObject {
        public AddDeviceSelectionDoneDelegate_Parameters() { }
        public AddDeviceSelectionDoneDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddDeviceSelectionDoneDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddDeviceSelectionDoneDelegate.DeviceDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate DeviceDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddDeviceSelectionDoneDelegate;
    public void AddDeviceSelectionDoneDelegate(byte LocalUserNum, FScriptDelegate DeviceDelegate) {
        _ptrAddDeviceSelectionDoneDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddDeviceSelectionDoneDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)DeviceDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddDeviceSelectionDoneDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnDeviceSelectionComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnDeviceSelectionComplete_Parameters : BaseObject {
        public OnDeviceSelectionComplete_Parameters() { }
        public OnDeviceSelectionComplete_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnDeviceSelectionComplete.bWasSuccessful
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnDeviceSelectionComplete;
    public void OnDeviceSelectionComplete(bool bWasSuccessful) {
        _ptrOnDeviceSelectionComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnDeviceSelectionComplete");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bWasSuccessful, @params, 4, 4);

        ProcessEvent(_ptrOnDeviceSelectionComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowDeviceSelectionUI
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class ShowDeviceSelectionUI_Parameters : BaseObject {
        public ShowDeviceSelectionUI_Parameters() { }
        public ShowDeviceSelectionUI_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowDeviceSelectionUI.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowDeviceSelectionUI.SizeNeeded
        // 0x4 (0x4)
        // (Param)
        public int SizeNeeded {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowDeviceSelectionUI.bForceShowUI
        // 0x8 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bForceShowUI {
            get => (*(uint*)(Pointer + 8) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 8) |= 0x1;
                else *(uint*)(Pointer + 8) &= ~(uint)0x1;
            }
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowDeviceSelectionUI.ReturnValue
        // 0xC (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 12) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 12) |= 0x1;
                else *(uint*)(Pointer + 12) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrShowDeviceSelectionUI;
    public bool ShowDeviceSelectionUI(byte LocalUserNum, int SizeNeeded, bool bForceShowUI = false) {
        _ptrShowDeviceSelectionUI ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowDeviceSelectionUI");

        var @params = stackalloc byte[13];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&SizeNeeded, @params + 4, 4, 4);
        System.Buffer.MemoryCopy(&bForceShowUI, @params + 8, 4, 4);

        ProcessEvent(_ptrShowDeviceSelectionUI, @params);

        return *(bool*)(@params + 12);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowCustomPlayersUI
    // 0x3750E0
    // (Final | Public | HasOutParams)
    public unsafe class ShowCustomPlayersUI_Parameters : BaseObject {
        public ShowCustomPlayersUI_Parameters() { }
        public ShowCustomPlayersUI_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowCustomPlayersUI.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowCustomPlayersUI.Players
        // 0x8 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public StructTArray<U_Types_Core.FUniqueNetId> Players {
            get => new(Pointer + 8, 72);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowCustomPlayersUI.Title
        // 0x18 (0x10)
        // (Param | NeedCtorLink)
        public FString Title {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowCustomPlayersUI.Description
        // 0x28 (0x10)
        // (Param | NeedCtorLink)
        public FString Description {
            get => new(Pointer + 40);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 40), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowCustomPlayersUI.ReturnValue
        // 0x38 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 56) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 56) |= 0x1;
                else *(uint*)(Pointer + 56) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrShowCustomPlayersUI;
    public bool ShowCustomPlayersUI(byte LocalUserNum, ref StructTArray<U_Types_Core.FUniqueNetId> Players, FString Title, FString Description) {
        _ptrShowCustomPlayersUI ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowCustomPlayersUI");

        var @params = stackalloc byte[53];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)Players.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy((void*)Title.Pointer, @params + 24, 16, 16);
        System.Buffer.MemoryCopy((void*)Description.Pointer, @params + 40, 16, 16);

        ProcessEvent(_ptrShowCustomPlayersUI, @params);

        var _PlayersPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_PlayersPtr, 16, 16);
        Players = new(_PlayersPtr, 72) { Allocated = true };

        return *(bool*)(@params + 56);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsUserSwitchActive
    // 0x3750E0
    // (Final | Public)
    public unsafe class IsUserSwitchActive_Parameters : BaseObject {
        public IsUserSwitchActive_Parameters() { }
        public IsUserSwitchActive_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsUserSwitchActive.ReturnValue
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
    private static UFunction _ptrIsUserSwitchActive;
    public bool IsUserSwitchActive() {
        _ptrIsUserSwitchActive ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsUserSwitchActive");

        var @params = stackalloc byte[4];

        ProcessEvent(_ptrIsUserSwitchActive, @params);

        return *(bool*)@params;
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetKickPlayerDialogActive
    // 0x3750E0
    // (Final | Public)
    public unsafe class SetKickPlayerDialogActive_Parameters : BaseObject {
        public SetKickPlayerDialogActive_Parameters() { }
        public SetKickPlayerDialogActive_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetKickPlayerDialogActive.Active
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool Active {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetKickPlayerDialogActive;
    public void SetKickPlayerDialogActive(bool Active) {
        _ptrSetKickPlayerDialogActive ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetKickPlayerDialogActive");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&Active, @params, 4, 4);

        ProcessEvent(_ptrSetKickPlayerDialogActive, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetKickPreviousUser
    // 0x3750E0
    // (Final | Public)
    public unsafe class SetKickPreviousUser_Parameters : BaseObject {
        public SetKickPreviousUser_Parameters() { }
        public SetKickPreviousUser_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetKickPreviousUser.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }
    }
    private static UFunction _ptrSetKickPreviousUser;
    public void SetKickPreviousUser(byte LocalUserNum) {
        _ptrSetKickPreviousUser ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetKickPreviousUser");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrSetKickPreviousUser, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowLoginUIForOrphanedUser
    // 0x3750E0
    // (Final | Public)
    public unsafe class ShowLoginUIForOrphanedUser_Parameters : BaseObject {
        public ShowLoginUIForOrphanedUser_Parameters() { }
        public ShowLoginUIForOrphanedUser_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowLoginUIForOrphanedUser.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowLoginUIForOrphanedUser.ReturnValue
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
    private static UFunction _ptrShowLoginUIForOrphanedUser;
    public bool ShowLoginUIForOrphanedUser(byte LocalUserNum) {
        _ptrShowLoginUIForOrphanedUser ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowLoginUIForOrphanedUser");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrShowLoginUIForOrphanedUser, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetSyncedAchievements
    // 0x3750E0
    // (Final | Public)
    public unsafe class GetSyncedAchievements_Parameters : BaseObject {
        public GetSyncedAchievements_Parameters() { }
        public GetSyncedAchievements_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetSyncedAchievements.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetSyncedAchievements.ReturnValue
        // 0x8 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public UnmanagedTArray<bool> ReturnValue {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrGetSyncedAchievements;
    public UnmanagedTArray<bool> GetSyncedAchievements(byte LocalUserNum) {
        _ptrGetSyncedAchievements ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetSyncedAchievements");

        var @params = stackalloc byte[17];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrGetSyncedAchievements, @params);

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsGuestLogin
    // 0x3750E0
    // (Final | Public)
    public unsafe class IsGuestLogin_Parameters : BaseObject {
        public IsGuestLogin_Parameters() { }
        public IsGuestLogin_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsGuestLogin.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsGuestLogin.ReturnValue
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
    private static UFunction _ptrIsGuestLogin;
    public bool IsGuestLogin(byte LocalUserNum) {
        _ptrIsGuestLogin ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsGuestLogin");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrIsGuestLogin, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RequestRestrictedFeatureMessaging
    // 0x3750E0
    // (Final | Public)
    public unsafe class RequestRestrictedFeatureMessaging_Parameters : BaseObject {
        public RequestRestrictedFeatureMessaging_Parameters() { }
        public RequestRestrictedFeatureMessaging_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RequestRestrictedFeatureMessaging.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RequestRestrictedFeatureMessaging.RestrictedFeature
        // 0x1 (0x1)
        // (Param)
        public UOnlineSubsystem.EFeaturePrivilege RestrictedFeature {
            get => *(UOnlineSubsystem.EFeaturePrivilege*)(Pointer + 1);
            set => *(UOnlineSubsystem.EFeaturePrivilege*)(Pointer + 1) = value;
        }
    }
    private static UFunction _ptrRequestRestrictedFeatureMessaging;
    public void RequestRestrictedFeatureMessaging(byte LocalUserNum, UOnlineSubsystem.EFeaturePrivilege RestrictedFeature) {
        _ptrRequestRestrictedFeatureMessaging ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RequestRestrictedFeatureMessaging");

        var @params = stackalloc byte[2];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&RestrictedFeature, @params + 1, 1, 1);

        ProcessEvent(_ptrRequestRestrictedFeatureMessaging, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateVoice
    // 0x3750E0
    // (Final | HasOptionalParams | Public | HasOutParams)
    public unsafe class CanCommunicateVoice_Parameters : BaseObject {
        public CanCommunicateVoice_Parameters() { }
        public CanCommunicateVoice_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateVoice.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateVoice.PrivilegeLevelHint
        // 0x1 (0x1)
        // (Param | OutParam)
        public UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint {
            get => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1);
            set => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1) = value;
        }

        // MISSED OFFSET: 0x2

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateVoice.bAttemptToResolve
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bAttemptToResolve {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateVoice.Reason
        // 0x8 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Reason {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateVoice.ReturnValue
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
    private static UFunction _ptrCanCommunicateVoice;
    public bool CanCommunicateVoice(byte LocalUserNum, ref UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint, bool bAttemptToResolve = false, FString Reason = null) {
        _ptrCanCommunicateVoice ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateVoice");

        var @params = stackalloc byte[26];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        var _PrivilegeLevelHint = PrivilegeLevelHint;
        System.Buffer.MemoryCopy(&_PrivilegeLevelHint, @params + 1, 1, 1);
        System.Buffer.MemoryCopy(&bAttemptToResolve, @params + 4, 4, 4);
        if (Reason != null) System.Buffer.MemoryCopy((void*)Reason.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrCanCommunicateVoice, @params);

        PrivilegeLevelHint = *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(@params + 1);

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateVideo
    // 0x3750E0
    // (Final | HasOptionalParams | Public | HasOutParams)
    public unsafe class CanCommunicateVideo_Parameters : BaseObject {
        public CanCommunicateVideo_Parameters() { }
        public CanCommunicateVideo_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateVideo.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateVideo.PrivilegeLevelHint
        // 0x1 (0x1)
        // (Param | OutParam)
        public UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint {
            get => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1);
            set => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1) = value;
        }

        // MISSED OFFSET: 0x2

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateVideo.bAttemptToResolve
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bAttemptToResolve {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateVideo.Reason
        // 0x8 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Reason {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateVideo.ReturnValue
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
    private static UFunction _ptrCanCommunicateVideo;
    public bool CanCommunicateVideo(byte LocalUserNum, ref UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint, bool bAttemptToResolve = false, FString Reason = null) {
        _ptrCanCommunicateVideo ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateVideo");

        var @params = stackalloc byte[26];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        var _PrivilegeLevelHint = PrivilegeLevelHint;
        System.Buffer.MemoryCopy(&_PrivilegeLevelHint, @params + 1, 1, 1);
        System.Buffer.MemoryCopy(&bAttemptToResolve, @params + 4, 4, 4);
        if (Reason != null) System.Buffer.MemoryCopy((void*)Reason.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrCanCommunicateVideo, @params);

        PrivilegeLevelHint = *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(@params + 1);

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateText
    // 0x3750E0
    // (Final | HasOptionalParams | Public | HasOutParams)
    public unsafe class CanCommunicateText_Parameters : BaseObject {
        public CanCommunicateText_Parameters() { }
        public CanCommunicateText_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateText.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateText.PrivilegeLevelHint
        // 0x1 (0x1)
        // (Param | OutParam)
        public UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint {
            get => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1);
            set => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1) = value;
        }

        // MISSED OFFSET: 0x2

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateText.bAttemptToResolve
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bAttemptToResolve {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateText.Reason
        // 0x8 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Reason {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateText.ReturnValue
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
    private static UFunction _ptrCanCommunicateText;
    public bool CanCommunicateText(byte LocalUserNum, ref UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint, bool bAttemptToResolve = false, FString Reason = null) {
        _ptrCanCommunicateText ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicateText");

        var @params = stackalloc byte[26];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        var _PrivilegeLevelHint = PrivilegeLevelHint;
        System.Buffer.MemoryCopy(&_PrivilegeLevelHint, @params + 1, 1, 1);
        System.Buffer.MemoryCopy(&bAttemptToResolve, @params + 4, 4, 4);
        if (Reason != null) System.Buffer.MemoryCopy((void*)Reason.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrCanCommunicateText, @params);

        PrivilegeLevelHint = *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(@params + 1);

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareUserCreatedContent
    // 0x3750E0
    // (Final | HasOptionalParams | Public | HasOutParams)
    public unsafe class CanShareUserCreatedContent_Parameters : BaseObject {
        public CanShareUserCreatedContent_Parameters() { }
        public CanShareUserCreatedContent_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareUserCreatedContent.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareUserCreatedContent.PrivilegeLevelHint
        // 0x1 (0x1)
        // (Param | OutParam)
        public UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint {
            get => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1);
            set => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1) = value;
        }

        // MISSED OFFSET: 0x2

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareUserCreatedContent.bAttemptToResolve
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bAttemptToResolve {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareUserCreatedContent.Reason
        // 0x8 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Reason {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareUserCreatedContent.ReturnValue
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
    private static UFunction _ptrCanShareUserCreatedContent;
    public bool CanShareUserCreatedContent(byte LocalUserNum, ref UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint, bool bAttemptToResolve = false, FString Reason = null) {
        _ptrCanShareUserCreatedContent ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareUserCreatedContent");

        var @params = stackalloc byte[26];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        var _PrivilegeLevelHint = PrivilegeLevelHint;
        System.Buffer.MemoryCopy(&_PrivilegeLevelHint, @params + 1, 1, 1);
        System.Buffer.MemoryCopy(&bAttemptToResolve, @params + 4, 4, 4);
        if (Reason != null) System.Buffer.MemoryCopy((void*)Reason.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrCanShareUserCreatedContent, @params);

        PrivilegeLevelHint = *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(@params + 1);

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanAccessPremiumVideoContent
    // 0x3750E0
    // (Final | HasOptionalParams | Public | HasOutParams)
    public unsafe class CanAccessPremiumVideoContent_Parameters : BaseObject {
        public CanAccessPremiumVideoContent_Parameters() { }
        public CanAccessPremiumVideoContent_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanAccessPremiumVideoContent.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanAccessPremiumVideoContent.PrivilegeLevelHint
        // 0x1 (0x1)
        // (Param | OutParam)
        public UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint {
            get => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1);
            set => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1) = value;
        }

        // MISSED OFFSET: 0x2

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanAccessPremiumVideoContent.bAttemptToResolve
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bAttemptToResolve {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanAccessPremiumVideoContent.Reason
        // 0x8 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Reason {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanAccessPremiumVideoContent.ReturnValue
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
    private static UFunction _ptrCanAccessPremiumVideoContent;
    public bool CanAccessPremiumVideoContent(byte LocalUserNum, ref UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint, bool bAttemptToResolve = false, FString Reason = null) {
        _ptrCanAccessPremiumVideoContent ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanAccessPremiumVideoContent");

        var @params = stackalloc byte[26];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        var _PrivilegeLevelHint = PrivilegeLevelHint;
        System.Buffer.MemoryCopy(&_PrivilegeLevelHint, @params + 1, 1, 1);
        System.Buffer.MemoryCopy(&bAttemptToResolve, @params + 4, 4, 4);
        if (Reason != null) System.Buffer.MemoryCopy((void*)Reason.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrCanAccessPremiumVideoContent, @params);

        PrivilegeLevelHint = *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(@params + 1);

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanAccessPremiumContent
    // 0x3750E0
    // (Final | HasOptionalParams | Public | HasOutParams)
    public unsafe class CanAccessPremiumContent_Parameters : BaseObject {
        public CanAccessPremiumContent_Parameters() { }
        public CanAccessPremiumContent_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanAccessPremiumContent.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanAccessPremiumContent.PrivilegeLevelHint
        // 0x1 (0x1)
        // (Param | OutParam)
        public UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint {
            get => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1);
            set => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1) = value;
        }

        // MISSED OFFSET: 0x2

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanAccessPremiumContent.bAttemptToResolve
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bAttemptToResolve {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanAccessPremiumContent.Reason
        // 0x8 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Reason {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanAccessPremiumContent.ReturnValue
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
    private static UFunction _ptrCanAccessPremiumContent;
    public bool CanAccessPremiumContent(byte LocalUserNum, ref UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint, bool bAttemptToResolve = false, FString Reason = null) {
        _ptrCanAccessPremiumContent ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanAccessPremiumContent");

        var @params = stackalloc byte[26];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        var _PrivilegeLevelHint = PrivilegeLevelHint;
        System.Buffer.MemoryCopy(&_PrivilegeLevelHint, @params + 1, 1, 1);
        System.Buffer.MemoryCopy(&bAttemptToResolve, @params + 4, 4, 4);
        if (Reason != null) System.Buffer.MemoryCopy((void*)Reason.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrCanAccessPremiumContent, @params);

        PrivilegeLevelHint = *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(@params + 1);

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanUseCloudStorage
    // 0x3750E0
    // (Final | HasOptionalParams | Public | HasOutParams)
    public unsafe class CanUseCloudStorage_Parameters : BaseObject {
        public CanUseCloudStorage_Parameters() { }
        public CanUseCloudStorage_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanUseCloudStorage.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanUseCloudStorage.PrivilegeLevelHint
        // 0x1 (0x1)
        // (Param | OutParam)
        public UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint {
            get => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1);
            set => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1) = value;
        }

        // MISSED OFFSET: 0x2

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanUseCloudStorage.bAttemptToResolve
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bAttemptToResolve {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanUseCloudStorage.Reason
        // 0x8 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Reason {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanUseCloudStorage.ReturnValue
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
    private static UFunction _ptrCanUseCloudStorage;
    public bool CanUseCloudStorage(byte LocalUserNum, ref UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint, bool bAttemptToResolve = false, FString Reason = null) {
        _ptrCanUseCloudStorage ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanUseCloudStorage");

        var @params = stackalloc byte[26];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        var _PrivilegeLevelHint = PrivilegeLevelHint;
        System.Buffer.MemoryCopy(&_PrivilegeLevelHint, @params + 1, 1, 1);
        System.Buffer.MemoryCopy(&bAttemptToResolve, @params + 4, 4, 4);
        if (Reason != null) System.Buffer.MemoryCopy((void*)Reason.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrCanUseCloudStorage, @params);

        PrivilegeLevelHint = *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(@params + 1);

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanRecordDVRClips
    // 0x3750E0
    // (Final | HasOptionalParams | Public | HasOutParams)
    public unsafe class CanRecordDVRClips_Parameters : BaseObject {
        public CanRecordDVRClips_Parameters() { }
        public CanRecordDVRClips_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanRecordDVRClips.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanRecordDVRClips.PrivilegeLevelHint
        // 0x1 (0x1)
        // (Param | OutParam)
        public UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint {
            get => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1);
            set => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1) = value;
        }

        // MISSED OFFSET: 0x2

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanRecordDVRClips.bAttemptToResolve
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bAttemptToResolve {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanRecordDVRClips.Reason
        // 0x8 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Reason {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanRecordDVRClips.ReturnValue
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
    private static UFunction _ptrCanRecordDVRClips;
    public bool CanRecordDVRClips(byte LocalUserNum, ref UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint, bool bAttemptToResolve = false, FString Reason = null) {
        _ptrCanRecordDVRClips ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanRecordDVRClips");

        var @params = stackalloc byte[26];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        var _PrivilegeLevelHint = PrivilegeLevelHint;
        System.Buffer.MemoryCopy(&_PrivilegeLevelHint, @params + 1, 1, 1);
        System.Buffer.MemoryCopy(&bAttemptToResolve, @params + 4, 4, 4);
        if (Reason != null) System.Buffer.MemoryCopy((void*)Reason.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrCanRecordDVRClips, @params);

        PrivilegeLevelHint = *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(@params + 1);

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanBrowseInternet
    // 0x3750E0
    // (Final | HasOptionalParams | Public | HasOutParams)
    public unsafe class CanBrowseInternet_Parameters : BaseObject {
        public CanBrowseInternet_Parameters() { }
        public CanBrowseInternet_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanBrowseInternet.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanBrowseInternet.PrivilegeLevelHint
        // 0x1 (0x1)
        // (Param | OutParam)
        public UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint {
            get => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1);
            set => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1) = value;
        }

        // MISSED OFFSET: 0x2

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanBrowseInternet.bAttemptToResolve
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bAttemptToResolve {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanBrowseInternet.Reason
        // 0x8 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Reason {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanBrowseInternet.ReturnValue
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
    private static UFunction _ptrCanBrowseInternet;
    public bool CanBrowseInternet(byte LocalUserNum, ref UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint, bool bAttemptToResolve = false, FString Reason = null) {
        _ptrCanBrowseInternet ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanBrowseInternet");

        var @params = stackalloc byte[26];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        var _PrivilegeLevelHint = PrivilegeLevelHint;
        System.Buffer.MemoryCopy(&_PrivilegeLevelHint, @params + 1, 1, 1);
        System.Buffer.MemoryCopy(&bAttemptToResolve, @params + 4, 4, 4);
        if (Reason != null) System.Buffer.MemoryCopy((void*)Reason.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrCanBrowseInternet, @params);

        PrivilegeLevelHint = *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(@params + 1);

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareWithSocialNetwork
    // 0x3750E0
    // (Final | HasOptionalParams | Public | HasOutParams)
    public unsafe class CanShareWithSocialNetwork_Parameters : BaseObject {
        public CanShareWithSocialNetwork_Parameters() { }
        public CanShareWithSocialNetwork_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareWithSocialNetwork.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareWithSocialNetwork.PrivilegeLevelHint
        // 0x1 (0x1)
        // (Param | OutParam)
        public UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint {
            get => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1);
            set => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1) = value;
        }

        // MISSED OFFSET: 0x2

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareWithSocialNetwork.bAttemptToResolve
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bAttemptToResolve {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareWithSocialNetwork.Reason
        // 0x8 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Reason {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareWithSocialNetwork.ReturnValue
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
    private static UFunction _ptrCanShareWithSocialNetwork;
    public bool CanShareWithSocialNetwork(byte LocalUserNum, ref UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint, bool bAttemptToResolve = false, FString Reason = null) {
        _ptrCanShareWithSocialNetwork ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareWithSocialNetwork");

        var @params = stackalloc byte[26];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        var _PrivilegeLevelHint = PrivilegeLevelHint;
        System.Buffer.MemoryCopy(&_PrivilegeLevelHint, @params + 1, 1, 1);
        System.Buffer.MemoryCopy(&bAttemptToResolve, @params + 4, 4, 4);
        if (Reason != null) System.Buffer.MemoryCopy((void*)Reason.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrCanShareWithSocialNetwork, @params);

        PrivilegeLevelHint = *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(@params + 1);

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareKinectContent
    // 0x3750E0
    // (Final | HasOptionalParams | Public | HasOutParams)
    public unsafe class CanShareKinectContent_Parameters : BaseObject {
        public CanShareKinectContent_Parameters() { }
        public CanShareKinectContent_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareKinectContent.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareKinectContent.PrivilegeLevelHint
        // 0x1 (0x1)
        // (Param | OutParam)
        public UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint {
            get => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1);
            set => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1) = value;
        }

        // MISSED OFFSET: 0x2

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareKinectContent.bAttemptToResolve
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bAttemptToResolve {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareKinectContent.Reason
        // 0x8 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Reason {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareKinectContent.ReturnValue
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
    private static UFunction _ptrCanShareKinectContent;
    public bool CanShareKinectContent(byte LocalUserNum, ref UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint, bool bAttemptToResolve = false, FString Reason = null) {
        _ptrCanShareKinectContent ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShareKinectContent");

        var @params = stackalloc byte[26];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        var _PrivilegeLevelHint = PrivilegeLevelHint;
        System.Buffer.MemoryCopy(&_PrivilegeLevelHint, @params + 1, 1, 1);
        System.Buffer.MemoryCopy(&bAttemptToResolve, @params + 4, 4, 4);
        if (Reason != null) System.Buffer.MemoryCopy((void*)Reason.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrCanShareKinectContent, @params);

        PrivilegeLevelHint = *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(@params + 1);

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanUploadFitnessData
    // 0x3750E0
    // (Final | HasOptionalParams | Public | HasOutParams)
    public unsafe class CanUploadFitnessData_Parameters : BaseObject {
        public CanUploadFitnessData_Parameters() { }
        public CanUploadFitnessData_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanUploadFitnessData.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanUploadFitnessData.PrivilegeLevelHint
        // 0x1 (0x1)
        // (Param | OutParam)
        public UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint {
            get => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1);
            set => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1) = value;
        }

        // MISSED OFFSET: 0x2

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanUploadFitnessData.bAttemptToResolve
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bAttemptToResolve {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanUploadFitnessData.Reason
        // 0x8 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Reason {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanUploadFitnessData.ReturnValue
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
    private static UFunction _ptrCanUploadFitnessData;
    public bool CanUploadFitnessData(byte LocalUserNum, ref UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint, bool bAttemptToResolve = false, FString Reason = null) {
        _ptrCanUploadFitnessData ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanUploadFitnessData");

        var @params = stackalloc byte[26];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        var _PrivilegeLevelHint = PrivilegeLevelHint;
        System.Buffer.MemoryCopy(&_PrivilegeLevelHint, @params + 1, 1, 1);
        System.Buffer.MemoryCopy(&bAttemptToResolve, @params + 4, 4, 4);
        if (Reason != null) System.Buffer.MemoryCopy((void*)Reason.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrCanUploadFitnessData, @params);

        PrivilegeLevelHint = *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(@params + 1);

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetPrimaryPlayerGamepadToLastInput
    // 0x3750E0
    // (Final | Public)
    public unsafe class SetPrimaryPlayerGamepadToLastInput_Parameters : BaseObject {
        public SetPrimaryPlayerGamepadToLastInput_Parameters() { }
        public SetPrimaryPlayerGamepadToLastInput_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrSetPrimaryPlayerGamepadToLastInput;
    public void SetPrimaryPlayerGamepadToLastInput() {
        _ptrSetPrimaryPlayerGamepadToLastInput ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetPrimaryPlayerGamepadToLastInput");

        ProcessEvent(_ptrSetPrimaryPlayerGamepadToLastInput, null);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearUserSwitchCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearUserSwitchCompleteDelegate_Parameters : BaseObject {
        public ClearUserSwitchCompleteDelegate_Parameters() { }
        public ClearUserSwitchCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearUserSwitchCompleteDelegate.UserSwitchCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate UserSwitchCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearUserSwitchCompleteDelegate;
    public void ClearUserSwitchCompleteDelegate(FScriptDelegate UserSwitchCompleteDelegate) {
        _ptrClearUserSwitchCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearUserSwitchCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)UserSwitchCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearUserSwitchCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddUserSwitchCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddUserSwitchCompleteDelegate_Parameters : BaseObject {
        public AddUserSwitchCompleteDelegate_Parameters() { }
        public AddUserSwitchCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddUserSwitchCompleteDelegate.UserSwitchCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate UserSwitchCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddUserSwitchCompleteDelegate;
    public void AddUserSwitchCompleteDelegate(FScriptDelegate UserSwitchCompleteDelegate) {
        _ptrAddUserSwitchCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddUserSwitchCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)UserSwitchCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddUserSwitchCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnUserSwitchComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnUserSwitchComplete_Parameters : BaseObject {
        public OnUserSwitchComplete_Parameters() { }
        public OnUserSwitchComplete_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnUserSwitchComplete.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }
    }
    private static UFunction _ptrOnUserSwitchComplete;
    public void OnUserSwitchComplete(byte LocalUserNum) {
        _ptrOnUserSwitchComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnUserSwitchComplete");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrOnUserSwitchComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearLoginStatusChangeDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearLoginStatusChangeDelegate_Parameters : BaseObject {
        public ClearLoginStatusChangeDelegate_Parameters() { }
        public ClearLoginStatusChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearLoginStatusChangeDelegate.InDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearLoginStatusChangeDelegate.LocalUserNum
        // 0x18 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)(Pointer + 24);
            set => *(byte*)(Pointer + 24) = value;
        }
    }
    private static UFunction _ptrClearLoginStatusChangeDelegate;
    public void ClearLoginStatusChangeDelegate(FScriptDelegate InDelegate, byte LocalUserNum) {
        _ptrClearLoginStatusChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearLoginStatusChangeDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params, 24, 24);
        System.Buffer.MemoryCopy(&LocalUserNum, @params + 24, 1, 1);

        ProcessEvent(_ptrClearLoginStatusChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddLoginStatusChangeDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddLoginStatusChangeDelegate_Parameters : BaseObject {
        public AddLoginStatusChangeDelegate_Parameters() { }
        public AddLoginStatusChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddLoginStatusChangeDelegate.InDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddLoginStatusChangeDelegate.LocalUserNum
        // 0x18 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)(Pointer + 24);
            set => *(byte*)(Pointer + 24) = value;
        }
    }
    private static UFunction _ptrAddLoginStatusChangeDelegate;
    public void AddLoginStatusChangeDelegate(FScriptDelegate InDelegate, byte LocalUserNum) {
        _ptrAddLoginStatusChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddLoginStatusChangeDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params, 24, 24);
        System.Buffer.MemoryCopy(&LocalUserNum, @params + 24, 1, 1);

        ProcessEvent(_ptrAddLoginStatusChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnLoginStatusChange
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnLoginStatusChange_Parameters : BaseObject {
        public OnLoginStatusChange_Parameters() { }
        public OnLoginStatusChange_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnLoginStatusChange.NewStatus
        // 0x0 (0x1)
        // (Param)
        public UOnlineSubsystem.ELoginStatus NewStatus {
            get => *(UOnlineSubsystem.ELoginStatus*)Pointer;
            set => *(UOnlineSubsystem.ELoginStatus*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnLoginStatusChange.NewId
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId NewId {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }
    }
    private static UFunction _ptrOnLoginStatusChange;
    public void OnLoginStatusChange(UOnlineSubsystem.ELoginStatus NewStatus, U_Types_Core.FUniqueNetId NewId) {
        _ptrOnLoginStatusChange ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnLoginStatusChange");

        var @params = stackalloc byte[73];
        System.Buffer.MemoryCopy(&NewStatus, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)NewId.Pointer, @params + 8, 72, 72);

        ProcessEvent(_ptrOnLoginStatusChange, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetPlayHistoryRegistrationKey
    // 0x3750E0
    // (Final | Public | HasOutParams)
    public unsafe class GetPlayHistoryRegistrationKey_Parameters : BaseObject {
        public GetPlayHistoryRegistrationKey_Parameters() { }
        public GetPlayHistoryRegistrationKey_Parameters(nint pointer) : base(pointer) { }

        // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetPlayHistoryRegistrationKey.Key
        // 0x0 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public UnmanagedTArray<byte> Key {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetPlayHistoryRegistrationKey.ReturnValue
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
    private static UFunction _ptrGetPlayHistoryRegistrationKey;
    public bool GetPlayHistoryRegistrationKey(ref UnmanagedTArray<byte> Key) {
        _ptrGetPlayHistoryRegistrationKey ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetPlayHistoryRegistrationKey");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params, 16, 16);

        ProcessEvent(_ptrGetPlayHistoryRegistrationKey, @params);

        var _KeyPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_KeyPtr, 16, 16);
        Key = new(_KeyPtr) { Allocated = true };

        return *(bool*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CheckParentalControlInfo
    // 0x3750E0
    // (Final | Public)
    public unsafe class CheckParentalControlInfo_Parameters : BaseObject {
        public CheckParentalControlInfo_Parameters() { }
        public CheckParentalControlInfo_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CheckParentalControlInfo.bShowUi
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bShowUi {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CheckParentalControlInfo.ReturnValue
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
    private static UFunction _ptrCheckParentalControlInfo;
    public bool CheckParentalControlInfo(bool bShowUi) {
        _ptrCheckParentalControlInfo ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CheckParentalControlInfo");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&bShowUi, @params, 4, 4);

        ProcessEvent(_ptrCheckParentalControlInfo, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetActiveDiscDLC
    // 0x3750E0
    // (Final | Public)
    public unsafe class GetActiveDiscDLC_Parameters : BaseObject {
        public GetActiveDiscDLC_Parameters() { }
        public GetActiveDiscDLC_Parameters(nint pointer) : base(pointer) { }

        // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetActiveDiscDLC.ReturnValue
        // 0x0 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public StructTArray<FName> ReturnValue {
            get => new(Pointer, 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetActiveDiscDLC;
    public StructTArray<FName> GetActiveDiscDLC() {
        _ptrGetActiveDiscDLC ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetActiveDiscDLC");

        var @params = stackalloc byte[16];

        ProcessEvent(_ptrGetActiveDiscDLC, @params);

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr, 8) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetOnlineSubscriptionRequirement
    // 0x3750E0
    // (Final | Public)
    public unsafe class SetOnlineSubscriptionRequirement_Parameters : BaseObject {
        public SetOnlineSubscriptionRequirement_Parameters() { }
        public SetOnlineSubscriptionRequirement_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetOnlineSubscriptionRequirement.bRequiresOnlineSubscription
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bRequiresOnlineSubscription {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetOnlineSubscriptionRequirement;
    public void SetOnlineSubscriptionRequirement(bool bRequiresOnlineSubscription) {
        _ptrSetOnlineSubscriptionRequirement ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetOnlineSubscriptionRequirement");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bRequiresOnlineSubscription, @params, 4, 4);

        ProcessEvent(_ptrSetOnlineSubscriptionRequirement, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetControllerID
    // 0x3750E0
    // (Final | Public)
    public unsafe class GetControllerID_Parameters : BaseObject {
        public GetControllerID_Parameters() { }
        public GetControllerID_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetControllerID.LocalPlayerNum
        // 0x0 (0x4)
        // (Param)
        public int LocalPlayerNum {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetControllerID.ReturnValue
        // 0x4 (0x4)
        // (Param | OutParam | ReturnParam)
        public int ReturnValue {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }
    }
    private static UFunction _ptrGetControllerID;
    public int GetControllerID(int LocalPlayerNum) {
        _ptrGetControllerID ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetControllerID");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&LocalPlayerNum, @params, 4, 4);

        ProcessEvent(_ptrGetControllerID, @params);

        return *(int*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetConnectedControllerNames
    // 0x3750E0
    // (Final | Public)
    public unsafe class GetConnectedControllerNames_Parameters : BaseObject {
        public GetConnectedControllerNames_Parameters() { }
        public GetConnectedControllerNames_Parameters(nint pointer) : base(pointer) { }

        // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetConnectedControllerNames.ReturnValue
        // 0x0 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public StructTArray<FName> ReturnValue {
            get => new(Pointer, 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetConnectedControllerNames;
    public StructTArray<FName> GetConnectedControllerNames() {
        _ptrGetConnectedControllerNames ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetConnectedControllerNames");

        var @params = stackalloc byte[16];

        ProcessEvent(_ptrGetConnectedControllerNames, @params);

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr, 8) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnLocalPlayerRemoved
    // 0x3750E0
    // (Final | Public)
    public unsafe class OnLocalPlayerRemoved_Parameters : BaseObject {
        public OnLocalPlayerRemoved_Parameters() { }
        public OnLocalPlayerRemoved_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnLocalPlayerRemoved.LocalPlayerNum
        // 0x0 (0x4)
        // (Param)
        public int LocalPlayerNum {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrOnLocalPlayerRemoved;
    public void OnLocalPlayerRemoved(int LocalPlayerNum) {
        _ptrOnLocalPlayerRemoved ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnLocalPlayerRemoved");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&LocalPlayerNum, @params, 4, 4);

        ProcessEvent(_ptrOnLocalPlayerRemoved, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UnregisterController
    // 0x3750E0
    // (Final | Public)
    public unsafe class UnregisterController_Parameters : BaseObject {
        public UnregisterController_Parameters() { }
        public UnregisterController_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UnregisterController.LocalPlayerNum
        // 0x0 (0x4)
        // (Param)
        public int LocalPlayerNum {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrUnregisterController;
    public void UnregisterController(int LocalPlayerNum) {
        _ptrUnregisterController ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UnregisterController");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&LocalPlayerNum, @params, 4, 4);

        ProcessEvent(_ptrUnregisterController, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RegisterController
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class RegisterController_Parameters : BaseObject {
        public RegisterController_Parameters() { }
        public RegisterController_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RegisterController.LocalPlayerNum
        // 0x0 (0x4)
        // (Param)
        public int LocalPlayerNum {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RegisterController.ControllerId
        // 0x4 (0x4)
        // (OptionalParam | Param)
        public int ControllerId {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }
    }
    private static UFunction _ptrRegisterController;
    public void RegisterController(int LocalPlayerNum, int ControllerId = 0) {
        _ptrRegisterController ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RegisterController");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&LocalPlayerNum, @params, 4, 4);
        System.Buffer.MemoryCopy(&ControllerId, @params + 4, 4, 4);

        ProcessEvent(_ptrRegisterController, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanRegisterController
    // 0x3750E0
    // (Final | Public)
    public unsafe class CanRegisterController_Parameters : BaseObject {
        public CanRegisterController_Parameters() { }
        public CanRegisterController_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanRegisterController.LocalPlayerNum
        // 0x0 (0x4)
        // (Param)
        public int LocalPlayerNum {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanRegisterController.ReturnValue
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
    private static UFunction _ptrCanRegisterController;
    public bool CanRegisterController(int LocalPlayerNum) {
        _ptrCanRegisterController ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanRegisterController");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&LocalPlayerNum, @params, 4, 4);

        ProcessEvent(_ptrCanRegisterController, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowBindings
    // 0x3750E0
    // (Final | Public)
    public unsafe class ShowBindings_Parameters : BaseObject {
        public ShowBindings_Parameters() { }
        public ShowBindings_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowBindings.ControllerId
        // 0x0 (0x4)
        // (Param)
        public int ControllerId {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowBindings.ReturnValue
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
    private static UFunction _ptrShowBindings;
    public bool ShowBindings(int ControllerId) {
        _ptrShowBindings ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowBindings");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&ControllerId, @params, 4, 4);

        ProcessEvent(_ptrShowBindings, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetControllerLayout
    // 0x3750E0
    // (Final | Public)
    public unsafe class SetControllerLayout_Parameters : BaseObject {
        public SetControllerLayout_Parameters() { }
        public SetControllerLayout_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetControllerLayout.ControllerId
        // 0x0 (0x4)
        // (Param)
        public int ControllerId {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // NameProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetControllerLayout.LayoutName
        // 0x4 (0x8)
        // (Param)
        public FName LayoutName {
            get => new(Pointer + 4);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 4), 8, 8);
        }
    }
    private static UFunction _ptrSetControllerLayout;
    public void SetControllerLayout(int ControllerId, FName LayoutName) {
        _ptrSetControllerLayout ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetControllerLayout");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy(&ControllerId, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)LayoutName.Pointer, @params + 4, 8, 8);

        ProcessEvent(_ptrSetControllerLayout, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetInputAPI
    // 0x3750E0
    // (Final | Public)
    public unsafe class SetInputAPI_Parameters : BaseObject {
        public SetInputAPI_Parameters() { }
        public SetInputAPI_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetInputAPI.TargetAPI
        // 0x0 (0x1)
        // (Param)
        public U_Types_Core.EInputAPI TargetAPI {
            get => *(U_Types_Core.EInputAPI*)Pointer;
            set => *(U_Types_Core.EInputAPI*)Pointer = value;
        }
    }
    private static UFunction _ptrSetInputAPI;
    public void SetInputAPI(U_Types_Core.EInputAPI TargetAPI) {
        _ptrSetInputAPI ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetInputAPI");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&TargetAPI, @params, 1, 1);

        ProcessEvent(_ptrSetInputAPI, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearInputAPIChangedDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearInputAPIChangedDelegate_Parameters : BaseObject {
        public ClearInputAPIChangedDelegate_Parameters() { }
        public ClearInputAPIChangedDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearInputAPIChangedDelegate.InputAPIChangedDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InputAPIChangedDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearInputAPIChangedDelegate;
    public void ClearInputAPIChangedDelegate(FScriptDelegate InputAPIChangedDelegate) {
        _ptrClearInputAPIChangedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearInputAPIChangedDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InputAPIChangedDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearInputAPIChangedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddInputAPIChangedDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddInputAPIChangedDelegate_Parameters : BaseObject {
        public AddInputAPIChangedDelegate_Parameters() { }
        public AddInputAPIChangedDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddInputAPIChangedDelegate.InputAPIChangedDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InputAPIChangedDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddInputAPIChangedDelegate;
    public void AddInputAPIChangedDelegate(FScriptDelegate InputAPIChangedDelegate) {
        _ptrAddInputAPIChangedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddInputAPIChangedDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InputAPIChangedDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddInputAPIChangedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnInputAPIChanged
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnInputAPIChanged_Parameters : BaseObject {
        public OnInputAPIChanged_Parameters() { }
        public OnInputAPIChanged_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnInputAPIChanged.TargetAPI
        // 0x0 (0x1)
        // (Param)
        public U_Types_Core.EInputAPI TargetAPI {
            get => *(U_Types_Core.EInputAPI*)Pointer;
            set => *(U_Types_Core.EInputAPI*)Pointer = value;
        }
    }
    private static UFunction _ptrOnInputAPIChanged;
    public void OnInputAPIChanged(U_Types_Core.EInputAPI TargetAPI) {
        _ptrOnInputAPIChanged ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnInputAPIChanged");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&TargetAPI, @params, 1, 1);

        ProcessEvent(_ptrOnInputAPIChanged, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearUnregisteredControllerDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearUnregisteredControllerDelegate_Parameters : BaseObject {
        public ClearUnregisteredControllerDelegate_Parameters() { }
        public ClearUnregisteredControllerDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearUnregisteredControllerDelegate.UnregisteredControllerDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate UnregisteredControllerDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearUnregisteredControllerDelegate;
    public void ClearUnregisteredControllerDelegate(FScriptDelegate UnregisteredControllerDelegate) {
        _ptrClearUnregisteredControllerDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearUnregisteredControllerDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)UnregisteredControllerDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearUnregisteredControllerDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearRegisteredControllerDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearRegisteredControllerDelegate_Parameters : BaseObject {
        public ClearRegisteredControllerDelegate_Parameters() { }
        public ClearRegisteredControllerDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearRegisteredControllerDelegate.RegisteredControllerDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate RegisteredControllerDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearRegisteredControllerDelegate;
    public void ClearRegisteredControllerDelegate(FScriptDelegate RegisteredControllerDelegate) {
        _ptrClearRegisteredControllerDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearRegisteredControllerDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)RegisteredControllerDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearRegisteredControllerDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddUnregisteredControllerDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddUnregisteredControllerDelegate_Parameters : BaseObject {
        public AddUnregisteredControllerDelegate_Parameters() { }
        public AddUnregisteredControllerDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddUnregisteredControllerDelegate.UnregisteredControllerDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate UnregisteredControllerDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddUnregisteredControllerDelegate;
    public void AddUnregisteredControllerDelegate(FScriptDelegate UnregisteredControllerDelegate) {
        _ptrAddUnregisteredControllerDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddUnregisteredControllerDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)UnregisteredControllerDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddUnregisteredControllerDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddRegisteredControllerDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddRegisteredControllerDelegate_Parameters : BaseObject {
        public AddRegisteredControllerDelegate_Parameters() { }
        public AddRegisteredControllerDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddRegisteredControllerDelegate.RegisteredControllerDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate RegisteredControllerDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddRegisteredControllerDelegate;
    public void AddRegisteredControllerDelegate(FScriptDelegate RegisteredControllerDelegate) {
        _ptrAddRegisteredControllerDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddRegisteredControllerDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)RegisteredControllerDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddRegisteredControllerDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnUnregisteredController
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnUnregisteredController_Parameters : BaseObject {
        public OnUnregisteredController_Parameters() { }
        public OnUnregisteredController_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnUnregisteredController.LocalPlayerNum
        // 0x0 (0x4)
        // (Param)
        public int LocalPlayerNum {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrOnUnregisteredController;
    public void OnUnregisteredController(int LocalPlayerNum) {
        _ptrOnUnregisteredController ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnUnregisteredController");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&LocalPlayerNum, @params, 4, 4);

        ProcessEvent(_ptrOnUnregisteredController, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnRegisteredController
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnRegisteredController_Parameters : BaseObject {
        public OnRegisteredController_Parameters() { }
        public OnRegisteredController_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnRegisteredController.LocalPlayerNum
        // 0x0 (0x4)
        // (Param)
        public int LocalPlayerNum {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnRegisteredController.ControllerId
        // 0x4 (0x4)
        // (Param)
        public int ControllerId {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }
    }
    private static UFunction _ptrOnRegisteredController;
    public void OnRegisteredController(int LocalPlayerNum, int ControllerId) {
        _ptrOnRegisteredController ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnRegisteredController");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&LocalPlayerNum, @params, 4, 4);
        System.Buffer.MemoryCopy(&ControllerId, @params + 4, 4, 4);

        ProcessEvent(_ptrOnRegisteredController, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddInGamePost
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddInGamePost_Parameters : BaseObject {
        public AddInGamePost_Parameters() { }
        public AddInGamePost_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddInGamePost.InPostID
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString InPostID {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddInGamePost.LocalUserNum
        // 0x10 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)(Pointer + 16);
            set => *(byte*)(Pointer + 16) = value;
        }

        // MISSED OFFSET: 0x7

        // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddInGamePost.StringReplaceList
        // 0x18 (0x10)
        // (Param | NeedCtorLink)
        public StructTArray<FString> StringReplaceList {
            get => new(Pointer + 24, 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddInGamePost.ReturnValue
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
    private static UFunction _ptrAddInGamePost;
    public bool AddInGamePost(FString InPostID, byte LocalUserNum, StructTArray<FString> StringReplaceList) {
        _ptrAddInGamePost ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddInGamePost");

        var @params = stackalloc byte[37];
        System.Buffer.MemoryCopy((void*)InPostID.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&LocalUserNum, @params + 16, 1, 1);
        System.Buffer.MemoryCopy((void*)StringReplaceList.Pointer, @params + 24, 16, 16);

        ProcessEvent(_ptrAddInGamePost, @params);

        return *(bool*)(@params + 40);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UpdateStat
    // 0x3750E0
    // (Final | Public)
    public unsafe class UpdateStat_Parameters : BaseObject {
        public UpdateStat_Parameters() { }
        public UpdateStat_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UpdateStat.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // NameProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UpdateStat.StatName
        // 0x4 (0x8)
        // (Param)
        public FName StatName {
            get => new(Pointer + 4);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 4), 8, 8);
        }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UpdateStat.Points
        // 0xC (0x4)
        // (Param)
        public int Points {
            get => *(int*)(Pointer + 12);
            set => *(int*)(Pointer + 12) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UpdateStat.ReturnValue
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
    private static UFunction _ptrUpdateStat;
    public bool UpdateStat(byte LocalUserNum, FName StatName, int Points) {
        _ptrUpdateStat ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.UpdateStat");

        var @params = stackalloc byte[17];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)StatName.Pointer, @params + 4, 8, 8);
        System.Buffer.MemoryCopy(&Points, @params + 12, 4, 4);

        ProcessEvent(_ptrUpdateStat, @params);

        return *(bool*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearSaveDataNoSpaceDialogCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearSaveDataNoSpaceDialogCompleteDelegate_Parameters : BaseObject {
        public ClearSaveDataNoSpaceDialogCompleteDelegate_Parameters() { }
        public ClearSaveDataNoSpaceDialogCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearSaveDataNoSpaceDialogCompleteDelegate.DeviceDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate DeviceDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearSaveDataNoSpaceDialogCompleteDelegate;
    public void ClearSaveDataNoSpaceDialogCompleteDelegate(FScriptDelegate DeviceDelegate) {
        _ptrClearSaveDataNoSpaceDialogCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearSaveDataNoSpaceDialogCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)DeviceDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearSaveDataNoSpaceDialogCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddSaveDataNoSpaceDialogCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddSaveDataNoSpaceDialogCompleteDelegate_Parameters : BaseObject {
        public AddSaveDataNoSpaceDialogCompleteDelegate_Parameters() { }
        public AddSaveDataNoSpaceDialogCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddSaveDataNoSpaceDialogCompleteDelegate.DeviceDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate DeviceDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddSaveDataNoSpaceDialogCompleteDelegate;
    public void AddSaveDataNoSpaceDialogCompleteDelegate(FScriptDelegate DeviceDelegate) {
        _ptrAddSaveDataNoSpaceDialogCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddSaveDataNoSpaceDialogCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)DeviceDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddSaveDataNoSpaceDialogCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnSaveDataNoSpaceDialogComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnSaveDataNoSpaceDialogComplete_Parameters : BaseObject {
        public OnSaveDataNoSpaceDialogComplete_Parameters() { }
        public OnSaveDataNoSpaceDialogComplete_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnSaveDataNoSpaceDialogComplete.bContinueWithoutSave
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bContinueWithoutSave {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnSaveDataNoSpaceDialogComplete;
    public void OnSaveDataNoSpaceDialogComplete(bool bContinueWithoutSave) {
        _ptrOnSaveDataNoSpaceDialogComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnSaveDataNoSpaceDialogComplete");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bContinueWithoutSave, @params, 4, 4);

        ProcessEvent(_ptrOnSaveDataNoSpaceDialogComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RecordPlayersRecentlyMetKeys
    // 0x3750E0
    // (Final | Public | HasOutParams)
    public unsafe class RecordPlayersRecentlyMetKeys_Parameters : BaseObject {
        public RecordPlayersRecentlyMetKeys_Parameters() { }
        public RecordPlayersRecentlyMetKeys_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RecordPlayersRecentlyMetKeys.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RecordPlayersRecentlyMetKeys.PlayerKeys
        // 0x8 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public StructTArray<UOnlineSubsystem.FFriendHistoryKey> PlayerKeys {
            get => new(Pointer + 8, 32);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RecordPlayersRecentlyMetKeys.ReturnValue
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
    private static UFunction _ptrRecordPlayersRecentlyMetKeys;
    public bool RecordPlayersRecentlyMetKeys(byte LocalUserNum, ref StructTArray<UOnlineSubsystem.FFriendHistoryKey> PlayerKeys) {
        _ptrRecordPlayersRecentlyMetKeys ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RecordPlayersRecentlyMetKeys");

        var @params = stackalloc byte[21];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)PlayerKeys.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrRecordPlayersRecentlyMetKeys, @params);

        var _PlayerKeysPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_PlayerKeysPtr, 16, 16);
        PlayerKeys = new(_PlayerKeysPtr, 32) { Allocated = true };

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsAchievementUnlocked
    // 0x3750E0
    // (Final | Public)
    public unsafe class IsAchievementUnlocked_Parameters : BaseObject {
        public IsAchievementUnlocked_Parameters() { }
        public IsAchievementUnlocked_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsAchievementUnlocked.AchievementId
        // 0x0 (0x4)
        // (Param)
        public int AchievementId {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsAchievementUnlocked.ReturnValue
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
    private static UFunction _ptrIsAchievementUnlocked;
    public bool IsAchievementUnlocked(int AchievementId) {
        _ptrIsAchievementUnlocked ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsAchievementUnlocked");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&AchievementId, @params, 4, 4);

        ProcessEvent(_ptrIsAchievementUnlocked, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowContentMarketplaceUI
    // 0x3750E0
    // (Final | Public)
    public unsafe class ShowContentMarketplaceUI_Parameters : BaseObject {
        public ShowContentMarketplaceUI_Parameters() { }
        public ShowContentMarketplaceUI_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowContentMarketplaceUI.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowContentMarketplaceUI.ReturnValue
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
    private static UFunction _ptrShowContentMarketplaceUI;
    public bool ShowContentMarketplaceUI(byte LocalUserNum) {
        _ptrShowContentMarketplaceUI ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowContentMarketplaceUI");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrShowContentMarketplaceUI, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowFriendsInviteUI
    // 0x3750E0
    // (Final | Public)
    public unsafe class ShowFriendsInviteUI_Parameters : BaseObject {
        public ShowFriendsInviteUI_Parameters() { }
        public ShowFriendsInviteUI_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowFriendsInviteUI.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowFriendsInviteUI.PlayerID
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowFriendsInviteUI.ReturnValue
        // 0x50 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 80) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 80) |= 0x1;
                else *(uint*)(Pointer + 80) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrShowFriendsInviteUI;
    public bool ShowFriendsInviteUI(byte LocalUserNum, U_Types_Core.FUniqueNetId PlayerID) {
        _ptrShowFriendsInviteUI ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowFriendsInviteUI");

        var @params = stackalloc byte[77];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params + 8, 72, 72);

        ProcessEvent(_ptrShowFriendsInviteUI, @params);

        return *(bool*)(@params + 80);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowAchievementsUI
    // 0x3750E0
    // (Final | Public)
    public unsafe class ShowAchievementsUI_Parameters : BaseObject {
        public ShowAchievementsUI_Parameters() { }
        public ShowAchievementsUI_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowAchievementsUI.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowAchievementsUI.ReturnValue
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
    private static UFunction _ptrShowAchievementsUI;
    public bool ShowAchievementsUI(byte LocalUserNum) {
        _ptrShowAchievementsUI ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowAchievementsUI");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrShowAchievementsUI, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowMessagesUI
    // 0x3750E0
    // (Final | Public)
    public unsafe class ShowMessagesUI_Parameters : BaseObject {
        public ShowMessagesUI_Parameters() { }
        public ShowMessagesUI_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowMessagesUI.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowMessagesUI.ReturnValue
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
    private static UFunction _ptrShowMessagesUI;
    public bool ShowMessagesUI(byte LocalUserNum) {
        _ptrShowMessagesUI ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowMessagesUI");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrShowMessagesUI, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowFeedbackUI
    // 0x3750E0
    // (Final | Public)
    public unsafe class ShowFeedbackUI_Parameters : BaseObject {
        public ShowFeedbackUI_Parameters() { }
        public ShowFeedbackUI_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowFeedbackUI.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowFeedbackUI.PlayerID
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowFeedbackUI.ReturnValue
        // 0x50 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 80) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 80) |= 0x1;
                else *(uint*)(Pointer + 80) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrShowFeedbackUI;
    public bool ShowFeedbackUI(byte LocalUserNum, U_Types_Core.FUniqueNetId PlayerID) {
        _ptrShowFeedbackUI ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowFeedbackUI");

        var @params = stackalloc byte[77];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params + 8, 72, 72);

        ProcessEvent(_ptrShowFeedbackUI, @params);

        return *(bool*)(@params + 80);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RemoveCanPlayOnlineChangedDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class RemoveCanPlayOnlineChangedDelegate_Parameters : BaseObject {
        public RemoveCanPlayOnlineChangedDelegate_Parameters() { }
        public RemoveCanPlayOnlineChangedDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RemoveCanPlayOnlineChangedDelegate.Callback
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate Callback {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrRemoveCanPlayOnlineChangedDelegate;
    public void RemoveCanPlayOnlineChangedDelegate(FScriptDelegate Callback) {
        _ptrRemoveCanPlayOnlineChangedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RemoveCanPlayOnlineChangedDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)Callback.Pointer, @params, 24, 24);

        ProcessEvent(_ptrRemoveCanPlayOnlineChangedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddCanPlayOnlineChangedDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddCanPlayOnlineChangedDelegate_Parameters : BaseObject {
        public AddCanPlayOnlineChangedDelegate_Parameters() { }
        public AddCanPlayOnlineChangedDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddCanPlayOnlineChangedDelegate.Callback
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate Callback {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddCanPlayOnlineChangedDelegate;
    public void AddCanPlayOnlineChangedDelegate(FScriptDelegate Callback) {
        _ptrAddCanPlayOnlineChangedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddCanPlayOnlineChangedDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)Callback.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddCanPlayOnlineChangedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanPlayOnlineChanged
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class CanPlayOnlineChanged_Parameters : BaseObject {
        public CanPlayOnlineChanged_Parameters() { }
        public CanPlayOnlineChanged_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanPlayOnlineChanged.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }
    }
    private static UFunction _ptrCanPlayOnlineChanged;
    public void CanPlayOnlineChanged(byte LocalUserNum) {
        _ptrCanPlayOnlineChanged ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanPlayOnlineChanged");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrCanPlayOnlineChanged, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearUserSignInCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearUserSignInCompleteDelegate_Parameters : BaseObject {
        public ClearUserSignInCompleteDelegate_Parameters() { }
        public ClearUserSignInCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearUserSignInCompleteDelegate.InDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearUserSignInCompleteDelegate;
    public void ClearUserSignInCompleteDelegate(FScriptDelegate InDelegate) {
        _ptrClearUserSignInCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearUserSignInCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearUserSignInCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddUserSignInCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddUserSignInCompleteDelegate_Parameters : BaseObject {
        public AddUserSignInCompleteDelegate_Parameters() { }
        public AddUserSignInCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddUserSignInCompleteDelegate.InDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddUserSignInCompleteDelegate;
    public void AddUserSignInCompleteDelegate(FScriptDelegate InDelegate) {
        _ptrAddUserSignInCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddUserSignInCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddUserSignInCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnUserSignInComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnUserSignInComplete_Parameters : BaseObject {
        public OnUserSignInComplete_Parameters() { }
        public OnUserSignInComplete_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnUserSignInComplete.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }
    }
    private static UFunction _ptrOnUserSignInComplete;
    public void OnUserSignInComplete(byte LocalUserNum) {
        _ptrOnUserSignInComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnUserSignInComplete");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrOnUserSignInComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowCustomMessageUI
    // 0x3750E0
    // (Final | HasOptionalParams | Public | HasOutParams)
    public unsafe class ShowCustomMessageUI_Parameters : BaseObject {
        public ShowCustomMessageUI_Parameters() { }
        public ShowCustomMessageUI_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowCustomMessageUI.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowCustomMessageUI.Recipients
        // 0x8 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public StructTArray<U_Types_Core.FUniqueNetId> Recipients {
            get => new(Pointer + 8, 72);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowCustomMessageUI.MessageTitle
        // 0x18 (0x10)
        // (Param | NeedCtorLink)
        public FString MessageTitle {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowCustomMessageUI.NonEditableMessage
        // 0x28 (0x10)
        // (Param | NeedCtorLink)
        public FString NonEditableMessage {
            get => new(Pointer + 40);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 40), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowCustomMessageUI.EditableMessage
        // 0x38 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString EditableMessage {
            get => new(Pointer + 56);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 56), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowCustomMessageUI.ReturnValue
        // 0x48 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 72) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 72) |= 0x1;
                else *(uint*)(Pointer + 72) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrShowCustomMessageUI;
    public bool ShowCustomMessageUI(byte LocalUserNum, ref StructTArray<U_Types_Core.FUniqueNetId> Recipients, FString MessageTitle, FString NonEditableMessage, FString EditableMessage = null) {
        _ptrShowCustomMessageUI ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowCustomMessageUI");

        var @params = stackalloc byte[69];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)Recipients.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy((void*)MessageTitle.Pointer, @params + 24, 16, 16);
        System.Buffer.MemoryCopy((void*)NonEditableMessage.Pointer, @params + 40, 16, 16);
        if (EditableMessage != null) System.Buffer.MemoryCopy((void*)EditableMessage.Pointer, @params + 56, 16, 16);

        ProcessEvent(_ptrShowCustomMessageUI, @params);

        var _RecipientsPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_RecipientsPtr, 16, 16);
        Recipients = new(_RecipientsPtr, 72) { Allocated = true };

        return *(bool*)(@params + 72);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearCrossTitleProfileSettings
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearCrossTitleProfileSettings_Parameters : BaseObject {
        public ClearCrossTitleProfileSettings_Parameters() { }
        public ClearCrossTitleProfileSettings_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearCrossTitleProfileSettings.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearCrossTitleProfileSettings.TitleId
        // 0x4 (0x4)
        // (Param)
        public int TitleId {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }
    }
    private static UFunction _ptrClearCrossTitleProfileSettings;
    public void ClearCrossTitleProfileSettings(byte LocalUserNum, int TitleId) {
        _ptrClearCrossTitleProfileSettings ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearCrossTitleProfileSettings");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&TitleId, @params + 4, 4, 4);

        ProcessEvent(_ptrClearCrossTitleProfileSettings, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetCrossTitleProfileSettings
    // 0x3750E0
    // (Final | Public)
    public unsafe class GetCrossTitleProfileSettings_Parameters : BaseObject {
        public GetCrossTitleProfileSettings_Parameters() { }
        public GetCrossTitleProfileSettings_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetCrossTitleProfileSettings.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetCrossTitleProfileSettings.TitleId
        // 0x4 (0x4)
        // (Param)
        public int TitleId {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }

        // ObjectProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetCrossTitleProfileSettings.ReturnValue
        // 0x8 (0x8)
        // (Param | OutParam | ReturnParam)
        public UOnlineProfileSettings ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }
    }
    private static UFunction _ptrGetCrossTitleProfileSettings;
    public UOnlineProfileSettings GetCrossTitleProfileSettings(byte LocalUserNum, int TitleId) {
        _ptrGetCrossTitleProfileSettings ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetCrossTitleProfileSettings");

        var @params = stackalloc byte[13];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&TitleId, @params + 4, 4, 4);

        ProcessEvent(_ptrGetCrossTitleProfileSettings, @params);

        return new(*(nint*)(@params + 8));
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadCrossTitleProfileSettingsCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearReadCrossTitleProfileSettingsCompleteDelegate_Parameters : BaseObject {
        public ClearReadCrossTitleProfileSettingsCompleteDelegate_Parameters() { }
        public ClearReadCrossTitleProfileSettingsCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadCrossTitleProfileSettingsCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadCrossTitleProfileSettingsCompleteDelegate.InDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearReadCrossTitleProfileSettingsCompleteDelegate;
    public void ClearReadCrossTitleProfileSettingsCompleteDelegate(byte LocalUserNum, FScriptDelegate InDelegate) {
        _ptrClearReadCrossTitleProfileSettingsCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadCrossTitleProfileSettingsCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearReadCrossTitleProfileSettingsCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadCrossTitleProfileSettingsCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddReadCrossTitleProfileSettingsCompleteDelegate_Parameters : BaseObject {
        public AddReadCrossTitleProfileSettingsCompleteDelegate_Parameters() { }
        public AddReadCrossTitleProfileSettingsCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadCrossTitleProfileSettingsCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadCrossTitleProfileSettingsCompleteDelegate.InDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddReadCrossTitleProfileSettingsCompleteDelegate;
    public void AddReadCrossTitleProfileSettingsCompleteDelegate(byte LocalUserNum, FScriptDelegate InDelegate) {
        _ptrAddReadCrossTitleProfileSettingsCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadCrossTitleProfileSettingsCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddReadCrossTitleProfileSettingsCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadCrossTitleProfileSettingsComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnReadCrossTitleProfileSettingsComplete_Parameters : BaseObject {
        public OnReadCrossTitleProfileSettingsComplete_Parameters() { }
        public OnReadCrossTitleProfileSettingsComplete_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadCrossTitleProfileSettingsComplete.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadCrossTitleProfileSettingsComplete.TitleId
        // 0x4 (0x4)
        // (Param)
        public int TitleId {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadCrossTitleProfileSettingsComplete.bWasSuccessful
        // 0x8 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)(Pointer + 8) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 8) |= 0x1;
                else *(uint*)(Pointer + 8) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnReadCrossTitleProfileSettingsComplete;
    public void OnReadCrossTitleProfileSettingsComplete(byte LocalUserNum, int TitleId, bool bWasSuccessful) {
        _ptrOnReadCrossTitleProfileSettingsComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadCrossTitleProfileSettingsComplete");

        var @params = stackalloc byte[9];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&TitleId, @params + 4, 4, 4);
        System.Buffer.MemoryCopy(&bWasSuccessful, @params + 8, 4, 4);

        ProcessEvent(_ptrOnReadCrossTitleProfileSettingsComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadCrossTitleProfileSettings
    // 0x3750E0
    // (Final | Public)
    public unsafe class ReadCrossTitleProfileSettings_Parameters : BaseObject {
        public ReadCrossTitleProfileSettings_Parameters() { }
        public ReadCrossTitleProfileSettings_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadCrossTitleProfileSettings.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadCrossTitleProfileSettings.TitleId
        // 0x4 (0x4)
        // (Param)
        public int TitleId {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }

        // ObjectProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadCrossTitleProfileSettings.ProfileSettings
        // 0x8 (0x8)
        // (Param)
        public UOnlineProfileSettings ProfileSettings {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadCrossTitleProfileSettings.ReturnValue
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
    private static UFunction _ptrReadCrossTitleProfileSettings;
    public bool ReadCrossTitleProfileSettings(byte LocalUserNum, int TitleId, UOnlineProfileSettings ProfileSettings) {
        _ptrReadCrossTitleProfileSettings ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadCrossTitleProfileSettings");

        var @params = stackalloc byte[17];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&TitleId, @params + 4, 4, 4);
        System.Buffer.MemoryCopy((void*)ProfileSettings.Pointer, @params + 8, 8, 8);

        ProcessEvent(_ptrReadCrossTitleProfileSettings, @params);

        return *(bool*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearWritePlayerStorageCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearWritePlayerStorageCompleteDelegate_Parameters : BaseObject {
        public ClearWritePlayerStorageCompleteDelegate_Parameters() { }
        public ClearWritePlayerStorageCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearWritePlayerStorageCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearWritePlayerStorageCompleteDelegate.InDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearWritePlayerStorageCompleteDelegate;
    public void ClearWritePlayerStorageCompleteDelegate(byte LocalUserNum, FScriptDelegate InDelegate) {
        _ptrClearWritePlayerStorageCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearWritePlayerStorageCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearWritePlayerStorageCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddWritePlayerStorageCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddWritePlayerStorageCompleteDelegate_Parameters : BaseObject {
        public AddWritePlayerStorageCompleteDelegate_Parameters() { }
        public AddWritePlayerStorageCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddWritePlayerStorageCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddWritePlayerStorageCompleteDelegate.InDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddWritePlayerStorageCompleteDelegate;
    public void AddWritePlayerStorageCompleteDelegate(byte LocalUserNum, FScriptDelegate InDelegate) {
        _ptrAddWritePlayerStorageCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddWritePlayerStorageCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddWritePlayerStorageCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnWritePlayerStorageComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnWritePlayerStorageComplete_Parameters : BaseObject {
        public OnWritePlayerStorageComplete_Parameters() { }
        public OnWritePlayerStorageComplete_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnWritePlayerStorageComplete.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnWritePlayerStorageComplete.bWasSuccessful
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnWritePlayerStorageComplete;
    public void OnWritePlayerStorageComplete(byte LocalUserNum, bool bWasSuccessful) {
        _ptrOnWritePlayerStorageComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnWritePlayerStorageComplete");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&bWasSuccessful, @params + 4, 4, 4);

        ProcessEvent(_ptrOnWritePlayerStorageComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.WritePlayerStorage
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class WritePlayerStorage_Parameters : BaseObject {
        public WritePlayerStorage_Parameters() { }
        public WritePlayerStorage_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.WritePlayerStorage.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ObjectProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.WritePlayerStorage.PlayerStorage
        // 0x8 (0x8)
        // (Param)
        public UOnlinePlayerStorage PlayerStorage {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.WritePlayerStorage.DeviceID
        // 0x10 (0x4)
        // (OptionalParam | Param)
        public int DeviceID {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.WritePlayerStorage.ReturnValue
        // 0x14 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 20) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 20) |= 0x1;
                else *(uint*)(Pointer + 20) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrWritePlayerStorage;
    public bool WritePlayerStorage(byte LocalUserNum, UOnlinePlayerStorage PlayerStorage, int DeviceID = 0) {
        _ptrWritePlayerStorage ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.WritePlayerStorage");

        var @params = stackalloc byte[17];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)PlayerStorage.Pointer, @params + 8, 8, 8);
        System.Buffer.MemoryCopy(&DeviceID, @params + 16, 4, 4);

        ProcessEvent(_ptrWritePlayerStorage, @params);

        return *(bool*)(@params + 20);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadPlayerStorageForNetIdCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearReadPlayerStorageForNetIdCompleteDelegate_Parameters : BaseObject {
        public ClearReadPlayerStorageForNetIdCompleteDelegate_Parameters() { }
        public ClearReadPlayerStorageForNetIdCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadPlayerStorageForNetIdCompleteDelegate.NetId
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId NetId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadPlayerStorageForNetIdCompleteDelegate.InDelegate
        // 0x48 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer + 72);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 72), 24, 24);
        }
    }
    private static UFunction _ptrClearReadPlayerStorageForNetIdCompleteDelegate;
    public void ClearReadPlayerStorageForNetIdCompleteDelegate(U_Types_Core.FUniqueNetId NetId, FScriptDelegate InDelegate) {
        _ptrClearReadPlayerStorageForNetIdCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadPlayerStorageForNetIdCompleteDelegate");

        var @params = stackalloc byte[96];
        System.Buffer.MemoryCopy((void*)NetId.Pointer, @params, 72, 72);
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params + 72, 24, 24);

        ProcessEvent(_ptrClearReadPlayerStorageForNetIdCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadPlayerStorageForNetIdCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddReadPlayerStorageForNetIdCompleteDelegate_Parameters : BaseObject {
        public AddReadPlayerStorageForNetIdCompleteDelegate_Parameters() { }
        public AddReadPlayerStorageForNetIdCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadPlayerStorageForNetIdCompleteDelegate.NetId
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId NetId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadPlayerStorageForNetIdCompleteDelegate.InDelegate
        // 0x48 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer + 72);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 72), 24, 24);
        }
    }
    private static UFunction _ptrAddReadPlayerStorageForNetIdCompleteDelegate;
    public void AddReadPlayerStorageForNetIdCompleteDelegate(U_Types_Core.FUniqueNetId NetId, FScriptDelegate InDelegate) {
        _ptrAddReadPlayerStorageForNetIdCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadPlayerStorageForNetIdCompleteDelegate");

        var @params = stackalloc byte[96];
        System.Buffer.MemoryCopy((void*)NetId.Pointer, @params, 72, 72);
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params + 72, 24, 24);

        ProcessEvent(_ptrAddReadPlayerStorageForNetIdCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadPlayerStorageForNetIdComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnReadPlayerStorageForNetIdComplete_Parameters : BaseObject {
        public OnReadPlayerStorageForNetIdComplete_Parameters() { }
        public OnReadPlayerStorageForNetIdComplete_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadPlayerStorageForNetIdComplete.NetId
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId NetId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadPlayerStorageForNetIdComplete.bWasSuccessful
        // 0x48 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)(Pointer + 72) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 72) |= 0x1;
                else *(uint*)(Pointer + 72) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnReadPlayerStorageForNetIdComplete;
    public void OnReadPlayerStorageForNetIdComplete(U_Types_Core.FUniqueNetId NetId, bool bWasSuccessful) {
        _ptrOnReadPlayerStorageForNetIdComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadPlayerStorageForNetIdComplete");

        var @params = stackalloc byte[76];
        System.Buffer.MemoryCopy((void*)NetId.Pointer, @params, 72, 72);
        System.Buffer.MemoryCopy(&bWasSuccessful, @params + 72, 4, 4);

        ProcessEvent(_ptrOnReadPlayerStorageForNetIdComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadPlayerStorageForNetId
    // 0x3750E0
    // (Final | Public)
    public unsafe class ReadPlayerStorageForNetId_Parameters : BaseObject {
        public ReadPlayerStorageForNetId_Parameters() { }
        public ReadPlayerStorageForNetId_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadPlayerStorageForNetId.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadPlayerStorageForNetId.NetId
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId NetId {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // ObjectProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadPlayerStorageForNetId.PlayerStorage
        // 0x50 (0x8)
        // (Param)
        public UOnlinePlayerStorage PlayerStorage {
            get {
                var pointer = *(nint*)(Pointer + 80);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 80) = value.Pointer;
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadPlayerStorageForNetId.ReturnValue
        // 0x58 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 88) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 88) |= 0x1;
                else *(uint*)(Pointer + 88) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrReadPlayerStorageForNetId;
    public bool ReadPlayerStorageForNetId(byte LocalUserNum, U_Types_Core.FUniqueNetId NetId, UOnlinePlayerStorage PlayerStorage) {
        _ptrReadPlayerStorageForNetId ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadPlayerStorageForNetId");

        var @params = stackalloc byte[85];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)NetId.Pointer, @params + 8, 72, 72);
        System.Buffer.MemoryCopy((void*)PlayerStorage.Pointer, @params + 80, 8, 8);

        ProcessEvent(_ptrReadPlayerStorageForNetId, @params);

        return *(bool*)(@params + 88);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadPlayerStorageCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearReadPlayerStorageCompleteDelegate_Parameters : BaseObject {
        public ClearReadPlayerStorageCompleteDelegate_Parameters() { }
        public ClearReadPlayerStorageCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadPlayerStorageCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadPlayerStorageCompleteDelegate.InDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearReadPlayerStorageCompleteDelegate;
    public void ClearReadPlayerStorageCompleteDelegate(byte LocalUserNum, FScriptDelegate InDelegate) {
        _ptrClearReadPlayerStorageCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadPlayerStorageCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearReadPlayerStorageCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadPlayerStorageCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddReadPlayerStorageCompleteDelegate_Parameters : BaseObject {
        public AddReadPlayerStorageCompleteDelegate_Parameters() { }
        public AddReadPlayerStorageCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadPlayerStorageCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadPlayerStorageCompleteDelegate.InDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddReadPlayerStorageCompleteDelegate;
    public void AddReadPlayerStorageCompleteDelegate(byte LocalUserNum, FScriptDelegate InDelegate) {
        _ptrAddReadPlayerStorageCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadPlayerStorageCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)InDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddReadPlayerStorageCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadPlayerStorageComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnReadPlayerStorageComplete_Parameters : BaseObject {
        public OnReadPlayerStorageComplete_Parameters() { }
        public OnReadPlayerStorageComplete_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadPlayerStorageComplete.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadPlayerStorageComplete.bWasSuccessful
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnReadPlayerStorageComplete;
    public void OnReadPlayerStorageComplete(byte LocalUserNum, bool bWasSuccessful) {
        _ptrOnReadPlayerStorageComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadPlayerStorageComplete");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&bWasSuccessful, @params + 4, 4, 4);

        ProcessEvent(_ptrOnReadPlayerStorageComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadPlayerStorage
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class ReadPlayerStorage_Parameters : BaseObject {
        public ReadPlayerStorage_Parameters() { }
        public ReadPlayerStorage_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadPlayerStorage.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ObjectProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadPlayerStorage.PlayerStorage
        // 0x8 (0x8)
        // (Param)
        public UOnlinePlayerStorage PlayerStorage {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadPlayerStorage.DeviceID
        // 0x10 (0x4)
        // (OptionalParam | Param)
        public int DeviceID {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadPlayerStorage.ReturnValue
        // 0x14 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 20) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 20) |= 0x1;
                else *(uint*)(Pointer + 20) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrReadPlayerStorage;
    public bool ReadPlayerStorage(byte LocalUserNum, UOnlinePlayerStorage PlayerStorage, int DeviceID = 0) {
        _ptrReadPlayerStorage ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadPlayerStorage");

        var @params = stackalloc byte[17];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)PlayerStorage.Pointer, @params + 8, 8, 8);
        System.Buffer.MemoryCopy(&DeviceID, @params + 16, 4, 4);

        ProcessEvent(_ptrReadPlayerStorage, @params);

        return *(bool*)(@params + 20);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetPlayerStorage
    // 0x3750E0
    // (Final | Public)
    public unsafe class GetPlayerStorage_Parameters : BaseObject {
        public GetPlayerStorage_Parameters() { }
        public GetPlayerStorage_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetPlayerStorage.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ObjectProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetPlayerStorage.ReturnValue
        // 0x8 (0x8)
        // (Param | OutParam | ReturnParam)
        public UOnlinePlayerStorage ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }
    }
    private static UFunction _ptrGetPlayerStorage;
    public UOnlinePlayerStorage GetPlayerStorage(byte LocalUserNum) {
        _ptrGetPlayerStorage ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetPlayerStorage");

        var @params = stackalloc byte[9];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrGetPlayerStorage, @params);

        return new(*(nint*)(@params + 8));
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RequestNativePlatformAuthTicket
    // 0x3750E0
    // (Final | Defined | Private | HasDefaults)
    public unsafe class RequestNativePlatformAuthTicket_Parameters : BaseObject {
        public RequestNativePlatformAuthTicket_Parameters() { }
        public RequestNativePlatformAuthTicket_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RequestNativePlatformAuthTicket.LocalUserNum
        // 0x0 (0x4)
        // (Param)
        public int LocalUserNum {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RequestNativePlatformAuthTicket.Callback
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate Callback {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrRequestNativePlatformAuthTicket;
    public void RequestNativePlatformAuthTicket(int LocalUserNum, FScriptDelegate Callback) {
        _ptrRequestNativePlatformAuthTicket ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RequestNativePlatformAuthTicket");

        var @params = stackalloc byte[28];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)Callback.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrRequestNativePlatformAuthTicket, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnRequestNativePlatformAuthTicketComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnRequestNativePlatformAuthTicketComplete_Parameters : BaseObject {
        public OnRequestNativePlatformAuthTicketComplete_Parameters() { }
        public OnRequestNativePlatformAuthTicketComplete_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnRequestNativePlatformAuthTicketComplete.LocalUserNum
        // 0x0 (0x4)
        // (Param)
        public int LocalUserNum {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnRequestNativePlatformAuthTicketComplete.PlatformAuthTicket
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString PlatformAuthTicket {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrOnRequestNativePlatformAuthTicketComplete;
    public void OnRequestNativePlatformAuthTicketComplete(int LocalUserNum, FString PlatformAuthTicket) {
        _ptrOnRequestNativePlatformAuthTicketComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnRequestNativePlatformAuthTicketComplete");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)PlatformAuthTicket.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrOnRequestNativePlatformAuthTicketComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.LinkedAccount
    // 0x3750E0
    // (Final | Defined | Event | Private)
    public unsafe class LinkedAccount_Parameters : BaseObject {
        public LinkedAccount_Parameters() { }
        public LinkedAccount_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.LinkedAccount.LocalUserNum
        // 0x0 (0x4)
        // (Param)
        public int LocalUserNum {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrLinkedAccount;
    public void LinkedAccount(int LocalUserNum) {
        _ptrLinkedAccount ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.LinkedAccount");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 4, 4);

        ProcessEvent(_ptrLinkedAccount, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ConnectLogin
    // 0xCDCD10
    // (Final | Native | Private)
    public unsafe class ConnectLogin_Parameters : BaseObject {
        public ConnectLogin_Parameters() { }
        public ConnectLogin_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ConnectLogin.LocalUserNum
        // 0x0 (0x4)
        // (Param)
        public int LocalUserNum {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrConnectLogin;
    public void ConnectLogin(int LocalUserNum) {
        _ptrConnectLogin ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ConnectLogin");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 4, 4);

        _ptrConnectLogin.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrConnectLogin, @params);
        _ptrConnectLogin.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.HasIncomingFriendInvite
    // 0xCDCA90
    // (Final | Native | Public)
    public unsafe class HasIncomingFriendInvite_Parameters : BaseObject {
        public HasIncomingFriendInvite_Parameters() { }
        public HasIncomingFriendInvite_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.HasIncomingFriendInvite.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.HasIncomingFriendInvite.InviteFrom
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId InviteFrom {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.HasIncomingFriendInvite.ReturnValue
        // 0x50 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 80) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 80) |= 0x1;
                else *(uint*)(Pointer + 80) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrHasIncomingFriendInvite;
    public bool HasIncomingFriendInvite(byte LocalUserNum, U_Types_Core.FUniqueNetId InviteFrom) {
        _ptrHasIncomingFriendInvite ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.HasIncomingFriendInvite");

        var @params = stackalloc byte[77];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)InviteFrom.Pointer, @params + 8, 72, 72);

        _ptrHasIncomingFriendInvite.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrHasIncomingFriendInvite, @params);
        _ptrHasIncomingFriendInvite.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 80);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SupportInGameLogin
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class SupportInGameLogin_Parameters : BaseObject {
        public SupportInGameLogin_Parameters() { }
        public SupportInGameLogin_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SupportInGameLogin.ReturnValue
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
    private static UFunction _ptrSupportInGameLogin;
    public bool SupportInGameLogin() {
        _ptrSupportInGameLogin ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SupportInGameLogin");

        var @params = stackalloc byte[4];

        ProcessEvent(_ptrSupportInGameLogin, @params);

        return *(bool*)@params;
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.HasFriendsFunctionality
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class HasFriendsFunctionality_Parameters : BaseObject {
        public HasFriendsFunctionality_Parameters() { }
        public HasFriendsFunctionality_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.HasFriendsFunctionality.ReturnValue
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
    private static UFunction _ptrHasFriendsFunctionality;
    public bool HasFriendsFunctionality() {
        _ptrHasFriendsFunctionality ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.HasFriendsFunctionality");

        var @params = stackalloc byte[4];

        ProcessEvent(_ptrHasFriendsFunctionality, @params);

        return *(bool*)@params;
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.DeleteMessage
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class DeleteMessage_Parameters : BaseObject {
        public DeleteMessage_Parameters() { }
        public DeleteMessage_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.DeleteMessage.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.DeleteMessage.MessageIndex
        // 0x4 (0x4)
        // (Param)
        public int MessageIndex {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.DeleteMessage.ReturnValue
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
    private static UFunction _ptrDeleteMessage;
    public bool DeleteMessage(byte LocalUserNum, int MessageIndex) {
        _ptrDeleteMessage ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.DeleteMessage");

        var @params = stackalloc byte[9];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&MessageIndex, @params + 4, 4, 4);

        ProcessEvent(_ptrDeleteMessage, @params);

        return *(bool*)(@params + 8);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearFriendMessageReceivedDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearFriendMessageReceivedDelegate_Parameters : BaseObject {
        public ClearFriendMessageReceivedDelegate_Parameters() { }
        public ClearFriendMessageReceivedDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearFriendMessageReceivedDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearFriendMessageReceivedDelegate.MessageDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate MessageDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearFriendMessageReceivedDelegate;
    public void ClearFriendMessageReceivedDelegate(byte LocalUserNum, FScriptDelegate MessageDelegate) {
        _ptrClearFriendMessageReceivedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearFriendMessageReceivedDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)MessageDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearFriendMessageReceivedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendMessageReceivedDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddFriendMessageReceivedDelegate_Parameters : BaseObject {
        public AddFriendMessageReceivedDelegate_Parameters() { }
        public AddFriendMessageReceivedDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendMessageReceivedDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendMessageReceivedDelegate.MessageDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate MessageDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddFriendMessageReceivedDelegate;
    public void AddFriendMessageReceivedDelegate(byte LocalUserNum, FScriptDelegate MessageDelegate) {
        _ptrAddFriendMessageReceivedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendMessageReceivedDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)MessageDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddFriendMessageReceivedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnFriendMessageReceived
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnFriendMessageReceived_Parameters : BaseObject {
        public OnFriendMessageReceived_Parameters() { }
        public OnFriendMessageReceived_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnFriendMessageReceived.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnFriendMessageReceived.SendingPlayer
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId SendingPlayer {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnFriendMessageReceived.SendingNick
        // 0x50 (0x10)
        // (Param | NeedCtorLink)
        public FString SendingNick {
            get => new(Pointer + 80);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 80), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnFriendMessageReceived.Message
        // 0x60 (0x10)
        // (Param | NeedCtorLink)
        public FString Message {
            get => new(Pointer + 96);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 96), 16, 16);
        }
    }
    private static UFunction _ptrOnFriendMessageReceived;
    public void OnFriendMessageReceived(byte LocalUserNum, U_Types_Core.FUniqueNetId SendingPlayer, FString SendingNick, FString Message) {
        _ptrOnFriendMessageReceived ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnFriendMessageReceived");

        var @params = stackalloc byte[105];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)SendingPlayer.Pointer, @params + 8, 72, 72);
        System.Buffer.MemoryCopy((void*)SendingNick.Pointer, @params + 80, 16, 16);
        System.Buffer.MemoryCopy((void*)Message.Pointer, @params + 96, 16, 16);

        ProcessEvent(_ptrOnFriendMessageReceived, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetFriendMessages
    // 0x3750E0
    // (Final | Defined | Public | HasOutParams)
    public unsafe class GetFriendMessages_Parameters : BaseObject {
        public GetFriendMessages_Parameters() { }
        public GetFriendMessages_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetFriendMessages.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetFriendMessages.FriendMessages
        // 0x8 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public StructTArray<UOnlineSubsystem.FOnlineFriendMessage> FriendMessages {
            get => new(Pointer + 8, 112);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrGetFriendMessages;
    public void GetFriendMessages(byte LocalUserNum, ref StructTArray<UOnlineSubsystem.FOnlineFriendMessage> FriendMessages) {
        _ptrGetFriendMessages ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetFriendMessages");

        var @params = stackalloc byte[17];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)FriendMessages.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrGetFriendMessages, @params);

        var _FriendMessagesPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_FriendMessagesPtr, 16, 16);
        FriendMessages = new(_FriendMessagesPtr, 112) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearJoinFriendGameCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearJoinFriendGameCompleteDelegate_Parameters : BaseObject {
        public ClearJoinFriendGameCompleteDelegate_Parameters() { }
        public ClearJoinFriendGameCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearJoinFriendGameCompleteDelegate.JoinFriendGameCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate JoinFriendGameCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearJoinFriendGameCompleteDelegate;
    public void ClearJoinFriendGameCompleteDelegate(FScriptDelegate JoinFriendGameCompleteDelegate) {
        _ptrClearJoinFriendGameCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearJoinFriendGameCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)JoinFriendGameCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearJoinFriendGameCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddJoinFriendGameCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddJoinFriendGameCompleteDelegate_Parameters : BaseObject {
        public AddJoinFriendGameCompleteDelegate_Parameters() { }
        public AddJoinFriendGameCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddJoinFriendGameCompleteDelegate.JoinFriendGameCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate JoinFriendGameCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddJoinFriendGameCompleteDelegate;
    public void AddJoinFriendGameCompleteDelegate(FScriptDelegate JoinFriendGameCompleteDelegate) {
        _ptrAddJoinFriendGameCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddJoinFriendGameCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)JoinFriendGameCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddJoinFriendGameCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnJoinFriendGameComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnJoinFriendGameComplete_Parameters : BaseObject {
        public OnJoinFriendGameComplete_Parameters() { }
        public OnJoinFriendGameComplete_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnJoinFriendGameComplete.bWasSuccessful
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnJoinFriendGameComplete;
    public void OnJoinFriendGameComplete(bool bWasSuccessful) {
        _ptrOnJoinFriendGameComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnJoinFriendGameComplete");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bWasSuccessful, @params, 4, 4);

        ProcessEvent(_ptrOnJoinFriendGameComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.JoinFriendGame
    // 0x3750E0
    // (Final | Public)
    public unsafe class JoinFriendGame_Parameters : BaseObject {
        public JoinFriendGame_Parameters() { }
        public JoinFriendGame_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.JoinFriendGame.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.JoinFriendGame.Friend
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId Friend {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.JoinFriendGame.ReturnValue
        // 0x50 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 80) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 80) |= 0x1;
                else *(uint*)(Pointer + 80) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrJoinFriendGame;
    public bool JoinFriendGame(byte LocalUserNum, U_Types_Core.FUniqueNetId Friend) {
        _ptrJoinFriendGame ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.JoinFriendGame");

        var @params = stackalloc byte[77];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)Friend.Pointer, @params + 8, 72, 72);

        ProcessEvent(_ptrJoinFriendGame, @params);

        return *(bool*)(@params + 80);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReceivedGameInviteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearReceivedGameInviteDelegate_Parameters : BaseObject {
        public ClearReceivedGameInviteDelegate_Parameters() { }
        public ClearReceivedGameInviteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReceivedGameInviteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReceivedGameInviteDelegate.ReceivedGameInviteDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ReceivedGameInviteDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearReceivedGameInviteDelegate;
    public void ClearReceivedGameInviteDelegate(byte LocalUserNum, FScriptDelegate ReceivedGameInviteDelegate) {
        _ptrClearReceivedGameInviteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReceivedGameInviteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)ReceivedGameInviteDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearReceivedGameInviteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReceivedGameInviteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddReceivedGameInviteDelegate_Parameters : BaseObject {
        public AddReceivedGameInviteDelegate_Parameters() { }
        public AddReceivedGameInviteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReceivedGameInviteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReceivedGameInviteDelegate.ReceivedGameInviteDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ReceivedGameInviteDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddReceivedGameInviteDelegate;
    public void AddReceivedGameInviteDelegate(byte LocalUserNum, FScriptDelegate ReceivedGameInviteDelegate) {
        _ptrAddReceivedGameInviteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReceivedGameInviteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)ReceivedGameInviteDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddReceivedGameInviteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReceivedGameInvite
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnReceivedGameInvite_Parameters : BaseObject {
        public OnReceivedGameInvite_Parameters() { }
        public OnReceivedGameInvite_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReceivedGameInvite.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReceivedGameInvite.InviterName
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString InviterName {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrOnReceivedGameInvite;
    public void OnReceivedGameInvite(byte LocalUserNum, FString InviterName) {
        _ptrOnReceivedGameInvite ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReceivedGameInvite");

        var @params = stackalloc byte[17];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)InviterName.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrOnReceivedGameInvite, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SendGameInviteToFriends
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class SendGameInviteToFriends_Parameters : BaseObject {
        public SendGameInviteToFriends_Parameters() { }
        public SendGameInviteToFriends_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SendGameInviteToFriends.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SendGameInviteToFriends.Friends
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public StructTArray<U_Types_Core.FUniqueNetId> Friends {
            get => new(Pointer + 8, 72);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SendGameInviteToFriends.Text
        // 0x18 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Text {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SendGameInviteToFriends.ReturnValue
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
    private static UFunction _ptrSendGameInviteToFriends;
    public bool SendGameInviteToFriends(byte LocalUserNum, StructTArray<U_Types_Core.FUniqueNetId> Friends, FString Text = null) {
        _ptrSendGameInviteToFriends ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SendGameInviteToFriends");

        var @params = stackalloc byte[37];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)Friends.Pointer, @params + 8, 16, 16);
        if (Text != null) System.Buffer.MemoryCopy((void*)Text.Pointer, @params + 24, 16, 16);

        ProcessEvent(_ptrSendGameInviteToFriends, @params);

        return *(bool*)(@params + 40);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SendGameInviteToFriend
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class SendGameInviteToFriend_Parameters : BaseObject {
        public SendGameInviteToFriend_Parameters() { }
        public SendGameInviteToFriend_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SendGameInviteToFriend.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SendGameInviteToFriend.Friend
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId Friend {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SendGameInviteToFriend.Text
        // 0x50 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Text {
            get => new(Pointer + 80);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 80), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SendGameInviteToFriend.ReturnValue
        // 0x60 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 96) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 96) |= 0x1;
                else *(uint*)(Pointer + 96) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSendGameInviteToFriend;
    public bool SendGameInviteToFriend(byte LocalUserNum, U_Types_Core.FUniqueNetId Friend, FString Text = null) {
        _ptrSendGameInviteToFriend ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SendGameInviteToFriend");

        var @params = stackalloc byte[93];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)Friend.Pointer, @params + 8, 72, 72);
        if (Text != null) System.Buffer.MemoryCopy((void*)Text.Pointer, @params + 80, 16, 16);

        ProcessEvent(_ptrSendGameInviteToFriend, @params);

        return *(bool*)(@params + 96);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SendMessageToFriend
    // 0x3750E0
    // (Final | Public)
    public unsafe class SendMessageToFriend_Parameters : BaseObject {
        public SendMessageToFriend_Parameters() { }
        public SendMessageToFriend_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SendMessageToFriend.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SendMessageToFriend.Friend
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId Friend {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SendMessageToFriend.Message
        // 0x50 (0x10)
        // (Param | NeedCtorLink)
        public FString Message {
            get => new(Pointer + 80);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 80), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SendMessageToFriend.ReturnValue
        // 0x60 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 96) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 96) |= 0x1;
                else *(uint*)(Pointer + 96) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSendMessageToFriend;
    public bool SendMessageToFriend(byte LocalUserNum, U_Types_Core.FUniqueNetId Friend, FString Message) {
        _ptrSendMessageToFriend ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SendMessageToFriend");

        var @params = stackalloc byte[93];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)Friend.Pointer, @params + 8, 72, 72);
        System.Buffer.MemoryCopy((void*)Message.Pointer, @params + 80, 16, 16);

        ProcessEvent(_ptrSendMessageToFriend, @params);

        return *(bool*)(@params + 96);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearFriendInviteCanceledDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearFriendInviteCanceledDelegate_Parameters : BaseObject {
        public ClearFriendInviteCanceledDelegate_Parameters() { }
        public ClearFriendInviteCanceledDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearFriendInviteCanceledDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearFriendInviteCanceledDelegate.InviteDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InviteDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearFriendInviteCanceledDelegate;
    public void ClearFriendInviteCanceledDelegate(byte LocalUserNum, FScriptDelegate InviteDelegate) {
        _ptrClearFriendInviteCanceledDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearFriendInviteCanceledDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)InviteDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearFriendInviteCanceledDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendInviteCanceledDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddFriendInviteCanceledDelegate_Parameters : BaseObject {
        public AddFriendInviteCanceledDelegate_Parameters() { }
        public AddFriendInviteCanceledDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendInviteCanceledDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendInviteCanceledDelegate.InviteDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InviteDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddFriendInviteCanceledDelegate;
    public void AddFriendInviteCanceledDelegate(byte LocalUserNum, FScriptDelegate InviteDelegate) {
        _ptrAddFriendInviteCanceledDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendInviteCanceledDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)InviteDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddFriendInviteCanceledDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnFriendInviteCanceled
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnFriendInviteCanceled_Parameters : BaseObject {
        public OnFriendInviteCanceled_Parameters() { }
        public OnFriendInviteCanceled_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnFriendInviteCanceled.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnFriendInviteCanceled.CanceledUserId
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId CanceledUserId {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }
    }
    private static UFunction _ptrOnFriendInviteCanceled;
    public void OnFriendInviteCanceled(byte LocalUserNum, U_Types_Core.FUniqueNetId CanceledUserId) {
        _ptrOnFriendInviteCanceled ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnFriendInviteCanceled");

        var @params = stackalloc byte[73];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)CanceledUserId.Pointer, @params + 8, 72, 72);

        ProcessEvent(_ptrOnFriendInviteCanceled, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearFriendInviteReceivedDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearFriendInviteReceivedDelegate_Parameters : BaseObject {
        public ClearFriendInviteReceivedDelegate_Parameters() { }
        public ClearFriendInviteReceivedDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearFriendInviteReceivedDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearFriendInviteReceivedDelegate.InviteDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InviteDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearFriendInviteReceivedDelegate;
    public void ClearFriendInviteReceivedDelegate(byte LocalUserNum, FScriptDelegate InviteDelegate) {
        _ptrClearFriendInviteReceivedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearFriendInviteReceivedDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)InviteDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearFriendInviteReceivedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendInviteReceivedDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddFriendInviteReceivedDelegate_Parameters : BaseObject {
        public AddFriendInviteReceivedDelegate_Parameters() { }
        public AddFriendInviteReceivedDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendInviteReceivedDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendInviteReceivedDelegate.InviteDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InviteDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddFriendInviteReceivedDelegate;
    public void AddFriendInviteReceivedDelegate(byte LocalUserNum, FScriptDelegate InviteDelegate) {
        _ptrAddFriendInviteReceivedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendInviteReceivedDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)InviteDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddFriendInviteReceivedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnFriendInviteReceived
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnFriendInviteReceived_Parameters : BaseObject {
        public OnFriendInviteReceived_Parameters() { }
        public OnFriendInviteReceived_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnFriendInviteReceived.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnFriendInviteReceived.RequestingPlayer
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId RequestingPlayer {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnFriendInviteReceived.RequestingNick
        // 0x50 (0x10)
        // (Param | NeedCtorLink)
        public FString RequestingNick {
            get => new(Pointer + 80);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 80), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnFriendInviteReceived.Message
        // 0x60 (0x10)
        // (Param | NeedCtorLink)
        public FString Message {
            get => new(Pointer + 96);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 96), 16, 16);
        }
    }
    private static UFunction _ptrOnFriendInviteReceived;
    public void OnFriendInviteReceived(byte LocalUserNum, U_Types_Core.FUniqueNetId RequestingPlayer, FString RequestingNick, FString Message) {
        _ptrOnFriendInviteReceived ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnFriendInviteReceived");

        var @params = stackalloc byte[105];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)RequestingPlayer.Pointer, @params + 8, 72, 72);
        System.Buffer.MemoryCopy((void*)RequestingNick.Pointer, @params + 80, 16, 16);
        System.Buffer.MemoryCopy((void*)Message.Pointer, @params + 96, 16, 16);

        ProcessEvent(_ptrOnFriendInviteReceived, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RemoveFriend
    // 0x3750E0
    // (Final | Public)
    public unsafe class RemoveFriend_Parameters : BaseObject {
        public RemoveFriend_Parameters() { }
        public RemoveFriend_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RemoveFriend.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RemoveFriend.FormerFriend
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId FormerFriend {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RemoveFriend.ReturnValue
        // 0x50 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 80) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 80) |= 0x1;
                else *(uint*)(Pointer + 80) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrRemoveFriend;
    public bool RemoveFriend(byte LocalUserNum, U_Types_Core.FUniqueNetId FormerFriend) {
        _ptrRemoveFriend ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.RemoveFriend");

        var @params = stackalloc byte[77];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)FormerFriend.Pointer, @params + 8, 72, 72);

        ProcessEvent(_ptrRemoveFriend, @params);

        return *(bool*)(@params + 80);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearRemoveFriendCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearRemoveFriendCompleteDelegate_Parameters : BaseObject {
        public ClearRemoveFriendCompleteDelegate_Parameters() { }
        public ClearRemoveFriendCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearRemoveFriendCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearRemoveFriendCompleteDelegate.RemoveFriendDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate RemoveFriendDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearRemoveFriendCompleteDelegate;
    public void ClearRemoveFriendCompleteDelegate(byte LocalUserNum, FScriptDelegate RemoveFriendDelegate) {
        _ptrClearRemoveFriendCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearRemoveFriendCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)RemoveFriendDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearRemoveFriendCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddRemoveFriendCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddRemoveFriendCompleteDelegate_Parameters : BaseObject {
        public AddRemoveFriendCompleteDelegate_Parameters() { }
        public AddRemoveFriendCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddRemoveFriendCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddRemoveFriendCompleteDelegate.RemoveFriendDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate RemoveFriendDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddRemoveFriendCompleteDelegate;
    public void AddRemoveFriendCompleteDelegate(byte LocalUserNum, FScriptDelegate RemoveFriendDelegate) {
        _ptrAddRemoveFriendCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddRemoveFriendCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)RemoveFriendDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddRemoveFriendCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnRemoveFriendComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnRemoveFriendComplete_Parameters : BaseObject {
        public OnRemoveFriendComplete_Parameters() { }
        public OnRemoveFriendComplete_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnRemoveFriendComplete.bWasSuccessful
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }

        // MISSED OFFSET: 0x4

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnRemoveFriendComplete.RemovedID
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId RemovedID {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }
    }
    private static UFunction _ptrOnRemoveFriendComplete;
    public void OnRemoveFriendComplete(bool bWasSuccessful, U_Types_Core.FUniqueNetId RemovedID) {
        _ptrOnRemoveFriendComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnRemoveFriendComplete");

        var @params = stackalloc byte[76];
        System.Buffer.MemoryCopy(&bWasSuccessful, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)RemovedID.Pointer, @params + 8, 72, 72);

        ProcessEvent(_ptrOnRemoveFriendComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.DenyFriendInvite
    // 0x3750E0
    // (Final | Public)
    public unsafe class DenyFriendInvite_Parameters : BaseObject {
        public DenyFriendInvite_Parameters() { }
        public DenyFriendInvite_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.DenyFriendInvite.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.DenyFriendInvite.RequestingPlayer
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId RequestingPlayer {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.DenyFriendInvite.ReturnValue
        // 0x50 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 80) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 80) |= 0x1;
                else *(uint*)(Pointer + 80) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrDenyFriendInvite;
    public bool DenyFriendInvite(byte LocalUserNum, U_Types_Core.FUniqueNetId RequestingPlayer) {
        _ptrDenyFriendInvite ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.DenyFriendInvite");

        var @params = stackalloc byte[77];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)RequestingPlayer.Pointer, @params + 8, 72, 72);

        ProcessEvent(_ptrDenyFriendInvite, @params);

        return *(bool*)(@params + 80);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearDenyFriendInviteCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearDenyFriendInviteCompleteDelegate_Parameters : BaseObject {
        public ClearDenyFriendInviteCompleteDelegate_Parameters() { }
        public ClearDenyFriendInviteCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearDenyFriendInviteCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearDenyFriendInviteCompleteDelegate.FriendDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate FriendDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearDenyFriendInviteCompleteDelegate;
    public void ClearDenyFriendInviteCompleteDelegate(byte LocalUserNum, FScriptDelegate FriendDelegate) {
        _ptrClearDenyFriendInviteCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearDenyFriendInviteCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)FriendDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearDenyFriendInviteCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddDenyFriendInviteCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddDenyFriendInviteCompleteDelegate_Parameters : BaseObject {
        public AddDenyFriendInviteCompleteDelegate_Parameters() { }
        public AddDenyFriendInviteCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddDenyFriendInviteCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddDenyFriendInviteCompleteDelegate.FriendDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate FriendDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddDenyFriendInviteCompleteDelegate;
    public void AddDenyFriendInviteCompleteDelegate(byte LocalUserNum, FScriptDelegate FriendDelegate) {
        _ptrAddDenyFriendInviteCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddDenyFriendInviteCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)FriendDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddDenyFriendInviteCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnDenyFriendInviteComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnDenyFriendInviteComplete_Parameters : BaseObject {
        public OnDenyFriendInviteComplete_Parameters() { }
        public OnDenyFriendInviteComplete_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnDenyFriendInviteComplete.FriendId
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId FriendId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // ObjectProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnDenyFriendInviteComplete.Error
        // 0x48 (0x8)
        // (Const | Param)
        public UError Error {
            get {
                var pointer = *(nint*)(Pointer + 72);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 72) = value.Pointer;
        }
    }
    private static UFunction _ptrOnDenyFriendInviteComplete;
    public void OnDenyFriendInviteComplete(U_Types_Core.FUniqueNetId FriendId, UError Error) {
        _ptrOnDenyFriendInviteComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnDenyFriendInviteComplete");

        var @params = stackalloc byte[80];
        System.Buffer.MemoryCopy((void*)FriendId.Pointer, @params, 72, 72);
        System.Buffer.MemoryCopy((void*)Error.Pointer, @params + 72, 8, 8);

        ProcessEvent(_ptrOnDenyFriendInviteComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AcceptFriendInvite
    // 0x3750E0
    // (Final | Public)
    public unsafe class AcceptFriendInvite_Parameters : BaseObject {
        public AcceptFriendInvite_Parameters() { }
        public AcceptFriendInvite_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AcceptFriendInvite.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AcceptFriendInvite.RequestingPlayer
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId RequestingPlayer {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AcceptFriendInvite.ReturnValue
        // 0x50 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 80) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 80) |= 0x1;
                else *(uint*)(Pointer + 80) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrAcceptFriendInvite;
    public bool AcceptFriendInvite(byte LocalUserNum, U_Types_Core.FUniqueNetId RequestingPlayer) {
        _ptrAcceptFriendInvite ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AcceptFriendInvite");

        var @params = stackalloc byte[77];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)RequestingPlayer.Pointer, @params + 8, 72, 72);

        ProcessEvent(_ptrAcceptFriendInvite, @params);

        return *(bool*)(@params + 80);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearAcceptFriendInviteCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearAcceptFriendInviteCompleteDelegate_Parameters : BaseObject {
        public ClearAcceptFriendInviteCompleteDelegate_Parameters() { }
        public ClearAcceptFriendInviteCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearAcceptFriendInviteCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearAcceptFriendInviteCompleteDelegate.FriendDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate FriendDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearAcceptFriendInviteCompleteDelegate;
    public void ClearAcceptFriendInviteCompleteDelegate(byte LocalUserNum, FScriptDelegate FriendDelegate) {
        _ptrClearAcceptFriendInviteCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearAcceptFriendInviteCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)FriendDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearAcceptFriendInviteCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddAcceptFriendInviteCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddAcceptFriendInviteCompleteDelegate_Parameters : BaseObject {
        public AddAcceptFriendInviteCompleteDelegate_Parameters() { }
        public AddAcceptFriendInviteCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddAcceptFriendInviteCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddAcceptFriendInviteCompleteDelegate.FriendDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate FriendDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddAcceptFriendInviteCompleteDelegate;
    public void AddAcceptFriendInviteCompleteDelegate(byte LocalUserNum, FScriptDelegate FriendDelegate) {
        _ptrAddAcceptFriendInviteCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddAcceptFriendInviteCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)FriendDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddAcceptFriendInviteCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnAcceptFriendInviteComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnAcceptFriendInviteComplete_Parameters : BaseObject {
        public OnAcceptFriendInviteComplete_Parameters() { }
        public OnAcceptFriendInviteComplete_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnAcceptFriendInviteComplete.FriendId
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId FriendId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // ObjectProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnAcceptFriendInviteComplete.Error
        // 0x48 (0x8)
        // (Const | Param)
        public UError Error {
            get {
                var pointer = *(nint*)(Pointer + 72);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 72) = value.Pointer;
        }
    }
    private static UFunction _ptrOnAcceptFriendInviteComplete;
    public void OnAcceptFriendInviteComplete(U_Types_Core.FUniqueNetId FriendId, UError Error) {
        _ptrOnAcceptFriendInviteComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnAcceptFriendInviteComplete");

        var @params = stackalloc byte[80];
        System.Buffer.MemoryCopy((void*)FriendId.Pointer, @params, 72, 72);
        System.Buffer.MemoryCopy((void*)Error.Pointer, @params + 72, 8, 8);

        ProcessEvent(_ptrOnAcceptFriendInviteComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearAddFriendByNameCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearAddFriendByNameCompleteDelegate_Parameters : BaseObject {
        public ClearAddFriendByNameCompleteDelegate_Parameters() { }
        public ClearAddFriendByNameCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearAddFriendByNameCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearAddFriendByNameCompleteDelegate.FriendDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate FriendDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearAddFriendByNameCompleteDelegate;
    public void ClearAddFriendByNameCompleteDelegate(byte LocalUserNum, FScriptDelegate FriendDelegate) {
        _ptrClearAddFriendByNameCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearAddFriendByNameCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)FriendDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearAddFriendByNameCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddAddFriendByNameCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddAddFriendByNameCompleteDelegate_Parameters : BaseObject {
        public AddAddFriendByNameCompleteDelegate_Parameters() { }
        public AddAddFriendByNameCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddAddFriendByNameCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddAddFriendByNameCompleteDelegate.FriendDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate FriendDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddAddFriendByNameCompleteDelegate;
    public void AddAddFriendByNameCompleteDelegate(byte LocalUserNum, FScriptDelegate FriendDelegate) {
        _ptrAddAddFriendByNameCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddAddFriendByNameCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)FriendDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddAddFriendByNameCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnAddFriendByNameComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnAddFriendByNameComplete_Parameters : BaseObject {
        public OnAddFriendByNameComplete_Parameters() { }
        public OnAddFriendByNameComplete_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnAddFriendByNameComplete.bWasSuccessful
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnAddFriendByNameComplete;
    public void OnAddFriendByNameComplete(bool bWasSuccessful) {
        _ptrOnAddFriendByNameComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnAddFriendByNameComplete");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bWasSuccessful, @params, 4, 4);

        ProcessEvent(_ptrOnAddFriendByNameComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendByName
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class AddFriendByName_Parameters : BaseObject {
        public AddFriendByName_Parameters() { }
        public AddFriendByName_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendByName.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendByName.FriendName
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString FriendName {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendByName.Message
        // 0x18 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Message {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendByName.ReturnValue
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
    private static UFunction _ptrAddFriendByName;
    public bool AddFriendByName(byte LocalUserNum, FString FriendName, FString Message = null) {
        _ptrAddFriendByName ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendByName");

        var @params = stackalloc byte[37];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)FriendName.Pointer, @params + 8, 16, 16);
        if (Message != null) System.Buffer.MemoryCopy((void*)Message.Pointer, @params + 24, 16, 16);

        ProcessEvent(_ptrAddFriendByName, @params);

        return *(bool*)(@params + 40);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.QueryUserByDisplayName
    // 0xCDC9B0
    // (Final | Native | Public)
    public unsafe class QueryUserByDisplayName_Parameters : BaseObject {
        public QueryUserByDisplayName_Parameters() { }
        public QueryUserByDisplayName_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.QueryUserByDisplayName.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.QueryUserByDisplayName.DisplayName
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString DisplayName {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.QueryUserByDisplayName.ReturnValue
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
    private static UFunction _ptrQueryUserByDisplayName;
    public bool QueryUserByDisplayName(byte LocalUserNum, FString DisplayName) {
        _ptrQueryUserByDisplayName ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.QueryUserByDisplayName");

        var @params = stackalloc byte[21];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)DisplayName.Pointer, @params + 8, 16, 16);

        _ptrQueryUserByDisplayName.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrQueryUserByDisplayName, @params);
        _ptrQueryUserByDisplayName.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearQueryUserByDisplayNameCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearQueryUserByDisplayNameCompleteDelegate_Parameters : BaseObject {
        public ClearQueryUserByDisplayNameCompleteDelegate_Parameters() { }
        public ClearQueryUserByDisplayNameCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearQueryUserByDisplayNameCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearQueryUserByDisplayNameCompleteDelegate.QueryDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate QueryDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearQueryUserByDisplayNameCompleteDelegate;
    public void ClearQueryUserByDisplayNameCompleteDelegate(byte LocalUserNum, FScriptDelegate QueryDelegate) {
        _ptrClearQueryUserByDisplayNameCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearQueryUserByDisplayNameCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)QueryDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearQueryUserByDisplayNameCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddQueryUserByDisplayNameCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddQueryUserByDisplayNameCompleteDelegate_Parameters : BaseObject {
        public AddQueryUserByDisplayNameCompleteDelegate_Parameters() { }
        public AddQueryUserByDisplayNameCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddQueryUserByDisplayNameCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddQueryUserByDisplayNameCompleteDelegate.QueryDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate QueryDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddQueryUserByDisplayNameCompleteDelegate;
    public void AddQueryUserByDisplayNameCompleteDelegate(byte LocalUserNum, FScriptDelegate QueryDelegate) {
        _ptrAddQueryUserByDisplayNameCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddQueryUserByDisplayNameCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)QueryDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddQueryUserByDisplayNameCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnQueryUserByDisplayName
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnQueryUserByDisplayName_Parameters : BaseObject {
        public OnQueryUserByDisplayName_Parameters() { }
        public OnQueryUserByDisplayName_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnQueryUserByDisplayName.bWasSuccessful
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }

        // MISSED OFFSET: 0x4

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnQueryUserByDisplayName.QueriedDisplayName
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString QueriedDisplayName {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnQueryUserByDisplayName.UserId
        // 0x18 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId UserId {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 72, 72);
        }
    }
    private static UFunction _ptrOnQueryUserByDisplayName;
    public void OnQueryUserByDisplayName(bool bWasSuccessful, FString QueriedDisplayName, U_Types_Core.FUniqueNetId UserId) {
        _ptrOnQueryUserByDisplayName ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnQueryUserByDisplayName");

        var @params = stackalloc byte[92];
        System.Buffer.MemoryCopy(&bWasSuccessful, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)QueriedDisplayName.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy((void*)UserId.Pointer, @params + 24, 72, 72);

        ProcessEvent(_ptrOnQueryUserByDisplayName, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriend
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class AddFriend_Parameters : BaseObject {
        public AddFriend_Parameters() { }
        public AddFriend_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriend.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriend.NewFriend
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId NewFriend {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriend.Message
        // 0x50 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Message {
            get => new(Pointer + 80);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 80), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriend.ReturnValue
        // 0x60 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 96) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 96) |= 0x1;
                else *(uint*)(Pointer + 96) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrAddFriend;
    public bool AddFriend(byte LocalUserNum, U_Types_Core.FUniqueNetId NewFriend, FString Message = null) {
        _ptrAddFriend ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriend");

        var @params = stackalloc byte[93];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)NewFriend.Pointer, @params + 8, 72, 72);
        if (Message != null) System.Buffer.MemoryCopy((void*)Message.Pointer, @params + 80, 16, 16);

        ProcessEvent(_ptrAddFriend, @params);

        return *(bool*)(@params + 96);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearAddFriendCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearAddFriendCompleteDelegate_Parameters : BaseObject {
        public ClearAddFriendCompleteDelegate_Parameters() { }
        public ClearAddFriendCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearAddFriendCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearAddFriendCompleteDelegate.FriendDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate FriendDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearAddFriendCompleteDelegate;
    public void ClearAddFriendCompleteDelegate(byte LocalUserNum, FScriptDelegate FriendDelegate) {
        _ptrClearAddFriendCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearAddFriendCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)FriendDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearAddFriendCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddAddFriendCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddAddFriendCompleteDelegate_Parameters : BaseObject {
        public AddAddFriendCompleteDelegate_Parameters() { }
        public AddAddFriendCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddAddFriendCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddAddFriendCompleteDelegate.FriendDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate FriendDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddAddFriendCompleteDelegate;
    public void AddAddFriendCompleteDelegate(byte LocalUserNum, FScriptDelegate FriendDelegate) {
        _ptrAddAddFriendCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddAddFriendCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)FriendDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddAddFriendCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnAddFriendComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnAddFriendComplete_Parameters : BaseObject {
        public OnAddFriendComplete_Parameters() { }
        public OnAddFriendComplete_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnAddFriendComplete.NewFriendId
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId NewFriendId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // ObjectProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnAddFriendComplete.Error
        // 0x48 (0x8)
        // (Const | Param)
        public UError Error {
            get {
                var pointer = *(nint*)(Pointer + 72);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 72) = value.Pointer;
        }
    }
    private static UFunction _ptrOnAddFriendComplete;
    public void OnAddFriendComplete(U_Types_Core.FUniqueNetId NewFriendId, UError Error) {
        _ptrOnAddFriendComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnAddFriendComplete");

        var @params = stackalloc byte[80];
        System.Buffer.MemoryCopy((void*)NewFriendId.Pointer, @params, 72, 72);
        System.Buffer.MemoryCopy((void*)Error.Pointer, @params + 72, 8, 8);

        ProcessEvent(_ptrOnAddFriendComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetKeyboardInputResults
    // 0x3750E0
    // (Final | Public | HasOutParams)
    public unsafe class GetKeyboardInputResults_Parameters : BaseObject {
        public GetKeyboardInputResults_Parameters() { }
        public GetKeyboardInputResults_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetKeyboardInputResults.bWasCanceled
        // 0x0 (0x1)
        // (Param | OutParam)
        public byte bWasCanceled {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetKeyboardInputResults.ReturnValue
        // 0x8 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrGetKeyboardInputResults;
    public FString GetKeyboardInputResults(ref byte bWasCanceled) {
        _ptrGetKeyboardInputResults ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetKeyboardInputResults");

        var @params = stackalloc byte[17];
        var _bWasCanceled = bWasCanceled;
        System.Buffer.MemoryCopy(&_bWasCanceled, @params, 1, 1);

        ProcessEvent(_ptrGetKeyboardInputResults, @params);

        bWasCanceled = *(byte*)@params;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearKeyboardInputDoneDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearKeyboardInputDoneDelegate_Parameters : BaseObject {
        public ClearKeyboardInputDoneDelegate_Parameters() { }
        public ClearKeyboardInputDoneDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearKeyboardInputDoneDelegate.InputDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InputDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearKeyboardInputDoneDelegate;
    public void ClearKeyboardInputDoneDelegate(FScriptDelegate InputDelegate) {
        _ptrClearKeyboardInputDoneDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearKeyboardInputDoneDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InputDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearKeyboardInputDoneDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddKeyboardInputDoneDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddKeyboardInputDoneDelegate_Parameters : BaseObject {
        public AddKeyboardInputDoneDelegate_Parameters() { }
        public AddKeyboardInputDoneDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddKeyboardInputDoneDelegate.InputDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate InputDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddKeyboardInputDoneDelegate;
    public void AddKeyboardInputDoneDelegate(FScriptDelegate InputDelegate) {
        _ptrAddKeyboardInputDoneDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddKeyboardInputDoneDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)InputDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddKeyboardInputDoneDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnKeyboardInputComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnKeyboardInputComplete_Parameters : BaseObject {
        public OnKeyboardInputComplete_Parameters() { }
        public OnKeyboardInputComplete_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnKeyboardInputComplete.bWasSuccessful
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnKeyboardInputComplete;
    public void OnKeyboardInputComplete(bool bWasSuccessful) {
        _ptrOnKeyboardInputComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnKeyboardInputComplete");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bWasSuccessful, @params, 4, 4);

        ProcessEvent(_ptrOnKeyboardInputComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowKeyboardUI
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class ShowKeyboardUI_Parameters : BaseObject {
        public ShowKeyboardUI_Parameters() { }
        public ShowKeyboardUI_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowKeyboardUI.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowKeyboardUI.TitleText
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString TitleText {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowKeyboardUI.DescriptionText
        // 0x18 (0x10)
        // (Param | NeedCtorLink)
        public FString DescriptionText {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowKeyboardUI.bIsPassword
        // 0x28 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bIsPassword {
            get => (*(uint*)(Pointer + 40) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x1;
                else *(uint*)(Pointer + 40) &= ~(uint)0x1;
            }
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowKeyboardUI.bShouldValidate
        // 0x2C (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bShouldValidate {
            get => (*(uint*)(Pointer + 44) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 44) |= 0x1;
                else *(uint*)(Pointer + 44) &= ~(uint)0x1;
            }
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowKeyboardUI.DefaultText
        // 0x30 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString DefaultText {
            get => new(Pointer + 48);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 48), 16, 16);
        }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowKeyboardUI.MaxResultLength
        // 0x40 (0x4)
        // (OptionalParam | Param)
        public int MaxResultLength {
            get => *(int*)(Pointer + 64);
            set => *(int*)(Pointer + 64) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowKeyboardUI.ReturnValue
        // 0x44 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 68) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 68) |= 0x1;
                else *(uint*)(Pointer + 68) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrShowKeyboardUI;
    public bool ShowKeyboardUI(byte LocalUserNum, FString TitleText, FString DescriptionText, bool bIsPassword = false, bool bShouldValidate = false, FString DefaultText = null, int MaxResultLength = 0) {
        _ptrShowKeyboardUI ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowKeyboardUI");

        var @params = stackalloc byte[65];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)TitleText.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy((void*)DescriptionText.Pointer, @params + 24, 16, 16);
        System.Buffer.MemoryCopy(&bIsPassword, @params + 40, 4, 4);
        System.Buffer.MemoryCopy(&bShouldValidate, @params + 44, 4, 4);
        if (DefaultText != null) System.Buffer.MemoryCopy((void*)DefaultText.Pointer, @params + 48, 16, 16);
        System.Buffer.MemoryCopy(&MaxResultLength, @params + 64, 4, 4);

        ProcessEvent(_ptrShowKeyboardUI, @params);

        return *(bool*)(@params + 68);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetOnlineStatus
    // 0xCDC800
    // (Final | Native | Public | HasOutParams)
    public unsafe class SetOnlineStatus_Parameters : BaseObject {
        public SetOnlineStatus_Parameters() { }
        public SetOnlineStatus_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetOnlineStatus.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetOnlineStatus.StatusId
        // 0x4 (0x4)
        // (Param)
        public int StatusId {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }

        // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetOnlineStatus.LocalizedStringSettings
        // 0x8 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public StructTArray<USettings.FLocalizedStringSetting> LocalizedStringSettings {
            get => new(Pointer + 8, 12);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetOnlineStatus.Properties
        // 0x18 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public StructTArray<USettings.FSettingsProperty> Properties {
            get => new(Pointer + 24, 32);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }
    }
    private static UFunction _ptrSetOnlineStatus;
    public void SetOnlineStatus(byte LocalUserNum, int StatusId, ref StructTArray<USettings.FLocalizedStringSetting> LocalizedStringSettings, ref StructTArray<USettings.FSettingsProperty> Properties) {
        _ptrSetOnlineStatus ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.SetOnlineStatus");

        var @params = stackalloc byte[37];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&StatusId, @params + 4, 4, 4);
        System.Buffer.MemoryCopy((void*)LocalizedStringSettings.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy((void*)Properties.Pointer, @params + 24, 16, 16);

        _ptrSetOnlineStatus.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetOnlineStatus, @params);
        _ptrSetOnlineStatus.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _LocalizedStringSettingsPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_LocalizedStringSettingsPtr, 16, 16);
        LocalizedStringSettings = new(_LocalizedStringSettingsPtr, 12) { Allocated = true };
        var _PropertiesPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 24, (void*)_PropertiesPtr, 16, 16);
        Properties = new(_PropertiesPtr, 32) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetFriendsList
    // 0xCDC630
    // (Final | Native | HasOptionalParams | Public | HasOutParams)
    public unsafe class GetFriendsList_Parameters : BaseObject {
        public GetFriendsList_Parameters() { }
        public GetFriendsList_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetFriendsList.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetFriendsList.Friends
        // 0x8 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public StructTArray<UOnlineSubsystem.FOnlineFriend> Friends {
            get => new(Pointer + 8, 280);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetFriendsList.Count
        // 0x18 (0x4)
        // (OptionalParam | Param)
        public int Count {
            get => *(int*)(Pointer + 24);
            set => *(int*)(Pointer + 24) = value;
        }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetFriendsList.StartingAt
        // 0x1C (0x4)
        // (OptionalParam | Param)
        public int StartingAt {
            get => *(int*)(Pointer + 28);
            set => *(int*)(Pointer + 28) = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetFriendsList.ReturnValue
        // 0x20 (0x1)
        // (Param | OutParam | ReturnParam)
        public UOnlineSubsystem.EOnlineEnumerationReadState ReturnValue {
            get => *(UOnlineSubsystem.EOnlineEnumerationReadState*)(Pointer + 32);
            set => *(UOnlineSubsystem.EOnlineEnumerationReadState*)(Pointer + 32) = value;
        }
    }
    private static UFunction _ptrGetFriendsList;
    public UOnlineSubsystem.EOnlineEnumerationReadState GetFriendsList(byte LocalUserNum, ref StructTArray<UOnlineSubsystem.FOnlineFriend> Friends, int Count = 0, int StartingAt = 0) {
        _ptrGetFriendsList ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetFriendsList");

        var @params = stackalloc byte[26];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)Friends.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy(&Count, @params + 24, 4, 4);
        System.Buffer.MemoryCopy(&StartingAt, @params + 28, 4, 4);

        _ptrGetFriendsList.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetFriendsList, @params);
        _ptrGetFriendsList.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _FriendsPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_FriendsPtr, 16, 16);
        Friends = new(_FriendsPtr, 280) { Allocated = true };

        return *(UOnlineSubsystem.EOnlineEnumerationReadState*)(@params + 32);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadFriendsCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearReadFriendsCompleteDelegate_Parameters : BaseObject {
        public ClearReadFriendsCompleteDelegate_Parameters() { }
        public ClearReadFriendsCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadFriendsCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadFriendsCompleteDelegate.ReadFriendsCompleteDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ReadFriendsCompleteDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearReadFriendsCompleteDelegate;
    public void ClearReadFriendsCompleteDelegate(byte LocalUserNum, FScriptDelegate ReadFriendsCompleteDelegate) {
        _ptrClearReadFriendsCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadFriendsCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)ReadFriendsCompleteDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearReadFriendsCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadFriendsCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddReadFriendsCompleteDelegate_Parameters : BaseObject {
        public AddReadFriendsCompleteDelegate_Parameters() { }
        public AddReadFriendsCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadFriendsCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadFriendsCompleteDelegate.ReadFriendsCompleteDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ReadFriendsCompleteDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddReadFriendsCompleteDelegate;
    public void AddReadFriendsCompleteDelegate(byte LocalUserNum, FScriptDelegate ReadFriendsCompleteDelegate) {
        _ptrAddReadFriendsCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadFriendsCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)ReadFriendsCompleteDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddReadFriendsCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadFriendsComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnReadFriendsComplete_Parameters : BaseObject {
        public OnReadFriendsComplete_Parameters() { }
        public OnReadFriendsComplete_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadFriendsComplete.bWasSuccessful
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnReadFriendsComplete;
    public void OnReadFriendsComplete(bool bWasSuccessful) {
        _ptrOnReadFriendsComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadFriendsComplete");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bWasSuccessful, @params, 4, 4);

        ProcessEvent(_ptrOnReadFriendsComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadFriendsList
    // 0xCDC540
    // (Final | Native | HasOptionalParams | Public)
    public unsafe class ReadFriendsList_Parameters : BaseObject {
        public ReadFriendsList_Parameters() { }
        public ReadFriendsList_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadFriendsList.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadFriendsList.Count
        // 0x4 (0x4)
        // (OptionalParam | Param)
        public int Count {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadFriendsList.StartingAt
        // 0x8 (0x4)
        // (OptionalParam | Param)
        public int StartingAt {
            get => *(int*)(Pointer + 8);
            set => *(int*)(Pointer + 8) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadFriendsList.ReturnValue
        // 0xC (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 12) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 12) |= 0x1;
                else *(uint*)(Pointer + 12) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrReadFriendsList;
    public bool ReadFriendsList(byte LocalUserNum, int Count = 0, int StartingAt = 0) {
        _ptrReadFriendsList ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadFriendsList");

        var @params = stackalloc byte[13];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&Count, @params + 4, 4, 4);
        System.Buffer.MemoryCopy(&StartingAt, @params + 8, 4, 4);

        _ptrReadFriendsList.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrReadFriendsList, @params);
        _ptrReadFriendsList.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 12);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearWriteProfileSettingsCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearWriteProfileSettingsCompleteDelegate_Parameters : BaseObject {
        public ClearWriteProfileSettingsCompleteDelegate_Parameters() { }
        public ClearWriteProfileSettingsCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearWriteProfileSettingsCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearWriteProfileSettingsCompleteDelegate.WriteProfileSettingsCompleteDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate WriteProfileSettingsCompleteDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearWriteProfileSettingsCompleteDelegate;
    public void ClearWriteProfileSettingsCompleteDelegate(byte LocalUserNum, FScriptDelegate WriteProfileSettingsCompleteDelegate) {
        _ptrClearWriteProfileSettingsCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearWriteProfileSettingsCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)WriteProfileSettingsCompleteDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearWriteProfileSettingsCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddWriteProfileSettingsCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddWriteProfileSettingsCompleteDelegate_Parameters : BaseObject {
        public AddWriteProfileSettingsCompleteDelegate_Parameters() { }
        public AddWriteProfileSettingsCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddWriteProfileSettingsCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddWriteProfileSettingsCompleteDelegate.WriteProfileSettingsCompleteDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate WriteProfileSettingsCompleteDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddWriteProfileSettingsCompleteDelegate;
    public void AddWriteProfileSettingsCompleteDelegate(byte LocalUserNum, FScriptDelegate WriteProfileSettingsCompleteDelegate) {
        _ptrAddWriteProfileSettingsCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddWriteProfileSettingsCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)WriteProfileSettingsCompleteDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddWriteProfileSettingsCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnWriteProfileSettingsComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnWriteProfileSettingsComplete_Parameters : BaseObject {
        public OnWriteProfileSettingsComplete_Parameters() { }
        public OnWriteProfileSettingsComplete_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnWriteProfileSettingsComplete.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnWriteProfileSettingsComplete.bWasSuccessful
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnWriteProfileSettingsComplete;
    public void OnWriteProfileSettingsComplete(byte LocalUserNum, bool bWasSuccessful) {
        _ptrOnWriteProfileSettingsComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnWriteProfileSettingsComplete");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&bWasSuccessful, @params + 4, 4, 4);

        ProcessEvent(_ptrOnWriteProfileSettingsComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.WriteProfileSettings
    // 0xCDC4A0
    // (Final | Native | Public)
    public unsafe class WriteProfileSettings_Parameters : BaseObject {
        public WriteProfileSettings_Parameters() { }
        public WriteProfileSettings_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.WriteProfileSettings.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ObjectProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.WriteProfileSettings.ProfileSettings
        // 0x8 (0x8)
        // (Param)
        public UOnlineProfileSettings ProfileSettings {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.WriteProfileSettings.ReturnValue
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
    private static UFunction _ptrWriteProfileSettings;
    public bool WriteProfileSettings(byte LocalUserNum, UOnlineProfileSettings ProfileSettings) {
        _ptrWriteProfileSettings ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.WriteProfileSettings");

        var @params = stackalloc byte[13];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)ProfileSettings.Pointer, @params + 8, 8, 8);

        _ptrWriteProfileSettings.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrWriteProfileSettings, @params);
        _ptrWriteProfileSettings.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetProfileSettings
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class GetProfileSettings_Parameters : BaseObject {
        public GetProfileSettings_Parameters() { }
        public GetProfileSettings_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetProfileSettings.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ObjectProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetProfileSettings.ReturnValue
        // 0x8 (0x8)
        // (Param | OutParam | ReturnParam)
        public UOnlineProfileSettings ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }
    }
    private static UFunction _ptrGetProfileSettings;
    public UOnlineProfileSettings GetProfileSettings(byte LocalUserNum) {
        _ptrGetProfileSettings ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetProfileSettings");

        var @params = stackalloc byte[9];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrGetProfileSettings, @params);

        return new(*(nint*)(@params + 8));
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadProfileSettingsCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearReadProfileSettingsCompleteDelegate_Parameters : BaseObject {
        public ClearReadProfileSettingsCompleteDelegate_Parameters() { }
        public ClearReadProfileSettingsCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadProfileSettingsCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadProfileSettingsCompleteDelegate.ReadProfileSettingsCompleteDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ReadProfileSettingsCompleteDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearReadProfileSettingsCompleteDelegate;
    public void ClearReadProfileSettingsCompleteDelegate(byte LocalUserNum, FScriptDelegate ReadProfileSettingsCompleteDelegate) {
        _ptrClearReadProfileSettingsCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearReadProfileSettingsCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)ReadProfileSettingsCompleteDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearReadProfileSettingsCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadProfileSettingsCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddReadProfileSettingsCompleteDelegate_Parameters : BaseObject {
        public AddReadProfileSettingsCompleteDelegate_Parameters() { }
        public AddReadProfileSettingsCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadProfileSettingsCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadProfileSettingsCompleteDelegate.ReadProfileSettingsCompleteDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ReadProfileSettingsCompleteDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddReadProfileSettingsCompleteDelegate;
    public void AddReadProfileSettingsCompleteDelegate(byte LocalUserNum, FScriptDelegate ReadProfileSettingsCompleteDelegate) {
        _ptrAddReadProfileSettingsCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddReadProfileSettingsCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)ReadProfileSettingsCompleteDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddReadProfileSettingsCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadProfileSettingsComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnReadProfileSettingsComplete_Parameters : BaseObject {
        public OnReadProfileSettingsComplete_Parameters() { }
        public OnReadProfileSettingsComplete_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadProfileSettingsComplete.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadProfileSettingsComplete.bWasSuccessful
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnReadProfileSettingsComplete;
    public void OnReadProfileSettingsComplete(byte LocalUserNum, bool bWasSuccessful) {
        _ptrOnReadProfileSettingsComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReadProfileSettingsComplete");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&bWasSuccessful, @params + 4, 4, 4);

        ProcessEvent(_ptrOnReadProfileSettingsComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadProfileSettings
    // 0xCDC4A0
    // (Final | Native | Public)
    public unsafe class ReadProfileSettings_Parameters : BaseObject {
        public ReadProfileSettings_Parameters() { }
        public ReadProfileSettings_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadProfileSettings.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ObjectProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadProfileSettings.ProfileSettings
        // 0x8 (0x8)
        // (Param)
        public UOnlineProfileSettings ProfileSettings {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadProfileSettings.ReturnValue
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
    private static UFunction _ptrReadProfileSettings;
    public bool ReadProfileSettings(byte LocalUserNum, UOnlineProfileSettings ProfileSettings) {
        _ptrReadProfileSettings ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ReadProfileSettings");

        var @params = stackalloc byte[13];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)ProfileSettings.Pointer, @params + 8, 8, 8);

        _ptrReadProfileSettings.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrReadProfileSettings, @params);
        _ptrReadProfileSettings.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearFriendsChangeDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearFriendsChangeDelegate_Parameters : BaseObject {
        public ClearFriendsChangeDelegate_Parameters() { }
        public ClearFriendsChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearFriendsChangeDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearFriendsChangeDelegate.FriendsDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate FriendsDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearFriendsChangeDelegate;
    public void ClearFriendsChangeDelegate(byte LocalUserNum, FScriptDelegate FriendsDelegate) {
        _ptrClearFriendsChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearFriendsChangeDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)FriendsDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearFriendsChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendsChangeDelegate
    // 0x3750E0
    // (Final | Defined | Event | Public)
    public unsafe class AddFriendsChangeDelegate_Parameters : BaseObject {
        public AddFriendsChangeDelegate_Parameters() { }
        public AddFriendsChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendsChangeDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendsChangeDelegate.FriendsDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate FriendsDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddFriendsChangeDelegate;
    public void AddFriendsChangeDelegate(byte LocalUserNum, FScriptDelegate FriendsDelegate) {
        _ptrAddFriendsChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddFriendsChangeDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)FriendsDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddFriendsChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearMutingChangeDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearMutingChangeDelegate_Parameters : BaseObject {
        public ClearMutingChangeDelegate_Parameters() { }
        public ClearMutingChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearMutingChangeDelegate.MutingDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate MutingDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearMutingChangeDelegate;
    public void ClearMutingChangeDelegate(FScriptDelegate MutingDelegate) {
        _ptrClearMutingChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearMutingChangeDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)MutingDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearMutingChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddMutingChangeDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddMutingChangeDelegate_Parameters : BaseObject {
        public AddMutingChangeDelegate_Parameters() { }
        public AddMutingChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddMutingChangeDelegate.MutingDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate MutingDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddMutingChangeDelegate;
    public void AddMutingChangeDelegate(FScriptDelegate MutingDelegate) {
        _ptrAddMutingChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddMutingChangeDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)MutingDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddMutingChangeDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearLoginCancelledDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearLoginCancelledDelegate_Parameters : BaseObject {
        public ClearLoginCancelledDelegate_Parameters() { }
        public ClearLoginCancelledDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearLoginCancelledDelegate.CancelledDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate CancelledDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearLoginCancelledDelegate;
    public void ClearLoginCancelledDelegate(FScriptDelegate CancelledDelegate) {
        _ptrClearLoginCancelledDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearLoginCancelledDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)CancelledDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearLoginCancelledDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddLoginCancelledDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddLoginCancelledDelegate_Parameters : BaseObject {
        public AddLoginCancelledDelegate_Parameters() { }
        public AddLoginCancelledDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddLoginCancelledDelegate.CancelledDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate CancelledDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddLoginCancelledDelegate;
    public void AddLoginCancelledDelegate(FScriptDelegate CancelledDelegate) {
        _ptrAddLoginCancelledDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddLoginCancelledDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)CancelledDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddLoginCancelledDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearLoginChangeDelegate
    // 0xCDC3C0
    // (Final | Native | Public)
    public unsafe class ClearLoginChangeDelegate_Parameters : BaseObject {
        public ClearLoginChangeDelegate_Parameters() { }
        public ClearLoginChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearLoginChangeDelegate.LoginDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate LoginDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearLoginChangeDelegate;
    public void ClearLoginChangeDelegate(FScriptDelegate LoginDelegate) {
        _ptrClearLoginChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearLoginChangeDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)LoginDelegate.Pointer, @params, 24, 24);

        _ptrClearLoginChangeDelegate.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrClearLoginChangeDelegate, @params);
        _ptrClearLoginChangeDelegate.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddLoginChangeDelegate
    // 0xCDC2E0
    // (Final | Native | Public)
    public unsafe class AddLoginChangeDelegate_Parameters : BaseObject {
        public AddLoginChangeDelegate_Parameters() { }
        public AddLoginChangeDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddLoginChangeDelegate.LoginDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate LoginDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddLoginChangeDelegate;
    public void AddLoginChangeDelegate(FScriptDelegate LoginDelegate) {
        _ptrAddLoginChangeDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddLoginChangeDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)LoginDelegate.Pointer, @params, 24, 24);

        _ptrAddLoginChangeDelegate.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrAddLoginChangeDelegate, @params);
        _ptrAddLoginChangeDelegate.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowFriendsUI
    // 0x3750E0
    // (Final | Public)
    public unsafe class ShowFriendsUI_Parameters : BaseObject {
        public ShowFriendsUI_Parameters() { }
        public ShowFriendsUI_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowFriendsUI.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowFriendsUI.ReturnValue
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
    private static UFunction _ptrShowFriendsUI;
    public bool ShowFriendsUI(byte LocalUserNum) {
        _ptrShowFriendsUI ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowFriendsUI");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrShowFriendsUI, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsMuted
    // 0x3750E0
    // (Final | Public)
    public unsafe class IsMuted_Parameters : BaseObject {
        public IsMuted_Parameters() { }
        public IsMuted_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsMuted.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsMuted.PlayerID
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsMuted.ReturnValue
        // 0x50 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 80) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 80) |= 0x1;
                else *(uint*)(Pointer + 80) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrIsMuted;
    public bool IsMuted(byte LocalUserNum, U_Types_Core.FUniqueNetId PlayerID) {
        _ptrIsMuted ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsMuted");

        var @params = stackalloc byte[77];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params + 8, 72, 72);

        ProcessEvent(_ptrIsMuted, @params);

        return *(bool*)(@params + 80);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AreAnyFriends
    // 0xCDC0E0
    // (Final | Native | Public | HasOutParams)
    public unsafe class AreAnyFriends_Parameters : BaseObject {
        public AreAnyFriends_Parameters() { }
        public AreAnyFriends_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AreAnyFriends.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AreAnyFriends.Query
        // 0x8 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public StructTArray<UOnlineSubsystem.FFriendsQuery> Query {
            get => new(Pointer + 8, 80);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AreAnyFriends.ReturnValue
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
    private static UFunction _ptrAreAnyFriends;
    public bool AreAnyFriends(byte LocalUserNum, ref StructTArray<UOnlineSubsystem.FFriendsQuery> Query) {
        _ptrAreAnyFriends ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AreAnyFriends");

        var @params = stackalloc byte[21];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)Query.Pointer, @params + 8, 16, 16);

        _ptrAreAnyFriends.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrAreAnyFriends, @params);
        _ptrAreAnyFriends.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _QueryPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_QueryPtr, 16, 16);
        Query = new(_QueryPtr, 80) { Allocated = true };

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsFriend
    // 0xCDBF70
    // (Final | Native | Public)
    public unsafe class IsFriend_Parameters : BaseObject {
        public IsFriend_Parameters() { }
        public IsFriend_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsFriend.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsFriend.PlayerID
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsFriend.ReturnValue
        // 0x50 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 80) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 80) |= 0x1;
                else *(uint*)(Pointer + 80) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrIsFriend;
    public bool IsFriend(byte LocalUserNum, U_Types_Core.FUniqueNetId PlayerID) {
        _ptrIsFriend ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.IsFriend");

        var @params = stackalloc byte[77];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params + 8, 72, 72);

        _ptrIsFriend.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrIsFriend, @params);
        _ptrIsFriend.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 80);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShowPresenceInformation
    // 0x3750E0
    // (Final | Defined | HasOptionalParams | Public | HasOutParams)
    public unsafe class CanShowPresenceInformation_Parameters : BaseObject {
        public CanShowPresenceInformation_Parameters() { }
        public CanShowPresenceInformation_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShowPresenceInformation.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShowPresenceInformation.PrivilegeLevelHint
        // 0x1 (0x1)
        // (Param | OutParam)
        public UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint {
            get => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1);
            set => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1) = value;
        }

        // MISSED OFFSET: 0x2

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShowPresenceInformation.bAttemptToResolve
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bAttemptToResolve {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShowPresenceInformation.Reason
        // 0x8 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Reason {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShowPresenceInformation.ReturnValue
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
    private static UFunction _ptrCanShowPresenceInformation;
    public bool CanShowPresenceInformation(byte LocalUserNum, ref UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint, bool bAttemptToResolve = false, FString Reason = null) {
        _ptrCanShowPresenceInformation ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanShowPresenceInformation");

        var @params = stackalloc byte[26];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        var _PrivilegeLevelHint = PrivilegeLevelHint;
        System.Buffer.MemoryCopy(&_PrivilegeLevelHint, @params + 1, 1, 1);
        System.Buffer.MemoryCopy(&bAttemptToResolve, @params + 4, 4, 4);
        if (Reason != null) System.Buffer.MemoryCopy((void*)Reason.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrCanShowPresenceInformation, @params);

        PrivilegeLevelHint = *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(@params + 1);

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanViewPlayerProfiles
    // 0x3750E0
    // (Final | Defined | HasOptionalParams | Public | HasOutParams)
    public unsafe class CanViewPlayerProfiles_Parameters : BaseObject {
        public CanViewPlayerProfiles_Parameters() { }
        public CanViewPlayerProfiles_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanViewPlayerProfiles.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanViewPlayerProfiles.PrivilegeLevelHint
        // 0x1 (0x1)
        // (Param | OutParam)
        public UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint {
            get => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1);
            set => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1) = value;
        }

        // MISSED OFFSET: 0x2

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanViewPlayerProfiles.bAttemptToResolve
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bAttemptToResolve {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanViewPlayerProfiles.Reason
        // 0x8 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Reason {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanViewPlayerProfiles.ReturnValue
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
    private static UFunction _ptrCanViewPlayerProfiles;
    public bool CanViewPlayerProfiles(byte LocalUserNum, ref UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint, bool bAttemptToResolve = false, FString Reason = null) {
        _ptrCanViewPlayerProfiles ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanViewPlayerProfiles");

        var @params = stackalloc byte[26];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        var _PrivilegeLevelHint = PrivilegeLevelHint;
        System.Buffer.MemoryCopy(&_PrivilegeLevelHint, @params + 1, 1, 1);
        System.Buffer.MemoryCopy(&bAttemptToResolve, @params + 4, 4, 4);
        if (Reason != null) System.Buffer.MemoryCopy((void*)Reason.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrCanViewPlayerProfiles, @params);

        PrivilegeLevelHint = *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(@params + 1);

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanPurchaseContent
    // 0x3750E0
    // (Final | Defined | HasOptionalParams | Public | HasOutParams)
    public unsafe class CanPurchaseContent_Parameters : BaseObject {
        public CanPurchaseContent_Parameters() { }
        public CanPurchaseContent_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanPurchaseContent.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanPurchaseContent.PrivilegeLevelHint
        // 0x1 (0x1)
        // (Param | OutParam)
        public UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint {
            get => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1);
            set => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1) = value;
        }

        // MISSED OFFSET: 0x2

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanPurchaseContent.bAttemptToResolve
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bAttemptToResolve {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanPurchaseContent.Reason
        // 0x8 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Reason {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanPurchaseContent.ReturnValue
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
    private static UFunction _ptrCanPurchaseContent;
    public bool CanPurchaseContent(byte LocalUserNum, ref UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint, bool bAttemptToResolve = false, FString Reason = null) {
        _ptrCanPurchaseContent ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanPurchaseContent");

        var @params = stackalloc byte[26];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        var _PrivilegeLevelHint = PrivilegeLevelHint;
        System.Buffer.MemoryCopy(&_PrivilegeLevelHint, @params + 1, 1, 1);
        System.Buffer.MemoryCopy(&bAttemptToResolve, @params + 4, 4, 4);
        if (Reason != null) System.Buffer.MemoryCopy((void*)Reason.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrCanPurchaseContent, @params);

        PrivilegeLevelHint = *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(@params + 1);

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanDownloadUserContent
    // 0x3750E0
    // (Final | Defined | HasOptionalParams | Public | HasOutParams)
    public unsafe class CanDownloadUserContent_Parameters : BaseObject {
        public CanDownloadUserContent_Parameters() { }
        public CanDownloadUserContent_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanDownloadUserContent.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanDownloadUserContent.PrivilegeLevelHint
        // 0x1 (0x1)
        // (Param | OutParam)
        public UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint {
            get => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1);
            set => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1) = value;
        }

        // MISSED OFFSET: 0x2

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanDownloadUserContent.bAttemptToResolve
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bAttemptToResolve {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanDownloadUserContent.Reason
        // 0x8 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Reason {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanDownloadUserContent.ReturnValue
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
    private static UFunction _ptrCanDownloadUserContent;
    public bool CanDownloadUserContent(byte LocalUserNum, ref UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint, bool bAttemptToResolve = false, FString Reason = null) {
        _ptrCanDownloadUserContent ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanDownloadUserContent");

        var @params = stackalloc byte[26];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        var _PrivilegeLevelHint = PrivilegeLevelHint;
        System.Buffer.MemoryCopy(&_PrivilegeLevelHint, @params + 1, 1, 1);
        System.Buffer.MemoryCopy(&bAttemptToResolve, @params + 4, 4, 4);
        if (Reason != null) System.Buffer.MemoryCopy((void*)Reason.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrCanDownloadUserContent, @params);

        PrivilegeLevelHint = *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(@params + 1);

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicate
    // 0x3750E0
    // (Final | Defined | HasOptionalParams | Public)
    public unsafe class CanCommunicate_Parameters : BaseObject {
        public CanCommunicate_Parameters() { }
        public CanCommunicate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicate.CommMethod
        // 0x1 (0x1)
        // (Param)
        public UOnlineSubsystem.ECommunicationMethod CommMethod {
            get => *(UOnlineSubsystem.ECommunicationMethod*)(Pointer + 1);
            set => *(UOnlineSubsystem.ECommunicationMethod*)(Pointer + 1) = value;
        }

        // MISSED OFFSET: 0x2

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicate.bAttemptToResolve
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bAttemptToResolve {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicate.ReturnValue
        // 0x8 (0x1)
        // (Param | OutParam | ReturnParam)
        public UOnlineSubsystem.EFeaturePrivilegeLevel ReturnValue {
            get => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 8);
            set => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrCanCommunicate;
    public UOnlineSubsystem.EFeaturePrivilegeLevel CanCommunicate(byte LocalUserNum, UOnlineSubsystem.ECommunicationMethod CommMethod, bool bAttemptToResolve = false) {
        _ptrCanCommunicate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanCommunicate");

        var @params = stackalloc byte[7];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&CommMethod, @params + 1, 1, 1);
        System.Buffer.MemoryCopy(&bAttemptToResolve, @params + 4, 4, 4);

        ProcessEvent(_ptrCanCommunicate, @params);

        return *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(@params + 8);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanPlayOnline
    // 0x3750E0
    // (Final | Defined | HasOptionalParams | Public | HasOutParams)
    public unsafe class CanPlayOnline_Parameters : BaseObject {
        public CanPlayOnline_Parameters() { }
        public CanPlayOnline_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanPlayOnline.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanPlayOnline.PrivilegeLevelHint
        // 0x1 (0x1)
        // (Param | OutParam)
        public UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint {
            get => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1);
            set => *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(Pointer + 1) = value;
        }

        // MISSED OFFSET: 0x2

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanPlayOnline.bAttemptToResolve
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bAttemptToResolve {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanPlayOnline.Reason
        // 0x8 (0x10)
        // (OptionalParam | Param | NeedCtorLink)
        public FString Reason {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanPlayOnline.ReturnValue
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
    private static UFunction _ptrCanPlayOnline;
    public bool CanPlayOnline(byte LocalUserNum, ref UOnlineSubsystem.EFeaturePrivilegeLevel PrivilegeLevelHint, bool bAttemptToResolve = false, FString Reason = null) {
        _ptrCanPlayOnline ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.CanPlayOnline");

        var @params = stackalloc byte[26];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        var _PrivilegeLevelHint = PrivilegeLevelHint;
        System.Buffer.MemoryCopy(&_PrivilegeLevelHint, @params + 1, 1, 1);
        System.Buffer.MemoryCopy(&bAttemptToResolve, @params + 4, 4, 4);
        if (Reason != null) System.Buffer.MemoryCopy((void*)Reason.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrCanPlayOnline, @params);

        PrivilegeLevelHint = *(UOnlineSubsystem.EFeaturePrivilegeLevel*)(@params + 1);

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetPlayerNickname
    // 0xCDBE90
    // (Final | Native | Public)
    public unsafe class GetPlayerNickname_Parameters : BaseObject {
        public GetPlayerNickname_Parameters() { }
        public GetPlayerNickname_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetPlayerNickname.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetPlayerNickname.ReturnValue
        // 0x8 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrGetPlayerNickname;
    public FString GetPlayerNickname(byte LocalUserNum) {
        _ptrGetPlayerNickname ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetPlayerNickname");

        var @params = stackalloc byte[17];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        _ptrGetPlayerNickname.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetPlayerNickname, @params);
        _ptrGetPlayerNickname.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetUniquePlayerId
    // 0xCDBC20
    // (Final | Native | Public | HasOutParams)
    public unsafe class GetUniquePlayerId_Parameters : BaseObject {
        public GetUniquePlayerId_Parameters() { }
        public GetUniquePlayerId_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetUniquePlayerId.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetUniquePlayerId.PlayerID
        // 0x8 (0x48)
        // (Param | OutParam | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetUniquePlayerId.ReturnValue
        // 0x50 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 80) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 80) |= 0x1;
                else *(uint*)(Pointer + 80) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrGetUniquePlayerId;
    public bool GetUniquePlayerId(byte LocalUserNum, ref U_Types_Core.FUniqueNetId PlayerID) {
        _ptrGetUniquePlayerId ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetUniquePlayerId");

        var @params = stackalloc byte[77];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params + 8, 72, 72);

        _ptrGetUniquePlayerId.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetUniquePlayerId, @params);
        _ptrGetUniquePlayerId.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _PlayerIDPtr = Marshal.AllocHGlobal(72);
        System.Buffer.MemoryCopy(@params + 8, (void*)_PlayerIDPtr, 72, 72);
        PlayerID = new(_PlayerIDPtr) { Allocated = true };

        return *(bool*)(@params + 80);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetLoginStatus
    // 0xCDBB90
    // (Final | Native | Public)
    public unsafe class GetLoginStatus_Parameters : BaseObject {
        public GetLoginStatus_Parameters() { }
        public GetLoginStatus_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetLoginStatus.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetLoginStatus.ReturnValue
        // 0x1 (0x1)
        // (Param | OutParam | ReturnParam)
        public UOnlineSubsystem.ELoginStatus ReturnValue {
            get => *(UOnlineSubsystem.ELoginStatus*)(Pointer + 1);
            set => *(UOnlineSubsystem.ELoginStatus*)(Pointer + 1) = value;
        }
    }
    private static UFunction _ptrGetLoginStatus;
    public UOnlineSubsystem.ELoginStatus GetLoginStatus(byte LocalUserNum) {
        _ptrGetLoginStatus ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.GetLoginStatus");

        var @params = stackalloc byte[2];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        _ptrGetLoginStatus.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetLoginStatus, @params);
        _ptrGetLoginStatus.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(UOnlineSubsystem.ELoginStatus*)(@params + 1);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearLogoutCompletedDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearLogoutCompletedDelegate_Parameters : BaseObject {
        public ClearLogoutCompletedDelegate_Parameters() { }
        public ClearLogoutCompletedDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearLogoutCompletedDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearLogoutCompletedDelegate.LogoutDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate LogoutDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearLogoutCompletedDelegate;
    public void ClearLogoutCompletedDelegate(byte LocalUserNum, FScriptDelegate LogoutDelegate) {
        _ptrClearLogoutCompletedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearLogoutCompletedDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)LogoutDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearLogoutCompletedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddLogoutCompletedDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddLogoutCompletedDelegate_Parameters : BaseObject {
        public AddLogoutCompletedDelegate_Parameters() { }
        public AddLogoutCompletedDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddLogoutCompletedDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddLogoutCompletedDelegate.LogoutDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate LogoutDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddLogoutCompletedDelegate;
    public void AddLogoutCompletedDelegate(byte LocalUserNum, FScriptDelegate LogoutDelegate) {
        _ptrAddLogoutCompletedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddLogoutCompletedDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)LogoutDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddLogoutCompletedDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnLogoutCompleted
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnLogoutCompleted_Parameters : BaseObject {
        public OnLogoutCompleted_Parameters() { }
        public OnLogoutCompleted_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnLogoutCompleted.bWasSuccessful
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnLogoutCompleted;
    public void OnLogoutCompleted(bool bWasSuccessful) {
        _ptrOnLogoutCompleted ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnLogoutCompleted");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bWasSuccessful, @params, 4, 4);

        ProcessEvent(_ptrOnLogoutCompleted, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.Logout
    // 0xCDBB00
    // (Final | Native | Public)
    public unsafe class Logout_Parameters : BaseObject {
        public Logout_Parameters() { }
        public Logout_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.Logout.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.Logout.ReturnValue
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
    private static UFunction _ptrLogout;
    public bool Logout(byte LocalUserNum) {
        _ptrLogout ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.Logout");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        _ptrLogout.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrLogout, @params);
        _ptrLogout.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearLoginFailedDelegate
    // 0xCDBA00
    // (Final | Native | Public)
    public unsafe class ClearLoginFailedDelegate_Parameters : BaseObject {
        public ClearLoginFailedDelegate_Parameters() { }
        public ClearLoginFailedDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearLoginFailedDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearLoginFailedDelegate.LoginFailedDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate LoginFailedDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearLoginFailedDelegate;
    public void ClearLoginFailedDelegate(byte LocalUserNum, FScriptDelegate LoginFailedDelegate) {
        _ptrClearLoginFailedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ClearLoginFailedDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)LoginFailedDelegate.Pointer, @params + 8, 24, 24);

        _ptrClearLoginFailedDelegate.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrClearLoginFailedDelegate, @params);
        _ptrClearLoginFailedDelegate.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddLoginFailedDelegate
    // 0xCDB900
    // (Final | Native | Public)
    public unsafe class AddLoginFailedDelegate_Parameters : BaseObject {
        public AddLoginFailedDelegate_Parameters() { }
        public AddLoginFailedDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddLoginFailedDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddLoginFailedDelegate.LoginFailedDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate LoginFailedDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddLoginFailedDelegate;
    public void AddLoginFailedDelegate(byte LocalUserNum, FScriptDelegate LoginFailedDelegate) {
        _ptrAddLoginFailedDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AddLoginFailedDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)LoginFailedDelegate.Pointer, @params + 8, 24, 24);

        _ptrAddLoginFailedDelegate.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrAddLoginFailedDelegate, @params);
        _ptrAddLoginFailedDelegate.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReceievedPinGrantCode
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnReceievedPinGrantCode_Parameters : BaseObject {
        public OnReceievedPinGrantCode_Parameters() { }
        public OnReceievedPinGrantCode_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReceievedPinGrantCode.Result
        // 0x0 (0x1)
        // (Param)
        public UOnlineSubsystem.EPinGrantResult Result {
            get => *(UOnlineSubsystem.EPinGrantResult*)Pointer;
            set => *(UOnlineSubsystem.EPinGrantResult*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReceievedPinGrantCode.LocalUserNum
        // 0x1 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)(Pointer + 1);
            set => *(byte*)(Pointer + 1) = value;
        }

        // MISSED OFFSET: 0x6

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReceievedPinGrantCode.Code
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString Code {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReceievedPinGrantCode.URL
        // 0x18 (0x10)
        // (Param | NeedCtorLink)
        public FString URL {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReceievedPinGrantCode.SecondsUntilExpiration
        // 0x28 (0x4)
        // (Param)
        public int SecondsUntilExpiration {
            get => *(int*)(Pointer + 40);
            set => *(int*)(Pointer + 40) = value;
        }
    }
    private static UFunction _ptrOnReceievedPinGrantCode;
    public void OnReceievedPinGrantCode(UOnlineSubsystem.EPinGrantResult Result, byte LocalUserNum, FString Code, FString URL, int SecondsUntilExpiration) {
        _ptrOnReceievedPinGrantCode ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnReceievedPinGrantCode");

        var @params = stackalloc byte[38];
        System.Buffer.MemoryCopy(&Result, @params, 1, 1);
        System.Buffer.MemoryCopy(&LocalUserNum, @params + 1, 1, 1);
        System.Buffer.MemoryCopy((void*)Code.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy((void*)URL.Pointer, @params + 24, 16, 16);
        System.Buffer.MemoryCopy(&SecondsUntilExpiration, @params + 40, 4, 4);

        ProcessEvent(_ptrOnReceievedPinGrantCode, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnLoginFailed
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnLoginFailed_Parameters : BaseObject {
        public OnLoginFailed_Parameters() { }
        public OnLoginFailed_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnLoginFailed.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnLoginFailed.ErrorCode
        // 0x1 (0x1)
        // (Param)
        public UOnlineSubsystem.EOnlineServerConnectionStatus ErrorCode {
            get => *(UOnlineSubsystem.EOnlineServerConnectionStatus*)(Pointer + 1);
            set => *(UOnlineSubsystem.EOnlineServerConnectionStatus*)(Pointer + 1) = value;
        }
    }
    private static UFunction _ptrOnLoginFailed;
    public void OnLoginFailed(byte LocalUserNum, UOnlineSubsystem.EOnlineServerConnectionStatus ErrorCode) {
        _ptrOnLoginFailed ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnLoginFailed");

        var @params = stackalloc byte[2];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&ErrorCode, @params + 1, 1, 1);

        ProcessEvent(_ptrOnLoginFailed, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AutoLogin
    // 0x3750E0
    // (Final | Public)
    public unsafe class AutoLogin_Parameters : BaseObject {
        public AutoLogin_Parameters() { }
        public AutoLogin_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AutoLogin.ReturnValue
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
    private static UFunction _ptrAutoLogin;
    public bool AutoLogin() {
        _ptrAutoLogin ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.AutoLogin");

        var @params = stackalloc byte[4];

        ProcessEvent(_ptrAutoLogin, @params);

        return *(bool*)@params;
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.Login
    // 0xCDB6C0
    // (Final | Native | HasOptionalParams | Public)
    public unsafe class Login_Parameters : BaseObject {
        public Login_Parameters() { }
        public Login_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.Login.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.Login.LoginName
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString LoginName {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.Login.Password
        // 0x18 (0x10)
        // (Param | NeedCtorLink)
        public FString Password {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.Login.bWantsLocalOnly
        // 0x28 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bWantsLocalOnly {
            get => (*(uint*)(Pointer + 40) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 40) |= 0x1;
                else *(uint*)(Pointer + 40) &= ~(uint)0x1;
            }
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.Login.ReturnValue
        // 0x2C (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 44) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 44) |= 0x1;
                else *(uint*)(Pointer + 44) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrLogin;
    public bool Login(byte LocalUserNum, FString LoginName, FString Password, bool bWantsLocalOnly = false) {
        _ptrLogin ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.Login");

        var @params = stackalloc byte[41];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)LoginName.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy((void*)Password.Pointer, @params + 24, 16, 16);
        System.Buffer.MemoryCopy(&bWantsLocalOnly, @params + 40, 4, 4);

        _ptrLogin.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrLogin, @params);
        _ptrLogin.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 44);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowLoginUI
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class ShowLoginUI_Parameters : BaseObject {
        public ShowLoginUI_Parameters() { }
        public ShowLoginUI_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowLoginUI.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowLoginUI.bShowOnlineOnly
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bShowOnlineOnly {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // BoolProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowLoginUI.ReturnValue
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
    private static UFunction _ptrShowLoginUI;
    public bool ShowLoginUI(byte LocalUserNum, bool bShowOnlineOnly = false) {
        _ptrShowLoginUI ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.ShowLoginUI");

        var @params = stackalloc byte[9];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&bShowOnlineOnly, @params + 4, 4, 4);

        ProcessEvent(_ptrShowLoginUI, @params);

        return *(bool*)(@params + 8);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnFriendsChange
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnFriendsChange_Parameters : BaseObject {
        public OnFriendsChange_Parameters() { }
        public OnFriendsChange_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrOnFriendsChange;
    public void OnFriendsChange() {
        _ptrOnFriendsChange ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnFriendsChange");

        ProcessEvent(_ptrOnFriendsChange, null);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnMutingChange
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnMutingChange_Parameters : BaseObject {
        public OnMutingChange_Parameters() { }
        public OnMutingChange_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrOnMutingChange;
    public void OnMutingChange() {
        _ptrOnMutingChange ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnMutingChange");

        ProcessEvent(_ptrOnMutingChange, null);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnLoginCancelled
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnLoginCancelled_Parameters : BaseObject {
        public OnLoginCancelled_Parameters() { }
        public OnLoginCancelled_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrOnLoginCancelled;
    public void OnLoginCancelled() {
        _ptrOnLoginCancelled ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnLoginCancelled");

        ProcessEvent(_ptrOnLoginCancelled, null);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnLoginChange
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnLoginChange_Parameters : BaseObject {
        public OnLoginChange_Parameters() { }
        public OnLoginChange_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnLoginChange.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }
    }
    private static UFunction _ptrOnLoginChange;
    public void OnLoginChange(byte LocalUserNum) {
        _ptrOnLoginChange ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnLoginChange");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrOnLoginChange, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnPlayerUnblocked
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnPlayerUnblocked_Parameters : BaseObject {
        public OnPlayerUnblocked_Parameters() { }
        public OnPlayerUnblocked_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnPlayerUnblocked.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnPlayerUnblocked.PlayerID
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // ObjectProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnPlayerUnblocked.Error
        // 0x50 (0x8)
        // (Param)
        public UError Error {
            get {
                var pointer = *(nint*)(Pointer + 80);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 80) = value.Pointer;
        }
    }
    private static UFunction _ptrOnPlayerUnblocked;
    public void OnPlayerUnblocked(byte LocalUserNum, U_Types_Core.FUniqueNetId PlayerID, UError Error) {
        _ptrOnPlayerUnblocked ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnPlayerUnblocked");

        var @params = stackalloc byte[81];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params + 8, 72, 72);
        System.Buffer.MemoryCopy((void*)Error.Pointer, @params + 80, 8, 8);

        ProcessEvent(_ptrOnPlayerUnblocked, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnPlayerBlocked
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnPlayerBlocked_Parameters : BaseObject {
        public OnPlayerBlocked_Parameters() { }
        public OnPlayerBlocked_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnPlayerBlocked.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnPlayerBlocked.PlayerID
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // ObjectProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnPlayerBlocked.Error
        // 0x50 (0x8)
        // (Param)
        public UError Error {
            get {
                var pointer = *(nint*)(Pointer + 80);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 80) = value.Pointer;
        }
    }
    private static UFunction _ptrOnPlayerBlocked;
    public void OnPlayerBlocked(byte LocalUserNum, U_Types_Core.FUniqueNetId PlayerID, UError Error) {
        _ptrOnPlayerBlocked ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnPlayerBlocked");

        var @params = stackalloc byte[81];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params + 8, 72, 72);
        System.Buffer.MemoryCopy((void*)Error.Pointer, @params + 80, 8, 8);

        ProcessEvent(_ptrOnPlayerBlocked, @params);
    }

    // Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnBlockListUpdated
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnBlockListUpdated_Parameters : BaseObject {
        public OnBlockListUpdated_Parameters() { }
        public OnBlockListUpdated_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnBlockListUpdated.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }
    }
    private static UFunction _ptrOnBlockListUpdated;
    public void OnBlockListUpdated(byte LocalUserNum) {
        _ptrOnBlockListUpdated ??= FindFunction("Function OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnBlockListUpdated");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrOnBlockListUpdated, @params);
    }


    // ScriptStruct OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnlineStatusMappingEOS
    // 0x18
    public unsafe class FOnlineStatusMappingEOS : BaseObject {
        public FOnlineStatusMappingEOS() {
            Pointer = Marshal.AllocHGlobal(24);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 24);
            Allocated = true;
        }
        public FOnlineStatusMappingEOS(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnlineStatusMappingEOS.StatusId
        // 0x0 (0x4)
        public int StatusId {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.OnlineStatusMappingEOS.StatusString
        // 0x8 (0x10)
        // (Const | Localized | NeedCtorLink)
        public FString StatusString {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }

    // ScriptStruct OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.LoginDelegates
    // 0x10
    public unsafe class FLoginDelegates : BaseObject {
        public FLoginDelegates() {
            Pointer = Marshal.AllocHGlobal(16);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 16);
            Allocated = true;
        }
        public FLoginDelegates(nint pointer) : base(pointer) { }

        // ArrayProperty OnlineSubsystemEOS.OnlinePlayerInterfaceEOS.LoginDelegates.Delegates
        // 0x0 (0x10)
        // (NeedCtorLink)
        public StructTArray<FScriptDelegate> Delegates {
            get => new(Pointer, 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class OnlineSubsystemEOS.OnlinePlayerInterfaceEOS");
            return _staticClass;
        }
    }
}

// Class OnlineSubsystemEOS.OnlineStatsInterfaceEOS
// 0x68 (0x60 - 0xC8)
// (Compiled | Parsed | Native)
public unsafe partial class UOnlineStatsInterfaceEOS : UObject {
    public UOnlineStatsInterfaceEOS() { }
    public UOnlineStatsInterfaceEOS(nint pointer) : base(pointer) { }


    // StructProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.StatsHandle
    // 0x60 (0x8)
    // (Const | Native | Transient)
    public nint StatsHandle {
        get => *(nint*)(Pointer + 96);
        set => *(nint*)(Pointer + 96) = value;
    }

    // ObjectProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.PlayerInterfaceEOS
    // 0x68 (0x8)
    public UOnlinePlayerInterfaceEOS PlayerInterfaceEOS {
        get {
            var pointer = *(nint*)(Pointer + 104);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 104) = value.Pointer;
    }

    // ArrayProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadStatsDelegates
    // 0x70 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> ReadStatsDelegates {
        get => new(Pointer + 112, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 112), 16, 16);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.__OnReadOnlineStatsComplete__Delegate
    // 0x80 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnReadOnlineStatsComplete__Delegate {
        get => new(Pointer + 128);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 128), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.__OnFlushOnlineStatsComplete__Delegate
    // 0x98 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnFlushOnlineStatsComplete__Delegate {
        get => new(Pointer + 152);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 152), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.__OnRegisterHostStatGuidComplete__Delegate
    // 0xB0 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnRegisterHostStatGuidComplete__Delegate {
        get => new(Pointer + 176);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 176), 24, 24);
    }


    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.RegisterStatGuid
    // 0x3750E0
    // (Final | Public | HasOutParams)
    public unsafe class RegisterStatGuid_Parameters : BaseObject {
        public RegisterStatGuid_Parameters() { }
        public RegisterStatGuid_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.RegisterStatGuid.PlayerID
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // StrProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.RegisterStatGuid.ClientStatGuid
        // 0x48 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString ClientStatGuid {
            get => new(Pointer + 72);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 72), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.RegisterStatGuid.ReturnValue
        // 0x58 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 88) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 88) |= 0x1;
                else *(uint*)(Pointer + 88) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrRegisterStatGuid;
    public bool RegisterStatGuid(U_Types_Core.FUniqueNetId PlayerID, ref FString ClientStatGuid) {
        _ptrRegisterStatGuid ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.RegisterStatGuid");

        var @params = stackalloc byte[92];
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params, 72, 72);
        System.Buffer.MemoryCopy((void*)ClientStatGuid.Pointer, @params + 72, 16, 16);

        ProcessEvent(_ptrRegisterStatGuid, @params);

        var _ClientStatGuidPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 72, (void*)_ClientStatGuidPtr, 16, 16);
        ClientStatGuid = new(_ClientStatGuidPtr) { Allocated = true };

        return *(bool*)(@params + 88);
    }

    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.GetClientStatGuid
    // 0x3750E0
    // (Final | Public)
    public unsafe class GetClientStatGuid_Parameters : BaseObject {
        public GetClientStatGuid_Parameters() { }
        public GetClientStatGuid_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.GetClientStatGuid.ReturnValue
        // 0x0 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetClientStatGuid;
    public FString GetClientStatGuid() {
        _ptrGetClientStatGuid ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.GetClientStatGuid");

        var @params = stackalloc byte[16];

        ProcessEvent(_ptrGetClientStatGuid, @params);

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ClearRegisterHostStatGuidCompleteDelegateDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearRegisterHostStatGuidCompleteDelegateDelegate_Parameters : BaseObject {
        public ClearRegisterHostStatGuidCompleteDelegateDelegate_Parameters() { }
        public ClearRegisterHostStatGuidCompleteDelegateDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ClearRegisterHostStatGuidCompleteDelegateDelegate.RegisterHostStatGuidCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate RegisterHostStatGuidCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearRegisterHostStatGuidCompleteDelegateDelegate;
    public void ClearRegisterHostStatGuidCompleteDelegateDelegate(FScriptDelegate RegisterHostStatGuidCompleteDelegate) {
        _ptrClearRegisterHostStatGuidCompleteDelegateDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ClearRegisterHostStatGuidCompleteDelegateDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)RegisterHostStatGuidCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearRegisterHostStatGuidCompleteDelegateDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.AddRegisterHostStatGuidCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddRegisterHostStatGuidCompleteDelegate_Parameters : BaseObject {
        public AddRegisterHostStatGuidCompleteDelegate_Parameters() { }
        public AddRegisterHostStatGuidCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.AddRegisterHostStatGuidCompleteDelegate.RegisterHostStatGuidCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate RegisterHostStatGuidCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddRegisterHostStatGuidCompleteDelegate;
    public void AddRegisterHostStatGuidCompleteDelegate(FScriptDelegate RegisterHostStatGuidCompleteDelegate) {
        _ptrAddRegisterHostStatGuidCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.AddRegisterHostStatGuidCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)RegisterHostStatGuidCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddRegisterHostStatGuidCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.OnRegisterHostStatGuidComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnRegisterHostStatGuidComplete_Parameters : BaseObject {
        public OnRegisterHostStatGuidComplete_Parameters() { }
        public OnRegisterHostStatGuidComplete_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.OnRegisterHostStatGuidComplete.bWasSuccessful
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnRegisterHostStatGuidComplete;
    public void OnRegisterHostStatGuidComplete(bool bWasSuccessful) {
        _ptrOnRegisterHostStatGuidComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.OnRegisterHostStatGuidComplete");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bWasSuccessful, @params, 4, 4);

        ProcessEvent(_ptrOnRegisterHostStatGuidComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.RegisterHostStatGuid
    // 0x3750E0
    // (Final | Public | HasOutParams)
    public unsafe class RegisterHostStatGuid_Parameters : BaseObject {
        public RegisterHostStatGuid_Parameters() { }
        public RegisterHostStatGuid_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.RegisterHostStatGuid.HostStatGuid
        // 0x0 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString HostStatGuid {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.RegisterHostStatGuid.ReturnValue
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
    private static UFunction _ptrRegisterHostStatGuid;
    public bool RegisterHostStatGuid(ref FString HostStatGuid) {
        _ptrRegisterHostStatGuid ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.RegisterHostStatGuid");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)HostStatGuid.Pointer, @params, 16, 16);

        ProcessEvent(_ptrRegisterHostStatGuid, @params);

        var _HostStatGuidPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_HostStatGuidPtr, 16, 16);
        HostStatGuid = new(_HostStatGuidPtr) { Allocated = true };

        return *(bool*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.GetHostStatGuid
    // 0x3750E0
    // (Final | Public)
    public unsafe class GetHostStatGuid_Parameters : BaseObject {
        public GetHostStatGuid_Parameters() { }
        public GetHostStatGuid_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.GetHostStatGuid.ReturnValue
        // 0x0 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrGetHostStatGuid;
    public FString GetHostStatGuid() {
        _ptrGetHostStatGuid ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.GetHostStatGuid");

        var @params = stackalloc byte[16];

        ProcessEvent(_ptrGetHostStatGuid, @params);

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.WriteOnlinePlayerScores
    // 0x3750E0
    // (Final | Public | HasOutParams)
    public unsafe class WriteOnlinePlayerScores_Parameters : BaseObject {
        public WriteOnlinePlayerScores_Parameters() { }
        public WriteOnlinePlayerScores_Parameters(nint pointer) : base(pointer) { }

        // NameProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.WriteOnlinePlayerScores.SessionName
        // 0x0 (0x8)
        // (Param)
        public FName SessionName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // IntProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.WriteOnlinePlayerScores.LeaderboardId
        // 0x8 (0x4)
        // (Param)
        public int LeaderboardId {
            get => *(int*)(Pointer + 8);
            set => *(int*)(Pointer + 8) = value;
        }

        // MISSED OFFSET: 0x4

        // ArrayProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.WriteOnlinePlayerScores.PlayerScores
        // 0x10 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public StructTArray<UOnlineSubsystem.FOnlinePlayerScore> PlayerScores {
            get => new(Pointer + 16, 80);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.WriteOnlinePlayerScores.ReturnValue
        // 0x20 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 32) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 32) |= 0x1;
                else *(uint*)(Pointer + 32) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrWriteOnlinePlayerScores;
    public bool WriteOnlinePlayerScores(FName SessionName, int LeaderboardId, ref StructTArray<UOnlineSubsystem.FOnlinePlayerScore> PlayerScores) {
        _ptrWriteOnlinePlayerScores ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.WriteOnlinePlayerScores");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)SessionName.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&LeaderboardId, @params + 8, 4, 4);
        System.Buffer.MemoryCopy((void*)PlayerScores.Pointer, @params + 16, 16, 16);

        ProcessEvent(_ptrWriteOnlinePlayerScores, @params);

        var _PlayerScoresPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 16, (void*)_PlayerScoresPtr, 16, 16);
        PlayerScores = new(_PlayerScoresPtr, 80) { Allocated = true };

        return *(bool*)(@params + 32);
    }

    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ClearFlushOnlineStatsCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearFlushOnlineStatsCompleteDelegate_Parameters : BaseObject {
        public ClearFlushOnlineStatsCompleteDelegate_Parameters() { }
        public ClearFlushOnlineStatsCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ClearFlushOnlineStatsCompleteDelegate.FlushOnlineStatsCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate FlushOnlineStatsCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearFlushOnlineStatsCompleteDelegate;
    public void ClearFlushOnlineStatsCompleteDelegate(FScriptDelegate FlushOnlineStatsCompleteDelegate) {
        _ptrClearFlushOnlineStatsCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ClearFlushOnlineStatsCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)FlushOnlineStatsCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearFlushOnlineStatsCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.AddFlushOnlineStatsCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddFlushOnlineStatsCompleteDelegate_Parameters : BaseObject {
        public AddFlushOnlineStatsCompleteDelegate_Parameters() { }
        public AddFlushOnlineStatsCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.AddFlushOnlineStatsCompleteDelegate.FlushOnlineStatsCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate FlushOnlineStatsCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddFlushOnlineStatsCompleteDelegate;
    public void AddFlushOnlineStatsCompleteDelegate(FScriptDelegate FlushOnlineStatsCompleteDelegate) {
        _ptrAddFlushOnlineStatsCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.AddFlushOnlineStatsCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)FlushOnlineStatsCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddFlushOnlineStatsCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.OnFlushOnlineStatsComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnFlushOnlineStatsComplete_Parameters : BaseObject {
        public OnFlushOnlineStatsComplete_Parameters() { }
        public OnFlushOnlineStatsComplete_Parameters(nint pointer) : base(pointer) { }

        // NameProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.OnFlushOnlineStatsComplete.SessionName
        // 0x0 (0x8)
        // (Param)
        public FName SessionName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.OnFlushOnlineStatsComplete.bWasSuccessful
        // 0x8 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)(Pointer + 8) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 8) |= 0x1;
                else *(uint*)(Pointer + 8) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnFlushOnlineStatsComplete;
    public void OnFlushOnlineStatsComplete(FName SessionName, bool bWasSuccessful) {
        _ptrOnFlushOnlineStatsComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.OnFlushOnlineStatsComplete");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)SessionName.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&bWasSuccessful, @params + 8, 4, 4);

        ProcessEvent(_ptrOnFlushOnlineStatsComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.FlushOnlineStats
    // 0x3750E0
    // (Final | Public)
    public unsafe class FlushOnlineStats_Parameters : BaseObject {
        public FlushOnlineStats_Parameters() { }
        public FlushOnlineStats_Parameters(nint pointer) : base(pointer) { }

        // NameProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.FlushOnlineStats.SessionName
        // 0x0 (0x8)
        // (Param)
        public FName SessionName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.FlushOnlineStats.ReturnValue
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
    private static UFunction _ptrFlushOnlineStats;
    public bool FlushOnlineStats(FName SessionName) {
        _ptrFlushOnlineStats ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.FlushOnlineStats");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)SessionName.Pointer, @params, 8, 8);

        ProcessEvent(_ptrFlushOnlineStats, @params);

        return *(bool*)(@params + 8);
    }

    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.WriteOnlineStats
    // 0x3750E0
    // (Final | Public)
    public unsafe class WriteOnlineStats_Parameters : BaseObject {
        public WriteOnlineStats_Parameters() { }
        public WriteOnlineStats_Parameters(nint pointer) : base(pointer) { }

        // NameProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.WriteOnlineStats.SessionName
        // 0x0 (0x8)
        // (Param)
        public FName SessionName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // StructProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.WriteOnlineStats.Player
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId Player {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // ObjectProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.WriteOnlineStats.StatsWrite
        // 0x50 (0x8)
        // (Param)
        public UOnlineStatsWrite StatsWrite {
            get {
                var pointer = *(nint*)(Pointer + 80);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 80) = value.Pointer;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.WriteOnlineStats.ReturnValue
        // 0x58 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 88) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 88) |= 0x1;
                else *(uint*)(Pointer + 88) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrWriteOnlineStats;
    public bool WriteOnlineStats(FName SessionName, U_Types_Core.FUniqueNetId Player, UOnlineStatsWrite StatsWrite) {
        _ptrWriteOnlineStats ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.WriteOnlineStats");

        var @params = stackalloc byte[92];
        System.Buffer.MemoryCopy((void*)SessionName.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Player.Pointer, @params + 8, 72, 72);
        System.Buffer.MemoryCopy((void*)StatsWrite.Pointer, @params + 80, 8, 8);

        ProcessEvent(_ptrWriteOnlineStats, @params);

        return *(bool*)(@params + 88);
    }

    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.FreeStats
    // 0x3750E0
    // (Final | Public)
    public unsafe class FreeStats_Parameters : BaseObject {
        public FreeStats_Parameters() { }
        public FreeStats_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.FreeStats.StatsRead
        // 0x0 (0x8)
        // (Param)
        public UOnlineStatsRead StatsRead {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrFreeStats;
    public void FreeStats(UOnlineStatsRead StatsRead) {
        _ptrFreeStats ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.FreeStats");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy((void*)StatsRead.Pointer, @params, 8, 8);

        ProcessEvent(_ptrFreeStats, @params);
    }

    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ClearReadOnlineStatsCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearReadOnlineStatsCompleteDelegate_Parameters : BaseObject {
        public ClearReadOnlineStatsCompleteDelegate_Parameters() { }
        public ClearReadOnlineStatsCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ClearReadOnlineStatsCompleteDelegate.ReadOnlineStatsCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ReadOnlineStatsCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearReadOnlineStatsCompleteDelegate;
    public void ClearReadOnlineStatsCompleteDelegate(FScriptDelegate ReadOnlineStatsCompleteDelegate) {
        _ptrClearReadOnlineStatsCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ClearReadOnlineStatsCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)ReadOnlineStatsCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearReadOnlineStatsCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.AddReadOnlineStatsCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddReadOnlineStatsCompleteDelegate_Parameters : BaseObject {
        public AddReadOnlineStatsCompleteDelegate_Parameters() { }
        public AddReadOnlineStatsCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.AddReadOnlineStatsCompleteDelegate.ReadOnlineStatsCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ReadOnlineStatsCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddReadOnlineStatsCompleteDelegate;
    public void AddReadOnlineStatsCompleteDelegate(FScriptDelegate ReadOnlineStatsCompleteDelegate) {
        _ptrAddReadOnlineStatsCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.AddReadOnlineStatsCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)ReadOnlineStatsCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddReadOnlineStatsCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.OnReadOnlineStatsComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnReadOnlineStatsComplete_Parameters : BaseObject {
        public OnReadOnlineStatsComplete_Parameters() { }
        public OnReadOnlineStatsComplete_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.OnReadOnlineStatsComplete.bWasSuccessful
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnReadOnlineStatsComplete;
    public void OnReadOnlineStatsComplete(bool bWasSuccessful) {
        _ptrOnReadOnlineStatsComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.OnReadOnlineStatsComplete");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bWasSuccessful, @params, 4, 4);

        ProcessEvent(_ptrOnReadOnlineStatsComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStatsByRankAroundPlayer
    // 0xCDDB10
    // (Final | Native | HasOptionalParams | Public)
    public unsafe class ReadOnlineStatsByRankAroundPlayer_Parameters : BaseObject {
        public ReadOnlineStatsByRankAroundPlayer_Parameters() { }
        public ReadOnlineStatsByRankAroundPlayer_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStatsByRankAroundPlayer.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ObjectProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStatsByRankAroundPlayer.StatsRead
        // 0x8 (0x8)
        // (Param)
        public UOnlineStatsRead StatsRead {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // IntProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStatsByRankAroundPlayer.NumRows
        // 0x10 (0x4)
        // (OptionalParam | Param)
        public int NumRows {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStatsByRankAroundPlayer.ReturnValue
        // 0x14 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 20) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 20) |= 0x1;
                else *(uint*)(Pointer + 20) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrReadOnlineStatsByRankAroundPlayer;
    public bool ReadOnlineStatsByRankAroundPlayer(byte LocalUserNum, UOnlineStatsRead StatsRead, int NumRows = 0) {
        _ptrReadOnlineStatsByRankAroundPlayer ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStatsByRankAroundPlayer");

        var @params = stackalloc byte[17];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)StatsRead.Pointer, @params + 8, 8, 8);
        System.Buffer.MemoryCopy(&NumRows, @params + 16, 4, 4);

        _ptrReadOnlineStatsByRankAroundPlayer.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrReadOnlineStatsByRankAroundPlayer, @params);
        _ptrReadOnlineStatsByRankAroundPlayer.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 20);
    }

    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStatsByRank
    // 0xCDDA20
    // (Final | Native | HasOptionalParams | Public)
    public unsafe class ReadOnlineStatsByRank_Parameters : BaseObject {
        public ReadOnlineStatsByRank_Parameters() { }
        public ReadOnlineStatsByRank_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStatsByRank.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ObjectProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStatsByRank.StatsRead
        // 0x8 (0x8)
        // (Param)
        public UOnlineStatsRead StatsRead {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // IntProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStatsByRank.StartIndex
        // 0x10 (0x4)
        // (OptionalParam | Param)
        public int StartIndex {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }

        // IntProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStatsByRank.NumToRead
        // 0x14 (0x4)
        // (OptionalParam | Param)
        public int NumToRead {
            get => *(int*)(Pointer + 20);
            set => *(int*)(Pointer + 20) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStatsByRank.ReturnValue
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
    private static UFunction _ptrReadOnlineStatsByRank;
    public bool ReadOnlineStatsByRank(byte LocalUserNum, UOnlineStatsRead StatsRead, int StartIndex = 0, int NumToRead = 0) {
        _ptrReadOnlineStatsByRank ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStatsByRank");

        var @params = stackalloc byte[21];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)StatsRead.Pointer, @params + 8, 8, 8);
        System.Buffer.MemoryCopy(&StartIndex, @params + 16, 4, 4);
        System.Buffer.MemoryCopy(&NumToRead, @params + 20, 4, 4);

        _ptrReadOnlineStatsByRank.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrReadOnlineStatsByRank, @params);
        _ptrReadOnlineStatsByRank.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStatsForFriends
    // 0xCDC4A0
    // (Final | Native | Public)
    public unsafe class ReadOnlineStatsForFriends_Parameters : BaseObject {
        public ReadOnlineStatsForFriends_Parameters() { }
        public ReadOnlineStatsForFriends_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStatsForFriends.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ObjectProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStatsForFriends.StatsRead
        // 0x8 (0x8)
        // (Param)
        public UOnlineStatsRead StatsRead {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStatsForFriends.ReturnValue
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
    private static UFunction _ptrReadOnlineStatsForFriends;
    public bool ReadOnlineStatsForFriends(byte LocalUserNum, UOnlineStatsRead StatsRead) {
        _ptrReadOnlineStatsForFriends ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStatsForFriends");

        var @params = stackalloc byte[13];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)StatsRead.Pointer, @params + 8, 8, 8);

        _ptrReadOnlineStatsForFriends.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrReadOnlineStatsForFriends, @params);
        _ptrReadOnlineStatsForFriends.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStats
    // 0xCDD8F0
    // (Final | Native | Public | HasOutParams)
    public unsafe class ReadOnlineStats_Parameters : BaseObject {
        public ReadOnlineStats_Parameters() { }
        public ReadOnlineStats_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStats.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ArrayProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStats.Players
        // 0x8 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public StructTArray<U_Types_Core.FUniqueNetId> Players {
            get => new(Pointer + 8, 72);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // ObjectProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStats.StatsRead
        // 0x18 (0x8)
        // (Param)
        public UOnlineStatsRead StatsRead {
            get {
                var pointer = *(nint*)(Pointer + 24);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 24) = value.Pointer;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStats.ReturnValue
        // 0x20 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 32) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 32) |= 0x1;
                else *(uint*)(Pointer + 32) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrReadOnlineStats;
    public bool ReadOnlineStats(byte LocalUserNum, ref StructTArray<U_Types_Core.FUniqueNetId> Players, UOnlineStatsRead StatsRead) {
        _ptrReadOnlineStats ??= FindFunction("Function OnlineSubsystemEOS.OnlineStatsInterfaceEOS.ReadOnlineStats");

        var @params = stackalloc byte[29];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)Players.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy((void*)StatsRead.Pointer, @params + 24, 8, 8);

        _ptrReadOnlineStats.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrReadOnlineStats, @params);
        _ptrReadOnlineStats.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _PlayersPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_PlayersPtr, 16, 16);
        Players = new(_PlayersPtr, 72) { Allocated = true };

        return *(bool*)(@params + 32);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class OnlineSubsystemEOS.OnlineStatsInterfaceEOS");
            return _staticClass;
        }
    }
}

// Class OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS
// 0xB8 (0x60 - 0x118)
// (Compiled | Parsed | Native)
public unsafe partial class UOnlineUserCloudFileInterfaceEOS : UObject {
    public UOnlineUserCloudFileInterfaceEOS() { }
    public UOnlineUserCloudFileInterfaceEOS(nint pointer) : base(pointer) { }


    // StructProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.PDSHandle
    // 0x60 (0x8)
    // (Const | Native | Transient)
    public nint PDSHandle {
        get => *(nint*)(Pointer + 96);
        set => *(nint*)(Pointer + 96) = value;
    }

    // IntProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.LastReadFileErrorCode
    // 0x68 (0x4)
    // (Native | Transient)
    public int LastReadFileErrorCode {
        get => *(int*)(Pointer + 104);
        set => *(int*)(Pointer + 104) = value;
    }

    // MISSED OFFSET: 0x4

    // ObjectProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.PlayerInterfaceEOS
    // 0x70 (0x8)
    public UOnlinePlayerInterfaceEOS PlayerInterfaceEOS {
        get {
            var pointer = *(nint*)(Pointer + 112);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 112) = value.Pointer;
    }

    // ArrayProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.EnumerateUserFileCompleteDelegates
    // 0x78 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> EnumerateUserFileCompleteDelegates {
        get => new(Pointer + 120, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 120), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ReadUserFileCompleteDelegates
    // 0x88 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> ReadUserFileCompleteDelegates {
        get => new(Pointer + 136, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 136), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.WriteUserFileCompleteDelegates
    // 0x98 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> WriteUserFileCompleteDelegates {
        get => new(Pointer + 152, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 152), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.DeleteUserFileCompleteDelegates
    // 0xA8 (0x10)
    // (NeedCtorLink)
    public StructTArray<FScriptDelegate> DeleteUserFileCompleteDelegates {
        get => new(Pointer + 168, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 168), 16, 16);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.__OnEnumerateUserFilesComplete__Delegate
    // 0xB8 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnEnumerateUserFilesComplete__Delegate {
        get => new(Pointer + 184);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 184), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.__OnReadUserFileComplete__Delegate
    // 0xD0 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnReadUserFileComplete__Delegate {
        get => new(Pointer + 208);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 208), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.__OnWriteUserFileComplete__Delegate
    // 0xE8 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnWriteUserFileComplete__Delegate {
        get => new(Pointer + 232);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 232), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.__OnDeleteUserFileComplete__Delegate
    // 0x100 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnDeleteUserFileComplete__Delegate {
        get => new(Pointer + 256);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 256), 24, 24);
    }


    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearAllDelegates
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearAllDelegates_Parameters : BaseObject {
        public ClearAllDelegates_Parameters() { }
        public ClearAllDelegates_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrClearAllDelegates;
    public void ClearAllDelegates() {
        _ptrClearAllDelegates ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearAllDelegates");

        ProcessEvent(_ptrClearAllDelegates, null);
    }

    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearDeleteUserFileCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearDeleteUserFileCompleteDelegate_Parameters : BaseObject {
        public ClearDeleteUserFileCompleteDelegate_Parameters() { }
        public ClearDeleteUserFileCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearDeleteUserFileCompleteDelegate.DeleteUserFileCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate DeleteUserFileCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearDeleteUserFileCompleteDelegate;
    public void ClearDeleteUserFileCompleteDelegate(FScriptDelegate DeleteUserFileCompleteDelegate) {
        _ptrClearDeleteUserFileCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearDeleteUserFileCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)DeleteUserFileCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearDeleteUserFileCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.AddDeleteUserFileCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddDeleteUserFileCompleteDelegate_Parameters : BaseObject {
        public AddDeleteUserFileCompleteDelegate_Parameters() { }
        public AddDeleteUserFileCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.AddDeleteUserFileCompleteDelegate.DeleteUserFileCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate DeleteUserFileCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddDeleteUserFileCompleteDelegate;
    public void AddDeleteUserFileCompleteDelegate(FScriptDelegate DeleteUserFileCompleteDelegate) {
        _ptrAddDeleteUserFileCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.AddDeleteUserFileCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)DeleteUserFileCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddDeleteUserFileCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.DeleteUserFile
    // 0xCDEA50
    // (Final | Native | Public)
    public unsafe class DeleteUserFile_Parameters : BaseObject {
        public DeleteUserFile_Parameters() { }
        public DeleteUserFile_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.DeleteUserFile.UserId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString UserId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.DeleteUserFile.Filename
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString Filename {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.DeleteUserFile.bShouldCloudDelete
        // 0x20 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bShouldCloudDelete {
            get => (*(uint*)(Pointer + 32) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 32) |= 0x1;
                else *(uint*)(Pointer + 32) &= ~(uint)0x1;
            }
        }

        // BoolProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.DeleteUserFile.bShouldLocallyDelete
        // 0x24 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bShouldLocallyDelete {
            get => (*(uint*)(Pointer + 36) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 36) |= 0x1;
                else *(uint*)(Pointer + 36) &= ~(uint)0x1;
            }
        }

        // BoolProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.DeleteUserFile.ReturnValue
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
    private static UFunction _ptrDeleteUserFile;
    public bool DeleteUserFile(FString UserId, FString Filename, bool bShouldCloudDelete, bool bShouldLocallyDelete) {
        _ptrDeleteUserFile ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.DeleteUserFile");

        var @params = stackalloc byte[44];
        System.Buffer.MemoryCopy((void*)UserId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)Filename.Pointer, @params + 16, 16, 16);
        System.Buffer.MemoryCopy(&bShouldCloudDelete, @params + 32, 4, 4);
        System.Buffer.MemoryCopy(&bShouldLocallyDelete, @params + 36, 4, 4);

        _ptrDeleteUserFile.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrDeleteUserFile, @params);
        _ptrDeleteUserFile.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 40);
    }

    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.OnDeleteUserFileComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnDeleteUserFileComplete_Parameters : BaseObject {
        public OnDeleteUserFileComplete_Parameters() { }
        public OnDeleteUserFileComplete_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.OnDeleteUserFileComplete.bWasSuccessful
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }

        // MISSED OFFSET: 0x4

        // StrProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.OnDeleteUserFileComplete.UserId
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString UserId {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.OnDeleteUserFileComplete.Filename
        // 0x18 (0x10)
        // (Param | NeedCtorLink)
        public FString Filename {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }
    }
    private static UFunction _ptrOnDeleteUserFileComplete;
    public void OnDeleteUserFileComplete(bool bWasSuccessful, FString UserId, FString Filename) {
        _ptrOnDeleteUserFileComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.OnDeleteUserFileComplete");

        var @params = stackalloc byte[36];
        System.Buffer.MemoryCopy(&bWasSuccessful, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)UserId.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy((void*)Filename.Pointer, @params + 24, 16, 16);

        ProcessEvent(_ptrOnDeleteUserFileComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearWriteUserFileCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearWriteUserFileCompleteDelegate_Parameters : BaseObject {
        public ClearWriteUserFileCompleteDelegate_Parameters() { }
        public ClearWriteUserFileCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearWriteUserFileCompleteDelegate.WriteUserFileCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate WriteUserFileCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearWriteUserFileCompleteDelegate;
    public void ClearWriteUserFileCompleteDelegate(FScriptDelegate WriteUserFileCompleteDelegate) {
        _ptrClearWriteUserFileCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearWriteUserFileCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)WriteUserFileCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearWriteUserFileCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.AddWriteUserFileCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddWriteUserFileCompleteDelegate_Parameters : BaseObject {
        public AddWriteUserFileCompleteDelegate_Parameters() { }
        public AddWriteUserFileCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.AddWriteUserFileCompleteDelegate.WriteUserFileCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate WriteUserFileCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddWriteUserFileCompleteDelegate;
    public void AddWriteUserFileCompleteDelegate(FScriptDelegate WriteUserFileCompleteDelegate) {
        _ptrAddWriteUserFileCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.AddWriteUserFileCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)WriteUserFileCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddWriteUserFileCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.WriteUserFile
    // 0xCDE8F0
    // (Final | Native | Public | HasOutParams)
    public unsafe class WriteUserFile_Parameters : BaseObject {
        public WriteUserFile_Parameters() { }
        public WriteUserFile_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.WriteUserFile.UserId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString UserId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.WriteUserFile.Filename
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString Filename {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // ArrayProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.WriteUserFile.FileContents
        // 0x20 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public UnmanagedTArray<byte> FileContents {
            get => new(Pointer + 32);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 32), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.WriteUserFile.ReturnValue
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
    private static UFunction _ptrWriteUserFile;
    public bool WriteUserFile(FString UserId, FString Filename, ref UnmanagedTArray<byte> FileContents) {
        _ptrWriteUserFile ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.WriteUserFile");

        var @params = stackalloc byte[52];
        System.Buffer.MemoryCopy((void*)UserId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)Filename.Pointer, @params + 16, 16, 16);
        System.Buffer.MemoryCopy((void*)FileContents.Pointer, @params + 32, 16, 16);

        _ptrWriteUserFile.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrWriteUserFile, @params);
        _ptrWriteUserFile.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _FileContentsPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 32, (void*)_FileContentsPtr, 16, 16);
        FileContents = new(_FileContentsPtr) { Allocated = true };

        return *(bool*)(@params + 48);
    }

    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.OnWriteUserFileComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnWriteUserFileComplete_Parameters : BaseObject {
        public OnWriteUserFileComplete_Parameters() { }
        public OnWriteUserFileComplete_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.OnWriteUserFileComplete.bWasSuccessful
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }

        // MISSED OFFSET: 0x4

        // StrProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.OnWriteUserFileComplete.UserId
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString UserId {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.OnWriteUserFileComplete.Filename
        // 0x18 (0x10)
        // (Param | NeedCtorLink)
        public FString Filename {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }
    }
    private static UFunction _ptrOnWriteUserFileComplete;
    public void OnWriteUserFileComplete(bool bWasSuccessful, FString UserId, FString Filename) {
        _ptrOnWriteUserFileComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.OnWriteUserFileComplete");

        var @params = stackalloc byte[36];
        System.Buffer.MemoryCopy(&bWasSuccessful, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)UserId.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy((void*)Filename.Pointer, @params + 24, 16, 16);

        ProcessEvent(_ptrOnWriteUserFileComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearReadUserFileCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearReadUserFileCompleteDelegate_Parameters : BaseObject {
        public ClearReadUserFileCompleteDelegate_Parameters() { }
        public ClearReadUserFileCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearReadUserFileCompleteDelegate.ReadUserFileCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ReadUserFileCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearReadUserFileCompleteDelegate;
    public void ClearReadUserFileCompleteDelegate(FScriptDelegate ReadUserFileCompleteDelegate) {
        _ptrClearReadUserFileCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearReadUserFileCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)ReadUserFileCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearReadUserFileCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.AddReadUserFileCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddReadUserFileCompleteDelegate_Parameters : BaseObject {
        public AddReadUserFileCompleteDelegate_Parameters() { }
        public AddReadUserFileCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.AddReadUserFileCompleteDelegate.ReadUserFileCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate ReadUserFileCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddReadUserFileCompleteDelegate;
    public void AddReadUserFileCompleteDelegate(FScriptDelegate ReadUserFileCompleteDelegate) {
        _ptrAddReadUserFileCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.AddReadUserFileCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)ReadUserFileCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddReadUserFileCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ReadUserFile
    // 0xCDE7E0
    // (Final | Native | Public)
    public unsafe class ReadUserFile_Parameters : BaseObject {
        public ReadUserFile_Parameters() { }
        public ReadUserFile_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ReadUserFile.UserId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString UserId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ReadUserFile.Filename
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString Filename {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ReadUserFile.ReturnValue
        // 0x20 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 32) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 32) |= 0x1;
                else *(uint*)(Pointer + 32) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrReadUserFile;
    public bool ReadUserFile(FString UserId, FString Filename) {
        _ptrReadUserFile ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ReadUserFile");

        var @params = stackalloc byte[36];
        System.Buffer.MemoryCopy((void*)UserId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)Filename.Pointer, @params + 16, 16, 16);

        _ptrReadUserFile.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrReadUserFile, @params);
        _ptrReadUserFile.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 32);
    }

    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.OnReadUserFileComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnReadUserFileComplete_Parameters : BaseObject {
        public OnReadUserFileComplete_Parameters() { }
        public OnReadUserFileComplete_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.OnReadUserFileComplete.bWasSuccessful
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }

        // MISSED OFFSET: 0x4

        // StrProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.OnReadUserFileComplete.UserId
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString UserId {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.OnReadUserFileComplete.Filename
        // 0x18 (0x10)
        // (Param | NeedCtorLink)
        public FString Filename {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 16, 16);
        }
    }
    private static UFunction _ptrOnReadUserFileComplete;
    public void OnReadUserFileComplete(bool bWasSuccessful, FString UserId, FString Filename) {
        _ptrOnReadUserFileComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.OnReadUserFileComplete");

        var @params = stackalloc byte[36];
        System.Buffer.MemoryCopy(&bWasSuccessful, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)UserId.Pointer, @params + 8, 16, 16);
        System.Buffer.MemoryCopy((void*)Filename.Pointer, @params + 24, 16, 16);

        ProcessEvent(_ptrOnReadUserFileComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.GetUserFileList
    // 0xCDE680
    // (Final | Native | Public | HasOutParams)
    public unsafe class GetUserFileList_Parameters : BaseObject {
        public GetUserFileList_Parameters() { }
        public GetUserFileList_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.GetUserFileList.UserId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString UserId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ArrayProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.GetUserFileList.UserFiles
        // 0x10 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public StructTArray<UOnlineSubsystem.FEmsFile> UserFiles {
            get => new(Pointer + 16, 56);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }
    }
    private static UFunction _ptrGetUserFileList;
    public void GetUserFileList(FString UserId, ref StructTArray<UOnlineSubsystem.FEmsFile> UserFiles) {
        _ptrGetUserFileList ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.GetUserFileList");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)UserId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)UserFiles.Pointer, @params + 16, 16, 16);

        _ptrGetUserFileList.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetUserFileList, @params);
        _ptrGetUserFileList.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _UserFilesPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 16, (void*)_UserFilesPtr, 16, 16);
        UserFiles = new(_UserFilesPtr, 56) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearEnumerateUserFileCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ClearEnumerateUserFileCompleteDelegate_Parameters : BaseObject {
        public ClearEnumerateUserFileCompleteDelegate_Parameters() { }
        public ClearEnumerateUserFileCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearEnumerateUserFileCompleteDelegate.EnumerateUserFileCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate EnumerateUserFileCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearEnumerateUserFileCompleteDelegate;
    public void ClearEnumerateUserFileCompleteDelegate(FScriptDelegate EnumerateUserFileCompleteDelegate) {
        _ptrClearEnumerateUserFileCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearEnumerateUserFileCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)EnumerateUserFileCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearEnumerateUserFileCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.AddEnumerateUserFileCompleteDelegate
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class AddEnumerateUserFileCompleteDelegate_Parameters : BaseObject {
        public AddEnumerateUserFileCompleteDelegate_Parameters() { }
        public AddEnumerateUserFileCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.AddEnumerateUserFileCompleteDelegate.EnumerateUserFileCompleteDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate EnumerateUserFileCompleteDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddEnumerateUserFileCompleteDelegate;
    public void AddEnumerateUserFileCompleteDelegate(FScriptDelegate EnumerateUserFileCompleteDelegate) {
        _ptrAddEnumerateUserFileCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.AddEnumerateUserFileCompleteDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)EnumerateUserFileCompleteDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddEnumerateUserFileCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.EnumerateUserFiles
    // 0xCDE5D0
    // (Final | Native | Public)
    public unsafe class EnumerateUserFiles_Parameters : BaseObject {
        public EnumerateUserFiles_Parameters() { }
        public EnumerateUserFiles_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.EnumerateUserFiles.UserId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString UserId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrEnumerateUserFiles;
    public void EnumerateUserFiles(FString UserId) {
        _ptrEnumerateUserFiles ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.EnumerateUserFiles");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)UserId.Pointer, @params, 16, 16);

        _ptrEnumerateUserFiles.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrEnumerateUserFiles, @params);
        _ptrEnumerateUserFiles.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.OnEnumerateUserFilesComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnEnumerateUserFilesComplete_Parameters : BaseObject {
        public OnEnumerateUserFilesComplete_Parameters() { }
        public OnEnumerateUserFilesComplete_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.OnEnumerateUserFilesComplete.bWasSuccessful
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bWasSuccessful {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }

        // MISSED OFFSET: 0x4

        // StrProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.OnEnumerateUserFilesComplete.UserId
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString UserId {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrOnEnumerateUserFilesComplete;
    public void OnEnumerateUserFilesComplete(bool bWasSuccessful, FString UserId) {
        _ptrOnEnumerateUserFilesComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.OnEnumerateUserFilesComplete");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy(&bWasSuccessful, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)UserId.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrOnEnumerateUserFilesComplete, @params);
    }

    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearFile
    // 0xCDE4B0
    // (Final | Native | Public)
    public unsafe class ClearFile_Parameters : BaseObject {
        public ClearFile_Parameters() { }
        public ClearFile_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearFile.UserId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString UserId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearFile.Filename
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString Filename {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearFile.ReturnValue
        // 0x20 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 32) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 32) |= 0x1;
                else *(uint*)(Pointer + 32) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrClearFile;
    public bool ClearFile(FString UserId, FString Filename) {
        _ptrClearFile ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearFile");

        var @params = stackalloc byte[36];
        System.Buffer.MemoryCopy((void*)UserId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)Filename.Pointer, @params + 16, 16, 16);

        _ptrClearFile.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrClearFile, @params);
        _ptrClearFile.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 32);
    }

    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearFiles
    // 0xCDE3F0
    // (Final | Native | Public)
    public unsafe class ClearFiles_Parameters : BaseObject {
        public ClearFiles_Parameters() { }
        public ClearFiles_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearFiles.UserId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString UserId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearFiles.ReturnValue
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
    private static UFunction _ptrClearFiles;
    public bool ClearFiles(FString UserId) {
        _ptrClearFiles ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.ClearFiles");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)UserId.Pointer, @params, 16, 16);

        _ptrClearFiles.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrClearFiles, @params);
        _ptrClearFiles.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.GetFileContents
    // 0xCDE1A0
    // (Final | Native | Public | HasOutParams)
    public unsafe class GetFileContents_Parameters : BaseObject {
        public GetFileContents_Parameters() { }
        public GetFileContents_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.GetFileContents.UserId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString UserId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.GetFileContents.Filename
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString Filename {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // ArrayProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.GetFileContents.FileContents
        // 0x20 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public UnmanagedTArray<byte> FileContents {
            get => new(Pointer + 32);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 32), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.GetFileContents.ReturnValue
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
    private static UFunction _ptrGetFileContents;
    public bool GetFileContents(FString UserId, FString Filename, ref UnmanagedTArray<byte> FileContents) {
        _ptrGetFileContents ??= FindFunction("Function OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS.GetFileContents");

        var @params = stackalloc byte[52];
        System.Buffer.MemoryCopy((void*)UserId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)Filename.Pointer, @params + 16, 16, 16);
        System.Buffer.MemoryCopy((void*)FileContents.Pointer, @params + 32, 16, 16);

        _ptrGetFileContents.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetFileContents, @params);
        _ptrGetFileContents.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _FileContentsPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 32, (void*)_FileContentsPtr, 16, 16);
        FileContents = new(_FileContentsPtr) { Allocated = true };

        return *(bool*)(@params + 48);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class OnlineSubsystemEOS.OnlineUserCloudFileInterfaceEOS");
            return _staticClass;
        }
    }
}

// Class OnlineSubsystemEOS.OnlineVoiceInterfaceEOS
// 0x100 (0x60 - 0x160)
// (Compiled | Parsed | Native)
public unsafe partial class UOnlineVoiceInterfaceEOS : UObject {
    public UOnlineVoiceInterfaceEOS() { }
    public UOnlineVoiceInterfaceEOS(nint pointer) : base(pointer) { }


    // StructProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.RTCHandle
    // 0x60 (0x8)
    // (Const | Native | Transient)
    public nint RTCHandle {
        get => *(nint*)(Pointer + 96);
        set => *(nint*)(Pointer + 96) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.RTCAudioHandle
    // 0x68 (0x8)
    // (Const | Native | Transient)
    public nint RTCAudioHandle {
        get => *(nint*)(Pointer + 104);
        set => *(nint*)(Pointer + 104) = value;
    }

    // StructProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.RTCAdminHandle
    // 0x70 (0x8)
    // (Const | Native | Transient)
    public nint RTCAdminHandle {
        get => *(nint*)(Pointer + 112);
        set => *(nint*)(Pointer + 112) = value;
    }

    // ObjectProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.PlayerInterfaceEOS
    // 0x78 (0x8)
    public UOnlinePlayerInterfaceEOS PlayerInterfaceEOS {
        get {
            var pointer = *(nint*)(Pointer + 120);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 120) = value.Pointer;
    }

    // ArrayProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.InputAudioDevices
    // 0x80 (0x10)
    // (NeedCtorLink | PrivateWrite)
    public StructTArray<U_Types_Core.FVoiceAudioDevice> InputAudioDevices {
        get => new(Pointer + 128, 40);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 128), 16, 16);
    }

    // ArrayProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.OutputAudioDevices
    // 0x90 (0x10)
    // (NeedCtorLink | PrivateWrite)
    public StructTArray<U_Types_Core.FVoiceAudioDevice> OutputAudioDevices {
        get => new(Pointer + 144, 40);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 144), 16, 16);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.__EventLeftVoiceRoom__Delegate
    // 0xA0 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventLeftVoiceRoom__Delegate {
        get => new(Pointer + 160);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 160), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.__EventJoinedVoiceRoom__Delegate
    // 0xB8 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventJoinedVoiceRoom__Delegate {
        get => new(Pointer + 184);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 184), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.__EventRemovedFromVoiceRoom__Delegate
    // 0xD0 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventRemovedFromVoiceRoom__Delegate {
        get => new(Pointer + 208);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 208), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.__EventPlayerJoinedVoiceRoom__Delegate
    // 0xE8 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventPlayerJoinedVoiceRoom__Delegate {
        get => new(Pointer + 232);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 232), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.__EventPlayerLeftVoiceRoom__Delegate
    // 0x100 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventPlayerLeftVoiceRoom__Delegate {
        get => new(Pointer + 256);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 256), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.__EventPlayerStatusChanged__Delegate
    // 0x118 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventPlayerStatusChanged__Delegate {
        get => new(Pointer + 280);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 280), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.__OnPlayerTalkingStateChange__Delegate
    // 0x130 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnPlayerTalkingStateChange__Delegate {
        get => new(Pointer + 304);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 304), 24, 24);
    }

    // DelegateProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.__OnRecognitionComplete__Delegate
    // 0x148 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __OnRecognitionComplete__Delegate {
        get => new(Pointer + 328);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 328), 24, 24);
    }


    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetVoiceReceiveVolume
    // 0x3750E0
    // (Final | Public)
    public unsafe class SetVoiceReceiveVolume_Parameters : BaseObject {
        public SetVoiceReceiveVolume_Parameters() { }
        public SetVoiceReceiveVolume_Parameters(nint pointer) : base(pointer) { }

        // FloatProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetVoiceReceiveVolume.VoiceVolume
        // 0x0 (0x4)
        // (Param)
        public float VoiceVolume {
            get => *(float*)Pointer;
            set => *(float*)Pointer = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetVoiceReceiveVolume.ReturnValue
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
    private static UFunction _ptrSetVoiceReceiveVolume;
    public bool SetVoiceReceiveVolume(float VoiceVolume) {
        _ptrSetVoiceReceiveVolume ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetVoiceReceiveVolume");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&VoiceVolume, @params, 4, 4);

        ProcessEvent(_ptrSetVoiceReceiveVolume, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.UnmuteAll
    // 0x3750E0
    // (Final | Public)
    public unsafe class UnmuteAll_Parameters : BaseObject {
        public UnmuteAll_Parameters() { }
        public UnmuteAll_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.UnmuteAll.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.UnmuteAll.ReturnValue
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
    private static UFunction _ptrUnmuteAll;
    public bool UnmuteAll(byte LocalUserNum) {
        _ptrUnmuteAll ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.UnmuteAll");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrUnmuteAll, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.MuteAll
    // 0x3750E0
    // (Final | Public)
    public unsafe class MuteAll_Parameters : BaseObject {
        public MuteAll_Parameters() { }
        public MuteAll_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.MuteAll.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.MuteAll.bAllowFriends
        // 0x4 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bAllowFriends {
            get => (*(uint*)(Pointer + 4) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 4) |= 0x1;
                else *(uint*)(Pointer + 4) &= ~(uint)0x1;
            }
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.MuteAll.ReturnValue
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
    private static UFunction _ptrMuteAll;
    public bool MuteAll(byte LocalUserNum, bool bAllowFriends) {
        _ptrMuteAll ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.MuteAll");

        var @params = stackalloc byte[9];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&bAllowFriends, @params + 4, 4, 4);

        ProcessEvent(_ptrMuteAll, @params);

        return *(bool*)(@params + 8);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetSpeechRecognitionObject
    // 0x3750E0
    // (Final | Public)
    public unsafe class SetSpeechRecognitionObject_Parameters : BaseObject {
        public SetSpeechRecognitionObject_Parameters() { }
        public SetSpeechRecognitionObject_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetSpeechRecognitionObject.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ObjectProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetSpeechRecognitionObject.SpeechRecogObj
        // 0x8 (0x8)
        // (Param)
        public USpeechRecognition SpeechRecogObj {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetSpeechRecognitionObject.ReturnValue
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
    private static UFunction _ptrSetSpeechRecognitionObject;
    public bool SetSpeechRecognitionObject(byte LocalUserNum, USpeechRecognition SpeechRecogObj) {
        _ptrSetSpeechRecognitionObject ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetSpeechRecognitionObject");

        var @params = stackalloc byte[13];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)SpeechRecogObj.Pointer, @params + 8, 8, 8);

        ProcessEvent(_ptrSetSpeechRecognitionObject, @params);

        return *(bool*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SelectVocabulary
    // 0x3750E0
    // (Final | Public)
    public unsafe class SelectVocabulary_Parameters : BaseObject {
        public SelectVocabulary_Parameters() { }
        public SelectVocabulary_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SelectVocabulary.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // IntProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SelectVocabulary.VocabularyId
        // 0x4 (0x4)
        // (Param)
        public int VocabularyId {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SelectVocabulary.ReturnValue
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
    private static UFunction _ptrSelectVocabulary;
    public bool SelectVocabulary(byte LocalUserNum, int VocabularyId) {
        _ptrSelectVocabulary ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SelectVocabulary");

        var @params = stackalloc byte[9];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy(&VocabularyId, @params + 4, 4, 4);

        ProcessEvent(_ptrSelectVocabulary, @params);

        return *(bool*)(@params + 8);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.ClearRecognitionCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearRecognitionCompleteDelegate_Parameters : BaseObject {
        public ClearRecognitionCompleteDelegate_Parameters() { }
        public ClearRecognitionCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.ClearRecognitionCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.ClearRecognitionCompleteDelegate.RecognitionDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate RecognitionDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrClearRecognitionCompleteDelegate;
    public void ClearRecognitionCompleteDelegate(byte LocalUserNum, FScriptDelegate RecognitionDelegate) {
        _ptrClearRecognitionCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.ClearRecognitionCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)RecognitionDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrClearRecognitionCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.AddRecognitionCompleteDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddRecognitionCompleteDelegate_Parameters : BaseObject {
        public AddRecognitionCompleteDelegate_Parameters() { }
        public AddRecognitionCompleteDelegate_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.AddRecognitionCompleteDelegate.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // DelegateProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.AddRecognitionCompleteDelegate.RecognitionDelegate
        // 0x8 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate RecognitionDelegate {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 24, 24);
        }
    }
    private static UFunction _ptrAddRecognitionCompleteDelegate;
    public void AddRecognitionCompleteDelegate(byte LocalUserNum, FScriptDelegate RecognitionDelegate) {
        _ptrAddRecognitionCompleteDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.AddRecognitionCompleteDelegate");

        var @params = stackalloc byte[25];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)RecognitionDelegate.Pointer, @params + 8, 24, 24);

        ProcessEvent(_ptrAddRecognitionCompleteDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.GetRecognitionResults
    // 0x3750E0
    // (Final | Public | HasOutParams)
    public unsafe class GetRecognitionResults_Parameters : BaseObject {
        public GetRecognitionResults_Parameters() { }
        public GetRecognitionResults_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.GetRecognitionResults.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // ArrayProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.GetRecognitionResults.Words
        // 0x8 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public StructTArray<UOnlineSubsystem.FSpeechRecognizedWord> Words {
            get => new(Pointer + 8, 32);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.GetRecognitionResults.ReturnValue
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
    private static UFunction _ptrGetRecognitionResults;
    public bool GetRecognitionResults(byte LocalUserNum, ref StructTArray<UOnlineSubsystem.FSpeechRecognizedWord> Words) {
        _ptrGetRecognitionResults ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.GetRecognitionResults");

        var @params = stackalloc byte[21];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)Words.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrGetRecognitionResults, @params);

        var _WordsPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_WordsPtr, 16, 16);
        Words = new(_WordsPtr, 32) { Allocated = true };

        return *(bool*)(@params + 24);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.StopSpeechRecognition
    // 0x3750E0
    // (Final | Public)
    public unsafe class StopSpeechRecognition_Parameters : BaseObject {
        public StopSpeechRecognition_Parameters() { }
        public StopSpeechRecognition_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.StopSpeechRecognition.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.StopSpeechRecognition.ReturnValue
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
    private static UFunction _ptrStopSpeechRecognition;
    public bool StopSpeechRecognition(byte LocalUserNum) {
        _ptrStopSpeechRecognition ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.StopSpeechRecognition");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrStopSpeechRecognition, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.StartSpeechRecognition
    // 0x3750E0
    // (Final | Public)
    public unsafe class StartSpeechRecognition_Parameters : BaseObject {
        public StartSpeechRecognition_Parameters() { }
        public StartSpeechRecognition_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.StartSpeechRecognition.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.StartSpeechRecognition.ReturnValue
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
    private static UFunction _ptrStartSpeechRecognition;
    public bool StartSpeechRecognition(byte LocalUserNum) {
        _ptrStartSpeechRecognition ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.StartSpeechRecognition");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrStartSpeechRecognition, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.StopNetworkedVoice
    // 0x3750E0
    // (Final | Public)
    public unsafe class StopNetworkedVoice_Parameters : BaseObject {
        public StopNetworkedVoice_Parameters() { }
        public StopNetworkedVoice_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.StopNetworkedVoice.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }
    }
    private static UFunction _ptrStopNetworkedVoice;
    public void StopNetworkedVoice(byte LocalUserNum) {
        _ptrStopNetworkedVoice ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.StopNetworkedVoice");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrStopNetworkedVoice, @params);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.StartNetworkedVoice
    // 0x3750E0
    // (Final | Public)
    public unsafe class StartNetworkedVoice_Parameters : BaseObject {
        public StartNetworkedVoice_Parameters() { }
        public StartNetworkedVoice_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.StartNetworkedVoice.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }
    }
    private static UFunction _ptrStartNetworkedVoice;
    public void StartNetworkedVoice(byte LocalUserNum) {
        _ptrStartNetworkedVoice ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.StartNetworkedVoice");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrStartNetworkedVoice, @params);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.ClearPlayerTalkingDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class ClearPlayerTalkingDelegate_Parameters : BaseObject {
        public ClearPlayerTalkingDelegate_Parameters() { }
        public ClearPlayerTalkingDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.ClearPlayerTalkingDelegate.TalkerDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate TalkerDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrClearPlayerTalkingDelegate;
    public void ClearPlayerTalkingDelegate(FScriptDelegate TalkerDelegate) {
        _ptrClearPlayerTalkingDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.ClearPlayerTalkingDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)TalkerDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrClearPlayerTalkingDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.AddPlayerTalkingDelegate
    // 0x3750E0
    // (Final | Public)
    public unsafe class AddPlayerTalkingDelegate_Parameters : BaseObject {
        public AddPlayerTalkingDelegate_Parameters() { }
        public AddPlayerTalkingDelegate_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.AddPlayerTalkingDelegate.TalkerDelegate
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate TalkerDelegate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrAddPlayerTalkingDelegate;
    public void AddPlayerTalkingDelegate(FScriptDelegate TalkerDelegate) {
        _ptrAddPlayerTalkingDelegate ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.AddPlayerTalkingDelegate");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)TalkerDelegate.Pointer, @params, 24, 24);

        ProcessEvent(_ptrAddPlayerTalkingDelegate, @params);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.UnmuteRemoteTalker
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class UnmuteRemoteTalker_Parameters : BaseObject {
        public UnmuteRemoteTalker_Parameters() { }
        public UnmuteRemoteTalker_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.UnmuteRemoteTalker.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.UnmuteRemoteTalker.PlayerID
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.UnmuteRemoteTalker.bIsSystemWide
        // 0x50 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bIsSystemWide {
            get => (*(uint*)(Pointer + 80) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 80) |= 0x1;
                else *(uint*)(Pointer + 80) &= ~(uint)0x1;
            }
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.UnmuteRemoteTalker.ReturnValue
        // 0x54 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 84) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 84) |= 0x1;
                else *(uint*)(Pointer + 84) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrUnmuteRemoteTalker;
    public bool UnmuteRemoteTalker(byte LocalUserNum, U_Types_Core.FUniqueNetId PlayerID, bool bIsSystemWide = false) {
        _ptrUnmuteRemoteTalker ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.UnmuteRemoteTalker");

        var @params = stackalloc byte[81];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params + 8, 72, 72);
        System.Buffer.MemoryCopy(&bIsSystemWide, @params + 80, 4, 4);

        ProcessEvent(_ptrUnmuteRemoteTalker, @params);

        return *(bool*)(@params + 84);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.MuteRemoteTalker
    // 0x3750E0
    // (Final | HasOptionalParams | Public)
    public unsafe class MuteRemoteTalker_Parameters : BaseObject {
        public MuteRemoteTalker_Parameters() { }
        public MuteRemoteTalker_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.MuteRemoteTalker.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.MuteRemoteTalker.PlayerID
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.MuteRemoteTalker.bIsSystemWide
        // 0x50 (0x4)
        // Bitmask: 0x00000001
        // (OptionalParam | Param)
        public bool bIsSystemWide {
            get => (*(uint*)(Pointer + 80) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 80) |= 0x1;
                else *(uint*)(Pointer + 80) &= ~(uint)0x1;
            }
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.MuteRemoteTalker.ReturnValue
        // 0x54 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 84) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 84) |= 0x1;
                else *(uint*)(Pointer + 84) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrMuteRemoteTalker;
    public bool MuteRemoteTalker(byte LocalUserNum, U_Types_Core.FUniqueNetId PlayerID, bool bIsSystemWide = false) {
        _ptrMuteRemoteTalker ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.MuteRemoteTalker");

        var @params = stackalloc byte[81];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params + 8, 72, 72);
        System.Buffer.MemoryCopy(&bIsSystemWide, @params + 80, 4, 4);

        ProcessEvent(_ptrMuteRemoteTalker, @params);

        return *(bool*)(@params + 84);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetRemoteTalkerPriority
    // 0x3750E0
    // (Final | Public)
    public unsafe class SetRemoteTalkerPriority_Parameters : BaseObject {
        public SetRemoteTalkerPriority_Parameters() { }
        public SetRemoteTalkerPriority_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetRemoteTalkerPriority.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x7

        // StructProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetRemoteTalkerPriority.PlayerID
        // 0x8 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // IntProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetRemoteTalkerPriority.Priority
        // 0x50 (0x4)
        // (Param)
        public int Priority {
            get => *(int*)(Pointer + 80);
            set => *(int*)(Pointer + 80) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetRemoteTalkerPriority.ReturnValue
        // 0x54 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 84) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 84) |= 0x1;
                else *(uint*)(Pointer + 84) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetRemoteTalkerPriority;
    public bool SetRemoteTalkerPriority(byte LocalUserNum, U_Types_Core.FUniqueNetId PlayerID, int Priority) {
        _ptrSetRemoteTalkerPriority ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetRemoteTalkerPriority");

        var @params = stackalloc byte[81];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params + 8, 72, 72);
        System.Buffer.MemoryCopy(&Priority, @params + 80, 4, 4);

        ProcessEvent(_ptrSetRemoteTalkerPriority, @params);

        return *(bool*)(@params + 84);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.IsHeadsetPresent
    // 0x3750E0
    // (Final | Public)
    public unsafe class IsHeadsetPresent_Parameters : BaseObject {
        public IsHeadsetPresent_Parameters() { }
        public IsHeadsetPresent_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.IsHeadsetPresent.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.IsHeadsetPresent.ReturnValue
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
    private static UFunction _ptrIsHeadsetPresent;
    public bool IsHeadsetPresent(byte LocalUserNum) {
        _ptrIsHeadsetPresent ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.IsHeadsetPresent");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrIsHeadsetPresent, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.IsRemotePlayerTalking
    // 0x3750E0
    // (Final | Public)
    public unsafe class IsRemotePlayerTalking_Parameters : BaseObject {
        public IsRemotePlayerTalking_Parameters() { }
        public IsRemotePlayerTalking_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.IsRemotePlayerTalking.PlayerID
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.IsRemotePlayerTalking.ReturnValue
        // 0x48 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 72) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 72) |= 0x1;
                else *(uint*)(Pointer + 72) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrIsRemotePlayerTalking;
    public bool IsRemotePlayerTalking(U_Types_Core.FUniqueNetId PlayerID) {
        _ptrIsRemotePlayerTalking ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.IsRemotePlayerTalking");

        var @params = stackalloc byte[76];
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params, 72, 72);

        ProcessEvent(_ptrIsRemotePlayerTalking, @params);

        return *(bool*)(@params + 72);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.IsLocalPlayerTalking
    // 0x3750E0
    // (Final | Public)
    public unsafe class IsLocalPlayerTalking_Parameters : BaseObject {
        public IsLocalPlayerTalking_Parameters() { }
        public IsLocalPlayerTalking_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.IsLocalPlayerTalking.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.IsLocalPlayerTalking.ReturnValue
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
    private static UFunction _ptrIsLocalPlayerTalking;
    public bool IsLocalPlayerTalking(byte LocalUserNum) {
        _ptrIsLocalPlayerTalking ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.IsLocalPlayerTalking");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrIsLocalPlayerTalking, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.UnregisterRemoteTalker
    // 0x3750E0
    // (Final | Public)
    public unsafe class UnregisterRemoteTalker_Parameters : BaseObject {
        public UnregisterRemoteTalker_Parameters() { }
        public UnregisterRemoteTalker_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.UnregisterRemoteTalker.PlayerID
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.UnregisterRemoteTalker.ReturnValue
        // 0x48 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 72) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 72) |= 0x1;
                else *(uint*)(Pointer + 72) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrUnregisterRemoteTalker;
    public bool UnregisterRemoteTalker(U_Types_Core.FUniqueNetId PlayerID) {
        _ptrUnregisterRemoteTalker ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.UnregisterRemoteTalker");

        var @params = stackalloc byte[76];
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params, 72, 72);

        ProcessEvent(_ptrUnregisterRemoteTalker, @params);

        return *(bool*)(@params + 72);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.RegisterRemoteTalker
    // 0x3750E0
    // (Final | Public)
    public unsafe class RegisterRemoteTalker_Parameters : BaseObject {
        public RegisterRemoteTalker_Parameters() { }
        public RegisterRemoteTalker_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.RegisterRemoteTalker.PlayerID
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId PlayerID {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.RegisterRemoteTalker.ReturnValue
        // 0x48 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 72) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 72) |= 0x1;
                else *(uint*)(Pointer + 72) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrRegisterRemoteTalker;
    public bool RegisterRemoteTalker(U_Types_Core.FUniqueNetId PlayerID) {
        _ptrRegisterRemoteTalker ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.RegisterRemoteTalker");

        var @params = stackalloc byte[76];
        System.Buffer.MemoryCopy((void*)PlayerID.Pointer, @params, 72, 72);

        ProcessEvent(_ptrRegisterRemoteTalker, @params);

        return *(bool*)(@params + 72);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.UnregisterLocalTalker
    // 0x3750E0
    // (Final | Public)
    public unsafe class UnregisterLocalTalker_Parameters : BaseObject {
        public UnregisterLocalTalker_Parameters() { }
        public UnregisterLocalTalker_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.UnregisterLocalTalker.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.UnregisterLocalTalker.ReturnValue
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
    private static UFunction _ptrUnregisterLocalTalker;
    public bool UnregisterLocalTalker(byte LocalUserNum) {
        _ptrUnregisterLocalTalker ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.UnregisterLocalTalker");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrUnregisterLocalTalker, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.RegisterLocalTalker
    // 0x3750E0
    // (Final | Public)
    public unsafe class RegisterLocalTalker_Parameters : BaseObject {
        public RegisterLocalTalker_Parameters() { }
        public RegisterLocalTalker_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.RegisterLocalTalker.LocalUserNum
        // 0x0 (0x1)
        // (Param)
        public byte LocalUserNum {
            get => *(byte*)Pointer;
            set => *(byte*)Pointer = value;
        }

        // MISSED OFFSET: 0x3

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.RegisterLocalTalker.ReturnValue
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
    private static UFunction _ptrRegisterLocalTalker;
    public bool RegisterLocalTalker(byte LocalUserNum) {
        _ptrRegisterLocalTalker ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.RegisterLocalTalker");

        var @params = stackalloc byte[5];
        System.Buffer.MemoryCopy(&LocalUserNum, @params, 1, 1);

        ProcessEvent(_ptrRegisterLocalTalker, @params);

        return *(bool*)(@params + 4);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.OnRecognitionComplete
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnRecognitionComplete_Parameters : BaseObject {
        public OnRecognitionComplete_Parameters() { }
        public OnRecognitionComplete_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrOnRecognitionComplete;
    public void OnRecognitionComplete() {
        _ptrOnRecognitionComplete ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.OnRecognitionComplete");

        ProcessEvent(_ptrOnRecognitionComplete, null);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.OnPlayerTalkingStateChange
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class OnPlayerTalkingStateChange_Parameters : BaseObject {
        public OnPlayerTalkingStateChange_Parameters() { }
        public OnPlayerTalkingStateChange_Parameters(nint pointer) : base(pointer) { }

        // StructProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.OnPlayerTalkingStateChange.Player
        // 0x0 (0x48)
        // (Param | NeedCtorLink)
        public U_Types_Core.FUniqueNetId Player {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.OnPlayerTalkingStateChange.bIsTalking
        // 0x48 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bIsTalking {
            get => (*(uint*)(Pointer + 72) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 72) |= 0x1;
                else *(uint*)(Pointer + 72) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrOnPlayerTalkingStateChange;
    public void OnPlayerTalkingStateChange(U_Types_Core.FUniqueNetId Player, bool bIsTalking) {
        _ptrOnPlayerTalkingStateChange ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.OnPlayerTalkingStateChange");

        var @params = stackalloc byte[76];
        System.Buffer.MemoryCopy((void*)Player.Pointer, @params, 72, 72);
        System.Buffer.MemoryCopy(&bIsTalking, @params + 72, 4, 4);

        ProcessEvent(_ptrOnPlayerTalkingStateChange, @params);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetPlayerBlockStatus
    // 0xCDFB40
    // (Final | Native | Public | HasOutParams)
    public unsafe class SetPlayerBlockStatus_Parameters : BaseObject {
        public SetPlayerBlockStatus_Parameters() { }
        public SetPlayerBlockStatus_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetPlayerBlockStatus.LocalEpicAccountId
        // 0x0 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString LocalEpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetPlayerBlockStatus.TargetEpicAccountId
        // 0x10 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString TargetEpicAccountId {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetPlayerBlockStatus.RoomName
        // 0x20 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString RoomName {
            get => new(Pointer + 32);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 32), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetPlayerBlockStatus.bBlocked
        // 0x30 (0x4)
        // Bitmask: 0x00000001
        // (Const | Param)
        public bool bBlocked {
            get => (*(uint*)(Pointer + 48) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 48) |= 0x1;
                else *(uint*)(Pointer + 48) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetPlayerBlockStatus;
    public void SetPlayerBlockStatus(ref FString LocalEpicAccountId, ref FString TargetEpicAccountId, ref FString RoomName, bool bBlocked) {
        _ptrSetPlayerBlockStatus ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetPlayerBlockStatus");

        var @params = stackalloc byte[52];
        System.Buffer.MemoryCopy((void*)LocalEpicAccountId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)TargetEpicAccountId.Pointer, @params + 16, 16, 16);
        System.Buffer.MemoryCopy((void*)RoomName.Pointer, @params + 32, 16, 16);
        System.Buffer.MemoryCopy(&bBlocked, @params + 48, 4, 4);

        _ptrSetPlayerBlockStatus.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetPlayerBlockStatus, @params);
        _ptrSetPlayerBlockStatus.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _LocalEpicAccountIdPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_LocalEpicAccountIdPtr, 16, 16);
        LocalEpicAccountId = new(_LocalEpicAccountIdPtr) { Allocated = true };
        var _TargetEpicAccountIdPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 16, (void*)_TargetEpicAccountIdPtr, 16, 16);
        TargetEpicAccountId = new(_TargetEpicAccountIdPtr) { Allocated = true };
        var _RoomNamePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 32, (void*)_RoomNamePtr, 16, 16);
        RoomName = new(_RoomNamePtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetPlayerMuteStatus
    // 0xCDF970
    // (Final | Native | Public | HasOutParams)
    public unsafe class SetPlayerMuteStatus_Parameters : BaseObject {
        public SetPlayerMuteStatus_Parameters() { }
        public SetPlayerMuteStatus_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetPlayerMuteStatus.LocalEpicAccountId
        // 0x0 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString LocalEpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetPlayerMuteStatus.TargetEpicAccountId
        // 0x10 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString TargetEpicAccountId {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetPlayerMuteStatus.RoomName
        // 0x20 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString RoomName {
            get => new(Pointer + 32);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 32), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetPlayerMuteStatus.bMuted
        // 0x30 (0x4)
        // Bitmask: 0x00000001
        // (Const | Param)
        public bool bMuted {
            get => (*(uint*)(Pointer + 48) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 48) |= 0x1;
                else *(uint*)(Pointer + 48) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetPlayerMuteStatus;
    public void SetPlayerMuteStatus(ref FString LocalEpicAccountId, ref FString TargetEpicAccountId, ref FString RoomName, bool bMuted) {
        _ptrSetPlayerMuteStatus ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetPlayerMuteStatus");

        var @params = stackalloc byte[52];
        System.Buffer.MemoryCopy((void*)LocalEpicAccountId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)TargetEpicAccountId.Pointer, @params + 16, 16, 16);
        System.Buffer.MemoryCopy((void*)RoomName.Pointer, @params + 32, 16, 16);
        System.Buffer.MemoryCopy(&bMuted, @params + 48, 4, 4);

        _ptrSetPlayerMuteStatus.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetPlayerMuteStatus, @params);
        _ptrSetPlayerMuteStatus.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _LocalEpicAccountIdPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_LocalEpicAccountIdPtr, 16, 16);
        LocalEpicAccountId = new(_LocalEpicAccountIdPtr) { Allocated = true };
        var _TargetEpicAccountIdPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 16, (void*)_TargetEpicAccountIdPtr, 16, 16);
        TargetEpicAccountId = new(_TargetEpicAccountIdPtr) { Allocated = true };
        var _RoomNamePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 32, (void*)_RoomNamePtr, 16, 16);
        RoomName = new(_RoomNamePtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.GetUserState
    // 0xCDF890
    // (Final | Native | Public | HasOutParams)
    public unsafe class GetUserState_Parameters : BaseObject {
        public GetUserState_Parameters() { }
        public GetUserState_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.GetUserState.EpicAccountId
        // 0x0 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString EpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.GetUserState.ReturnValue
        // 0x10 (0x1)
        // (Param | OutParam | ReturnParam)
        public EPlayerVoiceTransitionState ReturnValue {
            get => *(EPlayerVoiceTransitionState*)(Pointer + 16);
            set => *(EPlayerVoiceTransitionState*)(Pointer + 16) = value;
        }
    }
    private static UFunction _ptrGetUserState;
    public EPlayerVoiceTransitionState GetUserState(ref FString EpicAccountId) {
        _ptrGetUserState ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.GetUserState");

        var @params = stackalloc byte[17];
        System.Buffer.MemoryCopy((void*)EpicAccountId.Pointer, @params, 16, 16);

        _ptrGetUserState.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetUserState, @params);
        _ptrGetUserState.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _EpicAccountIdPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_EpicAccountIdPtr, 16, 16);
        EpicAccountId = new(_EpicAccountIdPtr) { Allocated = true };

        return *(EPlayerVoiceTransitionState*)(@params + 16);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.GetCurrentRoomNameForUser
    // 0xCDF770
    // (Final | Native | Public | HasOutParams)
    public unsafe class GetCurrentRoomNameForUser_Parameters : BaseObject {
        public GetCurrentRoomNameForUser_Parameters() { }
        public GetCurrentRoomNameForUser_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.GetCurrentRoomNameForUser.EpicAccountId
        // 0x0 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString EpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.GetCurrentRoomNameForUser.ReturnValue
        // 0x10 (0x10)
        // (Param | OutParam | ReturnParam | NeedCtorLink)
        public FString ReturnValue {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }
    }
    private static UFunction _ptrGetCurrentRoomNameForUser;
    public FString GetCurrentRoomNameForUser(ref FString EpicAccountId) {
        _ptrGetCurrentRoomNameForUser ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.GetCurrentRoomNameForUser");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)EpicAccountId.Pointer, @params, 16, 16);

        _ptrGetCurrentRoomNameForUser.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetCurrentRoomNameForUser, @params);
        _ptrGetCurrentRoomNameForUser.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _EpicAccountIdPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_EpicAccountIdPtr, 16, 16);
        EpicAccountId = new(_EpicAccountIdPtr) { Allocated = true };

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 16, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.LeaveVoiceRoom
    // 0xCDF630
    // (Final | Native | Public | HasOutParams)
    public unsafe class LeaveVoiceRoom_Parameters : BaseObject {
        public LeaveVoiceRoom_Parameters() { }
        public LeaveVoiceRoom_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.LeaveVoiceRoom.EpicAccountId
        // 0x0 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString EpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.LeaveVoiceRoom.RoomName
        // 0x10 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString RoomName {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.LeaveVoiceRoom.ReturnValue
        // 0x20 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 32) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 32) |= 0x1;
                else *(uint*)(Pointer + 32) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrLeaveVoiceRoom;
    public bool LeaveVoiceRoom(ref FString EpicAccountId, ref FString RoomName) {
        _ptrLeaveVoiceRoom ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.LeaveVoiceRoom");

        var @params = stackalloc byte[36];
        System.Buffer.MemoryCopy((void*)EpicAccountId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)RoomName.Pointer, @params + 16, 16, 16);

        _ptrLeaveVoiceRoom.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrLeaveVoiceRoom, @params);
        _ptrLeaveVoiceRoom.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _EpicAccountIdPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_EpicAccountIdPtr, 16, 16);
        EpicAccountId = new(_EpicAccountIdPtr) { Allocated = true };
        var _RoomNamePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 16, (void*)_RoomNamePtr, 16, 16);
        RoomName = new(_RoomNamePtr) { Allocated = true };

        return *(bool*)(@params + 32);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.JoinVoiceRoom
    // 0xCDF430
    // (Final | Native | Public | HasOutParams)
    public unsafe class JoinVoiceRoom_Parameters : BaseObject {
        public JoinVoiceRoom_Parameters() { }
        public JoinVoiceRoom_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.JoinVoiceRoom.EpicAccountId
        // 0x0 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString EpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.JoinVoiceRoom.RoomName
        // 0x10 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString RoomName {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.JoinVoiceRoom.ClientBaseUrl
        // 0x20 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString ClientBaseUrl {
            get => new(Pointer + 32);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 32), 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.JoinVoiceRoom.JoinToken
        // 0x30 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString JoinToken {
            get => new(Pointer + 48);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 48), 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.JoinVoiceRoom.ReturnValue
        // 0x40 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 64) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 64) |= 0x1;
                else *(uint*)(Pointer + 64) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrJoinVoiceRoom;
    public bool JoinVoiceRoom(ref FString EpicAccountId, ref FString RoomName, ref FString ClientBaseUrl, ref FString JoinToken) {
        _ptrJoinVoiceRoom ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.JoinVoiceRoom");

        var @params = stackalloc byte[68];
        System.Buffer.MemoryCopy((void*)EpicAccountId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)RoomName.Pointer, @params + 16, 16, 16);
        System.Buffer.MemoryCopy((void*)ClientBaseUrl.Pointer, @params + 32, 16, 16);
        System.Buffer.MemoryCopy((void*)JoinToken.Pointer, @params + 48, 16, 16);

        _ptrJoinVoiceRoom.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrJoinVoiceRoom, @params);
        _ptrJoinVoiceRoom.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _EpicAccountIdPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_EpicAccountIdPtr, 16, 16);
        EpicAccountId = new(_EpicAccountIdPtr) { Allocated = true };
        var _RoomNamePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 16, (void*)_RoomNamePtr, 16, 16);
        RoomName = new(_RoomNamePtr) { Allocated = true };
        var _ClientBaseUrlPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 32, (void*)_ClientBaseUrlPtr, 16, 16);
        ClientBaseUrl = new(_ClientBaseUrlPtr) { Allocated = true };
        var _JoinTokenPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 48, (void*)_JoinTokenPtr, 16, 16);
        JoinToken = new(_JoinTokenPtr) { Allocated = true };

        return *(bool*)(@params + 64);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetAudioOutputDevice
    // 0xCDF140
    // (Final | Native | Public | HasOutParams)
    public unsafe class SetAudioOutputDevice_Parameters : BaseObject {
        public SetAudioOutputDevice_Parameters() { }
        public SetAudioOutputDevice_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetAudioOutputDevice.EpicAccountId
        // 0x0 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString EpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetAudioOutputDevice.DeviceID
        // 0x10 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString DeviceID {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // FloatProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetAudioOutputDevice.OutputVolume
        // 0x20 (0x4)
        // (Param)
        public float OutputVolume {
            get => *(float*)(Pointer + 32);
            set => *(float*)(Pointer + 32) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetAudioOutputDevice.ReturnValue
        // 0x24 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 36) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 36) |= 0x1;
                else *(uint*)(Pointer + 36) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetAudioOutputDevice;
    public bool SetAudioOutputDevice(ref FString EpicAccountId, ref FString DeviceID, float OutputVolume) {
        _ptrSetAudioOutputDevice ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetAudioOutputDevice");

        var @params = stackalloc byte[40];
        System.Buffer.MemoryCopy((void*)EpicAccountId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)DeviceID.Pointer, @params + 16, 16, 16);
        System.Buffer.MemoryCopy(&OutputVolume, @params + 32, 4, 4);

        _ptrSetAudioOutputDevice.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetAudioOutputDevice, @params);
        _ptrSetAudioOutputDevice.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _EpicAccountIdPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_EpicAccountIdPtr, 16, 16);
        EpicAccountId = new(_EpicAccountIdPtr) { Allocated = true };
        var _DeviceIDPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 16, (void*)_DeviceIDPtr, 16, 16);
        DeviceID = new(_DeviceIDPtr) { Allocated = true };

        return *(bool*)(@params + 36);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetAudioInputDevice
    // 0xCDEE50
    // (Final | Native | Public | HasOutParams)
    public unsafe class SetAudioInputDevice_Parameters : BaseObject {
        public SetAudioInputDevice_Parameters() { }
        public SetAudioInputDevice_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetAudioInputDevice.EpicAccountId
        // 0x0 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString EpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetAudioInputDevice.DeviceID
        // 0x10 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString DeviceID {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // FloatProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetAudioInputDevice.InputVolume
        // 0x20 (0x4)
        // (Param)
        public float InputVolume {
            get => *(float*)(Pointer + 32);
            set => *(float*)(Pointer + 32) = value;
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetAudioInputDevice.ReturnValue
        // 0x24 (0x4)
        // Bitmask: 0x00000001
        // (Param | OutParam | ReturnParam)
        public bool ReturnValue {
            get => (*(uint*)(Pointer + 36) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 36) |= 0x1;
                else *(uint*)(Pointer + 36) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetAudioInputDevice;
    public bool SetAudioInputDevice(ref FString EpicAccountId, ref FString DeviceID, float InputVolume) {
        _ptrSetAudioInputDevice ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetAudioInputDevice");

        var @params = stackalloc byte[40];
        System.Buffer.MemoryCopy((void*)EpicAccountId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)DeviceID.Pointer, @params + 16, 16, 16);
        System.Buffer.MemoryCopy(&InputVolume, @params + 32, 4, 4);

        _ptrSetAudioInputDevice.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetAudioInputDevice, @params);
        _ptrSetAudioInputDevice.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _EpicAccountIdPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_EpicAccountIdPtr, 16, 16);
        EpicAccountId = new(_EpicAccountIdPtr) { Allocated = true };
        var _DeviceIDPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 16, (void*)_DeviceIDPtr, 16, 16);
        DeviceID = new(_DeviceIDPtr) { Allocated = true };

        return *(bool*)(@params + 36);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetLocalPlayerRegisteredStatus
    // 0xCDECC0
    // (Final | Native | Public | HasOutParams)
    public unsafe class SetLocalPlayerRegisteredStatus_Parameters : BaseObject {
        public SetLocalPlayerRegisteredStatus_Parameters() { }
        public SetLocalPlayerRegisteredStatus_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetLocalPlayerRegisteredStatus.PlatformId
        // 0x0 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString PlatformId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // BoolProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetLocalPlayerRegisteredStatus.bRegister
        // 0x10 (0x4)
        // Bitmask: 0x00000001
        // (Const | Param)
        public bool bRegister {
            get => (*(uint*)(Pointer + 16) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 16) |= 0x1;
                else *(uint*)(Pointer + 16) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetLocalPlayerRegisteredStatus;
    public void SetLocalPlayerRegisteredStatus(ref FString PlatformId, bool bRegister) {
        _ptrSetLocalPlayerRegisteredStatus ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.SetLocalPlayerRegisteredStatus");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)PlatformId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy(&bRegister, @params + 16, 4, 4);

        _ptrSetLocalPlayerRegisteredStatus.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetLocalPlayerRegisteredStatus, @params);
        _ptrSetLocalPlayerRegisteredStatus.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _PlatformIdPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_PlatformIdPtr, 16, 16);
        PlatformId = new(_PlatformIdPtr) { Allocated = true };
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.CacheOutputAudioDevices
    // 0xCDEC80
    // (Final | Native | Private)
    public unsafe class CacheOutputAudioDevices_Parameters : BaseObject {
        public CacheOutputAudioDevices_Parameters() { }
        public CacheOutputAudioDevices_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrCacheOutputAudioDevices;
    public void CacheOutputAudioDevices() {
        _ptrCacheOutputAudioDevices ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.CacheOutputAudioDevices");

        _ptrCacheOutputAudioDevices.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrCacheOutputAudioDevices, null);
        _ptrCacheOutputAudioDevices.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.CacheInputAudioDevices
    // 0xCDEC40
    // (Final | Native | Private)
    public unsafe class CacheInputAudioDevices_Parameters : BaseObject {
        public CacheInputAudioDevices_Parameters() { }
        public CacheInputAudioDevices_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrCacheInputAudioDevices;
    public void CacheInputAudioDevices() {
        _ptrCacheInputAudioDevices ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.CacheInputAudioDevices");

        _ptrCacheInputAudioDevices.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrCacheInputAudioDevices, null);
        _ptrCacheInputAudioDevices.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.Init
    // 0xCDEBC0
    // (Final | Native | Public)
    public unsafe class Init_Parameters : BaseObject {
        public Init_Parameters() { }
        public Init_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrInit;
    public void Init() {
        _ptrInit ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.Init");

        _ptrInit.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrInit, null);
        _ptrInit.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventPlayerStatusChanged
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventPlayerStatusChanged_Parameters : BaseObject {
        public EventPlayerStatusChanged_Parameters() { }
        public EventPlayerStatusChanged_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventPlayerStatusChanged.EpicAccountId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString EpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventPlayerStatusChanged.RoomName
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString RoomName {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // StructProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventPlayerStatusChanged.MemberStatus
        // 0x20 (0x4)
        // (Param)
        public U_Types_Core.FVoiceRoomMemberStatus MemberStatus {
            get => new(Pointer + 32);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 32), 4, 4);
        }
    }
    private static UFunction _ptrEventPlayerStatusChanged;
    public void EventPlayerStatusChanged(FString EpicAccountId, FString RoomName, U_Types_Core.FVoiceRoomMemberStatus MemberStatus) {
        _ptrEventPlayerStatusChanged ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventPlayerStatusChanged");

        var @params = stackalloc byte[36];
        System.Buffer.MemoryCopy((void*)EpicAccountId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)RoomName.Pointer, @params + 16, 16, 16);
        System.Buffer.MemoryCopy((void*)MemberStatus.Pointer, @params + 32, 4, 4);

        ProcessEvent(_ptrEventPlayerStatusChanged, @params);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventPlayerLeftVoiceRoom
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventPlayerLeftVoiceRoom_Parameters : BaseObject {
        public EventPlayerLeftVoiceRoom_Parameters() { }
        public EventPlayerLeftVoiceRoom_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventPlayerLeftVoiceRoom.EpicAccountId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString EpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventPlayerLeftVoiceRoom.RoomName
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString RoomName {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }
    }
    private static UFunction _ptrEventPlayerLeftVoiceRoom;
    public void EventPlayerLeftVoiceRoom(FString EpicAccountId, FString RoomName) {
        _ptrEventPlayerLeftVoiceRoom ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventPlayerLeftVoiceRoom");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)EpicAccountId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)RoomName.Pointer, @params + 16, 16, 16);

        ProcessEvent(_ptrEventPlayerLeftVoiceRoom, @params);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventPlayerJoinedVoiceRoom
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventPlayerJoinedVoiceRoom_Parameters : BaseObject {
        public EventPlayerJoinedVoiceRoom_Parameters() { }
        public EventPlayerJoinedVoiceRoom_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventPlayerJoinedVoiceRoom.EpicAccountId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString EpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventPlayerJoinedVoiceRoom.RoomName
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString RoomName {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }
    }
    private static UFunction _ptrEventPlayerJoinedVoiceRoom;
    public void EventPlayerJoinedVoiceRoom(FString EpicAccountId, FString RoomName) {
        _ptrEventPlayerJoinedVoiceRoom ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventPlayerJoinedVoiceRoom");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)EpicAccountId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)RoomName.Pointer, @params + 16, 16, 16);

        ProcessEvent(_ptrEventPlayerJoinedVoiceRoom, @params);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventRemovedFromVoiceRoom
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventRemovedFromVoiceRoom_Parameters : BaseObject {
        public EventRemovedFromVoiceRoom_Parameters() { }
        public EventRemovedFromVoiceRoom_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventRemovedFromVoiceRoom.EpicAccountId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString EpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventRemovedFromVoiceRoom.RoomName
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString RoomName {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventRemovedFromVoiceRoom.RemovedResult
        // 0x20 (0x1)
        // (Param)
        public U_Types_Core.EVoiceResultCode RemovedResult {
            get => *(U_Types_Core.EVoiceResultCode*)(Pointer + 32);
            set => *(U_Types_Core.EVoiceResultCode*)(Pointer + 32) = value;
        }
    }
    private static UFunction _ptrEventRemovedFromVoiceRoom;
    public void EventRemovedFromVoiceRoom(FString EpicAccountId, FString RoomName, U_Types_Core.EVoiceResultCode RemovedResult) {
        _ptrEventRemovedFromVoiceRoom ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventRemovedFromVoiceRoom");

        var @params = stackalloc byte[33];
        System.Buffer.MemoryCopy((void*)EpicAccountId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)RoomName.Pointer, @params + 16, 16, 16);
        System.Buffer.MemoryCopy(&RemovedResult, @params + 32, 1, 1);

        ProcessEvent(_ptrEventRemovedFromVoiceRoom, @params);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventJoinedVoiceRoom
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventJoinedVoiceRoom_Parameters : BaseObject {
        public EventJoinedVoiceRoom_Parameters() { }
        public EventJoinedVoiceRoom_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventJoinedVoiceRoom.EpicAccountId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString EpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventJoinedVoiceRoom.RoomName
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString RoomName {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventJoinedVoiceRoom.JoinResult
        // 0x20 (0x1)
        // (Param)
        public U_Types_Core.EVoiceResultCode JoinResult {
            get => *(U_Types_Core.EVoiceResultCode*)(Pointer + 32);
            set => *(U_Types_Core.EVoiceResultCode*)(Pointer + 32) = value;
        }
    }
    private static UFunction _ptrEventJoinedVoiceRoom;
    public void EventJoinedVoiceRoom(FString EpicAccountId, FString RoomName, U_Types_Core.EVoiceResultCode JoinResult) {
        _ptrEventJoinedVoiceRoom ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventJoinedVoiceRoom");

        var @params = stackalloc byte[33];
        System.Buffer.MemoryCopy((void*)EpicAccountId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)RoomName.Pointer, @params + 16, 16, 16);
        System.Buffer.MemoryCopy(&JoinResult, @params + 32, 1, 1);

        ProcessEvent(_ptrEventJoinedVoiceRoom, @params);
    }

    // Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventLeftVoiceRoom
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventLeftVoiceRoom_Parameters : BaseObject {
        public EventLeftVoiceRoom_Parameters() { }
        public EventLeftVoiceRoom_Parameters(nint pointer) : base(pointer) { }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventLeftVoiceRoom.EpicAccountId
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString EpicAccountId {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventLeftVoiceRoom.RoomName
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString RoomName {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // ByteProperty OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventLeftVoiceRoom.LeaveResult
        // 0x20 (0x1)
        // (Param)
        public U_Types_Core.EVoiceResultCode LeaveResult {
            get => *(U_Types_Core.EVoiceResultCode*)(Pointer + 32);
            set => *(U_Types_Core.EVoiceResultCode*)(Pointer + 32) = value;
        }
    }
    private static UFunction _ptrEventLeftVoiceRoom;
    public void EventLeftVoiceRoom(FString EpicAccountId, FString RoomName, U_Types_Core.EVoiceResultCode LeaveResult) {
        _ptrEventLeftVoiceRoom ??= FindFunction("Function OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EventLeftVoiceRoom");

        var @params = stackalloc byte[33];
        System.Buffer.MemoryCopy((void*)EpicAccountId.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)RoomName.Pointer, @params + 16, 16, 16);
        System.Buffer.MemoryCopy(&LeaveResult, @params + 32, 1, 1);

        ProcessEvent(_ptrEventLeftVoiceRoom, @params);
    }


    // Enum OnlineSubsystemEOS.OnlineVoiceInterfaceEOS.EPlayerVoiceTransitionState
    public enum EPlayerVoiceTransitionState : byte {
        PVTS_Idle = 0,
        PVTS_Joining = 1,
        PVTS_Leaving = 2,
        PVTS_MAX = 3
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class OnlineSubsystemEOS.OnlineVoiceInterfaceEOS");
            return _staticClass;
        }
    }
}

// Class OnlineSubsystemEOS.VideoRecorderEOS
// 0x8 (0x60 - 0x68)
// (Compiled | Parsed | Native)
public unsafe partial class UVideoRecorderEOS : UObject {
    public UVideoRecorderEOS() { }
    public UVideoRecorderEOS(nint pointer) : base(pointer) { }


    // StructProperty OnlineSubsystemEOS.VideoRecorderEOS.VfTable_FTickableObject
    // 0x60 (0x8)
    // (Const | Native | NoExport)
    public nint VfTable_FTickableObject {
        get => *(nint*)(Pointer + 96);
        set => *(nint*)(Pointer + 96) = value;
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class OnlineSubsystemEOS.VideoRecorderEOS");
            return _staticClass;
        }
    }
}

// Class OnlineSubsystemEOS.__OnlinePlayerInterfaceEOS__LinkedAccount_0x1
// 0x4 (0x60 - 0x64)
// (Compiled | Parsed | Deprecated | Exported)
public unsafe partial class U__OnlinePlayerInterfaceEOS__LinkedAccount_0x1 : UObject {
    public U__OnlinePlayerInterfaceEOS__LinkedAccount_0x1() { }
    public U__OnlinePlayerInterfaceEOS__LinkedAccount_0x1(nint pointer) : base(pointer) { }


    // IntProperty OnlineSubsystemEOS.__OnlinePlayerInterfaceEOS__LinkedAccount_0x1.LocalUserNum
    // 0x60 (0x4)
    public int LocalUserNum {
        get => *(int*)(Pointer + 96);
        set => *(int*)(Pointer + 96) = value;
    }


    // Function OnlineSubsystemEOS.__OnlinePlayerInterfaceEOS__LinkedAccount_0x1.__OnlinePlayerInterfaceEOS__LinkedAccount_0x1
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class __OnlinePlayerInterfaceEOS__LinkedAccount_0x1_Parameters : BaseObject {
        public __OnlinePlayerInterfaceEOS__LinkedAccount_0x1_Parameters() { }
        public __OnlinePlayerInterfaceEOS__LinkedAccount_0x1_Parameters(nint pointer) : base(pointer) { }

        // IntProperty OnlineSubsystemEOS.__OnlinePlayerInterfaceEOS__LinkedAccount_0x1.__OnlinePlayerInterfaceEOS__LinkedAccount_0x1._
        // 0x0 (0x4)
        // (Param)
        public int _ {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty OnlineSubsystemEOS.__OnlinePlayerInterfaceEOS__LinkedAccount_0x1.__OnlinePlayerInterfaceEOS__LinkedAccount_0x1.PlatformAuthTicket
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString PlatformAuthTicket {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptr__OnlinePlayerInterfaceEOS__LinkedAccount_0x1;
    public void __OnlinePlayerInterfaceEOS__LinkedAccount_0x1(int _, FString PlatformAuthTicket) {
        _ptr__OnlinePlayerInterfaceEOS__LinkedAccount_0x1 ??= FindFunction("Function OnlineSubsystemEOS.__OnlinePlayerInterfaceEOS__LinkedAccount_0x1.__OnlinePlayerInterfaceEOS__LinkedAccount_0x1");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy(&_, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)PlatformAuthTicket.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptr__OnlinePlayerInterfaceEOS__LinkedAccount_0x1, @params);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class OnlineSubsystemEOS.__OnlinePlayerInterfaceEOS__LinkedAccount_0x1");
            return _staticClass;
        }
    }
}

// Class OnlineSubsystemEOS.__OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1
// 0x20 (0x60 - 0x80)
// (Compiled | Parsed | Deprecated | Exported)
public unsafe partial class U__OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1 : UObject {
    public U__OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1() { }
    public U__OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1(nint pointer) : base(pointer) { }


    // IntProperty OnlineSubsystemEOS.__OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1.LocalUserNum
    // 0x60 (0x4)
    public int LocalUserNum {
        get => *(int*)(Pointer + 96);
        set => *(int*)(Pointer + 96) = value;
    }

    // MISSED OFFSET: 0x4

    // DelegateProperty OnlineSubsystemEOS.__OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1.Callback
    // 0x68 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate Callback {
        get => new(Pointer + 104);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 104), 24, 24);
    }


    // Function OnlineSubsystemEOS.__OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1.__OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class __OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1_Parameters : BaseObject {
        public __OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1_Parameters() { }
        public __OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty OnlineSubsystemEOS.__OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1.__OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1.bSuccess
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bSuccess {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }

        // MISSED OFFSET: 0x4

        // StrProperty OnlineSubsystemEOS.__OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1.__OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1.Code
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString Code {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptr__OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1;
    public void __OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1(bool bSuccess, FString Code) {
        _ptr__OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1 ??= FindFunction("Function OnlineSubsystemEOS.__OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1.__OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy(&bSuccess, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)Code.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptr__OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1, @params);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class OnlineSubsystemEOS.__OnlinePlayerInterfaceEOS__RequestNativePlatformAuthTicket_0x1");
            return _staticClass;
        }
    }
}

#pragma warning restore CS0108, CS0114
