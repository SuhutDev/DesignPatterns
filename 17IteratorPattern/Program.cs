using IteratorPattern;

NameRepository namesRepository = new();

for (var iter = namesRepository.GetIterator(); iter.HasNext();)
{
    String name = (string)(iter.Next() ?? "");
    System.Console.WriteLine("Name : " + name);
}