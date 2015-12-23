using System.Data.SqlClient;

namespace Training
{
    public class SqlTestConnection
    {
        public SqlTestConnection(string user, string password,string dbType, string dbName)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "user id=" + user + ";" +
            "password=" + password +
           // "Trusted_Connection=no;" +
            "database=" + dbName;
            connection.Open();
        }
    }
}