using StatePattern;

Context context = new();

StartState startState = new();
startState.DoAction(context);

System.Console.WriteLine(context.GetState().ToString());

StopState stopState = new();
stopState.DoAction(context);

System.Console.WriteLine(context.GetState().ToString());

