
namespace BusinessDelegatePattern;

public class BusinessDelegate
{
    private BusinessLookUp _lookupService = new BusinessLookUp();
    private IBusinessService? _businessService;
    private string? _serviceType;

    public void SetServiceType(string serviceType)
    {
        _serviceType = serviceType;
    }
    public void DoTask()
    {
        _businessService = _lookupService.GetBusinessService(_serviceType!);
        _businessService.DoProcessing();
    }
}
