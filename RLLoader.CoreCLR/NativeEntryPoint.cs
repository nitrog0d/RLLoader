using PastelExtended;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using Windows.Win32;
using Windows.Win32.UI.WindowsAndMessaging;
using Windows.Win32.Foundation;
using RLLoader.Shared;

namespace RLLoader.CoreCLR;

public class NativeEntryPoint {
    public delegate void InitDelegate();
    public static void Init() {
        // AppDomain.CurrentDomain.FirstChanceException += (sender, e) => Logger.ErrorLine($"First Chance Exception!\n{e.Exception}");

        AppDomain.CurrentDomain.UnhandledException += (sender, e) => Logger.ErrorLine($"Unhandled Exception!\n{e.ExceptionObject}");

        _ = PInvoke.AllocConsole();

        // Make console transparent (Alpha 240)
        PInvoke.SetLayeredWindowAttributes(PInvoke.GetConsoleWindow(), new COLORREF(), 240, LAYERED_WINDOW_ATTRIBUTES_FLAGS.LWA_ALPHA);

        var process = Process.GetCurrentProcess();

        var logger = new Logger("RLLoader.CoreCLR");

        logger.InfoLine($"Loaded on process {process.ProcessName.Fg(Color.LightGreen)}, ID: {process.Id.ToString().Fg(Color.LightGreen)}");
        logger.InfoLine($"Runtime version: {RuntimeInformation.FrameworkDescription.Fg(Color.LightGreen)}");

        Core.RLLoader.HookLoadLibrary();
    }
}
