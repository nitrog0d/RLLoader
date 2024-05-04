# RLLoader

Mod Loader & SDK Dumper for Rocket League (and can be modified to work for other Unreal Engine 3 games)

## ABANDONED
This project was abandoned due to how C# objects works and how I've written the SDK generator.  
Basically, I create a new C# object for every property (that is a struct or object pointer) and at PE/PI hooks, I create a new UFunction, new FFrame, new Node, new instances, new parameters, etc.  
This is problematic because these objects get out of scope eventually, and GC eats them, causing hiccups (fps drops) in the game.  
I don't feel like working for a fix (an Object pool based on pointers could probably work..?), so I'll leave it behind.

## CoreCLR Host

- Build `RLLoader.CoreCLR`, you'll use the path it built to in the steps below.
- Unzip the CoreCLR files (`RLLoader.CoreCLR.zip`) in the game folder that has the RocketLeague.exe, you can find them at the same `Resources` folder.
- Open `rlloader_coreclr.ini`, change the path of `Directory` to where RLLoader.CoreCLR is being built to.
- Open your game and RLLoader should load.

## CLI (Dumper only)

- Open the game.
- Run the CLI tool.
