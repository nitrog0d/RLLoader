using ImGuiNET;
using RLLoader.SDK;
using RLLoader.Shared;
using System.Diagnostics;
using System.Text.Json;

namespace RLLoader.Core.Modules;

public class DumperModule : Module {
    private string OutputPath = @"C:\Users\Lucas\Desktop\Programming\CSharp\RLLoader\RLLoader.SDK";
    private bool Initialized = false;
    private bool DumpCSSDK = false;
    private bool DumpJSONSDK = false;
    private bool DumpNames = false;
    private bool DumpObjects = false;
    private bool DumpNetObjects = false;

    public override void OnDraw() {
        ImGui.InputText("Output Path", ref OutputPath, 256);
        if (ImGui.Button("Dump C# SDK")) DumpCSSDK = true;
        if (ImGui.Button("Dump JSON SDK")) DumpJSONSDK = true;
        if (ImGui.Button("Dump Names")) DumpNames = true;
        if (ImGui.Button("Dump Objects")) DumpObjects = true;
        if (ImGui.Button("Dump Net Objects")) DumpNetObjects = true;
    }

    public unsafe override void OnTick() {
        if (DumpCSSDK) {
            DumpCSSDK = false;

            InitializeDumper();
            RLDumper.Core.RLDumper.BuildModels();
            RLDumper.Core.RLDumper.DumpCSSDK(OutputPath);
        }
        if (DumpJSONSDK) {
            DumpJSONSDK = false;

            InitializeDumper();
            RLDumper.Core.RLDumper.BuildModels();
            RLDumper.Core.RLDumper.DumpJSONSDK(OutputPath);
        }
        if (DumpNames) {
            DumpNames = false;

            InitializeDumper();
            RLDumper.Core.RLDumper.DumpNames(OutputPath);
        }
        if (DumpObjects) {
            DumpObjects = false;

            InitializeDumper();
            RLDumper.Core.RLDumper.DumpObjects(OutputPath);
        }
        if (DumpNetObjects) {
            DumpNetObjects = false;

            /*var createPackagePtr = RLLoader.BaseAddress + 0x3A7B40;
            fixed (char* packageStrPtr = "Archetypes") {
                var packagePtr = ((delegate* unmanaged<nint, char*, nint>)createPackagePtr)(nint.Zero, packageStrPtr);
                Logger.InfoLine($"ptr: {packagePtr:X}");
            }*/

            List<Package> packages = [];

            var loadPackagePtr = RLLoader.BaseAddress + PatternScanner.FindPattern("40 53 56 57 41 54 41 55 41 56 41 57 48 81 EC D0", RLLoader.Module);

            foreach (var packagePath in Directory.GetFiles(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "TAGame/CookedPCConsole"), "*.upk")) {
                var packageFile = Path.GetFileNameWithoutExtension(packagePath);

                if (packageFile == "OnlineSubsystemSteamworks" ||
                    packageFile == "ESportsTeam_FCBarcelona_SF" ||
                    packageFile == "playerbanner_FCBarcelona_SF" ||
                    packageFile == "PlayerBanner_FCBarcelona_T_SF" ||
                    packageFile == "Skin_MuscleCar_FCB_Esports_SF" ||
                    packageFile == "Skin_MuscleCar_FCB_Esports_T_SF" ||
                    packageFile == "Skin_Octane_FCB_Esports_SF" ||
                    packageFile == "Skin_Octane_FCB_Esports_T_SF" ||
                    packageFile == "paintfinish_semi-dized_SF" ||
                    packageFile == "PaintFinish_Semi-dized_T_SF") continue;

                var lowercase = packageFile.ToLower();
                if (lowercase.StartsWith("wheel_") ||
                    lowercase.StartsWith("ss_") ||
                    lowercase.StartsWith("skin_") ||
                    lowercase.StartsWith("playerbanner_") ||
                    lowercase.StartsWith("sfx_") ||
                    lowercase.StartsWith("paintfinish_") ||
                    lowercase.StartsWith("pack_") ||
                    lowercase.StartsWith("hat_") ||
                    lowercase.StartsWith("flag_") ||
                    lowercase.StartsWith("explosion_") ||
                    lowercase.StartsWith("engineaudio_") ||
                    lowercase.StartsWith("countryflag_") ||
                    lowercase.StartsWith("boost_") ||
                    lowercase.StartsWith("body_") ||
                    lowercase.StartsWith("avatarborder_") ||
                    lowercase.StartsWith("antenna_") ||
                    lowercase.StartsWith("anthem_") ||
                    lowercase.StartsWith("esportsteam_") ||
                    lowercase.StartsWith("album_") ||
                    lowercase.StartsWith("mx_") ||
                    lowercase.StartsWith("tourneyflag_") ||
                    lowercase.StartsWith("streamerflag_") ||
                    lowercase.StartsWith("skins_") ||
                    lowercase.StartsWith("shopitem_") ||
                    lowercase.StartsWith("pennant_") ||
                    lowercase.StartsWith("giftbox_")) continue;

                Logger.InfoLine($"{packageFile}");
                fixed (char* packageFilePtr = packageFile) {
                    var packagePtr = nint.Zero;
                    try {
                        packagePtr = ((delegate* unmanaged<nint, char*, int, nint>)loadPackagePtr)(nint.Zero, packageFilePtr, 0);
                    }
                    catch (Exception e) {
                        Logger.ErrorLine($"Failed to load package {packageFile}, {e.Message}");
                        continue;
                    }

                    if (packagePtr == nint.Zero) {
                        Logger.ErrorLine($"Failed to load package {packageFile}!");
                        continue;
                    }

                    var package = new UPackage(packagePtr);

                    var newPackage = DumpPackage(package);

                    if (newPackage != null) packages.Add(newPackage);

                    AWorldInfo.ForceGarbageCollection(true);
                }
            }

            foreach (var obj in UObject.GObjects) {
                if (obj != null && obj.IsA<UPackage>()) {
                    var existingPackage = packages.Where(p => p.Name == obj.GetName()).FirstOrDefault();
                    if (existingPackage != null) continue;

                    var newPackage = DumpPackage(obj.As<UPackage>());
                    if (newPackage != null) packages.Add(newPackage);
                }
            }

            File.WriteAllText(Path.Combine(OutputPath, "PackagesNetDump.json"), JsonSerializer.Serialize(packages, new JsonSerializerOptions() { WriteIndented = true }));
        }
    }

    public void InitializeDumper() {
        if (Initialized) return;
        Initialized = true;

        var process = Process.GetCurrentProcess();
        RLDumper.Core.RLDumper.Init(process, false);
    }

    #region DataStore Dumper

    #endregion

    #region Package NetObjects Dumper
    public Package DumpPackage(UPackage package) {
        var guid = package.Guid;
        var newPackage = new Package() {
            Name = package.GetName(),
            GUID = $"{guid.A:x}{guid.B:x}{guid.C:x}{guid.D:x}",
            GenerationNetObjectCount = package.GenerationNetObjectCount.Count
        };

        var netObjects = package.NetObjects;
        for (var i = 0; i < netObjects.Count; i++) {
            var obj = netObjects[i];
            newPackage.NetObjects.Add(new NetObject() {
                FullName = obj != null ? obj.GetFullName() : "None",
                Index = i
            });
        }

        return newPackage.NetObjects.Count > 0 ? newPackage: null;
    }

    public class NetObject {
        public int Index { get; set; }
        public string FullName { get; set; }
    }

    public class Package {
        public string Name { get; set; }
        public string GUID { get; set; }
        public int GenerationNetObjectCount { get; set; }
        public List<NetObject> NetObjects { get; set; } = [];
    }
    #endregion
}