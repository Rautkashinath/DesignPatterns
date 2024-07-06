public class PrototypeClient
{
    public void Execute()
    {
        IShape shape = new Circle("Red");
        shape.Draw();
        // create clone of shape
        IShape clonedShape = shape.Clone();
        clonedShape.Draw();
    }
}