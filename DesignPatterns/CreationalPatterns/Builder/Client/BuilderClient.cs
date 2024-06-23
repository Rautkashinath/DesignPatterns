public class BuilderClient
{
    public void Execute()
    {
        var director = new Director();
        // ask director to make simple car
        var builder = new CarBuilder();
        director.CreateSimpleCar(builder);

        // get the created car
        Car car = builder.GetCar();
        // simple car created, check the details of simple car
        System.Console.WriteLine("Simpe Car Details:");
        car.GetDetails();

        // now ask director to create advanced car
        director.CreateAdvancedCar(builder);
        car = builder.GetCar();
        System.Console.WriteLine("Advanced Car Details:");
        car.GetDetails();
    }
}