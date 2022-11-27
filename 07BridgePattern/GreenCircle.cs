namespace BridgePattern;

public class GreenCircle : IDrawApi
{
    public void DrawCircle(int radius, int x, int y)
    {
        System.Console.WriteLine($"Drawing Circle[ color: green, radius: {radius}, x: {x}, {y} ");
    }
}