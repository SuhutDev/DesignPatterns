using NullObjectPattern;

AbstractCustomer customer1 = CustomerFactory.GetCustomer("Rob");
AbstractCustomer customer2 = CustomerFactory.GetCustomer("Bob");
AbstractCustomer customer3 = CustomerFactory.GetCustomer("Julie");
AbstractCustomer customer4 = CustomerFactory.GetCustomer("Laura");

System.Console.WriteLine("Customers");
System.Console.WriteLine(customer1.GetName());
System.Console.WriteLine(customer2.GetName());
System.Console.WriteLine(customer3.GetName());
System.Console.WriteLine(customer4.GetName());