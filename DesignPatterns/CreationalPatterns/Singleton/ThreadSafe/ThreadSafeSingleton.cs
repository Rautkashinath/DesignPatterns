public sealed class ThreadSafeSingleton
{
    private static ThreadSafeSingleton _safeSingleton = null;
    private static object _lock = new object();

    private ThreadSafeSingleton() { }
    
    public static ThreadSafeSingleton GetInstance()
    {
        lock(_lock)
        {
            if (_safeSingleton == null)
                _safeSingleton = new ThreadSafeSingleton();
            
            return _safeSingleton;
        }
    }
}