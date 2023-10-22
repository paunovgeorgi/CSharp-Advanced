namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family currentFamily = new Family();

            int numOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfPeople; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                Person currentMember = new Person(name, age);
                currentFamily.AddMember(currentMember);
                //currentFamily.AddMember(new Person(name, age));
            }

            foreach (Person p in currentFamily.People.Where(p=>p.Age > 30).OrderBy(p=>p.Name))
            {
               Console.WriteLine($"{p.Name} - {p.Age}");
            }
        }
    }
}