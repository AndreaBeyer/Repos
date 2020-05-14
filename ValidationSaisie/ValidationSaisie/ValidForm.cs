using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Achats;
using VerificationForm;
using Personnes;

namespace ValidationSaisie
{
    public partial class ValidForm : Form
    {
        Achat myAchat;
        bool editB;

        public ValidForm()
        {
            InitializeComponent();

            btnEdit.Visible = false;
            editB = false;

            Date.Text = "01/01/2020";
            Nom.Text = "Defaut";
            CodePostal.Text = "12345";
            Montant.Text = "0";
        }

        public ValidForm(Achat myAchatTmp)
        {
            InitializeComponent();

            Valider.Text = "Editer";

            myAchat = new Achat(myAchatTmp);

            editB = true;
            btnEdit.Visible = false;

            Nom.Text = myAchatTmp.Client.Nom;
            CodePostal.Text = myAchatTmp.CodePostal;
            Date.Text = myAchatTmp.Date.ToLocalTime().ToShortDateString();
            Montant.Text = myAchatTmp.Montant.ToString();
        }


        private void Valider_Click(object sender, EventArgs e)
        {
            if (!editB)
            {
                Valide();
            }
            else
            {
                Edit();
            }
            
             
        }

        private void Edit()
        {
            List<string> errors = new List<string>();

            List<string> success = new List<string>();

            VerifForm.ClearError();

            if (VerifForm.VerificationNom(Nom.Text).Count == 0)
            {
                myAchat.Client.Nom = Nom.Text;
                success.Add("Nom édité avec succès");
            }
            else
            {
                errors.Add("Le nom est invalide");
            }

            if (VerifForm.VerificationCodePostal(CodePostal.Text).Count == 0)
            {
                myAchat.CodePostal = CodePostal.Text;
                success.Add("Code postal édité avec succès");
            }
            else
            {
                errors.Add("Le code postal est invalide");
            }

            if (VerifForm.VerificationDate(Date.Text, out DateTime tempDT).Count == 0)
            {
                myAchat.Date = tempDT;
                success.Add("Date édité avec succès");
            }
            else
            {
                foreach(string error in VerifForm.VerificationDate(Date.Text, out DateTime tmp))
                {
                    errors.Add(error);
                }
                
            }

            if (VerifForm.VerificationMontant(Montant.Text).Count == 0)
            {
                double.TryParse(Montant.Text, out double tempdb);
                myAchat.Montant = tempdb;
                success.Add("Montant édité avec succès");
            }
            else
            {
                errors.Add("Le montant est invalide");
            }

            string tempS = "";

           

            foreach(string su in success)
            {
                if(su != "")
                {
                    tempS += (su + "\n");
                }
            }

            foreach (string error in errors)
            {
                if(error != "")
                {
                    tempS += (error + "\n");
                }
            }


            MessageBox.Show(tempS);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Nom.Text = Date.Text = Montant.Text = CodePostal.Text = "";
        }

        private void ValidForm_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();

            }
            else if(e.KeyCode == Keys.Enter)
            {
                Valide();
            }
        }

        private void Valide()
        {
            VerifForm.ClearError();

            VerifForm.VerificationCodePostal(CodePostal.Text);
            VerifForm.VerificationMontant(Montant.Text);
            VerifForm.VerificationNom(Nom.Text);
            VerifForm.VerificationDate(Date.Text, out DateTime tmp);


            if (VerifForm.Errors.Count == 0)
            {
                Personne client = new Personne(Nom.Text);
                DateTime date = DateTime.Parse(Date.Text);
                string codePostal = CodePostal.Text;
                double montant = double.Parse(Montant.Text);

                myAchat = new Achat(montant, client, date, codePostal);

                MessageBox.Show(myAchat + "\n" +
                    "Inscription réussie !");

                btnEdit.Visible = true;

            }
            else
            {
                string tempS = null;

                foreach (string error in VerifForm.Errors)
                {
                    tempS += (error + "\n");
                }

                MessageBox.Show(tempS);
                VerifForm.ClearError();
            }
        }

        private void Nom_Leave(object sender, EventArgs e)
        {

            /*TextBox temp = (TextBox)sender;

            string tempS = temp.Name;

            switch (tempS)
            {
                case "Nom":
                    VerifForm.VerificationNom(Nom.Text);
                    break;
                case "Montant":
                    VerifForm.VerificationMontant(Montant.Text);
                    break;
                case "CodePostal":
                    VerifForm.VerificationCodePostal(CodePostal.Text);
                    break;
                case "Date":
                    VerifForm.VerificationDate(Date.Text);
                    break;
            }


            if (VerifForm.Errors.Count != 0)
            {
                switch (tempS)
                {
                    case "Nom":
                        errorProvider.SetError(Nom, VerifForm.Errors[0]);
                        break;
                    case "Montant":
                        errorProvider.SetError(Montant, VerifForm.Errors[0]);
                        break;
                    case "CodePostal":
                        errorProvider.SetError(CodePostal, VerifForm.Errors[0]);
                        break;
                    case "Date":
                        errorProvider.SetError(Date, VerifForm.Errors[0]);
                        break;
                }
            }
            else
            {
                errorProvider.Clear();
            }

            VerifForm.ClearError();*/

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ValidForm edit = new ValidForm(myAchat);
            
            editB = true;
            edit.Show();
            this.Hide();
        }

        private void ValidForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
