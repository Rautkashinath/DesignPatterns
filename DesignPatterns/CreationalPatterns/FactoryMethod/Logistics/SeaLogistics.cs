public class SeaLogistics : Logistics
{
    /// <summary>
    /// subclass that returns (product), sea logistics way of transport
    /// </summary>
    /// <returns></returns>
    public override ITransport GetTransport()
    {
       return new ShipTansport();
    }
}