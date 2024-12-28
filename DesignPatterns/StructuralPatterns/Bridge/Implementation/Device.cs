public class Device
{
    private int volume;
    
    private int channel;

    public int GetVolume()
    {
        return volume;
    }

    public void SetVolume(int value)
    {
        volume = value;
    }

    public int GetChannel()
    {
        return channel;
    }

    public void SetChannel(int channelNum)
    {
        channel = channelNum;
    }
}