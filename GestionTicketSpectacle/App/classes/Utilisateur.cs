using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTicketSpectacle.App.Classes
{
    internal class Utilisateur
    {
        private int ID {  get; set; }
        private string Nom { get; set; }
        private string Mdp { get; set; }
        private List<Billet> Reservations { get; set; }

        public Utilisateur(int iD, string nom, List<Billet> reservations, string mdp)
        {
            ID = iD;
            Nom = nom;
            Reservations = reservations;
            Mdp = mdp;
        }
    }
}
