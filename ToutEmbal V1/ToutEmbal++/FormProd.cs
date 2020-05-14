using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductionCaisses;

namespace ToutEmbal__
{
    public partial class FormProd : Form
    {
        List<Production> productions;

        Production prodA, prodB, prodC;

        public FormProd()
        {
            InitializeComponent();
            prodA = new Production(1000);
            prodB = new Production(2500);
            prodC = new Production(12000);

            timerA.Enabled = timerB.Enabled = timerC.Enabled = true;

            //prodA.PropertyChanged += new PropertyChangedEventHandler(ProdPropertyChanged);
            //prodB.PropertyChanged += new PropertyChangedEventHandler(ProdPropertyChanged);
            //prodC.PropertyChanged += new PropertyChangedEventHandler(ProdPropertyChanged);

            UpdateIHM();
        }

        //private void ProdPropertyChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    UpdateIHM();
        //}


        private void timerA_Tick(object sender, EventArgs e)
        {
            prodA.AjouterDesCaisses();
            if (prodA.EtatCourantDeLaProduction == EnumEtatProduction.EnCours)
            {
                prodA.TpsEcouleDeProduction += timerA.Interval;
            }
            UpdateIHM();
        }

        private void timerB_Tick(object sender, EventArgs e)
        {
            prodB.AjouterDesCaisses();
            if (prodB.EtatCourantDeLaProduction == EnumEtatProduction.EnCours)
            {
                prodB.TpsEcouleDeProduction += timerB.Interval;
            }
            UpdateIHM();
        }

        private void timerC_Tick(object sender, EventArgs e)
        {
            prodC.AjouterDesCaisses();
            if (prodC.EtatCourantDeLaProduction == EnumEtatProduction.EnCours)
            {
                prodC.TpsEcouleDeProduction += timerC.Interval;
            }
            UpdateIHM();
        }

        private void ToolStripMenuItemStartA_Click(object sender, EventArgs e)
        {
            prodA.Demarrer();
            UpdateIHM();
        }

        private void ToolStripMenuItemStartB_Click(object sender, EventArgs e)
        {
            prodB.Demarrer();
            UpdateIHM();
        }

        private void ToolStripMenuItemStartC_Click(object sender, EventArgs e)
        {
            prodC.Demarrer();
            UpdateIHM();
        }

        private void ToolStripMenuItemStopA_Click(object sender, EventArgs e)
        {
            prodA.Suspendre();
            UpdateIHM();
        }

        private void ToolStripMenuItemStopB_Click(object sender, EventArgs e)
        {
            prodB.Suspendre();
            UpdateIHM();
        }

        private void ToolStripMenuItemStopC_Click(object sender, EventArgs e)
        {
            prodC.Suspendre();
            UpdateIHM();
        }

        private void ToolStripMenuItemContinueA_Click(object sender, EventArgs e)
        {
            prodA.Redemarrer();
            UpdateIHM();
        }

        private void ToolStripMenuItemContinueB_Click(object sender, EventArgs e)
        {
            prodB.Redemarrer();
            UpdateIHM();
        }

        private void ToolStripMenuItemContinueC_Click(object sender, EventArgs e)
        {
            prodC.Redemarrer();
            UpdateIHM();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        

        private void UpdateIHM()
        {
            tabPageProductionA.NombreCaisseDepuisDemarrage = prodA.NbCaissesProduite.ToString();
            tabPageProductionB.NombreCaisseDepuisDemarrage = prodB.NbCaissesProduite.ToString();
            tabPageProductionC.NombreCaisseDepuisDemarrage = prodC.NbCaissesProduite.ToString();

            ProgressionProductionA.ValeurBarreProgression = prodA.GetPourcentageProductionTerminate();
            ProgressionProductionB.ValeurBarreProgression = prodB.GetPourcentageProductionTerminate();
            ProgressionProductionC.ValeurBarreProgression = prodC.GetPourcentageProductionTerminate();

            if(prodA.EtatCourantDeLaProduction == EnumEtatProduction.EnCours)
            {
                ProgressionProductionA.ColorLabelProd = Color.Green;
                
            }
            else if (prodA.EtatCourantDeLaProduction == EnumEtatProduction.AttenteDemarrage)
            {
                 ProgressionProductionA.ColorLabelProd = Color.Blue;
            }
            else if (prodA.EtatCourantDeLaProduction == EnumEtatProduction.Suspendu)
            {
                ProgressionProductionA.ColorLabelProd = Color.Orange;
            }
            else
            {
                ProgressionProductionA.ColorLabelProd = Color.Red;
            }

            if (prodB.EtatCourantDeLaProduction == EnumEtatProduction.EnCours)
            {
                ProgressionProductionB.ColorLabelProd = Color.Green;

            }
            else if (prodB.EtatCourantDeLaProduction == EnumEtatProduction.AttenteDemarrage)
            {
                ProgressionProductionB.ColorLabelProd = Color.Blue;
            }
            else if (prodB.EtatCourantDeLaProduction == EnumEtatProduction.Suspendu)
            {
                ProgressionProductionB.ColorLabelProd = Color.Orange;
            }
            else
            {
                ProgressionProductionB.ColorLabelProd = Color.Red;
            }

            if (prodC.EtatCourantDeLaProduction == EnumEtatProduction.EnCours)
            {
                ProgressionProductionC.ColorLabelProd = Color.Green;

            }
            else if (prodC.EtatCourantDeLaProduction == EnumEtatProduction.AttenteDemarrage)
            {
                ProgressionProductionC.ColorLabelProd = Color.Blue;
            }
            else if (prodC.EtatCourantDeLaProduction == EnumEtatProduction.Suspendu)
            {
                ProgressionProductionC.ColorLabelProd = Color.Orange;
            }
            else
            {
                ProgressionProductionC.ColorLabelProd = Color.Red;
            }


            if (prodA.EtatCourantDeLaProduction == EnumEtatProduction.AttenteDemarrage || prodA.EtatCourantDeLaProduction == EnumEtatProduction.Termine)
            {
                ToolStripMenuItemStartA.Enabled = true;
                ToolStripMenuItemStopA.Enabled = false;
                ToolStripMenuItemContinueA.Enabled = false;
            }
            else if (prodA.EtatCourantDeLaProduction == EnumEtatProduction.EnCours)
            {
                ToolStripMenuItemStartA.Enabled = false;
                ToolStripMenuItemStopA.Enabled = true;
                ToolStripMenuItemContinueA.Enabled = false;
                tabPageProductionA.TauxDefautDemarrage = (prodA.NbCaissesNonConforme / (double)prodA.NbCaissesProduite).ToString("0.0000");
            }
            else
            {
                ToolStripMenuItemStartA.Enabled = false;
                ToolStripMenuItemStopA.Enabled = false;
                ToolStripMenuItemContinueA.Enabled = true;
            }

            if (prodB.EtatCourantDeLaProduction == EnumEtatProduction.AttenteDemarrage || prodB.EtatCourantDeLaProduction == EnumEtatProduction.Termine)
            {
                ToolStripMenuItemStartB.Enabled = true;
                ToolStripMenuItemStopB.Enabled = false;
                ToolStripMenuItemContinueB.Enabled = false;
            }
            else if (prodB.EtatCourantDeLaProduction == EnumEtatProduction.EnCours)
            {
                ToolStripMenuItemStartB.Enabled = false;
                ToolStripMenuItemStopB.Enabled = true;
                ToolStripMenuItemContinueB.Enabled = false;
                tabPageProductionB.TauxDefautDemarrage = (prodB.NbCaissesNonConforme / (double)prodB.NbCaissesProduite).ToString("0.0000");
            }
            else
            {
                ToolStripMenuItemStartB.Enabled = false;
                ToolStripMenuItemStopB.Enabled = false;
                ToolStripMenuItemContinueB.Enabled = true;
            }

            if (prodC.EtatCourantDeLaProduction == EnumEtatProduction.AttenteDemarrage || prodC.EtatCourantDeLaProduction == EnumEtatProduction.Termine)
            {
                ToolStripMenuItemStartC.Enabled = true;
                ToolStripMenuItemStopC.Enabled = false;
                ToolStripMenuItemContinueC.Enabled = false;
            }
            else if (prodC.EtatCourantDeLaProduction == EnumEtatProduction.EnCours)
            {
                ToolStripMenuItemStartC.Enabled = false;
                ToolStripMenuItemStopC.Enabled = true;
                ToolStripMenuItemContinueC.Enabled = false;
                tabPageProductionC.TauxDefautDemarrage = (prodC.NbCaissesNonConforme / (double)prodC.NbCaissesProduite).ToString("0.0000");
            }
            else
            {
                ToolStripMenuItemStartC.Enabled = false;
                ToolStripMenuItemStopC.Enabled = false;
                ToolStripMenuItemContinueC.Enabled = true;
            }
        }
    }
}
