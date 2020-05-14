using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLApp
{
    public partial class SupressForm : Form
    {
        private int numero;

        private SqlConnection sqlConnection;

        public SupressForm(SqlConnection sqlConnection)
        {
            numero = -1;
            this.sqlConnection = sqlConnection;
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            bool ok = int.TryParse(this.textBoxNumero.Text, out numero) && numero > 0;
            if (ok)
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = this.sqlConnection;

                sqlCommand.CommandText = "DELETE FROM CONTACT WHERE id_contact = @pid_contact";

                SqlParameter pCodeFournisseur = new SqlParameter("@pid_contact", SqlDbType.Int);

                pCodeFournisseur.Value = numero;
                sqlCommand.Parameters.Add(pCodeFournisseur);

                int nb = sqlCommand.ExecuteNonQuery();

                if(nb == 0)
                {
                    MessageBox.Show("Le fournisseur n'existe pas", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Trace.Fail(DateTime.Now + " Tentative de suppression numero inexistant : " +  numero + "\n");
                }
                else
                {
                    MessageBox.Show("Suppression réussie");
                    Trace.TraceInformation("Suppression du fournisseur : " + numero);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Numéro invalide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.Fail(DateTime.Now + " Tentative de suppression numero invalide : " + textBoxNumero.Text + "\n");
            }
            Trace.Flush();
        }
    }
}
