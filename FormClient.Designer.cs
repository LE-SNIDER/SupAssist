namespace SupAssist
{
    partial class FormClient
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
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.labelCodePostal = new System.Windows.Forms.Label();
            this.labelVille = new System.Windows.Forms.Label();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelListeDesClients = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.maskedTextBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNom.Location = new System.Drawing.Point(82, 38);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(190, 20);
            this.textBoxNom.TabIndex = 1;
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(197, 226);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.buttonEnregistrer.TabIndex = 6;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(47, 41);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "Nom";
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(18, 145);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(58, 13);
            this.labelTelephone.TabIndex = 4;
            this.labelTelephone.Text = "Téléphone";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(33, 15);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 6;
            this.labelPrenom.Text = "Prénom";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(82, 12);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(190, 20);
            this.textBoxPrenom.TabIndex = 0;
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(31, 67);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(45, 13);
            this.labelAdresse.TabIndex = 8;
            this.labelAdresse.Text = "Adresse";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(82, 64);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(190, 20);
            this.textBoxAdresse.TabIndex = 2;
            // 
            // labelCodePostal
            // 
            this.labelCodePostal.AutoSize = true;
            this.labelCodePostal.Location = new System.Drawing.Point(12, 93);
            this.labelCodePostal.Name = "labelCodePostal";
            this.labelCodePostal.Size = new System.Drawing.Size(64, 13);
            this.labelCodePostal.TabIndex = 10;
            this.labelCodePostal.Text = "Code Postal";
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(50, 119);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(26, 13);
            this.labelVille.TabIndex = 12;
            this.labelVille.Text = "Ville";
            // 
            // textBoxVille
            // 
            this.textBoxVille.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxVille.Location = new System.Drawing.Point(82, 116);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(190, 20);
            this.textBoxVille.TabIndex = 4;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(100, 199);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(172, 21);
            this.comboBoxClient.TabIndex = 13;
            // 
            // labelListeDesClients
            // 
            this.labelListeDesClients.AutoSize = true;
            this.labelListeDesClients.Location = new System.Drawing.Point(12, 202);
            this.labelListeDesClients.Name = "labelListeDesClients";
            this.labelListeDesClients.Size = new System.Drawing.Size(82, 13);
            this.labelListeDesClients.TabIndex = 14;
            this.labelListeDesClients.Text = "Liste des clients";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(12, 239);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(110, 13);
            this.labelRole.TabIndex = 15;
            this.labelRole.Text = "Connecté en tant que";
            // 
            // maskedTextBoxTelephone
            // 
            this.maskedTextBoxTelephone.Location = new System.Drawing.Point(82, 142);
            this.maskedTextBoxTelephone.Mask = "00 00 00 00 00";
            this.maskedTextBoxTelephone.Name = "maskedTextBoxTelephone";
            this.maskedTextBoxTelephone.Size = new System.Drawing.Size(190, 20);
            this.maskedTextBoxTelephone.TabIndex = 5;
            // 
            // maskedTextBoxCodePostal
            // 
            this.maskedTextBoxCodePostal.Location = new System.Drawing.Point(82, 90);
            this.maskedTextBoxCodePostal.Mask = "00000";
            this.maskedTextBoxCodePostal.Name = "maskedTextBoxCodePostal";
            this.maskedTextBoxCodePostal.Size = new System.Drawing.Size(190, 20);
            this.maskedTextBoxCodePostal.TabIndex = 3;
            // 
            // FormClient
            // 
            this.AcceptButton = this.buttonEnregistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.maskedTextBoxCodePostal);
            this.Controls.Add(this.maskedTextBoxTelephone);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelListeDesClients);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.labelCodePostal);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.textBoxNom);
            this.Name = "FormClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label labelCodePostal;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelListeDesClients;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelephone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCodePostal;
    }
}