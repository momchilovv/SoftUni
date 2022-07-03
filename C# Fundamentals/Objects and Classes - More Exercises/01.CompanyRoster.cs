using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }

    public double Salary { get; set; }

    public List<double> Salaries = new List<double>();

    public string Department { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee();
        List<Employee> employees = new List<Employee>();
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            string[] input = Console.ReadLine().Split();

            string name = input[0], department = input[2];
            double salary = double.Parse(input[1]);

            employee = new Employee()
            {
                Name = name,
                Salary = salary,
                Department = department
            };
            employee.Salaries.Add(salary);
            employees.Add(employee);
        }

        double highestAverage = 0;
        string highestDepartment = null;

        foreach (var em in employees)
        {
            if (highestAverage < em.Salaries.Average())
            {
                highestAverage = em.Salaries.Average();
                highestDepartment = em.Department;
            }
        }

        Console.WriteLine($"Highest Average Salary: {highestDepartment}");

        foreach (var em in employees.Where(em => em.Department == highestDepartment).OrderByDescending(s => s.Salary))
        {
            Console.WriteLine($"{em.Name} {em.Salary:f2}");
        }
    }
}