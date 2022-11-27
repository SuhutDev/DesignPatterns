namespace PrototypePattern;

public class Rectangle : Shape
{
    public Rectangle()
    {
        Type="Rectangle";
    }
    public override void Draw()
    {
        System.Console.WriteLine("Inside Rectangle.Draw");
    }
}
