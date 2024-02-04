using GameNetcodeStuff;
using HarmonyLib;
using BepInEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx.Bootstrap;

namespace ModLister.Patches
{
    [HarmonyPatch(typeof(InitializeGame), "OnEnable")]
    internal class InitializeGamePatches
    {
        public static void Postfix()
        {
            foreach (var plugin in Chainloader.PluginInfos)
            {
                var metadata = plugin.Value.Metadata;
                Utils.PrintToLog("Plugin: \"" + metadata.Name + "\" Version: \"" + metadata.Version.ToString() + "\" GUID: \"" + metadata.GUID.ToString() + "\"");
            }
        }
    }
}
