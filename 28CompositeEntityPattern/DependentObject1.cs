
namespace CompositeEntityPattern;

public class DependentObject1
{
    private string? _data;

    public void SetData(string data)
    {
        _data = data!;
    }

    public string GetData()
    {
        return _data!;
    }
}
