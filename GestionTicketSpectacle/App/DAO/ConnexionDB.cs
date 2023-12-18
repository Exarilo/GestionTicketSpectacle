using System;
using System.Data.SqlClient;

namespace GestionTicketSpectacle.App.Classes
{
    public class ConnexionDB
    {
        private readonly string connectionString;
        public SqlConnection Connection { get; set; }

        public ConnexionDB()
        {
            //Kelvin
            //this.connectionString = "Data Source = MSI; Initial Catalog = TpGestionTicketSpectacle; User ID = test2; Password = root";

            //Romain
            this.connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=TpGestionTicketSpectacle;Integrated Security=True;User ID=Exarilo;";
            this.Connection = this.OpenConnection();

        }

        public SqlConnection OpenConnection()
        {
            try
            {
                if (Connection == null)
                {
                    Connection = new SqlConnection(connectionString);
                }

                if (Connection.State != System.Data.ConnectionState.Open)
                {
                    Connection.Open();
                }

                return Connection;
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
                if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error closing database connection: {ex.Message}");
            }
        }
    }
}
