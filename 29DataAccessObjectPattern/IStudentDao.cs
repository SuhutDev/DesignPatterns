
namespace DataAccessObjectPattern;

public interface IStudentDao
{
    List<Student> GetAllStudents();
    Student GetStudent(int rollNo);
    void UpdateStudent(Student student);
    void DeleteStudent(Student student);
}
