
namespace BusinessDelegatePattern;

public class Client
{
    private readonly BusinessDelegate _businessService;
    public Client(BusinessDelegate businessService)
    {
        _businessService = businessService;
    }
    public void DoTask()
    {
        _businessService.DoTask();
    }
}
