using ClassLibraryPersistanceSqlServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Papyrus
{
    public partial class FormBDD : Form
    {
        PersitanceContact persitanceContact;

        public FormBDD()
        {
            InitializeComponent();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBoxBDD.Text == "" && this.textBoxServer.Text == "")
                {
                    persitanceContact = new PersitanceContact(ConfigurationManager.ConnectionStrings["papyrus"].ConnectionString);
                    persitanceContact.Open();
                    labelStateConnexion.Text = "Open";
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (Exception e1)
            {
                textBoxLogs.Visible = true;
                textBoxLogs.Text = e1.Message;
                labelStateConnexion.Text = "Error";
                if (persitanceContact != null)
                {
                    persitanceContact.Close();
                }

                Trace.TraceError(DateTime.Now + " Tentative de connection échouée : " + textBoxBDD.Text + ":" + textBoxServer.Text);
            }

            Trace.Flush();
        }

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            if (persitanceContact != null)
            {
                persitanceContact.Close();
                labelStateConnexion.Text = "Closed";
            }
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFournisseurs_Click(object sender, EventArgs e)
        {
            RechercheFournisseurs rechercheFournisseurs = new RechercheFournisseurs();
            rechercheFournisseurs.Show();
        }

        private void buttonCreation_Click(object sender, EventArgs e)
        {
            if (persitanceContact != null)
            {
                AffichageFournisseur affichageFournisseur = new AffichageFournisseur();
                affichageFournisseur.Show();
            }

        }

        private void buttonSuppression_Click(object sender, EventArgs e)
        {
            if (persitanceContact != null)
            {
                SupressForm supressForm = new SupressForm();
                supressForm.Show();
            }
        }

        private void buttonCommandes_Click(object sender, EventArgs e)
        {
            if (persitanceContact != null)
            {
                //ListeCommandes liste = new ListeCommandes();
                //liste.Show();
            }
        }
    }
}
