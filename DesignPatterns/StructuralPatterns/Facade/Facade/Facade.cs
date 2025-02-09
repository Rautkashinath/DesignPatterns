public class Facade
{
    private Subsystem1 _subsystem1;
    private Subsystem2 _subsystem2;

    public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
    {
        _subsystem1 = subsystem1;
        _subsystem2 = subsystem2;
    }

    // Facade works with an entire subsystem of objects.
    // Facade defines a simplified interface to a subsystem of objects
    public void Operation()
    {
        _subsystem1.Operation1();
        _subsystem1.Operation2();
        _subsystem1.Operation3();

        _subsystem2.Operation1();
    }
}