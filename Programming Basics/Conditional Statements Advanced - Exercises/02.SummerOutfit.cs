using System;

class Program
{
    static void Main(string[] args)
    {
        double degrees = double.Parse(Console.ReadLine());
        string dayPart = Console.ReadLine();
        string outfit = "";
        string shoes = "";

        switch (dayPart)
        {
            case "Morning":
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else if (degrees >= 25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                break;
            case "Afternoon":
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else if (degrees >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                break;
            case "Evening":
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else if (degrees >= 25)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                break;
        }
    }
}