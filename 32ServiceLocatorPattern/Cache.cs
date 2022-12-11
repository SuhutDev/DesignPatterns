
namespace ServiceLocatorPattern;

public class Cache
{

    private List<IService> _services;

    public Cache()
    {
        _services = new();
    }

    public IService? GetService(string serviceName)
    {
        foreach (var service in _services)
        {
            if (service.GetName().Equals(serviceName, StringComparison.OrdinalIgnoreCase))
            {
                System.Console.WriteLine("Returning cached  " + serviceName + " object");
                return service;
            }
        }
        return null;
    }

    public void AddService(IService newService)
    {
        bool exists = false;
        foreach (var service in _services)
        {
            if (service.GetName().Equals(newService.GetName(), StringComparison.OrdinalIgnoreCase))
            {
                exists = true;
            }
        }
        if (!exists)
        {
            _services.Add(newService);
        }
    }
}
