using InterpreterPattern;

IExpression isMale = InterpreterPatternDemo.GetMaleExpression();
IExpression isMarriedWoman = InterpreterPatternDemo.GetMarriedWomanExpression();
System.Console.WriteLine("John is male? " + isMale.Interpret("John"));
System.Console.WriteLine("Julie is a married women? " + isMarriedWoman.Interpret("Married Julie"));


public class InterpreterPatternDemo
{
    //Rule: Robert and John are male
    public static IExpression GetMaleExpression()
    {
        IExpression robert = new TerminalExpression("Robert");
        IExpression john = new TerminalExpression("John");
        return new OrExpression(robert, john);
    }

    //Rule: Julie is a married women
    public static IExpression GetMarriedWomanExpression()
    {
        IExpression julie = new TerminalExpression("Julie");
        IExpression married = new TerminalExpression("Married");
        return new AndExpression(julie, married);
    }
}