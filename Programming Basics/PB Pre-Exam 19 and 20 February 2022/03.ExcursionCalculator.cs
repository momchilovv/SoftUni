using System;

class Program
{
    static void Main(string[] args)
    {
        int numberOfPeople = int.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        double pricePerPerson = 0;
        double totalPrice = 0;


        switch (season)
        {
            case "spring":
                if (numberOfPeople <= 5)
                {
                    pricePerPerson = 50;
                }
                else
                {
                    pricePerPerson = 48;
                }
                totalPrice = numberOfPeople * pricePerPerson;
                break;
            case "summer":
                if (true)
                {
                    if (numberOfPeople <= 5)
                    {
                        pricePerPerson = 48.50;
                    }
                    else
                    {
                        pricePerPerson = 45;
                    }
                }
                totalPrice = (numberOfPeople * pricePerPerson) * 0.85;
                break;
            case "autumn":
                if (numberOfPeople <= 5)
                {
                    pricePerPerson = 60;
                }
                else
                {
                    pricePerPerson = 49.50;
                }
                totalPrice = numberOfPeople * pricePerPerson;
                break;
            case "winter":
                if (true)
                {
                    if (numberOfPeople <= 5)
                    {
                        pricePerPerson = 86;
                    }
                    else
                    {
                        pricePerPerson = 85;
                    }
                }
                totalPrice = (numberOfPeople * pricePerPerson) * 1.08;
                break;
        }
        Console.WriteLine($"{totalPrice:f2} leva.");
    }
}