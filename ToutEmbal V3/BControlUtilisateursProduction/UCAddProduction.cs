using System.Windows.Forms;

namespace BControlUtilisateursProduction
{
    public partial class UCAddProduction : UserControl
    {
        public UCAddProduction()
        {
            InitializeComponent();
        }

        public string NbCaisseToAdd { get => textBoxNbCaisse.Text; set => textBoxNbCaisse.Text = value; }
        public string TypeCaisseToAdd { get => textBoTypeCaisse.Text; set => textBoTypeCaisse.Text = value; }


    }
}
