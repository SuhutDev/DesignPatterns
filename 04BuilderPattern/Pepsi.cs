namespace BuilderPattern;

public class Pepsi : ColdDrink
{
    public override double Price()
    {
        return 35.0d;
    }

    public override string Name()
    {
        return "Pepsi";
    }
}
