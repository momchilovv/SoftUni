using System;

class Program
{
    static void Main(string[] args)
    {
        int kegs = int.Parse(Console.ReadLine());
        double biggestVolume = 0;
        string biggestKeg = null;

        for (int i = 0; i < kegs; i++)
        {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double volume = (Math.PI * Math.Pow(radius, 2)) * height;

            if (volume >= biggestVolume)
            {
                biggestVolume = volume;
                biggestKeg = model;
            }
        }
        Console.WriteLine(biggestKeg);
    }
}