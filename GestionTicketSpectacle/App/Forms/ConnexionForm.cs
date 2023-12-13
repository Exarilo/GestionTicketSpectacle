using GestionTicketSpectacle.App.Forms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTicketSpectacle
{
    public partial class ConnexionForm : Form
    {
        private InscriptionForm inscription;
        public ConnexionForm()
        {
            InitializeComponent();
        }

        private void linkLbRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (inscription == null || inscription.IsDisposed)
            {
                inscription = new InscriptionForm();
                inscription.FormClosed += InscriptionFormClosed; 
            }

            this.Hide(); 
            inscription.Show();
        }
        private void InscriptionFormClosed(object sender, EventArgs e)
        {
            this.Show(); 
        }

        private async void btValidate_Click(object sender, EventArgs e)
        {
            await HandleEmptyField(tbUsername.Text, pbUsernameError);
            await HandleEmptyField(tbPassword.Text, pbPasswordError);
        }

        private async Task HandleEmptyField(string fieldText, PictureBox pictureBox)
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

        private async Task BlinkIcon(PictureBox pictureBox)
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
