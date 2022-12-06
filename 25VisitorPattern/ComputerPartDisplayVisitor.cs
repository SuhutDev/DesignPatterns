namespace VisitorPattern;

public class ComputerPartDisplayVisitor : IComputerPartVisitor
{
    public void Visit(Computer computer)
    {
        System.Console.WriteLine("Displaying Computer");
    }

    public void Visit(Mouse mouse)
    {
        System.Console.WriteLine("Displaying Mouse");
    }

    public void Visit(Keyboard kayboard)
    {
        System.Console.WriteLine("Displaying Keyboard");
    }

    public void Visit(Monitor monitor)
    {
        System.Console.WriteLine("Displaying Monitor");
    }
}
