public class BridgeClient
{
    public void Execute()
    {
        Device device = new Device();
        Remote remote = new Remote(device);
        remote.Mute();
        remote.ChannelUp();
        remote.ChannelDown();
    }
}