using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductionCaisses;

namespace ToutEmbal__
{
    public partial class FormProd : Form
    {
        Production prodA, prodB, prodC;

        private delegate void UpdateIHMDelegateHandle();
        private UpdateIHMDelegateHandle updateIHMDelegate;

        Dictionary<char, Production> mesProductions;

        public FormProd()
        {
            InitializeComponent();
            prodA = new Production(1000, 'A');
            prodB = new Production(2500, 'B');
            prodC = new Production(12000, 'C');

            mesProductions = new Dictionary<char, Production>();

            mesProductions.Add('A', prodA);
            mesProductions.Add('B', prodB);
            mesProductions.Add('C', prodC);

            prodA.EtatProductionChange += Prod_EtatProductionChange;
            prodA.ProductionReussie += Prod_QteProductionChange;
            prodA.ErreurEstApparue += Prod_ErreurEstApparue;

            prodB.EtatProductionChange += Prod_EtatProductionChange;
            prodB.ProductionReussie += Prod_QteProductionChange;
            prodB.ErreurEstApparue += Prod_ErreurEstApparue;

            prodC.EtatProductionChange += Prod_EtatProductionChange;
            prodC.ProductionReussie += Prod_QteProductionChange;
            prodC.ErreurEstApparue += Prod_ErreurEstApparue;

            panelAddCaisse.Visible = false;

            this.updateIHMDelegate = new UpdateIHMDelegateHandle(UpdateIHM);
            Thread th = new Thread(ThreadProcess);
            th.Start();
        }

        

        private void ThreadProcess()
        {
            while (!this.IsDisposed)
            {
                if (updateIHMDelegate != null && this.IsHandleCreated)
                {
                    this.Invoke(this.updateIHMDelegate);
                    Thread.Sleep(100);
                }
            }
            
            
        }

        private void Prod_ErreurEstApparue(Production _prod, int _nbCaisseNonConforme, decimal _tauxErreurActuel)
        {
                        
        }

       
        private void Prod_QteProductionChange(Production _prod, int _nouvelleQte, int _nouveauPourcentage, decimal _tauxErreurActuel)
        {
            
        }

        private void Prod_EtatProductionChange(Production _prod, EnumEtatProduction _nouvelEtat)
        {
            
        }

        private void ToolStripMenuItemStartA_Click(object sender, EventArgs e)
        {
            prodA.Demarrer();
        }

        private void ToolStripMenuItemStartB_Click(object sender, EventArgs e)
        {
            prodB.Demarrer();
        }

        private void ToolStripMenuItemStartC_Click(object sender, EventArgs e)
        {
            prodC.Demarrer();
        }

        private void ToolStripMenuItemStopA_Click(object sender, EventArgs e)
        {
            prodA.Suspendre();
        }

        private void ToolStripMenuItemStopB_Click(object sender, EventArgs e)
        {
            prodB.Suspendre();
        }

        private void ToolStripMenuItemStopC_Click(object sender, EventArgs e)
        {
            prodC.Suspendre();
        }

        private void ToolStripMenuItemContinueA_Click(object sender, EventArgs e)
        {
            prodA.Redemarrer();
        }

        private void ToolStripMenuItemContinueB_Click(object sender, EventArgs e)
        {
            prodB.Redemarrer();
        }

        private void ToolStripMenuItemContinueC_Click(object sender, EventArgs e)
        {
            prodC.Redemarrer();
        }

        private void FormProd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
                mesProductions.Add(tempType, production);
                MessageBox.Show("Création réussie");
                panelAddCaisse.Visible = false;
                ucAddCaisseQuest.TypeCaisseToAdd = "";
                ucAddCaisseQuest.NbCaisseToAdd = "";
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

        private void UpdateIHM()
        {

            tabPageProductionA.NombreErreur = prodA.NbCaissesNonConforme.ToString();
            tabPageProductionA.TauxDefautDemarrage = prodA.GetTauxErreurDemarrage().ToString("0.0000");
            tabPageProductionA.NombreCaisseDepuisDemarrage = prodA.NbCaissesProduite.ToString();
            tabPageProductionA.TauxDefautDemarrage = prodA.GetTauxErreurDemarrage().ToString("0.0000");

            ProgressionProductionA.ValeurBarreProgression = prodA.GetPourcentageProductionTerminate();


            if (prodA.EtatCourantDeLaProduction == EnumEtatProduction.AttenteDemarrage)
            {
                ToolStripMenuItemStartA.Enabled = true;
                ToolStripMenuItemStopA.Enabled = false;
                ToolStripMenuItemContinueA.Enabled = false;
                ProgressionProductionA.ColorLabelProd = Color.Blue;
            }
            else if (prodA.EtatCourantDeLaProduction == EnumEtatProduction.Termine)
            {
                ToolStripMenuItemStartA.Enabled = false;
                ToolStripMenuItemStopA.Enabled = false;
                ToolStripMenuItemContinueA.Enabled = false;
                ProgressionProductionA.ColorLabelProd = Color.Red;
            }
            else if (prodA.EtatCourantDeLaProduction == EnumEtatProduction.EnCours)
            {
                ToolStripMenuItemStartA.Enabled = false;
                ToolStripMenuItemStopA.Enabled = true;
                ToolStripMenuItemContinueA.Enabled = false;
                ProgressionProductionA.ColorLabelProd = Color.Green;
            }
            else
            {
                ToolStripMenuItemStartA.Enabled = false;
                ToolStripMenuItemStopA.Enabled = false;
                ToolStripMenuItemContinueA.Enabled = true;
                ProgressionProductionA.ColorLabelProd = Color.Orange;
            }

            tabPageProductionB.NombreErreur = prodB.NbCaissesNonConforme.ToString();
            tabPageProductionB.TauxDefautDemarrage = prodB.GetTauxErreurDemarrage().ToString("0.0000");
            tabPageProductionB.NombreCaisseDepuisDemarrage = prodB.NbCaissesProduite.ToString();
            tabPageProductionB.TauxDefautDemarrage = prodB.GetTauxErreurDemarrage().ToString("0.0000");

            ProgressionProductionB.ValeurBarreProgression = prodB.GetPourcentageProductionTerminate();


            if (prodB.EtatCourantDeLaProduction == EnumEtatProduction.AttenteDemarrage)
            {
                ToolStripMenuItemStartB.Enabled = true;
                ToolStripMenuItemStopB.Enabled = false;
                ToolStripMenuItemContinueB.Enabled = false;
                ProgressionProductionB.ColorLabelProd = Color.Blue;
            }
            else if (prodB.EtatCourantDeLaProduction == EnumEtatProduction.Termine)
            {
                ToolStripMenuItemStartB.Enabled = false;
                ToolStripMenuItemStopB.Enabled = false;
                ToolStripMenuItemContinueB.Enabled = false;
                ProgressionProductionB.ColorLabelProd = Color.Red;
            }
            else if (prodB.EtatCourantDeLaProduction == EnumEtatProduction.EnCours)
            {
                ToolStripMenuItemStartB.Enabled = false;
                ToolStripMenuItemStopB.Enabled = true;
                ToolStripMenuItemContinueB.Enabled = false;
                ProgressionProductionB.ColorLabelProd = Color.Green;
            }
            else
            {
                ToolStripMenuItemStartB.Enabled = false;
                ToolStripMenuItemStopB.Enabled = false;
                ToolStripMenuItemContinueB.Enabled = true;
                ProgressionProductionB.ColorLabelProd = Color.Orange;
            }

            tabPageProductionC.NombreErreur = prodC.NbCaissesNonConforme.ToString();
            tabPageProductionC.TauxDefautDemarrage = prodC.GetTauxErreurDemarrage().ToString("0.0000");
            tabPageProductionC.NombreCaisseDepuisDemarrage = prodC.NbCaissesProduite.ToString();
            tabPageProductionC.TauxDefautDemarrage = prodC.GetTauxErreurDemarrage().ToString("0.0000");


            ProgressionProductionC.ValeurBarreProgression = prodC.GetPourcentageProductionTerminate();

            if (prodC.EtatCourantDeLaProduction == EnumEtatProduction.AttenteDemarrage)
            {
                ToolStripMenuItemStartC.Enabled = true;
                ToolStripMenuItemStopC.Enabled = false;
                ToolStripMenuItemContinueC.Enabled = false;
                ProgressionProductionC.ColorLabelProd = Color.Blue;
            }
            else if (prodC.EtatCourantDeLaProduction == EnumEtatProduction.Termine)
            {
                ToolStripMenuItemStartC.Enabled = false;
                ToolStripMenuItemStopC.Enabled = false;
                ToolStripMenuItemContinueC.Enabled = false;
                ProgressionProductionC.ColorLabelProd = Color.Red;
            }
            else if (prodC.EtatCourantDeLaProduction == EnumEtatProduction.EnCours)
            {
                ToolStripMenuItemStartC.Enabled = false;
                ToolStripMenuItemStopC.Enabled = true;
                ToolStripMenuItemContinueC.Enabled = false;
                ProgressionProductionC.ColorLabelProd = Color.Green;
            }
            else
            {
                ToolStripMenuItemStartC.Enabled = false;
                ToolStripMenuItemStopC.Enabled = false;
                ToolStripMenuItemContinueC.Enabled = true;
                ProgressionProductionC.ColorLabelProd = Color.Orange;
            }
        }
    }
}
