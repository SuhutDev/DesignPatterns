namespace BuilderPattern;

public interface IItem
{
    public string Name();
    public IPacking Packing(); 
    public double Price();
}
