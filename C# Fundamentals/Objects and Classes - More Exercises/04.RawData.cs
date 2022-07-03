using System;
using System.Collections.Generic;
using System.Linq;

class Car
{
    public string Model { get; set; }

    public Engine Engine { get; set; }

    public Cargo Cargo { get; set; }
}

class Engine
{
    public int EngineSpeed { get; set; }

    public int EnginePower { get; set; }
}

class Cargo
{
    public string CargoType { get; set; }

    public int CargoWeight { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();

        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            string[] command = Console.ReadLine().Split();

            string model = command[0], cargoType = command[4];
            int engineSpeed = int.Parse(command[1]), enginePower = int.Parse(command[2]), cargoWeight = int.Parse(command[3]);

            Engine engine = new Engine()
            {
                EngineSpeed = engineSpeed,
                EnginePower = enginePower
            };

            Cargo cargo = new Cargo()
            {
                CargoType = cargoType,
                CargoWeight = cargoWeight
            };

            Car car = new Car()
            {
                Model = model,
                Engine = engine,
                Cargo = cargo
            };

            cars.Add(car);
        }

        string typeOfCargo = Console.ReadLine();

        if (typeOfCargo == "fragile")
        {
            foreach (var car in cars.Where(c => c.Cargo.CargoType == "fragile").Where(c => c.Cargo.CargoWeight < 1000))
            {
                Console.WriteLine(car.Model);
            }
        }
        else if (typeOfCargo == "flamable")
        {
            foreach (var car in cars.Where(c => c.Cargo.CargoType == "flamable").Where(c => c.Engine.EnginePower > 250))
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}