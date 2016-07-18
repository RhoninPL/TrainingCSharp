using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Training;
using MySql.Data.MySqlClient;
namespace DataDisplay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            DataTable data = new DataTable();
            using (var connection = new MySqlConnection("server=localhost;userid=root;password=root;database=world"))
            {
 
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM city;", connection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(data);
                dataGrid.DataContext = data;
                
            }
        }
    }
}
