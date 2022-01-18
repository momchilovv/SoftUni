using System;

class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        int videocards = int.Parse(Console.ReadLine());
        int processors = int.Parse(Console.ReadLine());
        int ram = int.Parse(Console.ReadLine());

        double videocardsPrice = videocards * 250;
        double processorsPrice = (videocardsPrice * 0.35) * processors;
        double ramPrice = (videocardsPrice * 0.1) * ram;

        double totalPrice = videocardsPrice + processorsPrice + ramPrice;

        if (videocards > processors)
        {
            totalPrice = totalPrice - (totalPrice * 0.15);
        }

        if (budget >= totalPrice)
        {
            Console.WriteLine($"You have {budget - totalPrice:f2} leva left!");
        }
        else
        {
            Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva more!");
        }
    }
}