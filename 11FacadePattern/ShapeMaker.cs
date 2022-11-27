
namespace FacadePattern;

public class ShapeMaker
{
    private readonly IShape _circle;
    private readonly IShape _rectangle;
    private readonly IShape _square;

    public ShapeMaker()
    {
        _circle = new Circle();
        _rectangle = new Rectangle();
        _square = new Square();
    }

    public void drawCircle()
    {
        _circle.Draw();
    }
    public void drawRectangle()
    {
        _rectangle.Draw();
    }
    public void drawSquare()
    {
        _square.Draw();
    }
}
