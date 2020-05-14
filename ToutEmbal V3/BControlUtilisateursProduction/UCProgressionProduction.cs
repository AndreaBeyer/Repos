using System.Drawing;
using System.Windows.Forms;

namespace BControlUtilisateursProduction
{
    public partial class UCProgressionProduction : UserControl
    {
        public UCProgressionProduction()
        {
            InitializeComponent();
        }


        public string NomProduction { get => this.labelNomProduction.Text; set => this.labelNomProduction.Text = value; }
        public int ValeurBarreProgression { get => this.progressBarProduction.Value; set => this.progressBarProduction.Value = value; }
        public Color ColorLabelProd { get => labelNomProduction.ForeColor; set => labelNomProduction.ForeColor = value; }
    }
}
