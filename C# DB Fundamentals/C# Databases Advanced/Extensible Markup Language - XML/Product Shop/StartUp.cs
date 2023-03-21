using Castle.Core.Internal;
using ProductShop.Data;
using ProductShop.DTOs.Export;
using ProductShop.DTOs.Import;
using ProductShop.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main()
        {
            var context = new ProductShopContext();

            Console.WriteLine(GetUsersWithProducts(context));

            File.WriteAllText("../../../Results/categories-by-products.xml", GetUsersWithProducts(context));
        }

        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var serializer = new XmlSerializer(typeof(ExportUserCountDto), new XmlRootAttribute("Users"));

            var sb = new StringBuilder();
            using var writer = new StringWriter(sb);

            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            var users = context.Users
                .Where(u => u.ProductsSold.Count() >= 1)
                .OrderByDescending(u => u.ProductsSold.Count())
                .Select(u => new ExportUsersAndProductsDto
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Age = u.Age,
                    SoldProducts = new SoldProductsDto
                    {
                        Count = u.ProductsSold.Count,
                        Products = u.ProductsSold
                        .Select(ps => new ProductDto
                        {
                            Name = ps.Name,
                            Price= ps.Price
                        })
                        .OrderByDescending(ps => ps.Price)
                        .ToArray()
                    }
                })
                .Take(10)
                .ToArray();

            var customExport = new ExportUserCountDto
            {
                Count = context.Users.Count(x => x.ProductsSold.Any()),
                Users = users,
            };

            serializer.Serialize(writer, customExport, namespaces);

            return sb.ToString().Trim();
        }

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var serializer = new XmlSerializer(typeof(ExportCategoriesDto[]), new XmlRootAttribute("Categories"));

            var sb = new StringBuilder();
            using var writer = new StringWriter(sb);

            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            var categories = context.Categories
                .Select(c => new ExportCategoriesDto
                {
                    Name = c.Name,
                    Count = c.CategoryProducts.Count(),
                    AveragePrice = c.CategoryProducts.Average(cp => cp.Product.Price),
                    TotalRevenue = c.CategoryProducts.Sum(cp => cp.Product.Price)
                })
                .OrderByDescending(c => c.Count)
                .ThenBy(c => c.TotalRevenue)
                .ToArray();

            serializer.Serialize(writer, categories, namespaces);

            return sb.ToString().Trim();
        }

        public static string GetSoldProducts(ProductShopContext context)
        {
            var serializer = new XmlSerializer(typeof(ExportSoldProductsDto[]), new XmlRootAttribute("Users"));

            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            var sb = new StringBuilder();
            using var writer = new StringWriter(sb);

            var soldProducts = context.Users
                .Where(u => u.ProductsSold.Count() >= 1)
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Select(u => new ExportSoldProductsDto
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Products = u.ProductsSold
                                .Select(p => new ProductDto
                                {
                                    Name = p.Name,
                                    Price = p.Price
                                }).ToArray()
                })
                .Take(5)
                .ToArray();

            serializer.Serialize(writer, soldProducts, namespaces);

            return sb.ToString().Trim();
        }

        public static string GetProductsInRange(ProductShopContext context)
        {
            var serializer = new XmlSerializer(typeof(ExportProductsInRangeDto[]), new XmlRootAttribute("Products"));

            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            var sb = new StringBuilder();
            using var writer = new StringWriter(sb);

            var products = context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .Select(p => new ExportProductsInRangeDto
                {
                    ProductName = p.Name,
                    Price = p.Price,
                    BuyerFullName = $"{p.Buyer.FirstName} {p.Buyer.LastName}"
                })
                .OrderBy(p => p.Price)
                .Take(10)
                .ToArray();

            serializer.Serialize(writer, products, namespaces);

            return sb.ToString().Trim();
        }

        public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(ImportCategoriesProductsDto[]), new XmlRootAttribute("CategoryProducts"));

            using var reader = new StringReader(inputXml);

            var doc = (ImportCategoriesProductsDto[])serializer.Deserialize(reader)!;

            var categoryProducts = doc
                .Select(cp => new CategoryProduct()
                {
                    CategoryId = cp.CategoryId,
                    ProductId = cp.ProductId
                })
                .ToArray();

            context.CategoryProducts.AddRange(categoryProducts);
            context.SaveChanges();

            return $"Successfully imported {categoryProducts.Count()}";
        }

        public static string ImportCategories(ProductShopContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(ImportCategoriesDto[]), new XmlRootAttribute("Categories"));

            using var reader = new StringReader(inputXml);

            var doc = (ImportCategoriesDto[])serializer.Deserialize(reader)!;

            var categories = doc
                .Select(c => new Category()
                {
                    Name = c.Name
                })
                .ToArray();

            context.Categories.AddRange(categories);
            context.SaveChanges();

            return $"Successfully imported {categories.Count()}";
        }

        public static string ImportProducts(ProductShopContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(ImportProductsDto[]), new XmlRootAttribute("Products"));

            using var reader = new StreamReader(inputXml);

            var doc = (ImportProductsDto[])serializer.Deserialize(reader)!;

            var products = doc
                .Select(p => new Product()
                {
                    Name = p.Name,
                    Price = p.Price,
                    SellerId = p.SellerId,
                    BuyerId = p.BuyerId.HasValue ? p.BuyerId : null
                })
                .ToArray();

            context.Products.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Count()}";
        }

        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(ImportUsersDto[]), new XmlRootAttribute("Users"));

            using var reader = new StreamReader(inputXml);

            var doc = (ImportUsersDto[])serializer.Deserialize(reader)!;

            var users = doc
                .Select(u => new User()
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Age = u.Age
                })
                .ToArray();

            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Count()}";
        }
    }
}