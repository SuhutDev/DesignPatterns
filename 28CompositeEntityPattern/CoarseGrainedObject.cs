
namespace CompositeEntityPattern;

public class CoarseGrainedObject
{
    DependentObject1 do1 = new();
    DependentObject2 do2 = new();

    public void SetData(string data1, string data2)
    {
        do1.SetData(data1);
        do2.SetData(data2);
    }

    public string[] GetData()
    {
        return new string[] { do1.GetData(), do2.GetData() };
    }
}
