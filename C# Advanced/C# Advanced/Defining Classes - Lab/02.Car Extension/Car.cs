using System;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            double fuel = FuelQuantity - (distance * FuelConsumption);

            if (fuel < 0)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
                return;
            }
            else
            {
                FuelQuantity = fuel;
                Console.WriteLine($"You have {FuelQuantity:f2} left in the tank.");
            }
        }

        public void WhoAmI()
        {
            Console.WriteLine($"Make: {this.Make} " +
                $"\r\nModel: {this.Model} " +
                $"\r\nYear: {this.Year}" +
                $"\r\nFuel: {this.FuelQuantity:f2}");
        }
    }
}