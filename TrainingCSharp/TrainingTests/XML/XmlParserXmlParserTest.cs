using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training.XML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.XML.Entities;

namespace Training.XML.Tests
{
    [TestClass()]
    public class XmlParserXmlParserTest
    {
        [TestMethod()]
        public void DeserializeXmlTest()
        {
            var parser = new XmlParser();
            var result = parser.Deserialize<Garage>(
                @"C:\Users\michal\Documents\training\Anathema\Anathema\Anathema\Rhonin\TrainingThree\XML\XMLFiles\garage.xml");

            Assert.Fail();
        }
    }
}