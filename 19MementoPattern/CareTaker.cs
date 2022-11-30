
namespace MementoPattern;

public class CareTaker
{
    private List<Memento> _mementoList = new();

    public void Add(Memento state)
    {
        _mementoList.Add(state);
    }

    public Memento Get(int index)
    {
        return _mementoList[index];
    }
}
