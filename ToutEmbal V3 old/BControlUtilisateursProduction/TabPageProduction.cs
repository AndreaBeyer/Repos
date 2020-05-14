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
    public partial class TabPageProduction : UserControl
    {

        public TabPageProduction()
        {
            InitializeComponent();
        }

        public string NombreErreur { get => NbErreurs.Text; set => NbErreurs.Text = value; }
        public string NombreCaisseDepuisDemarrage { get => NbCaisseDepuisDemarrage.Text; set => NbCaisseDepuisDemarrage.Text = value; }
        public string TauxDefautHeures { get => TauxDefautHeure.Text; set => TauxDefautHeure.Text = value.ToString(); }
        public string TauxDefautDemarrage { get => TauxDefaultDepuisDemarrage.Text; set => TauxDefaultDepuisDemarrage.Text = value; }
    }
}
