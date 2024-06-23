// implements abstract factory class
public class ModerFurniture : Furniture
{
    public override IChair CreateChair()
    {
        return new ModernChair();
    }

    public override ISofa CreateSofa()
    {
        return new ModernSofa();
    }
}