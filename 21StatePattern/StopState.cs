
namespace StatePattern;

public class StopState : IState
{
    public void DoAction(Context context)
    {
        System.Console.WriteLine("Player is in stop state");
        context.SetState(this);
    }

    public override string ToString()
    {
        return "Stop State";
    }
}
