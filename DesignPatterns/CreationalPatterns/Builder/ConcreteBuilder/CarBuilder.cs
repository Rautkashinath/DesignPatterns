public class CarBuilder : IBuilder
{
    // object to be created in steps
    private Car car = new Car();

    public CarBuilder()
    {
        this.Reset();
    }

    // returns created object to client
    public Car GetCar()
    {
        // reset car object so it's ready for another object creation
        var builtCar = this.car;
        Reset();

        return builtCar;
    }

    // reset builder object
    public void Reset()
    {
        car = new Car();
    }

    // methods to create a object step by step
    public void SetSeats(int number)
    {
        car.AddDetail("Number of Seats: " + number);
    }

    public void SetEngine(string name)
    {
        car.AddDetail("Engine: " + name);
    }

    public void SetGPS()
    {
        car.AddDetail("GPS Enabled");
    }

    public void SetLED()
    {
        car.AddDetail("Added LED Display");
    }
}