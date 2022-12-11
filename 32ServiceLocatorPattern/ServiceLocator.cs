
namespace ServiceLocatorPattern;

public class ServiceLocator
{
    private static Cache cache = new Cache();

    public static IService GetService(String jndiName)
    {

        IService service = cache.GetService(jndiName)!;

        if (service != null)
        {
            return service;
        }

        InitialContext context = new InitialContext();
        IService service1 = (IService)context.lookup(jndiName)!;
        cache.AddService(service1);
        return service1;
    }
}
