namespace ChainOfResposibilityPattern;

public abstract class AbstractLogger
{
    public static int INFO = 1;
    public static int DEBUG = 2;
    public static int ERROR = 3;

    protected int Level;

    protected AbstractLogger? NextLogger;

    public void SetNextLogger(AbstractLogger nextLogger)
    {
        NextLogger = nextLogger;
    }

    public void LogMessage(int level, string message)
    {
        if (Level <= level)
        {
            Write(message);
        }
        if (NextLogger is not null)
        {
            NextLogger.LogMessage(level, message);
        }
    }

    abstract protected void Write(string message);
}
