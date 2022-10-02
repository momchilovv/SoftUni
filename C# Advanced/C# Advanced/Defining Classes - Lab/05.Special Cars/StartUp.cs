using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main()
        {
            string[] tireInfo = Console.ReadLine().Split();
            
            var tiresList = new List<Tire[]>();
            var enginesList = new List<Engine>();
            var carsList = new List<Car>();

            while (tireInfo[0] != "No")
            {
                Tire[] tires = new Tire[]
                {
                    new Tire(int.Parse(tireInfo[0]), double.Parse(tireInfo[1])),
                    new Tire(int.Parse(tireInfo[2]), double.Parse(tireInfo[3])),
                    new Tire(int.Parse(tireInfo[4]), double.Parse(tireInfo[5])),
                    new Tire(int.Parse(tireInfo[6]), double.Parse(tireInfo[7]))
                };

                tiresList.Add(tires);

                tireInfo = Console.ReadLine().Split().ToArray();
            }

            string[] engineInfo = Console.ReadLine().Split();

            while (engineInfo[0] != "Engines")
            {
                Engine engine = new Engine(int.Parse(engineInfo[0]), double.Parse(engineInfo[1]));

                enginesList.Add(engine);

                engineInfo = Console.ReadLine().Split();
            }

            string[] carInfo = Console.ReadLine().Split();

            while (carInfo[0] != "Show")
            {
                int engineIndex = int.Parse(carInfo[5]);
                int tireIndex = int.Parse(carInfo[6]);

                Car car = new Car(carInfo[0], carInfo[1], int.Parse(carInfo[2]), 
                    double.Parse(carInfo[3]), double.Parse(carInfo[4]),
                    enginesList[engineIndex], tiresList[tireIndex]);

                carsList.Add(car);

                carInfo = Console.ReadLine().Split();
            }

            Func<Car, bool> func = (car) => car.Year >= 2017 && car.Engine.HorsePower > 330 && 
            car.Tires.Sum(t => t.Pressure) >= 9 && car.Tires.Sum(t => t.Pressure) <= 10;

            foreach (var car in carsList.Where(func))
            {
                car.Drive(20);

                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}