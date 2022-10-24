using System;
using System.Collections.Generic;
using System.Text;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int CompareTo(Person otherPerson)
        {
            if (Name.CompareTo(otherPerson.Name) != 0)
            {
                return Name.CompareTo(otherPerson.Name);
            }
            return Age.CompareTo(otherPerson.Age);
        }

        public override bool Equals(object obj)
        {
            Person otherPerson = obj as Person;

            if (otherPerson == null)
            {
                return false;
            }

            return Name == otherPerson.Name && Age == otherPerson.Age;
        }

        public override int GetHashCode()
        {
            int hashCode = Name.GetHashCode() + Age.GetHashCode();

            return hashCode;
        }
    }
}