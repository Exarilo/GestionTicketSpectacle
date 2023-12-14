﻿using GestionTicketSpectacle.App.Classes;
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
                using (SqlConnection connection = db.OpenConnection())
                {
                    if (connection == null)
                    {
                        //return false;
                    }

                    string query = "SELECT COUNT(*) FROM Users WHERE Nom = @Nom AND Mdp = @Mdp";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nom", nom);
                        command.Parameters.AddWithValue("@Mdp", mdp);

                        int userCount = (int)command.ExecuteScalar();

                        if(userCount > 0)
                        {
                            return true;
                        }
                        else 
                        { 
                            return false; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking user existence: {ex.Message}");
                return false;
            }
        }

    }
}