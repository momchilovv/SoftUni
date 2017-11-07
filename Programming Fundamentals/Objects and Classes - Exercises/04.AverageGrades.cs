using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Student[] student = new Student[n];

            for (int i = 0; i < n; i++)
            {
                student[i] = ReadStudent(Console.ReadLine());
            }
            foreach (var st in student.Where(x => x.AverageGrade >=5.00).OrderBy(y => y.Name).ThenByDescending(z => z.AverageGrade))
            {
                Console.WriteLine($"{st.Name} -> {st.AverageGrade:f2}");
            }
        }
        static Student ReadStudent(string input)
        {
            string[] str = input.Split();
            List<double> grades = new List<double>();

            foreach (var item in str.Skip(1))
            {
                grades.Add(double.Parse(item));
            }
            return new Student { Name = str[0], Grades = grades };
        }
    }
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get { return Grades.Average(); } }
    }
}