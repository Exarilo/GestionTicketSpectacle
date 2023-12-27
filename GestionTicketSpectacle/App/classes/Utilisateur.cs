using System.Collections.Generic;

namespace GestionTicketSpectacle.App.Classes
{
    public class Utilisateur
    {
        public int ID {  get; set; }
        public string Nom { get; set; }
        private string Mdp { get; set; }
        public List<Billet> Reservations { get; set; }

        public Utilisateur(int iD, string nom, List<Billet> reservations, string mdp)
        {
            ID = iD;
            Nom = nom;
            Reservations = reservations;
            Mdp = mdp;
        }
    }
}
