namespace BControlUtilisateursProduction
{
    partial class UCPageProduction
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NbCaisseDepuisDemarrage = new System.Windows.Forms.TextBox();
            this.TauxDefautHeure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TauxDefaultDepuisDemarrage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NbErreurs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de caisse depuis le demarrage";
            // 
            // NbCaisseDepuisDemarrage
            // 
            this.NbCaisseDepuisDemarrage.Location = new System.Drawing.Point(324, 22);
            this.NbCaisseDepuisDemarrage.Name = "NbCaisseDepuisDemarrage";
            this.NbCaisseDepuisDemarrage.Size = new System.Drawing.Size(130, 20);
            this.NbCaisseDepuisDemarrage.TabIndex = 1;
            // 
            // TauxDefautHeure
            // 
            this.TauxDefautHeure.Location = new System.Drawing.Point(324, 108);
            this.TauxDefautHeure.Name = "TauxDefautHeure";
            this.TauxDefautHeure.Size = new System.Drawing.Size(130, 20);
            this.TauxDefautHeure.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Taux défaut heure";
            // 
            // TauxDefaultDepuisDemarrage
            // 
            this.TauxDefaultDepuisDemarrage.Location = new System.Drawing.Point(324, 162);
            this.TauxDefaultDepuisDemarrage.Name = "TauxDefaultDepuisDemarrage";
            this.TauxDefaultDepuisDemarrage.Size = new System.Drawing.Size(130, 20);
            this.TauxDefaultDepuisDemarrage.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Taux défault depuis démarrage";
            // 
            // NbErreurs
            // 
            this.NbErreurs.Location = new System.Drawing.Point(324, 61);
            this.NbErreurs.Name = "NbErreurs";
            this.NbErreurs.Size = new System.Drawing.Size(130, 20);
            this.NbErreurs.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre d\'erreurs";
            // 
            // TabPageProduction
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this.NbErreurs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TauxDefaultDepuisDemarrage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TauxDefautHeure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NbCaisseDepuisDemarrage);
            this.Controls.Add(this.label1);
            this.Name = "TabPageProduction";
            this.Size = new System.Drawing.Size(532, 197);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NbCaisseDepuisDemarrage;
        private System.Windows.Forms.TextBox TauxDefautHeure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TauxDefaultDepuisDemarrage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NbErreurs;
        private System.Windows.Forms.Label label4;
    }
}
