using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name { get; set; }
    public string ID { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        string[] input = Console.ReadLine().Split();

        while (input[0] != "End")
        {
            string name = input[0], id = input[1];
            int age = int.Parse(input[2]);
            bool isChanged = false;

            Person person = new Person()
            {
                Name = name,
                ID = id,
                Age = age
            };

            foreach (var prn in people)
            {
                if (prn.ID == id)
                {
                    prn.Name = name;
                    prn.Age = age;
                    isChanged = true;
                }
            }
            if (!isChanged)
            {
                people.Add(person);
            }
   
            input = Console.ReadLine().Split();
        }

        foreach (var person in people.OrderBy(a => a.Age))
        {
            Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
        }
    }
}