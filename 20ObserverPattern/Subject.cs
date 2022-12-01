
namespace ObserverPattern;

public class Subject
{
    private List<Observer> _observers = Enumerable.Empty<Observer>().ToList();

    private int _state;

    public int GetState()
    {
        return _state;
    }

    public void SetState(int state)
    {
        _state = state;
        NotifAllObservers();
    }

    public void Attach(Observer observer)
    {
        _observers.Add(observer);
    }

    public void NotifAllObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }
}
