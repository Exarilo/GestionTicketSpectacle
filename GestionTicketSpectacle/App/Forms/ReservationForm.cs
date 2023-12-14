using GestionTicketSpectacle.App.Api_Rest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTicketSpectacle.App.Forms
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
            test();
        }

        private async void test()
        {
            APIManager aPIManager = new APIManager();
            var spectacles = await aPIManager.GetSpectacles();
            var b = 1;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ConnexionForm mainForm = new ConnexionForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
