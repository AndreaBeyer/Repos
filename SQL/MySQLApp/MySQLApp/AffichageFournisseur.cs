using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryContact;

namespace MySQLApp
{
    public partial class AffichageFournisseur : Form
    {
        private SqlConnection sqlConnection;

        private bool createMode;

        private int codeFournisseur;
        private string num_rue_contact;
        private string personne_contact;
        private string cp_contact;
        private string ville_contact;
        private string nom_contact;
        private string rue_contact;
        private int satisfaction_contact;

        public AffichageFournisseur(SqlConnection sqlConnection, int codeFournisseur)
        {
            InitializeComponent();

            createMode = false;

            this.codeFournisseur = codeFournisseur;

            this.sqlConnection = sqlConnection;

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = this.sqlConnection;

            SqlDataReader sqlDataReader = null;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "SearchAllContact";

            SqlParameter pCodeFournisseur = new SqlParameter("@pid_contact", SqlDbType.Int);

            pCodeFournisseur.Value = codeFournisseur;
            sqlCommand.Parameters.Add(pCodeFournisseur);

            sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                textBoxNom.Text = sqlDataReader.GetString(3);
                
                textBoxNumRue.Text = sqlDataReader.GetString(2);
                
                textBoxAdresse.Text = sqlDataReader.GetString(1);
                
                textBoxCP.Text = sqlDataReader.GetString(5);
                
                textBoxVille.Text = sqlDataReader.GetString(4);
                
                textBoxContact.Text = sqlDataReader.GetString(6);
                
                textBoxSatisfaction.Text = sqlDataReader.GetInt32(7).ToString();
            }

            sqlDataReader.Close();

        }

        public AffichageFournisseur(SqlConnection sqlConnection)
        {
            InitializeComponent();

            this.sqlConnection = sqlConnection;
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
                rue_contact = textBoxAdresse.Text;
                num_rue_contact = textBoxNumRue.Text;
                nom_contact = textBoxNom.Text;

                if (createMode)
                {
                    if(!Contact.Create(nom_contact, num_rue_contact, rue_contact, ville_contact, cp_contact, personne_contact, satisfaction_contact, sqlConnection))
                    {
                        MessageBox.Show("Une ou plusieurs valeurs invalide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Création réussie");
                        this.Close();
                    }
                }
                else
                {
                    if (!Contact.Update(nom_contact, num_rue_contact, rue_contact, ville_contact, cp_contact, personne_contact, satisfaction_contact, sqlConnection, codeFournisseur))
                    {
                        MessageBox.Show("Echec de la mise à jour", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Mise à jour réussie");
                        this.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Une ou plusieurs valeurs invalide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.Fail(DateTime.Now + " " + ex.Message + "\n");
            }
            finally
            {
                Trace.Flush();
            }

        }
    }
}
