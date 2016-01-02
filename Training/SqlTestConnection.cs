using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using MySql.Data.MySqlClient;
using Training;
namespace Training
{
    public class SqlTestConnection
    {
        private DataSet data = new DataSet("city");
        
        public SqlTestConnection(string user, string password,string dbHost, string dbName)
        {
            using (var connection = new MySqlConnection("server=localhost;userid=root;password=root;database=world"))
            {
                // connection.ConnectionString = "user id=" + user + ";" +
                // "password=" + password +
                //// "Trusted_Connection=no;" +
                // "database=" + dbName;

                //connection.ConnectionString = "Data Source=" + dbHost + ";Initial Catalog=" + dbName + ";User ID=" + user + ";Password=" +
                //                              password + ";";
                //connection.ConnectionString = "server=localhost;userid=root;" +
                //"password=root;database=world";
                connection.Open();
                //MySqlCommand cmd = connection.CreateCommand();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM city;",connection);
                //cmd.CommandType = CommandType.Text;   //This will specify that we are passing query from application
                //string query = "SELECT * FROM city;";
                //cmd.CommandText = query;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM city;",connection);
                //DataSet data = new DataSet("city");
                
                dataAdapter.Fill(data,"lol");
                //DataTable dt = data.Tables["city"];
                //var read = cmd.ExecuteReader();
                
                //while (read.Read())
                //{
                //    var tmp = read.GetString(1);
                //}
            }
        }

        public DataSet GetData()
        {
            return data;
        }


    }
}