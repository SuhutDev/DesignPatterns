
namespace VisitorPattern;

public class Computer : IComputerPart
{
    IComputerPart[] Parts;

    public Computer()
    {
        Parts = new IComputerPart[] { new Mouse(), new Keyboard(), new Monitor() }; 
    }

    public void Accept(IComputerPartVisitor computerPartVisitor)
    {
        for (int i = 0; i < Parts.Length; i++)
        {
            Parts[i].Accept(computerPartVisitor);
        }
        computerPartVisitor.Visit(this);
    }
}
