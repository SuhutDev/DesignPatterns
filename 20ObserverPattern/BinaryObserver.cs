
namespace ObserverPattern;

public class BinaryObserver : Observer
{
    public BinaryObserver(Subject subject) : base(subject)
    {
        subject.Attach(this);
    }
    public override void Update()
    {
        System.Console.WriteLine($"Binary String {Convert.ToString(_subject.GetState(), 2)} ");
    }
}
