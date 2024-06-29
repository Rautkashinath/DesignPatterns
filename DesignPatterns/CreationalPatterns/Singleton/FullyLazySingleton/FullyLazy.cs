public sealed class FullyLazy
{
    private FullyLazy() { }

    public static FullyLazy GetInstance()
    {
        return Nested.instance;
    }

    private class Nested
    {
        // not to mark type as beforefieldinit
        // ensures type initializers are executed before first access to static field
        static Nested() { }
        internal static readonly FullyLazy instance = new();
    }
}