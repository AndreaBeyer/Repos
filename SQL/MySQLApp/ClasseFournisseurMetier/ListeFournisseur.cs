using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseFournisseurMetier
{
    public static class ListeFournisseur
    {
        private static List<Fournisseur> fournisseurs;

        public static List<Fournisseur> Fournisseurs { get => fournisseurs; set => fournisseurs = value; }

        public static Fournisseur SearchFournisseur(int _codeFournisseur)
        {
            int i = 0;
            while(fournisseurs[i].CodeFournisseur != _codeFournisseur)
            {
                if(fournisseurs[i].CodeFournisseur == _codeFournisseur)
                {
                    Fournisseur fournisseur = fournisseurs[i];
                    return fournisseur;
                }
                else
                {
                    i++;
                }
            }
            return null;
        }
    }
}
