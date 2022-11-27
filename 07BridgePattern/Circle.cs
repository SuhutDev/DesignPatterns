
namespace BridgePattern;

public class Circle : Shape
{
    private int X, Y, Radius;
    public Circle(int x, int y, int radius, IDrawApi drawApi) : base(drawApi)
    {  
        X = x;
        Y = y;
        Radius = radius;
    }

    public override void Draw()
    {
        DrawApi.DrawCircle(Radius, X, Y);
    }
}
