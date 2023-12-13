using GestionTicketSpectacle.App;
using GestionTicketSpectacle.App.DAO;
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

            UtilisateurDAO utilisateurDAO = new UtilisateurDAO();
            var test = utilisateurDAO.ConnexionUser(tbUsername.Text, tbPassword.Text);
            //MessageBox.Show(utilisateurDAO.ConnexionUser(tbUsername.Text , tbPassword.Text));
            if (utilisateurDAO.ConnexionUser(tbUsername.Text, tbPassword.Text)){
                ReservationForm mainForm = new ReservationForm();

                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erreur de connexion verifier vos identifiants","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
