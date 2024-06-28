public sealed class DoubleCheckLocking
{
    private static DoubleCheckLocking _instance = null;
    private static object _lock = new object();

    private DoubleCheckLocking() { }
    public static DoubleCheckLocking GetInstance()
    {
        if (_instance == null)
        {
            lock(_lock)
            {
                if (_instance == null)
                    _instance = new DoubleCheckLocking();
            }
        }

        return _instance;
    }
}