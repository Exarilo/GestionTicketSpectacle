using System;
using System.Windows.Forms;

namespace GestionTicketSpectacle.App.Forms
{
    public partial class OnReservationForm : Form
    {
        public event EventHandler UpdateReservationForm;
        private uint UnitPrice {  get; set; }
        public OnReservationForm(string name,uint quantityMax,uint unitPrice)
        {
            InitializeComponent();
            lbName.Text = name;
            nudQuantity.Maximum = quantityMax;
            lbPrice.Text = $"{unitPrice} €";
            this.UnitPrice = unitPrice; 
        }

        private void nudQuantity_ValueChanged(object sender, System.EventArgs e)
        {
            lbPrice.Text = $"{nudQuantity.Value* UnitPrice} €";
        }

        private void OnReservationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateReservationForm?.Invoke(this, EventArgs.Empty);
        }
        public string GetDataForInventory()
        {
            return $"{lbName.Text} x {nudQuantity.Value} ({nudQuantity.Value* UnitPrice} €)";
        }

        public decimal GetTotalPrice()
        {
            return nudQuantity.Value*UnitPrice;
        }
    }
}
