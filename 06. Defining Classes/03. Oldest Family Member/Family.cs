namespace OldestFamilyMember;

public class Family
{
    private List<Person> people;

    public Family()
    {
        People = new List<Person>();
    }

    public List<Person> People
    {
        get
        {
            return this.people;
        }
        set
        {
            this.people = value;
        }
    }

    public void AddMember(Person person)
    {
        People.Add(person);
    }

    public Person GetOldestMember()
    {
        return People.MaxBy(p => p.Age);
    }
}