using ClassLibraryPersistance;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLApp__
{
    public partial class AffichageFournisseur : Form
    {
        private bool createMode;

        private int codeFournisseur;
        private string num_rue_contact;
        private string personne_contact;
        private string cp_contact;
        private string ville_contact;
        private string nom_contact;
        private string rue_contact;
        private int satisfaction_contact;

        private PersistanceSQLServer persistanceSQLServer;

        public AffichageFournisseur(PersistanceSQLServer persistanceSQLServer, int codeFournisseur)
        {
            InitializeComponent();
            this.persistanceSQLServer = persistanceSQLServer;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pid_contact", codeFournisseur);
            ArrayList list = persistanceSQLServer.ExecuteDataReader(parameters, "SearchAllContact");

            textBoxNom.Text = list[3].ToString();
            textBoxNumRue.Text = list[2].ToString();
            textBoxRue.Text = list[1].ToString();
            textBoxCP.Text = list[5].ToString();
            textBoxVille.Text = list[4].ToString();
            textBoxContact.Text = list[3].ToString();
            textBoxSatisfaction.Text = list[7].ToString();

            createMode = false;
        }

        public AffichageFournisseur(PersistanceSQLServer persistanceSQLServer)
        {
            InitializeComponent();

            this.persistanceSQLServer = persistanceSQLServer;
            buttonMAJ.Text = "Creer";
            createMode = true;
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMAJ_Click(object sender, EventArgs e)
        {
            try
            {
                satisfaction_contact = int.Parse(textBoxSatisfaction.Text);
                personne_contact = textBoxContact.Text;
                ville_contact = textBoxVille.Text;
                cp_contact = textBoxCP.Text;
                rue_contact = textBoxRue.Text;
                num_rue_contact = textBoxNumRue.Text;
                nom_contact = textBoxNom.Text;

                Dictionary<string, object> parameters = new Dictionary<string, object>();

                parameters.Add("@prue_contact", rue_contact);
                parameters.Add("@pnum_rue_contact", num_rue_contact);
                parameters.Add("@pnom_contact", nom_contact);
                parameters.Add("@pville_contact", ville_contact);
                parameters.Add("@pcp_contact", cp_contact);
                parameters.Add("@ppersonne_contact", nom_contact);
                parameters.Add("@psatisfaction_contact", satisfaction_contact);

                if (createMode)
                {
                    string logs = persistanceSQLServer.ExecuteNonQuery(parameters, "CreateContact");

                    if(logs != "")
                    {
                        MessageBox.Show("Les champs ne sont pas valides", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Création réussie");
                    }

                }
            }
            catch
            {

            }
        }
    }
}
