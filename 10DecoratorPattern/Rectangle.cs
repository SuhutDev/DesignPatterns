
namespace DecoratorPattern;

public class Rectangle : IShape
{
    public void Draw()
    {
        System.Console.WriteLine("Shape : Rectangle");
    }
}
