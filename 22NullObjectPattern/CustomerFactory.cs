
namespace NullObjectPattern;

public class CustomerFactory
{
    public static string[] Names = { "Rob", "Joe", "Julie" };

    public static AbstractCustomer GetCustomer(string name)
    {
        for (int i = 0; i < Names.Length; i++)
        {
            if (string.Equals(name, Names[i], System.StringComparison.OrdinalIgnoreCase))
            {
                return new RealCutomer(name);
            }
        }
        return new NullCustomer();
    }
}
