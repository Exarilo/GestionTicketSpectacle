using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionTicketSpectacle.App.Classes
{
    public class ConnexionDB
    {
        private readonly string connectionString;
        public SqlConnection Connection { get; set; }

        public ConnexionDB()
        {
            this.connectionString =Constant.BDD_RomainConnectionString;
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
                MessageBox.Show(Constant.MessageBoxErrorOpeningConnection+ ex.Message);
                return null;
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
                    Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constant.MessageBoxErrorClosingConnection + ex.Message);
            }
        }
    }
}
