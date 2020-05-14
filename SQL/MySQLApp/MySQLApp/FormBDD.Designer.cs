namespace MySQLApp
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
            this.labelServeur = new System.Windows.Forms.Label();
            this.labelBDD = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxBDD = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEtatBDD = new System.Windows.Forms.Label();
            this.textBoxBDDLogs = new System.Windows.Forms.TextBox();
            this.buttonRecherche = new System.Windows.Forms.Button();
            this.buttonCommandes = new System.Windows.Forms.Button();
            this.buttonCreation = new System.Windows.Forms.Button();
            this.buttonSuppression = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelServeur
            // 
            this.labelServeur.AutoSize = true;
            this.labelServeur.Location = new System.Drawing.Point(33, 39);
            this.labelServeur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServeur.Name = "labelServeur";
            this.labelServeur.Size = new System.Drawing.Size(58, 20);
            this.labelServeur.TabIndex = 0;
            this.labelServeur.Text = "Serveur";
            // 
            // labelBDD
            // 
            this.labelBDD.AutoSize = true;
            this.labelBDD.Location = new System.Drawing.Point(33, 81);
            this.labelBDD.Name = "labelBDD";
            this.labelBDD.Size = new System.Drawing.Size(121, 20);
            this.labelBDD.TabIndex = 1;
            this.labelBDD.Text = "Base de données";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(188, 39);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(227, 27);
            this.textBoxServer.TabIndex = 2;
            // 
            // textBoxBDD
            // 
            this.textBoxBDD.Location = new System.Drawing.Point(188, 81);
            this.textBoxBDD.Name = "textBoxBDD";
            this.textBoxBDD.Size = new System.Drawing.Size(227, 27);
            this.textBoxBDD.TabIndex = 3;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(37, 146);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(117, 30);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connexion";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(328, 146);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(117, 30);
            this.buttonQuit.TabIndex = 5;
            this.buttonQuit.Text = "Quitter";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(188, 146);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(117, 30);
            this.buttonDisconnect.TabIndex = 6;
            this.buttonDisconnect.Text = "Déconnexion";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Etat de la connection";
            // 
            // labelEtatBDD
            // 
            this.labelEtatBDD.AutoSize = true;
            this.labelEtatBDD.Location = new System.Drawing.Point(238, 301);
            this.labelEtatBDD.Name = "labelEtatBDD";
            this.labelEtatBDD.Size = new System.Drawing.Size(27, 20);
            this.labelEtatBDD.TabIndex = 8;
            this.labelEtatBDD.Text = "---";
            // 
            // textBoxBDDLogs
            // 
            this.textBoxBDDLogs.Location = new System.Drawing.Point(41, 350);
            this.textBoxBDDLogs.Multiline = true;
            this.textBoxBDDLogs.Name = "textBoxBDDLogs";
            this.textBoxBDDLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBDDLogs.Size = new System.Drawing.Size(374, 185);
            this.textBoxBDDLogs.TabIndex = 9;
            // 
            // buttonRecherche
            // 
            this.buttonRecherche.Location = new System.Drawing.Point(37, 206);
            this.buttonRecherche.Name = "buttonRecherche";
            this.buttonRecherche.Size = new System.Drawing.Size(117, 30);
            this.buttonRecherche.TabIndex = 10;
            this.buttonRecherche.Text = "Fournisseurs";
            this.buttonRecherche.UseVisualStyleBackColor = true;
            this.buttonRecherche.Click += new System.EventHandler(this.buttonRecherche_Click);
            // 
            // buttonCommandes
            // 
            this.buttonCommandes.Location = new System.Drawing.Point(188, 206);
            this.buttonCommandes.Name = "buttonCommandes";
            this.buttonCommandes.Size = new System.Drawing.Size(117, 30);
            this.buttonCommandes.TabIndex = 11;
            this.buttonCommandes.Text = "Commandes";
            this.buttonCommandes.UseVisualStyleBackColor = true;
            this.buttonCommandes.Click += new System.EventHandler(this.buttonCommandes_Click);
            // 
            // buttonCreation
            // 
            this.buttonCreation.Location = new System.Drawing.Point(328, 206);
            this.buttonCreation.Name = "buttonCreation";
            this.buttonCreation.Size = new System.Drawing.Size(117, 30);
            this.buttonCreation.TabIndex = 12;
            this.buttonCreation.Text = "Creation";
            this.buttonCreation.UseVisualStyleBackColor = true;
            this.buttonCreation.Click += new System.EventHandler(this.buttonCreation_Click);
            // 
            // buttonSuppression
            // 
            this.buttonSuppression.Location = new System.Drawing.Point(37, 258);
            this.buttonSuppression.Name = "buttonSuppression";
            this.buttonSuppression.Size = new System.Drawing.Size(117, 30);
            this.buttonSuppression.TabIndex = 13;
            this.buttonSuppression.Text = "Suppression";
            this.buttonSuppression.UseVisualStyleBackColor = true;
            this.buttonSuppression.Click += new System.EventHandler(this.buttonSuppression_Click);
            // 
            // FormBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 569);
            this.Controls.Add(this.buttonSuppression);
            this.Controls.Add(this.buttonCreation);
            this.Controls.Add(this.buttonCommandes);
            this.Controls.Add(this.buttonRecherche);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.textBoxBDDLogs);
            this.Controls.Add(this.labelEtatBDD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxBDD);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.labelBDD);
            this.Controls.Add(this.labelServeur);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBDD";
            this.Text = "Connection à la BDD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelServeur;
        private System.Windows.Forms.Label labelBDD;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.TextBox textBoxBDD;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEtatBDD;
        private System.Windows.Forms.TextBox textBoxBDDLogs;
        private System.Windows.Forms.Button buttonRecherche;
        private System.Windows.Forms.Button buttonCommandes;
        private System.Windows.Forms.Button buttonCreation;
        private System.Windows.Forms.Button buttonSuppression;
    }
}

