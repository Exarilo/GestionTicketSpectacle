using GestionTicketSpectacle.Properties;
using System.Drawing;

namespace GestionTicketSpectacle.App.Classes
{
    public static class TypeSpectacle
    {
        public static Bitmap GetConcertIcon() => Resources.concert;
        public static Bitmap GetTheatreIcon() => Resources.theatre;
        public static Bitmap GetSportIcon() => Resources.sport;
    }
    public enum TypeSpectable
    {
        Concert,
        Theatre,
        Sport
    }
}
