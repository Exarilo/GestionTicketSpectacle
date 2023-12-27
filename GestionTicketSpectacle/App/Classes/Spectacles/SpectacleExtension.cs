using GestionTicketSpectacle.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace GestionTicketSpectacle.App.Classes.Spectacles
{
    public static class SpectacleExtension
    {
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
                    throw new Exception(Constant.ExceptionEventWithoutIcon);
            }
        }
    }
}
