using System.Collections.Generic;
using System.Linq;

public class Family
{
    private List<Person> members;

    public Family()
    {
        this.members = new List<Person>();
    }
    public List<Person> Members
    {
        get { return this.members; }
        set { this.members = value; }
    }
    public void AddMember(Person member)
    {
        this.members.Add(member);
    }
    public Person GetOldestPerson()
    {
        return this.members.OrderByDescending(m => m.Age).FirstOrDefault();
    }
}