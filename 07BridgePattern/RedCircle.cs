
namespace BridgePattern;

public class RedCircle : IDrawApi
{
    public void DrawCircle(int radius, int x, int y)
    {
        System.Console.WriteLine($"Drawing Circle[ color: red, radius: {radius}, x: {x}, {y} ");
    }
}
