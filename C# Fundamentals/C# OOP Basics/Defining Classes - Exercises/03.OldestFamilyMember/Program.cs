using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestPerson");
        MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }

        Family family = new Family();
        int numbersOfFamily = int.Parse(Console.ReadLine());

        while(numbersOfFamily > 0)
        { 
            string[] data = Console.ReadLine().Split();
            Person person = new Person(data[0], int.Parse(data[1]));
            family.AddMember(person);

            numbersOfFamily--;
        }
        
        Person oldestPerson = family.GetOldestPerson();
        Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
    }
}