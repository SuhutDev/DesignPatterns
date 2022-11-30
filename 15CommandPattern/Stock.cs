
namespace CommandPattern;

public class Stock
{
    private string _name = "ABC";
    private int _quantity = 10;

    public void Buy()
    {
        System.Console.WriteLine("Stock [ Name: " + _name + ",Quantity: " + _quantity + " ] bought");
    }

    public void Sell()
    {
        System.Console.WriteLine("Stock [ Name: " + _name + ", Quantity: " + _quantity + " ] sold");
    }
}
