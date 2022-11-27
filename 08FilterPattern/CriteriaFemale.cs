

namespace FilterPattern;

public class CriteriaFemale : ICriteria
{
    public List<Person> MeetCriteria(List<Person> persons)
    {
        List<Person> femalePersons = new();
        foreach (var person in persons)
        {
            if(string.Equals(person.GetGender(),"FEMALE", StringComparison.OrdinalIgnoreCase)) {
                femalePersons.Add(person);
            }
        }
        return femalePersons;
    }
}
