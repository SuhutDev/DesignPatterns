using ChainOfResposibilityPattern;


AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);
AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

errorLogger.SetNextLogger(fileLogger);
fileLogger.SetNextLogger(consoleLogger);

AbstractLogger loggerChain = errorLogger;

loggerChain.LogMessage(AbstractLogger.INFO,
   "This is an information.");

loggerChain.LogMessage(AbstractLogger.DEBUG,
   "This is an debug level information.");

loggerChain.LogMessage(AbstractLogger.ERROR,
   "This is an error information.");