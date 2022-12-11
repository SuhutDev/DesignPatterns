
namespace InterceptingFilterPattern;

public class Target
{
    public void execute(String request)
    {
        System.Console.WriteLine("Executing request: " + request);
    }
}
