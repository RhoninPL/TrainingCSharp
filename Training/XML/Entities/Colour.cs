using System.Xml.Schema;
using System.Xml.Serialization;

namespace Training.XML.Entities
{
    [XmlRoot("colour")]
    public class Colour
    {
        [XmlAttribute("name")]
        public string Type { get; set; }

        //[XmlElement("colour")]
        [XmlText()]
        public string Kolor { get; set; }
    }
}