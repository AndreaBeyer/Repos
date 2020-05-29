namespace Papyrus
{
    partial class FormBDD
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
            this.labelServer = new System.Windows.Forms.Label();
            this.labelBDD = new System.Windows.Forms.Label();
            this.labelConnexionTitle = new System.Windows.Forms.Label();
            this.labelStateConnexion = new System.Windows.Forms.Label();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonSuppression = new System.Windows.Forms.Button();
            this.buttonCommandes = new System.Windows.Forms.Button();
            this.buttonDeconnexion = new System.Windows.Forms.Button();
            this.buttonCreation = new System.Windows.Forms.Button();
            this.buttonFournisseurs = new System.Windows.Forms.Button();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxBDD = new System.Windows.Forms.TextBox();
            this.textBoxLogs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServer.Location = new System.Drawing.Point(27, 31);
            this.labelServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(58, 20);
            this.labelServer.TabIndex = 0;
            this.labelServer.Text = "Serveur";
            // 
            // labelBDD
            // 
            this.labelBDD.AutoSize = true;
            this.labelBDD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBDD.Location = new System.Drawing.Point(27, 74);
            this.labelBDD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBDD.Name = "labelBDD";
            this.labelBDD.Size = new System.Drawing.Size(121, 20);
            this.labelBDD.TabIndex = 1;
            this.labelBDD.Text = "Base de données";
            // 
            // labelConnexionTitle
            // 
            this.labelConnexionTitle.AutoSize = true;
            this.labelConnexionTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnexionTitle.Location = new System.Drawing.Point(27, 241);
            this.labelConnexionTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConnexionTitle.Name = "labelConnexionTitle";
            this.labelConnexionTitle.Size = new System.Drawing.Size(144, 20);
            this.labelConnexionTitle.TabIndex = 2;
            this.labelConnexionTitle.Text = "Etat de la connexion";
            // 
            // labelStateConnexion
            // 
            this.labelStateConnexion.AutoSize = true;
            this.labelStateConnexion.Location = new System.Drawing.Point(196, 241);
            this.labelStateConnexion.Name = "labelStateConnexion";
            this.labelStateConnexion.Size = new System.Drawing.Size(27, 20);
            this.labelStateConnexion.TabIndex = 3;
            this.labelStateConnexion.Text = "---";
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(31, 113);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(117, 33);
            this.buttonConnexion.TabIndex = 10;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(277, 113);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(117, 33);
            this.buttonQuitter.TabIndex = 11;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // buttonSuppression
            // 
            this.buttonSuppression.Location = new System.Drawing.Point(154, 191);
            this.buttonSuppression.Name = "buttonSuppression";
            this.buttonSuppression.Size = new System.Drawing.Size(117, 33);
            this.buttonSuppression.TabIndex = 12;
            this.buttonSuppression.Text = "Suppression";
            this.buttonSuppression.UseVisualStyleBackColor = true;
            this.buttonSuppression.Click += new System.EventHandler(this.buttonSuppression_Click);
            // 
            // buttonCommandes
            // 
            this.buttonCommandes.Location = new System.Drawing.Point(154, 152);
            this.buttonCommandes.Name = "buttonCommandes";
            this.buttonCommandes.Size = new System.Drawing.Size(117, 33);
            this.buttonCommandes.TabIndex = 13;
            this.buttonCommandes.Text = "Commandes";
            this.buttonCommandes.UseVisualStyleBackColor = true;
            this.buttonCommandes.Click += new System.EventHandler(this.buttonCommandes_Click);
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.Location = new System.Drawing.Point(154, 113);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(117, 33);
            this.buttonDeconnexion.TabIndex = 14;
            this.buttonDeconnexion.Text = "Déconnexion";
            this.buttonDeconnexion.UseVisualStyleBackColor = true;
            this.buttonDeconnexion.Click += new System.EventHandler(this.buttonDeconnexion_Click);
            // 
            // buttonCreation
            // 
            this.buttonCreation.Location = new System.Drawing.Point(31, 191);
            this.buttonCreation.Name = "buttonCreation";
            this.buttonCreation.Size = new System.Drawing.Size(117, 33);
            this.buttonCreation.TabIndex = 15;
            this.buttonCreation.Text = "Création";
            this.buttonCreation.UseVisualStyleBackColor = true;
            this.buttonCreation.Click += new System.EventHandler(this.buttonCreation_Click);
            // 
            // buttonFournisseurs
            // 
            this.buttonFournisseurs.Location = new System.Drawing.Point(31, 152);
            this.buttonFournisseurs.Name = "buttonFournisseurs";
            this.buttonFournisseurs.Size = new System.Drawing.Size(117, 33);
            this.buttonFournisseurs.TabIndex = 16;
            this.buttonFournisseurs.Text = "Fournisseurs";
            this.buttonFournisseurs.UseVisualStyleBackColor = true;
            this.buttonFournisseurs.Click += new System.EventHandler(this.buttonFournisseurs_Click);
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(154, 24);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(240, 27);
            this.textBoxServer.TabIndex = 17;
            // 
            // textBoxBDD
            // 
            this.textBoxBDD.Location = new System.Drawing.Point(155, 67);
            this.textBoxBDD.Name = "textBoxBDD";
            this.textBoxBDD.Size = new System.Drawing.Size(239, 27);
            this.textBoxBDD.TabIndex = 18;
            // 
            // textBoxLogs
            // 
            this.textBoxLogs.Location = new System.Drawing.Point(31, 279);
            this.textBoxLogs.Multiline = true;
            this.textBoxLogs.Name = "textBoxLogs";
            this.textBoxLogs.ReadOnly = true;
            this.textBoxLogs.Size = new System.Drawing.Size(363, 121);
            this.textBoxLogs.TabIndex = 19;
            // 
            // FormBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 412);
            this.Controls.Add(this.textBoxLogs);
            this.Controls.Add(this.textBoxBDD);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.buttonFournisseurs);
            this.Controls.Add(this.buttonCreation);
            this.Controls.Add(this.buttonDeconnexion);
            this.Controls.Add(this.buttonCommandes);
            this.Controls.Add(this.buttonSuppression);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.labelStateConnexion);
            this.Controls.Add(this.labelConnexionTitle);
            this.Controls.Add(this.labelBDD);
            this.Controls.Add(this.labelServer);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBDD";
            this.Text = "Connexion à la BDD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Label labelBDD;
        private System.Windows.Forms.Label labelConnexionTitle;
        private System.Windows.Forms.Label labelStateConnexion;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonSuppression;
        private System.Windows.Forms.Button buttonCommandes;
        private System.Windows.Forms.Button buttonDeconnexion;
        private System.Windows.Forms.Button buttonCreation;
        private System.Windows.Forms.Button buttonFournisseurs;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.TextBox textBoxBDD;
        private System.Windows.Forms.TextBox textBoxLogs;
    }
}

