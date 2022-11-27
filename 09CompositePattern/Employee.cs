namespace CompositePattern;

public class Employee
{
    private string Name;
    private string Dept;
    private int Sallary;
    private List<Employee> Subordinates;

    public Employee(string name, string dept, int sallary, List<Employee>? subordinates = null)
    {
        Name = name;
        Dept = dept;
        Sallary = sallary;
        Subordinates ??= Enumerable.Empty<Employee>().ToList();
    }

    public void Add(Employee e)
    {
        Subordinates.Add(e);
    }

    public void Remove(Employee e)
    {
        Subordinates.Remove(e);
    }

    public List<Employee> GetSubordinates()
    {
        return Subordinates;
    }

    public override string ToString()
    {
        return ("Employee :[ Name : " + Name
                    + ", dept : " + Dept + ", salary :"
                    + Sallary.ToString() + " ]");
    }

}
