using CG.Ship.Hull;
using HarmonyLib;

namespace OpenShipDoors
{
    [HarmonyPatch(typeof(AbstractDoor), "Awake")]
    internal class AbstractDoorPatch
    {
        static void Prefix(AbstractDoor __instance, ref bool ___isOpen)
        {
            if (__instance is AirlockDoor) return;
            ___isOpen = true;
        }
    }
}
