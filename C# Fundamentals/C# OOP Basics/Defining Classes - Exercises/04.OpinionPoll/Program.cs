using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.OpinionPoll
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMembers = int.Parse(Console.ReadLine());

            List<Person> members = new List<Person>();

            for (int i = 0; i < numberOfMembers; i++)
            {
                string[] data = Console.ReadLine().Split();

                Person person = new Person(data[0], int.Parse(data[1]));
                if (person.Age > 30)
                {
                    members.Add(person);
                }
            }
            foreach (var name in members.OrderBy(m => m.Name))
            {
                Console.WriteLine($"{name.Name} - {name.Age}");
            }
        }
    }
}