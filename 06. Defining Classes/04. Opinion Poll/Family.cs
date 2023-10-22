
namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }

        private List<Person> people;

        public List<Person> People
        {
            get
            {
                return people;
            }
            set
            {
                people = value;
            }
        }

        public void AddMember(Person member)
        {
            People.Add(member);
        }

       public Person GetOldestMember()
        {
            //return this.people.OrderByDescending(x => x.Age).FirstOrDefault();
            return People.MaxBy(p => p.Age);
        }
    }
}
