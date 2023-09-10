# DisableDuplicateOutput
This is a Harmony Mod intended to disable the ServerConsole output of a Rust server.
This is useful whenever you have Rust outputting to stdout instead of a logfile.
When this is done in Windows it causes the output to be duplicated which is what this mod prevents.

### Why are you outputting to stdout?
We have our own in-house server manager built in .NET 7 that spins up the Rust servers as sub-processes. 
When doing this there is obviously no console like running from a batch file. So we force
the game to output to stdout so that we can capture that in our server manager and filter the logs accordingly.

# Compile Yourself
- Clone the repository to your computer.
- Download the latest Windows Rust server files using SteamCMD.
- Move everything from `RustDedicated_Data/Managed` in the Rust install to `RustAssemblies/` in the repository directory.
- Make any changes you'd like.

# Installation
- After building is successful, drag the `DisableDuplicateOutput.dll` to your Rust installation's `HarmonyMods` folder.