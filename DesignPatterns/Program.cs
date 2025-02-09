public class Program
{
    public static void ExecuteCreationalPatterns()
    {
        FactoryClient factoryClient = new FactoryClient();
        factoryClient.Execute();

        AbstractFactoryClient abstractFactoryClient = new AbstractFactoryClient();
        abstractFactoryClient.Execute();

        BuilderClient builderClient = new BuilderClient();
        builderClient.Execute();
        
        SingletonClient singletonClient = new SingletonClient();
        singletonClient.Execute();

        PrototypeClient prototypeClient = new PrototypeClient();
        prototypeClient.Execute();
    }

    public static void ExecuteStrutralPatterns()
    {
        AdapterClient adapterClient = new();
        adapterClient.Execute();

        BridgeClient bridgeClient = new();
        bridgeClient.Execute();

        DecoratorClient decoratorClient = new DecoratorClient();
        decoratorClient.Execute();

        CompositeClient compositeClient = new CompositeClient();
        compositeClient.Execute();

        ProxyClient proxyClient = new ProxyClient();
        proxyClient.Execute();
    }

    public static void Main(string []args)
    {
        ExecuteCreationalPatterns();
        ExecuteStrutralPatterns();
    }
}