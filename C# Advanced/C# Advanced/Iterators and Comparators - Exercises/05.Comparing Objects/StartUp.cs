using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] data = command.Split();

                Person person = new Person
                {
                    Name = data[0],
                    Age = int.Parse(data[1]),
                    Town = data[2]
                };

                people.Add(person);

                command = Console.ReadLine();
            }

            int index = int.Parse(Console.ReadLine()) - 1;

            Person personToCompare = people[index];

            int matches = 0;
            int different = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    matches++;
                }
                else
                {
                    different++;
                }
            }

            if (matches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matches} {different} {people.Count}");
            }
        }
    }
}