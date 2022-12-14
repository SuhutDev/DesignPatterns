namespace VisitorPattern;

public class Mouse : IComputerPart
{
    public void Accept(IComputerPartVisitor computerPartVisitor)
    {
        computerPartVisitor.Visit(this);
    }
}
