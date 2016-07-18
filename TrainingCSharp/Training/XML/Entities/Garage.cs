using System.Xml.Serialization;

namespace Training.XML.Entities
{
    [XmlRoot("garage")]
    public class Garage
    {
         [XmlElement("car")]
         public Car[] Cars { get; set; }

       
    }
}