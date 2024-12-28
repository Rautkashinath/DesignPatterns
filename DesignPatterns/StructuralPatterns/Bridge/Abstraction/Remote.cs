// Problem: Problem occurs when we try to extend a class into two indepedent dimensions: shape and color.
// Bridge solves this problem by switching from inheritance to object composition
public class Remote
{
    // This acts as bridge between TV and Remote
    private Device _device;

    public Remote(Device device)
    {
        _device = device;
    }

    public void Mute()
    {
        _device.SetVolume(0);
    }

    public void VolumeUp()
    {
        int currentVolume = _device.GetVolume();
        _device.SetVolume(currentVolume + 1);
    }

    public void VolumeDown()
    {
        int currentVolume = _device.GetVolume();
        _device.SetVolume(currentVolume - 1);
    }

    public void ChannelUp()
    {
        int currentChannel = _device.GetChannel();
        _device.SetChannel(currentChannel + 1);
    }

    public void ChannelDown()
    {
        int currentChannel = _device.GetChannel();
        _device.SetChannel(currentChannel - 1);
    }
}