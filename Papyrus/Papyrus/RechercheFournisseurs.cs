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
    public partial class RechercheFournisseurs : Form
    {
        PersitanceContact persitanceContact;

        public RechercheFournisseurs()
        {
            InitializeComponent();
            this.persitanceContact = new PersitanceContact(ConfigurationManager.ConnectionStrings["papyrus"].ConnectionString);
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            bool ok = int.TryParse(textBoxCode.Text, out int code);

            if (ok)
            {
                try
                {
                    if (persitanceContact.GetContact(code).id != -1)
                    {
                        AffichageFournisseur affichageFournisseur = new AffichageFournisseur(code);
                        affichageFournisseur.Show();
                    }
                    else
                    {
                        Trace.TraceError("Tentative d'accès au contact inexistant " + code);
                        MessageBox.Show("Contact inexistant", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch(Exception ex)
                {
                    Trace.TraceError("Erreur : " + ex.Message);
                }

            }
            else
            {
                Trace.TraceError("Tentative d'accès au code invalide " + code);
                MessageBox.Show("Le code est invalide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Trace.Flush();

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
