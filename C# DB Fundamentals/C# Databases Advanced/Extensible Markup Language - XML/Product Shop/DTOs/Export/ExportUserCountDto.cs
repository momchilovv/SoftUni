using System.Xml.Serialization;

namespace ProductShop.DTOs.Export
{
    public class ExportUserCountDto
    {
        [XmlElement("count")]
        public int Count { get; set; }

        [XmlArray("users")]
        public ExportUsersAndProductsDto[] Users { get; set; } = null!;
    }
}