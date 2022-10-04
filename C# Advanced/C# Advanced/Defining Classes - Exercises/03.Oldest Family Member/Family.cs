using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }

        public List<Person> People { get; private set; }

        public void AddMember(Person person)
        {
            People.Add(person);
        }

        public Person GetOldestMember()
        {
            return People.OrderByDescending(p => p.Age).FirstOrDefault();
        }
    }
}