using System;

class Program
{
    static void Main(string[] args)
    {
        string month = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());

        double studioPrice;
        double apartmentPrice;

        switch (month)
        {
            case "May":
            case "October":
                studioPrice = 50;
                apartmentPrice = 65;

                if (nights > 7 && nights < 14)
                    studioPrice -= studioPrice * 0.05;

                else if (nights > 14)
                {
                    studioPrice -= studioPrice * 0.30;
                    apartmentPrice -= apartmentPrice * 0.10;
                }

                Console.WriteLine($"Apartment: {apartmentPrice * nights:f2} lv.");
                Console.WriteLine($"Studio: {studioPrice * nights:f2} lv.");
                break;
            case "June":
            case "September":
                studioPrice = 75.20;
                apartmentPrice = 68.70;

                if (nights > 14)
                {
                    studioPrice -= studioPrice * 0.20;
                    apartmentPrice -= apartmentPrice * 0.10;
                }

                Console.WriteLine($"Apartment: {apartmentPrice * nights:f2} lv.");
                Console.WriteLine($"Studio: {studioPrice * nights:f2} lv.");
                break;
            case "July":
            case "August":
                studioPrice = 76;
                apartmentPrice = 77;

                if (nights > 14)
                    apartmentPrice -= apartmentPrice * 0.10;

                Console.WriteLine($"Apartment: {apartmentPrice * nights:f2} lv.");
                Console.WriteLine($"Studio: {studioPrice * nights:f2} lv.");
                break;
        }
    }
}