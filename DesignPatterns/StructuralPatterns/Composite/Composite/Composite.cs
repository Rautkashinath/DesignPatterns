// this class, provide an array field for storing references to sub-elements.
// The array is able to store both leaves and containers, 
// so make sure it’s declared with the component interface type.
public class Composite : IComponent
{
    public List<IComponent> components = [];
    
    public void Add(IComponent component)
    {
        components.Add(component);
    }

    public void Remove(IComponent component)
    {
        components.Remove(component);
    }

    public string Operation()
    {
        string result = "Branch(";
        foreach (var component in components)
        {
            result += component.Operation();
        }

        return result + ")";
    }
}