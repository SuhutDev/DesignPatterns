
namespace TemplatePattern;

public class Football : Game
{
    public override void EndPlay()
    {
        System.Console.WriteLine("Football Game Finish");
    }

    public override void Initialize()
    {
        System.Console.WriteLine("Football Game Initialized! Start playing.");
    }

    public override void StartPlay()
    {
        System.Console.WriteLine("Football Game Started. Enjoy the game!");
    }
}
