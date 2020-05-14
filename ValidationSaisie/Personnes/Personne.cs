using System;
using System.Collections.Generic;
using System.Text;

namespace Personnes
{
    public class Personne
    {
        string nom;
        public Personne()
        {
            this.Nom = null;
        }

        public Personne(string nom)
        {
            this.Nom = nom;
        }

        public Personne(Personne personneACloner)
        {
            this.Nom = personneACloner.Nom;
        }

        public string Nom { get => nom; set => nom = value; }
    }
}
