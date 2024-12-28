// The client code works with all objects using the Component interface.
// This way it can stay independent of the concrete classes of
// components it works with.
public class DecoratorClient
{
    public void Execute()
    {
        // base decorator object
        IPizza pizza = new Pizza();

        var cheesePizza = new CheesePizza(pizza);
        Console.WriteLine(cheesePizza.GetPizza());

        var onionPizza = new OnionPizza(pizza);
        Console.WriteLine(onionPizza.GetPizza());

        var cheeseAndOnionPizza = new OnionPizza(cheesePizza);
        Console.WriteLine(cheeseAndOnionPizza.GetPizza());
    }
}