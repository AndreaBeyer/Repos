using System;
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

namespace MySQLApp
{
    public partial class FormBDD : Form
    {
        SqlConnection sqlConnection;
        public FormBDD()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new SqlConnection();

                if(this.textBoxBDD.Text == "" && this.textBoxServer.Text == "")
                {
                    sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["papyrus"].ConnectionString;
                }
                else
                {
                    sqlConnection.ConnectionString = @"Data Source=" + this.textBoxServer.Text + "; Initial Catalog=" + this.textBoxBDD.Text + "; Integrated Security=True\"providerName = \"System.Data.SqlClient";

                    ConfigurationManager.ConnectionStrings.Add(new ConnectionStringSettings(this.textBoxBDD.Text, sqlConnection.ConnectionString));
                }              

                sqlConnection.Open();
                labelEtatBDD.Text = "Open";
                textBoxBDDLogs.Visible = false;
                this.UpdateIHM();
                Trace.TraceInformation(DateTime.Now + " Connection réussie " + sqlConnection.Database);
            }
            catch(Exception e1)
            {
                textBoxBDDLogs.Visible = true;
                textBoxBDDLogs.Text = e1.Message;
                if(sqlConnection != null)
                {
                    sqlConnection.Close();
                }
                Trace.TraceError(DateTime.Now + " Tentative de connection échouée : " + textBoxBDD.Text + ":" + textBoxServer.Text);
            }
            finally
            {
                Trace.Flush();
            }
            
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if(sqlConnection != null)
            {
                sqlConnection.Close();
                sqlConnection = null;
                UpdateIHM();
            }
            
        }

        private void buttonRecherche_Click(object sender, EventArgs e)
        {
            RechercheFournisseur rechercheFournisseur = new RechercheFournisseur(sqlConnection);
            rechercheFournisseur.Show();
        }

        private void UpdateIHM()
        {
            if(sqlConnection == null)
            {
                textBoxBDDLogs.Text = "";
                textBoxBDDLogs.Visible = false;
                labelEtatBDD.Text = "Closed";
                textBoxBDD.Text = "";
                textBoxServer.Text = "";
            }
            else
            {
                this.textBoxBDD.Text = sqlConnection.Database;
                this.textBoxServer.Text = sqlConnection.DataSource;
            }
        }

        private void buttonCommandes_Click(object sender, EventArgs e)
        {
            if(sqlConnection != null)
            {
                ListeCommandes listeCommandes = new ListeCommandes(sqlConnection);
                listeCommandes.Show();
            }
        }

        private void buttonCreation_Click(object sender, EventArgs e)
        {
            if(sqlConnection != null)
            {
                AffichageFournisseur affichage = new AffichageFournisseur(sqlConnection);
                affichage.Show();
            }
            
        }

        private void buttonSuppression_Click(object sender, EventArgs e)
        {
            if(sqlConnection != null)
            {
                SupressForm supressForm = new SupressForm(sqlConnection);
                supressForm.Show();
            }
            
        }
    }
}
