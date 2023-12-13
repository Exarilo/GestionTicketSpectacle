namespace GestionTicketSpectacle
{
    partial class ConnexionForm
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.linkLbRegistration = new System.Windows.Forms.LinkLabel();
            this.btValidate = new System.Windows.Forms.Button();
            this.pbPasswordError = new System.Windows.Forms.PictureBox();
            this.pbUsernameError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsernameError)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(22, 19);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(90, 13);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Nom d\'utilisateur :";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(22, 88);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(77, 13);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Mot de passe :";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(25, 49);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(405, 20);
            this.tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(25, 116);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(405, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // linkLbRegistration
            // 
            this.linkLbRegistration.AutoSize = true;
            this.linkLbRegistration.Location = new System.Drawing.Point(175, 153);
            this.linkLbRegistration.Name = "linkLbRegistration";
            this.linkLbRegistration.Size = new System.Drawing.Size(49, 13);
            this.linkLbRegistration.TabIndex = 4;
            this.linkLbRegistration.TabStop = true;
            this.linkLbRegistration.Text = "S\'inscrire";
            this.linkLbRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbRegistration_LinkClicked);
            // 
            // btValidate
            // 
            this.btValidate.Location = new System.Drawing.Point(165, 178);
            this.btValidate.Name = "btValidate";
            this.btValidate.Size = new System.Drawing.Size(75, 23);
            this.btValidate.TabIndex = 16;
            this.btValidate.Text = "Valider";
            this.btValidate.UseVisualStyleBackColor = true;
            this.btValidate.Click += new System.EventHandler(this.btValidate_Click);
            // 
            // pbPasswordError
            // 
            this.pbPasswordError.BackgroundImage = global::GestionTicketSpectacle.Properties.Resources.error;
            this.pbPasswordError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPasswordError.Location = new System.Drawing.Point(436, 116);
            this.pbPasswordError.Name = "pbPasswordError";
            this.pbPasswordError.Size = new System.Drawing.Size(22, 20);
            this.pbPasswordError.TabIndex = 15;
            this.pbPasswordError.TabStop = false;
            this.pbPasswordError.Visible = false;
            // 
            // pbUsernameError
            // 
            this.pbUsernameError.BackgroundImage = global::GestionTicketSpectacle.Properties.Resources.error;
            this.pbUsernameError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUsernameError.Location = new System.Drawing.Point(436, 49);
            this.pbUsernameError.Name = "pbUsernameError";
            this.pbUsernameError.Size = new System.Drawing.Size(22, 20);
            this.pbUsernameError.TabIndex = 14;
            this.pbUsernameError.TabStop = false;
            this.pbUsernameError.Visible = false;
            // 
            // ConnexionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 221);
            this.Controls.Add(this.btValidate);
            this.Controls.Add(this.pbPasswordError);
            this.Controls.Add(this.pbUsernameError);
            this.Controls.Add(this.linkLbRegistration);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConnexionForm";
            this.Text = "Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsernameError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.LinkLabel linkLbRegistration;
        private System.Windows.Forms.PictureBox pbUsernameError;
        private System.Windows.Forms.PictureBox pbPasswordError;
        private System.Windows.Forms.Button btValidate;
    }
}

