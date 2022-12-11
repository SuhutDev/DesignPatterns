
namespace ServiceLocatorPattern;

public class Service1 : IService
{
    public void Execute()
    {
        System.Console.WriteLine("Executing Service1");
    }

    public string GetName()
    {
        return "Service1";
    }
}
