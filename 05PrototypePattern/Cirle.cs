namespace PrototypePattern;

public class Cirle : Shape
{
    public Cirle()
    {
        Type="Circle";
    }
    public override void Draw()
    {
        System.Console.WriteLine("Inside Circle.Draw");
    }
}
