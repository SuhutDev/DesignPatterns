
namespace BusinessDelegatePattern;

public class EjbService : IBusinessService
{
    public void DoProcessing()
    {
        System.Console.WriteLine("Processing task by invoking EJB Service");
    }
}
