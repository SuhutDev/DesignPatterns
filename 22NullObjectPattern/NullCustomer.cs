
namespace NullObjectPattern;

public class NullCustomer : AbstractCustomer
{
    public NullCustomer() : base("")
    {

    }
    public override string GetName()
    {
        return "Not available in customer database";
    }

    public override bool IsNil()
    {
        return false;
    }
}
