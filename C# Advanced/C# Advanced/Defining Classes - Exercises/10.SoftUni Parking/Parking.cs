using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        public Parking(int capacity)
        {
            Cars = new List<Car>();
            Capacity = capacity;
        }

        public List<Car> Cars { get; set; }
        public int Capacity { get; private set; }
        public int Count
        {
            get { return Cars.Count; }
        }

        private List<Car> cars;
        private int capacity;

        public string AddCar(Car car)
        {
            if (Cars.Contains(Cars.FirstOrDefault(c => c.RegistrationNumber == car.RegistrationNumber)))
            {
                return "Car with that registration number, already exists!";
            }
            if (Cars.Count >= Capacity)
            {
                return "Parking is full!";
            }
            else
            {
                Cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }
        public string RemoveCar(string registrationNumber)
        {
            Car car = Cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
            if (!Cars.Contains(car))
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                Cars.Remove(car);
                return $"Successfully removed {registrationNumber}";
            }
        }

        public Car GetCar(string registrationNumber)
        {
            return Cars.First(c => c.RegistrationNumber == registrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var registrationNumber in registrationNumbers)
            {
                foreach (var car in Cars)
                {
                    if (car.RegistrationNumber == registrationNumber)
                    {
                        Cars.Remove(car);
                        break;
                    }
                }
            }
        }
    }
}