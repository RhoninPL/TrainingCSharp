using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training;

namespace TrainingTests
{
    [TestClass]
    public class SqlTest
    {
        [TestMethod]
        public void TestSqlConnection()
        {
            var sql = new SqlTestConnection(@"DESKTOP-KIE5GDK\michal", "", @"DESKTOP-KIE5GDK\SQLEXPRESS", "CSharpLearn");
        }
         
    }
}