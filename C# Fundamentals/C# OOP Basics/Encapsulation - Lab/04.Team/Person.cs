using System;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public Person(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }
    public Person(string firstName, string lastName, int age, decimal salary) 
        : this(firstName, lastName, age)
    {
        this.Salary = salary;
    }
    public decimal Salary
    {
        get { return salary; }
        private set
        {
            if (value < 460.00m)
            {
                throw new ArgumentException("Salary cannot be less than 460 leva!");
            }
            this.salary = value;
        }
    }
    public int Age
    {
        get { return age; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            this.age = value;
        }
    }
    public string LastName
    {
        get { return lastName; }
        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }
            this.lastName = value;
        }
    }
    public string FirstName
    {
        get { return firstName; }
        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
            this.firstName = value;            
        }
    }
    public void IncreaseSalary(decimal percentage)
    {
        if (this.Age < 30)
        {
            this.salary += this.salary / 100; 
        }
        else
        {
            this.salary += this.salary / 200;
        }
    }
}