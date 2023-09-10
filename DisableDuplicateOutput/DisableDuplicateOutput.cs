using System;
using System.Runtime.InteropServices;
using Harmony;

namespace Moose.HarmonyMods.DisableDuplicateOutput
{
    [HarmonyPatch(typeof(ServerConsole), nameof(ServerConsole.OnEnable))]
    internal static class PreventDuplicateOutput
    {
        private static bool Prepare() => RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        private static bool Prefix()
        {
            Console.WriteLine("Disabling ServerConsole to prevent duplicate output.");
            return false;
        }
    }
}