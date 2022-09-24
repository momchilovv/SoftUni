using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        var parkingLot = new HashSet<string>();

        string[] command = Console.ReadLine().Split(", ");

        while (command[0] != "END")
        {
            string direction = command[0];
            string car = command[1];

            if (direction == "IN")
            {
                parkingLot.Add(car);
            }
            else
            {
                parkingLot.Remove(car);
            }

            command = Console.ReadLine().Split(", ");
        }

        foreach (var car in parkingLot)
        {
            Console.WriteLine(car);
        }
        if (parkingLot.Count == 0)
        {
            Console.WriteLine("Parking Lot is Empty");
        }
    }
}