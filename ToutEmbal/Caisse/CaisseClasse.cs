using System;

namespace Caisse
{
    public class CaisseClasse
    {
        char type;
        int nbProduitPerMinutes;

        public CaisseClasse()
        {
            this.type = '0';
            this.nbProduitPerMinutes = 0;
        }

        public CaisseClasse(char type, int nbProduitPerHour)
        {
            this.type = type;
            this.nbProduitPerMinutes = nbProduitPerHour / 60;
        }

        public int NbProduitPerHour { get => nbProduitPerMinutes; set => nbProduitPerMinutes = value; }
        public char Type { get => type; set => type = value; }
    }
}
