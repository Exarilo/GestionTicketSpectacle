namespace GestionTicketSpectacle.App.Classes
{
    public class Billet
    {
        public delegate void ReservationDelegate(int eventId, int userId);
        public delegate void CancellationDelegate(int ticketId);

        public event ReservationDelegate OnReservation;
        public event CancellationDelegate OnCancellation;

        private int IDSpectacle { get; set; }
        private int IDUtilisateur { get; set; }
        private bool StatutReservation { get; set; }

        public Billet(int iDSpectacle, int iDUtilisateur, bool statutReservation)
        {
            IDSpectacle = iDSpectacle;
            IDUtilisateur = iDUtilisateur;
            StatutReservation = statutReservation;
        }

        public void EffectuerReservation()
        {
            OnReservation?.Invoke(IDSpectacle, IDUtilisateur);
        }

        public void EffectuerAnnulation(int ticketId)
        {
            OnCancellation?.Invoke(ticketId);
        }
    }

}
