
using MvcPattern;

Student student = new();
student.SetName("Robert");
student.SetRollNo("10");

var model = student;

StudentView view = new();

StudentController controller = new(model, view);

controller.UpdateView();

controller.SetStudentName("John");

controller.UpdateView();