namespace MySQLApp
{
    partial class ListeCommandes
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFournisseurs = new System.Windows.Forms.ComboBox();
            this.listBoxCommandes = new System.Windows.Forms.ListBox();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisir un fournisseur";
            // 
            // comboBoxFournisseurs
            // 
            this.comboBoxFournisseurs.FormattingEnabled = true;
            this.comboBoxFournisseurs.Location = new System.Drawing.Point(155, 31);
            this.comboBoxFournisseurs.Name = "comboBoxFournisseurs";
            this.comboBoxFournisseurs.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFournisseurs.TabIndex = 1;
            this.comboBoxFournisseurs.SelectedIndexChanged += new System.EventHandler(this.comboBoxFournisseurs_SelectedIndexChanged);
            // 
            // listBoxCommandes
            // 
            this.listBoxCommandes.FormattingEnabled = true;
            this.listBoxCommandes.Location = new System.Drawing.Point(28, 71);
            this.listBoxCommandes.Name = "listBoxCommandes";
            this.listBoxCommandes.Size = new System.Drawing.Size(248, 95);
            this.listBoxCommandes.TabIndex = 2;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(168, 193);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(108, 23);
            this.buttonQuitter.TabIndex = 3;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // ListeCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 238);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.listBoxCommandes);
            this.Controls.Add(this.comboBoxFournisseurs);
            this.Controls.Add(this.label1);
            this.Name = "ListeCommandes";
            this.Text = "Liste des Commandes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFournisseurs;
        private System.Windows.Forms.ListBox listBoxCommandes;
        private System.Windows.Forms.Button buttonQuitter;
    }
}