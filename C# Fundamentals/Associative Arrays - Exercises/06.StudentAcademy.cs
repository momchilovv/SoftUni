using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
        int number = int.Parse(Console.ReadLine());
        string currentStudent = null;

        for (int i = 1; i <= number * 2; i++)
        {
            string input = Console.ReadLine();

            if (i % 2 == 0)
            {
                if (!students.ContainsKey(currentStudent))
                {
                    var temp = new List<double>();
                    temp.Add(double.Parse(input));
                    students.Add(currentStudent, temp);
                }
                else
                {
                    students[currentStudent].Add(double.Parse(input));
                }
            }
            else
            {
                currentStudent = input;
            }
        }
        foreach (var student in students.Where(s => s.Value.Average() >= 4.50))
        {
            Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
        }
    }
}