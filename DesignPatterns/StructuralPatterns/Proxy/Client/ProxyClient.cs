public class ProxyClient
{
    public void Execute()
    {
        RealSubject realSubject = new RealSubject();
        Proxy proxy = new Proxy(realSubject);
        proxy.Request();
    }
}