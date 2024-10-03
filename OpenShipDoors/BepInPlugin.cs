using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using System.Reflection;

namespace OpenShipDoors
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.USERS_PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    [BepInProcess("Void Crew.exe")]
    [BepInDependency(VoidManager.MyPluginInfo.PLUGIN_GUID)]
    public class BepinPlugin : BaseUnityPlugin
    {
        internal static ManualLogSource Log;
        private void Awake()
        {
            Log = Logger;
            Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), MyPluginInfo.PLUGIN_GUID);

            Bindings.OpenDoorsOnStart = Config.Bind("OpenShipDoors", "OpenShipDoorsOnStart", true);
            Bindings.OpenInnerAirlock = Config.Bind("OpenShipDoors", "OpenInnerAirlock", true);
            Bindings.OpenOuterAirlock = Config.Bind("OpenShipDoors", "OpenOuterAirlock", false);
        }


        internal class Bindings
        {
            internal static ConfigEntry<bool> OpenDoorsOnStart;
            internal static ConfigEntry<bool> OpenInnerAirlock;
            internal static ConfigEntry<bool> OpenOuterAirlock;
        }
    }
}