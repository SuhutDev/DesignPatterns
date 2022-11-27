namespace AbstractFactoryPattern;

public class RoundedRectangle : IShape
{
    public void Draw()
    {
        System.Console.WriteLine($"Inside RoundedRectangle.Draw");
    }
}
 