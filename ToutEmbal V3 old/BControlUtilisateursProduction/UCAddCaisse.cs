using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BControlUtilisateursProduction
{
    public partial class UCAddCaisse : UserControl
    {
        public UCAddCaisse()
        {
            InitializeComponent();
        }

        public string NbCaisseToAdd { get => textBoxNbCaisse.Text; set => textBoxNbCaisse.Text = value; }
        public string TypeCaisseToAdd { get => textBoTypeCaisse.Text; set => textBoTypeCaisse.Text = value; }

        
    }
}
