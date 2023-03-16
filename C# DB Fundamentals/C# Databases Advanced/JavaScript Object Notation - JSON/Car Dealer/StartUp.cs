using CarDealer.Data;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using Newtonsoft.Json;
using System.Globalization;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main()
        {
            var context = new CarDealerContext();
        }

        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var sales = context.Sales
                .Select(s => new
                {
                    car = new
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TraveledDistance = s.Car.TravelledDistance
                    },
                    customerName = s.Customer.Name,
                    discount = s.Discount.ToString("f2"),
                    price = Math.Round(s.Car.Sales
                            .Join(context.Cars, sale => sale.CarId, car => car.Id, (sale, car) => new { sale, car })
                            .Join(context.PartsCars, temp => temp.car.Id, partCar => partCar.CarId, (temp, partCar) => new { temp.sale, temp.car, partCar })
                            .Join(context.Parts, temp => temp.partCar.PartId, part => part.Id, (temp, part) => part.Price)
                            .Sum(), 2).ToString("f2"),
                    priceWithDiscount = Math.Round(s.Car.Sales
                            .Join(context.Cars, sale => sale.CarId, car => car.Id, (sale, car) => new { sale, car })
                            .Join(context.PartsCars, temp => temp.car.Id, partCar => partCar.CarId, (temp, partCar) => new { temp.sale, temp.car, partCar })
                            .Join(context.Parts, temp => temp.partCar.PartId, part => part.Id, (temp, part) => part.Price)
                            .Sum() * (1 - (s.Discount / 100)), 2).ToString("f2")
                })
                .Take(10)
                .ToList();

            return JsonConvert.SerializeObject(sales, Formatting.Indented);
        }

        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var customers = context.Customers
                .Where(c => c.Sales.Count() >= 1)
                .Select(c => new
                {
                    fullName = c.Name,
                    boughtCars = c.Sales.Count,
                    spentMoney = c.Sales
                        .Join(context.Cars, sale => sale.CarId, car => car.Id, (sale, car) => new { sale, car })
                        .Join(context.PartsCars, temp => temp.car.Id, partCar => partCar.CarId, (temp, partCar) => new { temp.sale, temp.car, partCar })
                        .Join(context.Parts, temp => temp.partCar.PartId, part => part.Id, (temp, part) => part.Price)
                        .Sum()
                })
                .OrderByDescending(s => s.spentMoney)
                .ThenByDescending(c => c.boughtCars)
                .ToList();

            return JsonConvert.SerializeObject(customers, Formatting.Indented);
        }

        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var cars = context.Cars
                .Select(c => new
                {
                    car = new
                    {
                        Make = c.Make,
                        Model = c.Model,
                        TraveledDistance = c.TravelledDistance,
                    },
                    parts = c.PartsCars
                    .Select(p => new
                    {
                        Name = p.Part.Name,
                        Price = p.Part.Price.ToString("f2")
                    }).ToArray()
                })
                .ToArray();

            return JsonConvert.SerializeObject(cars, Formatting.Indented);
        }

        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var suppliers = context.Suppliers
                .Where(s => s.IsImporter == false)
                .Select(s => new
                {
                    Id = s.Id,
                    Name = s.Name,
                    PartsCount = s.Parts.Count
                })
                .ToArray();

            return JsonConvert.SerializeObject(suppliers, Formatting.Indented);
        }

        public static string GetCarsFromMakeToyota(CarDealerContext context)
        {
            var cars = context.Cars
                .Where(m => m.Make == "Toyota")
                .OrderBy(m => m.Model)
                .ThenByDescending(t => t.TravelledDistance)
                .Select(c => new
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TravelledDistance
                })
                .ToArray();

            return JsonConvert.SerializeObject(cars, Formatting.Indented);
        }

        public static string GetOrderedCustomers(CarDealerContext context)
        {
            var customers = context.Customers
                .OrderBy(c => c.BirthDate)
                .ThenBy(c => c.IsYoungDriver)
                .Select(c => new
                {
                    Name = c.Name,
                    BirthDate = c.BirthDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                    IsYoungDriver = c.IsYoungDriver
                })
                .ToArray();

            return JsonConvert.SerializeObject(customers, Formatting.Indented);
        }

        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            var sales = JsonConvert.DeserializeObject<List<Sale>>(inputJson);

            context.Sales.AddRange(sales!);
            context.SaveChanges();

            return $"Successfully imported {sales!.Count}.";
        }

        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            var customers = JsonConvert.DeserializeObject<List<Customer>>(inputJson);

            context.Customers.AddRange(customers!);
            context.SaveChanges();

            return $"Successfully imported {customers!.Count}.";
        }

        public static string ImportCars(CarDealerContext context, string inputJson)
        {
            var carInfo = JsonConvert.DeserializeObject<ImportCarsDto[]>(inputJson);

            foreach (var cars in carInfo!)
            {
                var car = new Car
                {
                    Make = cars.Make,
                    Model = cars.Model,
                    TravelledDistance = cars.TravelledDistance,
                };

                foreach (var parts in cars.PartsId.Distinct())
                {
                    var part = new PartCar
                    {
                        PartId = parts,
                        Car = car
                    };

                    context.PartsCars.Add(part);
                }

                context.Cars.Add(car);
            }

            context.SaveChanges();

            return $"Successfully imported {carInfo!.Count()}.";
        }

        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            var json = JsonConvert.DeserializeObject<List<Part>>(inputJson);

            var suppliers = context.Suppliers.ToList();

            var parts = new List<Part>();

            foreach (var part in json!)
            {
                if (suppliers.Any(p => p.Id == part.SupplierId))
                {
                    parts.Add(part);
                }
            }

            context.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts!.Count}.";
        }

        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            var suppliers = JsonConvert.DeserializeObject<List<Supplier>>(inputJson);

            context.Suppliers.AddRange(suppliers!);
            context.SaveChanges();

            return $"Successfully imported {suppliers!.Count}.";
        }
    }
}