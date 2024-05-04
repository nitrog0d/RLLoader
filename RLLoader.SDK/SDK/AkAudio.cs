using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace RLLoader.SDK;

#pragma warning disable CS0108, CS0114

// Class AkAudio.ActorFactoryAkAmbientSound
// 0xC (0x9C - 0xA8)
// (Compiled | Config | Parsed | Native | EditInlineNew | CollapseCategories)
public unsafe partial class UActorFactoryAkAmbientSound : UActorFactory {
    public UActorFactoryAkAmbientSound() { }
    public UActorFactoryAkAmbientSound(nint pointer) : base(pointer) { }


    // MISSED OFFSET: 0x4

    // ObjectProperty AkAudio.ActorFactoryAkAmbientSound.AmbientEvent
    // 0xA0 (0x8)
    // (Edit)
    public UAkEvent AmbientEvent {
        get {
            var pointer = *(nint*)(Pointer + 160);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 160) = value.Pointer;
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.ActorFactoryAkAmbientSound");
            return _staticClass;
        }
    }
}

// Class AkAudio.AkAmbientSound
// 0x10 (0x270 - 0x280)
// (Compiled | Parsed | Native | Hidden | HideDropDown)
public unsafe partial class AAkAmbientSound : AKeypoint {
    public AAkAmbientSound() { }
    public AAkAmbientSound(nint pointer) : base(pointer) { }


    // BoolProperty AkAudio.AkAmbientSound.bAutoPlay
    // 0x270 (0x4)
    // Bitmask: 0x00000001
    public bool bAutoPlay {
        get => (*(uint*)(Pointer + 624) & 0x1) != 0;
        set {
            if (value) *(uint*)(Pointer + 624) |= 0x1;
            else *(uint*)(Pointer + 624) &= ~(uint)0x1;
        }
    }

    // BoolProperty AkAudio.AkAmbientSound.StopWhenOwnerIsDestroyed
    // 0x270 (0x4)
    // Bitmask: 0x00000002
    // (Edit)
    public bool StopWhenOwnerIsDestroyed {
        get => (*(uint*)(Pointer + 624) & 0x2) != 0;
        set {
            if (value) *(uint*)(Pointer + 624) |= 0x2;
            else *(uint*)(Pointer + 624) &= ~(uint)0x2;
        }
    }

    // BoolProperty AkAudio.AkAmbientSound.bIsPlaying
    // 0x270 (0x4)
    // Bitmask: 0x00000004
    // (Transient)
    public bool bIsPlaying {
        get => (*(uint*)(Pointer + 624) & 0x4) != 0;
        set {
            if (value) *(uint*)(Pointer + 624) |= 0x4;
            else *(uint*)(Pointer + 624) &= ~(uint)0x4;
        }
    }

    // MISSED OFFSET: 0x4

    // ObjectProperty AkAudio.AkAmbientSound.PlayEvent
    // 0x278 (0x8)
    // (Edit)
    public UAkEvent PlayEvent {
        get {
            var pointer = *(nint*)(Pointer + 632);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 632) = value.Pointer;
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.AkAmbientSound");
            return _staticClass;
        }
    }
}

// Class AkAudio.AkBusActor
// 0x11 (0x268 - 0x279)
// (Compiled | Parsed | Native | Hidden)
public unsafe partial class AAkBusActor : AActor {
    public AAkBusActor() { }
    public AAkBusActor(nint pointer) : base(pointer) { }


    // ComponentProperty AkAudio.AkBusActor.SoundSource
    // 0x268 (0x8)
    // (ExportObject | Component | EditInline)
    public UAkSoundSource SoundSource {
        get {
            var pointer = *(nint*)(Pointer + 616);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 616) = value.Pointer;
    }

    // NameProperty AkAudio.AkBusActor.TargetBusName
    // 0x270 (0x8)
    public FName TargetBusName {
        get => new(Pointer + 624);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 624), 8, 8);
    }

    // ByteProperty AkAudio.AkBusActor.PinnedAxis
    // 0x278 (0x1)
    public EPinnedAxisType PinnedAxis {
        get => *(EPinnedAxisType*)(Pointer + 632);
        set => *(EPinnedAxisType*)(Pointer + 632) = value;
    }


    // Function AkAudio.AkBusActor.RegisterReflectionEmitter
    // 0xD0C8E0
    // (Final | Native | Public | K2Call)
    public unsafe class RegisterReflectionEmitter_Parameters : BaseObject {
        public RegisterReflectionEmitter_Parameters() { }
        public RegisterReflectionEmitter_Parameters(nint pointer) : base(pointer) { }

        // NameProperty AkAudio.AkBusActor.RegisterReflectionEmitter.BusName
        // 0x0 (0x8)
        // (Param)
        public FName BusName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // ByteProperty AkAudio.AkBusActor.RegisterReflectionEmitter.BusType
        // 0x8 (0x1)
        // (Param)
        public EBusEmitterType BusType {
            get => *(EBusEmitterType*)(Pointer + 8);
            set => *(EBusEmitterType*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrRegisterReflectionEmitter;
    public void RegisterReflectionEmitter(FName BusName, EBusEmitterType BusType) {
        _ptrRegisterReflectionEmitter ??= FindFunction("Function AkAudio.AkBusActor.RegisterReflectionEmitter");

        var @params = stackalloc byte[9];
        System.Buffer.MemoryCopy((void*)BusName.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&BusType, @params + 8, 1, 1);

        _ptrRegisterReflectionEmitter.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrRegisterReflectionEmitter, @params);
        _ptrRegisterReflectionEmitter.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkBusActor.SetPinnedAxis
    // 0xD0C860
    // (Final | Native | Public | K2Call)
    public unsafe class SetPinnedAxis_Parameters : BaseObject {
        public SetPinnedAxis_Parameters() { }
        public SetPinnedAxis_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty AkAudio.AkBusActor.SetPinnedAxis.AxisToPin
        // 0x0 (0x1)
        // (Param)
        public EPinnedAxisType AxisToPin {
            get => *(EPinnedAxisType*)Pointer;
            set => *(EPinnedAxisType*)Pointer = value;
        }
    }
    private static UFunction _ptrSetPinnedAxis;
    public void SetPinnedAxis(EPinnedAxisType AxisToPin) {
        _ptrSetPinnedAxis ??= FindFunction("Function AkAudio.AkBusActor.SetPinnedAxis");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&AxisToPin, @params, 1, 1);

        _ptrSetPinnedAxis.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetPinnedAxis, @params);
        _ptrSetPinnedAxis.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }


    // Enum AkAudio.AkBusActor.EBusEmitterType
    public enum EBusEmitterType : byte {
        BusEmitterType_Reflection = 0,
        BusEmitterType_Reverb = 1,
        BusEmitterType_None = 2,
        BusEmitterType_MAX = 3
    }

    // Enum AkAudio.AkBusActor.EPinnedAxisType
    public enum EPinnedAxisType : byte {
        PinnedAxis_X = 0,
        PinnedAxis_Y = 1,
        PinnedAxis_Z = 2,
        PinnedAxis_None = 3,
        PinnedAxis_MAX = 4
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.AkBusActor");
            return _staticClass;
        }
    }
}

// Class AkAudio.AkComponent
// 0x17 (0x9D - 0xB4)
// (Compiled | Parsed | Native | EditInlineNew | CollapseCategories)
public unsafe partial class UAkComponent : UActorComponent {
    public UAkComponent() { }
    public UAkComponent(nint pointer) : base(pointer) { }


    // MISSED OFFSET: 0x3

    // NameProperty AkAudio.AkComponent.BoneName
    // 0xA0 (0x8)
    // (Edit)
    public FName BoneName {
        get => new(Pointer + 160);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 160), 8, 8);
    }

    // ObjectProperty AkAudio.AkComponent.AutoPlayEvent
    // 0xA8 (0x8)
    public UAkEvent AutoPlayEvent {
        get {
            var pointer = *(nint*)(Pointer + 168);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 168) = value.Pointer;
    }

    // BoolProperty AkAudio.AkComponent.bStopWhenOwnerDestroyed
    // 0xB0 (0x4)
    // Bitmask: 0x00000001
    public bool bStopWhenOwnerDestroyed {
        get => (*(uint*)(Pointer + 176) & 0x1) != 0;
        set {
            if (value) *(uint*)(Pointer + 176) |= 0x1;
            else *(uint*)(Pointer + 176) &= ~(uint)0x1;
        }
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.AkComponent");
            return _staticClass;
        }
    }
}

// Class AkAudio.AkDevice
// 0x58 (0x60 - 0xB8)
// (Abstract | Compiled | Parsed | Native)
public unsafe partial class UAkDevice : UObject {
    public UAkDevice() { }
    public UAkDevice(nint pointer) : base(pointer) { }


    // NameProperty AkAudio.AkDevice.DynamicRangeSetting_Low_Master
    // 0x60 (0x8)
    public FName DynamicRangeSetting_Low_Master {
        get => new(Pointer + 96);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 96), 8, 8);
    }

    // NameProperty AkAudio.AkDevice.DynamicRangeSetting_Medium_Master
    // 0x68 (0x8)
    public FName DynamicRangeSetting_Medium_Master {
        get => new(Pointer + 104);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 104), 8, 8);
    }

    // NameProperty AkAudio.AkDevice.DynamicRangeSetting_High_Master
    // 0x70 (0x8)
    public FName DynamicRangeSetting_High_Master {
        get => new(Pointer + 112);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 112), 8, 8);
    }

    // NameProperty AkAudio.AkDevice.DynamicRangeSetting_Low_Gameplay
    // 0x78 (0x8)
    public FName DynamicRangeSetting_Low_Gameplay {
        get => new(Pointer + 120);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 120), 8, 8);
    }

    // NameProperty AkAudio.AkDevice.DynamicRangeSetting_Medium_Gameplay
    // 0x80 (0x8)
    public FName DynamicRangeSetting_Medium_Gameplay {
        get => new(Pointer + 128);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 128), 8, 8);
    }

    // NameProperty AkAudio.AkDevice.DynamicRangeSetting_High_Gameplay
    // 0x88 (0x8)
    public FName DynamicRangeSetting_High_Gameplay {
        get => new(Pointer + 136);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 136), 8, 8);
    }

    // NameProperty AkAudio.AkDevice.MasterAudioBusName
    // 0x90 (0x8)
    public FName MasterAudioBusName {
        get => new(Pointer + 144);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 144), 8, 8);
    }

    // NameProperty AkAudio.AkDevice.GameplayAudioBusName
    // 0x98 (0x8)
    public FName GameplayAudioBusName {
        get => new(Pointer + 152);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 152), 8, 8);
    }

    // DelegateProperty AkAudio.AkDevice.__EventInitialized__Delegate
    // 0xA0 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventInitialized__Delegate {
        get => new(Pointer + 160);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 160), 24, 24);
    }


    // Function AkAudio.AkDevice.SetBusEffect
    // 0xD0F130
    // (Final | Native | Static | HasOptionalParams | Public | K2Call)
    public unsafe class SetBusEffect_Parameters : BaseObject {
        public SetBusEffect_Parameters() { }
        public SetBusEffect_Parameters(nint pointer) : base(pointer) { }

        // NameProperty AkAudio.AkDevice.SetBusEffect.BusName
        // 0x0 (0x8)
        // (Param)
        public FName BusName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // NameProperty AkAudio.AkDevice.SetBusEffect.EffectSetting
        // 0x8 (0x8)
        // (Param)
        public FName EffectSetting {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 8, 8);
        }

        // IntProperty AkAudio.AkDevice.SetBusEffect.EffectSlot
        // 0x10 (0x4)
        // (OptionalParam | Param)
        public int EffectSlot {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }
    }
    private static UFunction _ptrSetBusEffect;
    public static void SetBusEffect(FName BusName, FName EffectSetting, int EffectSlot = 0) {
        _ptrSetBusEffect ??= FindFunction("Function AkAudio.AkDevice.SetBusEffect");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)BusName.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)EffectSetting.Pointer, @params + 8, 8, 8);
        System.Buffer.MemoryCopy(&EffectSlot, @params + 16, 4, 4);

        _ptrSetBusEffect.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrSetBusEffect, @params);
        _ptrSetBusEffect.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.ResetSlapbackObjects
    // 0xD0F050
    // (Final | Native | Static | Public | K2Call)
    public unsafe class ResetSlapbackObjects_Parameters : BaseObject {
        public ResetSlapbackObjects_Parameters() { }
        public ResetSlapbackObjects_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrResetSlapbackObjects;
    public static void ResetSlapbackObjects() {
        _ptrResetSlapbackObjects ??= FindFunction("Function AkAudio.AkDevice.ResetSlapbackObjects");

        _ptrResetSlapbackObjects.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrResetSlapbackObjects, null);
        _ptrResetSlapbackObjects.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.SetSoundEnvironment
    // 0xD0EEB0
    // (Final | Native | Static | Public | K2Call)
    public unsafe class SetSoundEnvironment_Parameters : BaseObject {
        public SetSoundEnvironment_Parameters() { }
        public SetSoundEnvironment_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkDevice.SetSoundEnvironment.Actor
        // 0x0 (0x8)
        // (Param)
        public AActor Actor {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // ByteProperty AkAudio.AkDevice.SetSoundEnvironment.EnvironmentType
        // 0x8 (0x1)
        // (Param)
        public UAkSoundSource.EAkEnvironmentType EnvironmentType {
            get => *(UAkSoundSource.EAkEnvironmentType*)(Pointer + 8);
            set => *(UAkSoundSource.EAkEnvironmentType*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrSetSoundEnvironment;
    public static void SetSoundEnvironment(AActor Actor, UAkSoundSource.EAkEnvironmentType EnvironmentType) {
        _ptrSetSoundEnvironment ??= FindFunction("Function AkAudio.AkDevice.SetSoundEnvironment");

        var @params = stackalloc byte[9];
        System.Buffer.MemoryCopy((void*)Actor.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&EnvironmentType, @params + 8, 1, 1);

        _ptrSetSoundEnvironment.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrSetSoundEnvironment, @params);
        _ptrSetSoundEnvironment.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.GetEnvironments
    // 0xD0EE40
    // (Final | Native | Static | Public | K2Call)
    public unsafe class GetEnvironments_Parameters : BaseObject {
        public GetEnvironments_Parameters() { }
        public GetEnvironments_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkDevice.GetEnvironments.ReturnValue
        // 0x0 (0x8)
        // (Param | OutParam | ReturnParam)
        public UAkEnvironments ReturnValue {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrGetEnvironments;
    public static UAkEnvironments GetEnvironments() {
        _ptrGetEnvironments ??= FindFunction("Function AkAudio.AkDevice.GetEnvironments");

        var @params = stackalloc byte[8];

        _ptrGetEnvironments.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrGetEnvironments, @params);
        _ptrGetEnvironments.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)@params);
    }

    // Function AkAudio.AkDevice.NotifyWhenInitialized
    // 0xD0ED00
    // (Final | Native | Static | Public | K2Call)
    public unsafe class NotifyWhenInitialized_Parameters : BaseObject {
        public NotifyWhenInitialized_Parameters() { }
        public NotifyWhenInitialized_Parameters(nint pointer) : base(pointer) { }

        // DelegateProperty AkAudio.AkDevice.NotifyWhenInitialized.Callback
        // 0x0 (0x18)
        // (Param | NeedCtorLink)
        public FScriptDelegate Callback {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 24, 24);
        }
    }
    private static UFunction _ptrNotifyWhenInitialized;
    public static void NotifyWhenInitialized(FScriptDelegate Callback) {
        _ptrNotifyWhenInitialized ??= FindFunction("Function AkAudio.AkDevice.NotifyWhenInitialized");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)Callback.Pointer, @params, 24, 24);

        _ptrNotifyWhenInitialized.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrNotifyWhenInitialized, @params);
        _ptrNotifyWhenInitialized.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.ProfileStop
    // 0xD0EC70
    // (Final | Native | Static | Public | K2Call)
    public unsafe class ProfileStop_Parameters : BaseObject {
        public ProfileStop_Parameters() { }
        public ProfileStop_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrProfileStop;
    public static void ProfileStop() {
        _ptrProfileStop ??= FindFunction("Function AkAudio.AkDevice.ProfileStop");

        _ptrProfileStop.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrProfileStop, null);
        _ptrProfileStop.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.ProfileStart
    // 0xD0EC10
    // (Final | Native | Static | Public | K2Call)
    public unsafe class ProfileStart_Parameters : BaseObject {
        public ProfileStart_Parameters() { }
        public ProfileStart_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrProfileStart;
    public static void ProfileStart() {
        _ptrProfileStart ??= FindFunction("Function AkAudio.AkDevice.ProfileStart");

        _ptrProfileStart.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrProfileStart, null);
        _ptrProfileStart.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.PrintData
    // 0xD0EBA0
    // (Final | Native | Static | Public | K2Call)
    public unsafe class PrintData_Parameters : BaseObject {
        public PrintData_Parameters() { }
        public PrintData_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrPrintData;
    public static void PrintData() {
        _ptrPrintData ??= FindFunction("Function AkAudio.AkDevice.PrintData");

        _ptrPrintData.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrPrintData, null);
        _ptrPrintData.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.SetDynamicRange
    // 0xD0EA10
    // (Final | Native | Static | Public | K2Call)
    public unsafe class SetDynamicRange_Parameters : BaseObject {
        public SetDynamicRange_Parameters() { }
        public SetDynamicRange_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty AkAudio.AkDevice.SetDynamicRange.Type
        // 0x0 (0x1)
        // (Param)
        public EAkDynamicRangeType Type {
            get => *(EAkDynamicRangeType*)Pointer;
            set => *(EAkDynamicRangeType*)Pointer = value;
        }
    }
    private static UFunction _ptrSetDynamicRange;
    public static void SetDynamicRange(EAkDynamicRangeType Type) {
        _ptrSetDynamicRange ??= FindFunction("Function AkAudio.AkDevice.SetDynamicRange");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&Type, @params, 1, 1);

        _ptrSetDynamicRange.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrSetDynamicRange, @params);
        _ptrSetDynamicRange.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.SetOutputType
    // 0xD0E920
    // (Final | Native | Static | Public | K2Call)
    public unsafe class SetOutputType_Parameters : BaseObject {
        public SetOutputType_Parameters() { }
        public SetOutputType_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty AkAudio.AkDevice.SetOutputType.Type
        // 0x0 (0x1)
        // (Param)
        public EAkOutputType Type {
            get => *(EAkOutputType*)Pointer;
            set => *(EAkOutputType*)Pointer = value;
        }
    }
    private static UFunction _ptrSetOutputType;
    public static void SetOutputType(EAkOutputType Type) {
        _ptrSetOutputType ??= FindFunction("Function AkAudio.AkDevice.SetOutputType");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&Type, @params, 1, 1);

        _ptrSetOutputType.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrSetOutputType, @params);
        _ptrSetOutputType.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.SetListenerSpatialization
    // 0xD0E850
    // (Final | Native | Static | Public | K2Call)
    public unsafe class SetListenerSpatialization_Parameters : BaseObject {
        public SetListenerSpatialization_Parameters() { }
        public SetListenerSpatialization_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkDevice.SetListenerSpatialization.Player
        // 0x0 (0x8)
        // (Param)
        public ULocalPlayer Player {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // ByteProperty AkAudio.AkDevice.SetListenerSpatialization.Value
        // 0x8 (0x1)
        // (Param)
        public EAkListenerSpacialization Value {
            get => *(EAkListenerSpacialization*)(Pointer + 8);
            set => *(EAkListenerSpacialization*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrSetListenerSpatialization;
    public static void SetListenerSpatialization(ULocalPlayer Player, EAkListenerSpacialization Value) {
        _ptrSetListenerSpatialization ??= FindFunction("Function AkAudio.AkDevice.SetListenerSpatialization");

        var @params = stackalloc byte[9];
        System.Buffer.MemoryCopy((void*)Player.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&Value, @params + 8, 1, 1);

        _ptrSetListenerSpatialization.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrSetListenerSpatialization, @params);
        _ptrSetListenerSpatialization.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.SetSplitScreenListenerEnabled
    // 0xD0E7A0
    // (Final | Native | Static | Public | K2Call)
    public unsafe class SetSplitScreenListenerEnabled_Parameters : BaseObject {
        public SetSplitScreenListenerEnabled_Parameters() { }
        public SetSplitScreenListenerEnabled_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty AkAudio.AkDevice.SetSplitScreenListenerEnabled.bEnable
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bEnable {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetSplitScreenListenerEnabled;
    public static void SetSplitScreenListenerEnabled(bool bEnable) {
        _ptrSetSplitScreenListenerEnabled ??= FindFunction("Function AkAudio.AkDevice.SetSplitScreenListenerEnabled");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bEnable, @params, 4, 4);

        _ptrSetSplitScreenListenerEnabled.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrSetSplitScreenListenerEnabled, @params);
        _ptrSetSplitScreenListenerEnabled.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.SetSplitScreenListenerPosition
    // 0xD0E6B0
    // (Final | Native | Static | Public | K2Call)
    public unsafe class SetSplitScreenListenerPosition_Parameters : BaseObject {
        public SetSplitScreenListenerPosition_Parameters() { }
        public SetSplitScreenListenerPosition_Parameters(nint pointer) : base(pointer) { }

        // StructProperty AkAudio.AkDevice.SetSplitScreenListenerPosition.Location
        // 0x0 (0xC)
        // (Param)
        public FVector Location {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 12, 12);
        }
    }
    private static UFunction _ptrSetSplitScreenListenerPosition;
    public static void SetSplitScreenListenerPosition(FVector Location) {
        _ptrSetSplitScreenListenerPosition ??= FindFunction("Function AkAudio.AkDevice.SetSplitScreenListenerPosition");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)Location.Pointer, @params, 12, 12);

        _ptrSetSplitScreenListenerPosition.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrSetSplitScreenListenerPosition, @params);
        _ptrSetSplitScreenListenerPosition.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.UpdateSecondaryOutputs
    // 0xD0E660
    // (Final | Native | Static | Public | K2Call)
    public unsafe class UpdateSecondaryOutputs_Parameters : BaseObject {
        public UpdateSecondaryOutputs_Parameters() { }
        public UpdateSecondaryOutputs_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrUpdateSecondaryOutputs;
    public static void UpdateSecondaryOutputs() {
        _ptrUpdateSecondaryOutputs ??= FindFunction("Function AkAudio.AkDevice.UpdateSecondaryOutputs");

        _ptrUpdateSecondaryOutputs.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrUpdateSecondaryOutputs, null);
        _ptrUpdateSecondaryOutputs.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.SetGlobalRTCP
    // 0xD0E570
    // (Final | Native | Static | Public | K2Call)
    public unsafe class SetGlobalRTCP_Parameters : BaseObject {
        public SetGlobalRTCP_Parameters() { }
        public SetGlobalRTCP_Parameters(nint pointer) : base(pointer) { }

        // NameProperty AkAudio.AkDevice.SetGlobalRTCP.Key
        // 0x0 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // FloatProperty AkAudio.AkDevice.SetGlobalRTCP.Value
        // 0x8 (0x4)
        // (Param)
        public float Value {
            get => *(float*)(Pointer + 8);
            set => *(float*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrSetGlobalRTCP;
    public static void SetGlobalRTCP(FName Key, float Value) {
        _ptrSetGlobalRTCP ??= FindFunction("Function AkAudio.AkDevice.SetGlobalRTCP");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&Value, @params + 8, 4, 4);

        _ptrSetGlobalRTCP.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrSetGlobalRTCP, @params);
        _ptrSetGlobalRTCP.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.StopGlobalSound
    // 0xD0E4A0
    // (Final | Native | Static | Public | K2Call)
    public unsafe class StopGlobalSound_Parameters : BaseObject {
        public StopGlobalSound_Parameters() { }
        public StopGlobalSound_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkDevice.StopGlobalSound.Sound
        // 0x0 (0x8)
        // (Param)
        public UAkSoundCue Sound {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrStopGlobalSound;
    public static void StopGlobalSound(UAkSoundCue Sound) {
        _ptrStopGlobalSound ??= FindFunction("Function AkAudio.AkDevice.StopGlobalSound");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy((void*)Sound.Pointer, @params, 8, 8);

        _ptrStopGlobalSound.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrStopGlobalSound, @params);
        _ptrStopGlobalSound.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.PlayGlobalSound
    // 0xD0E3D0
    // (Final | Native | Static | Public | K2Call)
    public unsafe class PlayGlobalSound_Parameters : BaseObject {
        public PlayGlobalSound_Parameters() { }
        public PlayGlobalSound_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkDevice.PlayGlobalSound.Sound
        // 0x0 (0x8)
        // (Param)
        public UAkSoundCue Sound {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrPlayGlobalSound;
    public static void PlayGlobalSound(UAkSoundCue Sound) {
        _ptrPlayGlobalSound ??= FindFunction("Function AkAudio.AkDevice.PlayGlobalSound");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy((void*)Sound.Pointer, @params, 8, 8);

        _ptrPlayGlobalSound.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrPlayGlobalSound, @params);
        _ptrPlayGlobalSound.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.SetState
    // 0xD0E2D0
    // (Final | Native | Static | Public | K2Call)
    public unsafe class SetState_Parameters : BaseObject {
        public SetState_Parameters() { }
        public SetState_Parameters(nint pointer) : base(pointer) { }

        // NameProperty AkAudio.AkDevice.SetState.InStateGroup
        // 0x0 (0x8)
        // (Param)
        public FName InStateGroup {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // NameProperty AkAudio.AkDevice.SetState.InState
        // 0x8 (0x8)
        // (Param)
        public FName InState {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 8, 8);
        }
    }
    private static UFunction _ptrSetState;
    public static void SetState(FName InStateGroup, FName InState) {
        _ptrSetState ??= FindFunction("Function AkAudio.AkDevice.SetState");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)InStateGroup.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)InState.Pointer, @params + 8, 8, 8);

        _ptrSetState.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrSetState, @params);
        _ptrSetState.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.SetSwitch
    // 0xD0E1A0
    // (Final | Native | Static | Public | K2Call)
    public unsafe class SetSwitch_Parameters : BaseObject {
        public SetSwitch_Parameters() { }
        public SetSwitch_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkDevice.SetSwitch.SourceActor
        // 0x0 (0x8)
        // (Param)
        public AActor SourceActor {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // NameProperty AkAudio.AkDevice.SetSwitch.Key
        // 0x8 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 8, 8);
        }

        // NameProperty AkAudio.AkDevice.SetSwitch.Value
        // 0x10 (0x8)
        // (Param)
        public FName Value {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 8, 8);
        }
    }
    private static UFunction _ptrSetSwitch;
    public static void SetSwitch(AActor SourceActor, FName Key, FName Value) {
        _ptrSetSwitch ??= FindFunction("Function AkAudio.AkDevice.SetSwitch");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)SourceActor.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params + 8, 8, 8);
        System.Buffer.MemoryCopy((void*)Value.Pointer, @params + 16, 8, 8);

        _ptrSetSwitch.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrSetSwitch, @params);
        _ptrSetSwitch.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.SetRTCP
    // 0xD0E070
    // (Final | Native | Static | Public | K2Call)
    public unsafe class SetRTCP_Parameters : BaseObject {
        public SetRTCP_Parameters() { }
        public SetRTCP_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkDevice.SetRTCP.SourceActor
        // 0x0 (0x8)
        // (Param)
        public AActor SourceActor {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // NameProperty AkAudio.AkDevice.SetRTCP.Key
        // 0x8 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 8, 8);
        }

        // FloatProperty AkAudio.AkDevice.SetRTCP.Value
        // 0x10 (0x4)
        // (Param)
        public float Value {
            get => *(float*)(Pointer + 16);
            set => *(float*)(Pointer + 16) = value;
        }
    }
    private static UFunction _ptrSetRTCP;
    public static void SetRTCP(AActor SourceActor, FName Key, float Value) {
        _ptrSetRTCP ??= FindFunction("Function AkAudio.AkDevice.SetRTCP");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)SourceActor.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params + 8, 8, 8);
        System.Buffer.MemoryCopy(&Value, @params + 16, 4, 4);

        _ptrSetRTCP.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrSetRTCP, @params);
        _ptrSetRTCP.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.StopAllSounds
    // 0xD0DFF0
    // (Final | Native | Static | Public | K2Call)
    public unsafe class StopAllSounds_Parameters : BaseObject {
        public StopAllSounds_Parameters() { }
        public StopAllSounds_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkDevice.StopAllSounds.SourceActor
        // 0x0 (0x8)
        // (Param)
        public AActor SourceActor {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrStopAllSounds;
    public static void StopAllSounds(AActor SourceActor) {
        _ptrStopAllSounds ??= FindFunction("Function AkAudio.AkDevice.StopAllSounds");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy((void*)SourceActor.Pointer, @params, 8, 8);

        _ptrStopAllSounds.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrStopAllSounds, @params);
        _ptrStopAllSounds.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.StopSound
    // 0xD0DF50
    // (Final | Native | Static | Public | K2Call)
    public unsafe class StopSound_Parameters : BaseObject {
        public StopSound_Parameters() { }
        public StopSound_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkDevice.StopSound.SourceActor
        // 0x0 (0x8)
        // (Param)
        public AActor SourceActor {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // ObjectProperty AkAudio.AkDevice.StopSound.Sound
        // 0x8 (0x8)
        // (Param)
        public UAkSoundCue Sound {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }
    }
    private static UFunction _ptrStopSound;
    public static void StopSound(AActor SourceActor, UAkSoundCue Sound) {
        _ptrStopSound ??= FindFunction("Function AkAudio.AkDevice.StopSound");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)SourceActor.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Sound.Pointer, @params + 8, 8, 8);

        _ptrStopSound.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrStopSound, @params);
        _ptrStopSound.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkDevice.PlaySound
    // 0xD0DDE0
    // (Final | Native | Static | HasOptionalParams | Public | K2Call)
    public unsafe class PlaySound_Parameters : BaseObject {
        public PlaySound_Parameters() { }
        public PlaySound_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkDevice.PlaySound.SourceActor
        // 0x0 (0x8)
        // (Param)
        public AActor SourceActor {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // ObjectProperty AkAudio.AkDevice.PlaySound.Sound
        // 0x8 (0x8)
        // (Param)
        public UAkSoundCue Sound {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }

        // StructProperty AkAudio.AkDevice.PlaySound.Translation
        // 0x10 (0xC)
        // (OptionalParam | Param)
        public FVector Translation {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 12, 12);
        }

        // StructProperty AkAudio.AkDevice.PlaySound.Rotation
        // 0x1C (0xC)
        // (OptionalParam | Param)
        public FRotator Rotation {
            get => new(Pointer + 28);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 28), 12, 12);
        }

        // ComponentProperty AkAudio.AkDevice.PlaySound.ReturnValue
        // 0x28 (0x8)
        // (Param | OutParam | ReturnParam | EditInline)
        public UAkSoundSource ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 40);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 40) = value.Pointer;
        }
    }
    private static UFunction _ptrPlaySound;
    public static UAkSoundSource PlaySound(AActor SourceActor, UAkSoundCue Sound, FVector Translation = null, FRotator Rotation = null) {
        _ptrPlaySound ??= FindFunction("Function AkAudio.AkDevice.PlaySound");

        var @params = stackalloc byte[48];
        System.Buffer.MemoryCopy((void*)SourceActor.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Sound.Pointer, @params + 8, 8, 8);
        if (Translation != null) System.Buffer.MemoryCopy((void*)Translation.Pointer, @params + 16, 12, 12);
        if (Rotation != null) System.Buffer.MemoryCopy((void*)Rotation.Pointer, @params + 28, 12, 12);

        _ptrPlaySound.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrPlaySound, @params);
        _ptrPlaySound.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)(@params + 40));
    }

    // Function AkAudio.AkDevice.GetSoundSource
    // 0xD0DCA0
    // (Final | Native | Static | HasOptionalParams | Public | K2Call)
    public unsafe class GetSoundSource_Parameters : BaseObject {
        public GetSoundSource_Parameters() { }
        public GetSoundSource_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkDevice.GetSoundSource.SourceActor
        // 0x0 (0x8)
        // (Param)
        public AActor SourceActor {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // StructProperty AkAudio.AkDevice.GetSoundSource.Translation
        // 0x8 (0xC)
        // (OptionalParam | Param)
        public FVector Translation {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 12, 12);
        }

        // StructProperty AkAudio.AkDevice.GetSoundSource.Rotation
        // 0x14 (0xC)
        // (OptionalParam | Param)
        public FRotator Rotation {
            get => new(Pointer + 20);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 20), 12, 12);
        }

        // ComponentProperty AkAudio.AkDevice.GetSoundSource.ReturnValue
        // 0x20 (0x8)
        // (Param | OutParam | ReturnParam | EditInline)
        public UAkSoundSource ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 32);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 32) = value.Pointer;
        }
    }
    private static UFunction _ptrGetSoundSource;
    public static UAkSoundSource GetSoundSource(AActor SourceActor, FVector Translation = null, FRotator Rotation = null) {
        _ptrGetSoundSource ??= FindFunction("Function AkAudio.AkDevice.GetSoundSource");

        var @params = stackalloc byte[40];
        System.Buffer.MemoryCopy((void*)SourceActor.Pointer, @params, 8, 8);
        if (Translation != null) System.Buffer.MemoryCopy((void*)Translation.Pointer, @params + 8, 12, 12);
        if (Rotation != null) System.Buffer.MemoryCopy((void*)Rotation.Pointer, @params + 20, 12, 12);

        _ptrGetSoundSource.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrGetSoundSource, @params);
        _ptrGetSoundSource.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)(@params + 32));
    }

    // Function AkAudio.AkDevice.EventInitialized
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventInitialized_Parameters : BaseObject {
        public EventInitialized_Parameters() { }
        public EventInitialized_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrEventInitialized;
    public void EventInitialized() {
        _ptrEventInitialized ??= FindFunction("Function AkAudio.AkDevice.EventInitialized");

        ProcessEvent(_ptrEventInitialized, null);
    }


    // Enum AkAudio.AkDevice.EAkDynamicRangeType
    public enum EAkDynamicRangeType : byte {
        AkDRT_Low = 0,
        AkDRT_Medium = 1,
        AkDRT_High = 2,
        AkDRT_MAX = 3
    }

    // Enum AkAudio.AkDevice.EAkOutputType
    public enum EAkOutputType : byte {
        AkOT_Speakers = 0,
        AKOT_Headphones = 1,
        EAkOutputType_MAX = 2
    }

    // Enum AkAudio.AkDevice.EAkListenerSpacialization
    public enum EAkListenerSpacialization : byte {
        AkLS_3D = 0,
        AkLS_Left = 1,
        AkLS_Right = 2,
        AkLS_MAX = 3
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.AkDevice");
            return _staticClass;
        }
    }
}

// Class AkAudio.AkDialogueEvent
// 0x10 (0x60 - 0x70)
// (Compiled | Parsed | Native | CollapseCategories)
public unsafe partial class UAkDialogueEvent : UObject {
    public UAkDialogueEvent() { }
    public UAkDialogueEvent(nint pointer) : base(pointer) { }


    // ArrayProperty AkAudio.AkDialogueEvent.Arguments
    // 0x60 (0x10)
    // (Edit | Const | NeedCtorLink)
    public PointerTArray<UAkSwitch> Arguments {
        get => new(Pointer + 96);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 96), 16, 16);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.AkDialogueEvent");
            return _staticClass;
        }
    }
}

// Class AkAudio.AkEnvironments
// 0x2C (0x60 - 0x8C)
// (Compiled | Parsed | Native)
public unsafe partial class UAkEnvironments : UObject {
    public UAkEnvironments() { }
    public UAkEnvironments(nint pointer) : base(pointer) { }


    // StructProperty AkAudio.AkEnvironments.VfTable_FObjectDestructionSubscriber
    // 0x60 (0x8)
    // (Const | Native | NoExport)
    public nint VfTable_FObjectDestructionSubscriber {
        get => *(nint*)(Pointer + 96);
        set => *(nint*)(Pointer + 96) = value;
    }

    // ArrayProperty AkAudio.AkEnvironments.LevelEnvironments
    // 0x68 (0x10)
    // (NeedCtorLink | PrivateWrite)
    public StructTArray<FAkEnvironment> LevelEnvironments {
        get => new(Pointer + 104, 32);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 104), 16, 16);
    }

    // ArrayProperty AkAudio.AkEnvironments.ActorEnvironments
    // 0x78 (0x10)
    // (NeedCtorLink | PrivateWrite)
    public StructTArray<FAkActorEnvironment> ActorEnvironments {
        get => new(Pointer + 120, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 120), 16, 16);
    }

    // BoolProperty AkAudio.AkEnvironments.bLevelDirty
    // 0x88 (0x4)
    // Bitmask: 0x00000001
    public bool bLevelDirty {
        get => (*(uint*)(Pointer + 136) & 0x1) != 0;
        set {
            if (value) *(uint*)(Pointer + 136) |= 0x1;
            else *(uint*)(Pointer + 136) &= ~(uint)0x1;
        }
    }

    // BoolProperty AkAudio.AkEnvironments.bActorEnvironmentDirty
    // 0x88 (0x4)
    // Bitmask: 0x00000002
    public bool bActorEnvironmentDirty {
        get => (*(uint*)(Pointer + 136) & 0x2) != 0;
        set {
            if (value) *(uint*)(Pointer + 136) |= 0x2;
            else *(uint*)(Pointer + 136) &= ~(uint)0x2;
        }
    }


    // Function AkAudio.AkEnvironments.RemoveActorEnvironment
    // 0xD0CBC0
    // (Final | Native | Public | HasOutParams)
    public unsafe class RemoveActorEnvironment_Parameters : BaseObject {
        public RemoveActorEnvironment_Parameters() { }
        public RemoveActorEnvironment_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkEnvironments.RemoveActorEnvironment.TargetActor
        // 0x0 (0x8)
        // (Param)
        public AActor TargetActor {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // StrProperty AkAudio.AkEnvironments.RemoveActorEnvironment.EnvironmentID
        // 0x8 (0x10)
        // (Const | Param | OutParam | NeedCtorLink)
        public FString EnvironmentID {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrRemoveActorEnvironment;
    public void RemoveActorEnvironment(AActor TargetActor, ref FString EnvironmentID) {
        _ptrRemoveActorEnvironment ??= FindFunction("Function AkAudio.AkEnvironments.RemoveActorEnvironment");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)TargetActor.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)EnvironmentID.Pointer, @params + 8, 16, 16);

        _ptrRemoveActorEnvironment.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrRemoveActorEnvironment, @params);
        _ptrRemoveActorEnvironment.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _EnvironmentIDPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 8, (void*)_EnvironmentIDPtr, 16, 16);
        EnvironmentID = new(_EnvironmentIDPtr) { Allocated = true };
    }

    // Function AkAudio.AkEnvironments.AddActorEnvironment
    // 0xD0CAB0
    // (Final | Native | Public | HasOutParams)
    public unsafe class AddActorEnvironment_Parameters : BaseObject {
        public AddActorEnvironment_Parameters() { }
        public AddActorEnvironment_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkEnvironments.AddActorEnvironment.TargetActor
        // 0x0 (0x8)
        // (Param)
        public AActor TargetActor {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // StructProperty AkAudio.AkEnvironments.AddActorEnvironment.Environment
        // 0x8 (0x20)
        // (Const | Param | OutParam | NeedCtorLink)
        public FAkEnvironment Environment {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 32, 32);
        }
    }
    private static UFunction _ptrAddActorEnvironment;
    public void AddActorEnvironment(AActor TargetActor, ref FAkEnvironment Environment) {
        _ptrAddActorEnvironment ??= FindFunction("Function AkAudio.AkEnvironments.AddActorEnvironment");

        var @params = stackalloc byte[40];
        System.Buffer.MemoryCopy((void*)TargetActor.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Environment.Pointer, @params + 8, 32, 32);

        _ptrAddActorEnvironment.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrAddActorEnvironment, @params);
        _ptrAddActorEnvironment.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _EnvironmentPtr = Marshal.AllocHGlobal(32);
        System.Buffer.MemoryCopy(@params + 8, (void*)_EnvironmentPtr, 32, 32);
        Environment = new(_EnvironmentPtr) { Allocated = true };
    }

    // Function AkAudio.AkEnvironments.AddLevelDefault
    // 0xD0C9D0
    // (Final | Native | Public | HasOutParams)
    public unsafe class AddLevelDefault_Parameters : BaseObject {
        public AddLevelDefault_Parameters() { }
        public AddLevelDefault_Parameters(nint pointer) : base(pointer) { }

        // StructProperty AkAudio.AkEnvironments.AddLevelDefault.Environment
        // 0x0 (0x20)
        // (Const | Param | OutParam | NeedCtorLink)
        public FAkEnvironment Environment {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 32, 32);
        }
    }
    private static UFunction _ptrAddLevelDefault;
    public void AddLevelDefault(ref FAkEnvironment Environment) {
        _ptrAddLevelDefault ??= FindFunction("Function AkAudio.AkEnvironments.AddLevelDefault");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)Environment.Pointer, @params, 32, 32);

        _ptrAddLevelDefault.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrAddLevelDefault, @params);
        _ptrAddLevelDefault.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _EnvironmentPtr = Marshal.AllocHGlobal(32);
        System.Buffer.MemoryCopy(@params, (void*)_EnvironmentPtr, 32, 32);
        Environment = new(_EnvironmentPtr) { Allocated = true };
    }


    // ScriptStruct AkAudio.AkEnvironments.AkActorEnvironment
    // 0x18
    public unsafe class FAkActorEnvironment : BaseObject {
        public FAkActorEnvironment() {
            Pointer = Marshal.AllocHGlobal(24);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 24);
            Allocated = true;
        }
        public FAkActorEnvironment(nint pointer) : base(pointer) { }

        // ArrayProperty AkAudio.AkEnvironments.AkActorEnvironment.Environments
        // 0x0 (0x10)
        // (NeedCtorLink)
        public StructTArray<FAkEnvironment> Environments {
            get => new(Pointer, 32);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ObjectProperty AkAudio.AkEnvironments.AkActorEnvironment.TargetActor
        // 0x10 (0x8)
        public AActor TargetActor {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }
    }

    // ScriptStruct AkAudio.AkEnvironments.AkEnvironment
    // 0x20
    public unsafe class FAkEnvironment : BaseObject {
        public FAkEnvironment() {
            Pointer = Marshal.AllocHGlobal(32);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 32);
            Allocated = true;
        }
        public FAkEnvironment(nint pointer) : base(pointer) { }

        // StrProperty AkAudio.AkEnvironments.AkEnvironment.Id
        // 0x0 (0x10)
        // (Edit | NeedCtorLink)
        public FString Id {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // IntProperty AkAudio.AkEnvironments.AkEnvironment.Priority
        // 0x10 (0x4)
        // (Edit)
        public int Priority {
            get => *(int*)(Pointer + 16);
            set => *(int*)(Pointer + 16) = value;
        }

        // FloatProperty AkAudio.AkEnvironments.AkEnvironment.WetValue
        // 0x14 (0x4)
        // (Edit)
        public float WetValue {
            get => *(float*)(Pointer + 20);
            set => *(float*)(Pointer + 20) = value;
        }

        // FloatProperty AkAudio.AkEnvironments.AkEnvironment.DryValue
        // 0x18 (0x4)
        // (Edit)
        public float DryValue {
            get => *(float*)(Pointer + 24);
            set => *(float*)(Pointer + 24) = value;
        }

        // StructProperty AkAudio.AkEnvironments.AkEnvironment.HashedEnvID
        // 0x1C (0x4)
        // (Const)
        public Fuint HashedEnvID {
            get => new(Pointer + 28);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 28), 4, 4);
        }
    }

    // ScriptStruct AkAudio.AkEnvironments.uint
    // 0x4
    public unsafe class Fuint : BaseObject {
        public Fuint() {
            Pointer = Marshal.AllocHGlobal(4);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 4);
            Allocated = true;
        }
        public Fuint(nint pointer) : base(pointer) { }

        // IntProperty AkAudio.AkEnvironments.uint.dummyint
        // 0x0 (0x4)
        public int dummyint {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.AkEnvironments");
            return _staticClass;
        }
    }
}

// Class AkAudio.AkEnvironmentVolume
// 0x24 (0x2A4 - 0x2C8)
// (Compiled | Parsed | Native | Placeable | Hidden)
public unsafe partial class AAkEnvironmentVolume : AVolume {
    public AAkEnvironmentVolume() { }
    public AAkEnvironmentVolume(nint pointer) : base(pointer) { }


    // MISSED OFFSET: 0x4

    // StructProperty AkAudio.AkEnvironmentVolume.Environment
    // 0x2A8 (0x20)
    // (Edit | NeedCtorLink)
    public UAkEnvironments.FAkEnvironment Environment {
        get => new(Pointer + 680);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 680), 32, 32);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.AkEnvironmentVolume");
            return _staticClass;
        }
    }
}

// Class AkAudio.AkMusicAnalysis
// 0xB0 (0x60 - 0x110)
// (Compiled | Config | Parsed | Native)
public unsafe partial class UAkMusicAnalysis : UObject {
    public UAkMusicAnalysis() { }
    public UAkMusicAnalysis(nint pointer) : base(pointer) { }


    // StructProperty AkAudio.AkMusicAnalysis.VfTable_FTickableObject
    // 0x60 (0x8)
    // (Const | Native | NoExport)
    public nint VfTable_FTickableObject {
        get => *(nint*)(Pointer + 96);
        set => *(nint*)(Pointer + 96) = value;
    }

    // IntProperty AkAudio.AkMusicAnalysis.BPM
    // 0x68 (0x4)
    public int BPM {
        get => *(int*)(Pointer + 104);
        set => *(int*)(Pointer + 104) = value;
    }

    // MISSED OFFSET: 0x4

    // StructProperty AkAudio.AkMusicAnalysis.MusicInfo
    // 0x70 (0x20)
    // (NeedCtorLink)
    public FMusicAnalysisInfo MusicInfo {
        get => new(Pointer + 112);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 112), 32, 32);
    }

    // StructProperty AkAudio.AkMusicAnalysis.MusicInfoSmoothed
    // 0x90 (0x20)
    // (NeedCtorLink)
    public FMusicAnalysisInfo MusicInfoSmoothed {
        get => new(Pointer + 144);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 144), 32, 32);
    }

    // FloatProperty AkAudio.AkMusicAnalysis.AttackSpeed
    // 0xB0 (0x4)
    // (Edit | Config)
    public float AttackSpeed {
        get => *(float*)(Pointer + 176);
        set => *(float*)(Pointer + 176) = value;
    }

    // FloatProperty AkAudio.AkMusicAnalysis.ReleaseSpeed
    // 0xB4 (0x4)
    // (Edit | Config)
    public float ReleaseSpeed {
        get => *(float*)(Pointer + 180);
        set => *(float*)(Pointer + 180) = value;
    }

    // BoolProperty AkAudio.AkMusicAnalysis.bDebugPrintMusicAnalysisValues
    // 0xB8 (0x4)
    // Bitmask: 0x00000001
    // (Edit | Config)
    public bool bDebugPrintMusicAnalysisValues {
        get => (*(uint*)(Pointer + 184) & 0x1) != 0;
        set {
            if (value) *(uint*)(Pointer + 184) |= 0x1;
            else *(uint*)(Pointer + 184) &= ~(uint)0x1;
        }
    }

    // MISSED OFFSET: 0x4

    // ObjectProperty AkAudio.AkMusicAnalysis.MusicAnalysisSilentLoop
    // 0xC0 (0x8)
    public UAkSoundCue MusicAnalysisSilentLoop {
        get {
            var pointer = *(nint*)(Pointer + 192);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 192) = value.Pointer;
    }

    // DelegateProperty AkAudio.AkMusicAnalysis.__EventNewMusicTrack__Delegate
    // 0xC8 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventNewMusicTrack__Delegate {
        get => new(Pointer + 200);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 200), 24, 24);
    }

    // DelegateProperty AkAudio.AkMusicAnalysis.__EventMusicBeat__Delegate
    // 0xE0 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventMusicBeat__Delegate {
        get => new(Pointer + 224);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 224), 24, 24);
    }

    // DelegateProperty AkAudio.AkMusicAnalysis.__EventMusicBar__Delegate
    // 0xF8 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventMusicBar__Delegate {
        get => new(Pointer + 248);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 248), 24, 24);
    }


    // Function AkAudio.AkMusicAnalysis.UpdateSmoothedMusicInfo
    // 0xD0F420
    // (Final | Native | Static | Public)
    public unsafe class UpdateSmoothedMusicInfo_Parameters : BaseObject {
        public UpdateSmoothedMusicInfo_Parameters() { }
        public UpdateSmoothedMusicInfo_Parameters(nint pointer) : base(pointer) { }

        // FloatProperty AkAudio.AkMusicAnalysis.UpdateSmoothedMusicInfo.DeltaTime
        // 0x0 (0x4)
        // (Const | Param)
        public float DeltaTime {
            get => *(float*)Pointer;
            set => *(float*)Pointer = value;
        }
    }
    private static UFunction _ptrUpdateSmoothedMusicInfo;
    public static void UpdateSmoothedMusicInfo(float DeltaTime) {
        _ptrUpdateSmoothedMusicInfo ??= FindFunction("Function AkAudio.AkMusicAnalysis.UpdateSmoothedMusicInfo");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&DeltaTime, @params, 4, 4);

        _ptrUpdateSmoothedMusicInfo.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrUpdateSmoothedMusicInfo, @params);
        _ptrUpdateSmoothedMusicInfo.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkMusicAnalysis.UpdateMusicInfo
    // 0xD0F340
    // (Final | Native | Static | Public | HasOutParams)
    public unsafe class UpdateMusicInfo_Parameters : BaseObject {
        public UpdateMusicInfo_Parameters() { }
        public UpdateMusicInfo_Parameters(nint pointer) : base(pointer) { }

        // StructProperty AkAudio.AkMusicAnalysis.UpdateMusicInfo.NewValues
        // 0x0 (0x20)
        // (Const | Param | OutParam | NeedCtorLink)
        public FMusicAnalysisInfo NewValues {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 32, 32);
        }
    }
    private static UFunction _ptrUpdateMusicInfo;
    public static void UpdateMusicInfo(ref FMusicAnalysisInfo NewValues) {
        _ptrUpdateMusicInfo ??= FindFunction("Function AkAudio.AkMusicAnalysis.UpdateMusicInfo");

        var @params = stackalloc byte[32];
        System.Buffer.MemoryCopy((void*)NewValues.Pointer, @params, 32, 32);

        _ptrUpdateMusicInfo.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrUpdateMusicInfo, @params);
        _ptrUpdateMusicInfo.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _NewValuesPtr = Marshal.AllocHGlobal(32);
        System.Buffer.MemoryCopy(@params, (void*)_NewValuesPtr, 32, 32);
        NewValues = new(_NewValuesPtr) { Allocated = true };
    }

    // Function AkAudio.AkMusicAnalysis.OnNewTrack
    // 0xD0F2C0
    // (Final | Native | Static | Public)
    public unsafe class OnNewTrack_Parameters : BaseObject {
        public OnNewTrack_Parameters() { }
        public OnNewTrack_Parameters(nint pointer) : base(pointer) { }

        // IntProperty AkAudio.AkMusicAnalysis.OnNewTrack.NewBPM
        // 0x0 (0x4)
        // (Param)
        public int NewBPM {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrOnNewTrack;
    public static void OnNewTrack(int NewBPM) {
        _ptrOnNewTrack ??= FindFunction("Function AkAudio.AkMusicAnalysis.OnNewTrack");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&NewBPM, @params, 4, 4);

        _ptrOnNewTrack.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrOnNewTrack, @params);
        _ptrOnNewTrack.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkMusicAnalysis.GetInstance
    // 0xD0F240
    // (Final | Native | Static | Public)
    public unsafe class GetInstance_Parameters : BaseObject {
        public GetInstance_Parameters() { }
        public GetInstance_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkMusicAnalysis.GetInstance.ReturnValue
        // 0x0 (0x8)
        // (Param | OutParam | ReturnParam)
        public UAkMusicAnalysis ReturnValue {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrGetInstance;
    public static UAkMusicAnalysis GetInstance() {
        _ptrGetInstance ??= FindFunction("Function AkAudio.AkMusicAnalysis.GetInstance");

        var @params = stackalloc byte[8];

        _ptrGetInstance.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrGetInstance, @params);
        _ptrGetInstance.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)@params);
    }

    // Function AkAudio.AkMusicAnalysis.EventMusicBar
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventMusicBar_Parameters : BaseObject {
        public EventMusicBar_Parameters() { }
        public EventMusicBar_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrEventMusicBar;
    public void EventMusicBar() {
        _ptrEventMusicBar ??= FindFunction("Function AkAudio.AkMusicAnalysis.EventMusicBar");

        ProcessEvent(_ptrEventMusicBar, null);
    }

    // Function AkAudio.AkMusicAnalysis.EventMusicBeat
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventMusicBeat_Parameters : BaseObject {
        public EventMusicBeat_Parameters() { }
        public EventMusicBeat_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrEventMusicBeat;
    public void EventMusicBeat() {
        _ptrEventMusicBeat ??= FindFunction("Function AkAudio.AkMusicAnalysis.EventMusicBeat");

        ProcessEvent(_ptrEventMusicBeat, null);
    }

    // Function AkAudio.AkMusicAnalysis.EventNewMusicTrack
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventNewMusicTrack_Parameters : BaseObject {
        public EventNewMusicTrack_Parameters() { }
        public EventNewMusicTrack_Parameters(nint pointer) : base(pointer) { }

        // IntProperty AkAudio.AkMusicAnalysis.EventNewMusicTrack.PlayingID
        // 0x0 (0x4)
        // (Param)
        public int PlayingID {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // IntProperty AkAudio.AkMusicAnalysis.EventNewMusicTrack.NewBPM
        // 0x4 (0x4)
        // (Param)
        public int NewBPM {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }
    }
    private static UFunction _ptrEventNewMusicTrack;
    public void EventNewMusicTrack(int PlayingID, int NewBPM) {
        _ptrEventNewMusicTrack ??= FindFunction("Function AkAudio.AkMusicAnalysis.EventNewMusicTrack");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy(&PlayingID, @params, 4, 4);
        System.Buffer.MemoryCopy(&NewBPM, @params + 4, 4, 4);

        ProcessEvent(_ptrEventNewMusicTrack, @params);
    }


    // ScriptStruct AkAudio.AkMusicAnalysis.MusicAnalysisInfo
    // 0x1C
    public unsafe class FMusicAnalysisInfo : BaseObject {
        public FMusicAnalysisInfo() {
            Pointer = Marshal.AllocHGlobal(28);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 28);
            Allocated = true;
        }
        public FMusicAnalysisInfo(nint pointer) : base(pointer) { }

        // FloatProperty AkAudio.AkMusicAnalysis.MusicAnalysisInfo.LowEnergy
        // 0x0 (0x4)
        public float LowEnergy {
            get => *(float*)Pointer;
            set => *(float*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // ArrayProperty AkAudio.AkMusicAnalysis.MusicAnalysisInfo.Frequencies
        // 0x8 (0x10)
        // (NeedCtorLink)
        public UnmanagedTArray<float> Frequencies {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }

        // FloatProperty AkAudio.AkMusicAnalysis.MusicAnalysisInfo.HighEnergy
        // 0x18 (0x4)
        public float HighEnergy {
            get => *(float*)(Pointer + 24);
            set => *(float*)(Pointer + 24) = value;
        }
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.AkMusicAnalysis");
            return _staticClass;
        }
    }
}

// Class AkAudio.AkMusicDevice
// 0x30 (0x60 - 0x90)
// (Abstract | Compiled | Parsed | Native)
public unsafe partial class UAkMusicDevice : UObject {
    public UAkMusicDevice() { }
    public UAkMusicDevice(nint pointer) : base(pointer) { }


    // DelegateProperty AkAudio.AkMusicDevice.__EventTrackStart__Delegate
    // 0x60 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventTrackStart__Delegate {
        get => new(Pointer + 96);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 96), 24, 24);
    }

    // DelegateProperty AkAudio.AkMusicDevice.__EventTrackEnd__Delegate
    // 0x78 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventTrackEnd__Delegate {
        get => new(Pointer + 120);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 120), 24, 24);
    }


    // Function AkAudio.AkMusicDevice.Seek
    // 0xD0F880
    // (Final | Native | Static | Public | K2Call)
    public unsafe class Seek_Parameters : BaseObject {
        public Seek_Parameters() { }
        public Seek_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkMusicDevice.Seek.Sound
        // 0x0 (0x8)
        // (Param)
        public UAkSoundCue Sound {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // FloatProperty AkAudio.AkMusicDevice.Seek.PositionSeconds
        // 0x8 (0x4)
        // (Param)
        public float PositionSeconds {
            get => *(float*)(Pointer + 8);
            set => *(float*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrSeek;
    public static void Seek(UAkSoundCue Sound, float PositionSeconds) {
        _ptrSeek ??= FindFunction("Function AkAudio.AkMusicDevice.Seek");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)Sound.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&PositionSeconds, @params + 8, 4, 4);

        _ptrSeek.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrSeek, @params);
        _ptrSeek.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkMusicDevice.SetRTCP
    // 0xD0F790
    // (Final | Native | Static | Public | K2Call)
    public unsafe class SetRTCP_Parameters : BaseObject {
        public SetRTCP_Parameters() { }
        public SetRTCP_Parameters(nint pointer) : base(pointer) { }

        // NameProperty AkAudio.AkMusicDevice.SetRTCP.Key
        // 0x0 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // FloatProperty AkAudio.AkMusicDevice.SetRTCP.Value
        // 0x8 (0x4)
        // (Param)
        public float Value {
            get => *(float*)(Pointer + 8);
            set => *(float*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrSetRTCP;
    public static void SetRTCP(FName Key, float Value) {
        _ptrSetRTCP ??= FindFunction("Function AkAudio.AkMusicDevice.SetRTCP");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&Value, @params + 8, 4, 4);

        _ptrSetRTCP.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrSetRTCP, @params);
        _ptrSetRTCP.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkMusicDevice.StopPlayingID
    // 0xD0F6E0
    // (Final | Native | Static | Public | K2Call)
    public unsafe class StopPlayingID_Parameters : BaseObject {
        public StopPlayingID_Parameters() { }
        public StopPlayingID_Parameters(nint pointer) : base(pointer) { }

        // IntProperty AkAudio.AkMusicDevice.StopPlayingID.PlayingID
        // 0x0 (0x4)
        // (Param)
        public int PlayingID {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrStopPlayingID;
    public static void StopPlayingID(int PlayingID) {
        _ptrStopPlayingID ??= FindFunction("Function AkAudio.AkMusicDevice.StopPlayingID");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&PlayingID, @params, 4, 4);

        _ptrStopPlayingID.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrStopPlayingID, @params);
        _ptrStopPlayingID.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkMusicDevice.Stop
    // 0xD0F660
    // (Final | Native | Static | Public | K2Call)
    public unsafe class Stop_Parameters : BaseObject {
        public Stop_Parameters() { }
        public Stop_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkMusicDevice.Stop.Sound
        // 0x0 (0x8)
        // (Param)
        public UAkSoundCue Sound {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrStop;
    public static void Stop(UAkSoundCue Sound) {
        _ptrStop ??= FindFunction("Function AkAudio.AkMusicDevice.Stop");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy((void*)Sound.Pointer, @params, 8, 8);

        _ptrStop.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrStop, @params);
        _ptrStop.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkMusicDevice.Play
    // 0xD0F4A0
    // (Final | Native | Static | Public | K2Call)
    public unsafe class Play_Parameters : BaseObject {
        public Play_Parameters() { }
        public Play_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkMusicDevice.Play.Sound
        // 0x0 (0x8)
        // (Param)
        public UAkSoundCue Sound {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // IntProperty AkAudio.AkMusicDevice.Play.ReturnValue
        // 0x8 (0x4)
        // (Param | OutParam | ReturnParam)
        public int ReturnValue {
            get => *(int*)(Pointer + 8);
            set => *(int*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrPlay;
    public static int Play(UAkSoundCue Sound) {
        _ptrPlay ??= FindFunction("Function AkAudio.AkMusicDevice.Play");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)Sound.Pointer, @params, 8, 8);

        _ptrPlay.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrPlay, @params);
        _ptrPlay.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(int*)(@params + 8);
    }

    // Function AkAudio.AkMusicDevice.EventTrackEnd
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventTrackEnd_Parameters : BaseObject {
        public EventTrackEnd_Parameters() { }
        public EventTrackEnd_Parameters(nint pointer) : base(pointer) { }

        // IntProperty AkAudio.AkMusicDevice.EventTrackEnd.PlayingID
        // 0x0 (0x4)
        // (Param)
        public int PlayingID {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrEventTrackEnd;
    public void EventTrackEnd(int PlayingID) {
        _ptrEventTrackEnd ??= FindFunction("Function AkAudio.AkMusicDevice.EventTrackEnd");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&PlayingID, @params, 4, 4);

        ProcessEvent(_ptrEventTrackEnd, @params);
    }

    // Function AkAudio.AkMusicDevice.EventTrackStart
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventTrackStart_Parameters : BaseObject {
        public EventTrackStart_Parameters() { }
        public EventTrackStart_Parameters(nint pointer) : base(pointer) { }

        // IntProperty AkAudio.AkMusicDevice.EventTrackStart.PlayingID
        // 0x0 (0x4)
        // (Param)
        public int PlayingID {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty AkAudio.AkMusicDevice.EventTrackStart.FileMarker
        // 0x8 (0x10)
        // (Param | NeedCtorLink)
        public FString FileMarker {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrEventTrackStart;
    public void EventTrackStart(int PlayingID, FString FileMarker) {
        _ptrEventTrackStart ??= FindFunction("Function AkAudio.AkMusicDevice.EventTrackStart");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy(&PlayingID, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)FileMarker.Pointer, @params + 8, 16, 16);

        ProcessEvent(_ptrEventTrackStart, @params);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.AkMusicDevice");
            return _staticClass;
        }
    }
}

// Class AkAudio.AkParamGroup
// 0xC1 (0x9D - 0x15E)
// (Compiled | Parsed | Native | Hidden)
public unsafe partial class UAkParamGroup : UActorComponent {
    public UAkParamGroup() { }
    public UAkParamGroup(nint pointer) : base(pointer) { }


    // MISSED OFFSET: 0x3

    // StructProperty AkAudio.AkParamGroup.VfTable_IISetParameter
    // 0xA0 (0x8)
    // (Const | Native | NoExport)
    public nint VfTable_IISetParameter {
        get => *(nint*)(Pointer + 160);
        set => *(nint*)(Pointer + 160) = value;
    }

    // StructProperty AkAudio.AkParamGroup.StoredParameters
    // 0xA8 (0xA0)
    // (Const | Transient)
    public FAkParamSet StoredParameters {
        get => new(Pointer + 168);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 168), 160, 160);
    }

    // ArrayProperty AkAudio.AkParamGroup.SoundSources
    // 0x148 (0x10)
    // (Const | ExportObject | Transient | Component | NeedCtorLink | EditInline)
    public PointerTArray<UAkSoundSource> SoundSources {
        get => new(Pointer + 328);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 328), 16, 16);
    }

    // IntProperty AkAudio.AkParamGroup.ControllerId
    // 0x158 (0x4)
    // (Transient)
    public int ControllerId {
        get => *(int*)(Pointer + 344);
        set => *(int*)(Pointer + 344) = value;
    }

    // ByteProperty AkAudio.AkParamGroup.SendType
    // 0x15C (0x1)
    // (Transient)
    public EReflectionSendType SendType {
        get => *(EReflectionSendType*)(Pointer + 348);
        set => *(EReflectionSendType*)(Pointer + 348) = value;
    }

    // ByteProperty AkAudio.AkParamGroup.AttenuationType
    // 0x15D (0x1)
    // (Transient)
    public EAttenuationType AttenuationType {
        get => *(EAttenuationType*)(Pointer + 349);
        set => *(EAttenuationType*)(Pointer + 349) = value;
    }


    // Function AkAudio.AkParamGroup.SetSendToSlapbacks
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class SetSendToSlapbacks_Parameters : BaseObject {
        public SetSendToSlapbacks_Parameters() { }
        public SetSendToSlapbacks_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty AkAudio.AkParamGroup.SetSendToSlapbacks.bSend
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bSend {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetSendToSlapbacks;
    public void SetSendToSlapbacks(bool bSend) {
        _ptrSetSendToSlapbacks ??= FindFunction("Function AkAudio.AkParamGroup.SetSendToSlapbacks");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bSend, @params, 4, 4);

        ProcessEvent(_ptrSetSendToSlapbacks, @params);
    }

    // Function AkAudio.AkParamGroup.SetControllerId
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class SetControllerId_Parameters : BaseObject {
        public SetControllerId_Parameters() { }
        public SetControllerId_Parameters(nint pointer) : base(pointer) { }

        // IntProperty AkAudio.AkParamGroup.SetControllerId.InID
        // 0x0 (0x4)
        // (Param)
        public int InID {
            get => *(int*)Pointer;
            set => *(int*)Pointer = value;
        }
    }
    private static UFunction _ptrSetControllerId;
    public void SetControllerId(int InID) {
        _ptrSetControllerId ??= FindFunction("Function AkAudio.AkParamGroup.SetControllerId");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&InID, @params, 4, 4);

        ProcessEvent(_ptrSetControllerId, @params);
    }

    // Function AkAudio.AkParamGroup.EnableObjectAttenuation
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class EnableObjectAttenuation_Parameters : BaseObject {
        public EnableObjectAttenuation_Parameters() { }
        public EnableObjectAttenuation_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrEnableObjectAttenuation;
    public void EnableObjectAttenuation() {
        _ptrEnableObjectAttenuation ??= FindFunction("Function AkAudio.AkParamGroup.EnableObjectAttenuation");

        ProcessEvent(_ptrEnableObjectAttenuation, null);
    }

    // Function AkAudio.AkParamGroup.DisableObjectAttenuation
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class DisableObjectAttenuation_Parameters : BaseObject {
        public DisableObjectAttenuation_Parameters() { }
        public DisableObjectAttenuation_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrDisableObjectAttenuation;
    public void DisableObjectAttenuation() {
        _ptrDisableObjectAttenuation ??= FindFunction("Function AkAudio.AkParamGroup.DisableObjectAttenuation");

        ProcessEvent(_ptrDisableObjectAttenuation, null);
    }

    // Function AkAudio.AkParamGroup.PrintDebugInfo
    // 0x3750E0
    // (Defined | Simulated | Public)
    public unsafe class PrintDebugInfo_Parameters : BaseObject {
        public PrintDebugInfo_Parameters() { }
        public PrintDebugInfo_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkParamGroup.PrintDebugInfo.Drawer
        // 0x0 (0x8)
        // (Param)
        public UDebugDrawer Drawer {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrPrintDebugInfo;
    public void PrintDebugInfo(UDebugDrawer Drawer) {
        _ptrPrintDebugInfo ??= FindFunction("Function AkAudio.AkParamGroup.PrintDebugInfo");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy((void*)Drawer.Pointer, @params, 8, 8);

        ProcessEvent(_ptrPrintDebugInfo, @params);
    }

    // Function AkAudio.AkParamGroup.UpdateSoundSourceAttenuationScaling
    // 0xD0D650
    // (Final | Native | Public | K2Call)
    public unsafe class UpdateSoundSourceAttenuationScaling_Parameters : BaseObject {
        public UpdateSoundSourceAttenuationScaling_Parameters() { }
        public UpdateSoundSourceAttenuationScaling_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrUpdateSoundSourceAttenuationScaling;
    public void UpdateSoundSourceAttenuationScaling() {
        _ptrUpdateSoundSourceAttenuationScaling ??= FindFunction("Function AkAudio.AkParamGroup.UpdateSoundSourceAttenuationScaling");

        _ptrUpdateSoundSourceAttenuationScaling.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrUpdateSoundSourceAttenuationScaling, null);
        _ptrUpdateSoundSourceAttenuationScaling.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkParamGroup.SetActorParameter
    // 0xD0D590
    // (Final | Native | Public | K2Call)
    public unsafe class SetActorParameter_Parameters : BaseObject {
        public SetActorParameter_Parameters() { }
        public SetActorParameter_Parameters(nint pointer) : base(pointer) { }

        // NameProperty AkAudio.AkParamGroup.SetActorParameter.Key
        // 0x0 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // ObjectProperty AkAudio.AkParamGroup.SetActorParameter.Value
        // 0x8 (0x8)
        // (Param)
        public AActor Value {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }
    }
    private static UFunction _ptrSetActorParameter;
    public void SetActorParameter(FName Key, AActor Value) {
        _ptrSetActorParameter ??= FindFunction("Function AkAudio.AkParamGroup.SetActorParameter");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Value.Pointer, @params + 8, 8, 8);

        _ptrSetActorParameter.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetActorParameter, @params);
        _ptrSetActorParameter.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkParamGroup.SetLinearColorParameter
    // 0xD0D4D0
    // (Final | Native | Public | K2Call)
    public unsafe class SetLinearColorParameter_Parameters : BaseObject {
        public SetLinearColorParameter_Parameters() { }
        public SetLinearColorParameter_Parameters(nint pointer) : base(pointer) { }

        // NameProperty AkAudio.AkParamGroup.SetLinearColorParameter.Key
        // 0x0 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // StructProperty AkAudio.AkParamGroup.SetLinearColorParameter.Value
        // 0x8 (0x10)
        // (Param)
        public FLinearColor Value {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrSetLinearColorParameter;
    public void SetLinearColorParameter(FName Key, FLinearColor Value) {
        _ptrSetLinearColorParameter ??= FindFunction("Function AkAudio.AkParamGroup.SetLinearColorParameter");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Value.Pointer, @params + 8, 16, 16);

        _ptrSetLinearColorParameter.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetLinearColorParameter, @params);
        _ptrSetLinearColorParameter.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkParamGroup.SetVectorParameter
    // 0xD0D400
    // (Final | Native | Public | K2Call)
    public unsafe class SetVectorParameter_Parameters : BaseObject {
        public SetVectorParameter_Parameters() { }
        public SetVectorParameter_Parameters(nint pointer) : base(pointer) { }

        // NameProperty AkAudio.AkParamGroup.SetVectorParameter.Key
        // 0x0 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // StructProperty AkAudio.AkParamGroup.SetVectorParameter.Value
        // 0x8 (0xC)
        // (Param)
        public FVector Value {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 12, 12);
        }
    }
    private static UFunction _ptrSetVectorParameter;
    public void SetVectorParameter(FName Key, FVector Value) {
        _ptrSetVectorParameter ??= FindFunction("Function AkAudio.AkParamGroup.SetVectorParameter");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Value.Pointer, @params + 8, 12, 12);

        _ptrSetVectorParameter.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetVectorParameter, @params);
        _ptrSetVectorParameter.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkParamGroup.SetFloatParameter
    // 0xD0D340
    // (Final | Native | Public | K2Call)
    public unsafe class SetFloatParameter_Parameters : BaseObject {
        public SetFloatParameter_Parameters() { }
        public SetFloatParameter_Parameters(nint pointer) : base(pointer) { }

        // NameProperty AkAudio.AkParamGroup.SetFloatParameter.Key
        // 0x0 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // FloatProperty AkAudio.AkParamGroup.SetFloatParameter.Value
        // 0x8 (0x4)
        // (Param)
        public float Value {
            get => *(float*)(Pointer + 8);
            set => *(float*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrSetFloatParameter;
    public void SetFloatParameter(FName Key, float Value) {
        _ptrSetFloatParameter ??= FindFunction("Function AkAudio.AkParamGroup.SetFloatParameter");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&Value, @params + 8, 4, 4);

        _ptrSetFloatParameter.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetFloatParameter, @params);
        _ptrSetFloatParameter.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkParamGroup.SetNameParameter
    // 0xD0D290
    // (Final | Native | Public | K2Call)
    public unsafe class SetNameParameter_Parameters : BaseObject {
        public SetNameParameter_Parameters() { }
        public SetNameParameter_Parameters(nint pointer) : base(pointer) { }

        // NameProperty AkAudio.AkParamGroup.SetNameParameter.Key
        // 0x0 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // NameProperty AkAudio.AkParamGroup.SetNameParameter.Value
        // 0x8 (0x8)
        // (Param)
        public FName Value {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 8, 8);
        }
    }
    private static UFunction _ptrSetNameParameter;
    public void SetNameParameter(FName Key, FName Value) {
        _ptrSetNameParameter ??= FindFunction("Function AkAudio.AkParamGroup.SetNameParameter");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Value.Pointer, @params + 8, 8, 8);

        _ptrSetNameParameter.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetNameParameter, @params);
        _ptrSetNameParameter.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkParamGroup.GetDebugData
    // 0xD0D020
    // (Final | Native | Public | HasOutParams | K2Call)
    public unsafe class GetDebugData_Parameters : BaseObject {
        public GetDebugData_Parameters() { }
        public GetDebugData_Parameters(nint pointer) : base(pointer) { }

        // ArrayProperty AkAudio.AkParamGroup.GetDebugData.RTCPKeys
        // 0x0 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public StructTArray<FName> RTCPKeys {
            get => new(Pointer, 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ArrayProperty AkAudio.AkParamGroup.GetDebugData.RTCPValues
        // 0x10 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public UnmanagedTArray<float> RTCPValues {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // ArrayProperty AkAudio.AkParamGroup.GetDebugData.SwitchKeys
        // 0x20 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public StructTArray<FName> SwitchKeys {
            get => new(Pointer + 32, 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 32), 16, 16);
        }

        // ArrayProperty AkAudio.AkParamGroup.GetDebugData.SwitchValues
        // 0x30 (0x10)
        // (Param | OutParam | NeedCtorLink)
        public StructTArray<FName> SwitchValues {
            get => new(Pointer + 48, 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 48), 16, 16);
        }
    }
    private static UFunction _ptrGetDebugData;
    public void GetDebugData(ref StructTArray<FName> RTCPKeys, ref UnmanagedTArray<float> RTCPValues, ref StructTArray<FName> SwitchKeys, ref StructTArray<FName> SwitchValues) {
        _ptrGetDebugData ??= FindFunction("Function AkAudio.AkParamGroup.GetDebugData");

        var @params = stackalloc byte[64];
        System.Buffer.MemoryCopy((void*)RTCPKeys.Pointer, @params, 16, 16);
        System.Buffer.MemoryCopy((void*)RTCPValues.Pointer, @params + 16, 16, 16);
        System.Buffer.MemoryCopy((void*)SwitchKeys.Pointer, @params + 32, 16, 16);
        System.Buffer.MemoryCopy((void*)SwitchValues.Pointer, @params + 48, 16, 16);

        _ptrGetDebugData.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrGetDebugData, @params);
        _ptrGetDebugData.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _RTCPKeysPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params, (void*)_RTCPKeysPtr, 16, 16);
        RTCPKeys = new(_RTCPKeysPtr, 8) { Allocated = true };
        var _RTCPValuesPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 16, (void*)_RTCPValuesPtr, 16, 16);
        RTCPValues = new(_RTCPValuesPtr) { Allocated = true };
        var _SwitchKeysPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 32, (void*)_SwitchKeysPtr, 16, 16);
        SwitchKeys = new(_SwitchKeysPtr, 8) { Allocated = true };
        var _SwitchValuesPtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 48, (void*)_SwitchValuesPtr, 16, 16);
        SwitchValues = new(_SwitchValuesPtr, 8) { Allocated = true };
    }

    // Function AkAudio.AkParamGroup.StopSound
    // 0xD0CF90
    // (Final | Native | Public | K2Call)
    public unsafe class StopSound_Parameters : BaseObject {
        public StopSound_Parameters() { }
        public StopSound_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkParamGroup.StopSound.Sound
        // 0x0 (0x8)
        // (Param)
        public UAkSoundCue Sound {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrStopSound;
    public void StopSound(UAkSoundCue Sound) {
        _ptrStopSound ??= FindFunction("Function AkAudio.AkParamGroup.StopSound");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy((void*)Sound.Pointer, @params, 8, 8);

        _ptrStopSound.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrStopSound, @params);
        _ptrStopSound.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkParamGroup.PlaySound
    // 0xD0CE30
    // (Final | Native | HasOptionalParams | Public | K2Call)
    public unsafe class PlaySound_Parameters : BaseObject {
        public PlaySound_Parameters() { }
        public PlaySound_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkParamGroup.PlaySound.Sound
        // 0x0 (0x8)
        // (Param)
        public UAkSoundCue Sound {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // StructProperty AkAudio.AkParamGroup.PlaySound.Translation
        // 0x8 (0xC)
        // (OptionalParam | Param)
        public FVector Translation {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 12, 12);
        }

        // StructProperty AkAudio.AkParamGroup.PlaySound.Rotation
        // 0x14 (0xC)
        // (OptionalParam | Param)
        public FRotator Rotation {
            get => new(Pointer + 20);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 20), 12, 12);
        }

        // ComponentProperty AkAudio.AkParamGroup.PlaySound.ReturnValue
        // 0x20 (0x8)
        // (Param | OutParam | ReturnParam | EditInline)
        public UAkSoundSource ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 32);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 32) = value.Pointer;
        }
    }
    private static UFunction _ptrPlaySound;
    public UAkSoundSource PlaySound(UAkSoundCue Sound, FVector Translation = null, FRotator Rotation = null) {
        _ptrPlaySound ??= FindFunction("Function AkAudio.AkParamGroup.PlaySound");

        var @params = stackalloc byte[40];
        System.Buffer.MemoryCopy((void*)Sound.Pointer, @params, 8, 8);
        if (Translation != null) System.Buffer.MemoryCopy((void*)Translation.Pointer, @params + 8, 12, 12);
        if (Rotation != null) System.Buffer.MemoryCopy((void*)Rotation.Pointer, @params + 20, 12, 12);

        _ptrPlaySound.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrPlaySound, @params);
        _ptrPlaySound.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)(@params + 32));
    }

    // Function AkAudio.AkParamGroup.SetSwitch
    // 0xD0CD80
    // (Final | Native | Public | K2Call)
    public unsafe class SetSwitch_Parameters : BaseObject {
        public SetSwitch_Parameters() { }
        public SetSwitch_Parameters(nint pointer) : base(pointer) { }

        // NameProperty AkAudio.AkParamGroup.SetSwitch.Key
        // 0x0 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // NameProperty AkAudio.AkParamGroup.SetSwitch.Value
        // 0x8 (0x8)
        // (Param)
        public FName Value {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 8, 8);
        }
    }
    private static UFunction _ptrSetSwitch;
    public void SetSwitch(FName Key, FName Value) {
        _ptrSetSwitch ??= FindFunction("Function AkAudio.AkParamGroup.SetSwitch");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Value.Pointer, @params + 8, 8, 8);

        _ptrSetSwitch.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetSwitch, @params);
        _ptrSetSwitch.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkParamGroup.SetRTCP
    // 0xD0CCC0
    // (Final | Native | Public | K2Call)
    public unsafe class SetRTCP_Parameters : BaseObject {
        public SetRTCP_Parameters() { }
        public SetRTCP_Parameters(nint pointer) : base(pointer) { }

        // NameProperty AkAudio.AkParamGroup.SetRTCP.Key
        // 0x0 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // FloatProperty AkAudio.AkParamGroup.SetRTCP.Value
        // 0x8 (0x4)
        // (Param)
        public float Value {
            get => *(float*)(Pointer + 8);
            set => *(float*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrSetRTCP;
    public void SetRTCP(FName Key, float Value) {
        _ptrSetRTCP ??= FindFunction("Function AkAudio.AkParamGroup.SetRTCP");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&Value, @params + 8, 4, 4);

        _ptrSetRTCP.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetRTCP, @params);
        _ptrSetRTCP.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }


    // ScriptStruct AkAudio.AkParamGroup.AkParamSet
    // 0xA0
    public unsafe class FAkParamSet : BaseObject {
        public FAkParamSet() {
            Pointer = Marshal.AllocHGlobal(160);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 160);
            Allocated = true;
        }
        public FAkParamSet(nint pointer) : base(pointer) { }

        // StructProperty AkAudio.AkParamGroup.AkParamSet.RTCPs
        // 0x0 (0x50)
        // (Const | Native)
        public FMap_Mirror RTCPs {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 80, 80);
        }

        // StructProperty AkAudio.AkParamGroup.AkParamSet.Switches
        // 0x50 (0x50)
        // (Const | Native)
        public FMap_Mirror Switches {
            get => new(Pointer + 80);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 80), 80, 80);
        }
    }


    // Enum AkAudio.AkParamGroup.EAttenuationType
    public enum EAttenuationType : byte {
        AttenuationType_Default = 0,
        AttenuationType_None = 1,
        AttenuationType_MAX = 2
    }

    // Enum AkAudio.AkParamGroup.EReflectionSendType
    public enum EReflectionSendType : byte {
        ReflectionSendType_None = 0,
        ReflectionSendType_Slapback = 1,
        ReflectionSendType_ArenaReverb = 2,
        ReflectionSendType_MAX = 3
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.AkParamGroup");
            return _staticClass;
        }
    }
}

// Class AkAudio.AkPlaySoundComponent
// 0xFB (0x9D - 0x198)
// (Compiled | Parsed | Native | EditInlineNew | Hidden)
public unsafe partial class UAkPlaySoundComponent : UActorComponent {
    public UAkPlaySoundComponent() { }
    public UAkPlaySoundComponent(nint pointer) : base(pointer) { }


    // MISSED OFFSET: 0x3

    // StructProperty AkAudio.AkPlaySoundComponent.VfTable_IISetParameter
    // 0xA0 (0x8)
    // (Const | Native | NoExport)
    public nint VfTable_IISetParameter {
        get => *(nint*)(Pointer + 160);
        set => *(nint*)(Pointer + 160) = value;
    }

    // ObjectProperty AkAudio.AkPlaySoundComponent.SoundCue
    // 0xA8 (0x8)
    // (Edit)
    public UAkSoundCue SoundCue {
        get {
            var pointer = *(nint*)(Pointer + 168);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 168) = value.Pointer;
    }

    // BoolProperty AkAudio.AkPlaySoundComponent.bAutoPlay
    // 0xB0 (0x4)
    // Bitmask: 0x00000001
    // (Edit)
    public bool bAutoPlay {
        get => (*(uint*)(Pointer + 176) & 0x1) != 0;
        set {
            if (value) *(uint*)(Pointer + 176) |= 0x1;
            else *(uint*)(Pointer + 176) &= ~(uint)0x1;
        }
    }

    // BoolProperty AkAudio.AkPlaySoundComponent.bKillSoundOnDetach
    // 0xB0 (0x4)
    // Bitmask: 0x00000002
    // (Edit)
    public bool bKillSoundOnDetach {
        get => (*(uint*)(Pointer + 176) & 0x2) != 0;
        set {
            if (value) *(uint*)(Pointer + 176) |= 0x2;
            else *(uint*)(Pointer + 176) &= ~(uint)0x2;
        }
    }

    // BoolProperty AkAudio.AkPlaySoundComponent.bWasAttached
    // 0xB0 (0x4)
    // Bitmask: 0x00000004
    // (Const | Transient)
    public bool bWasAttached {
        get => (*(uint*)(Pointer + 176) & 0x4) != 0;
        set {
            if (value) *(uint*)(Pointer + 176) |= 0x4;
            else *(uint*)(Pointer + 176) &= ~(uint)0x4;
        }
    }

    // StructProperty AkAudio.AkPlaySoundComponent.Translation
    // 0xB4 (0xC)
    // (Edit | Const)
    public FVector Translation {
        get => new(Pointer + 180);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 180), 12, 12);
    }

    // StructProperty AkAudio.AkPlaySoundComponent.Rotation
    // 0xC0 (0xC)
    // (Edit | Const)
    public FRotator Rotation {
        get => new(Pointer + 192);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 192), 12, 12);
    }

    // FloatProperty AkAudio.AkPlaySoundComponent.ReFireDelay
    // 0xCC (0x4)
    // (Edit)
    public float ReFireDelay {
        get => *(float*)(Pointer + 204);
        set => *(float*)(Pointer + 204) = value;
    }

    // ByteProperty AkAudio.AkPlaySoundComponent.Receiver
    // 0xD0 (0x1)
    // (Edit)
    public EAkPlaySoundReceiver Receiver {
        get => *(EAkPlaySoundReceiver*)(Pointer + 208);
        set => *(EAkPlaySoundReceiver*)(Pointer + 208) = value;
    }

    // MISSED OFFSET: 0x7

    // ArrayProperty AkAudio.AkPlaySoundComponent.RestartSwitches
    // 0xD8 (0x10)
    // (Edit | NeedCtorLink)
    public StructTArray<FName> RestartSwitches {
        get => new(Pointer + 216, 8);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 216), 16, 16);
    }

    // ComponentProperty AkAudio.AkPlaySoundComponent.SoundSource
    // 0xE8 (0x8)
    // (Const | ExportObject | Transient | Component | EditInline)
    public UAkSoundSource SoundSource {
        get {
            var pointer = *(nint*)(Pointer + 232);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 232) = value.Pointer;
    }

    // FloatProperty AkAudio.AkPlaySoundComponent.LastPlayTime
    // 0xF0 (0x4)
    // (Const | Transient)
    public float LastPlayTime {
        get => *(float*)(Pointer + 240);
        set => *(float*)(Pointer + 240) = value;
    }

    // MISSED OFFSET: 0x4

    // StructProperty AkAudio.AkPlaySoundComponent.StoredParameters
    // 0xF8 (0xA0)
    // (Const | Transient)
    public UAkParamGroup.FAkParamSet StoredParameters {
        get => new(Pointer + 248);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 248), 160, 160);
    }


    // Function AkAudio.AkPlaySoundComponent.SetActorParameter
    // 0xD0D590
    // (Final | Native | Public)
    public unsafe class SetActorParameter_Parameters : BaseObject {
        public SetActorParameter_Parameters() { }
        public SetActorParameter_Parameters(nint pointer) : base(pointer) { }

        // NameProperty AkAudio.AkPlaySoundComponent.SetActorParameter.Key
        // 0x0 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // ObjectProperty AkAudio.AkPlaySoundComponent.SetActorParameter.Value
        // 0x8 (0x8)
        // (Param)
        public AActor Value {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }
    }
    private static UFunction _ptrSetActorParameter;
    public void SetActorParameter(FName Key, AActor Value) {
        _ptrSetActorParameter ??= FindFunction("Function AkAudio.AkPlaySoundComponent.SetActorParameter");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Value.Pointer, @params + 8, 8, 8);

        _ptrSetActorParameter.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetActorParameter, @params);
        _ptrSetActorParameter.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkPlaySoundComponent.SetLinearColorParameter
    // 0xD0D4D0
    // (Final | Native | Public)
    public unsafe class SetLinearColorParameter_Parameters : BaseObject {
        public SetLinearColorParameter_Parameters() { }
        public SetLinearColorParameter_Parameters(nint pointer) : base(pointer) { }

        // NameProperty AkAudio.AkPlaySoundComponent.SetLinearColorParameter.Key
        // 0x0 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // StructProperty AkAudio.AkPlaySoundComponent.SetLinearColorParameter.Value
        // 0x8 (0x10)
        // (Param)
        public FLinearColor Value {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 16, 16);
        }
    }
    private static UFunction _ptrSetLinearColorParameter;
    public void SetLinearColorParameter(FName Key, FLinearColor Value) {
        _ptrSetLinearColorParameter ??= FindFunction("Function AkAudio.AkPlaySoundComponent.SetLinearColorParameter");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Value.Pointer, @params + 8, 16, 16);

        _ptrSetLinearColorParameter.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetLinearColorParameter, @params);
        _ptrSetLinearColorParameter.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkPlaySoundComponent.SetVectorParameter
    // 0xD0D400
    // (Final | Native | Public)
    public unsafe class SetVectorParameter_Parameters : BaseObject {
        public SetVectorParameter_Parameters() { }
        public SetVectorParameter_Parameters(nint pointer) : base(pointer) { }

        // NameProperty AkAudio.AkPlaySoundComponent.SetVectorParameter.Key
        // 0x0 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // StructProperty AkAudio.AkPlaySoundComponent.SetVectorParameter.Value
        // 0x8 (0xC)
        // (Param)
        public FVector Value {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 12, 12);
        }
    }
    private static UFunction _ptrSetVectorParameter;
    public void SetVectorParameter(FName Key, FVector Value) {
        _ptrSetVectorParameter ??= FindFunction("Function AkAudio.AkPlaySoundComponent.SetVectorParameter");

        var @params = stackalloc byte[20];
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Value.Pointer, @params + 8, 12, 12);

        _ptrSetVectorParameter.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetVectorParameter, @params);
        _ptrSetVectorParameter.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkPlaySoundComponent.SetFloatParameter
    // 0xD0D340
    // (Final | Native | Public)
    public unsafe class SetFloatParameter_Parameters : BaseObject {
        public SetFloatParameter_Parameters() { }
        public SetFloatParameter_Parameters(nint pointer) : base(pointer) { }

        // NameProperty AkAudio.AkPlaySoundComponent.SetFloatParameter.Key
        // 0x0 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // FloatProperty AkAudio.AkPlaySoundComponent.SetFloatParameter.Value
        // 0x8 (0x4)
        // (Param)
        public float Value {
            get => *(float*)(Pointer + 8);
            set => *(float*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrSetFloatParameter;
    public void SetFloatParameter(FName Key, float Value) {
        _ptrSetFloatParameter ??= FindFunction("Function AkAudio.AkPlaySoundComponent.SetFloatParameter");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&Value, @params + 8, 4, 4);

        _ptrSetFloatParameter.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetFloatParameter, @params);
        _ptrSetFloatParameter.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkPlaySoundComponent.SetNameParameter
    // 0xD0D290
    // (Final | Native | Public)
    public unsafe class SetNameParameter_Parameters : BaseObject {
        public SetNameParameter_Parameters() { }
        public SetNameParameter_Parameters(nint pointer) : base(pointer) { }

        // NameProperty AkAudio.AkPlaySoundComponent.SetNameParameter.Key
        // 0x0 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // NameProperty AkAudio.AkPlaySoundComponent.SetNameParameter.Value
        // 0x8 (0x8)
        // (Param)
        public FName Value {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 8, 8);
        }
    }
    private static UFunction _ptrSetNameParameter;
    public void SetNameParameter(FName Key, FName Value) {
        _ptrSetNameParameter ??= FindFunction("Function AkAudio.AkPlaySoundComponent.SetNameParameter");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Value.Pointer, @params + 8, 8, 8);

        _ptrSetNameParameter.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetNameParameter, @params);
        _ptrSetNameParameter.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkPlaySoundComponent.SetRTCP
    // 0xD0FBC0
    // (Final | Native | Public)
    public unsafe class SetRTCP_Parameters : BaseObject {
        public SetRTCP_Parameters() { }
        public SetRTCP_Parameters(nint pointer) : base(pointer) { }

        // NameProperty AkAudio.AkPlaySoundComponent.SetRTCP.Key
        // 0x0 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // FloatProperty AkAudio.AkPlaySoundComponent.SetRTCP.Value
        // 0x8 (0x4)
        // (Param)
        public float Value {
            get => *(float*)(Pointer + 8);
            set => *(float*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrSetRTCP;
    public void SetRTCP(FName Key, float Value) {
        _ptrSetRTCP ??= FindFunction("Function AkAudio.AkPlaySoundComponent.SetRTCP");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&Value, @params + 8, 4, 4);

        _ptrSetRTCP.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetRTCP, @params);
        _ptrSetRTCP.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkPlaySoundComponent.SetSwitch
    // 0xD0FB10
    // (Final | Native | Public)
    public unsafe class SetSwitch_Parameters : BaseObject {
        public SetSwitch_Parameters() { }
        public SetSwitch_Parameters(nint pointer) : base(pointer) { }

        // NameProperty AkAudio.AkPlaySoundComponent.SetSwitch.Key
        // 0x0 (0x8)
        // (Param)
        public FName Key {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // NameProperty AkAudio.AkPlaySoundComponent.SetSwitch.Value
        // 0x8 (0x8)
        // (Param)
        public FName Value {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 8, 8);
        }
    }
    private static UFunction _ptrSetSwitch;
    public void SetSwitch(FName Key, FName Value) {
        _ptrSetSwitch ??= FindFunction("Function AkAudio.AkPlaySoundComponent.SetSwitch");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)Key.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy((void*)Value.Pointer, @params + 8, 8, 8);

        _ptrSetSwitch.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetSwitch, @params);
        _ptrSetSwitch.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkPlaySoundComponent.IsPlaying
    // 0xD0FA70
    // (Final | Native | Public)
    public unsafe class IsPlaying_Parameters : BaseObject {
        public IsPlaying_Parameters() { }
        public IsPlaying_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty AkAudio.AkPlaySoundComponent.IsPlaying.ReturnValue
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
    private static UFunction _ptrIsPlaying;
    public bool IsPlaying() {
        _ptrIsPlaying ??= FindFunction("Function AkAudio.AkPlaySoundComponent.IsPlaying");

        var @params = stackalloc byte[4];

        _ptrIsPlaying.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrIsPlaying, @params);
        _ptrIsPlaying.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)@params;
    }

    // Function AkAudio.AkPlaySoundComponent.Stop
    // 0xD0FA00
    // (Final | Native | Public)
    public unsafe class Stop_Parameters : BaseObject {
        public Stop_Parameters() { }
        public Stop_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrStop;
    public void Stop() {
        _ptrStop ??= FindFunction("Function AkAudio.AkPlaySoundComponent.Stop");

        _ptrStop.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrStop, null);
        _ptrStop.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkPlaySoundComponent.Play
    // 0xD0F9C0
    // (Final | Native | Public)
    public unsafe class Play_Parameters : BaseObject {
        public Play_Parameters() { }
        public Play_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrPlay;
    public void Play() {
        _ptrPlay ??= FindFunction("Function AkAudio.AkPlaySoundComponent.Play");

        _ptrPlay.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrPlay, null);
        _ptrPlay.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }


    // Enum AkAudio.AkPlaySoundComponent.EAkPlaySoundReceiver
    public enum EAkPlaySoundReceiver : byte {
        PlaySoundReceiver_All = 0,
        PlaySoundReceiver_Local = 1,
        PlaySoundReceiver_NonLocal = 2,
        PlaySoundReceiver_MAX = 3
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.AkPlaySoundComponent");
            return _staticClass;
        }
    }
}

// Class AkAudio.AkRevPhysicsSimulation
// 0x50 (0x60 - 0xB0)
// (Compiled | Parsed | Native)
public unsafe partial class UAkRevPhysicsSimulation : UObject {
    public UAkRevPhysicsSimulation() { }
    public UAkRevPhysicsSimulation(nint pointer) : base(pointer) { }


    // FloatProperty AkAudio.AkRevPhysicsSimulation.EngineGearRatio
    // 0x60 (0x4)
    // (Edit)
    public float EngineGearRatio {
        get => *(float*)(Pointer + 96);
        set => *(float*)(Pointer + 96) = value;
    }

    // FloatProperty AkAudio.AkRevPhysicsSimulation.EngineFriction
    // 0x64 (0x4)
    // (Edit)
    public float EngineFriction {
        get => *(float*)(Pointer + 100);
        set => *(float*)(Pointer + 100) = value;
    }

    // FloatProperty AkAudio.AkRevPhysicsSimulation.GroundFriction
    // 0x68 (0x4)
    // (Edit)
    public float GroundFriction {
        get => *(float*)(Pointer + 104);
        set => *(float*)(Pointer + 104) = value;
    }

    // FloatProperty AkAudio.AkRevPhysicsSimulation.WindResistancePerVelocity
    // 0x6C (0x4)
    // (Edit)
    public float WindResistancePerVelocity {
        get => *(float*)(Pointer + 108);
        set => *(float*)(Pointer + 108) = value;
    }

    // FloatProperty AkAudio.AkRevPhysicsSimulation.UpShiftingRPM
    // 0x70 (0x4)
    // (Edit)
    public float UpShiftingRPM {
        get => *(float*)(Pointer + 112);
        set => *(float*)(Pointer + 112) = value;
    }

    // FloatProperty AkAudio.AkRevPhysicsSimulation.DownShiftRPM
    // 0x74 (0x4)
    // (Edit)
    public float DownShiftRPM {
        get => *(float*)(Pointer + 116);
        set => *(float*)(Pointer + 116) = value;
    }

    // FloatProperty AkAudio.AkRevPhysicsSimulation.InfiniteGearRatioDecreaseAmount
    // 0x78 (0x4)
    // (Edit)
    public float InfiniteGearRatioDecreaseAmount {
        get => *(float*)(Pointer + 120);
        set => *(float*)(Pointer + 120) = value;
    }

    // FloatProperty AkAudio.AkRevPhysicsSimulation.ThrottleInterpolationTime
    // 0x7C (0x4)
    // (Edit)
    public float ThrottleInterpolationTime {
        get => *(float*)(Pointer + 124);
        set => *(float*)(Pointer + 124) = value;
    }

    // FloatProperty AkAudio.AkRevPhysicsSimulation.EngineTorque
    // 0x80 (0x4)
    // (Transient)
    public float EngineTorque {
        get => *(float*)(Pointer + 128);
        set => *(float*)(Pointer + 128) = value;
    }

    // FloatProperty AkAudio.AkRevPhysicsSimulation.BrakingForce
    // 0x84 (0x4)
    // (Transient)
    public float BrakingForce {
        get => *(float*)(Pointer + 132);
        set => *(float*)(Pointer + 132) = value;
    }

    // FloatProperty AkAudio.AkRevPhysicsSimulation.WindResistance
    // 0x88 (0x4)
    // (Transient)
    public float WindResistance {
        get => *(float*)(Pointer + 136);
        set => *(float*)(Pointer + 136) = value;
    }

    // FloatProperty AkAudio.AkRevPhysicsSimulation.FrictionResistance
    // 0x8C (0x4)
    // (Transient)
    public float FrictionResistance {
        get => *(float*)(Pointer + 140);
        set => *(float*)(Pointer + 140) = value;
    }

    // FloatProperty AkAudio.AkRevPhysicsSimulation.EngineResistance
    // 0x90 (0x4)
    // (Transient)
    public float EngineResistance {
        get => *(float*)(Pointer + 144);
        set => *(float*)(Pointer + 144) = value;
    }

    // FloatProperty AkAudio.AkRevPhysicsSimulation.NetForce
    // 0x94 (0x4)
    // (Transient)
    public float NetForce {
        get => *(float*)(Pointer + 148);
        set => *(float*)(Pointer + 148) = value;
    }

    // DelegateProperty AkAudio.AkRevPhysicsSimulation.__EventGearChange__Delegate
    // 0x98 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventGearChange__Delegate {
        get => new(Pointer + 152);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 152), 24, 24);
    }


    // Function AkAudio.AkRevPhysicsSimulation.PrintDebugInfo
    // 0x3750E0
    // (Defined | Simulated | Public)
    public unsafe class PrintDebugInfo_Parameters : BaseObject {
        public PrintDebugInfo_Parameters() { }
        public PrintDebugInfo_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkRevPhysicsSimulation.PrintDebugInfo.Drawer
        // 0x0 (0x8)
        // (Param)
        public UDebugDrawer Drawer {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrPrintDebugInfo;
    public void PrintDebugInfo(UDebugDrawer Drawer) {
        _ptrPrintDebugInfo ??= FindFunction("Function AkAudio.AkRevPhysicsSimulation.PrintDebugInfo");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy((void*)Drawer.Pointer, @params, 8, 8);

        ProcessEvent(_ptrPrintDebugInfo, @params);
    }

    // Function AkAudio.AkRevPhysicsSimulation.InterpGearRatio
    // 0xD10060
    // (Final | Native | Static | Public | HasOutParams)
    public unsafe class InterpGearRatio_Parameters : BaseObject {
        public InterpGearRatio_Parameters() { }
        public InterpGearRatio_Parameters(nint pointer) : base(pointer) { }

        // StructProperty AkAudio.AkRevPhysicsSimulation.InterpGearRatio.SimUpdate
        // 0x0 (0x48)
        // (Const | Param | OutParam | NeedCtorLink)
        public FAkRevSimUpdateParams SimUpdate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // IntProperty AkAudio.AkRevPhysicsSimulation.InterpGearRatio.Gear
        // 0x48 (0x4)
        // (Param)
        public int Gear {
            get => *(int*)(Pointer + 72);
            set => *(int*)(Pointer + 72) = value;
        }

        // FloatProperty AkAudio.AkRevPhysicsSimulation.InterpGearRatio.ReturnValue
        // 0x4C (0x4)
        // (Param | OutParam | ReturnParam)
        public float ReturnValue {
            get => *(float*)(Pointer + 76);
            set => *(float*)(Pointer + 76) = value;
        }
    }
    private static UFunction _ptrInterpGearRatio;
    public static float InterpGearRatio(ref FAkRevSimUpdateParams SimUpdate, int Gear) {
        _ptrInterpGearRatio ??= FindFunction("Function AkAudio.AkRevPhysicsSimulation.InterpGearRatio");

        var @params = stackalloc byte[80];
        System.Buffer.MemoryCopy((void*)SimUpdate.Pointer, @params, 72, 72);
        System.Buffer.MemoryCopy(&Gear, @params + 72, 4, 4);

        _ptrInterpGearRatio.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrInterpGearRatio, @params);
        _ptrInterpGearRatio.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _SimUpdatePtr = Marshal.AllocHGlobal(72);
        System.Buffer.MemoryCopy(@params, (void*)_SimUpdatePtr, 72, 72);
        SimUpdate = new(_SimUpdatePtr) { Allocated = true };

        return *(float*)(@params + 76);
    }

    // Function AkAudio.AkRevPhysicsSimulation.GetGearRatio
    // 0xD0FF60
    // (Final | Native | Static | Public | HasOutParams)
    public unsafe class GetGearRatio_Parameters : BaseObject {
        public GetGearRatio_Parameters() { }
        public GetGearRatio_Parameters(nint pointer) : base(pointer) { }

        // StructProperty AkAudio.AkRevPhysicsSimulation.GetGearRatio.SimUpdate
        // 0x0 (0x48)
        // (Const | Param | OutParam | NeedCtorLink)
        public FAkRevSimUpdateParams SimUpdate {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 72, 72);
        }

        // FloatProperty AkAudio.AkRevPhysicsSimulation.GetGearRatio.ReturnValue
        // 0x48 (0x4)
        // (Param | OutParam | ReturnParam)
        public float ReturnValue {
            get => *(float*)(Pointer + 72);
            set => *(float*)(Pointer + 72) = value;
        }
    }
    private static UFunction _ptrGetGearRatio;
    public static float GetGearRatio(ref FAkRevSimUpdateParams SimUpdate) {
        _ptrGetGearRatio ??= FindFunction("Function AkAudio.AkRevPhysicsSimulation.GetGearRatio");

        var @params = stackalloc byte[76];
        System.Buffer.MemoryCopy((void*)SimUpdate.Pointer, @params, 72, 72);

        _ptrGetGearRatio.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrGetGearRatio, @params);
        _ptrGetGearRatio.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _SimUpdatePtr = Marshal.AllocHGlobal(72);
        System.Buffer.MemoryCopy(@params, (void*)_SimUpdatePtr, 72, 72);
        SimUpdate = new(_SimUpdatePtr) { Allocated = true };

        return *(float*)(@params + 72);
    }

    // Function AkAudio.AkRevPhysicsSimulation.CalcVelocity
    // 0xD0FEB0
    // (Final | Native | Public)
    public unsafe class CalcVelocity_Parameters : BaseObject {
        public CalcVelocity_Parameters() { }
        public CalcVelocity_Parameters(nint pointer) : base(pointer) { }

        // FloatProperty AkAudio.AkRevPhysicsSimulation.CalcVelocity.GearRatio
        // 0x0 (0x4)
        // (Param)
        public float GearRatio {
            get => *(float*)Pointer;
            set => *(float*)Pointer = value;
        }

        // FloatProperty AkAudio.AkRevPhysicsSimulation.CalcVelocity.RPM
        // 0x4 (0x4)
        // (Param)
        public float RPM {
            get => *(float*)(Pointer + 4);
            set => *(float*)(Pointer + 4) = value;
        }

        // FloatProperty AkAudio.AkRevPhysicsSimulation.CalcVelocity.ReturnValue
        // 0x8 (0x4)
        // (Param | OutParam | ReturnParam)
        public float ReturnValue {
            get => *(float*)(Pointer + 8);
            set => *(float*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrCalcVelocity;
    public float CalcVelocity(float GearRatio, float RPM) {
        _ptrCalcVelocity ??= FindFunction("Function AkAudio.AkRevPhysicsSimulation.CalcVelocity");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy(&GearRatio, @params, 4, 4);
        System.Buffer.MemoryCopy(&RPM, @params + 4, 4, 4);

        _ptrCalcVelocity.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrCalcVelocity, @params);
        _ptrCalcVelocity.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(float*)(@params + 8);
    }

    // Function AkAudio.AkRevPhysicsSimulation.CalcRPM
    // 0xD0FE00
    // (Final | Native | Public)
    public unsafe class CalcRPM_Parameters : BaseObject {
        public CalcRPM_Parameters() { }
        public CalcRPM_Parameters(nint pointer) : base(pointer) { }

        // FloatProperty AkAudio.AkRevPhysicsSimulation.CalcRPM.GearRatio
        // 0x0 (0x4)
        // (Param)
        public float GearRatio {
            get => *(float*)Pointer;
            set => *(float*)Pointer = value;
        }

        // FloatProperty AkAudio.AkRevPhysicsSimulation.CalcRPM.Velocity
        // 0x4 (0x4)
        // (Param)
        public float Velocity {
            get => *(float*)(Pointer + 4);
            set => *(float*)(Pointer + 4) = value;
        }

        // FloatProperty AkAudio.AkRevPhysicsSimulation.CalcRPM.ReturnValue
        // 0x8 (0x4)
        // (Param | OutParam | ReturnParam)
        public float ReturnValue {
            get => *(float*)(Pointer + 8);
            set => *(float*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrCalcRPM;
    public float CalcRPM(float GearRatio, float Velocity) {
        _ptrCalcRPM ??= FindFunction("Function AkAudio.AkRevPhysicsSimulation.CalcRPM");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy(&GearRatio, @params, 4, 4);
        System.Buffer.MemoryCopy(&Velocity, @params + 4, 4, 4);

        _ptrCalcRPM.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrCalcRPM, @params);
        _ptrCalcRPM.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(float*)(@params + 8);
    }

    // Function AkAudio.AkRevPhysicsSimulation.Step
    // 0xD0FCB0
    // (Final | Native | Public | HasOutParams)
    public unsafe class Step_Parameters : BaseObject {
        public Step_Parameters() { }
        public Step_Parameters(nint pointer) : base(pointer) { }

        // FloatProperty AkAudio.AkRevPhysicsSimulation.Step.DeltaTime
        // 0x0 (0x4)
        // (Param)
        public float DeltaTime {
            get => *(float*)Pointer;
            set => *(float*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // StructProperty AkAudio.AkRevPhysicsSimulation.Step.Params
        // 0x8 (0x48)
        // (Const | Param | OutParam | NeedCtorLink)
        public FAkRevSimUpdateParams Params {
            get => new(Pointer + 8);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 8), 72, 72);
        }

        // StructProperty AkAudio.AkRevPhysicsSimulation.Step.ReturnValue
        // 0x50 (0x10)
        // (Param | OutParam | ReturnParam)
        public FAkRevSimFrame ReturnValue {
            get => new(Pointer + 80);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 80), 16, 16);
        }
    }
    private static UFunction _ptrStep;
    public FAkRevSimFrame Step(float DeltaTime, ref FAkRevSimUpdateParams Params) {
        _ptrStep ??= FindFunction("Function AkAudio.AkRevPhysicsSimulation.Step");

        var @params = stackalloc byte[92];
        System.Buffer.MemoryCopy(&DeltaTime, @params, 4, 4);
        System.Buffer.MemoryCopy((void*)Params.Pointer, @params + 8, 72, 72);

        _ptrStep.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrStep, @params);
        _ptrStep.FunctionFlags |= (ulong)EFunctionFlags.Native;

        var _ParamsPtr = Marshal.AllocHGlobal(72);
        System.Buffer.MemoryCopy(@params + 8, (void*)_ParamsPtr, 72, 72);
        Params = new(_ParamsPtr) { Allocated = true };

        var _ReturnValuePtr = Marshal.AllocHGlobal(16);
        System.Buffer.MemoryCopy(@params + 80, (void*)_ReturnValuePtr, 16, 16);
        return new(_ReturnValuePtr) { Allocated = true };
    }

    // Function AkAudio.AkRevPhysicsSimulation.EventGearChange
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventGearChange_Parameters : BaseObject {
        public EventGearChange_Parameters() { }
        public EventGearChange_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkRevPhysicsSimulation.EventGearChange.Simulation
        // 0x0 (0x8)
        // (Param)
        public UAkRevPhysicsSimulation Simulation {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrEventGearChange;
    public void EventGearChange(UAkRevPhysicsSimulation Simulation) {
        _ptrEventGearChange ??= FindFunction("Function AkAudio.AkRevPhysicsSimulation.EventGearChange");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy((void*)Simulation.Pointer, @params, 8, 8);

        ProcessEvent(_ptrEventGearChange, @params);
    }


    // ScriptStruct AkAudio.AkRevPhysicsSimulation.AkRevSimUpdateParams
    // 0x48
    public unsafe class FAkRevSimUpdateParams : BaseObject {
        public FAkRevSimUpdateParams() {
            Pointer = Marshal.AllocHGlobal(72);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 72);
            Allocated = true;
        }
        public FAkRevSimUpdateParams(nint pointer) : base(pointer) { }

        // FloatProperty AkAudio.AkRevPhysicsSimulation.AkRevSimUpdateParams.Throttle
        // 0x0 (0x4)
        public float Throttle {
            get => *(float*)Pointer;
            set => *(float*)Pointer = value;
        }

        // FloatProperty AkAudio.AkRevPhysicsSimulation.AkRevSimUpdateParams.Brake
        // 0x4 (0x4)
        public float Brake {
            get => *(float*)(Pointer + 4);
            set => *(float*)(Pointer + 4) = value;
        }

        // FloatProperty AkAudio.AkRevPhysicsSimulation.AkRevSimUpdateParams.EngineFrictionScale
        // 0x8 (0x4)
        public float EngineFrictionScale {
            get => *(float*)(Pointer + 8);
            set => *(float*)(Pointer + 8) = value;
        }

        // FloatProperty AkAudio.AkRevPhysicsSimulation.AkRevSimUpdateParams.GroundFrictionScale
        // 0xC (0x4)
        public float GroundFrictionScale {
            get => *(float*)(Pointer + 12);
            set => *(float*)(Pointer + 12) = value;
        }

        // FloatProperty AkAudio.AkRevPhysicsSimulation.AkRevSimUpdateParams.ClutchedGearRatio
        // 0x10 (0x4)
        public float ClutchedGearRatio {
            get => *(float*)(Pointer + 16);
            set => *(float*)(Pointer + 16) = value;
        }

        // BoolProperty AkAudio.AkRevPhysicsSimulation.AkRevSimUpdateParams.bEnableUpShifting
        // 0x14 (0x4)
        // Bitmask: 0x00000001
        public bool bEnableUpShifting {
            get => (*(uint*)(Pointer + 20) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 20) |= 0x1;
                else *(uint*)(Pointer + 20) &= ~(uint)0x1;
            }
        }

        // StructProperty AkAudio.AkRevPhysicsSimulation.AkRevSimUpdateParams.Controls
        // 0x18 (0x20)
        // (NeedCtorLink)
        public FAkRevSimPhysicsControls Controls {
            get => new(Pointer + 24);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 24), 32, 32);
        }

        // StructProperty AkAudio.AkRevPhysicsSimulation.AkRevSimUpdateParams.frame
        // 0x38 (0x10)
        public FAkRevSimFrame frame {
            get => new(Pointer + 56);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 56), 16, 16);
        }
    }

    // ScriptStruct AkAudio.AkRevPhysicsSimulation.AkRevSimFrame
    // 0x10
    public unsafe class FAkRevSimFrame : BaseObject {
        public FAkRevSimFrame() {
            Pointer = Marshal.AllocHGlobal(16);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 16);
            Allocated = true;
        }
        public FAkRevSimFrame(nint pointer) : base(pointer) { }

        // FloatProperty AkAudio.AkRevPhysicsSimulation.AkRevSimFrame.RPM
        // 0x0 (0x4)
        public float RPM {
            get => *(float*)Pointer;
            set => *(float*)Pointer = value;
        }

        // IntProperty AkAudio.AkRevPhysicsSimulation.AkRevSimFrame.Gear
        // 0x4 (0x4)
        public int Gear {
            get => *(int*)(Pointer + 4);
            set => *(int*)(Pointer + 4) = value;
        }

        // IntProperty AkAudio.AkRevPhysicsSimulation.AkRevSimFrame.RevGear
        // 0x8 (0x4)
        public int RevGear {
            get => *(int*)(Pointer + 8);
            set => *(int*)(Pointer + 8) = value;
        }

        // FloatProperty AkAudio.AkRevPhysicsSimulation.AkRevSimFrame.Velocity
        // 0xC (0x4)
        public float Velocity {
            get => *(float*)(Pointer + 12);
            set => *(float*)(Pointer + 12) = value;
        }
    }

    // ScriptStruct AkAudio.AkRevPhysicsSimulation.AkRevSimPhysicsControls
    // 0x20
    public unsafe class FAkRevSimPhysicsControls : BaseObject {
        public FAkRevSimPhysicsControls() {
            Pointer = Marshal.AllocHGlobal(32);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 32);
            Allocated = true;
        }
        public FAkRevSimPhysicsControls(nint pointer) : base(pointer) { }

        // FloatProperty AkAudio.AkRevPhysicsSimulation.AkRevSimPhysicsControls.Weight
        // 0x0 (0x4)
        // (Edit)
        public float Weight {
            get => *(float*)Pointer;
            set => *(float*)Pointer = value;
        }

        // FloatProperty AkAudio.AkRevPhysicsSimulation.AkRevSimPhysicsControls.EngineTorque
        // 0x4 (0x4)
        // (Edit)
        public float EngineTorque {
            get => *(float*)(Pointer + 4);
            set => *(float*)(Pointer + 4) = value;
        }

        // FloatProperty AkAudio.AkRevPhysicsSimulation.AkRevSimPhysicsControls.BreakingHorsePower
        // 0x8 (0x4)
        // (Edit)
        public float BreakingHorsePower {
            get => *(float*)(Pointer + 8);
            set => *(float*)(Pointer + 8) = value;
        }

        // MISSED OFFSET: 0x4

        // ArrayProperty AkAudio.AkRevPhysicsSimulation.AkRevSimPhysicsControls.GearRatios
        // 0x10 (0x10)
        // (Edit | NeedCtorLink)
        public UnmanagedTArray<float> GearRatios {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.AkRevPhysicsSimulation");
            return _staticClass;
        }
    }
}

// Class AkAudio.AkRTPCDecayComponent
// 0x3F (0x9D - 0xDC)
// (Compiled | Parsed | Native | EditInlineNew | Hidden)
public unsafe partial class UAkRTPCDecayComponent : UActorComponent {
    public UAkRTPCDecayComponent() { }
    public UAkRTPCDecayComponent(nint pointer) : base(pointer) { }


    // MISSED OFFSET: 0x3

    // NameProperty AkAudio.AkRTPCDecayComponent.RTPC
    // 0xA0 (0x8)
    // (Edit)
    public FName RTPC {
        get => new(Pointer + 160);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 160), 8, 8);
    }

    // FloatProperty AkAudio.AkRTPCDecayComponent.GrowValue
    // 0xA8 (0x4)
    // (Edit)
    public float GrowValue {
        get => *(float*)(Pointer + 168);
        set => *(float*)(Pointer + 168) = value;
    }

    // FloatProperty AkAudio.AkRTPCDecayComponent.MaxValue
    // 0xAC (0x4)
    // (Edit)
    public float MaxValue {
        get => *(float*)(Pointer + 172);
        set => *(float*)(Pointer + 172) = value;
    }

    // StructProperty AkAudio.AkRTPCDecayComponent.DecayPerSecond
    // 0xB0 (0x18)
    // (Edit | NeedCtorLink)
    public FInterpCurveFloat DecayPerSecond {
        get => new(Pointer + 176);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 176), 24, 24);
    }

    // ComponentProperty AkAudio.AkRTPCDecayComponent.SoundSource
    // 0xC8 (0x8)
    // (Const | ExportObject | Transient | Component | EditInline)
    public UAkSoundSource SoundSource {
        get {
            var pointer = *(nint*)(Pointer + 200);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 200) = value.Pointer;
    }

    // FloatProperty AkAudio.AkRTPCDecayComponent.CurrentValue
    // 0xD0 (0x4)
    // (Const | Transient)
    public float CurrentValue {
        get => *(float*)(Pointer + 208);
        set => *(float*)(Pointer + 208) = value;
    }

    // FloatProperty AkAudio.AkRTPCDecayComponent.LastAttachTime
    // 0xD4 (0x4)
    // (Const | Transient)
    public float LastAttachTime {
        get => *(float*)(Pointer + 212);
        set => *(float*)(Pointer + 212) = value;
    }

    // BoolProperty AkAudio.AkRTPCDecayComponent.bWasAttached
    // 0xD8 (0x4)
    // Bitmask: 0x00000001
    // (Const | Transient)
    public bool bWasAttached {
        get => (*(uint*)(Pointer + 216) & 0x1) != 0;
        set {
            if (value) *(uint*)(Pointer + 216) |= 0x1;
            else *(uint*)(Pointer + 216) &= ~(uint)0x1;
        }
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.AkRTPCDecayComponent");
            return _staticClass;
        }
    }
}

// Class AkAudio.AkSoundBanksInfo
// 0x28 (0x60 - 0x88)
// (Compiled | Parsed | Native | Hidden)
public unsafe partial class UAkSoundBanksInfo : UObject {
    public UAkSoundBanksInfo() { }
    public UAkSoundBanksInfo(nint pointer) : base(pointer) { }


    // ArrayProperty AkAudio.AkSoundBanksInfo.StreamedFileNames
    // 0x60 (0x10)
    // (NeedCtorLink)
    public StructTArray<FString> StreamedFileNames {
        get => new(Pointer + 96, 16);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 96), 16, 16);
    }

    // ArrayProperty AkAudio.AkSoundBanksInfo.SoundBanks
    // 0x70 (0x10)
    // (NeedCtorLink)
    public StructTArray<FSoundBankInfo> SoundBanks {
        get => new(Pointer + 112, 48);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 112), 16, 16);
    }

    // ComponentProperty AkAudio.AkSoundBanksInfo.EventToBankMap
    // 0x80 (0x8)
    // (ExportObject | Component | EditInline)
    public UStringMap EventToBankMap {
        get {
            var pointer = *(nint*)(Pointer + 128);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 128) = value.Pointer;
    }


    // Function AkAudio.AkSoundBanksInfo.Parse
    // 0xD10350
    // (Final | Native | Static | Public)
    public unsafe class Parse_Parameters : BaseObject {
        public Parse_Parameters() { }
        public Parse_Parameters(nint pointer) : base(pointer) { }

        // StrProperty AkAudio.AkSoundBanksInfo.Parse.Text
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString Text {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ObjectProperty AkAudio.AkSoundBanksInfo.Parse.ReturnValue
        // 0x10 (0x8)
        // (Param | OutParam | ReturnParam)
        public UAkSoundBanksInfo ReturnValue {
            get {
                var pointer = *(nint*)(Pointer + 16);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 16) = value.Pointer;
        }
    }
    private static UFunction _ptrParse;
    public static UAkSoundBanksInfo Parse(FString Text) {
        _ptrParse ??= FindFunction("Function AkAudio.AkSoundBanksInfo.Parse");

        var @params = stackalloc byte[24];
        System.Buffer.MemoryCopy((void*)Text.Pointer, @params, 16, 16);

        _ptrParse.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrParse, @params);
        _ptrParse.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)(@params + 16));
    }

    // Function AkAudio.AkSoundBanksInfo.LoadForNativePlatform
    // 0xD101C0
    // (Final | Native | Static | Public)
    public unsafe class LoadForNativePlatform_Parameters : BaseObject {
        public LoadForNativePlatform_Parameters() { }
        public LoadForNativePlatform_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkSoundBanksInfo.LoadForNativePlatform.ReturnValue
        // 0x0 (0x8)
        // (Param | OutParam | ReturnParam)
        public UAkSoundBanksInfo ReturnValue {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrLoadForNativePlatform;
    public static UAkSoundBanksInfo LoadForNativePlatform() {
        _ptrLoadForNativePlatform ??= FindFunction("Function AkAudio.AkSoundBanksInfo.LoadForNativePlatform");

        var @params = stackalloc byte[8];

        _ptrLoadForNativePlatform.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        StaticClass.ProcessEvent(_ptrLoadForNativePlatform, @params);
        _ptrLoadForNativePlatform.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return new(*(nint*)@params);
    }


    // ScriptStruct AkAudio.AkSoundBanksInfo.SoundBankInfo
    // 0x30
    public unsafe class FSoundBankInfo : BaseObject {
        public FSoundBankInfo() {
            Pointer = Marshal.AllocHGlobal(48);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 48);
            Allocated = true;
        }
        public FSoundBankInfo(nint pointer) : base(pointer) { }

        // StrProperty AkAudio.AkSoundBanksInfo.SoundBankInfo.ShortName
        // 0x0 (0x10)
        // (NeedCtorLink)
        public FString ShortName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // StrProperty AkAudio.AkSoundBanksInfo.SoundBankInfo.RelativePath
        // 0x10 (0x10)
        // (NeedCtorLink)
        public FString RelativePath {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }

        // StrProperty AkAudio.AkSoundBanksInfo.SoundBankInfo.Language
        // 0x20 (0x10)
        // (NeedCtorLink)
        public FString Language {
            get => new(Pointer + 32);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 32), 16, 16);
        }
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.AkSoundBanksInfo");
            return _staticClass;
        }
    }
}

// Class AkAudio.AkSoundCue
// 0x28 (0x60 - 0x88)
// (Compiled | Parsed | Native)
public unsafe partial class UAkSoundCue : UObject {
    public UAkSoundCue() { }
    public UAkSoundCue(nint pointer) : base(pointer) { }


    // ObjectProperty AkAudio.AkSoundCue.RequiredBank
    // 0x60 (0x8)
    // (Edit)
    public UAkBank RequiredBank {
        get {
            var pointer = *(nint*)(Pointer + 96);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 96) = value.Pointer;
    }

    // StrProperty AkAudio.AkSoundCue.StartEvent
    // 0x68 (0x10)
    // (Edit | NeedCtorLink)
    public FString StartEvent {
        get => new(Pointer + 104);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 104), 16, 16);
    }

    // StrProperty AkAudio.AkSoundCue.StopEvent
    // 0x78 (0x10)
    // (Edit | NeedCtorLink)
    public FString StopEvent {
        get => new(Pointer + 120);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 120), 16, 16);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.AkSoundCue");
            return _staticClass;
        }
    }
}

// Class AkAudio.AkSoundSource
// 0xFB (0x9D - 0x198)
// (Compiled | Parsed | Native | Hidden)
public unsafe partial class UAkSoundSource : UActorComponent {
    public UAkSoundSource() { }
    public UAkSoundSource(nint pointer) : base(pointer) { }


    // MISSED OFFSET: 0x3

    // StructProperty AkAudio.AkSoundSource.Translation
    // 0xA0 (0xC)
    // (Edit | Const)
    public FVector Translation {
        get => new(Pointer + 160);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 160), 12, 12);
    }

    // StructProperty AkAudio.AkSoundSource.Rotation
    // 0xAC (0xC)
    // (Edit | Const)
    public FRotator Rotation {
        get => new(Pointer + 172);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 172), 12, 12);
    }

    // BoolProperty AkAudio.AkSoundSource.bDetachOnComplete
    // 0xB8 (0x4)
    // Bitmask: 0x00000001
    // (Edit | Const)
    public bool bDetachOnComplete {
        get => (*(uint*)(Pointer + 184) & 0x1) != 0;
        set {
            if (value) *(uint*)(Pointer + 184) |= 0x1;
            else *(uint*)(Pointer + 184) &= ~(uint)0x1;
        }
    }

    // BoolProperty AkAudio.AkSoundSource.bRegistered
    // 0xB8 (0x4)
    // Bitmask: 0x00000002
    // (Const | Transient)
    public bool bRegistered {
        get => (*(uint*)(Pointer + 184) & 0x2) != 0;
        set {
            if (value) *(uint*)(Pointer + 184) |= 0x2;
            else *(uint*)(Pointer + 184) &= ~(uint)0x2;
        }
    }

    // BoolProperty AkAudio.AkSoundSource.bUpdateOrientation
    // 0xB8 (0x4)
    // Bitmask: 0x00000004
    // (Const | Transient)
    public bool bUpdateOrientation {
        get => (*(uint*)(Pointer + 184) & 0x4) != 0;
        set {
            if (value) *(uint*)(Pointer + 184) |= 0x4;
            else *(uint*)(Pointer + 184) &= ~(uint)0x4;
        }
    }

    // MISSED OFFSET: 0x4

    // StructProperty AkAudio.AkSoundSource.CachedParentToWorld
    // 0xC0 (0x40)
    // (Const | Transient)
    public FMatrix CachedParentToWorld {
        get => new(Pointer + 192);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 192), 64, 64);
    }

    // StructProperty AkAudio.AkSoundSource.WorldLocation
    // 0x100 (0xC)
    // (Const | Transient)
    public FVector WorldLocation {
        get => new(Pointer + 256);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 256), 12, 12);
    }

    // StructProperty AkAudio.AkSoundSource.WorldRotation
    // 0x10C (0xC)
    // (Const | Transient)
    public FRotator WorldRotation {
        get => new(Pointer + 268);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 268), 12, 12);
    }

    // ComponentProperty AkAudio.AkSoundSource.Params
    // 0x118 (0x8)
    // (Const | ExportObject | Transient | Component | EditInline)
    public UAkParamGroup Params {
        get {
            var pointer = *(nint*)(Pointer + 280);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 280) = value.Pointer;
    }

    // ArrayProperty AkAudio.AkSoundSource.ActiveSounds
    // 0x120 (0x10)
    // (Const | Transient | NeedCtorLink)
    public StructTArray<FActiveSound> ActiveSounds {
        get => new(Pointer + 288, 16);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 288), 16, 16);
    }

    // ByteProperty AkAudio.AkSoundSource.EnvironmentType
    // 0x130 (0x1)
    // (Transient)
    public EAkEnvironmentType EnvironmentType {
        get => *(EAkEnvironmentType*)(Pointer + 304);
        set => *(EAkEnvironmentType*)(Pointer + 304) = value;
    }

    // MISSED OFFSET: 0x7

    // ArrayProperty AkAudio.AkSoundSource.CallbackTypes
    // 0x138 (0x10)
    // (NeedCtorLink)
    public UnmanagedTArray<EAkCallbackType> CallbackTypes {
        get => new(Pointer + 312);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 312), 16, 16);
    }

    // StructProperty AkAudio.AkSoundSource.SoundSourceId
    // 0x148 (0x8)
    // (Native | Transient)
    public nint SoundSourceId {
        get => *(nint*)(Pointer + 328);
        set => *(nint*)(Pointer + 328) = value;
    }

    // DelegateProperty AkAudio.AkSoundSource.__EventFinished__Delegate
    // 0x150 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventFinished__Delegate {
        get => new(Pointer + 336);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 336), 24, 24);
    }

    // DelegateProperty AkAudio.AkSoundSource.__EventMarker__Delegate
    // 0x168 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventMarker__Delegate {
        get => new(Pointer + 360);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 360), 24, 24);
    }

    // DelegateProperty AkAudio.AkSoundSource.__EventDuration__Delegate
    // 0x180 (0x18)
    // (NeedCtorLink)
    public FScriptDelegate __EventDuration__Delegate {
        get => new(Pointer + 384);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 384), 24, 24);
    }


    // Function AkAudio.AkSoundSource.SetSubtitlesEnabled
    // 0x3750E0
    // (Final | Defined | Event | Public | K2Call)
    public unsafe class SetSubtitlesEnabled_Parameters : BaseObject {
        public SetSubtitlesEnabled_Parameters() { }
        public SetSubtitlesEnabled_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty AkAudio.AkSoundSource.SetSubtitlesEnabled.bValue
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bValue {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrSetSubtitlesEnabled;
    public void SetSubtitlesEnabled(bool bValue) {
        _ptrSetSubtitlesEnabled ??= FindFunction("Function AkAudio.AkSoundSource.SetSubtitlesEnabled");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bValue, @params, 4, 4);

        ProcessEvent(_ptrSetSubtitlesEnabled, @params);
    }

    // Function AkAudio.AkSoundSource.SetAttenuationScaling
    // 0xD0DC20
    // (Final | Native | Public | K2Call)
    public unsafe class SetAttenuationScaling_Parameters : BaseObject {
        public SetAttenuationScaling_Parameters() { }
        public SetAttenuationScaling_Parameters(nint pointer) : base(pointer) { }

        // ByteProperty AkAudio.AkSoundSource.SetAttenuationScaling.AttenuationType
        // 0x0 (0x1)
        // (Param)
        public UAkParamGroup.EAttenuationType AttenuationType {
            get => *(UAkParamGroup.EAttenuationType*)Pointer;
            set => *(UAkParamGroup.EAttenuationType*)Pointer = value;
        }
    }
    private static UFunction _ptrSetAttenuationScaling;
    public void SetAttenuationScaling(UAkParamGroup.EAttenuationType AttenuationType) {
        _ptrSetAttenuationScaling ??= FindFunction("Function AkAudio.AkSoundSource.SetAttenuationScaling");

        var @params = stackalloc byte[1];
        System.Buffer.MemoryCopy(&AttenuationType, @params, 1, 1);

        _ptrSetAttenuationScaling.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSetAttenuationScaling, @params);
        _ptrSetAttenuationScaling.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkSoundSource.ForceUpdatePosition
    // 0xD0DBA0
    // (Final | Native | Public | K2Call)
    public unsafe class ForceUpdatePosition_Parameters : BaseObject {
        public ForceUpdatePosition_Parameters() { }
        public ForceUpdatePosition_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrForceUpdatePosition;
    public void ForceUpdatePosition() {
        _ptrForceUpdatePosition ??= FindFunction("Function AkAudio.AkSoundSource.ForceUpdatePosition");

        _ptrForceUpdatePosition.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrForceUpdatePosition, null);
        _ptrForceUpdatePosition.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkSoundSource.RegisterReflectionEmitter
    // 0xD0DAC0
    // (Final | Native | Public | K2Call)
    public unsafe class RegisterReflectionEmitter_Parameters : BaseObject {
        public RegisterReflectionEmitter_Parameters() { }
        public RegisterReflectionEmitter_Parameters(nint pointer) : base(pointer) { }

        // NameProperty AkAudio.AkSoundSource.RegisterReflectionEmitter.BusName
        // 0x0 (0x8)
        // (Param)
        public FName BusName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 8, 8);
        }

        // ByteProperty AkAudio.AkSoundSource.RegisterReflectionEmitter.BusType
        // 0x8 (0x1)
        // (Param)
        public AAkBusActor.EBusEmitterType BusType {
            get => *(AAkBusActor.EBusEmitterType*)(Pointer + 8);
            set => *(AAkBusActor.EBusEmitterType*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrRegisterReflectionEmitter;
    public void RegisterReflectionEmitter(FName BusName, AAkBusActor.EBusEmitterType BusType) {
        _ptrRegisterReflectionEmitter ??= FindFunction("Function AkAudio.AkSoundSource.RegisterReflectionEmitter");

        var @params = stackalloc byte[9];
        System.Buffer.MemoryCopy((void*)BusName.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&BusType, @params + 8, 1, 1);

        _ptrRegisterReflectionEmitter.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrRegisterReflectionEmitter, @params);
        _ptrRegisterReflectionEmitter.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkSoundSource.IsPlayingAny
    // 0xD0DA70
    // (Final | Native | Public | K2Call)
    public unsafe class IsPlayingAny_Parameters : BaseObject {
        public IsPlayingAny_Parameters() { }
        public IsPlayingAny_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty AkAudio.AkSoundSource.IsPlayingAny.ReturnValue
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
    private static UFunction _ptrIsPlayingAny;
    public bool IsPlayingAny() {
        _ptrIsPlayingAny ??= FindFunction("Function AkAudio.AkSoundSource.IsPlayingAny");

        var @params = stackalloc byte[4];

        _ptrIsPlayingAny.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrIsPlayingAny, @params);
        _ptrIsPlayingAny.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)@params;
    }

    // Function AkAudio.AkSoundSource.IsPlaying
    // 0xD0D9A0
    // (Final | Native | Public | K2Call)
    public unsafe class IsPlaying_Parameters : BaseObject {
        public IsPlaying_Parameters() { }
        public IsPlaying_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkSoundSource.IsPlaying.Sound
        // 0x0 (0x8)
        // (Param)
        public UAkSoundCue Sound {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // BoolProperty AkAudio.AkSoundSource.IsPlaying.ReturnValue
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
    private static UFunction _ptrIsPlaying;
    public bool IsPlaying(UAkSoundCue Sound) {
        _ptrIsPlaying ??= FindFunction("Function AkAudio.AkSoundSource.IsPlaying");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)Sound.Pointer, @params, 8, 8);

        _ptrIsPlaying.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrIsPlaying, @params);
        _ptrIsPlaying.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(bool*)(@params + 8);
    }

    // Function AkAudio.AkSoundSource.Seek
    // 0xD0D840
    // (Final | Native | Public | K2Call)
    public unsafe class Seek_Parameters : BaseObject {
        public Seek_Parameters() { }
        public Seek_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkSoundSource.Seek.Sound
        // 0x0 (0x8)
        // (Param)
        public UAkSoundCue Sound {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // FloatProperty AkAudio.AkSoundSource.Seek.SeekSeconds
        // 0x8 (0x4)
        // (Param)
        public float SeekSeconds {
            get => *(float*)(Pointer + 8);
            set => *(float*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrSeek;
    public void Seek(UAkSoundCue Sound, float SeekSeconds) {
        _ptrSeek ??= FindFunction("Function AkAudio.AkSoundSource.Seek");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)Sound.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&SeekSeconds, @params + 8, 4, 4);

        _ptrSeek.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrSeek, @params);
        _ptrSeek.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkSoundSource.StopAll
    // 0xD0D800
    // (Final | Native | Public | K2Call)
    public unsafe class StopAll_Parameters : BaseObject {
        public StopAll_Parameters() { }
        public StopAll_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrStopAll;
    public void StopAll() {
        _ptrStopAll ??= FindFunction("Function AkAudio.AkSoundSource.StopAll");

        _ptrStopAll.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrStopAll, null);
        _ptrStopAll.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkSoundSource.Stop
    // 0xD0D780
    // (Final | Native | Public | K2Call)
    public unsafe class Stop_Parameters : BaseObject {
        public Stop_Parameters() { }
        public Stop_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkSoundSource.Stop.Sound
        // 0x0 (0x8)
        // (Param)
        public UAkSoundCue Sound {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrStop;
    public void Stop(UAkSoundCue Sound) {
        _ptrStop ??= FindFunction("Function AkAudio.AkSoundSource.Stop");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy((void*)Sound.Pointer, @params, 8, 8);

        _ptrStop.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrStop, @params);
        _ptrStop.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }

    // Function AkAudio.AkSoundSource.Play
    // 0xD0D6F0
    // (Final | Native | Public | K2Call)
    public unsafe class Play_Parameters : BaseObject {
        public Play_Parameters() { }
        public Play_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkSoundSource.Play.Sound
        // 0x0 (0x8)
        // (Param)
        public UAkSoundCue Sound {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // IntProperty AkAudio.AkSoundSource.Play.ReturnValue
        // 0x8 (0x4)
        // (Param | OutParam | ReturnParam)
        public int ReturnValue {
            get => *(int*)(Pointer + 8);
            set => *(int*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrPlay;
    public int Play(UAkSoundCue Sound) {
        _ptrPlay ??= FindFunction("Function AkAudio.AkSoundSource.Play");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)Sound.Pointer, @params, 8, 8);

        _ptrPlay.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrPlay, @params);
        _ptrPlay.FunctionFlags |= (ulong)EFunctionFlags.Native;

        return *(int*)(@params + 8);
    }

    // Function AkAudio.AkSoundSource.EventDuration
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventDuration_Parameters : BaseObject {
        public EventDuration_Parameters() { }
        public EventDuration_Parameters(nint pointer) : base(pointer) { }

        // ComponentProperty AkAudio.AkSoundSource.EventDuration.Source
        // 0x0 (0x8)
        // (Param | EditInline)
        public UAkSoundSource Source {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // IntProperty AkAudio.AkSoundSource.EventDuration.PlayingID
        // 0x8 (0x4)
        // (Param)
        public int PlayingID {
            get => *(int*)(Pointer + 8);
            set => *(int*)(Pointer + 8) = value;
        }

        // FloatProperty AkAudio.AkSoundSource.EventDuration.DurationMS
        // 0xC (0x4)
        // (Param)
        public float DurationMS {
            get => *(float*)(Pointer + 12);
            set => *(float*)(Pointer + 12) = value;
        }
    }
    private static UFunction _ptrEventDuration;
    public void EventDuration(UAkSoundSource Source, int PlayingID, float DurationMS) {
        _ptrEventDuration ??= FindFunction("Function AkAudio.AkSoundSource.EventDuration");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)Source.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&PlayingID, @params + 8, 4, 4);
        System.Buffer.MemoryCopy(&DurationMS, @params + 12, 4, 4);

        ProcessEvent(_ptrEventDuration, @params);
    }

    // Function AkAudio.AkSoundSource.EventMarker
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventMarker_Parameters : BaseObject {
        public EventMarker_Parameters() { }
        public EventMarker_Parameters(nint pointer) : base(pointer) { }

        // ComponentProperty AkAudio.AkSoundSource.EventMarker.Source
        // 0x0 (0x8)
        // (Param | EditInline)
        public UAkSoundSource Source {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // IntProperty AkAudio.AkSoundSource.EventMarker.PlayingID
        // 0x8 (0x4)
        // (Param)
        public int PlayingID {
            get => *(int*)(Pointer + 8);
            set => *(int*)(Pointer + 8) = value;
        }

        // MISSED OFFSET: 0x4

        // StrProperty AkAudio.AkSoundSource.EventMarker.Marker
        // 0x10 (0x10)
        // (Param | NeedCtorLink)
        public FString Marker {
            get => new(Pointer + 16);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 16), 16, 16);
        }
    }
    private static UFunction _ptrEventMarker;
    public void EventMarker(UAkSoundSource Source, int PlayingID, FString Marker) {
        _ptrEventMarker ??= FindFunction("Function AkAudio.AkSoundSource.EventMarker");

        var @params = stackalloc byte[28];
        System.Buffer.MemoryCopy((void*)Source.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&PlayingID, @params + 8, 4, 4);
        System.Buffer.MemoryCopy((void*)Marker.Pointer, @params + 16, 16, 16);

        ProcessEvent(_ptrEventMarker, @params);
    }

    // Function AkAudio.AkSoundSource.EventFinished
    // 0x3750E0
    // (Final | Public | Delegate)
    public unsafe class EventFinished_Parameters : BaseObject {
        public EventFinished_Parameters() { }
        public EventFinished_Parameters(nint pointer) : base(pointer) { }

        // ComponentProperty AkAudio.AkSoundSource.EventFinished.Source
        // 0x0 (0x8)
        // (Param | EditInline)
        public UAkSoundSource Source {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // IntProperty AkAudio.AkSoundSource.EventFinished.PlayingID
        // 0x8 (0x4)
        // (Param)
        public int PlayingID {
            get => *(int*)(Pointer + 8);
            set => *(int*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrEventFinished;
    public void EventFinished(UAkSoundSource Source, int PlayingID) {
        _ptrEventFinished ??= FindFunction("Function AkAudio.AkSoundSource.EventFinished");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)Source.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&PlayingID, @params + 8, 4, 4);

        ProcessEvent(_ptrEventFinished, @params);
    }


    // ScriptStruct AkAudio.AkSoundSource.ActiveSound
    // 0x10
    public unsafe class FActiveSound : BaseObject {
        public FActiveSound() {
            Pointer = Marshal.AllocHGlobal(16);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 16);
            Allocated = true;
        }
        public FActiveSound(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkSoundSource.ActiveSound.Sound
        // 0x0 (0x8)
        public UAkSoundCue Sound {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // IntProperty AkAudio.AkSoundSource.ActiveSound.PlayId
        // 0x8 (0x4)
        public int PlayId {
            get => *(int*)(Pointer + 8);
            set => *(int*)(Pointer + 8) = value;
        }

        // IntProperty AkAudio.AkSoundSource.ActiveSound.StopId
        // 0xC (0x4)
        public int StopId {
            get => *(int*)(Pointer + 12);
            set => *(int*)(Pointer + 12) = value;
        }
    }


    // Enum AkAudio.AkSoundSource.EAkCallbackType
    public enum EAkCallbackType : byte {
        AkCallbackType_Marker = 0,
        AkCallbackType_Duration = 1,
        AkCallbackType_MAX = 2
    }

    // Enum AkAudio.AkSoundSource.EAkEnvironmentType
    public enum EAkEnvironmentType : byte {
        EnvironmentType_SpatializedAudio = 0,
        EnvironmentType_UnspatializedAudio = 1,
        EnvironmentType_Music = 2,
        EnvironmentType_None = 3,
        EnvironmentType_MAX = 4
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.AkSoundSource");
            return _staticClass;
        }
    }
}

// Class AkAudio.AkSwitch
// 0x0 (0x60 - 0x60)
// (Compiled | Parsed | Native)
public unsafe partial class UAkSwitch : UObject {
    public UAkSwitch() { }
    public UAkSwitch(nint pointer) : base(pointer) { }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.AkSwitch");
            return _staticClass;
        }
    }
}

// Class AkAudio.InterpTrackAkEvent
// 0x18 (0xC4 - 0xDC)
// (Compiled | Parsed | Native | CollapseCategories)
public unsafe partial class UInterpTrackAkEvent : UInterpTrack {
    public UInterpTrackAkEvent() { }
    public UInterpTrackAkEvent(nint pointer) : base(pointer) { }


    // MISSED OFFSET: 0x4

    // ArrayProperty AkAudio.InterpTrackAkEvent.AkEvents
    // 0xC8 (0x10)
    // (NeedCtorLink)
    public StructTArray<FAkEventTrackKey> AkEvents {
        get => new(Pointer + 200, 16);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 200), 16, 16);
    }

    // FloatProperty AkAudio.InterpTrackAkEvent.SeekTimeSeconds
    // 0xD8 (0x4)
    // (Edit)
    public float SeekTimeSeconds {
        get => *(float*)(Pointer + 216);
        set => *(float*)(Pointer + 216) = value;
    }


    // ScriptStruct AkAudio.InterpTrackAkEvent.AkEventTrackKey
    // 0x10
    public unsafe class FAkEventTrackKey : BaseObject {
        public FAkEventTrackKey() {
            Pointer = Marshal.AllocHGlobal(16);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 16);
            Allocated = true;
        }
        public FAkEventTrackKey(nint pointer) : base(pointer) { }

        // FloatProperty AkAudio.InterpTrackAkEvent.AkEventTrackKey.Time
        // 0x0 (0x4)
        public float Time {
            get => *(float*)Pointer;
            set => *(float*)Pointer = value;
        }

        // MISSED OFFSET: 0x4

        // ObjectProperty AkAudio.InterpTrackAkEvent.AkEventTrackKey.Event
        // 0x8 (0x8)
        // (Edit)
        public UAkSoundCue Event {
            get {
                var pointer = *(nint*)(Pointer + 8);
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)(Pointer + 8) = value.Pointer;
        }
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.InterpTrackAkEvent");
            return _staticClass;
        }
    }
}

// Class AkAudio.InterpTrackAkRTPC
// 0x14 (0xE4 - 0xF8)
// (Compiled | Parsed | Native | CollapseCategories)
public unsafe partial class UInterpTrackAkRTPC : UInterpTrackFloatBase {
    public UInterpTrackAkRTPC() { }
    public UInterpTrackAkRTPC(nint pointer) : base(pointer) { }


    // MISSED OFFSET: 0x4

    // StrProperty AkAudio.InterpTrackAkRTPC.Param
    // 0xE8 (0x10)
    // (Edit | NeedCtorLink)
    public FString Param {
        get => new(Pointer + 232);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 232), 16, 16);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.InterpTrackAkRTPC");
            return _staticClass;
        }
    }
}

// Class AkAudio.InterpTrackInstAkEvent
// 0x4 (0x60 - 0x64)
// (Compiled | Parsed | Native)
public unsafe partial class UInterpTrackInstAkEvent : UInterpTrackInst {
    public UInterpTrackInstAkEvent() { }
    public UInterpTrackInstAkEvent(nint pointer) : base(pointer) { }


    // FloatProperty AkAudio.InterpTrackInstAkEvent.LastUpdatePosition
    // 0x60 (0x4)
    public float LastUpdatePosition {
        get => *(float*)(Pointer + 96);
        set => *(float*)(Pointer + 96) = value;
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.InterpTrackInstAkEvent");
            return _staticClass;
        }
    }
}

// Class AkAudio.InterpTrackInstAkRTPC
// 0x0 (0x60 - 0x60)
// (Compiled | Parsed | Native)
public unsafe partial class UInterpTrackInstAkRTPC : UInterpTrackInst {
    public UInterpTrackInstAkRTPC() { }
    public UInterpTrackInstAkRTPC(nint pointer) : base(pointer) { }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.InterpTrackInstAkRTPC");
            return _staticClass;
        }
    }
}

// Class AkAudio.SeqAct_AkClearBanks
// 0x0 (0x160 - 0x160)
// (Compiled | Parsed | Native)
public unsafe partial class USeqAct_AkClearBanks : USequenceAction {
    public USeqAct_AkClearBanks() { }
    public USeqAct_AkClearBanks(nint pointer) : base(pointer) { }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.SeqAct_AkClearBanks");
            return _staticClass;
        }
    }
}

// Class AkAudio.SeqAct_AkEnvironment
// 0x21 (0x160 - 0x181)
// (Compiled | Parsed | Native)
public unsafe partial class USeqAct_AkEnvironment : USequenceAction {
    public USeqAct_AkEnvironment() { }
    public USeqAct_AkEnvironment(nint pointer) : base(pointer) { }


    // StructProperty AkAudio.SeqAct_AkEnvironment.Environment
    // 0x160 (0x20)
    // (Edit | NeedCtorLink)
    public UAkEnvironments.FAkEnvironment Environment {
        get => new(Pointer + 352);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 352), 32, 32);
    }

    // ByteProperty AkAudio.SeqAct_AkEnvironment.Target
    // 0x180 (0x1)
    // (Edit)
    public EAkEnvironmentTarget Target {
        get => *(EAkEnvironmentTarget*)(Pointer + 384);
        set => *(EAkEnvironmentTarget*)(Pointer + 384) = value;
    }


    // Enum AkAudio.SeqAct_AkEnvironment.EAkEnvironmentTarget
    public enum EAkEnvironmentTarget : byte {
        AkEnvironmentTarget_LevelDefault = 0,
        AkEnvironmentTarget_Actor = 1,
        AkEnvironmentTarget_MAX = 2
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.SeqAct_AkEnvironment");
            return _staticClass;
        }
    }
}

// Class AkAudio.SeqAct_AkLoadBank
// 0x14 (0x178 - 0x18C)
// (Compiled | Parsed | Native)
public unsafe partial class USeqAct_AkLoadBank : USeqAct_Latent {
    public USeqAct_AkLoadBank() { }
    public USeqAct_AkLoadBank(nint pointer) : base(pointer) { }


    // BoolProperty AkAudio.SeqAct_AkLoadBank.Async
    // 0x178 (0x4)
    // Bitmask: 0x00000001
    // (Edit)
    public bool Async {
        get => (*(uint*)(Pointer + 376) & 0x1) != 0;
        set {
            if (value) *(uint*)(Pointer + 376) |= 0x1;
            else *(uint*)(Pointer + 376) &= ~(uint)0x1;
        }
    }

    // BoolProperty AkAudio.SeqAct_AkLoadBank.bWaitingCallback
    // 0x178 (0x4)
    // Bitmask: 0x00000002
    // (Transient)
    public bool bWaitingCallback {
        get => (*(uint*)(Pointer + 376) & 0x2) != 0;
        set {
            if (value) *(uint*)(Pointer + 376) |= 0x2;
            else *(uint*)(Pointer + 376) &= ~(uint)0x2;
        }
    }

    // MISSED OFFSET: 0x4

    // ObjectProperty AkAudio.SeqAct_AkLoadBank.Bank
    // 0x180 (0x8)
    // (Edit)
    public UAkBank Bank {
        get {
            var pointer = *(nint*)(Pointer + 384);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 384) = value.Pointer;
    }

    // IntProperty AkAudio.SeqAct_AkLoadBank.Signal
    // 0x188 (0x4)
    // (Transient)
    public int Signal {
        get => *(int*)(Pointer + 392);
        set => *(int*)(Pointer + 392) = value;
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.SeqAct_AkLoadBank");
            return _staticClass;
        }
    }
}

// Class AkAudio.SeqAct_AkPlayMusicWithCues
// 0x18 (0x178 - 0x190)
// (Compiled | Parsed | Native)
public unsafe partial class USeqAct_AkPlayMusicWithCues : USeqAct_Latent {
    public USeqAct_AkPlayMusicWithCues() { }
    public USeqAct_AkPlayMusicWithCues(nint pointer) : base(pointer) { }


    // ObjectProperty AkAudio.SeqAct_AkPlayMusicWithCues.SoundCue
    // 0x178 (0x8)
    // (Edit)
    public UAkSoundCue SoundCue {
        get {
            var pointer = *(nint*)(Pointer + 376);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 376) = value.Pointer;
    }

    // ArrayProperty AkAudio.SeqAct_AkPlayMusicWithCues.MusicSyncEvents
    // 0x180 (0x10)
    // (NeedCtorLink)
    public StructTArray<FMusicSyncEvent> MusicSyncEvents {
        get => new(Pointer + 384, 24);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 384), 16, 16);
    }


    // Function AkAudio.SeqAct_AkPlayMusicWithCues.TriggerEvents
    // 0x3750E0
    // (Final | Defined | Event | Private)
    public unsafe class TriggerEvents_Parameters : BaseObject {
        public TriggerEvents_Parameters() { }
        public TriggerEvents_Parameters(nint pointer) : base(pointer) { }

        // StrProperty AkAudio.SeqAct_AkPlayMusicWithCues.TriggerEvents.CueName
        // 0x0 (0x10)
        // (Param | NeedCtorLink)
        public FString CueName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }
    }
    private static UFunction _ptrTriggerEvents;
    public void TriggerEvents(FString CueName) {
        _ptrTriggerEvents ??= FindFunction("Function AkAudio.SeqAct_AkPlayMusicWithCues.TriggerEvents");

        var @params = stackalloc byte[16];
        System.Buffer.MemoryCopy((void*)CueName.Pointer, @params, 16, 16);

        ProcessEvent(_ptrTriggerEvents, @params);
    }


    // ScriptStruct AkAudio.SeqAct_AkPlayMusicWithCues.MusicSyncEvent
    // 0x11
    public unsafe class FMusicSyncEvent : BaseObject {
        public FMusicSyncEvent() {
            Pointer = Marshal.AllocHGlobal(17);
            Unsafe.InitBlockUnaligned((void*)Pointer, 0, 17);
            Allocated = true;
        }
        public FMusicSyncEvent(nint pointer) : base(pointer) { }

        // StrProperty AkAudio.SeqAct_AkPlayMusicWithCues.MusicSyncEvent.CueName
        // 0x0 (0x10)
        // (NeedCtorLink)
        public FString CueName {
            get => new(Pointer);
            set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)Pointer, 16, 16);
        }

        // ByteProperty AkAudio.SeqAct_AkPlayMusicWithCues.MusicSyncEvent.CueType
        // 0x10 (0x1)
        public EMusicSyncType CueType {
            get => *(EMusicSyncType*)(Pointer + 16);
            set => *(EMusicSyncType*)(Pointer + 16) = value;
        }
    }


    // Enum AkAudio.SeqAct_AkPlayMusicWithCues.EMusicSyncType
    public enum EMusicSyncType : byte {
        MusicSyncType_EndOfEvent = 0,
        MusicSyncType_UserCue = 1,
        MusicSyncType_MAX = 2
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.SeqAct_AkPlayMusicWithCues");
            return _staticClass;
        }
    }
}

// Class AkAudio.SeqAct_AkPlaySound
// 0xC (0x160 - 0x16C)
// (Compiled | Parsed | Native)
public unsafe partial class USeqAct_AkPlaySound : USequenceAction {
    public USeqAct_AkPlaySound() { }
    public USeqAct_AkPlaySound(nint pointer) : base(pointer) { }


    // ObjectProperty AkAudio.SeqAct_AkPlaySound.SoundCue
    // 0x160 (0x8)
    // (Edit)
    public UAkSoundCue SoundCue {
        get {
            var pointer = *(nint*)(Pointer + 352);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 352) = value.Pointer;
    }

    // BoolProperty AkAudio.SeqAct_AkPlaySound.bBGMusic
    // 0x168 (0x4)
    // Bitmask: 0x00000001
    // (Edit)
    public bool bBGMusic {
        get => (*(uint*)(Pointer + 360) & 0x1) != 0;
        set {
            if (value) *(uint*)(Pointer + 360) |= 0x1;
            else *(uint*)(Pointer + 360) &= ~(uint)0x1;
        }
    }


    // Function AkAudio.SeqAct_AkPlaySound.ToggleSoundFor
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ToggleSoundFor_Parameters : BaseObject {
        public ToggleSoundFor_Parameters() { }
        public ToggleSoundFor_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.SeqAct_AkPlaySound.ToggleSoundFor.A
        // 0x0 (0x8)
        // (Param)
        public AActor A {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // BoolProperty AkAudio.SeqAct_AkPlaySound.ToggleSoundFor.bPlay
        // 0x8 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bPlay {
            get => (*(uint*)(Pointer + 8) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 8) |= 0x1;
                else *(uint*)(Pointer + 8) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrToggleSoundFor;
    public void ToggleSoundFor(AActor A, bool bPlay) {
        _ptrToggleSoundFor ??= FindFunction("Function AkAudio.SeqAct_AkPlaySound.ToggleSoundFor");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)A.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&bPlay, @params + 8, 4, 4);

        ProcessEvent(_ptrToggleSoundFor, @params);
    }

    // Function AkAudio.SeqAct_AkPlaySound.ToggleSound
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ToggleSound_Parameters : BaseObject {
        public ToggleSound_Parameters() { }
        public ToggleSound_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty AkAudio.SeqAct_AkPlaySound.ToggleSound.bPlay
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bPlay {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrToggleSound;
    public void ToggleSound(bool bPlay) {
        _ptrToggleSound ??= FindFunction("Function AkAudio.SeqAct_AkPlaySound.ToggleSound");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bPlay, @params, 4, 4);

        ProcessEvent(_ptrToggleSound, @params);
    }

    // Function AkAudio.SeqAct_AkPlaySound.Activated
    // 0x3750E0
    // (Defined | Event | Public)
    public unsafe class Activated_Parameters : BaseObject {
        public Activated_Parameters() { }
        public Activated_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrActivated;
    public void Activated() {
        _ptrActivated ??= FindFunction("Function AkAudio.SeqAct_AkPlaySound.Activated");

        ProcessEvent(_ptrActivated, null);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.SeqAct_AkPlaySound");
            return _staticClass;
        }
    }
}

// Class AkAudio.SeqAct_AkPostEvent
// 0x1C (0x178 - 0x194)
// (Compiled | Parsed | Native)
public unsafe partial class USeqAct_AkPostEvent : USeqAct_Latent {
    public USeqAct_AkPostEvent() { }
    public USeqAct_AkPostEvent(nint pointer) : base(pointer) { }


    // ArrayProperty AkAudio.SeqAct_AkPostEvent.PlayingIDs
    // 0x178 (0x10)
    // (Const | Transient | NeedCtorLink)
    public UnmanagedTArray<int> PlayingIDs {
        get => new(Pointer + 376);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 376), 16, 16);
    }

    // ObjectProperty AkAudio.SeqAct_AkPostEvent.SoundCue
    // 0x188 (0x8)
    // (Edit)
    public UAkSoundCue SoundCue {
        get {
            var pointer = *(nint*)(Pointer + 392);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 392) = value.Pointer;
    }

    // BoolProperty AkAudio.SeqAct_AkPostEvent.bHasSubtitles
    // 0x190 (0x4)
    // Bitmask: 0x00000001
    // (Edit)
    public bool bHasSubtitles {
        get => (*(uint*)(Pointer + 400) & 0x1) != 0;
        set {
            if (value) *(uint*)(Pointer + 400) |= 0x1;
            else *(uint*)(Pointer + 400) &= ~(uint)0x1;
        }
    }


    // Function AkAudio.SeqAct_AkPostEvent.HandleSoundCueFinished
    // 0xD10440
    // (Final | Native | Event | Private)
    public unsafe class HandleSoundCueFinished_Parameters : BaseObject {
        public HandleSoundCueFinished_Parameters() { }
        public HandleSoundCueFinished_Parameters(nint pointer) : base(pointer) { }

        // ComponentProperty AkAudio.SeqAct_AkPostEvent.HandleSoundCueFinished.Source
        // 0x0 (0x8)
        // (Param | EditInline)
        public UAkSoundSource Source {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // IntProperty AkAudio.SeqAct_AkPostEvent.HandleSoundCueFinished.PlayingID
        // 0x8 (0x4)
        // (Param)
        public int PlayingID {
            get => *(int*)(Pointer + 8);
            set => *(int*)(Pointer + 8) = value;
        }
    }
    private static UFunction _ptrHandleSoundCueFinished;
    public void HandleSoundCueFinished(UAkSoundSource Source, int PlayingID) {
        _ptrHandleSoundCueFinished ??= FindFunction("Function AkAudio.SeqAct_AkPostEvent.HandleSoundCueFinished");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)Source.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&PlayingID, @params + 8, 4, 4);

        _ptrHandleSoundCueFinished.FunctionFlags &= (ulong)~EFunctionFlags.Native;
        ProcessEvent(_ptrHandleSoundCueFinished, @params);
        _ptrHandleSoundCueFinished.FunctionFlags |= (ulong)EFunctionFlags.Native;
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.SeqAct_AkPostEvent");
            return _staticClass;
        }
    }
}

// Class AkAudio.SeqAct_AkPostTrigger
// 0x10 (0x160 - 0x170)
// (Compiled | Parsed | Native)
public unsafe partial class USeqAct_AkPostTrigger : USequenceAction {
    public USeqAct_AkPostTrigger() { }
    public USeqAct_AkPostTrigger(nint pointer) : base(pointer) { }


    // StrProperty AkAudio.SeqAct_AkPostTrigger.Trigger
    // 0x160 (0x10)
    // (Edit | NeedCtorLink)
    public FString Trigger {
        get => new(Pointer + 352);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 352), 16, 16);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.SeqAct_AkPostTrigger");
            return _staticClass;
        }
    }
}

// Class AkAudio.SeqAct_AkSetRTPCValue
// 0x18 (0x178 - 0x190)
// (Compiled | Parsed | Native)
public unsafe partial class USeqAct_AkSetRTPCValue : USeqAct_Latent {
    public USeqAct_AkSetRTPCValue() { }
    public USeqAct_AkSetRTPCValue(nint pointer) : base(pointer) { }


    // StrProperty AkAudio.SeqAct_AkSetRTPCValue.Param
    // 0x178 (0x10)
    // (Edit | NeedCtorLink)
    public FString Param {
        get => new(Pointer + 376);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 376), 16, 16);
    }

    // FloatProperty AkAudio.SeqAct_AkSetRTPCValue.Value
    // 0x188 (0x4)
    // (Edit)
    public float Value {
        get => *(float*)(Pointer + 392);
        set => *(float*)(Pointer + 392) = value;
    }

    // BoolProperty AkAudio.SeqAct_AkSetRTPCValue.Running
    // 0x18C (0x4)
    // Bitmask: 0x00000001
    // (Transient)
    public bool Running {
        get => (*(uint*)(Pointer + 396) & 0x1) != 0;
        set {
            if (value) *(uint*)(Pointer + 396) |= 0x1;
            else *(uint*)(Pointer + 396) &= ~(uint)0x1;
        }
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.SeqAct_AkSetRTPCValue");
            return _staticClass;
        }
    }
}

// Class AkAudio.SeqAct_AkSetState
// 0x20 (0x160 - 0x180)
// (Compiled | Parsed | Native)
public unsafe partial class USeqAct_AkSetState : USequenceAction {
    public USeqAct_AkSetState() { }
    public USeqAct_AkSetState(nint pointer) : base(pointer) { }


    // StrProperty AkAudio.SeqAct_AkSetState.StateGroup
    // 0x160 (0x10)
    // (Edit | NeedCtorLink)
    public FString StateGroup {
        get => new(Pointer + 352);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 352), 16, 16);
    }

    // StrProperty AkAudio.SeqAct_AkSetState.State
    // 0x170 (0x10)
    // (Edit | NeedCtorLink)
    public FString State {
        get => new(Pointer + 368);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 368), 16, 16);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.SeqAct_AkSetState");
            return _staticClass;
        }
    }
}

// Class AkAudio.SeqAct_AkSetSwitch
// 0x20 (0x160 - 0x180)
// (Compiled | Parsed | Native)
public unsafe partial class USeqAct_AkSetSwitch : USequenceAction {
    public USeqAct_AkSetSwitch() { }
    public USeqAct_AkSetSwitch(nint pointer) : base(pointer) { }


    // StrProperty AkAudio.SeqAct_AkSetSwitch.SwitchGroup
    // 0x160 (0x10)
    // (Edit | NeedCtorLink)
    public FString SwitchGroup {
        get => new(Pointer + 352);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 352), 16, 16);
    }

    // StrProperty AkAudio.SeqAct_AkSetSwitch.Switch
    // 0x170 (0x10)
    // (Edit | NeedCtorLink)
    public FString Switch {
        get => new(Pointer + 368);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 368), 16, 16);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.SeqAct_AkSetSwitch");
            return _staticClass;
        }
    }
}

// Class AkAudio.SeqAct_AkStartAmbientSound
// 0x0 (0x160 - 0x160)
// (Compiled | Parsed | Native | HideDropDown)
public unsafe partial class USeqAct_AkStartAmbientSound : USequenceAction {
    public USeqAct_AkStartAmbientSound() { }
    public USeqAct_AkStartAmbientSound(nint pointer) : base(pointer) { }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.SeqAct_AkStartAmbientSound");
            return _staticClass;
        }
    }
}

// Class AkAudio.SeqAct_AkStopAll
// 0x0 (0x160 - 0x160)
// (Compiled | Parsed | Native)
public unsafe partial class USeqAct_AkStopAll : USequenceAction {
    public USeqAct_AkStopAll() { }
    public USeqAct_AkStopAll(nint pointer) : base(pointer) { }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.SeqAct_AkStopAll");
            return _staticClass;
        }
    }
}

// Class AkAudio.AkAudioDevice
// 0x148 (0x68 - 0x1B0)
// (Config | Transient | Native | Intrinsic)
public unsafe partial class UAkAudioDevice : USubsystem {
    public UAkAudioDevice() { }
    public UAkAudioDevice(nint pointer) : base(pointer) { }


    // MISSED OFFSET: 0x10

    // IntProperty AkAudio.AkAudioDevice.MaxNumMemoryPools
    // 0x78 (0x4)
    // (Config)
    public int MaxNumMemoryPools {
        get => *(int*)(Pointer + 120);
        set => *(int*)(Pointer + 120) = value;
    }

    // IntProperty AkAudio.AkAudioDevice.DefaultMemoryPoolKB
    // 0x7C (0x4)
    // (Config)
    public int DefaultMemoryPoolKB {
        get => *(int*)(Pointer + 124);
        set => *(int*)(Pointer + 124) = value;
    }

    // IntProperty AkAudio.AkAudioDevice.DefaultEngineMemoryPoolKB
    // 0x80 (0x4)
    // (Config)
    public int DefaultEngineMemoryPoolKB {
        get => *(int*)(Pointer + 128);
        set => *(int*)(Pointer + 128) = value;
    }

    // IntProperty AkAudio.AkAudioDevice.WwiseBusSendBufferSamples
    // 0x84 (0x4)
    // (Config)
    public int WwiseBusSendBufferSamples {
        get => *(int*)(Pointer + 132);
        set => *(int*)(Pointer + 132) = value;
    }

    // BoolProperty AkAudio.AkAudioDevice.DebugRecordWwiseBusSends
    // 0x88 (0x4)
    // Bitmask: 0x00000001
    // (Config)
    public bool DebugRecordWwiseBusSends {
        get => (*(uint*)(Pointer + 136) & 0x1) != 0;
        set {
            if (value) *(uint*)(Pointer + 136) |= 0x1;
            else *(uint*)(Pointer + 136) &= ~(uint)0x1;
        }
    }

    // FloatProperty AkAudio.AkAudioDevice.LowMemoryThreshold
    // 0x8C (0x4)
    // (Config)
    public float LowMemoryThreshold {
        get => *(float*)(Pointer + 140);
        set => *(float*)(Pointer + 140) = value;
    }

    // MISSED OFFSET: 0x120


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.AkAudioDevice");
            return _staticClass;
        }
    }
}

// Class AkAudio.AkAmbientSoundActor
// 0x8 (0x270 - 0x278)
// (Compiled | Parsed | Placeable | Hidden)
public unsafe partial class AAkAmbientSoundActor : AKeypoint {
    public AAkAmbientSoundActor() { }
    public AAkAmbientSoundActor(nint pointer) : base(pointer) { }


    // ComponentProperty AkAudio.AkAmbientSoundActor.PlaySoundComponent
    // 0x270 (0x8)
    // (Edit | ExportObject | Component | EditInline)
    public UAkPlaySoundComponent PlaySoundComponent {
        get {
            var pointer = *(nint*)(Pointer + 624);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 624) = value.Pointer;
    }


    // Function AkAudio.AkAmbientSoundActor.OnToggle
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class OnToggle_Parameters : BaseObject {
        public OnToggle_Parameters() { }
        public OnToggle_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.AkAmbientSoundActor.OnToggle.Action
        // 0x0 (0x8)
        // (Param)
        public USeqAct_Toggle Action {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }
    }
    private static UFunction _ptrOnToggle;
    public void OnToggle(USeqAct_Toggle Action) {
        _ptrOnToggle ??= FindFunction("Function AkAudio.AkAmbientSoundActor.OnToggle");

        var @params = stackalloc byte[8];
        System.Buffer.MemoryCopy((void*)Action.Pointer, @params, 8, 8);

        ProcessEvent(_ptrOnToggle, @params);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.AkAmbientSoundActor");
            return _staticClass;
        }
    }
}

// Class AkAudio.SeqEvent_AkMusicCue
// 0x14 (0x17C - 0x190)
// (Compiled | Parsed)
public unsafe partial class USeqEvent_AkMusicCue : USequenceEvent {
    public USeqEvent_AkMusicCue() { }
    public USeqEvent_AkMusicCue(nint pointer) : base(pointer) { }


    // MISSED OFFSET: 0x4

    // StrProperty AkAudio.SeqEvent_AkMusicCue.CueName
    // 0x180 (0x10)
    // (NeedCtorLink)
    public FString CueName {
        get => new(Pointer + 384);
        set => System.Buffer.MemoryCopy((void*)value.Pointer, (void*)(Pointer + 384), 16, 16);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.SeqEvent_AkMusicCue");
            return _staticClass;
        }
    }
}

// Class AkAudio.SeqAct_AkPlaySoundAndSeek
// 0x18 (0x160 - 0x178)
// (Compiled | Parsed | Hidden)
public unsafe partial class USeqAct_AkPlaySoundAndSeek : USequenceAction {
    public USeqAct_AkPlaySoundAndSeek() { }
    public USeqAct_AkPlaySoundAndSeek(nint pointer) : base(pointer) { }


    // ObjectProperty AkAudio.SeqAct_AkPlaySoundAndSeek.SoundCue
    // 0x160 (0x8)
    // (Edit)
    public UAkSoundCue SoundCue {
        get {
            var pointer = *(nint*)(Pointer + 352);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 352) = value.Pointer;
    }

    // FloatProperty AkAudio.SeqAct_AkPlaySoundAndSeek.StartLocationSeconds
    // 0x168 (0x4)
    // (Edit)
    public float StartLocationSeconds {
        get => *(float*)(Pointer + 360);
        set => *(float*)(Pointer + 360) = value;
    }

    // MISSED OFFSET: 0x4

    // ComponentProperty AkAudio.SeqAct_AkPlaySoundAndSeek.SoundSource
    // 0x170 (0x8)
    // (ExportObject | Transient | Component | EditInline)
    public UAkSoundSource SoundSource {
        get {
            var pointer = *(nint*)(Pointer + 368);
            return pointer != nint.Zero ? new(pointer) : null;
        }
        set => *(nint*)(Pointer + 368) = value.Pointer;
    }


    // Function AkAudio.SeqAct_AkPlaySoundAndSeek.ToggleSoundFor
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ToggleSoundFor_Parameters : BaseObject {
        public ToggleSoundFor_Parameters() { }
        public ToggleSoundFor_Parameters(nint pointer) : base(pointer) { }

        // ObjectProperty AkAudio.SeqAct_AkPlaySoundAndSeek.ToggleSoundFor.A
        // 0x0 (0x8)
        // (Param)
        public AActor A {
            get {
                var pointer = *(nint*)Pointer;
                return pointer != nint.Zero ? new(pointer) : null;
            }
            set => *(nint*)Pointer = value.Pointer;
        }

        // BoolProperty AkAudio.SeqAct_AkPlaySoundAndSeek.ToggleSoundFor.bPlay
        // 0x8 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bPlay {
            get => (*(uint*)(Pointer + 8) & 0x1) != 0;
            set {
                if (value) *(uint*)(Pointer + 8) |= 0x1;
                else *(uint*)(Pointer + 8) &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrToggleSoundFor;
    public void ToggleSoundFor(AActor A, bool bPlay) {
        _ptrToggleSoundFor ??= FindFunction("Function AkAudio.SeqAct_AkPlaySoundAndSeek.ToggleSoundFor");

        var @params = stackalloc byte[12];
        System.Buffer.MemoryCopy((void*)A.Pointer, @params, 8, 8);
        System.Buffer.MemoryCopy(&bPlay, @params + 8, 4, 4);

        ProcessEvent(_ptrToggleSoundFor, @params);
    }

    // Function AkAudio.SeqAct_AkPlaySoundAndSeek.ToggleSound
    // 0x3750E0
    // (Final | Defined | Public)
    public unsafe class ToggleSound_Parameters : BaseObject {
        public ToggleSound_Parameters() { }
        public ToggleSound_Parameters(nint pointer) : base(pointer) { }

        // BoolProperty AkAudio.SeqAct_AkPlaySoundAndSeek.ToggleSound.bPlay
        // 0x0 (0x4)
        // Bitmask: 0x00000001
        // (Param)
        public bool bPlay {
            get => (*(uint*)Pointer & 0x1) != 0;
            set {
                if (value) *(uint*)Pointer |= 0x1;
                else *(uint*)Pointer &= ~(uint)0x1;
            }
        }
    }
    private static UFunction _ptrToggleSound;
    public void ToggleSound(bool bPlay) {
        _ptrToggleSound ??= FindFunction("Function AkAudio.SeqAct_AkPlaySoundAndSeek.ToggleSound");

        var @params = stackalloc byte[4];
        System.Buffer.MemoryCopy(&bPlay, @params, 4, 4);

        ProcessEvent(_ptrToggleSound, @params);
    }

    // Function AkAudio.SeqAct_AkPlaySoundAndSeek.Activated
    // 0x3750E0
    // (Defined | Event | Public)
    public unsafe class Activated_Parameters : BaseObject {
        public Activated_Parameters() { }
        public Activated_Parameters(nint pointer) : base(pointer) { }
    }
    private static UFunction _ptrActivated;
    public void Activated() {
        _ptrActivated ??= FindFunction("Function AkAudio.SeqAct_AkPlaySoundAndSeek.Activated");

        ProcessEvent(_ptrActivated, null);
    }


    private static UClass _staticClass;
    public static UClass StaticClass {
        get {
            _staticClass ??= FindClass("Class AkAudio.SeqAct_AkPlaySoundAndSeek");
            return _staticClass;
        }
    }
}

#pragma warning restore CS0108, CS0114
