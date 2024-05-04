using RLLoader.Core.Modules;
using RLLoader.SDK;
using RLLoader.Shared;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Windows.Win32;

namespace RLLoader.Core;

public static class RLLoader {
    private delegate nint LoadLibrary(nint lpLibFileName);
    // private static NativeDetour<LoadLibrary> LoadLibraryWHook;
    private static NativeDetour<LoadLibrary> LoadLibraryAHook;
    public static nint BaseAddress { get; private set; }
    public static byte[] Module { get; private set; }

    public unsafe static void HookLoadLibrary() {
        Console.Title = "RLLoader";

        // loadLibraryW = PInvoke.GetProcAddress(PInvoke.GetModuleHandle("kernel32.dll"), "LoadLibraryW");
        // LoadLibraryWHook = new(loadLibraryW, LoadLibraryWDetour);

        var loadLibraryA = PInvoke.GetProcAddress(PInvoke.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
        LoadLibraryAHook = new(loadLibraryA, LoadLibraryADetour);

        Logger.InfoLine($"Waiting for the game to initialize...");
    }

    private unsafe static void Init() {
        Logger.InfoLine($"Initializing...");

        var process = Process.GetCurrentProcess();
        var processModule = process.MainModule;
        BaseAddress = processModule.BaseAddress;
        var processModuleMemorySize = processModule.ModuleMemorySize;
        Module = new byte[processModuleMemorySize];

        fixed (void* ptr = Module) {
            Buffer.MemoryCopy((void*)processModule.BaseAddress, ptr, processModuleMemorySize, processModuleMemorySize);
        }
        var gNamesRva = Offsets.GetGNamesRVA(Module);

        if (gNamesRva == -1) {
            Logger.ErrorLine($"Failed to find GNames! Exiting...");
            return;
        }

        Logger.VerboseLine($"GNames RVA: 0x{gNamesRva:X}");

        var gObjectsRva = Offsets.GetGObjectsRVA(Module);
        if (gObjectsRva == -1) {
            Logger.ErrorLine($"Failed to find GObjects! Exiting...");
            return;
        }

        Logger.VerboseLine($"GObjects RVA: 0x{gObjectsRva:X}");

        UObject.InitSDK(processModule.BaseAddress + gNamesRva, processModule.BaseAddress + gObjectsRva);

        ModuleManager.Init();

        ModuleManager.RegisterModule(new AboutModule() { Name = "About", ShouldRender = true });
        ModuleManager.RegisterModule(new DumperModule() { Name = "Dumper", ShouldRender = true });
    }

    /*private static nint LoadLibraryWDetour(nint lpLibFileName) {
        var libName = Marshal.PtrToStringUni(lpLibFileName);

        var ret = LoadLibraryWHook.Trampoline(lpLibFileName);

        Logger.InfoLine($"Loaded library W: {libName}");

        return ret;
    }*/

    private static nint LoadLibraryADetour(nint lpLibFileName) {
        var libName = Marshal.PtrToStringAnsi(lpLibFileName);

        var ret = LoadLibraryAHook.Trampoline(lpLibFileName);

        // Logger.InfoLine($"Loaded library A: {libName}");

        // When dxgi is loaded, the window is already set up etc.
        if (libName == "dxgi.dll") {
            LoadLibraryAHook.Detach();
            Init();
        }

        return ret;
    }
}
