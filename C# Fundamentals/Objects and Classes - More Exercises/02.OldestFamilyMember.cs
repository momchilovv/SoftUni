using System;
using System.Collections.Generic;
using System.Linq;

class Family
{
    public List<string> People = new List<string>();
}

class Person
{
    public string Name { get; set; }

    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            string[] input = Console.ReadLine().Split();
            string name = input[0];
            int age = int.Parse(input[1]);

            Person person = new Person()
            {
                Name = name,
                Age = age
            };

            people.Add(person);
        }
        foreach (var person in people.OrderByDescending(p => p.Age))
        {
            Console.WriteLine($"{person.Name} {person.Age}");
            break;
        }
    }
}