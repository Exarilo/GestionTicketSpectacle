namespace GestionTicketSpectacle.App.Classes
{
    public class Billet
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
