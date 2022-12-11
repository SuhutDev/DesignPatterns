
namespace InterceptingFilterPattern;

public class Client
{
    FilterManager? _filterManager;

    public void SetFilterManager(FilterManager filterManager)
    {
        _filterManager = filterManager;
    }

    public void SendRequest(String request)
    {
        _filterManager?.FilterRequest(request);
    }
}
