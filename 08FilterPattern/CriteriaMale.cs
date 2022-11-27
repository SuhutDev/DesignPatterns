
namespace FilterPattern;

public class CriteriaMale : ICriteria
{
    public List<Person> MeetCriteria(List<Person> persons)
    {
        List<Person> malePersons = new();
        foreach (var person in persons)
        {
            if(string.Equals(person.GetGender(),"MALE", StringComparison.OrdinalIgnoreCase)) {
                malePersons.Add(person);
            }
        }
        return malePersons;
    }
}
