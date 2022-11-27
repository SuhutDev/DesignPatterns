namespace AbstractFactoryPattern;


public class Square : IShape
{
    public void Draw()
    {
        System.Console.WriteLine($"Inside Square.Draw");
    }
} 