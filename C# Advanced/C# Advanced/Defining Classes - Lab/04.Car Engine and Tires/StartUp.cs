using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main()
        {
            Tire[] tires = new Tire[4]
            {
                new Tire(1, 2.0),
                new Tire(1, 2.2),
                new Tire(2, 2.4),
                new Tire(2, 2.3)
            };

            Engine engine = new Engine(507, 5000);

            Car car = new Car("BMW", "M5", 2005, 70, 20, engine, tires);

            Console.WriteLine($"BMW M5 With {car.Engine.HorsePower}hp, {car.Engine.CubicCapacity}cc.");
            Console.WriteLine($"Production year: {car.Year}");
            Console.WriteLine($"Tank capacity: {car.FuelQuantity} with fuel consumption of {car.FuelConsumption}l/100km");
            Console.WriteLine($"Front left tyre: {car.Tires[0].Pressure:F2}psa, Front right tyre: {car.Tires[1].Pressure:F2}psa");
            Console.WriteLine($"Rear left tyre: {car.Tires[2].Pressure:F2}psa, Rear right tyre: {car.Tires[3].Pressure:F2}psa");
        }
    }
}