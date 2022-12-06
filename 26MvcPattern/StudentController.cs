
namespace MvcPattern;

public class StudentController
{
    private readonly Student _model;
    private readonly StudentView _view;
    public StudentController(Student model, StudentView view)
    {
        _model = model;
        _view = view;
    }
    public void SetStudentName(string name)
    {
        _model.SetName(name);
    }
    public string GetStudentName()
    {
        return _model.GetName();
    }
    public void SetStudentRollNo(string rollNo)
    {
        _model.SetRollNo(rollNo);
    }
    public string GetStudentRollNo()
    {
        return _model.GetRollNo();
    }
    public void UpdateView()
    {
        _view.PrintStudentDetails(_model.GetName(), _model.GetRollNo());
    }
}
