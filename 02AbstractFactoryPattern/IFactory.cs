namespace AbstractFactoryPattern;

public interface IFactory
{
    public IShape GetShape(string shapeType);
}
