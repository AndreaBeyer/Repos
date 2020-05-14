using BControlUtilisateursProduction;
using ClassLibraryXMLSerialization;
using LibraryHorloge;
using ProductionCaisses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ToutEmbal__
{
  
    public partial class FormProd : Form
    {

        delegate void UpdateIHMDelegate(Production _production);
        delegate void ShowHorlogeDelegateHandler();

        UpdateIHMDelegate updateIHM;

        ShowHorlogeDelegateHandler ShowHorlogeDelegate;

        Dictionary<char, Production> mesProductions;

        public FormProd()
        {
            InitializeComponent();

            mesProductions = new Dictionary<char, Production>();

            panelAddCaisse.Visible = false;

            enregistrerToolStripMenuItem.Enabled = false;
            ShowHorlogeDelegate = new ShowHorlogeDelegateHandler(ShowHorloge);

            Thread t = new Thread(new ThreadStart(ThreadProcess));
            
            t.Start();
        }

        private void ThreadProcess()
        {
            while (!this.IsDisposed)
            {
                if (this.IsHandleCreated && ShowHorlogeDelegate != null)
                {
                    this.Invoke(this.ShowHorlogeDelegate, null);
                    Thread.Sleep(1000);
                }
            }
        }

        private void Prod_ErreurEstApparue(Production _prod, int _nbCaisseNonConforme, decimal _tauxErreurActuel)
        {

            updateIHM = new UpdateIHMDelegate(UpdateIHM);

            if (this.IsHandleCreated && updateIHM != null)
            {
                this.Invoke(updateIHM, new object[] { _prod });
            }
        }


        private void Prod_QteProductionChange(Production _prod, int _nouvelleQte, int _nouveauPourcentage, decimal _tauxErreurActuel)
        {
            updateIHM = new UpdateIHMDelegate(UpdateIHM);

            if (this.IsHandleCreated && updateIHM != null)
            {
                this.Invoke(updateIHM, new object[] { _prod });
            }
        }

        private void Prod_EtatProductionChange(Production _prod, EnumEtatProduction _nouvelEtat)
        {
            updateIHM = new UpdateIHMDelegate(UpdateIHM);

            if (this.IsHandleCreated && updateIHM != null)
            {
                this.Invoke(updateIHM, new object[] { _prod });
            }
        }

        private void DemarrerProd(object sender, EventArgs e)
        {
            ToolStripMenuItem sender1 = (ToolStripMenuItem)sender;
            mesProductions[char.Parse(sender1.Text)].Demarrer();
        }

        private void SuspendreProd(object sender, EventArgs e)
        {
            ToolStripMenuItem sender1 = (ToolStripMenuItem)sender;
            mesProductions[char.Parse(sender1.Text)].Suspendre();
        }

        private void ContinueProd(object sender, EventArgs e)
        {
            ToolStripMenuItem sender1 = (ToolStripMenuItem)sender;
            mesProductions[char.Parse(sender1.Text)].Redemarrer();
        }

        private void ajouterProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAddCaisse.Visible = true;
        }

        private void buttonAddCaisse_Click(object sender, EventArgs e)
        {
            char tempType = ' ';
            int tempNbCaisses = 0;
            bool ok = char.TryParse(ucAddCaisseQuest.TypeCaisseToAdd, out tempType) && int.TryParse(ucAddCaisseQuest.NbCaisseToAdd, out tempNbCaisses) && tempNbCaisses > 0;
            if (ok)
            {
                Production production = new Production(tempNbCaisses, tempType);
                production.EtatProductionChange += Prod_EtatProductionChange;
                production.ProductionReussie += Prod_QteProductionChange;
                production.ErreurEstApparue += Prod_ErreurEstApparue;
                mesProductions.Add(production.Type, production);
                AddProductionToIHM(production);
            }
            else
            {
                MessageBox.Show("Les informations sont invalides");
            }

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateIHM(Production production)
        {
            if (production.EtatCourantDeLaProduction == EnumEtatProduction.AttenteDemarrage)
            {
                demarrerToolStripMenuItem.DropDownItems["Start" + production.Type].Enabled = true;
                continuerToolStripMenuItem.DropDownItems["Continue" + production.Type].Enabled = false;
                arrêterToolStripMenuItem.DropDownItems["Stop" + production.Type].Enabled = false;
            }
            else if (production.EtatCourantDeLaProduction == EnumEtatProduction.Suspendu)
            {
                demarrerToolStripMenuItem.DropDownItems["Start" + production.Type].Enabled = false;
                continuerToolStripMenuItem.DropDownItems["Continue" + production.Type].Enabled = true;
                arrêterToolStripMenuItem.DropDownItems["Stop" + production.Type].Enabled = false;
            }
            else if (production.EtatCourantDeLaProduction == EnumEtatProduction.EnCours)
            {
                demarrerToolStripMenuItem.DropDownItems["Start" + production.Type].Enabled = false;
                continuerToolStripMenuItem.DropDownItems["Continue" + production.Type].Enabled = false;
                arrêterToolStripMenuItem.DropDownItems["Stop" + production.Type].Enabled = true;
            }
            else
            {
                demarrerToolStripMenuItem.DropDownItems["Start" + production.Type].Enabled = false;
                continuerToolStripMenuItem.DropDownItems["Continue" + production.Type].Enabled = false;
                arrêterToolStripMenuItem.DropDownItems["Stop" + production.Type].Enabled = false;
            }

            UCProgressionProduction uc = (UCProgressionProduction)this.panelProgressBar.Controls[production.Type.ToString()];
            uc.ValeurBarreProgression = production.GetPourcentageProductionTerminate();
            UCPageProduction uCPage = (UCPageProduction)this.tabControlProd.Controls["Production" + production.Type.ToString()].Controls[production.Type.ToString()];

            uCPage.NombreCaisseDepuisDemarrage = production.NbCaissesProduite.ToString();
            uCPage.NombreErreur = production.NbCaissesNonConforme.ToString();
            uCPage.TauxDefautDemarrage = production.GetTauxErreurDemarrage().ToString("0.0000");

        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Production"))
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Production");
                }
                foreach (Production p in mesProductions.Values)
                {
                    XMLSerialization<Production>.Serialize(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Production\Production " + p.Type + ".xml", p);
                }
            }
            catch (UnauthorizedAccessException e1)
            {
                MessageBox.Show("L'utilisateur ne possède pas les droits d'écriture du dossier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e2)
            {
                MessageBox.Show("L'opération est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void chargerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chargerToolStripMenuItem.Enabled = false;

            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Production"))
            {
                foreach (string f in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Production", "Production*.xml"))
                {

                    try
                    {
                        Production production = XMLSerialization<Production>.Deserialize(f);
                        production.EtatProductionChange += Prod_EtatProductionChange;
                        production.ProductionReussie += Prod_QteProductionChange;
                        production.ErreurEstApparue += Prod_ErreurEstApparue;
                        mesProductions.Add(production.Type, production);
                        AddProductionToIHM(production);
                    }
                    catch (UnauthorizedAccessException e1)
                    {
                        MessageBox.Show("L'utilisateur ne possède pas les droits de lecture du dossier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception e2)
                    {
                        MessageBox.Show("L'opération est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Le dossier n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProductionToIHM(Production production)
        {
            enregistrerToolStripMenuItem.Enabled = true;

            panelAddCaisse.Visible = false;
            ucAddCaisseQuest.TypeCaisseToAdd = "";
            ucAddCaisseQuest.NbCaisseToAdd = "";

            TabPage tabPage = new TabPage("Production " + production.Type);

            tabPage.Name = "Production" + production.Type;

            UCPageProduction pageProd = new UCPageProduction();

            pageProd.Name = production.Type.ToString();

            tabPage.Controls.Add(pageProd);
            tabControlProd.Controls.Add(tabPage);

            ToolStripItem item = new ToolStripMenuItem(production.Type.ToString(), null, DemarrerProd);
            item.Name = "Start" + production.Type;
            demarrerToolStripMenuItem.DropDownItems.Add(item);

            ToolStripItem item1 = new ToolStripMenuItem(production.Type.ToString(), null, ContinueProd);
            item1.Name = "Continue" + production.Type;
            continuerToolStripMenuItem.DropDownItems.Add(item1);

            ToolStripItem item2 = new ToolStripMenuItem(production.Type.ToString(), null, SuspendreProd);
            item2.Name = "Stop" + production.Type;
            arrêterToolStripMenuItem.DropDownItems.Add(item2);

            UCProgressionProduction uC = new UCProgressionProduction();

            uC.Name = production.Type.ToString();
            uC.NomProduction += " " + uC.Name; 

            panelProgressBar.Controls.Add(uC);

            ToolStripStatusLabel toolStrip = new ToolStripStatusLabel($"Production {production.Type} : {production.EtatCourantDeLaProduction} || ");

            statusStripProd.Items.Add(toolStrip);

            UpdateIHM(production);
        }

        private void FormProd_FormClosing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ShowHorloge()
        {
             labelHorloge.Text = Horloge.GetStringFormat();
        }

        private void buttonQuitterAdd_Click(object sender, EventArgs e)
        {
            panelAddCaisse.Visible = false;
            ucAddCaisseQuest.TypeCaisseToAdd = "";
            ucAddCaisseQuest.NbCaisseToAdd = "";
        }
    }
}
