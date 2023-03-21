using CarDealer.Data;
using CarDealer.DTOs.Export;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main()
        {
            var context = new CarDealerContext();

            Console.WriteLine(GetSalesWithAppliedDiscount(context));

            File.WriteAllText("../../../Results/sales-discount.xml", GetSalesWithAppliedDiscount(context));
        }

        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var serializer = new XmlSerializer(typeof(ExportSalesWithDiscountDto[]), new XmlRootAttribute("sales"));

            var sb = new StringBuilder();
            using var writer = new StringWriter(sb);

            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            var sales = context.Sales
                    .Select(s => new ExportSalesWithDiscountDto
                    {
                        CarDto = new CarDto
                        {
                            Make = s.Car.Make,
                            Model = s.Car.Model,
                            TraveledDistance = s.Car.TraveledDistance
                        },
                        Discount = s.Discount,
                        CustomerName = s.Customer.Name,
                        Price = s.Car.PartsCars.Sum(c => c.Part.Price),
                        PriceWithDiscount = s.Car.PartsCars.Sum(c => c.Part.Price) * (1 - (s.Discount / 100))
                    })
                    .ToArray();

            serializer.Serialize(writer, sales, namespaces);

            return sb.ToString().Trim();
        }

        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var serializer = new XmlSerializer(typeof(ExportTotalSalesDto[]), new XmlRootAttribute("customers"));

            var sb = new StringBuilder();
            using var writer = new StringWriter(sb);

            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            var sales = context.Sales
                .Where(s => s.Customer.Sales.Any())
                .Select(s => new ExportTotalSalesDto
                {
                    FullName = s.Customer.Name,
                    BoughtCars = s.Customer.Sales.Count(),
                    SpentMoney = s.Customer.IsYoungDriver ? s.Car.PartsCars.Sum(p => Math.Round(p.Part.Price * 0.95m, 2))
                                                          : s.Car.PartsCars.Sum(p => p.Part.Price)
                })
                .OrderByDescending(s => s.SpentMoney)
                .ToArray();

            serializer.Serialize(writer, sales, namespaces);

            return sb.ToString().Trim();
        }

        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var serializer = new XmlSerializer(typeof(ExportCarsWithPartsDto[]), new XmlRootAttribute("cars"));

            var sb = new StringBuilder();
            using var writer = new StringWriter(sb);

            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            var cars = context.Cars
                .Select(c => new ExportCarsWithPartsDto
                {
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance,
                    Parts = c.PartsCars.
                    Select(p => new DTOs.Export.PartsDto
                    {
                        Name = p.Part.Name,
                        Price = p.Part.Price
                    })
                    .OrderByDescending(pp => pp.Price)
                    .ToArray()
                })
                .OrderByDescending(c => c.TraveledDistance)
                .ThenBy(c => c.Model)
                .Take(5)
                .ToArray();

            serializer.Serialize(writer, cars, namespaces);

            return sb.ToString().Trim();
        }

        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var serializer = new XmlSerializer(typeof(ExportLocalSuppliersDto[]), new XmlRootAttribute("suppliers"));

            var sb = new StringBuilder();
            using var writer = new StringWriter(sb);

            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            var suppliers = context.Suppliers
                .Where(s => s.IsImporter == false)
                .Select(s => new ExportLocalSuppliersDto
                {
                    Id = s.Id,
                    Name = s.Name,
                    PartsCount = s.Parts.Select(p => p.Quantity).Count()
                })
                .ToArray();

            serializer.Serialize(writer, suppliers, namespaces);

            return sb.ToString().Trim();
        }

        public static string GetCarsFromMakeBmw(CarDealerContext context)
        {
            var serializer = new XmlSerializer(typeof(ExportBMWCarsDto[]), new XmlRootAttribute("cars"));

            var sb = new StringBuilder();
            using var writer = new StringWriter(sb);

            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            var cars = context.Cars
                .Where(c => c.Make == "BMW")
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TraveledDistance)
                .Select(c => new ExportBMWCarsDto
                {
                    Id = c.Id,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance
                })
                .ToArray();

            serializer.Serialize(writer, cars, namespaces);

            return sb.ToString().Trim();
        }

        public static string GetCarsWithDistance(CarDealerContext context)
        {
            var serializer = new XmlSerializer(typeof(ExportCarsWithDistanceDto[]), new XmlRootAttribute("cars"));

            var sb = new StringBuilder();
            using var writer = new StringWriter(sb);

            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            var cars = context.Cars
                .Where(c => c.TraveledDistance > 2000000)
                .OrderBy(c => c.Make)
                .ThenBy(c => c.Model)
                .Select(c => new ExportCarsWithDistanceDto
                {
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance,
                })
                .Take(10)
                .ToArray();

            serializer.Serialize(writer, cars, namespaces);

            return sb.ToString().Trim();
        }

        public static string ImportSales(CarDealerContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(ImportSalesDto[]), new XmlRootAttribute("Sales"));

            using var reader = new StringReader(inputXml);

            var dto = (ImportSalesDto[])serializer.Deserialize(reader)!;

            var sales = dto
                .Where(s => context.Cars.Select(c => c.Id).Contains(s.CarId))
                .Select(s => new Sale
                {
                    CarId = s.CarId,
                    CustomerId = s.CustomerId,
                    Discount = s.Discount
                })
                .ToArray();

            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Count()}";
        }

        public static string ImportCustomers(CarDealerContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(ImportCustomersDto[]), new XmlRootAttribute("Customers"));

            using var reader = new StringReader(inputXml);

            var doc = (ImportCustomersDto[])serializer.Deserialize(reader)!;

            var customers = doc
                .Select(c => new Customer
                {
                    Name = c.Name,
                    BirthDate = c.BirthDate,
                    IsYoungDriver = c.IsYoungDriver
                })
                .ToArray();

            context.Customers.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Count()}";
        }

        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(ImportCarsDto[]), new XmlRootAttribute("Cars"));

            using var reader = new StringReader(inputXml);

            var doc = (ImportCarsDto[])serializer.Deserialize(reader)!;

            var cars = new List<Car>();

            int carId = 1;

            foreach (var carDto in doc)
            {
                var car = new Car()
                {
                    Make = carDto.Make,
                    Model = carDto.Model,
                    TraveledDistance = carDto.TraveledDistance,
                };
                cars.Add(car);

                foreach (var part in carDto.Parts
                                           .Where(p => context.Parts.Select(pp => pp.Id).Contains(p.PartId))
                                           .Select(p => p.PartId)
                                           .Distinct())
                {
                    var partCar = new PartCar()
                    {
                        CarId = carId,
                        PartId = part
                    };
                    context.PartsCars.Add(partCar);
                }
                carId++;
            }
            context.Cars.AddRange(cars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count()}";
        }

        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(ImportPartsDto[]), new XmlRootAttribute("Parts"));

            using var reader = new StringReader(inputXml);

            var doc = (ImportPartsDto[])serializer.Deserialize(reader)!;

            var parts = doc
                .Where(p => context.Suppliers.Select(s => s.Id).Contains(p.SupplierId))
                .Select(p => new Part()
                {
                    Name = p.Name,
                    Price = p.Price,
                    Quantity = p.Quantity,
                    SupplierId = p.SupplierId
                })
                .ToArray();

            context.Parts.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Count()}";
        }

        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(ImportSuppliersDto[]), new XmlRootAttribute("Suppliers"));

            using var reader = new StringReader(inputXml);

            var doc = (ImportSuppliersDto[])serializer.Deserialize(reader)!;

            var suppliers = doc
                .Select(s => new Supplier()
                {
                    Name = s.Name,
                    IsImporter = s.IsImporter
                })
                .ToArray();

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count()}"; ;
        }
    }
}