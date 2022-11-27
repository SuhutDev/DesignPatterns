

namespace FilterPattern;

public class OrCriteria : ICriteria
{
    private ICriteria Criteria;
    private ICriteria OtherCriteria;
  
    public OrCriteria(ICriteria criteria, ICriteria otherCriteria) {
        Criteria = criteria;
        OtherCriteria = otherCriteria; 
    }

    public List<Person> MeetCriteria(List<Person> persons)
    { 
         List<Person> firstCriteriaPersons = Criteria.MeetCriteria(persons);		
        return OtherCriteria.MeetCriteria(firstCriteriaPersons);
    }
}
