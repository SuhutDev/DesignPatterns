
namespace ServiceLocatorPattern;

public class Service2 : IService
{
    public void Execute()
    {
        System.Console.WriteLine("Executing Service2");
    }

    public string GetName()
    {
        return "Service2";
    }
}
