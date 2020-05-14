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
    public partial class UCProgressionProduction : UserControl
    {
        string nom;
        public UCProgressionProduction()
        {
            InitializeComponent();
        }


        public string NomProduction { get => this.labelNomProduction.Text; set => this.labelNomProduction.Text = value; }
        public int ValeurBarreProgression { get => this.progressBarProduction.Value; set => this.progressBarProduction.Value = value; }
        public Color ColorLabelProd { get => labelNomProduction.ForeColor; set => labelNomProduction.ForeColor = value; }
        public string Nom { get => nom; set => nom = value; }
    }
}
