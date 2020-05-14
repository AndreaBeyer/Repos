namespace TreeView
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TreeViewArborescence = new System.Windows.Forms.TreeView();
            this.ButtonExpansionArbre = new System.Windows.Forms.Button();
            this.ButtonAffichageDiscDur = new System.Windows.Forms.Button();
            this.ButtonReductionArbre = new System.Windows.Forms.Button();
            this.TextBoxChemin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TreeViewArborescence
            // 
            this.TreeViewArborescence.Location = new System.Drawing.Point(53, 84);
            this.TreeViewArborescence.Name = "TreeViewArborescence";
            this.TreeViewArborescence.Size = new System.Drawing.Size(675, 284);
            this.TreeViewArborescence.TabIndex = 0;
            this.TreeViewArborescence.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewArborescence_NodeMouseClick);
            // 
            // ButtonExpansionArbre
            // 
            this.ButtonExpansionArbre.Location = new System.Drawing.Point(132, 385);
            this.ButtonExpansionArbre.Name = "ButtonExpansionArbre";
            this.ButtonExpansionArbre.Size = new System.Drawing.Size(144, 43);
            this.ButtonExpansionArbre.TabIndex = 1;
            this.ButtonExpansionArbre.Text = "Expansion de l\'arbre";
            this.ButtonExpansionArbre.UseVisualStyleBackColor = true;
            // 
            // ButtonAffichageDiscDur
            // 
            this.ButtonAffichageDiscDur.Location = new System.Drawing.Point(132, 12);
            this.ButtonAffichageDiscDur.Name = "ButtonAffichageDiscDur";
            this.ButtonAffichageDiscDur.Size = new System.Drawing.Size(144, 43);
            this.ButtonAffichageDiscDur.TabIndex = 2;
            this.ButtonAffichageDiscDur.Text = "Affichage du disque dur";
            this.ButtonAffichageDiscDur.UseVisualStyleBackColor = true;
            // 
            // ButtonReductionArbre
            // 
            this.ButtonReductionArbre.Location = new System.Drawing.Point(454, 385);
            this.ButtonReductionArbre.Name = "ButtonReductionArbre";
            this.ButtonReductionArbre.Size = new System.Drawing.Size(144, 43);
            this.ButtonReductionArbre.TabIndex = 3;
            this.ButtonReductionArbre.Text = "Reduction de l\'arbre";
            this.ButtonReductionArbre.UseVisualStyleBackColor = true;
            // 
            // TextBoxChemin
            // 
            this.TextBoxChemin.Location = new System.Drawing.Point(477, 24);
            this.TextBoxChemin.Name = "TextBoxChemin";
            this.TextBoxChemin.Size = new System.Drawing.Size(251, 20);
            this.TextBoxChemin.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(371, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chemin du dossier à examiner";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxChemin);
            this.Controls.Add(this.ButtonReductionArbre);
            this.Controls.Add(this.ButtonAffichageDiscDur);
            this.Controls.Add(this.ButtonExpansionArbre);
            this.Controls.Add(this.TreeViewArborescence);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeViewArborescence;
        private System.Windows.Forms.Button ButtonExpansionArbre;
        private System.Windows.Forms.Button ButtonAffichageDiscDur;
        private System.Windows.Forms.Button ButtonReductionArbre;
        private System.Windows.Forms.TextBox TextBoxChemin;
        private System.Windows.Forms.Label label1;
    }
}

