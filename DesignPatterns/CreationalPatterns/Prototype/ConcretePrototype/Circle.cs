public class Circle : IShape
{
    private String color;

    public Circle(String color)
    {
        this.color = color;
    }

    public void Draw()
    {
        System.Console.WriteLine("Drawing color: "+ color);
    }

    public IShape Clone()
    {
        return (Circle) this.MemberwiseClone();
    }
}