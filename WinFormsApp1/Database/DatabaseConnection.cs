using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinFormsApp1.Database
{
    public class DatabaseConnection
    {
        private string connectionString = "Server=localhost;Database=duckfarmapps;User ID=root;Password=;";

        private MySqlConnection connection;

        public DatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        // Metode untuk membuka koneksi
        public MySqlConnection GetNewConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Metode untuk menutup koneksi
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
