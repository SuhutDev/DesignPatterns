namespace BuilderPattern;
 
public class ChickenBurger : Burger
{
    public override double Price()
    {
        return 50.0d;
    }

    public override string Name()
    {
        return "Chicken Burger";
    }
}
 