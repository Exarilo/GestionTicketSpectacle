using GestionTicketSpectacle.App.Classes.Spectacles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
namespace GestionTicketSpectacle.App.Classes
{
    public class Spectacle
    {
        public Bitmap Icon { get; set; }
        public int ID { get; set; }
        public string Titre { get; set; }
        public DateTime Date { get; set; }
        public string Lieu { get; set; }
        public int NbPlace { get; set; }
        public int Price { get; set; }
        public GestionnaireBillets BilletManager {get;set;}

        public Spectacle(int iD, TypeSpectable typeSpectable ,string titre, DateTime date,int price, string lieu, int nbPlace)
        {
            this.ID = iD;
            this.Icon = typeSpectable.GetAssociatedBitmap();
            this.Titre = titre;
            this.Date = date;
            this.Lieu = lieu;
            this.NbPlace = nbPlace;
            this.Price = price;
            BilletManager = new GestionnaireBillets();
            BilletManager.AddRange(ProvideBillets(nbPlace));
        }

        public IEnumerable<Billet> ProvideBillets(int nbBillets)
        {
            return from billet in Enumerable.Range(0, nbBillets) select new Billet(this.ID,  false);
        }
    }
}
