using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Production;
using Horloge;


namespace ToutEmbal
{
    public partial class Form1 : Form
    {
        ProductionClasse production;
        public Form1()
        {
            InitializeComponent();

            production = new ProductionClasse(10000, 25000, 120000, false, false, false);
            
            timerProduction.Start();
            
            pictureBoxAO.Visible = pictureBoxAG.Visible = pictureBoxBG.Visible = pictureBoxBO.Visible = pictureBoxCO.Visible = pictureBoxCG.Visible = false;

            //Affichage de l'heure
            hourtoolLBL.Text = HorlogeClasse.ToString();

            //Afichage des poucentages théoriques
            TauxTheoriqueA.Text = ((double)production.TauxDerreurA / 10).ToString("P0");
            TauxTheoriqueB.Text = ((double)production.TauxDerreurB / 10).ToString("P0");
            TauxTheoriqueC.Text = ((double)production.TauxDerreurC / 10).ToString("P0");

        }

        private void menuItemQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerProduction_Tick(object sender, EventArgs e)
        {
            if (production.ProduceAIsStart1)
            {
                boxTypeADefParH.Text = production.ProductNbMinutesGetError('a', 60).ToString("0.0000");
            }
            if (production.ProduceBIsStart1)
            {
                boxTypeBDefParH.Text = production.ProductNbMinutesGetError('b', 60).ToString("0.0000");
            }
            if (production.ProduceCIsStart1)
            {
                boxTypeCDefParH.Text = production.ProductNbMinutesGetError('c', 60).ToString("0.0000");
            }

            UpdateUI();
        }

        private void UpdateUI()
        {
            string aStatut;
            string bStatut;
            string cStatut;

            //SrollBars
            scbProdA.Value = production.GetPercentProduce('a');
            scbProdB.Value = production.GetPercentProduce('b');
            scbProdC.Value = production.GetPercentProduce('c');

            //Nombre de caisse depuis le démarrage
            boxNBCaisseA.Text = production.NbCaisseAProduct.ToString();
            boxNBCaisseB.Text = production.NbCaisseBProduct.ToString();
            boxNBCaisseC.Text = production.NbCaisseCProduct.ToString();

            //A Suspendu
            if (production.ProduceAIsSuspend1)
            {
                menuItemContinueA.Enabled = true;
                menuItemStopA.Enabled = false;
                menuItemStartA.Enabled = false;
                pictureBoxAG.Visible = false;
                pictureBoxAO.Visible = true;
                pictureBoxAR.Visible = false;
                aStatut = "Suspendu";
            }
            //A en cours
            else if(production.ProduceAIsStart1)
            {
                menuItemStartA.Enabled = false;
                menuItemStopA.Enabled = true;
                menuItemContinueA.Enabled = false;
                pictureBoxAG.Visible = true;
                pictureBoxAO.Visible = false;
                pictureBoxAR.Visible = false;
                aStatut = "En cours";
            }
            //A stoppé
            else
            {
                menuItemStartA.Enabled = true;
                menuItemContinueA.Enabled = false;
                menuItemStopA.Enabled = false;
                pictureBoxAG.Visible = false;
                pictureBoxAO.Visible = false;
                pictureBoxAR.Visible = true;
                aStatut = "Stoppé";
            }

            //B Suspendu
            if (production.ProduceBIsSuspend1)
            {
                menuItemContinueB.Enabled = true;
                menuItemStopB.Enabled = false;
                menuItemStartB.Enabled = false;
                pictureBoxBG.Visible = false;
                pictureBoxBO.Visible = true;
                pictureBoxBR.Visible = false;
                bStatut = "Suspendu";
            }
            //B en cours
            else if (production.ProduceBIsStart1)
            {
                menuItemStartB.Enabled = false;
                menuItemStopB.Enabled = true;
                menuItemContinueB.Enabled = false;
                pictureBoxBG.Visible = true;
                pictureBoxBO.Visible = false;
                pictureBoxBR.Visible = false;
                bStatut = "En cours";
            }
            //B stoppé
            else
            {
                menuItemStartB.Enabled = true;
                menuItemContinueB.Enabled = false;
                menuItemStopB.Enabled = false;
                pictureBoxBG.Visible = false;
                pictureBoxBO.Visible = false;
                pictureBoxBR.Visible = true;
                bStatut = "Stoppé";

            }
            //C Suspendu
            if (production.ProduceCIsSuspend1)
            {
                menuItemContinueC.Enabled = true;
                menuItemStopC.Enabled = false;
                menuItemStartC.Enabled = false;
                pictureBoxCG.Visible = false;
                pictureBoxCO.Visible = true;
                pictureBoxCR.Visible = false;
                cStatut = "Suspendu";
            }
            //C en cours
            else if (production.ProduceCIsStart1)
            {
                menuItemStartC.Enabled = false;
                menuItemStopC.Enabled = true;
                menuItemContinueC.Enabled = false;
                pictureBoxCG.Visible = true;
                pictureBoxCO.Visible = false;
                pictureBoxCR.Visible = false;
                cStatut = "En cours";
            }
            //C stoppé
            else
            {
                menuItemStartC.Enabled = true;
                menuItemContinueC.Enabled = false;
                menuItemStopC.Enabled = false;
                pictureBoxCG.Visible = false;
                pictureBoxCO.Visible = false;
                pictureBoxCR.Visible = true;
                cStatut = "Stoppé";
            }

            //Affichage du statut des caisses
            AtootLBL.Text = "Caisse A : " + aStatut;
            BToolLBL.Text = "Caisse B : " + bStatut;
            CtoolLBL.Text = "Caisse C : " + cStatut;

            //Horloge
            hourtoolLBL.Text = HorlogeClasse.ToString();

            //Affichage du taux d'erreur
            if (production.ProduceAIsStart1)
            {
                boxDefTotalTypeA.Text = production.getTauxErreur('a').ToString("0.0000");
            }
            if (production.ProduceBIsStart1)
            {
                boxDefTotalTypeB.Text = production.getTauxErreur('b').ToString("0.0000");
            }
            if (production.ProduceCIsStart1)
            {
                boxDefTotalTypeC.Text = production.getTauxErreur('c').ToString("0.0000");
            }
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            production.StartProduction('a');
        }

        private void menuItemStartB_Click(object sender, EventArgs e)
        {
            production.StartProduction('b');
        }

        private void menuItemStartC_Click(object sender, EventArgs e)
        {
            production.StartProduction('c');
        }

        private void menuItemStopA_Click(object sender, EventArgs e)
        {
            production.SuspendProduction('a');
        }

        private void menuItemStopB_Click(object sender, EventArgs e)
        {
            production.SuspendProduction('b');
        }

        private void menuItemStopC_Click(object sender, EventArgs e)
        {
            production.SuspendProduction('c');
        }

        private void menuItemContinueA_Click(object sender, EventArgs e)
        {
            production.RestartProduction('a');
        }

        private void menuItemContinueB_Click(object sender, EventArgs e)
        {
            production.RestartProduction('b');
        }

        private void menuItemContinueC_Click(object sender, EventArgs e)
        {
            production.RestartProduction('c');
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Fermeture de l'application", "Demande de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
