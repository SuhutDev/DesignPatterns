
namespace DecoratorPattern;

public class RedShapeDecorator : ShapeDecorator
{
    public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape)
    {

    }

    public override void Draw()
    {
        DecoratedShape.Draw();
        SetRedBorder(DecoratedShape);
    }

    private void SetRedBorder(IShape decoratedShape) {
        System.Console.WriteLine("Border Color: Red");
    }
}
