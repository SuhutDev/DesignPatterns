
using TransferObjectPattern;

StudentBO studentBusinessObject = new StudentBO();

//print all students
foreach (var std in studentBusinessObject.GetAllStudents())
{
    System.Console.WriteLine("Student: [RollNo : " + std.GetRollNo() + ", Name : " + std.GetName() + " ]");
}

//update student
StudentVO student = studentBusinessObject.GetAllStudents()[0];
student.SetName("Michael");
studentBusinessObject.UpdateStudent(student);

//get the student
studentBusinessObject.GetStudent(0);
System.Console.WriteLine("Student: [RollNo : " + student.GetRollNo() + ", Name : " + student.GetName() + " ]");