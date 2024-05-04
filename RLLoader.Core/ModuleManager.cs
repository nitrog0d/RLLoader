using ImGuiNET;
using RLLoader.SDK;
using RLLoader.Shared;
using System.Numerics;
using System.Runtime.InteropServices;
using Windows.Win32;
using Windows.Win32.UI.Input.KeyboardAndMouse;

namespace RLLoader.Core;

public static class ModuleManager {
    public static Logger Logger { get; private set; } = new("ModuleManager");

    public static List<Module> Modules { get; private set; } = [];

    private static bool ImGuiInitialized { get; set; }
    public static bool RenderImGui;
    private static bool ToggleImGuiCursor;
    private static bool LastGameCursorState;
    public static int SelectedModule { get; set; } = 0;

    private unsafe delegate void ProcessEvent(nint instance, nint function, nint @params, nint unusedResult);
    private static NativeDetour<ProcessEvent> ProcessEventHook;

    private unsafe delegate void ProcessInternal(nint instance, nint stack, nint unusedResult);
    private static NativeDetour<ProcessInternal> ProcessInternalHook;

    public class Event {
        public bool IsEnabled { get; set; }
        public Delegate Function { get; set; }
        public Type InstanceType { get; set; }
        public Type ArgumentType { get; set; }
        public bool IsPostfix { get; set; }
    }

    private static List<Event> RegisteredAllEvents = [];
    private static Dictionary<int, List<Event>> RegisteredEvents = [];


    public static void Init() {
        UObject.ProcessEventPointer = UObject.StaticClass.GetVTableFunction(67);
        Logger.VerboseLine($"UObject::ProcessEvent RVA: 0x{UObject.ProcessEventPointer - RLLoader.BaseAddress:X}");
        ProcessEventHook = new(UObject.ProcessEventPointer, ProcessEventDetour);

        // Non-native functions usually point to UObject::ProcessInternal
        var processInternalPtr = UObject.FindFunction("Function Core.Object.RSmoothInterpTo").Func;
        Logger.VerboseLine($"UObject::ProcessInternal RVA: 0x{processInternalPtr - RLLoader.BaseAddress:X}");
        ProcessInternalHook = new(processInternalPtr, ProcessInternalDetour);

        RegisterEvent("Function Engine.GameViewportClient.Tick", OnTick, true);
        RegisterEvent("Function Engine.GameViewportClient.SetHardwareMouseCursorVisibility", OnSetCursorVisibility);

        if (!ImGuiInitialized) {
            Logger.VerboseLine("Initializing ImGui...");

            CImGui.RegisterCreateContextCallback(OnContextCreated);
            CImGui.RegisterRenderEvent(OnRender);
            CImGui.RegisterInputEvent(OnNativeInput);

            if (CImGui.InitDirectX11Hook()) ImGuiInitialized = true;
            else Logger.ErrorLine("Failed to initialize DirectX11 Hook!");
        }
    }

    public static void RegisterModule(Module module) {
        module.Logger = new(module.GetType().Name);
        module.Index = Modules.Count;

        Modules.Add(module);

        module.OnLoad();
    }

    public static T GetModule<T>() where T : Module => (T)Modules.FirstOrDefault(m => m.GetType() == typeof(T));


    public static Event RegisterEvent(string functionFullName, Delegate function, bool postfix = false) {
        var uFunction = UObject.FindFunction(functionFullName) ?? throw new Exception($"Could not find function {functionFullName}!");
        if (postfix && function.Method.ReturnType != typeof(void)) throw new Exception("Postfixes can only return void!");

        if (!RegisteredEvents.TryGetValue(uFunction.ObjectInternalInteger, out var foundEntries)) {
            foundEntries = [];
            RegisteredEvents.Add(uFunction.ObjectInternalInteger, foundEntries);
        }

        Logger.VerboseLine($"Registering {(postfix ? "postfix" : "prefix")} {uFunction.GetFullName()} for {function.Method.DeclaringType.Name}.{function.Method.Name}");

        var methodParameters = function.Method.GetParameters();

        var newEvent = new Event() {
            IsEnabled = true,
            Function = function,
            InstanceType = methodParameters[0].ParameterType,
            ArgumentType = methodParameters[1].ParameterType,
            IsPostfix = postfix
        };

        foundEntries.Add(newEvent);

        return newEvent;
    }

    #region Events
    public static void OnTick(UGameViewportClient instance, UGameViewportClient.Tick_Parameters @params) {
        foreach (var module in Modules) {
            if (module.ShouldTick) module.OnTick();
        }

        if (ToggleImGuiCursor) {
            ToggleImGuiCursor = false;

            if (RenderImGui) instance.SetHardwareMouseCursorVisibility(true);
            else instance.SetHardwareMouseCursorVisibility(LastGameCursorState);
        }
    }

    public static bool OnSetCursorVisibility(UGameViewportClient instance, UGameViewportClient.SetHardwareMouseCursorVisibility_Parameters @params) {
        // Save game cursor state
        LastGameCursorState = @params.bIsVisible;

        // Cancel function if ImGui is rendering
        return !RenderImGui;
    }
    #endregion

    #region ImGui
    private static void OnContextCreated() {
        SetupImGui();
        Logger.InfoLine($"ImGui is ready!");
    }

    private static void OnRender() {
        try {
            if (RenderImGui) {
                ImGui.SetNextWindowSize(new Vector2(800, 800), ImGuiCond.FirstUseEver);
                ImGui.Begin("RLLoader", ref RenderImGui, ImGuiWindowFlags.NoCollapse);

                ImGui.BeginChild("LeftPane", new Vector2(170, 0), ImGuiChildFlags.Border);
                for (var i = 0; i < Modules.Count; i++) {
                    var module = Modules[i];
                    if (module.ShouldRender) {
                        if (ImGui.Selectable(module.Name, SelectedModule == i)) {
                            SelectedModule = i;
                        }
                    }
                }
                ImGui.EndChild();

                ImGui.SameLine();

                ImGui.BeginChild("RightPane");

                var currentModule = Modules[SelectedModule];

                ImGui.SeparatorText(currentModule.Name);
                Modules[SelectedModule].OnDraw();

                ImGui.EndChild();

                ImGui.End();
            }

            foreach (var module in Modules) {
                if (module.ShouldRender) module.OnDrawExternal();
            }
        }
        catch (Exception e) {
            Logger.ErrorLine($"Exception caught inside DirectX11 Render Hook!\n{e}");
        }
    }

    private static int OnNativeInput(nint hwnd, uint uMsg, ulong wParam, long lParam) {
        if (uMsg == PInvoke.WM_KEYDOWN && wParam == (ulong)VIRTUAL_KEY.VK_F1) {
            RenderImGui = !RenderImGui;
            ToggleImGuiCursor = true;
            return 1;
        }
        if (RenderImGui) {
            var io = ImGui.GetIO();
            if ((io.WantCaptureKeyboard || io.WantCaptureMouse) && IsMsgBlacklisted(uMsg)) return 1;
        }
        return 0;
    }

    private static bool IsMsgBlacklisted(uint uMsg) => uMsg switch {
        32 or 123 or 132 or 255 or 256 or 258 or 260 or 261 or 512 or 513 or 514 or 515 or 516 or 517 or 518 or 519 or 520 or 521 or 522 or 523 or 524 or 533 or 793 => true,
        _ => false,
    };

    private static void SetupImGui() {
        var style = ImGui.GetStyle();

        style.Alpha = 0.95f;
        style.DisabledAlpha = 0.10f;
        style.WindowPadding = new Vector2(8.0f, 8.0f);
        style.WindowRounding = 10.0f;
        style.WindowBorderSize = 0.0f;
        style.WindowMinSize = new Vector2(30.0f, 30.0f);
        style.WindowTitleAlign = new Vector2(0.01f, 0.5f);
        style.WindowMenuButtonPosition = ImGuiDir.Right;
        style.ChildRounding = 5.0f;
        style.ChildBorderSize = 1.0f;
        style.PopupRounding = 10.0f;
        style.PopupBorderSize = 0.0f;
        style.FramePadding = new Vector2(6.0f, 3.5f);
        style.FrameRounding = 6.0f;
        style.FrameBorderSize = 0.0f;
        style.ItemSpacing = new Vector2(6.0f, 5.0f);
        style.ItemInnerSpacing = new Vector2(5.0f, 5.0f);
        style.IndentSpacing = 5.0f;
        style.ColumnsMinSpacing = 5.0f;
        style.ScrollbarSize = 15.0f;
        style.ScrollbarRounding = 12.0f;
        style.GrabMinSize = 15.0f;
        style.GrabRounding = 5.0f;
        style.TabRounding = 5.0f;
        style.TabBorderSize = 0.0f;
        style.TabMinWidthForCloseButton = 0.0f;
        style.ColorButtonPosition = ImGuiDir.Right;
        style.ButtonTextAlign = new Vector2(0.5f, 0.5f);
        style.SelectableTextAlign = new Vector2(0.0f, 0.0f);


        var colors = style.Colors;

        colors[(int)ImGuiCol.Text] = new Vector4(1.00f, 1.00f, 1.00f, 1.00f);
        colors[(int)ImGuiCol.TextDisabled] = new Vector4(1.00f, 1.00f, 1.00f, 0.36f);
        colors[(int)ImGuiCol.WindowBg] = new Vector4(0.10f, 0.10f, 0.10f, 1.00f);
        colors[(int)ImGuiCol.ChildBg] = new Vector4(1.00f, 0.00f, 0.00f, 0.00f);
        colors[(int)ImGuiCol.PopupBg] = new Vector4(0.10f, 0.10f, 0.10f, 1.00f);
        colors[(int)ImGuiCol.Border] = new Vector4(0.42f, 0.38f, 0.57f, 0.55f);
        colors[(int)ImGuiCol.BorderShadow] = new Vector4(0.00f, 0.00f, 0.00f, 0.00f);
        colors[(int)ImGuiCol.FrameBg] = new Vector4(0.24f, 0.24f, 0.24f, 1.00f);
        colors[(int)ImGuiCol.FrameBgHovered] = new Vector4(0.62f, 0.58f, 0.77f, 0.46f);
        colors[(int)ImGuiCol.FrameBgActive] = new Vector4(0.62f, 0.58f, 0.77f, 0.55f);
        colors[(int)ImGuiCol.TitleBg] = new Vector4(0.10f, 0.10f, 0.10f, 1.00f);
        colors[(int)ImGuiCol.TitleBgActive] = new Vector4(0.17f, 0.17f, 0.17f, 1.00f);
        colors[(int)ImGuiCol.TitleBgCollapsed] = new Vector4(0.26f, 0.26f, 0.26f, 0.20f);
        colors[(int)ImGuiCol.MenuBarBg] = new Vector4(0.00f, 0.00f, 0.00f, 0.00f);
        colors[(int)ImGuiCol.ScrollbarBg] = new Vector4(0.16f, 0.16f, 0.16f, 0.00f);
        colors[(int)ImGuiCol.ScrollbarGrab] = new Vector4(0.16f, 0.16f, 0.16f, 1.00f);
        colors[(int)ImGuiCol.ScrollbarGrabHovered] = new Vector4(0.24f, 0.24f, 0.24f, 1.00f);
        colors[(int)ImGuiCol.ScrollbarGrabActive] = new Vector4(0.29f, 0.29f, 0.29f, 1.00f);
        colors[(int)ImGuiCol.CheckMark] = new Vector4(0.86f, 0.86f, 0.86f, 1.00f);
        colors[(int)ImGuiCol.SliderGrab] = new Vector4(0.62f, 0.58f, 0.77f, 0.55f);
        colors[(int)ImGuiCol.SliderGrabActive] = new Vector4(0.82f, 0.77f, 0.96f, 0.55f);
        colors[(int)ImGuiCol.Button] = new Vector4(0.62f, 0.58f, 0.77f, 0.55f);
        colors[(int)ImGuiCol.ButtonHovered] = new Vector4(0.74f, 0.69f, 0.89f, 0.55f);
        colors[(int)ImGuiCol.ButtonActive] = new Vector4(0.82f, 0.77f, 0.96f, 0.55f);
        colors[(int)ImGuiCol.Header] = new Vector4(0.62f, 0.58f, 0.77f, 0.55f);
        colors[(int)ImGuiCol.HeaderHovered] = new Vector4(0.74f, 0.69f, 0.89f, 0.55f);
        colors[(int)ImGuiCol.HeaderActive] = new Vector4(0.82f, 0.77f, 0.96f, 0.55f);
        colors[(int)ImGuiCol.Separator] = new Vector4(0.62f, 0.58f, 0.77f, 0.55f);
        colors[(int)ImGuiCol.SeparatorHovered] = new Vector4(0.74f, 0.69f, 0.89f, 0.55f);
        colors[(int)ImGuiCol.SeparatorActive] = new Vector4(0.82f, 0.77f, 0.96f, 0.55f);
        colors[(int)ImGuiCol.ResizeGrip] = new Vector4(0.62f, 0.58f, 0.77f, 0.55f);
        colors[(int)ImGuiCol.ResizeGripHovered] = new Vector4(0.74f, 0.69f, 0.89f, 0.55f);
        colors[(int)ImGuiCol.ResizeGripActive] = new Vector4(0.82f, 0.77f, 0.96f, 0.55f);
        colors[(int)ImGuiCol.Tab] = new Vector4(0.62f, 0.58f, 0.77f, 0.55f);
        colors[(int)ImGuiCol.TabHovered] = new Vector4(0.74f, 0.69f, 0.89f, 0.55f);
        colors[(int)ImGuiCol.TabActive] = new Vector4(0.82f, 0.77f, 0.96f, 0.55f);
        colors[(int)ImGuiCol.TabUnfocused] = new Vector4(0.00f, 0.45f, 1.00f, 0.00f);
        colors[(int)ImGuiCol.TabUnfocusedActive] = new Vector4(0.13f, 0.26f, 0.42f, 0.00f);
        colors[(int)ImGuiCol.PlotLines] = new Vector4(0.29f, 0.29f, 0.29f, 1.00f);
        colors[(int)ImGuiCol.PlotLinesHovered] = new Vector4(0.74f, 0.69f, 0.89f, 0.55f);
        colors[(int)ImGuiCol.PlotHistogram] = new Vector4(0.62f, 0.58f, 0.77f, 0.55f);
        colors[(int)ImGuiCol.PlotHistogramHovered] = new Vector4(0.74f, 0.69f, 0.89f, 0.55f);
        colors[(int)ImGuiCol.TableHeaderBg] = new Vector4(0.19f, 0.19f, 0.20f, 1.00f);
        colors[(int)ImGuiCol.TableBorderStrong] = new Vector4(0.42f, 0.38f, 0.57f, 0.55f);
        colors[(int)ImGuiCol.TableBorderLight] = new Vector4(0.42f, 0.38f, 0.57f, 0.29f);
        colors[(int)ImGuiCol.TableRowBg] = new Vector4(0.00f, 0.00f, 0.00f, 0.00f);
        colors[(int)ImGuiCol.TableRowBgAlt] = new Vector4(1.00f, 1.00f, 1.00f, 0.03f);
        colors[(int)ImGuiCol.TextSelectedBg] = new Vector4(0.74f, 0.69f, 0.89f, 0.55f);
        colors[(int)ImGuiCol.DragDropTarget] = new Vector4(1.00f, 1.00f, 0.00f, 0.90f);
        colors[(int)ImGuiCol.NavHighlight] = new Vector4(0.00f, 0.00f, 0.00f, 1.00f);
        colors[(int)ImGuiCol.NavWindowingHighlight] = new Vector4(1.00f, 1.00f, 1.00f, 0.70f);

        var io = ImGui.GetIO();

        var fontBytes = Convert.FromBase64String(RobotoMediumFont.Base64);
        var fontPtr = Marshal.AllocHGlobal(fontBytes.Length);
        Marshal.Copy(fontBytes, 0, fontPtr, fontBytes.Length);

        io.Fonts.AddFontFromMemoryTTF(fontPtr, fontBytes.Length, 16f);

        io.Fonts.AddFontDefault();

        unsafe {
            var iniFilenamePtr = Marshal.StringToHGlobalAnsi("rlloader_imgui.ini");
            io.NativePtr->IniFilename = (byte*)iniFilenamePtr;
        }

        var configFlags = io.ConfigFlags;
        configFlags |= ImGuiConfigFlags.NoMouseCursorChange;
        io.ConfigFlags = configFlags;
    }
    #endregion

    #region Detours
    // To stop multiple events (PE can redirect to PI when it's a non-native function)
    private static (nint, nint) LastPEFunction = (0, 0);

    public static void ProcessEventDetour(nint instance, nint function, nint @params, nint unusedResult) {
        try {
            LastPEFunction = (instance, function);

            // Called by us, ignore.
            if (unusedResult == 1) {
                ProcessEventHook.Trampoline(instance, function, @params, unusedResult);
                return;
            }

            var uFunction = new UFunction(function);

            if (RegisteredEvents.TryGetValue(uFunction.ObjectInternalInteger, out var foundEntries)) {
                var shouldCancel = false;
                foreach (var entry in foundEntries) {
                    if (!entry.IsPostfix && entry.IsEnabled) {
                        var returnValue = entry.Function.DynamicInvoke(Activator.CreateInstance(entry.InstanceType, instance), Activator.CreateInstance(entry.ArgumentType, @params)) as bool?;
                        // Prefixes can return false to cancel the execution
                        if (returnValue.HasValue && !returnValue.Value) shouldCancel = true;
                    }
                }

                if (shouldCancel)
                    return;

                ProcessEventHook.Trampoline(instance, function, @params, unusedResult);

                foreach (var entry in foundEntries) {
                    if (entry.IsPostfix && entry.IsEnabled) entry.Function.DynamicInvoke(Activator.CreateInstance(entry.InstanceType, instance), Activator.CreateInstance(entry.ArgumentType, @params));
                }
            }
            else ProcessEventHook.Trampoline(instance, function, @params, unusedResult);
        }
        catch (Exception e) {
            Logger.ErrorLine($"Unhandled Exception on ProcessEvent hook!\n{e}");
        }
    }

    public static void ProcessInternalDetour(nint instance, nint stack, nint unusedResult) {
        try {
            var frame = new FFrame(stack);

            if (LastPEFunction == (instance, frame.Node.Pointer)) {
                ProcessInternalHook.Trampoline(instance, stack, unusedResult);
                return;
            }

            var uFunction = frame.Node.As<UFunction>();

            if (RegisteredEvents.TryGetValue(uFunction.ObjectInternalInteger, out var foundEntries)) {
                var shouldCancel = false;

                foreach (var entry in foundEntries) {
                    if (!entry.IsPostfix && entry.IsEnabled) {
                        var returnValue = entry.Function.DynamicInvoke(Activator.CreateInstance(entry.InstanceType, instance), Activator.CreateInstance(entry.ArgumentType, frame.Locals)) as bool?;
                        // Prefixes can return false to cancel the execution
                        if (returnValue.HasValue && !returnValue.Value) shouldCancel = true;
                    }
                }

                if (shouldCancel)
                    return;

                ProcessInternalHook.Trampoline(instance, stack, unusedResult);

                foreach (var entry in foundEntries) {
                    if (entry.IsPostfix && entry.IsEnabled) entry.Function.DynamicInvoke(Activator.CreateInstance(entry.InstanceType, instance), Activator.CreateInstance(entry.ArgumentType, frame.Locals));
                }
            }
            else ProcessInternalHook.Trampoline(instance, stack, unusedResult);
        }
        catch (Exception e) {
            Logger.ErrorLine($"Unhandled Exception on ProcessInternal hook!\n{e}");
        }
    }
    #endregion
}

public static partial class CImGui {
    private static readonly List<Delegate> DontGcDelegates = [];

    [LibraryImport("cimgui", EntryPoint = "evil_InitDirectX11Hook")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static unsafe partial bool InitDirectX11Hook();


    public delegate void CreateContextCallbackDelegate();

    [LibraryImport("cimgui", EntryPoint = "evil_RegisterCreateContextCallback")]
    public static unsafe partial void evil_RegisterCreateContextCallback(nint function);

    public unsafe static void RegisterCreateContextCallback(CreateContextCallbackDelegate method) {
        DontGcDelegates.Add(method);
        evil_RegisterCreateContextCallback(Marshal.GetFunctionPointerForDelegate(method));
    }

    [LibraryImport("cimgui", EntryPoint = "evil_UnregisterCreateContextCallback")]
    public static unsafe partial void evil_UnregisterCreateContextCallback(nint function);

    public unsafe static void UnregisterCreateContextCallback(CreateContextCallbackDelegate method) {
        DontGcDelegates.Remove(method);
        evil_UnregisterCreateContextCallback(Marshal.GetFunctionPointerForDelegate(method));
    }


    public delegate void RenderEventDelegate();

    [LibraryImport("cimgui", EntryPoint = "evil_RegisterRenderEvent")]
    public static unsafe partial void evil_RegisterRenderEvent(nint function);

    public unsafe static void RegisterRenderEvent(RenderEventDelegate method) {
        DontGcDelegates.Add(method);
        evil_RegisterRenderEvent(Marshal.GetFunctionPointerForDelegate(method));
    }

    [LibraryImport("cimgui", EntryPoint = "evil_UnregisterRenderEvent")]
    public static unsafe partial void evil_UnregisterRenderEvent(nint function);

    public unsafe static void UnregisterRenderEvent(RenderEventDelegate method) {
        DontGcDelegates.Remove(method);
        evil_UnregisterRenderEvent(Marshal.GetFunctionPointerForDelegate(method));
    }


    public delegate int InputEventDelegate(nint hwnd, uint uMsg, ulong wParam, long lParam);

    [LibraryImport("cimgui", EntryPoint = "evil_RegisterInputEvent")]
    public static unsafe partial void evil_RegisterInputEvent(nint function);

    public unsafe static void RegisterInputEvent(InputEventDelegate method) {
        DontGcDelegates.Add(method);
        evil_RegisterInputEvent(Marshal.GetFunctionPointerForDelegate(method));
    }

    [LibraryImport("cimgui", EntryPoint = "evil_UnregisterInputEvent")]
    public static unsafe partial void evil_UnregisterInputEvent(nint function);

    public unsafe static void UnregisterInputEvent(InputEventDelegate method) {
        DontGcDelegates.Remove(method);
        evil_UnregisterInputEvent(Marshal.GetFunctionPointerForDelegate(method));
    }
}