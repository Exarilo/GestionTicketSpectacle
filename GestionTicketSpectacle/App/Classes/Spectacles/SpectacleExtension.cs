using GestionTicketSpectacle.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTicketSpectacle.App.Classes.Spectacles
{
    public static class SpectacleExtension
    {
        private static Bitmap GetConcertIcon() => Resources.concert;
        private static Bitmap GetTheatreIcon() => Resources.theatre;
        private static Bitmap GetSportIcon() => Resources.sport;

        public static Bitmap GetAssociatedBitmap(this TypeSpectable typeSpectable)
        {
            switch (typeSpectable)
            {
                case TypeSpectable.Concert when typeSpectable == TypeSpectable.Concert:
                    return TypeSpectacle.GetConcertIcon();
                case TypeSpectable.Theatre when typeSpectable == TypeSpectable.Theatre:
                    return TypeSpectacle.GetTheatreIcon();
                case TypeSpectable.Sport when typeSpectable == TypeSpectable.Sport:
                    return TypeSpectacle.GetSportIcon();

                default:
                    throw new Exception("Un type de spectacle doit avoir uen icone qui lui ait associé");
            }
        }
    }
}
