
namespace CompositeEntityPattern;

public class Client
{
    private CompositeEntity compositeEntity = new();

    public void PrintData()
    {
        for (int i = 0; i < compositeEntity.GetData().Length; i++)
        {
            System.Console.WriteLine("Data: " + compositeEntity.GetData()[i]);
        }
    }

    public void SetData(String data1, String data2)
    {
        compositeEntity.SetData(data1, data2);
    }
}