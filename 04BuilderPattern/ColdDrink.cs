namespace BuilderPattern;

public class ColdDrink : IItem
{
    public virtual string Name()
    {
        throw new NotImplementedException();
    }

    public IPacking Packing()
    {
        return new Bottle();
    }

    public virtual double Price()
    {
        throw new NotImplementedException();
    }
}
