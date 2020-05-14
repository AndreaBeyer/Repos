namespace BControlUtilisateursProduction
{
    partial class UCProgressionProduction
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
            this.labelNomProduction = new System.Windows.Forms.Label();
            this.progressBarProduction = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // labelNomProduction
            // 
            this.labelNomProduction.AutoSize = true;
            this.labelNomProduction.Location = new System.Drawing.Point(14, 26);
            this.labelNomProduction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomProduction.Name = "labelNomProduction";
            this.labelNomProduction.Size = new System.Drawing.Size(58, 13);
            this.labelNomProduction.TabIndex = 0;
            this.labelNomProduction.Text = "Production";
            // 
            // progressBarProduction
            // 
            this.progressBarProduction.Location = new System.Drawing.Point(99, 19);
            this.progressBarProduction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBarProduction.Name = "progressBarProduction";
            this.progressBarProduction.Size = new System.Drawing.Size(559, 23);
            this.progressBarProduction.TabIndex = 1;
            // 
            // UCProgressionProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBarProduction);
            this.Controls.Add(this.labelNomProduction);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCProgressionProduction";
            this.Size = new System.Drawing.Size(688, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomProduction;
        private System.Windows.Forms.ProgressBar progressBarProduction;
    }
}
