namespace GestionTicketSpectacle.App.Classes
{
    public class Billet
    {
        public delegate void ReservationDelegate(int eventId);
        public delegate void CancellationDelegate(int ticketId);

        public event ReservationDelegate OnReservation;
        public event CancellationDelegate OnCancellation;

        private int IDSpectacle { get; set; }
        private bool StatutReservation { get; set; }

        public Billet(int iDSpectacle, bool statutReservation)
        {
            IDSpectacle = iDSpectacle;
            StatutReservation = statutReservation;
        }

        public void BuyBillet()
        {
            OnReservation?.Invoke(IDSpectacle);
        }

        public void CancelReservation(int ticketId)
        {
            OnCancellation?.Invoke(ticketId);
        }
    }

}
