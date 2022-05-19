using System;

class Program
{
    static void Main(string[] args)
    {
        double money = double.Parse(Console.ReadLine());
        int countOfStudents = int.Parse(Console.ReadLine());
        double lightsabrePrice = double.Parse(Console.ReadLine());
        double robePrice = double.Parse(Console.ReadLine());
        double beltPrice = double.Parse(Console.ReadLine());
        int count = 0;

        if (countOfStudents >= 6)
        {
            for (int i = 1; i <= countOfStudents; i += 6)
            {
                if (i + 6 > countOfStudents)
                {
                    break;
                }
                count++;     
            }
        }

        double total = (lightsabrePrice * (countOfStudents + Math.Ceiling(countOfStudents * 0.10))) + robePrice * countOfStudents
            + (beltPrice * (countOfStudents - count));

        if (money >= total)
        {
            Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
        }
        else
        {
            Console.WriteLine($"John will need {Math.Abs(total - money):f2}lv more.");
        }
    }
}