
namespace ChainOfResposibilityPattern;

public class ConsoleLogger : AbstractLogger
{
    public ConsoleLogger(int level)
    {
        Level = level;
    } 
    protected override void Write(string message)
    {
        System.Console.WriteLine($"Standard Console.Logger : {message}");
    }

}
