
namespace FilterPattern;

public class CriteriaSingle : ICriteria
{
    public List<Person> MeetCriteria(List<Person> persons)
    {
        List<Person> singlePersons = new();
        foreach (var person in persons)
        {
            if(string.Equals(person.GetGender(),"SINGLE", StringComparison.OrdinalIgnoreCase)) {
                singlePersons.Add(person);
            }
        }
        return singlePersons;
    }
}
