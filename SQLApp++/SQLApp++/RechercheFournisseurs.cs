using ClassLibraryContact;
using ClassLibraryPersistance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLApp__
{
    public partial class RechercheFournisseurs : Form
    {
        PersistanceSQLServer persistanceSQLServer;

        public RechercheFournisseurs(PersistanceSQLServer persistanceSQLServer)
        {
            InitializeComponent();
            this.persistanceSQLServer = persistanceSQLServer;
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            bool ok = int.TryParse(textBoxCode.Text, out int code);

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            if (ok)
            {
                parameters.Add("@pid_contact", code);

                if ((int)persistanceSQLServer.ExecuteDataReader(parameters, "SearchContact").Count == 0)
                {
                    MessageBox.Show("Le code fournisseur est inexistant", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AffichageFournisseur affichageFournisseur = new AffichageFournisseur(persistanceSQLServer, code);
                    affichageFournisseur.Show();
                }
            }
            else
            {
                MessageBox.Show("Le code est invalide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
