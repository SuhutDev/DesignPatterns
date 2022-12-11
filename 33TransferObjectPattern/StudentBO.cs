
namespace TransferObjectPattern;

public class StudentBO
{
    //list is working as a database
    private List<StudentVO> _students;

    public StudentBO()
    {
        _students = new();
        StudentVO student1 = new("Robert", 0);
        StudentVO student2 = new("John", 1);
        _students.Add(student1);
        _students.Add(student2);
    }
    public void deleteStudent(StudentVO student)
    {
        _students.RemoveAt(student.GetRollNo());
        System.Console.WriteLine("Student: Roll No " + student.GetRollNo() + ", deleted from database");
    }

    //retrive list of _students from the database
    public List<StudentVO> GetAllStudents()
    {
        return _students;
    }

    public StudentVO GetStudent(int rollNo)
    {
        return _students[rollNo];
    }

    public void UpdateStudent(StudentVO student)
    {
        _students[student.GetRollNo()].SetName(student.GetName());
        System.Console.WriteLine("Student: Roll No " + student.GetRollNo() + ", updated in the database");
    }
}
