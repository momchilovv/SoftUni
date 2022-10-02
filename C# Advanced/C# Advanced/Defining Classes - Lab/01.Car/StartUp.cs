using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main()
        {
            Car car = new Car();

            car.Make = "BMW";
            car.Model = "525i";
            car.Year = 2005;

            Console.WriteLine($"Make: {car.Make} \r\nModel: {car.Model} \r\nProduction Year: {car.Year}");
        }
    }
}