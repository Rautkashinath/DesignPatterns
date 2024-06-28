public sealed class DotNetLazySingleton
{
    private static readonly Lazy<DotNetLazySingleton> lazy = new(() => new DotNetLazySingleton());
    
    private DotNetLazySingleton() { }

    public static DotNetLazySingleton GetInstance()
    {
        return lazy.Value;
    }        
}