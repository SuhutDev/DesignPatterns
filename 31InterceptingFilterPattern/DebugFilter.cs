
namespace InterceptingFilterPattern;

public class DebugFilter : IFilter
{
    public void Execute(string request)
    {
        System.Console.WriteLine("request log: " + request);
    }
}
