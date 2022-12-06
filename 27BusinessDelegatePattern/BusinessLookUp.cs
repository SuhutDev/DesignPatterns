
namespace BusinessDelegatePattern;

public class BusinessLookUp
{
    public IBusinessService GetBusinessService(string serviceType)
    {
        if (serviceType.Equals("EJB", StringComparison.OrdinalIgnoreCase))
        {
            return new EjbService();
        }
        else
        {
            return new JmsService();
        }
    }
}
