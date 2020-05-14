namespace MySQLApp
{
    partial class AffichageFournisseur
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
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxSatisfaction = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.buttonMAJ = new System.Windows.Forms.Button();
            this.textBoxNumRue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(198, 46);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(170, 20);
            this.textBoxNom.TabIndex = 0;
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(268, 127);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(100, 20);
            this.textBoxVille.TabIndex = 1;
            // 
            // textBoxSatisfaction
            // 
            this.textBoxSatisfaction.Location = new System.Drawing.Point(198, 205);
            this.textBoxSatisfaction.Name = "textBoxSatisfaction";
            this.textBoxSatisfaction.Size = new System.Drawing.Size(37, 20);
            this.textBoxSatisfaction.TabIndex = 2;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(198, 166);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(170, 20);
            this.textBoxContact.TabIndex = 3;
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(198, 127);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(64, 20);
            this.textBoxCP.TabIndex = 4;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(236, 83);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(132, 20);
            this.textBoxAdresse.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CP / Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Satisfaction";
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(293, 266);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(75, 23);
            this.buttonRetour.TabIndex = 11;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // buttonMAJ
            // 
            this.buttonMAJ.Location = new System.Drawing.Point(187, 266);
            this.buttonMAJ.Name = "buttonMAJ";
            this.buttonMAJ.Size = new System.Drawing.Size(75, 23);
            this.buttonMAJ.TabIndex = 12;
            this.buttonMAJ.Text = "MAJ";
            this.buttonMAJ.UseVisualStyleBackColor = true;
            this.buttonMAJ.Click += new System.EventHandler(this.buttonMAJ_Click);
            // 
            // textBoxNumRue
            // 
            this.textBoxNumRue.Location = new System.Drawing.Point(198, 83);
            this.textBoxNumRue.Name = "textBoxNumRue";
            this.textBoxNumRue.Size = new System.Drawing.Size(32, 20);
            this.textBoxNumRue.TabIndex = 13;
            // 
            // AffichageFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(423, 320);
            this.Controls.Add(this.textBoxNumRue);
            this.Controls.Add(this.buttonMAJ);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.textBoxSatisfaction);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxNom);
            this.MaximizeBox = false;
            this.Name = "AffichageFournisseur";
            this.Text = "Affichage Fournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxSatisfaction;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Button buttonMAJ;
        private System.Windows.Forms.TextBox textBoxNumRue;
    }
}