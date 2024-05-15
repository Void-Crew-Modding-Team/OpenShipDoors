using CG.Ship.Hull;
using HarmonyLib;

namespace OpenShipDoors
{
    [HarmonyPatch(typeof(AbstractDoor), "Awake")]
    internal class AbstractDoorPatch
    {
        static void Prefix(AbstractDoor __instance, ref bool ___isOpen)
        {
            if (!BepinPlugin.Bindings.OpenDoorsOnStart.Value) return;

            if (__instance is AirlockDoor door)
            {
                if ((BepinPlugin.Bindings.OpenInnerAirlock.Value && door.airlockDoorType == AirlockDoorType.Inner) ||
                    (BepinPlugin.Bindings.OpenOuterAirlock.Value && door.airlockDoorType == AirlockDoorType.Outer))
                {
                    ___isOpen = true;
                }
            }
            else
            {
                ___isOpen = true;
            }
        }
    }
}
