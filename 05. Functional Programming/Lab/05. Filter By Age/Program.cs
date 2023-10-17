List<Person> people = new List<Person>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

    people.Add(new Person(input[0], int.Parse(input[1])));
}

string filterType = Console.ReadLine();

int age = int.Parse(Console.ReadLine());

string format = Console.ReadLine();


Func<Person, bool> filter = GetFilter(filterType, age);

people = people.Where(filter).ToList();

Action<Person> printer = GetPrinter(format);

foreach (Person person in people)
{
    printer(person);
}
Func<Person, bool> GetFilter(string filterType, int age)
{
    switch (filterType)
    {
        case "older": return person => person.Age >= age;
        case "younger": return person => person.Age < age;
        default:
            return null;
    }
}

Action<Person> GetPrinter(string formatType)
{
    switch (formatType)
    {
        case "name age": return p => Console.WriteLine($"{p.Name} - {p.Age}");
        case "name": return p => Console.WriteLine($"{p.Name}");
        case "age": return p => Console.WriteLine($"{p.Age}");
        default:
            return null;
    }
}
 class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }
}
