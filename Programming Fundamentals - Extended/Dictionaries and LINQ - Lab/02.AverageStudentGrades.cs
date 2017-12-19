using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();

            string[] input;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().ToArray();
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!dict.ContainsKey(name))                
                    dict[name] = new List<double>();

                dict[name].Add(grade);
            }
            foreach (var pair in dict)
            {
                string name = pair.Key;
                List<double> grades = pair.Value;

                double average = grades.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in grades)
                    Console.Write($"{grade:f2} ");

                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}