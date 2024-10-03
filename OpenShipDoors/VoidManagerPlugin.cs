using VoidManager.MPModChecks;

namespace OpenShipDoors
{
    public class VoidManagerPlugin : VoidManager.VoidPlugin
    {
        public override MultiplayerType MPType => MultiplayerType.Client;

        public override string Author => MyPluginInfo.PLUGIN_AUTHORS;

        public override string Description => MyPluginInfo.PLUGIN_DESCRIPTION;

        public override string ThunderstoreID => MyPluginInfo.PLUGIN_THUNDERSTORE_ID;

        public override VoidManager.SessionChangedReturn OnSessionChange(VoidManager.SessionChangedInput input)
        {
            if (input.CallType == VoidManager.CallType.HostStartSession)
            {
                return new VoidManager.SessionChangedReturn() { SetMod_Session = true};
            }
            return base.OnSessionChange(input);
        }
    }
}
