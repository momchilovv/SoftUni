using System;

class Program
{
    static void Main(string[] args)
    {
        double deposit = double.Parse(Console.ReadLine());
        int depositDeadline = int.Parse(Console.ReadLine());
        double yearInterest = double.Parse(Console.ReadLine());

        double interestPerYear = deposit * (yearInterest / 100);
        double interestPerMonth = interestPerYear / 12;
        double total = deposit + (depositDeadline * interestPerMonth);

        Console.WriteLine(total);
    }
}