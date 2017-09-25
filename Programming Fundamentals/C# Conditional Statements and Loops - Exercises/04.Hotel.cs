using System;
/// <summary>
/// 77% DONE! IN PROGRESS...
/// </summary>
namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;

            if (month == "May")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;
                if (nightsCount > 7)
                {
                    Console.WriteLine($"Studio: {(studioPrice * 0.95) * nightsCount:f2} lv.");
                    Console.WriteLine($"Double: {doublePrice * nightsCount:f2} lv.");
                    Console.WriteLine($"Suite: {suitePrice * nightsCount:f2} lv.");
                }
                else if (nightsCount < 7)
                {
                    Console.WriteLine($"Studio: {studioPrice * nightsCount:f2} lv.");
                    Console.WriteLine($"Double: {doublePrice * nightsCount:f2} lv.");
                    Console.WriteLine($"Suite: {suitePrice * nightsCount:f2} lv.");
                }
            }
            else if (month == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;
                if (nightsCount > 7)
                {
                    Console.WriteLine($"Studio: {((studioPrice * 0.95) * (nightsCount - 1)):f2} lv.");
                    Console.WriteLine($"Double: {doublePrice * nightsCount:f2} lv.");
                    Console.WriteLine($"Suite: {suitePrice * nightsCount:f2} lv.");
                }
                else if (nightsCount < 7)
                {
                    Console.WriteLine($"Studio: {(studioPrice * (nightsCount - 1)):f2} lv.");
                    Console.WriteLine($"Double: {doublePrice * nightsCount:f2} lv.");
                    Console.WriteLine($"Suite: {suitePrice * nightsCount:f2} lv.");
                }
            }
            else if (month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;
                if (nightsCount > 14)
                {
                    Console.WriteLine($"Studio: {(studioPrice * (nightsCount - 1)):f2} lv.");
                    Console.WriteLine($"Double: {(doublePrice * 0.90) * nightsCount:f2} lv.");
                    Console.WriteLine($"Suite: {suitePrice * nightsCount:f2} lv.");
                }
                else if (nightsCount < 14)
                {
                    Console.WriteLine($"Studio: {(studioPrice * (nightsCount - 1)):f2} lv.");
                    Console.WriteLine($"Double: {doublePrice * nightsCount:f2} lv.");
                    Console.WriteLine($"Suite: {suitePrice * nightsCount:f2} lv.");
                }
            }
            else if (month == "June")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;
                if (nightsCount > 14)
                {
                    Console.WriteLine($"Studio: {studioPrice * nightsCount:f2} lv.");
                    Console.WriteLine($"Double: {(doublePrice * 0.90) * nightsCount:f2} lv.");
                    Console.WriteLine($"Suite: {suitePrice * nightsCount:f2} lv.");
                }
                else if (nightsCount < 14)
                {
                    Console.WriteLine($"Studio: {studioPrice * nightsCount:f2} lv.");
                    Console.WriteLine($"Double: {doublePrice * nightsCount:f2} lv.");
                    Console.WriteLine($"Suite: {suitePrice * nightsCount:f2} lv.");
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;
                if (nightsCount > 14)
                {
                    Console.WriteLine($"Studio: {studioPrice * nightsCount:f2} lv.");
                    Console.WriteLine($"Double: {doublePrice * nightsCount:f2} lv.");
                    Console.WriteLine($"Suite: {(suitePrice * 0.85) * nightsCount:f2} lv.");
                }
                else if (nightsCount < 14)
                {
                    Console.WriteLine($"Studio: {studioPrice * nightsCount:f2} lv.");
                    Console.WriteLine($"Double: {doublePrice * nightsCount:f2} lv.");
                    Console.WriteLine($"Suite: {suitePrice * nightsCount:f2} lv.");
                }
            } 
        }
    }
}