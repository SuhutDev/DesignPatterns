using MediatorPattern;

User robert = new("Robert");
User john = new("John");

robert.SendMessage("Hi! John!");
john.SendMessage("Hello! Robert!");