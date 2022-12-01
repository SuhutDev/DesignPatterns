
namespace ObserverPattern;

public class HexaObserver : Observer
{
    public HexaObserver(Subject subject) : base(subject)
    {
        subject.Attach(this);
    }
    public override void Update()
    {
        System.Console.WriteLine($"Hexa String {Convert.ToString(_subject.GetState(), 16).ToUpper()} ");
    }
}
