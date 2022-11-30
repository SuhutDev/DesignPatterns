using MementoPattern;


Originator originator = new Originator();
CareTaker careTaker = new CareTaker();
originator.SetState("State #1");
originator.SetState("State #2");
careTaker.Add(originator.SaveStateToMemento());
originator.SetState("State #3");
careTaker.Add(originator.SaveStateToMemento());
originator.SetState("State #4");

System.Console.WriteLine("Current State: " + originator.GetState());
originator.GetStateFromMemento(careTaker.Get(0));
System.Console.WriteLine("First saved State: " + originator.GetState());
originator.GetStateFromMemento(careTaker.Get(1));
System.Console.WriteLine("Second saved State: " + originator.GetState());
