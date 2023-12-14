using GestionTicketSpectacle.App.Api_Rest;
using System.Windows.Forms;

namespace GestionTicketSpectacle.App.Forms
{
    public partial class ReservationForm2 : Form
    {
        public ReservationForm2()
        {
            InitializeComponent();
            FillGrid();

        }
        private async void FillGrid()
        {
            APIManager aPIManager = new APIManager();
            var spectacles = await aPIManager.GetSpectacles();
            foreach ( var spectacle in spectacles)
            {
                this.dataGridView1.Rows.Add(spectacle.Icon,spectacle.Titre, spectacle.Lieu, spectacle.Date,false);
            }
        }
    }
}
