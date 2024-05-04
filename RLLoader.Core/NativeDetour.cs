// The child of my favorite baby EvilLoader & mom MelonLoader
using System.Runtime.InteropServices;

namespace RLLoader.Core;

public static partial class NativeLib {
    public static readonly List<Delegate> DontGcDelegates = [];


    [LibraryImport("cimgui", EntryPoint = "evil_Polyhook_Create")]
    public static unsafe partial nint Polyhook_Create(nint target, nint replacement, ref nint originalCall);

    [LibraryImport("cimgui", EntryPoint = "evil_Polyhook_Hook")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool Polyhook_Hook(nint detour);

    [LibraryImport("cimgui", EntryPoint = "evil_Polyhook_Unhook")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool Polyhook_Unhook(nint detour);
}

public unsafe class NativeDetour<T> where T : Delegate {
    #region Private Values
    private nint _polyhookInstance;
    private nint _targetHandle;
    private nint _detourHandle;
    private nint _trampolineHandle;
    private T _trampoline;
    #endregion

    #region Public Properties
    public nint Target {
        get => _targetHandle;

        set {
            if (value == nint.Zero)
                throw new ArgumentNullException(nameof(value));

            _targetHandle = value;
        }
    }

    public nint Detour {
        get => _detourHandle;

        set {
            if (value == nint.Zero)
                throw new ArgumentNullException(nameof(value));

            _detourHandle = value;
        }
    }

    public T Trampoline {
        get {
            if (_trampolineHandle == nint.Zero)
                throw new NullReferenceException("_trampolineHandle");

            if (_trampoline == null) {
                _trampoline = Marshal.GetDelegateForFunctionPointer<T>(_trampolineHandle);
            }

            return _trampoline;
        }
    }

    public bool IsHooked { get; private set; }
    #endregion

    public NativeDetour() { }

    public unsafe NativeDetour(nint target, T detour, bool autoAttach = true) {
        if (target == nint.Zero)
            throw new ArgumentNullException(nameof(target));

        if (detour == null)
            throw new ArgumentNullException(nameof(detour));

        _targetHandle = target;
        NativeLib.DontGcDelegates.Add(detour);
        _detourHandle = Marshal.GetFunctionPointerForDelegate(detour);

        _polyhookInstance = NativeLib.Polyhook_Create(_targetHandle, _detourHandle, ref _trampolineHandle);

        if (autoAttach)
            Attach();
    }

    public unsafe NativeDetour(nint target, nint detour, bool autoAttach = true) {
        if (target == nint.Zero)
            throw new ArgumentNullException(nameof(target));

        if (detour == nint.Zero)
            throw new ArgumentNullException(nameof(detour));

        _targetHandle = target;
        _detourHandle = detour;

        _polyhookInstance = NativeLib.Polyhook_Create(_targetHandle, _detourHandle, ref _trampolineHandle);

        if (autoAttach)
            Attach();
    }

    public unsafe void Attach() {
        if (IsHooked)
            return;

        if (_targetHandle == nint.Zero)
            throw new NullReferenceException("The Native Detour's target has not been set!");

        if (_detourHandle == nint.Zero)
            throw new NullReferenceException("The Native Detour's detour has not been set!");

        if (!NativeLib.Polyhook_Hook(_polyhookInstance))
            throw new Exception($"Failed to attach detour!");

        IsHooked = true;
    }

    public unsafe void Detach() {
        if (!IsHooked)
            return;

        if (_targetHandle == nint.Zero)
            throw new NullReferenceException("The Native Detour's target has not been set!");

        if (!NativeLib.Polyhook_Unhook(_polyhookInstance))
            throw new Exception($"Failed to detach detour!");

        IsHooked = false;

        _trampoline = null;
        _trampolineHandle = nint.Zero;
    }
}