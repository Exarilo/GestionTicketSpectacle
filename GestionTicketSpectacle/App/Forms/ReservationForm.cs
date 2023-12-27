using GestionTicketSpectacle.App.Api_Rest;
using System;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;


namespace GestionTicketSpectacle.App.Forms
{
    public partial class ReservationForm : Form
    {
        public ReservationForm(string username)
        {
            InitializeComponent();
            FillGrid();
            lbUsername.Text=username;

        }
        private async void FillGrid()
        {
            APIManager aPIManager = new APIManager();
            var spectacles = await aPIManager.GetSpectacles();
            foreach (var spectacle in spectacles)
            {
                this.dgvSelection.Rows.Add(spectacle.Icon, spectacle.Titre, spectacle.Lieu, spectacle.Date, spectacle.Price, spectacle.NbPlace);
            }
        }

        private void dgvSelection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSelection.Columns[e.ColumnIndex].Name == "colToInventory" && e.RowIndex >= 0)
            {
                string eventName = dgvSelection.Rows[e.RowIndex].Cells["colName"].Value.ToString();
                uint remainingPlaces = Convert.ToUInt32(dgvSelection.Rows[e.RowIndex].Cells["colRemainingPlaces"].Value);
                uint unitPrice = Convert.ToUInt32(dgvSelection.Rows[e.RowIndex].Cells["colPrice"].Value);


                OnReservationForm onReservationForm = new OnReservationForm(eventName, remainingPlaces, unitPrice);
                onReservationForm.UpdateReservationForm += UpdateReservationFormHandler;
                if (onReservationForm.ShowDialog() == DialogResult.OK)
                {
                    //obligé de créer un fichier temporaire avec l'image (depuis l'uri directement ne amrche pas)
                    string imageUrl = "https://cdn-icons-png.flaticon.com/512/148/148767.png"; // Remplacez par votre URL
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        string tempImagePath = Path.Combine(Path.GetTempPath(), "tempImage.png");
                        File.WriteAllBytes(tempImagePath, imageBytes);

                        new ToastContentBuilder()
                            .AddToastActivationInfo("action", ToastActivationType.Foreground)
                            .AddText("Nouvelle réservation ajouté au panier !")
                            .AddText($"Réservation pour {eventName}")
                            .AddText($"Places restantes : {remainingPlaces}")
                            .AddAppLogoOverride(new Uri($"file:///{tempImagePath}"), ToastGenericAppLogoCrop.Circle)
                            .Show();
                    }
                }
            }
        }

        private void UpdateReservationFormHandler(object sender, EventArgs e)
        {
            lbInventory.Items.Add((sender as OnReservationForm).GetDataForInventory());
            lbInventory.SetItemChecked(lbInventory.Items.Count - 1, true); //on met l'item qui vient d'être rajouté a checked
        }

        private void btPay_Click(object sender, EventArgs e)
        {
            if(lbInventory.Items.Count==0)
            {
                MessageBox.Show("Rien n'a été selectioné");
                return;
            }
            int totalSelectedPrice = 0;

            for (int i = 0; i < lbInventory.Items.Count; i++)
            {
                if (lbInventory.GetItemChecked(i))
                {
                    string item = lbInventory.Items[i].ToString();
                    Match match = Regex.Match(item, @"\((\d+) €\)");

                    if (match.Success)
                    {
                        if (int.TryParse(match.Groups[1].Value, out int price))
                        {
                            totalSelectedPrice += price;
                        }
                    }
                }
            }
            if (MessageBox.Show($"Confirmer le payement de {lbTotalPrice.Text}?", "Confirmation de payement", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string imageUrl = "https://cdn-icons-png.flaticon.com/512/148/148767.png"; // Remplacez par votre URL
                using (WebClient webClient = new WebClient())
                {
                    byte[] imageBytes = webClient.DownloadData(imageUrl);
                    string tempImagePath = Path.Combine(Path.GetTempPath(), "tempImage.png");
                    File.WriteAllBytes(tempImagePath, imageBytes);

                    new ToastContentBuilder()
                        .AddToastActivationInfo("action", ToastActivationType.Foreground)
                        .AddText("Merci pour votre achat !")
                        .AddText($"Payement de {totalSelectedPrice} € confirmé")
                        .AddAppLogoOverride(new Uri($"file:///{tempImagePath}"), ToastGenericAppLogoCrop.Circle)
                        .Show();
       
                    //doit etre optimisé pas normal d'avoir 2 fois la boucle sur lbInventory
                    //methode trop grande pourrait etre splitté en plusieurs parties.
                    for (int i = 0; i < lbInventory.Items.Count; i++)
                    {
                        if (lbInventory.GetItemChecked(i))
                            lbHistory.Items.Add(lbInventory.Items[i].ToString());
                        lbHistoryPrice.Text = $"{totalSelectedPrice} €"; // devrait faire une addition avec le prix actuel actuellement ca reinitialise
                    }
                    RemoveCheckedItems(lbInventory);

                }
            }
        }

        private void RemoveCheckedItems(CheckedListBox checkedListBox)
        {
            for (int i = checkedListBox.Items.Count - 1; i >= 0; i--)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    checkedListBox.Items.RemoveAt(i);
                }
            }
        }

        private void lbInventory_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = lbInventory.Items[e.Index].ToString();
            Regex regex = new Regex(@"\((\d+) €\)");

            Match match = regex.Match(item);
            if (match.Success)
            {
                int parsedValue;
                if (int.TryParse(match.Groups[1].Value, out parsedValue))
                {
                    if (int.TryParse(lbTotalPrice.Text.Substring(0, lbTotalPrice.Text.Length - 1), out int currentPrice))
                    {
                        if (e.NewValue == CheckState.Checked)
                        {
                            // Ajout du prix si checked
                            lbTotalPrice.Text = $"{currentPrice + parsedValue} €";
                        }
                        else
                        {
                            // Reduc du prix si unchecked
                            lbTotalPrice.Text = $"{currentPrice - parsedValue} €";
                        }
                    }
                }
            }
        }

    }
}
