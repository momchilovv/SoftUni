using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> courses = Console.ReadLine().Split(", ").ToList();
        List<string> exercises = new List<string>();
        int counter = 1;

        string[] command = Console.ReadLine().Split(":");

        while (command[0] != "course start")
        {
            string course = command[1];
            switch (command[0])
            {
                case "Add":
                    if (!courses.Contains(course))
                    {
                        courses.Add(course);
                    }
                    break;
                case "Insert":
                    if (int.Parse(command[2]) >= 0 && int.Parse(command[2]) < courses.Count && !courses.Contains(course))
                    {
                        courses.Insert(int.Parse(command[2]), course);
                    }
                    break;
                case "Remove":
                    if (courses.Contains(course))
                    {
                        courses.Remove(course);
                    }
                    if (exercises.Contains(course))
                    {
                        exercises.Remove(course);
                    }
                    break;
                case "Swap":
                    if (courses.Contains(course) && courses.Contains(command[2]))
                    {
                        int firstIndex = courses.IndexOf(course), secondIndex = courses.IndexOf(command[2]);

                        courses[secondIndex] = course;
                        courses[firstIndex] = command[2];
                    }
                    break;
                case "Exercise":
                    if (courses.Contains(course))
                    {
                        exercises.Add(course);
                    }
                    else
                    {
                        courses.Add(course);
                        exercises.Add(course);
                    }
                    break;
            }
            command = Console.ReadLine().Split(":");
        }
        for (int i = 0; i < courses.Count; i++)
        {
            Console.WriteLine($"{counter}.{courses[i]}");
            counter++;

            if (exercises.Contains(courses[i]))
            {
                Console.WriteLine($"{counter}.{courses[i]}-Exercise");
                counter++;
            }
        }
    }
}