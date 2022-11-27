namespace AbstractFactoryPattern;

public class FactoryProducer
{
    public static IFactory GetFactory(bool rounded) {
        if(rounded) {
            return new RoundedShapeFactory();
        } else {
            return new ShapeFactory();
        }
    }
}
