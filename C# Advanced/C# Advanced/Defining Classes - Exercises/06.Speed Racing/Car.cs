using System;

namespace DefiningClasses
{
    public class Car
    {
        public Car()
        {  
            
        }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer) : this()
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(string model, double distance)
        {
            double fuelNeeded = FuelAmount - (distance * FuelConsumptionPerKilometer); 
            
            if (fuelNeeded < 0)
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return;
            }
            else
            {
                FuelAmount = fuelNeeded;
                TravelledDistance += distance;
            }
        }
    }
}