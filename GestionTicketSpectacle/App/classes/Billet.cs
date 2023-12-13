using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTicketSpectacle.App.Classes
{
    internal class Billet
    {
        private int IDSpectacle {  get; set; }
        private int IDUtilisateur { get; set; }
        private bool StatutReservation { get; set; }

        public Billet(int iDSpectacle, int iDUtilisateur, bool statutReservation)
        {
            IDSpectacle = iDSpectacle;
            IDUtilisateur = iDUtilisateur;
            StatutReservation = statutReservation;
        }
    }
}
