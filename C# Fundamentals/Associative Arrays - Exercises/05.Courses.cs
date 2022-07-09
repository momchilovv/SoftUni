using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

        string[] input = Console.ReadLine().Split(" : ");

        while (input[0] != "end")
        {
            if (!courses.ContainsKey(input[0]))
            {
                var temp = new List<string>();
                temp.Add(input[1]);
                courses.Add(input[0], temp);
            }
            else
            {
                courses[input[0]].Add(input[1]);
            }

            input = Console.ReadLine().Split(" : ");
        }
        foreach (var course in courses)
        {
            Console.WriteLine($"{course.Key}: {course.Value.Count}");
            Console.Write("-- ");
            Console.WriteLine(string.Join("\r\n-- ", course.Value));
        }
    }
}