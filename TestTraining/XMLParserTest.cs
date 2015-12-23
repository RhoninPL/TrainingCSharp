using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Training.XML;
using Training.XML.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTraining
{
    [TestClass]
    public class XmlParserTest
    {
        [TestMethod]
        public void TestXmlParser()
        {
            var parser = new XmlParser();
            var result = parser.Deserialize<Garage>(
                @"C:\Users\michal\Documents\training\Anathema\Anathema\Anathema\Rhonin\TrainingThree\XML\XMLFiles\garage.xml");

        }
    }
}
