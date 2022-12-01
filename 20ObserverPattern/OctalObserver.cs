
namespace ObserverPattern;

public class OctalObserver : Observer
{
    public OctalObserver(Subject subject) : base(subject)
    {
        subject.Attach(this);
    }
    public override void Update()
    {
        System.Console.WriteLine($"Octa String {Convert.ToString(_subject.GetState(), 8)} ");
    }
}
