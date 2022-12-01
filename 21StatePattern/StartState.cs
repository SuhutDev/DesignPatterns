
namespace StatePattern;

public class StartState : IState
{
    public void DoAction(Context context)
    {
        System.Console.WriteLine("Player is in start state");
        context.SetState(this);
    }

    public override string ToString()
    {
        return "Start State";
    }
}
