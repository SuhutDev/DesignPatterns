
namespace NullObjectPattern;

public class RealCutomer : AbstractCustomer
{
    public RealCutomer(string name) : base(name)
    {
    }

    public override bool IsNil()
    {
        return false;
    }

    public override string GetName()
    {
        return _name;
    }
}
