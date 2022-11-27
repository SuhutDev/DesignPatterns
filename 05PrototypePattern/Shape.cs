
namespace PrototypePattern;
 
public abstract class Shape : ICloneable
{
    private string? Id;
    protected string? Type; 
    public abstract void Draw();
    public string GetTypeX() {
        return Type!;
    }
    public string GetId() {
        return Id!;
    }

    public void SetId(string id) {
        Id=id;
    }

    public object Clone() {
        object? clone=null;
        try {
            clone=base.MemberwiseClone();
        }
        catch (Exception ex) {
            System.Console.WriteLine(ex);
        }
        return clone!;
    }
}