using System;

class Program
{
    static void Main(string[] args)
    {
        int age = int.Parse(Console.ReadLine());

        switch (age)
        {
            case int ages when(age >= 0 && age <= 2):
                Console.WriteLine("baby");
                break;
            case int ages when (age >= 3 && age <= 13):
                Console.WriteLine("child");
                break;
            case int ages when (age >= 14 && age <= 19):
                Console.WriteLine("teenager");
                break;
            case int ages when (age >= 20 && age <= 65):
                Console.WriteLine("adult");
                break;
            case int ages when (age >= 66):
                Console.WriteLine("elder");
                break;
        }
    }
}