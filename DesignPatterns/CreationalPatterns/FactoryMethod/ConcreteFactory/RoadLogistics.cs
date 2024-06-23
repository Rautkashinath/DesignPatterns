public class RoadLogicstics : Logistics
{
    /// <summary>
    /// subclass that returns road logistics way of transport
    /// </summary>
    public override ITransport GetTransport()
    {
       return new TruckTransport();
    }
}