public class OnionPizza : SimplePizza
{
    public OnionPizza(IPizza pizza) : base(pizza)
    {
    }

    public override string GetPizza()
    {
        var pizza = base.GetPizza();
        return pizza + ";with onion";
    }
}