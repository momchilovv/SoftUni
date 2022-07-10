using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<double> grades = new List<double>();

        int judges = int.Parse(Console.ReadLine());

        string presentation = Console.ReadLine();

        while (presentation != "Finish")
        {
            double currentGrade = 0;

            for (int i = 0; i < judges; i++)
            {
                currentGrade += double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"{presentation} - {currentGrade / judges:f2}.");

            grades.Add(currentGrade / judges);
            presentation = Console.ReadLine();
        }
        Console.WriteLine($"Student's final assessment is {grades.Average():f2}.");
    }
}