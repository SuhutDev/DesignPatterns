
namespace BusinessDelegatePattern;

public class JmsService : IBusinessService
{
    public void DoProcessing()
    {
        System.Console.WriteLine("Processing task by invoking JMS Service");
    }
}
