
namespace DecoratorPattern;

public abstract class ShapeDecorator : IShape
{
    protected IShape DecoratedShape;

    public ShapeDecorator(IShape decoratorShape)
    {
        DecoratedShape = decoratorShape;
    }

    public virtual void Draw()
    {
        DecoratedShape.Draw();
    }

}
