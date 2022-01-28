using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string student = Console.ReadLine();
        List<double> grades = new List<double>();
        double grade;
        int timesFailed = 0;

        while (grades.Count < 12)
        {
            grade = double.Parse(Console.ReadLine());
            grades.Add(grade);

            if (grade < 4.00)
            {
                timesFailed++;
            }
            if (timesFailed == 2)
            {
                Console.WriteLine($"{student} has been excluded at {grades.Count - 1} grade");
                System.Environment.Exit(0);
            }
        }
        Console.WriteLine($"{student} graduated. Average grade: {grades.Average():f2}");
    }
}