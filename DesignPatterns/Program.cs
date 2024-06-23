public class Program
{
    public static void Main(string []args)
    {
        FactoryClient factoryClient = new FactoryClient();
        factoryClient.Execute();

        AbstractFactoryClient abstractFactoryClient = new AbstractFactoryClient();
        abstractFactoryClient.Execute();
    }
}