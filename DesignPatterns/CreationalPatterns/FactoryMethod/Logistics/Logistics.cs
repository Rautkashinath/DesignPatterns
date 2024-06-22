public abstract class Logistics
{
    /// <summary>
    /// It's primary responsiblity is not creating products it can have another business logic
    /// Factory method that supposed to retutn object of transport class.
    /// subclasses will implement this one and return different products from their factory
    /// </summary>
    public abstract ITransport GetTransport();

    public void DoSomeOperation()
    {
        // get transport mode
        var transport = GetTransport();
        System.Console.WriteLine("Doing some business logic");
        transport.Deliver();
    }
}