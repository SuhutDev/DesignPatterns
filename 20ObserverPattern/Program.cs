
using ObserverPattern;

Subject subject = new();

_ = new HexaObserver(subject);
_ = new OctalObserver(subject);
_ = new BinaryObserver(subject);

System.Console.WriteLine("First state change : 15");

subject.SetState(15);

System.Console.WriteLine("Second state change : 10");

subject.SetState(10);