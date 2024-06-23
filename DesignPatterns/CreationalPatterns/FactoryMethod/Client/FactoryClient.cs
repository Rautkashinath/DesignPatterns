/// <summary>
/// Client which will use factory method to get factory products
/// </summary>
public class FactoryClient
{
    public void Execute()
    {
        // initialize logistics
        Logistics logistics = new RoadLogicstics();
        // get mode of transport and deliver
        ITransport transport = logistics.GetTransport();
        transport.Deliver();

        // deliver using sea transport
        logistics = new SeaLogistics();
        transport = logistics.GetTransport();
        transport.Deliver();

        // do some business logic calculation and then deliver
        logistics.DoSomeOperation();
    }
}