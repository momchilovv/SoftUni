using System;
using System.Collections.Generic;
using System.Text;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }


        public int CompareTo(Person otherPerson)
        {
            int result = Name.CompareTo(otherPerson.Name);

            if (result != 0) return result;

            result = Age.CompareTo(otherPerson.Age);

            if (result != 0) return result;

            return Town.CompareTo(otherPerson.Town);
        }
    }
}