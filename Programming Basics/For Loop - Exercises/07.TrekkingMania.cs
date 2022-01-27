using System;

class Program
{
    static void Main(string[] args)
    {
        int groups = int.Parse(Console.ReadLine());

        double musala = 0;
        double monblan = 0;
        double kilimanjaro = 0;
        double k2 = 0;
        double everest = 0;

        for (int i = 0; i < groups; i++)
        {
            int people = int.Parse(Console.ReadLine());

            if (people <= 5)
            {
                musala += people;
            }
            else if (people >= 6 && people <= 12)
            {
                monblan += people;
            }
            if (people >= 13 && people <= 25)
            {
                kilimanjaro += people;
            }
            else if (people >= 26 && people <= 40)
            {
                k2 += people;
            }
            else if (people >= 41)
            {
                everest += people;
            }
        }
        double total = musala + monblan + kilimanjaro + k2 + everest;

        Console.WriteLine($"{musala / total * 100:f2}%");
        Console.WriteLine($"{monblan / total * 100:f2}%");
        Console.WriteLine($"{kilimanjaro / total * 100:f2}%");
        Console.WriteLine($"{k2 / total * 100:f2}%");
        Console.WriteLine($"{everest / total * 100:f2}%");
    }
}