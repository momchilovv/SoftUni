using System;

class Program
{
    static void Main(string[] args)
    {
        string typeOfDay = Console.ReadLine();
        int ageOfPerson = int.Parse(Console.ReadLine());

        if (ageOfPerson >= 123 || ageOfPerson < 0)
        {
            Console.WriteLine("Error!");
            Environment.Exit(0);
        }
        else
        {
            switch (typeOfDay)
            {
                case "Weekday":
                    if (ageOfPerson >= 0 && ageOfPerson <= 18)
                        Console.WriteLine("12$");
                    else if (ageOfPerson >= 19 && ageOfPerson <= 64)
                        Console.WriteLine("18$");
                    else if (ageOfPerson >= 65 && ageOfPerson <= 122)
                        Console.WriteLine("12$");
                    break;
                case "Weekend":
                    if (ageOfPerson >= 0 && ageOfPerson <= 18)
                        Console.WriteLine("15$");
                    else if (ageOfPerson >= 19 && ageOfPerson <= 64)
                        Console.WriteLine("20$");
                    else if (ageOfPerson >= 65 && ageOfPerson <= 122)
                        Console.WriteLine("15$");
                    break;
                case "Holiday":
                    if (ageOfPerson >= 0 && ageOfPerson <= 18)
                        Console.WriteLine("5$");
                    else if (ageOfPerson >= 19 && ageOfPerson <= 64)
                        Console.WriteLine("12$");
                    else if (ageOfPerson >= 65 && ageOfPerson <= 122)
                        Console.WriteLine("10$");
                    break;
            }
        }
    }
}