public class Program
{
    public static void Main(string []args)
    {
        FactoryClient factoryClient = new FactoryClient();
        factoryClient.ExecuteFactory();

        AbstractFactoryClient abstractFactoryClient = new AbstractFactoryClient();
        abstractFactoryClient.Execute();
    }
}