
namespace IteratorPattern;

public class NameIterator : IIterator
{
    int Index;
    string[] _names;

    public NameIterator(string[] names)
    {
        _names = names;
    }

    public bool HasNext()
    {
        if (Index < _names.Length)
        {
            return true;
        }
        return false;
    }

    public object? Next()
    {
        if (HasNext())
        {
            return _names[Index++];
        }
        return null;
    }
}