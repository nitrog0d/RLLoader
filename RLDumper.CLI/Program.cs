using PastelExtended;
using RLLoader.Shared;
using System.Diagnostics;
using System.Drawing;

namespace RLDumper.CLI;

public static class Program {
    private static Logger Logger = new("RLDumper.CLI");

    public static void Main(string[] args) {
        Logger.VerboseLine("Looking for Rocket League process...");

        var process = Process.GetProcessesByName("RocketLeague").LastOrDefault();
        if (process == null) {
            Logger.ErrorLine($"Failed to find Rocket League process! Exiting...");
            return;
        }

        Logger.InfoLine($"Found Rocket League process! {process.MainWindowTitle.Fg(Color.LightGreen)}, ID: {process.Id.ToString().Fg(Color.LightGreen)}");

        Core.RLDumper.Init(process, true);
        Core.RLDumper.BuildModels();
        Core.RLDumper.DumpCSSDK(@"C:\Users\Lucas\Desktop\Programming\CSharp\RLLoader\RLLoader.SDK");
    }
}
