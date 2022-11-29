
namespace ChainOfResposibilityPattern;

public class ErrorLogger : AbstractLogger
{
    public ErrorLogger(int level)
    {
        Level = level;
    }

    protected override void Write(string message)
    {
        System.Console.WriteLine($"Error Console.Logger : {message}");
    }

    
}
