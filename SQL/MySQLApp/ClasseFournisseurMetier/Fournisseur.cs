using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseFournisseurMetier
{
    public class Fournisseur
    {
        private string nomFournisseur;
        private string adresseFournisseur;
        private string cpFournisseur;
        private string villeFournisseur;
        private string contactFournisseur;
        private string satisfactionFournisseur;
        private int codeFournisseur;

        public Fournisseur(string nomFournisseur, string adresseFournisseur, string cpFournisseur, string villeFournisseur, string contactFournisseur, string satisfactionFournisseur, int codeFournisseur)
        {
            this.nomFournisseur = nomFournisseur;
            this.adresseFournisseur = adresseFournisseur;
            this.cpFournisseur = cpFournisseur;
            this.villeFournisseur = villeFournisseur;
            this.contactFournisseur = contactFournisseur;
            this.satisfactionFournisseur = satisfactionFournisseur;
            this.codeFournisseur = codeFournisseur;
        }

        public Fournisseur()
        {
            this.nomFournisseur = null;
            this.adresseFournisseur = null;
            this.cpFournisseur = null;
            this.villeFournisseur = null;
            this.contactFournisseur = null;
            this.satisfactionFournisseur = null;
            this.codeFournisseur = -1;
        }

        public string NomFournisseur { get => nomFournisseur; set => nomFournisseur = value; }
        public string AdresseFournisseur { get => adresseFournisseur; set => adresseFournisseur = value; }
        public string CpFournisseur { get => cpFournisseur; set => cpFournisseur = value; }
        public string VilleFournisseur { get => villeFournisseur; set => villeFournisseur = value; }
        public string ContactFournisseur { get => contactFournisseur; set => contactFournisseur = value; }
        public string SatisfactionFournisseur { get => satisfactionFournisseur; set => satisfactionFournisseur = value; }
        public int CodeFournisseur { get => codeFournisseur; set => codeFournisseur = value; }

        public override bool Equals(object obj)
        {
            return obj is Fournisseur fournisseur;
        }
    }
}
