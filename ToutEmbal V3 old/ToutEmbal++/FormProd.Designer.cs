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
            this.tabControlProd = new System.Windows.Forms.TabControl();
            this.tabPageA = new System.Windows.Forms.TabPage();
            this.tabPageB = new System.Windows.Forms.TabPage();
            this.tabPageC = new System.Windows.Forms.TabPage();
            this.menuStripProd = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterProductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.démarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemStartA = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemStartB = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemStartC = new System.Windows.Forms.ToolStripMenuItem();
            this.arrêterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemStopA = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemStopB = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemStopC = new System.Windows.Forms.ToolStripMenuItem();
            this.continuerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemContinueA = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemContinueB = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemContinueC = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAddCaisse = new System.Windows.Forms.Panel();
            this.ucAddCaisseQuest = new BControlUtilisateursProduction.UCAddCaisse();
            this.ProgressionProductionB = new BControlUtilisateursProduction.UCProgressionProduction();
            this.ProgressionProductionC = new BControlUtilisateursProduction.UCProgressionProduction();
            this.ProgressionProductionA = new BControlUtilisateursProduction.UCProgressionProduction();
            this.tabPageProductionA = new BControlUtilisateursProduction.TabPageProduction();
            this.tabPageProductionB = new BControlUtilisateursProduction.TabPageProduction();
            this.tabPageProductionC = new BControlUtilisateursProduction.TabPageProduction();
            this.buttonAddCaisse = new System.Windows.Forms.Button();
            this.tabControlProd.SuspendLayout();
            this.tabPageA.SuspendLayout();
            this.tabPageB.SuspendLayout();
            this.tabPageC.SuspendLayout();
            this.menuStripProd.SuspendLayout();
            this.panelAddCaisse.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlProd
            // 
            this.tabControlProd.Controls.Add(this.tabPageA);
            this.tabControlProd.Controls.Add(this.tabPageB);
            this.tabControlProd.Controls.Add(this.tabPageC);
            this.tabControlProd.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlProd.Location = new System.Drawing.Point(370, 83);
            this.tabControlProd.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlProd.Name = "tabControlProd";
            this.tabControlProd.SelectedIndex = 0;
            this.tabControlProd.Size = new System.Drawing.Size(653, 298);
            this.tabControlProd.TabIndex = 0;
            // 
            // tabPageA
            // 
            this.tabPageA.Controls.Add(this.tabPageProductionA);
            this.tabPageA.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageA.Location = new System.Drawing.Point(4, 26);
            this.tabPageA.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageA.Name = "tabPageA";
            this.tabPageA.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageA.Size = new System.Drawing.Size(645, 268);
            this.tabPageA.TabIndex = 0;
            this.tabPageA.Text = "Type A";
            this.tabPageA.UseVisualStyleBackColor = true;
            // 
            // tabPageB
            // 
            this.tabPageB.Controls.Add(this.tabPageProductionB);
            this.tabPageB.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageB.Location = new System.Drawing.Point(4, 26);
            this.tabPageB.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageB.Name = "tabPageB";
            this.tabPageB.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageB.Size = new System.Drawing.Size(645, 268);
            this.tabPageB.TabIndex = 1;
            this.tabPageB.Text = "Type B";
            this.tabPageB.UseVisualStyleBackColor = true;
            // 
            // tabPageC
            // 
            this.tabPageC.Controls.Add(this.tabPageProductionC);
            this.tabPageC.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageC.Location = new System.Drawing.Point(4, 26);
            this.tabPageC.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageC.Name = "tabPageC";
            this.tabPageC.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageC.Size = new System.Drawing.Size(645, 268);
            this.tabPageC.TabIndex = 2;
            this.tabPageC.Text = "Type C";
            this.tabPageC.UseVisualStyleBackColor = true;
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
            this.démarrerToolStripMenuItem,
            this.arrêterToolStripMenuItem,
            this.continuerToolStripMenuItem});
            this.productionToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(91, 21);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // démarrerToolStripMenuItem
            // 
            this.démarrerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemStartA,
            this.ToolStripMenuItemStartB,
            this.ToolStripMenuItemStartC});
            this.démarrerToolStripMenuItem.Name = "démarrerToolStripMenuItem";
            this.démarrerToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.démarrerToolStripMenuItem.Text = "Démarrer";
            // 
            // ToolStripMenuItemStartA
            // 
            this.ToolStripMenuItemStartA.Name = "ToolStripMenuItemStartA";
            this.ToolStripMenuItemStartA.Size = new System.Drawing.Size(85, 22);
            this.ToolStripMenuItemStartA.Text = "A";
            this.ToolStripMenuItemStartA.Click += new System.EventHandler(this.ToolStripMenuItemStartA_Click);
            // 
            // ToolStripMenuItemStartB
            // 
            this.ToolStripMenuItemStartB.Name = "ToolStripMenuItemStartB";
            this.ToolStripMenuItemStartB.Size = new System.Drawing.Size(85, 22);
            this.ToolStripMenuItemStartB.Text = "B";
            this.ToolStripMenuItemStartB.Click += new System.EventHandler(this.ToolStripMenuItemStartB_Click);
            // 
            // ToolStripMenuItemStartC
            // 
            this.ToolStripMenuItemStartC.Name = "ToolStripMenuItemStartC";
            this.ToolStripMenuItemStartC.Size = new System.Drawing.Size(85, 22);
            this.ToolStripMenuItemStartC.Text = "C";
            this.ToolStripMenuItemStartC.Click += new System.EventHandler(this.ToolStripMenuItemStartC_Click);
            // 
            // arrêterToolStripMenuItem
            // 
            this.arrêterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemStopA,
            this.ToolStripMenuItemStopB,
            this.ToolStripMenuItemStopC});
            this.arrêterToolStripMenuItem.Name = "arrêterToolStripMenuItem";
            this.arrêterToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.arrêterToolStripMenuItem.Text = "Arrêter";
            // 
            // ToolStripMenuItemStopA
            // 
            this.ToolStripMenuItemStopA.Name = "ToolStripMenuItemStopA";
            this.ToolStripMenuItemStopA.Size = new System.Drawing.Size(85, 22);
            this.ToolStripMenuItemStopA.Text = "A";
            this.ToolStripMenuItemStopA.Click += new System.EventHandler(this.ToolStripMenuItemStopA_Click);
            // 
            // ToolStripMenuItemStopB
            // 
            this.ToolStripMenuItemStopB.Name = "ToolStripMenuItemStopB";
            this.ToolStripMenuItemStopB.Size = new System.Drawing.Size(85, 22);
            this.ToolStripMenuItemStopB.Text = "B";
            this.ToolStripMenuItemStopB.Click += new System.EventHandler(this.ToolStripMenuItemStopB_Click);
            // 
            // ToolStripMenuItemStopC
            // 
            this.ToolStripMenuItemStopC.Name = "ToolStripMenuItemStopC";
            this.ToolStripMenuItemStopC.Size = new System.Drawing.Size(85, 22);
            this.ToolStripMenuItemStopC.Text = "C";
            this.ToolStripMenuItemStopC.Click += new System.EventHandler(this.ToolStripMenuItemStopC_Click);
            // 
            // continuerToolStripMenuItem
            // 
            this.continuerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemContinueA,
            this.ToolStripMenuItemContinueB,
            this.ToolStripMenuItemContinueC});
            this.continuerToolStripMenuItem.Name = "continuerToolStripMenuItem";
            this.continuerToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.continuerToolStripMenuItem.Text = "Continuer";
            // 
            // ToolStripMenuItemContinueA
            // 
            this.ToolStripMenuItemContinueA.Name = "ToolStripMenuItemContinueA";
            this.ToolStripMenuItemContinueA.Size = new System.Drawing.Size(85, 22);
            this.ToolStripMenuItemContinueA.Text = "A";
            this.ToolStripMenuItemContinueA.Click += new System.EventHandler(this.ToolStripMenuItemContinueA_Click);
            // 
            // ToolStripMenuItemContinueB
            // 
            this.ToolStripMenuItemContinueB.Name = "ToolStripMenuItemContinueB";
            this.ToolStripMenuItemContinueB.Size = new System.Drawing.Size(85, 22);
            this.ToolStripMenuItemContinueB.Text = "B";
            this.ToolStripMenuItemContinueB.Click += new System.EventHandler(this.ToolStripMenuItemContinueB_Click);
            // 
            // ToolStripMenuItemContinueC
            // 
            this.ToolStripMenuItemContinueC.Name = "ToolStripMenuItemContinueC";
            this.ToolStripMenuItemContinueC.Size = new System.Drawing.Size(85, 22);
            this.ToolStripMenuItemContinueC.Text = "C";
            this.ToolStripMenuItemContinueC.Click += new System.EventHandler(this.ToolStripMenuItemContinueC_Click);
            // 
            // panelAddCaisse
            // 
            this.panelAddCaisse.Controls.Add(this.buttonAddCaisse);
            this.panelAddCaisse.Controls.Add(this.ucAddCaisseQuest);
            this.panelAddCaisse.Location = new System.Drawing.Point(13, 44);
            this.panelAddCaisse.Name = "panelAddCaisse";
            this.panelAddCaisse.Size = new System.Drawing.Size(246, 203);
            this.panelAddCaisse.TabIndex = 5;
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
            // ProgressionProductionB
            // 
            this.ProgressionProductionB.ColorLabelProd = System.Drawing.SystemColors.ControlText;
            this.ProgressionProductionB.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressionProductionB.Location = new System.Drawing.Point(146, 460);
            this.ProgressionProductionB.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressionProductionB.Name = "ProgressionProductionB";
            this.ProgressionProductionB.Nom = "B";
            this.ProgressionProductionB.NomProduction = "Production B";
            this.ProgressionProductionB.Size = new System.Drawing.Size(923, 81);
            this.ProgressionProductionB.TabIndex = 2;
            this.ProgressionProductionB.ValeurBarreProgression = 0;
            // 
            // ProgressionProductionC
            // 
            this.ProgressionProductionC.ColorLabelProd = System.Drawing.SystemColors.ControlText;
            this.ProgressionProductionC.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressionProductionC.Location = new System.Drawing.Point(146, 549);
            this.ProgressionProductionC.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressionProductionC.Name = "ProgressionProductionC";
            this.ProgressionProductionC.Nom = "C";
            this.ProgressionProductionC.NomProduction = "Production C";
            this.ProgressionProductionC.Size = new System.Drawing.Size(900, 67);
            this.ProgressionProductionC.TabIndex = 1;
            this.ProgressionProductionC.ValeurBarreProgression = 0;
            // 
            // ProgressionProductionA
            // 
            this.ProgressionProductionA.ColorLabelProd = System.Drawing.SystemColors.ControlText;
            this.ProgressionProductionA.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressionProductionA.Location = new System.Drawing.Point(146, 380);
            this.ProgressionProductionA.Name = "ProgressionProductionA";
            this.ProgressionProductionA.Nom = "A";
            this.ProgressionProductionA.NomProduction = "Production A";
            this.ProgressionProductionA.Size = new System.Drawing.Size(923, 83);
            this.ProgressionProductionA.TabIndex = 0;
            this.ProgressionProductionA.ValeurBarreProgression = 0;
            // 
            // tabPageProductionA
            // 
            this.tabPageProductionA.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageProductionA.Location = new System.Drawing.Point(0, 0);
            this.tabPageProductionA.Margin = new System.Windows.Forms.Padding(5);
            this.tabPageProductionA.Name = "tabPageProductionA";
            this.tabPageProductionA.NombreCaisseDepuisDemarrage = "";
            this.tabPageProductionA.NombreErreur = "";
            this.tabPageProductionA.Size = new System.Drawing.Size(649, 263);
            this.tabPageProductionA.TabIndex = 0;
            this.tabPageProductionA.TauxDefautDemarrage = "";
            this.tabPageProductionA.TauxDefautHeures = "";
            // 
            // tabPageProductionB
            // 
            this.tabPageProductionB.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageProductionB.Location = new System.Drawing.Point(0, 0);
            this.tabPageProductionB.Margin = new System.Windows.Forms.Padding(5);
            this.tabPageProductionB.Name = "tabPageProductionB";
            this.tabPageProductionB.NombreCaisseDepuisDemarrage = "";
            this.tabPageProductionB.NombreErreur = "";
            this.tabPageProductionB.Size = new System.Drawing.Size(785, 263);
            this.tabPageProductionB.TabIndex = 0;
            this.tabPageProductionB.TauxDefautDemarrage = "";
            this.tabPageProductionB.TauxDefautHeures = "";
            // 
            // tabPageProductionC
            // 
            this.tabPageProductionC.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageProductionC.Location = new System.Drawing.Point(0, 0);
            this.tabPageProductionC.Margin = new System.Windows.Forms.Padding(5);
            this.tabPageProductionC.Name = "tabPageProductionC";
            this.tabPageProductionC.NombreCaisseDepuisDemarrage = "";
            this.tabPageProductionC.NombreErreur = "";
            this.tabPageProductionC.Size = new System.Drawing.Size(785, 263);
            this.tabPageProductionC.TabIndex = 0;
            this.tabPageProductionC.TauxDefautDemarrage = "";
            this.tabPageProductionC.TauxDefautHeures = "";
            // 
            // buttonAddCaisse
            // 
            this.buttonAddCaisse.Location = new System.Drawing.Point(81, 161);
            this.buttonAddCaisse.Name = "buttonAddCaisse";
            this.buttonAddCaisse.Size = new System.Drawing.Size(82, 29);
            this.buttonAddCaisse.TabIndex = 5;
            this.buttonAddCaisse.Text = "Ajouter";
            this.buttonAddCaisse.UseVisualStyleBackColor = true;
            this.buttonAddCaisse.Click += new System.EventHandler(this.buttonAddCaisse_Click);
            // 
            // FormProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 646);
            this.Controls.Add(this.panelAddCaisse);
            this.Controls.Add(this.ProgressionProductionB);
            this.Controls.Add(this.ProgressionProductionC);
            this.Controls.Add(this.ProgressionProductionA);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProd_FormClosed);
            this.tabControlProd.ResumeLayout(false);
            this.tabPageA.ResumeLayout(false);
            this.tabPageB.ResumeLayout(false);
            this.tabPageC.ResumeLayout(false);
            this.menuStripProd.ResumeLayout(false);
            this.menuStripProd.PerformLayout();
            this.panelAddCaisse.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProd;
        private System.Windows.Forms.TabPage tabPageA;
        private BControlUtilisateursProduction.TabPageProduction tabPageProductionA;
        private System.Windows.Forms.TabPage tabPageB;
        private BControlUtilisateursProduction.TabPageProduction tabPageProductionB;
        private System.Windows.Forms.TabPage tabPageC;
        private BControlUtilisateursProduction.TabPageProduction tabPageProductionC;
        private BControlUtilisateursProduction.UCProgressionProduction ProgressionProductionA;
        private BControlUtilisateursProduction.UCProgressionProduction ProgressionProductionC;
        private BControlUtilisateursProduction.UCProgressionProduction ProgressionProductionB;
        private System.Windows.Forms.MenuStrip menuStripProd;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem démarrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStartA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStartB;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStartC;
        private System.Windows.Forms.ToolStripMenuItem arrêterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStopA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStopB;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStopC;
        private System.Windows.Forms.ToolStripMenuItem continuerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemContinueA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemContinueB;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemContinueC;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterProductionToolStripMenuItem;
        private BControlUtilisateursProduction.UCAddCaisse ucAddCaisseQuest;
        private System.Windows.Forms.Panel panelAddCaisse;
        private System.Windows.Forms.Button buttonAddCaisse;
    }
}

