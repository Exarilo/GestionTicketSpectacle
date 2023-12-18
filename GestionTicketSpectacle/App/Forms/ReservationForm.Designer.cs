﻿namespace GestionTicketSpectacle.App.Forms
{
    partial class ReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.compteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.dgvSelection = new System.Windows.Forms.DataGridView();
            this.colIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemainingPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToInventory = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabShop = new System.Windows.Forms.TabPage();
            this.lbInventory = new System.Windows.Forms.CheckedListBox();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.btPay = new System.Windows.Forms.Button();
            this.tabHistorical = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelection)).BeginInit();
            this.tabShop.SuspendLayout();
            this.tabHistorical.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // compteToolStripMenuItem
            // 
            this.compteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconnexionToolStripMenuItem});
            this.compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            this.compteToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.compteToolStripMenuItem.Text = "Compte";
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.deconnexionToolStripMenuItem.Text = "Deconnexion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 78);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GestionTicketSpectacle.Properties.Resources.usericon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 78);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabShop);
            this.tabControl1.Controls.Add(this.tabHistorical);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 102);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(881, 348);
            this.tabControl1.TabIndex = 8;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.dgvSelection);
            this.tabHome.Location = new System.Drawing.Point(4, 25);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(873, 319);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Acceuil";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // dgvSelection
            // 
            this.dgvSelection.AllowUserToAddRows = false;
            this.dgvSelection.AllowUserToDeleteRows = false;
            this.dgvSelection.AllowUserToOrderColumns = true;
            this.dgvSelection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIcon,
            this.colName,
            this.colLocation,
            this.colDate,
            this.colPrice,
            this.colRemainingPlaces,
            this.colToInventory});
            this.dgvSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelection.Location = new System.Drawing.Point(3, 3);
            this.dgvSelection.Name = "dgvSelection";
            this.dgvSelection.ReadOnly = true;
            this.dgvSelection.Size = new System.Drawing.Size(867, 313);
            this.dgvSelection.TabIndex = 0;
            this.dgvSelection.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelection_CellContentClick);
            // 
            // colIcon
            // 
            this.colIcon.HeaderText = "Type";
            this.colIcon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colIcon.Name = "colIcon";
            this.colIcon.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Nom";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colLocation
            // 
            this.colLocation.HeaderText = "Lieu";
            this.colLocation.Name = "colLocation";
            this.colLocation.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Prix";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colRemainingPlaces
            // 
            this.colRemainingPlaces.HeaderText = "Places Restantes";
            this.colRemainingPlaces.Name = "colRemainingPlaces";
            this.colRemainingPlaces.ReadOnly = true;
            // 
            // colToInventory
            // 
            this.colToInventory.HeaderText = "Réservation";
            this.colToInventory.Name = "colToInventory";
            this.colToInventory.ReadOnly = true;
            this.colToInventory.Text = "Réserver";
            this.colToInventory.UseColumnTextForButtonValue = true;
            // 
            // tabShop
            // 
            this.tabShop.Controls.Add(this.lbInventory);
            this.tabShop.Controls.Add(this.lbTotalPrice);
            this.tabShop.Controls.Add(this.lb);
            this.tabShop.Controls.Add(this.btPay);
            this.tabShop.Location = new System.Drawing.Point(4, 25);
            this.tabShop.Name = "tabShop";
            this.tabShop.Size = new System.Drawing.Size(873, 319);
            this.tabShop.TabIndex = 2;
            this.tabShop.Text = "Panier";
            this.tabShop.UseVisualStyleBackColor = true;
            // 
            // lbInventory
            // 
            this.lbInventory.CheckOnClick = true;
            this.lbInventory.FormattingEnabled = true;
            this.lbInventory.Location = new System.Drawing.Point(27, 19);
            this.lbInventory.Name = "lbInventory";
            this.lbInventory.Size = new System.Drawing.Size(722, 174);
            this.lbInventory.TabIndex = 5;
            this.lbInventory.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lbInventory_ItemCheck);
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Location = new System.Drawing.Point(69, 227);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(24, 16);
            this.lbTotalPrice.TabIndex = 4;
            this.lbTotalPrice.Text = "0 €";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(24, 226);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(44, 16);
            this.lb.TabIndex = 3;
            this.lb.Text = "Total :";
            // 
            // btPay
            // 
            this.btPay.AutoSize = true;
            this.btPay.Location = new System.Drawing.Point(111, 222);
            this.btPay.Name = "btPay";
            this.btPay.Size = new System.Drawing.Size(75, 26);
            this.btPay.TabIndex = 1;
            this.btPay.Text = "Payer";
            this.btPay.UseVisualStyleBackColor = true;
            this.btPay.Click += new System.EventHandler(this.btPay_Click);
            // 
            // tabHistorical
            // 
            this.tabHistorical.Controls.Add(this.label3);
            this.tabHistorical.Controls.Add(this.label2);
            this.tabHistorical.Controls.Add(this.listBox1);
            this.tabHistorical.Location = new System.Drawing.Point(4, 25);
            this.tabHistorical.Name = "tabHistorical";
            this.tabHistorical.Size = new System.Drawing.Size(873, 319);
            this.tabHistorical.TabIndex = 3;
            this.tabHistorical.Text = "Historique";
            this.tabHistorical.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "0€ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prix total : ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(27, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(722, 196);
            this.listBox1.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 392);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(881, 58);
            this.panel.TabIndex = 9;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReservationForm";
            this.Text = "ReservationForm2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelection)).EndInit();
            this.tabShop.ResumeLayout(false);
            this.tabShop.PerformLayout();
            this.tabHistorical.ResumeLayout(false);
            this.tabHistorical.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem compteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabShop;
        private System.Windows.Forms.TabPage tabHistorical;
        private System.Windows.Forms.Button btPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dgvSelection;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridViewImageColumn colIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemainingPlaces;
        private System.Windows.Forms.DataGridViewButtonColumn colToInventory;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.CheckedListBox lbInventory;
    }
}