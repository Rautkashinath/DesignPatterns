public class CheesePizza : SimplePizza
{
    public CheesePizza(IPizza pizza) : base(pizza)
    {
    }

    public override string GetPizza()
    {
        var pizza = base.GetPizza();
        return pizza + ";with cheese";
    }
}