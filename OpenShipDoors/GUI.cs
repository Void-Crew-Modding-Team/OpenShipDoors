using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        public override string Name()
        {
            return $"OpenShipDoors: {(BepinPlugin.Bindings.OpenDoorsOnStart.Value ? "Enabled" : "Disabled")}";
        }
    }
}
