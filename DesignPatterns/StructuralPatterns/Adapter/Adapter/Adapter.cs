/// <summary>
/// This is actual adapter
/// this takes a call from client and transfer it to legacy adaptee
/// and retun result from adaptee back to client
/// Adapter should follow client interface
/// </summary>
public class Adapter : IClient
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        this._adaptee = adaptee;
    }

    public string HandleRequest()
    {
        return $"This is '{this._adaptee.HandleSpecificRequest()}'";
    }
}