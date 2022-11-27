namespace BuilderPattern;

public class Burger : IItem
{
    public virtual string Name()
    {
        throw new NotImplementedException();
    }

    public IPacking Packing()
    {
       return new Wrapper();
    }

    public virtual double Price()
    {
        throw new NotImplementedException();
    }
}
