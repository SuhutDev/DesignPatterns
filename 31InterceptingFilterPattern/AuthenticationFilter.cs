
namespace InterceptingFilterPattern;

public class AuthenticationFilter : IFilter
{
    public void Execute(string request)
    {
        System.Console.WriteLine("Authenticating request: " + request);
    }
}
