using System;

namespace ContactMetier
{
    public class Contact
    {
        private static int oldNumber = 0;

        private int id;
        private string nom;
        private string num_rue;
        private string ville;
        private string code_postal;
        private string personne_contact;
        private int satisfaction;


        public Contact(string nom, string num_rue, string ville, string code_postal, string personne_contact, int satisfaction)
        {
            this.nom = nom;
            this.num_rue = num_rue;
            this.ville = ville;
            this.code_postal = code_postal;
            this.personne_contact = personne_contact;
            this.satisfaction = satisfaction;
            this.id = oldNumber++;
        }
    }
}
