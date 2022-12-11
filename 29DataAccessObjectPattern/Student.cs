
namespace DataAccessObjectPattern;

public class Student
{
    private string _name;
    private int _rollNo;

    public Student(string name, int rollNo)
    {
        _name = name;
        _rollNo = rollNo;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(String name)
    {
        _name = name;
    }

    public int GetRollNo()
    {
        return _rollNo;
    }

    public void SetRollNo(int rollNo)
    {
        _rollNo = rollNo;
    }
}
