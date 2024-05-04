using ImGuiNET;
using Microsoft.Win32.SafeHandles;
using PastelExtended;
using RLLoader.SDK;
using RLLoader.Shared;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using Windows.Win32;

namespace RLLoader.Core.Modules;

public class AboutModule : Module {
    private string Version;
    private string CompileTime;
    private int GNamesCount;
    private int GObjectsCount;

    private bool ShowDemoWindow;

    public unsafe override void OnLoad() {
        var gPsyonixBuildIdAddress = *(nint*)PInvoke.GetProcAddress(new SafeProcessHandle(RLLoader.BaseAddress, false), "GPsyonixBuildID").Value;

        Version = Marshal.PtrToStringUni(gPsyonixBuildIdAddress);
        CompileTime = Marshal.PtrToStringUTF8(gPsyonixBuildIdAddress + (Version.Length * 2) + 2);

        Console.Title = $"RLLoader - {Version}";

        Logger.InfoLine($"Version: {Version.Fg(Color.LightGreen)}, compile time: {CompileTime.Fg(Color.LightGreen)}");
    }

    public override void OnDraw() {
        ImGui.TextColored(new Vector4(0.75f, 0.5f, 1f, 0.9f), "Game Version:"); ImGui.SameLine(); ImGui.Text(Version);
        ImGui.TextColored(new Vector4(0.75f, 0.5f, 1f, 0.9f), "Compile Time:"); ImGui.SameLine(); ImGui.Text(CompileTime);
        ImGui.TextColored(new Vector4(0.75f, 0.5f, 1f, 0.9f), "GNames count:"); ImGui.SameLine(); ImGui.Text($"{GNamesCount}");
        ImGui.TextColored(new Vector4(0.75f, 0.5f, 1f, 0.9f), "GObjects count:"); ImGui.SameLine(); ImGui.Text($"{GObjectsCount}");

        ImGui.NewLine();

        ImGui.Checkbox("Show Demo Window", ref ShowDemoWindow);
    }

    public override void OnTick() {
        if (IsSelected) {
            GNamesCount = UObject.GNames.Count;
            GObjectsCount = UObject.GObjects.Count;
        }
    }

    public override void OnDrawExternal() {
        if (ShowDemoWindow) ImGui.ShowDemoWindow(ref ShowDemoWindow);
    }
}