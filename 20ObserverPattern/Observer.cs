
namespace ObserverPattern;

public abstract class Observer
{
    protected Subject _subject;

    protected Observer(Subject subject)
    {
        _subject = subject;
    }

    public abstract void Update();
}
