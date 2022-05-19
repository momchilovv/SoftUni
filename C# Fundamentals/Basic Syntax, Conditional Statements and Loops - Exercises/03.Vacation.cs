using System;

class Program
{
    static void Main(string[] args)
    {
        int numberOfPeople = int.Parse(Console.ReadLine());
        string typeOfGroup = Console.ReadLine();
        string dayOfWeek = Console.ReadLine();
        double totalSum = 0;

        switch (typeOfGroup)
        {
            case "Students":
                switch (dayOfWeek)
                {
                    case "Friday":
                        totalSum += numberOfPeople * 8.45;
                        break;
                    case "Saturday":
                        totalSum += numberOfPeople * 9.80;
                        break;
                    case "Sunday":
                        totalSum += numberOfPeople * 10.46;
                        break;
                }
                if (numberOfPeople >= 30)
                {
                    totalSum *= 0.85;
                }
                break;
            case "Business":
                if (numberOfPeople >= 100)
                {
                    numberOfPeople -= 10;
                }
                switch (dayOfWeek)
                {
                    case "Friday":
                        totalSum += numberOfPeople * 10.90;
                        break;
                    case "Saturday":
                        totalSum += numberOfPeople * 15.60;
                        break;
                    case "Sunday":
                        totalSum += numberOfPeople * 16;
                        break;
                }
                break;
            case "Regular":
                switch (dayOfWeek)
                {
                    case "Friday":
                        totalSum += numberOfPeople * 15;
                        break;
                    case "Saturday":
                        totalSum += numberOfPeople * 20;
                        break;
                    case "Sunday":
                        totalSum += numberOfPeople * 22.50;
                        break;
                }
                if (numberOfPeople >= 10 && numberOfPeople <= 20)
                {
                    totalSum *= 0.95;
                }
                break;
        }
        Console.WriteLine($"Total price: {totalSum:f2}");
    }
}