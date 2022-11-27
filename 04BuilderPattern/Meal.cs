namespace BuilderPattern;

public class Meal
{
    private List<IItem> Items = Enumerable.Empty<IItem>().ToList();

    public void AddItem(IItem item) {
        Items.Add(item);
    }

    public double GetCost() {
        double cost=0.0d;
        foreach(var item in Items) {
            cost+=item.Price();
        }
        return cost;
    }

    public void ShowItems() {
        foreach(var item in Items) {
            System.Console.Write($"Item : {item.Name()}");
            System.Console.Write($", Packing : {item.Packing().Pack()}");
            System.Console.WriteLine($", Price : {item.Price().ToString()}");
        }
    } 
}
