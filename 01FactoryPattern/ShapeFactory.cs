namespace FactoryPattern;

public class ShapeFactory
{
    public IShape GetShape(string shapeType)
    { 
        if (string.Equals(shapeType, "CIRCLE", StringComparison.OrdinalIgnoreCase))
        {
            return new Circle();
        }
        else if (string.Equals(shapeType, "RECTANGLE", StringComparison.OrdinalIgnoreCase))
        {
            return new Rectangle();
        }
        else if (string.Equals(shapeType, "SQUARE", StringComparison.OrdinalIgnoreCase))
        {
            return new Square();
        } 
        else {
            throw new ArgumentException();
        }
    }
}