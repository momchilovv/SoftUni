using System;
using System.Collections.Generic;
using System.Linq;

class Car
{
    public Car()
    {
        TraveledDistance = 0;
    }

    public string Model { get; set; }

    public double Fuel { get; set; }

    public double FuelConsumption { get; set; }

    public double TraveledDistance { get; set; }

}

class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();

        int numberOfCars = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCars; i++)
        {
            string[] input = Console.ReadLine().Split();

            string model = input[0];
            double fuel = double.Parse(input[1]), fuelConsumption = double.Parse(input[2]);

            Car car = new Car()
            {
                Model = model,
                Fuel = fuel,
                FuelConsumption = fuelConsumption
            };

            cars.Add(car);
        }

        string[] command = Console.ReadLine().Split();

        while (command[0] != "End")
        {
            string model = command[1];
            double travel = double.Parse(command[2]);

            foreach (var car in cars.Where(c => c.Model == model))
            {
                double fuelNeeded = travel * car.FuelConsumption;

                if (car.Fuel >= fuelNeeded)
                {
                    car.Fuel -= fuelNeeded;
                    car.TraveledDistance += travel;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }
            command = Console.ReadLine().Split();
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} {car.Fuel:f2} {car.TraveledDistance}");
        }
    }
}