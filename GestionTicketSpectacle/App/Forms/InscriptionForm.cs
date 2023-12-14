using System;
using System.Windows.Forms;

namespace GestionTicketSpectacle.App.Forms
{
    public partial class InscriptionForm : Form
    {
        public InscriptionForm()
        {
            InitializeComponent();
        }

        private async void btValidate_Click(object sender, EventArgs e)
        {
            await Tools.HandleEmptyField(tbUsername.Text, pbUsernameError);
            await Tools.HandleEmptyField(tbPassword.Text, pbPasswordError);
            await Tools.HandleEmptyField(tbConfirmPassword.Text, pbConfirmPasswordError);
        }
    }
}
