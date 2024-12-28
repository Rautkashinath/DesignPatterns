// The primary purpose of this class is to
// define the wrapping interface for all concrete decorators.
// base decorator for concrete decorators
public class SimplePizza : IPizza
{
    private IPizza _pizza;

    public SimplePizza(IPizza pizza)
    {
        _pizza = pizza;
    }
    
    public virtual string GetPizza()
    {
        return _pizza.GetPizza();
    }
}