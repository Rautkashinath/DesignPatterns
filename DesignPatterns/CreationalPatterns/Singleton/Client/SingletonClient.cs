public class SingletonClient
{
    public void Execute()
    {
        // different types of singleton
        var singleton = Singleton.GetInstance();
        var threadSafe = ThreadSafeSingleton.GetInstance();
        var doubleCheckLocking = DoubleCheckLocking.GetInstance();
        var threadSafeWOLock = ThreadSafeWOLock.GetInstance();
        var fullyLazy = FullyLazy.GetInstance();
        var dotNetLazySingleton = DotNetLazySingleton.GetInstance();
    }
}