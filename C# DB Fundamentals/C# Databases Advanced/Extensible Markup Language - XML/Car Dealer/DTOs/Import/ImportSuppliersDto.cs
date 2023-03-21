using System.Xml.Serialization;

namespace CarDealer.DTOs.Import
{
    [XmlType("Supplier")]
    public class ImportSuppliersDto
    {
        [XmlElement("name")]
        public string Name { get; set; } = null!;

        [XmlElement("isImported")]
        public bool IsImporter { get; set; }
    }
}