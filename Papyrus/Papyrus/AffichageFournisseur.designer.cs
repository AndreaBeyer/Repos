namespace Papyrus
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxNumRue = new System.Windows.Forms.TextBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxSatisfaction = new System.Windows.Forms.TextBox();
            this.textBoxRue = new System.Windows.Forms.TextBox();
            this.buttonMAJ = new System.Windows.Forms.Button();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CP / Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Satisfaction";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(117, 37);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(206, 27);
            this.textBoxNom.TabIndex = 5;
            // 
            // textBoxNumRue
            // 
            this.textBoxNumRue.Location = new System.Drawing.Point(117, 73);
            this.textBoxNumRue.Name = "textBoxNumRue";
            this.textBoxNumRue.Size = new System.Drawing.Size(53, 27);
            this.textBoxNumRue.TabIndex = 6;
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(117, 108);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(85, 27);
            this.textBoxCP.TabIndex = 7;
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(208, 108);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(115, 27);
            this.textBoxVille.TabIndex = 8;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(117, 147);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(206, 27);
            this.textBoxContact.TabIndex = 9;
            // 
            // textBoxSatisfaction
            // 
            this.textBoxSatisfaction.Location = new System.Drawing.Point(117, 184);
            this.textBoxSatisfaction.Name = "textBoxSatisfaction";
            this.textBoxSatisfaction.Size = new System.Drawing.Size(53, 27);
            this.textBoxSatisfaction.TabIndex = 10;
            // 
            // textBoxRue
            // 
            this.textBoxRue.Location = new System.Drawing.Point(176, 73);
            this.textBoxRue.Name = "textBoxRue";
            this.textBoxRue.Size = new System.Drawing.Size(147, 27);
            this.textBoxRue.TabIndex = 11;
            // 
            // buttonMAJ
            // 
            this.buttonMAJ.Location = new System.Drawing.Point(117, 245);
            this.buttonMAJ.Name = "buttonMAJ";
            this.buttonMAJ.Size = new System.Drawing.Size(109, 33);
            this.buttonMAJ.TabIndex = 13;
            this.buttonMAJ.Text = "MAJ";
            this.buttonMAJ.UseVisualStyleBackColor = true;
            this.buttonMAJ.Click += new System.EventHandler(this.buttonMAJ_Click);
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(232, 245);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(109, 33);
            this.buttonRetour.TabIndex = 14;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // AffichageFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 334);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.buttonMAJ);
            this.Controls.Add(this.textBoxRue);
            this.Controls.Add(this.textBoxSatisfaction);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.textBoxNumRue);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AffichageFournisseur";
            this.Text = "Affichage du Fournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxNumRue;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxSatisfaction;
        private System.Windows.Forms.TextBox textBoxRue;
        private System.Windows.Forms.Button buttonMAJ;
        private System.Windows.Forms.Button buttonRetour;
    }
}