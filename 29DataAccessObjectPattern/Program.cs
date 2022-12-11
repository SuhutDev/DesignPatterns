using DataAccessObjectPattern;

IStudentDao studentDao = new StudentDaoImpl();

//print all students
foreach (var std in studentDao.GetAllStudents())
{
    System.Console.WriteLine($"Student: [RollNo : {std.GetRollNo()} , Name : {std.GetName()} ]");
}


//update student
Student student = studentDao.GetAllStudents()[0];
student.SetName("Michael");
studentDao.UpdateStudent(student);

//get the student
studentDao.GetStudent(0);
System.Console.WriteLine($"Student: [RollNo : {student.GetRollNo()}, Name : {student.GetName()} ]");