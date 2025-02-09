// provides substitute or placeholder for another object
// controls access to original object, allowing us to perform something either before or after\
// request go through original object
public class Proxy : ISubject
{
    private RealSubject _subject;

    public Proxy(RealSubject realSubject)
    {
        _subject = realSubject;
    }

    public void Request()
    {
        if(CheckAccess())
        {
            _subject.Request();
            LogAccess();
        }
    }

    private bool CheckAccess()
    {
        System.Console.WriteLine("Proxy: Check access before request");
        return true;
    }

    private void LogAccess()
    {
        System.Console.WriteLine("Proxy: Logging request access");
    }
}