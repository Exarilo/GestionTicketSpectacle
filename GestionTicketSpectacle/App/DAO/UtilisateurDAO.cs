using GestionTicketSpectacle.App.Classes;
using System;
using System.Data.SqlClient;

namespace GestionTicketSpectacle.App.DAO
{
    public class UtilisateurDAO
    {
        public UtilisateurDAO() { }

        public bool ConnexionUser(string nom, string mdp)
        {
            try
            {
                ConnexionDB db = new ConnexionDB();

                if (db.Connection == null)
                {
                    return false;
                }

                string query = "SELECT COUNT(*) FROM Users WHERE Nom = @Nom AND Mdp = @Mdp";
                using (SqlCommand command = new SqlCommand(query, db.Connection))
                {
                    command.Parameters.AddWithValue("@Nom", nom);
                    command.Parameters.AddWithValue("@Mdp", mdp);

                    int userCount = (int)command.ExecuteScalar();

                    if (userCount > 0)
                        return true;
                    else
                        return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(Constant.ConsoleUserNotFound + ex.Message);
                return false;
            }
        }

    }
}
