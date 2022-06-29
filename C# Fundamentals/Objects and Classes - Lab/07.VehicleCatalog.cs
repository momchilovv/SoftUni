using System;
using System.Collections.Generic;
using System.Linq;

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
}
class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
}
class VehicleCatalog
{
    public List<Car> Cars = new List<Car>();
    public List<Truck> Trucks = new List<Truck>();
}
class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split("/");

        VehicleCatalog vehicleCatalog = new VehicleCatalog();

        while (input[0] != "end")
        {
            string type = input[0];
            string brand = input[1];
            string model = input[2];
            int number = int.Parse(input[3]);

            if (type == "Car")
            {
                Car car = new Car()
                {
                    Brand = brand,
                    Model = model,
                    HorsePower = number
                };
                vehicleCatalog.Cars.Add(car);
            }
            else if (type == "Truck")
            {
                Truck truck = new Truck()
                {
                    Brand = brand,
                    Model = model,
                    Weight = number
                };
                vehicleCatalog.Trucks.Add(truck);
            }
            input = Console.ReadLine().Split("/");
        }
        if (vehicleCatalog.Cars.Count > 0)
        {
            Console.WriteLine("Cars:");
            foreach (var car in vehicleCatalog.Cars.OrderBy(c => c.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
        }
        if (vehicleCatalog.Trucks.Count > 0)
        {
            Console.WriteLine("Trucks:");
            foreach (var truck in vehicleCatalog.Trucks.OrderBy(t => t.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");

            }
        }   
    }
}