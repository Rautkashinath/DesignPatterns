using System.Net.Http.Headers;

public class VictorianFurniture : Furniture
{
    public override IChair CreateChair()
    {
        return new VictorianChair();
    }

    public override ISofa CreateSofa()
    {
        return new VictorianSofa();
    }
}