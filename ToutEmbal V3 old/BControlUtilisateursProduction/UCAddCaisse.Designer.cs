namespace BControlUtilisateursProduction
{
    partial class UCAddCaisse
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
            this.textBoxNbCaisse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoTypeCaisse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNbCaisse
            // 
            this.textBoxNbCaisse.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNbCaisse.Location = new System.Drawing.Point(161, 84);
            this.textBoxNbCaisse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNbCaisse.Name = "textBoxNbCaisse";
            this.textBoxNbCaisse.Size = new System.Drawing.Size(58, 25);
            this.textBoxNbCaisse.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 63);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre de caisses à produire";
            // 
            // textBoTypeCaisse
            // 
            this.textBoTypeCaisse.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoTypeCaisse.Location = new System.Drawing.Point(161, 25);
            this.textBoTypeCaisse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoTypeCaisse.Name = "textBoTypeCaisse";
            this.textBoTypeCaisse.Size = new System.Drawing.Size(58, 25);
            this.textBoTypeCaisse.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Type de caisse";
            // 
            // UCAddCaisse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxNbCaisse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoTypeCaisse);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCAddCaisse";
            this.Size = new System.Drawing.Size(235, 153);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNbCaisse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoTypeCaisse;
        private System.Windows.Forms.Label label1;
    }
}
