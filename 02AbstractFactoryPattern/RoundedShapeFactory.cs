using System;
namespace AbstractFactoryPattern;

public class RoundedShapeFactory : IFactory
{
    public IShape GetShape(String shapeType) {
        if(string.Equals(shapeType, "RECTANGLE", StringComparison.OrdinalIgnoreCase)) {
            return new RoundedRectangle();
        }
        else if (string.Equals(shapeType, "SQUARE", StringComparison.OrdinalIgnoreCase)) {
            return new RoundedSquare();
        }
        else {
            throw new ArgumentException();
        }
    }
}
