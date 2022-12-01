
namespace NullObjectPattern;

public abstract class AbstractCustomer
{

    protected string _name;
    protected AbstractCustomer(string name)
    {
        _name = name;
    }

    public abstract bool IsNil();
    public abstract string GetName();
}
