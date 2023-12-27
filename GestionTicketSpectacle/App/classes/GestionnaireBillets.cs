using System;
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
                AddBillet(billet);
            }
        }

        public void DeleteBillet(Billet billet)
        {
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
