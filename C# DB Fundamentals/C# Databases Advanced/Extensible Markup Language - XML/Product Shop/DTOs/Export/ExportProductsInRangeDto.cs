﻿using ProductShop.Models;
using System.Xml.Serialization;

namespace ProductShop.DTOs.Export
{
    [XmlType("Product")]
    public class ExportProductsInRangeDto
    {
        [XmlElement("name")]
        public string ProductName { get; set; } = null!;

        [XmlElement("price")]
        public decimal Price { get; set; }

        [XmlElement("buyer")]
        public string? BuyerFullName { get; set; }
    }
}