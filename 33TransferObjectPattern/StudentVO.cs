
namespace TransferObjectPattern;

public class StudentVO
{
    private string _name;
    private int _rollNo;

    public StudentVO(string name, int rollNo)
    {
        _name = name;
        _rollNo = rollNo;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
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
