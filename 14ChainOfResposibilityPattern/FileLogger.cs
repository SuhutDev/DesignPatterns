
namespace ChainOfResposibilityPattern;

public class FileLogger : AbstractLogger
{
    public FileLogger(int level)
    {
        Level=level;
    }

    protected override void Write(string message)
    {
        System.Console.WriteLine($"File.Logger : {message}");
    }
}
