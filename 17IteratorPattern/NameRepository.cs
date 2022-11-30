
namespace IteratorPattern;

public class NameRepository : IContailer
{
    public string[] names = { "Robert", "John", "Julie", "Lora" };

    public IIterator GetIterator()
    {
        return new NameIterator(names);
    }
}
