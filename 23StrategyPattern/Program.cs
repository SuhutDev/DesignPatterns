
using StrategyPattern;

Context context = new(new OperationAdd());
System.Console.WriteLine("10 + 5 = " + context.ExecuteStrategy(10, 5));

context = new(new OperationSubtract());
System.Console.WriteLine("10 - 5 = " + context.ExecuteStrategy(10, 5));

context = new(new OperationMultiply());
System.Console.WriteLine("10 * 5 = " + context.ExecuteStrategy(10, 5));