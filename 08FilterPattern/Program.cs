using FilterPattern;

List<Person> persons = new();

      persons.Add(new Person("Robert","Male", "Single"));
      persons.Add(new Person("John","Male", "Married"));
      persons.Add(new Person("Laura","Female", "Married"));
      persons.Add(new Person("Diana","Female", "Single"));
      persons.Add(new Person("Mike","Male", "Single"));
      persons.Add(new Person("Bobby","Male", "Single"));

      ICriteria male = new CriteriaMale();
      ICriteria female = new CriteriaFemale();
      ICriteria single = new CriteriaSingle();
      ICriteria singleMale = new AndCriteria(single, male);
      ICriteria singleOrFemale = new OrCriteria(single, female);
 
      System.Console.WriteLine("Males :");
      CustomPrint.PrintPersons(male.MeetCriteria(persons));
 
      System.Console.WriteLine("Females :");
      CustomPrint.PrintPersons(female.MeetCriteria(persons));
 
      System.Console.WriteLine("Single Males :");
      CustomPrint.PrintPersons(singleMale.MeetCriteria(persons));
 
      System.Console.WriteLine("Single Or Females:");
      CustomPrint.PrintPersons(singleOrFemale.MeetCriteria(persons));

public class CustomPrint {
   public static void PrintPersons(List<Person> persons) {
         foreach (Person person in persons) {
            System.Console.WriteLine("Person : [ Name : " + person.GetName() 
            +", Gender : " + person.GetGender() 
            +", Marital Status : " + person.GetMaritalStatus()
            +" ]"); 
      }
    }
 }