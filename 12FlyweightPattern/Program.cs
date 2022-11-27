using FlyweightPattern;


for (int i = 0; i < 20; ++i)
{
    Circle circle =
       (Circle)ShapeFactory.GetCircle(CustomRandom.GetRandomColor());
    circle.SetX(CustomRandom.GetRandomX());
    circle.SetY(CustomRandom.GetRandomY());
    circle.SetRadius(100);
    circle.Draw();
}

class CustomRandom
{
    private static string[] _colors =
      { "Red", "Green", "Blue", "White", "Black" };

    private static Random rnd = new Random();
    public static String GetRandomColor()
    {
        return _colors[(int)(rnd.Next(0, _colors.Count()-1))];
    }
    public static int GetRandomX()
    {
        return (int)(rnd.Next(1000) * 100);
    }
    public static int GetRandomY()
    {
        return (int)(rnd.Next(1000) * 100);
    }
}