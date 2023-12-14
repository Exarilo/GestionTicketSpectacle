using System;
using System.Data.SqlClient;

namespace GestionTicketSpectacle.App.Classes
{
    public class ConnexionDB
    {
        private readonly string connectionString;
        private SqlConnection connection;

        public ConnexionDB()
        {
            this.connectionString = "Data Source = MSI; Initial Catalog = TpGestionTicketSpectacle; User ID = test2; Password = root";
        }

        public SqlConnection OpenConnection()
        {
            try
            {
                if (connection == null)
                {
                    connection = new SqlConnection(connectionString);
                }

                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening database connection: {ex.Message}");
                return null;
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error closing database connection: {ex.Message}");
            }
        }
    }
}
