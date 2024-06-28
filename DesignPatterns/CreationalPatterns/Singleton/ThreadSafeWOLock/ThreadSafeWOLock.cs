public sealed class ThreadSafeWOLock
{
    public static ThreadSafeWOLock threadSafeWOLock = new ThreadSafeWOLock();

    private ThreadSafeWOLock() { }

    // not to mark type as beforefieldinit
    // ensures type initializers are executed before first access to static field
    static ThreadSafeWOLock()
    {
        System.Console.WriteLine("Static constructor");
    }

    public static ThreadSafeWOLock GetInstance()
    {
        return threadSafeWOLock;
    }
}