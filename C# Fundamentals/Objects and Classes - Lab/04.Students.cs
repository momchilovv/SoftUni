using System;
using System.Collections.Generic;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }

}
class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        
        string[] input = Console.ReadLine().Split();

        while (input[0] != "end")
        {
            Student student = new Student()
            {
                FirstName = input[0],
                LastName = input[1],
                Age = int.Parse(input[2]),
                HomeTown = input[3]
            };

            students.Add(student);
            input = Console.ReadLine().Split();           
        }
        string townToPrint = Console.ReadLine();

        foreach (var student in students)
        {
            if (student.HomeTown == townToPrint)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}