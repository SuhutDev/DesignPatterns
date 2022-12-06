
namespace CompositeEntityPattern;

public class CompositeEntity
{
    private CoarseGrainedObject cgo = new CoarseGrainedObject();

    public void SetData(String data1, String data2)
    {
        cgo.SetData(data1, data2);
    }

    public String[] GetData()
    {
        return cgo.GetData();
    }
}
