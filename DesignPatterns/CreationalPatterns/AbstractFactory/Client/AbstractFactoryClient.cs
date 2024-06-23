public class AbstractFactoryClient
{
    public void Execute()
    {
        Furniture furniture = new ModerFurniture();
        IChair chair = furniture.CreateChair();
        ISofa sofa = furniture.CreateSofa();
        chair.SitOnChair();
        sofa.SitOnSofa();

        furniture = new VictorianFurniture();
        chair = furniture.CreateChair();
        sofa = furniture.CreateSofa();
        chair.SitOnChair();
        sofa.SitOnSofa();
    }
}