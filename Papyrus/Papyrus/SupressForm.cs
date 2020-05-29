using ClassLibraryInterfacePersistanceMetier;
using ClassLibraryMetier;
using ClassLibraryPersistanceSqlServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Papyrus
{
    public partial class SupressForm : Form
    {
        private int numero;

        PersitanceContact persitanceContact;

        public SupressForm()
        {
            numero = -1;
            InitializeComponent();
            persitanceContact = new PersitanceContact(ConfigurationManager.ConnectionStrings["papyrus"].ConnectionString);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            bool ok = int.TryParse(this.textBoxNumero.Text, out numero) && numero > 0;
            if (ok)
            {
                StructContact contact = persitanceContact.GetContact(numero);
                if(persitanceContact.DeleteContact(contact))
                {
                    MessageBox.Show("Suppression réussie");
                    Trace.TraceInformation(DateTime.Now + " Suppression du contact : " + textBoxNumero.Text + "\n");
                }
                else
                {
                    MessageBox.Show("Contact inexistant", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Trace.Fail(DateTime.Now + " Tentative de suppression du contact inexistant : " + textBoxNumero.Text + "\n");
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
