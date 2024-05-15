using VoidManager.MPModChecks;

namespace OpenShipDoors
{
    public class VoidManagerPlugin : VoidManager.VoidPlugin
    {
        public override MultiplayerType MPType => MultiplayerType.Client;

        public override string Author => "18107, Dragon";

        public override string Description => "Opens ship doors on game startup. Host-Side";
    }
}
