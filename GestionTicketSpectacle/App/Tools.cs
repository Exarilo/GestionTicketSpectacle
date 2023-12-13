using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTicketSpectacle.App
{
    public static class Tools
    {
        public static async Task HandleEmptyField(string fieldText, PictureBox pictureBox)
        {
            if (string.IsNullOrWhiteSpace(fieldText))
            {
                await BlinkIcon(pictureBox);
            }
            else
            {
                pictureBox.Visible = false;
            }
        }

        public static async Task BlinkIcon(PictureBox pictureBox)
        {
            int numberOfBlinks = 6;
            for (int i = 0; i < numberOfBlinks; i++)
            {
                pictureBox.Visible = !pictureBox.Visible;
                await Task.Delay(150);
            }
            pictureBox.Visible = true;
        }
    }
}
