namespace PrototypePattern;

public class Square : Shape
{
    public Square()
    {
        Type="Square";
    }
    public override void Draw()
    {
       System.Console.WriteLine("Inside Square.Dran");
    }
}
