public sealed class ThreadSafeWOLock
{
    private static readonly ThreadSafeWOLock threadSafeWOLock = new();

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