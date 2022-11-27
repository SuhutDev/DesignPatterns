
namespace BridgePattern;
 
public abstract class Shape
{
    protected IDrawApi DrawApi;
    protected Shape(IDrawApi drawApi) {
        DrawApi=drawApi;
    }

    public abstract void Draw();
}
 