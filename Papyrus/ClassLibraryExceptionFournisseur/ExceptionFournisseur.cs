using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExceptionFournisseur
{
    public class ExceptionFournisseur : Exception
    {
        public ExceptionFournisseur() : base("Erreur sur le fournisseur")
        {
        }

        public ExceptionFournisseur(string nom) : base($"Erreur sur le fournisseur {nom}")
        {
        }

        public ExceptionFournisseur(int id) : base($"Erreur sur le fournisseur numéro {id}")
        {
        }
    }
}
