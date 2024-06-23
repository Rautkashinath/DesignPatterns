// concrete builders who implements this interface
// need to provided their own method to retrieve result
public interface IBuilder
{
    public void SetSeats(int number);
    public void SetEngine(string name);
    public void SetGPS();
    public void SetLED();
}