using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLApp
{
    public partial class RechercheFournisseur : Form
    {
        private SqlConnection sqlConnection;
        public RechercheFournisseur(SqlConnection sqlConnection)
        {
            InitializeComponent();
            this.sqlConnection = sqlConnection;
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string codeFournisseurString = textBoxCodeFournisseur.Text;

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = this.sqlConnection;

            SqlDataReader sqlDataReader;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "SearchContact";

            try
            {
                SqlParameter pCodeFournisseur = new SqlParameter("@pid_contact", SqlDbType.Int);

                pCodeFournisseur.Value = textBoxCodeFournisseur.Text;
                sqlCommand.Parameters.Add(pCodeFournisseur);

                sqlDataReader = sqlCommand.ExecuteReader();
                bool ok = sqlDataReader.Read();

                if (ok)
                {
                    int codeFournisseur = sqlDataReader.GetInt32(0);
                    sqlDataReader.Close();
                    AffichageFournisseur affichage = new AffichageFournisseur(sqlConnection, codeFournisseur);
                    affichage.Show();
                }
                else
                {
                    MessageBox.Show("Le code fournisseur est inexistant", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Entrée invalide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



}
    }
}
