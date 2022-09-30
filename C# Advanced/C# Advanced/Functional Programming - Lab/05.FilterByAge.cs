using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var peopleList = new List<Person>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            peopleList.Add(new Person()
            {
                Name = input[0],
                Age = int.Parse(input[1])
            });
        }

        string condition = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string[] format = Console.ReadLine().Split();

        Func<Person, bool> cond;

        if (condition == "younger")
        {
            cond = p => p.Age < age;
        }
        else
        {
            cond = p => p.Age >= age;
        }

        Func<Person, string> formatted;

        if (format.Length == 2)
        {
            formatted = p => $"{p.Name} - {p.Age}";
        }
        else if (format[0] == "name")
        {
            formatted = p => $"{p.Name}";
        }
        else
        {
            formatted = p => $"{p.Age}";
        }

        foreach (var person in peopleList.Where(cond).Select(formatted).ToList()) 
        {
            Console.WriteLine(person);
        }
    }
}
internal class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}