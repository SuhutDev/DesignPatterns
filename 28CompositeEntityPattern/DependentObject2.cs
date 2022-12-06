
namespace CompositeEntityPattern;

public class DependentObject2
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
