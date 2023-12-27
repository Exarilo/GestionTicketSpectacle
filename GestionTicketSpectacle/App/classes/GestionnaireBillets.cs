using System.Collections.Generic;

namespace GestionTicketSpectacle.App.Classes
{
    public class GestionnaireBillets
    {
        private List<Billet> billets;

        public GestionnaireBillets()
        {
            billets = new List<Billet>();
        }
        public void AddBillet(Billet billet)
        {
            if (billet != null)
            {
                billets.Add(billet);
                billet.OnReservation += HandleReservation;
                billet.OnCancellation += HandleCancellation;
            }
        }

        public void AddRange(IEnumerable<Billet> newBillets)
        {
            foreach (var billet in newBillets)
            {
                AddBillet(billet); //affecte les events liés a la réservation
            }
        }

        public void DeleteBillet(Billet billet)
        {
            //quand un billet est reservé ont lui retire les events liés a la reservation
            if (billets.Contains(billet))
            {
                billet.OnReservation -= HandleReservation;
                billet.OnCancellation -= HandleCancellation;
                billets.Remove(billet);
            }
        }

        private void HandleReservation(int eventId)
        {
            
        }

        private void HandleCancellation(int ticketId)
        {

        }
    }
}
