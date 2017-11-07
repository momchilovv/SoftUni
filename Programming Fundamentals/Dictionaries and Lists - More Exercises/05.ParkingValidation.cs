using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ParkingValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var parking = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];
                string name = input[1];

                if (command == "register")
                {
                    string license = input[2];
                    if (parking.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[name]}");
                    }
                    else if (!IsValid(license))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {license}");
                    }
                    else if (parking.ContainsValue(license))
                    {
                        Console.WriteLine($"ERROR: license plate {license} is busy");
                    }
                    else
                    {
                        Console.WriteLine($"{name} registered {license} successfully");
                        parking.Add(name, license);
                    }
                }
                if (command == "unregister")
                {
                    if (!parking.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else if (parking.ContainsKey(name))
                    {
                        parking.Remove(name);
                        Console.WriteLine($"user {name} unregistered successfully");                    
                    }
                }
            }
            foreach (var reg in parking)
            {
                Console.WriteLine($"{reg.Key} => {reg.Value}");
            }
        }
        static bool IsValid(string license)
        {
            if (license.Length == 8 && license.Take(2).All(char.IsUpper)
                && license.Skip(2).Take(4).All(char.IsDigit)
                && license.Skip(6).Take(2).All(char.IsUpper))
            {
                return true;
            }
            else return false;
        }
    }
}