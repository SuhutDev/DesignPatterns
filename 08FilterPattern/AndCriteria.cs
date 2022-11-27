

namespace FilterPattern;

public class AndCriteria : ICriteria
{
    private ICriteria Criteria;
    private ICriteria OtherCriteria;
  
    public AndCriteria(ICriteria criteria, ICriteria otherCriteria) {
        Criteria = criteria;
        OtherCriteria = otherCriteria; 
    }

    public List<Person> MeetCriteria(List<Person> persons)
    { 
         List<Person> firstCriteriaPersons = Criteria.MeetCriteria(persons);		
        return OtherCriteria.MeetCriteria(firstCriteriaPersons);
    }
}
