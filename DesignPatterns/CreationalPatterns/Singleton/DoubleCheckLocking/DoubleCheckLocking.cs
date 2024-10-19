public sealed class DoubleCheckLocking
{
    private static DoubleCheckLocking? _instance;
    private static readonly object _lock = new();

    private DoubleCheckLocking() { }
    public static DoubleCheckLocking GetInstance()
    {
        if (_instance == null)
        {
            lock(_lock)
            {
                _instance ??= new DoubleCheckLocking();
            }
        }

        return _instance;
    }
}