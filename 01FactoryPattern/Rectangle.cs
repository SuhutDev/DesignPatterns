namespace FactoryPattern;

public class Rectangle : IShape
{
    public void Draw()
    {
         System.Console.WriteLine($"Inside Rectangle.Draw");
    }
} 