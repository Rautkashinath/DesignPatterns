public class AdapterClient
{
    public void Execute()
    {
        Adaptee adaptee = new();
        IClient client = new Adapter(adaptee);
        string message = client.HandleRequest();
        System.Console.WriteLine(message);
    }
}