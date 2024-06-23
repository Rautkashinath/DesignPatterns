// Director tells what feature object should have
public class Director
{
    public void CreateSimpleCar(IBuilder builder)
    {
        builder.SetSeats(2);
        builder.SetEngine("Simlple");
    }

    // director is adding features to existing object step by step
    // means it's creating object step by step
    public void CreateAdvancedCar(IBuilder builder)
    {
        builder.SetSeats(7);
        builder.SetEngine("Advanced");
        builder.SetGPS();
        builder.SetLED();
    }
}