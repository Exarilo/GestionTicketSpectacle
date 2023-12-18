using System;
using System.Collections.Generic;

namespace GestionTicketSpectacle.App.Classes
{
    public class GestionnaireBillets
    {
        private List<Billet> billets;

        public GestionnaireBillets()
        {

        }
        private void AddBillet(Billet billet)
        {
            if (billet != null)
            {
                billets.Add(billet);
                billet.OnReservation += HandleReservation;
                billet.OnCancellation += HandleCancellation;
            }
        }

        private void DeleteBillet(Billet billet)
        {
            if (billets.Contains(billet))
            {
                billet.OnReservation -= HandleReservation;
                billet.OnCancellation -= HandleCancellation;
                billets.Remove(billet);
            }
        }

        private void HandleReservation(int eventId, int userId)
        {
            
        }

        private void HandleCancellation(int ticketId)
        {

        }
    }
}
