using ClassLibraryInterfacePersistanceMetier;
using ClassLibraryMetier;
using ClassLibraryPersistanceSqlServer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Papyrus
{
    public partial class AffichageFournisseur : Form
    {
        private bool createMode;
        private PersitanceContact persitanceContact;
        private int id;
        public AffichageFournisseur()
        {
            InitializeComponent();
            createMode = true;
            this.buttonMAJ.Text = "Créer";

            this.persitanceContact = new PersitanceContact(ConfigurationManager.ConnectionStrings["papyrus"].ConnectionString);
        }

        public AffichageFournisseur(int id)
        {
            InitializeComponent();
            createMode = false;

            this.id = id;

            this.persitanceContact = new PersitanceContact(ConfigurationManager.ConnectionStrings["papyrus"].ConnectionString);

            Contact contact = new Contact(persitanceContact.GetContact(id));

            textBoxNom.Text = contact.nom;

            textBoxNumRue.Text = contact.num_rue;

            textBoxRue.Text = contact.rue;

            textBoxCP.Text = contact.code_postal;

            textBoxVille.Text = contact.ville;

            textBoxContact.Text = contact.personne_contact;

            textBoxSatisfaction.Text = contact.satisfaction.ToString();


        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMAJ_Click(object sender, EventArgs e)
        {

            try
            {
                int satisfaction = int.Parse(textBoxSatisfaction.Text);

                Contact contact = new Contact(textBoxNom.Text, textBoxNumRue.Text, textBoxRue.Text, textBoxVille.Text, textBoxCP.Text, textBoxContact.Text, satisfaction);

                if (createMode)
                {
                    contact.Save();
                    MessageBox.Show("Création réussie");
                    Trace.TraceInformation($"{DateTime.Now} Création réussie du contact {textBoxNom.Text}");
                }
                else
                {
                    if (contact.Save())
                    {
                        MessageBox.Show("Mise à jour réussie");
                    }
                    else
                    {
                        MessageBox.Show("Echec de la mise à jour", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Une ou plusieurs valeurs invalide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.TraceError($"{DateTime.Now} Tentative de création d'un contact avec des valeurs invalides {ex.Message}");
            }

            Trace.Flush();
        }
    }
}
