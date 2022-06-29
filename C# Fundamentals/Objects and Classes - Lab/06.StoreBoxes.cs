using System;
using System.Collections.Generic;
using System.Linq;

class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}
class Box
{
    public Box()
    {
        Item = new Item();
    }
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public decimal PriceForBox { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        List<Box> boxes = new List<Box>();

        while (input[0] != "end")
        {
            string serialNumber = input[0];
            Item itemName = new Item()
            {
                Name = input[1],
                Price = decimal.Parse(input[3])
            };

            int itemQuantity = int.Parse(input[2]);
            decimal itemPrice = decimal.Parse(input[3]);

            decimal priceForBox = itemQuantity * itemPrice;

            Box box = new Box()
            {
                SerialNumber = serialNumber,
                Item = itemName,
                ItemQuantity = itemQuantity,
                PriceForBox = priceForBox
            };
            boxes.Add(box);

            input = Console.ReadLine().Split();
        }

        foreach (var box in boxes.OrderByDescending(x => x.PriceForBox))
        {
            Console.WriteLine(box.SerialNumber);
            Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
            Console.WriteLine($"-- ${box.PriceForBox:f2}");
        }
    }
}