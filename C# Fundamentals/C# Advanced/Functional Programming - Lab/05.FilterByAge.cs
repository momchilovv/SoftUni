using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> list = new List<Person>();

            string[] input;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                list.Add(new Person(input[0], int.Parse(input[1])));
            }
            string condition = Console.ReadLine();
            int intAge = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            if (condition == "younger")
            {
                list = list.Where(a => a.Age < intAge).ToList();
            }
            else if (condition == "older")
            {
                list = list.Where(a => a.Age >= intAge).ToList();
            }
            var orderTokens = format.Split();
            if (orderTokens.Length > 1)
            {
                foreach (var person in list)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
            }
            else
            {
                if (orderTokens[0] == "name")
                {
                    foreach (var person in list)
                    {
                        Console.WriteLine(person.Name);
                    }
                }
                else
                {
                    foreach (var person in list)
                    {
                        Console.WriteLine(person.Age);
                    }
                }
            }
        }
        class Person
        {
            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}