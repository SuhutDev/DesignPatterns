
namespace MvcPattern;
public class StudentView
{
    public void PrintStudentDetails(string studentName, string studentRollNo)
    {
        System.Console.WriteLine("Student :");
        System.Console.WriteLine("Name : " + studentName);
        System.Console.WriteLine("Roll No : " + studentRollNo);
    }
}
