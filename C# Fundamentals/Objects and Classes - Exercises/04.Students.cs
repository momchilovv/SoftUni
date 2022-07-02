using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        int countOfStudents = int.Parse(Console.ReadLine());

        for (int i = 0; i < countOfStudents; i++)
        {
            string[] input = Console.ReadLine().Split();

            Student student = new Student()
            {
                FirstName = input[0],
                LastName = input[1],
                Grade = double.Parse(input[2])
            };

            students.Add(student);
        }

        foreach (var student in students.OrderByDescending(g => g.Grade))
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
        }
    }
}