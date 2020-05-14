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
    public partial class ListeCommandes : Form
    {
        private SqlConnection sqlConnection;
        public ListeCommandes(SqlConnection sqlConnection)
        {
            InitializeComponent();
            this.sqlConnection = sqlConnection;

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = this.sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "SearchAllContactsByALL";


            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                comboBoxFournisseurs.Items.Add(sqlDataReader.GetValue(0));
            }

            sqlDataReader.Close();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxFournisseurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCommandes.Items.Clear();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = this.sqlConnection;

            SqlParameter pCodeFournisseur = new SqlParameter("@pid_contact", SqlDbType.Int);

            int selectedIndex = comboBoxFournisseurs.SelectedIndex;

            pCodeFournisseur.Value = (int)comboBoxFournisseurs.Items[selectedIndex];


            sqlCommand.Parameters.Add(pCodeFournisseur);

            sqlCommand.CommandText = "select id_commande, date_commande, obs_commande From Commande, Contact where Commande.id_contact = @pid_contact";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                listBoxCommandes.Items.Add(sqlDataReader.GetValue(0) + " " + sqlDataReader.GetDateTime(1).ToString("MM/dd/yyyy") + " " + sqlDataReader.GetValue(2));
            }

            sqlDataReader.Close();
        }
    }
}
