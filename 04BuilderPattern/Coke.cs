namespace BuilderPattern;

public class Coke : ColdDrink
{
    public override double Price()
    {
        return 30.0d;
    }
    public override string Name()
    {
        return "Coke";
    }
}
