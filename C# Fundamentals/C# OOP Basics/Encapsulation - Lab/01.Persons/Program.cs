using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());
        List<Person> persons = new List<Person>();

        for (int i = 0; i < lines; i++)
        {
            string[] command = Console.ReadLine().Split();
            Person person = new Person(command[0], command[1], int.Parse(command[2]));
            persons.Add(person);
        }
        persons.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList().ForEach(p => Console.WriteLine(p.ToString()));
    }
}