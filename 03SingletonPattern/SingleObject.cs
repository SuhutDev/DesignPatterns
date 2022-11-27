namespace SingletonPattern;

public class SingleObject
{
    private static SingleObject instance=new SingleObject();

    private SingleObject() {

    }
    public static SingleObject GetInstance() {
        return instance;
    }

    public void ShowMessage() {
        System.Console.WriteLine("Hello world");
    }
}
