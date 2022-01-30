using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int unsatisfiedGrades = int.Parse(Console.ReadLine());
        string taskName = Console.ReadLine();
        int grade = int.Parse(Console.ReadLine());
        List<double> grades = new List<double>();

        int poorGradesCount = 0;
        int taskCount = 0;
        string lastTask = null;

        while (taskName != "Enough")
        {
            taskCount++;
            if (grade <= 4)
            {
                poorGradesCount++;
                if (poorGradesCount == unsatisfiedGrades)
                {
                    Console.WriteLine($"You need a break, {poorGradesCount} poor grades.");
                    System.Environment.Exit(0);
                }
            }
            grades.Add(grade);

            lastTask = taskName;
            taskName = Console.ReadLine();
            if (taskName == "Enough")
                break;
            grade = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Average score: {grades.Average():f2}");
        Console.WriteLine($"Number of problems: {taskCount}");
        Console.WriteLine($"Last problem: {lastTask}");
    }
}