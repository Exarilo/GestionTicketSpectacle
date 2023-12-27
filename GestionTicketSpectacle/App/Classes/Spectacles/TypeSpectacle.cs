using GestionTicketSpectacle.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace GestionTicketSpectacle.App.Classes
{
    public static class TypeSpectacle
    {
        public static Bitmap GetConcertIcon() => Resources.concert;
        public static Bitmap GetTheatreIcon() => Resources.theatre;
        public static Bitmap GetSportIcon() => Resources.sport;
        public static TypeSpectable GetTypeSpectacleFromString(string type) 
        { 
            switch(type)
            {
                case "Theatre":
                    return TypeSpectable.Theatre;
                case "Concert":
                    return TypeSpectable.Concert;
                case "Sport":
                    return TypeSpectable.Sport;
                default:
                    throw new System.Exception("This event type doesn't exist");
            }
        } 
    }
    public enum TypeSpectable
    {
        Concert,
        Theatre,
        Sport
    }
}
