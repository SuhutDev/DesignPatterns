

namespace DataAccessObjectPattern;

public class StudentDaoImpl : IStudentDao
{
    List<Student> _students;

    public StudentDaoImpl()
    {
        _students = new();
        Student student1 = new("Robert", 0);
        Student student2 = new("John", 1);
        _students.Add(student1);
        _students.Add(student2);
    }
    public void DeleteStudent(Student student)
    {
        _students.RemoveAt(student.GetRollNo());
    }

    public List<Student> GetAllStudents()
    {
        return _students;
    }

    public Student GetStudent(int rollNo)
    {
        return _students[rollNo];
    }

    public void UpdateStudent(Student student)
    {
        _students[student.GetRollNo()].SetName(student.GetName());
        System.Console.WriteLine($"Student: Roll No {student.GetRollNo()} , updated in the database");
    }
}