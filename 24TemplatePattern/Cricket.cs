
namespace TemplatePattern;

public class Cricket : Game
{
    public override void EndPlay()
    {
        System.Console.WriteLine("Cricket Game Finish");
    }

    public override void Initialize()
    {
        System.Console.WriteLine("Cricket Game Initialized! Start playing.");
    }

    public override void StartPlay()
    {
        System.Console.WriteLine("Cricket Game Started. Enjoy the game!");
    }
}
