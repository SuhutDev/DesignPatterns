namespace AbstractFactoryPattern;

public class RoundedSquare : IShape
{
    public void Draw() {
        System.Console.WriteLine($"Inside RoundedSquare.Draw");
    }
}
