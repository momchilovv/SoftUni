using System;

class Program
{
    static void Main(string[] args)
    {
        /*	"room for one person" – 18.00 лв за нощувка
        	"apartment" – 25.00 лв за нощувка 
        	"president apartment" – 35.00 лв за нощувка
        */

        int days = int.Parse(Console.ReadLine());
        string roomType = Console.ReadLine();
        string feedback = Console.ReadLine();
        int nights = days - 1;

        double totalPrice = 0;

        switch (roomType)
        {
            case "room for one person":
                totalPrice += nights * 18;
                if (feedback == "positive")
                    Console.WriteLine($"{totalPrice += totalPrice * 0.25:f2}");
                else
                    Console.WriteLine($"{totalPrice -= totalPrice * 0.10}");                
                break;
            case "apartment":
                totalPrice += nights * 25;
                if (nights < 10)
                    totalPrice -= totalPrice * 0.30;

                else if (nights >= 10 && nights <= 15)
                    totalPrice -= totalPrice * 0.35;

                else if (nights > 15)
                    totalPrice -= totalPrice * 0.50;

                if (feedback == "positive")
                    Console.WriteLine($"{totalPrice += totalPrice * 0.25:f2}");
                else
                    Console.WriteLine($"{totalPrice -= totalPrice * 0.10:f2}");
                break;
            case "president apartment":
                totalPrice += nights * 35;
                if (nights < 10)
                    totalPrice -= totalPrice * 0.10;

                else if (nights >= 10 && nights <= 15)
                    totalPrice -= totalPrice * 0.15;

                else if (nights > 15)
                    totalPrice -= totalPrice * 0.20;

                if (feedback == "positive")
                    Console.WriteLine($"{totalPrice += totalPrice * 0.25:f2}");
                else
                    Console.WriteLine($"{totalPrice -= totalPrice * 0.10:f2}");
                break;
        }
    }
}