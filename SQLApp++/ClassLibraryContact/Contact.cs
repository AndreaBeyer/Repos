using ClassLibraryPersistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryContact
{
    public class Contact
    {
        private string nom;
        private string num_rue;
        private string rue;
        private string ville;
        private string code_postal;
        private string personne_contact;
        private int satisfaction;

        public Contact(string nom, string num_rue, string rue, string ville, string code_postal, string personne_contact, int satisfaction)
        {
            this.nom = nom;
            this.num_rue = num_rue;
            this.rue = rue;
            this.ville = ville;
            this.code_postal = code_postal;
            this.personne_contact = personne_contact;
            this.satisfaction = satisfaction;
        }

        public string AddToSQlServer(string server, string bdd)
        {
            string logs = "";

            //try
            //{
            //    PersistanceSQLServer persistanceSQLServer = new PersistanceSQLServer(server, bdd);

            //}

            return logs;

        }



        public string Nom { get => nom; set => nom = value; }
        public string Num_rue { get => num_rue; set => num_rue = value; }
        public string Rue { get => rue; set => rue = value; }
        public string Ville { get => ville; set => ville = value; }
        public string Code_postal { get => code_postal; set => code_postal = value; }
        public string Personne_contact { get => personne_contact; set => personne_contact = value; }
        public int Satisfaction { get => satisfaction; set => satisfaction = value; }
    }
}
