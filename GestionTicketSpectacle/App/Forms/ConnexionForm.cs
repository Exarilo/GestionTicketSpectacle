using GestionTicketSpectacle.App;
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
            await Tools.HandleEmptyField(tbUsername.Text, pbUsernameError);
            await Tools.HandleEmptyField(tbPassword.Text, pbPasswordError);
        }
    }
}
