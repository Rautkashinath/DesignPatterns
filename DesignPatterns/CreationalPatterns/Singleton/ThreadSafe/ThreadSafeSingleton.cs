public sealed class ThreadSafeSingleton
{
    private static ThreadSafeSingleton? _safeSingleton;
    private static object _lock = new();

    private ThreadSafeSingleton() { }
    
    public static ThreadSafeSingleton GetInstance()
    {
        lock(_lock)
        {
            _safeSingleton ??= new ThreadSafeSingleton();
            
            return _safeSingleton;
        }
    }
}