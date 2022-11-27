using System;
namespace AbstractFactoryPattern;

public class ShapeFactory : IFactory
{
    public IShape GetShape(String shapeType) {
        if(string.Equals(shapeType, "RECTANGLE", StringComparison.OrdinalIgnoreCase)) {
            return new Rectangle();
        }
        else if (string.Equals(shapeType, "SQUARE", StringComparison.OrdinalIgnoreCase)) {
            return new Square();
        }
        else {
            throw new ArgumentException();
        }
    }
}
