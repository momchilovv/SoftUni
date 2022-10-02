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
            car.FuelQuantity = 100;
            car.FuelConsumption = 7;


            while (true)
            {
                car.Drive(double.Parse(Console.ReadLine()));
                car.WhoAmI();
            }
        }
    }
}