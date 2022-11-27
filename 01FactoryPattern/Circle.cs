namespace FactoryPattern;

public class Circle : IShape
{
    public void Draw()
    {
         System.Console.WriteLine($"Inside Circle.Drawn");
    }
} 