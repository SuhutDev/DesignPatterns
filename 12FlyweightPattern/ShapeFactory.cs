
namespace FlyweightPattern;

public class ShapeFactory
{
    private static Dictionary<string, Circle> _circleMap = new();

    public static IShape GetCircle(string color)
    {
        Circle? circle = null;

        _ = _circleMap.TryGetValue(color, out circle);

        if (circle is null)
        {
            circle = new Circle(color);
            _circleMap.Add(color, circle);
            System.Console.WriteLine("Creating circle of color : " + color);
        }

        return circle;

    }
}
