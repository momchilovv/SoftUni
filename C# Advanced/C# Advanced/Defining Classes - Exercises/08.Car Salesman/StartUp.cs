using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses

{
    public class StartUp
    {
        public static void Main()
        {
            List<Engine> engines = new List<Engine>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);
                Engine engine = new Engine(model, power);

                if (engineInfo.Length == 3 && char.IsDigit(engineInfo[2][0]))
                {
                    int displacement = int.Parse(engineInfo[2]);
                    engine.Displacement = displacement;
                }
                if (engineInfo.Length == 3 && char.IsLetter(engineInfo[2][0]))
                {
                    string efficiency = engineInfo[2];
                    engine.Efficiency = efficiency;
                }
                if (engineInfo.Length == 4)
                {
                    int displacement = int.Parse(engineInfo[2]);
                    string efficiency = engineInfo[3];
                    engine.Displacement = displacement;
                    engine.Efficiency = efficiency; 
                }

                engines.Add(engine);
            }

            List<Car> cars = new List<Car>();

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                Engine engine = new Engine();

                foreach (var e in engines.Where(e => e.Model == carInfo[1]))
                {
                    engine = new Engine(e.Model, e.Power, e.Displacement, e.Efficiency);
                }

                Car car = new Car(model, engine);

                if (carInfo.Length == 3 && char.IsDigit(carInfo[2][0]))
                {
                    int weight = int.Parse(carInfo[2]);
                    car.Weight = weight;
                }
                if (carInfo.Length == 3 && char.IsLetter(carInfo[2][0]))
                {
                    string color = carInfo[2];
                    car.Color = color;
                }
                else if (carInfo.Length == 4)
                {
                    int weight = int.Parse(carInfo[2]);
                    string color = carInfo[3];
                    car.Weight = weight;
                    car.Color = color;
                }
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.Write(car.ToString());
            }
        }
    }
}