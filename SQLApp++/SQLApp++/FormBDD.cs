using ClassLibraryPersistance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLApp__
{
    public partial class FormBDD : Form
    {
        PersistanceSQLServer persistanceSQLServer;
        public FormBDD()
        {
            InitializeComponent();
            persistanceSQLServer = new PersistanceSQLServer();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            string logs = "";

            if(persistanceSQLServer.IsOpen())
            {
                this.persistanceSQLServer.Deconnexion();
            }

            try
            {
                if(textBoxServer.Text == "" && textBoxBDD.Text == "")
                {
                    persistanceSQLServer = new PersistanceSQLServer(ConfigurationManager.ConnectionStrings["papyrus"].ConnectionString);
                }
                else
                {
                    persistanceSQLServer = new PersistanceSQLServer(textBoxServer.Text, textBoxBDD.Text);
                }
                
                logs += persistanceSQLServer.Connexion();
            }
            catch(Exception ex)
            {
                logs += ex.Message + Environment.NewLine;
                if (persistanceSQLServer.IsOpen())
                {
                    persistanceSQLServer.Deconnexion();
                }
            }
            if(logs == "")
            {
                this.labelStateConnexion.Text = "Open";
                textBoxLogs.Text = "";
                this.textBoxLogs.Text = "Connexion réussie";
            }
            else
            {
                this.labelStateConnexion.Text = "Close";
                textBoxLogs.Text = logs;
            }
        }

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {

            string logs = this.persistanceSQLServer.Deconnexion();

            if (logs == "")
            {
                this.labelStateConnexion.Text = "Close";
                textBoxLogs.Text = "Déconnexion réussie";
            }
            else
            {
                textBoxLogs.Text = logs;
            }
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFournisseurs_Click(object sender, EventArgs e)
        {
            RechercheFournisseurs rechercheFournisseurs = new RechercheFournisseurs(persistanceSQLServer);
            rechercheFournisseurs.Show();
        }

        private void buttonCreation_Click(object sender, EventArgs e)
        {
            if(persistanceSQLServer.IsOpen())
            {
                AffichageFournisseur affichageFournisseur = new AffichageFournisseur(persistanceSQLServer);
                affichageFournisseur.Show();
            }
            
        }
    }
}
