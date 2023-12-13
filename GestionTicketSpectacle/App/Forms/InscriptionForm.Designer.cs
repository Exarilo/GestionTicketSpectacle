namespace GestionTicketSpectacle.App.Forms
{
    partial class InscriptionForm
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btValidate = new System.Windows.Forms.Button();
            this.pbUsernameError = new System.Windows.Forms.PictureBox();
            this.pbPasswordError = new System.Windows.Forms.PictureBox();
            this.pbConfirmPasswordError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsernameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmPasswordError)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(9, 103);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(405, 20);
            this.tbPassword.TabIndex = 8;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(9, 45);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(405, 20);
            this.tbUsername.TabIndex = 7;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(6, 77);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(77, 13);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Mot de passe :";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(6, 15);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(90, 13);
            this.lbUsername.TabIndex = 5;
            this.lbUsername.Text = "Nom d\'utilisateur :";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(9, 168);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(405, 20);
            this.tbConfirmPassword.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Confirmation mot de passe :";
            // 
            // btValidate
            // 
            this.btValidate.Location = new System.Drawing.Point(146, 226);
            this.btValidate.Name = "btValidate";
            this.btValidate.Size = new System.Drawing.Size(75, 23);
            this.btValidate.TabIndex = 12;
            this.btValidate.Text = "Valider";
            this.btValidate.UseVisualStyleBackColor = true;
            this.btValidate.Click += new System.EventHandler(this.btValidate_Click);
            // 
            // pbUsernameError
            // 
            this.pbUsernameError.BackgroundImage = global::GestionTicketSpectacle.Properties.Resources.error;
            this.pbUsernameError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUsernameError.Location = new System.Drawing.Point(419, 45);
            this.pbUsernameError.Name = "pbUsernameError";
            this.pbUsernameError.Size = new System.Drawing.Size(22, 20);
            this.pbUsernameError.TabIndex = 15;
            this.pbUsernameError.TabStop = false;
            this.pbUsernameError.Visible = false;
            // 
            // pbPasswordError
            // 
            this.pbPasswordError.BackgroundImage = global::GestionTicketSpectacle.Properties.Resources.error;
            this.pbPasswordError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPasswordError.Location = new System.Drawing.Point(419, 103);
            this.pbPasswordError.Name = "pbPasswordError";
            this.pbPasswordError.Size = new System.Drawing.Size(22, 20);
            this.pbPasswordError.TabIndex = 16;
            this.pbPasswordError.TabStop = false;
            this.pbPasswordError.Visible = false;
            // 
            // pbConfirmPasswordError
            // 
            this.pbConfirmPasswordError.BackgroundImage = global::GestionTicketSpectacle.Properties.Resources.error;
            this.pbConfirmPasswordError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbConfirmPasswordError.Location = new System.Drawing.Point(419, 168);
            this.pbConfirmPasswordError.Name = "pbConfirmPasswordError";
            this.pbConfirmPasswordError.Size = new System.Drawing.Size(22, 20);
            this.pbConfirmPasswordError.TabIndex = 17;
            this.pbConfirmPasswordError.TabStop = false;
            this.pbConfirmPasswordError.Visible = false;
            // 
            // InscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 261);
            this.Controls.Add(this.pbConfirmPasswordError);
            this.Controls.Add(this.pbPasswordError);
            this.Controls.Add(this.pbUsernameError);
            this.Controls.Add(this.btValidate);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InscriptionForm";
            this.Text = "Inscription";
            ((System.ComponentModel.ISupportInitialize)(this.pbUsernameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmPasswordError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btValidate;
        private System.Windows.Forms.PictureBox pbUsernameError;
        private System.Windows.Forms.PictureBox pbPasswordError;
        private System.Windows.Forms.PictureBox pbConfirmPasswordError;
    }
}