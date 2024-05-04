using PastelExtended;
using RLDumper.Core.Classes;
using RLDumper.Core.Models;
using RLDumper.Core.OutputFormats;
using RLLoader.Shared;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using Windows.Win32;
using Windows.Win32.Foundation;

namespace RLDumper.Core;

// Shut the fuck up
#pragma warning disable CA1416 // Validate platform compatibility

public static class RLDumper {
    public static Logger Logger { get; private set; }
    public static Process Process { get; private set; }
    public static bool IsExternal { get; private set; }
    public static nint BaseAddress { get; private set; }
    private static HANDLE ReaderHandle { get; set; }

    public static PointerTArray<FNameEntry> GNames { get; private set; }
    public static PointerTArray<UObject> GObjects { get; private set; }
    public static List<Package> Packages { get; private set; } = [];

    public static void Init(Process process, bool external) {
        Logger = new("RLDumper");
        Process = process;
        IsExternal = external;

        Logger.InfoLine($"Initializing Dumper...");

        if (IsExternal) {
            ReaderHandle = PInvoke.OpenProcess(Windows.Win32.System.Threading.PROCESS_ACCESS_RIGHTS.PROCESS_VM_READ, false, (uint)process.Id);
        }

        var processModule = process.MainModule;
        BaseAddress = processModule.BaseAddress;
        var processModuleInMemory = ReadRawMemory(BaseAddress, processModule.ModuleMemorySize);


        var gNamesRva = Offsets.GetGNamesRVA(processModuleInMemory);

        if (gNamesRva == -1) {
            Logger.ErrorLine($"Failed to find GNames! Exiting...");
            return;
        }

        Logger.VerboseLine($"GNames RVA: 0x{gNamesRva:X}");

        var gObjectsRva = Offsets.GetGObjectsRVA(processModuleInMemory);
        if (gObjectsRva == -1) {
            Logger.ErrorLine($"Failed to find GObjects! Exiting...");
            return;
        }

        Logger.VerboseLine($"GObjects RVA: 0x{gObjectsRva:X}");


        GNames = new PointerTArray<FNameEntry>(processModule.BaseAddress + gNamesRva);
        Logger.VerboseLine($"GNames count: {GNames.Count}");

        GObjects = new PointerTArray<UObject>(processModule.BaseAddress + gObjectsRva);
        Logger.VerboseLine($"GObjects count: {GObjects.Count}");
    }

    public static void BuildModels() {
        // Don't dump again if we already did it once
        if (Packages.Count > 0) return;

        var stopwatch = new Stopwatch();

        Logger.InfoLine($"Starting model building...");

        stopwatch.Start();

        foreach (var uObject in GObjects) {
            if (uObject == null)
                continue;

            if (uObject.GetName().StartsWith("Default__")) continue;

            if (uObject.IsA<UClass>()) {
                var package = uObject.GetPackage();
                var packageFullName = package.GetFullName();
                var modelPackage = Packages.Where(p => p.FullName == packageFullName).FirstOrDefault();
                if (modelPackage == null) {
                    modelPackage = new Package() {
                        FullName = packageFullName
                    };

                    Logger.InfoLine($"New package: {package.GetName().Fg(Color.LightGreen)}");

                    Packages.Add(modelPackage);
                }

                modelPackage.Classes.Add(Class.BuildClass(uObject.As<UClass>()));
            }
            // FOR SOME REASON SOME STRUCTS ARE MISSING FROM THEIR CLASSES REFLECTION?????????? (ScriptStruct Engine.StaticMesh.StaticMeshLODInfo for example, is not on children)
            else if (uObject.IsA<UScriptStruct>()) {
                var builtClass = Class.BuildClass(uObject.Outer.As<UClass>());
                var builtStruct = Struct.BuildStruct(uObject.As<UStruct>());

                if (!builtClass.Structs.Contains(builtStruct))
                    builtClass.Structs.Add(builtStruct);
            }
            // Just to not risk missing anything, I'll do the same with the other types.
            else if (uObject.IsA<UFunction>()) {
                var builtClass = Class.BuildClass(uObject.Outer.As<UClass>());
                var builtFunction = Function.BuildFunction(uObject.As<UFunction>());

                if (!builtClass.Functions.Contains(builtFunction))
                    builtClass.Functions.Add(builtFunction);
            }
            else if (uObject.IsA<UConst>()) {
                var builtClass = Class.BuildClass(uObject.Outer.As<UClass>());
                var builtConst = Const.BuildConst(uObject.As<UConst>());

                if (!builtClass.Constants.Contains(builtConst))
                    builtClass.Constants.Add(builtConst);
            }
            else if (uObject.IsA<UEnum>()) {
                var builtClass = Class.BuildClass(uObject.Outer.As<UClass>());
                var builtEnum = Models.Enum.BuildEnum(uObject.As<UEnum>());

                if (!builtClass.Enums.Contains(builtEnum))
                    builtClass.Enums.Add(builtEnum);
            }
        }
        stopwatch.Stop();

        Logger.InfoLine($"Time taken to build models: {stopwatch.Elapsed.ToString().Fg(Color.LightGreen)}");
    }

    public static void DumpCSSDK(string outputPath) {
        var stopwatch = new Stopwatch();
        Logger.InfoLine($"Writing C# SDK Dump to folder...");
        stopwatch.Start();
        CSharp.OutputToFolder(Packages, Path.Combine(outputPath, "SDK"));
        stopwatch.Stop();
        Logger.InfoLine($"Time taken to dump C# SDK: {stopwatch.Elapsed.ToString().Fg(Color.LightGreen)}");
    }

    public static void DumpJSONSDK(string outputPath) {
        var stopwatch = new Stopwatch();
        Logger.InfoLine($"Writing JSON SDK Dump to folder...");
        stopwatch.Start();
        // JSON.OutputToFolder(packages, outputPath);
        stopwatch.Stop();
        Logger.InfoLine($"Time taken to dump JSON SDK: {stopwatch.Elapsed.ToString().Fg(Color.LightGreen)}");
    }

    public static void DumpNames(string outputPath) {
        var stopwatch = new Stopwatch();
        Logger.InfoLine("Writing Names Dump to folder...");
        stopwatch.Start();

        using var writer = new StreamWriter(Path.Combine(outputPath, "NamesDump.txt"));
        for (var i = 0; i < GNames.Count; i++) {
            var entry = GNames[i];
            if (entry != null) {
                writer.WriteLine($"[{entry.Address:X}] [{i}] {entry.Name}");
            }
        }

        writer.Close();
        stopwatch.Stop();

        Logger.InfoLine($"Time taken to write names: {stopwatch.Elapsed.ToString().Fg(Color.LightGreen)}");
    }

    public static void DumpObjects(string outputPath) {
        var stopwatch = new Stopwatch();
        Logger.InfoLine("Writing Objects Dump to folder...");
        stopwatch.Start();

        using var writer = new StreamWriter(Path.Combine(outputPath, "ObjectsDump.txt"));
        for (var i = 0; i < GObjects.Count; i++) {
            var obj = GObjects[i];
            if (obj != null) {
                writer.WriteLine($"[{obj.Address:X}] [{i}] {obj.GetFullName()}");
            }
        }

        writer.Close();
        stopwatch.Stop();

        Logger.InfoLine($"Time taken to write objects: {stopwatch.Elapsed.ToString().Fg(Color.LightGreen)}");
    }

    public static unsafe T ReadMemory<T>(nint address) where T : unmanaged {
        if (IsExternal) {
            T result = new();
            var size = (nuint)Marshal.SizeOf<T>();

            _ = PInvoke.ReadProcessMemory(ReaderHandle, (void*)address, &result, size);

            return result;
        }
        else
            return *(T*)address;
    }

    public static unsafe byte[] ReadRawMemory(nint address, long size) {
        var buffer = new byte[size];

        fixed (void* bufferPtr = buffer) {
            if (IsExternal)
                _ = PInvoke.ReadProcessMemory(ReaderHandle, (void*)address, bufferPtr, (nuint)size);
            else
                Buffer.MemoryCopy((void*)address, bufferPtr, size, size);
        }

        return buffer;
    }

    public static unsafe string ReadString(nint address, int size) {
        var buffer = new char[size];

        fixed (char* bufferPtr = buffer) {
            if (IsExternal)
                _ = PInvoke.ReadProcessMemory(ReaderHandle, (void*)address, bufferPtr, (nuint)size * sizeof(char));
            else
                Buffer.MemoryCopy((void*)address, bufferPtr, size, size);

            return new string(bufferPtr);
        }
    }
}
