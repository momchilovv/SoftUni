using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            var cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];

                double tire1Pressure = double.Parse(carInfo[5]);
                int tire1Age = int.Parse(carInfo[6]);
                double tire2Pressure = double.Parse(carInfo[7]);
                int tire2Age = int.Parse(carInfo[8]);
                double tire3Pressure = double.Parse(carInfo[9]);
                int tire3Age = int.Parse(carInfo[10]);
                double tire4Pressure = double.Parse(carInfo[11]);
                int tire4Age = int.Parse(carInfo[12]);

                Engine engine = new Engine
                {
                    Power = enginePower,
                    Speed = engineSpeed
                };

                Cargo cargo = new Cargo
                {
                    Weight = cargoWeight,
                    Type = cargoType
                };

                Tire[] tires = new Tire[]
                {
                    new Tire(tire1Age, tire1Pressure),
                    new Tire(tire2Age, tire2Pressure),
                    new Tire(tire3Age, tire3Pressure),
                    new Tire(tire4Age, tire4Pressure)
                };

                Car car = new Car(model, engine, cargo, tires);

                cars.Add(car);
            }

            string input = Console.ReadLine();

            Func<Car, bool> flammable = (car) => car.Engine.Power > 250 && car.Cargo.Type == "flammable";

            Func<Car, bool> fragile = (car) => car.Tires.Any(t => t.Pressure < 1);

            if (input == "flammable")
            {
                foreach (var car in cars.Where(flammable))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                foreach (var car in cars.Where(fragile))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}