
namespace FrontControllerPattern;

public class FrontController
{
    private Dispatcher _dispatcher;

    public FrontController()
    {
        _dispatcher = new();
    }
    private bool IsAuthenticUser()
    {
        System.Console.WriteLine("User is authenticated successfully.");
        return true;
    }

    private void TrackRequest(string request)
    {
        System.Console.WriteLine("Page requested: " + request);
    }

    public void DispatchRequest(string request)
    {
        //log each request
        TrackRequest(request);
        //authenticate the user
        if (IsAuthenticUser())
        {
            _dispatcher.Dispatch(request);
        }
    }
}
