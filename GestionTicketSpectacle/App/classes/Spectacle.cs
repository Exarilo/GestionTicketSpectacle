using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTicketSpectacle.App.Classes
{
    internal class Spectacle
    {
        private int ID {  get; set; }
        private string Titre { get; set; }
        private DateTime Date { get; set; }
        private string Lieu {  get; set; }
        private int NbPlace { get; set; }

        public Spectacle(int iD, string titre, DateTime date, string lieu, int nbPlace)
        {
            ID = iD;
            Titre = titre;
            Date = date;
            Lieu = lieu;
            NbPlace = nbPlace;
        }
    }
}
