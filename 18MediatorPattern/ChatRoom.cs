
namespace MediatorPattern;

public class ChatRoom
{
    public static void ShowMessage(User user, string message)
    {
        System.Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fffffff") + " [" + user.GetName() + "] : " + message);
    }
}
