namespace ToutEmbal__
{
    
    partial class FormProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProd));
            this.menuStripProd = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterProductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrêterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.continuerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAddCaisse = new System.Windows.Forms.Panel();
            this.buttonQuitterAdd = new System.Windows.Forms.Button();
            this.buttonAddCaisse = new System.Windows.Forms.Button();
            this.ucAddCaisseQuest = new BControlUtilisateursProduction.UCAddProduction();
            this.tabControlProd = new System.Windows.Forms.TabControl();
            this.panelProgressBar = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStripProd = new System.Windows.Forms.StatusStrip();
            this.labelHorloge = new System.Windows.Forms.Label();
            this.menuStripProd.SuspendLayout();
            this.panelAddCaisse.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripProd
            // 
            this.menuStripProd.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripProd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.productionToolStripMenuItem});
            this.menuStripProd.Location = new System.Drawing.Point(0, 0);
            this.menuStripProd.Name = "menuStripProd";
            this.menuStripProd.Size = new System.Drawing.Size(1244, 25);
            this.menuStripProd.TabIndex = 3;
            this.menuStripProd.Text = "menuStripProd";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterProductionToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.chargerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ajouterProductionToolStripMenuItem
            // 
            this.ajouterProductionToolStripMenuItem.Name = "ajouterProductionToolStripMenuItem";
            this.ajouterProductionToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ajouterProductionToolStripMenuItem.Text = "Ajouter production";
            this.ajouterProductionToolStripMenuItem.Click += new System.EventHandler(this.ajouterProductionToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // chargerToolStripMenuItem
            // 
            this.chargerToolStripMenuItem.Name = "chargerToolStripMenuItem";
            this.chargerToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.chargerToolStripMenuItem.Text = "Charger";
            this.chargerToolStripMenuItem.Click += new System.EventHandler(this.chargerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demarrerToolStripMenuItem,
            this.arrêterToolStripMenuItem,
            this.continuerToolStripMenuItem});
            this.productionToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(91, 21);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // demarrerToolStripMenuItem
            // 
            this.demarrerToolStripMenuItem.Name = "demarrerToolStripMenuItem";
            this.demarrerToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.demarrerToolStripMenuItem.Text = "Démarrer";
            // 
            // arrêterToolStripMenuItem
            // 
            this.arrêterToolStripMenuItem.Name = "arrêterToolStripMenuItem";
            this.arrêterToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.arrêterToolStripMenuItem.Text = "Arrêter";
            // 
            // continuerToolStripMenuItem
            // 
            this.continuerToolStripMenuItem.Name = "continuerToolStripMenuItem";
            this.continuerToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.continuerToolStripMenuItem.Text = "Continuer";
            // 
            // panelAddCaisse
            // 
            this.panelAddCaisse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddCaisse.Controls.Add(this.buttonQuitterAdd);
            this.panelAddCaisse.Controls.Add(this.buttonAddCaisse);
            this.panelAddCaisse.Controls.Add(this.ucAddCaisseQuest);
            this.panelAddCaisse.Location = new System.Drawing.Point(13, 44);
            this.panelAddCaisse.Name = "panelAddCaisse";
            this.panelAddCaisse.Size = new System.Drawing.Size(246, 203);
            this.panelAddCaisse.TabIndex = 5;
            // 
            // buttonQuitterAdd
            // 
            this.buttonQuitterAdd.Location = new System.Drawing.Point(141, 157);
            this.buttonQuitterAdd.Name = "buttonQuitterAdd";
            this.buttonQuitterAdd.Size = new System.Drawing.Size(81, 29);
            this.buttonQuitterAdd.TabIndex = 6;
            this.buttonQuitterAdd.Text = "Quitter";
            this.buttonQuitterAdd.UseVisualStyleBackColor = true;
            this.buttonQuitterAdd.Click += new System.EventHandler(this.buttonQuitterAdd_Click);
            // 
            // buttonAddCaisse
            // 
            this.buttonAddCaisse.Location = new System.Drawing.Point(32, 157);
            this.buttonAddCaisse.Name = "buttonAddCaisse";
            this.buttonAddCaisse.Size = new System.Drawing.Size(82, 29);
            this.buttonAddCaisse.TabIndex = 5;
            this.buttonAddCaisse.Text = "Ajouter";
            this.buttonAddCaisse.UseVisualStyleBackColor = true;
            this.buttonAddCaisse.Click += new System.EventHandler(this.buttonAddCaisse_Click);
            // 
            // ucAddCaisseQuest
            // 
            this.ucAddCaisseQuest.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAddCaisseQuest.Location = new System.Drawing.Point(7, 15);
            this.ucAddCaisseQuest.Margin = new System.Windows.Forms.Padding(4);
            this.ucAddCaisseQuest.Name = "ucAddCaisseQuest";
            this.ucAddCaisseQuest.NbCaisseToAdd = "";
            this.ucAddCaisseQuest.Size = new System.Drawing.Size(235, 125);
            this.ucAddCaisseQuest.TabIndex = 4;
            this.ucAddCaisseQuest.TypeCaisseToAdd = "";
            // 
            // tabControlProd
            // 
            this.tabControlProd.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlProd.Location = new System.Drawing.Point(370, 83);
            this.tabControlProd.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlProd.Name = "tabControlProd";
            this.tabControlProd.SelectedIndex = 0;
            this.tabControlProd.Size = new System.Drawing.Size(653, 298);
            this.tabControlProd.TabIndex = 0;
            // 
            // panelProgressBar
            // 
            this.panelProgressBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelProgressBar.AutoScroll = true;
            this.panelProgressBar.Location = new System.Drawing.Point(120, 427);
            this.panelProgressBar.Name = "panelProgressBar";
            this.panelProgressBar.Size = new System.Drawing.Size(1001, 219);
            this.panelProgressBar.TabIndex = 7;
            // 
            // statusStripProd
            // 
            this.statusStripProd.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.statusStripProd.Location = new System.Drawing.Point(0, 763);
            this.statusStripProd.Name = "statusStripProd";
            this.statusStripProd.Size = new System.Drawing.Size(1244, 22);
            this.statusStripProd.TabIndex = 8;
            this.statusStripProd.Text = "statusStrip1";
            // 
            // labelHorloge
            // 
            this.labelHorloge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHorloge.AutoSize = true;
            this.labelHorloge.Location = new System.Drawing.Point(1168, 737);
            this.labelHorloge.Name = "labelHorloge";
            this.labelHorloge.Size = new System.Drawing.Size(64, 17);
            this.labelHorloge.TabIndex = 9;
            this.labelHorloge.Text = "00:00:00";
            // 
            // FormProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1244, 785);
            this.Controls.Add(this.labelHorloge);
            this.Controls.Add(this.statusStripProd);
            this.Controls.Add(this.panelProgressBar);
            this.Controls.Add(this.panelAddCaisse);
            this.Controls.Add(this.tabControlProd);
            this.Controls.Add(this.menuStripProd);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripProd;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production des caisses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProd_FormClosing);
            this.menuStripProd.ResumeLayout(false);
            this.menuStripProd.PerformLayout();
            this.panelAddCaisse.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripProd;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demarrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrêterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continuerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterProductionToolStripMenuItem;
        private BControlUtilisateursProduction.UCAddProduction ucAddCaisseQuest;
        private System.Windows.Forms.Panel panelAddCaisse;
        private System.Windows.Forms.Button buttonAddCaisse;
        private System.Windows.Forms.TabControl tabControlProd;
        private System.Windows.Forms.FlowLayoutPanel panelProgressBar;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripProd;
        private System.Windows.Forms.Label labelHorloge;
        private System.Windows.Forms.Button buttonQuitterAdd;
    }
}

