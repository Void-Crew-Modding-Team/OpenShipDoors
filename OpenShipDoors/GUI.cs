using VoidManager.CustomGUI;
using static UnityEngine.GUILayout;

namespace OpenShipDoors
{
    internal class GUI : ModSettingsMenu
    {
        public override void Draw()
        {
            if(Button($"Open ship doors on start: {(BepinPlugin.Bindings.OpenDoorsOnStart.Value ? "Enabled" : "Disabled")}"))
            {
                BepinPlugin.Bindings.OpenDoorsOnStart.Value = !BepinPlugin.Bindings.OpenDoorsOnStart.Value;
            }
            if(Button($"Open inner airlock doors: {(BepinPlugin.Bindings.OpenInnerAirlock.Value ? "Enabled" : "Disabled")}"))
            {
                BepinPlugin.Bindings.OpenInnerAirlock.Value = !BepinPlugin.Bindings.OpenInnerAirlock.Value;
            }
            if (Button($"Open outer airlock doors: {(BepinPlugin.Bindings.OpenOuterAirlock.Value ? "Enabled" : "Disabled")}"))
            {
                BepinPlugin.Bindings.OpenOuterAirlock.Value = !BepinPlugin.Bindings.OpenOuterAirlock.Value;
            }
        }

        public override string Name()
        {
            return $"OpenShipDoors: {(BepinPlugin.Bindings.OpenDoorsOnStart.Value ? "Enabled" : "Disabled")}";
        }
    }
}
