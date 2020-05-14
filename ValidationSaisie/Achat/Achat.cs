using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personnes;


namespace Achats
{
    public class Achat 
    {
        private double montant;
        private Personne client;
        private DateTime date;
        private string codePostal;

        public Achat(double montant, Personne client, DateTime date, string codePostal)
        {
            Montant = montant;
            Client = client;
            Date = date;
            CodePostal = codePostal;
        }

        public Achat()
        {
            Montant = 0;
            Date = new DateTime(11/11/2020);
            Client = new Personne();
            CodePostal = "12345";

        }

        public Achat(Achat achatACloner)
        {
            this.montant = achatACloner.montant;
            this.client = new Personne(achatACloner.client);
            this.date = achatACloner.date;
            this.codePostal = achatACloner.codePostal;
        }

        public override string ToString()
        {
            string rep = $"Nom : {client.Nom}\n" +
                        $"Date : {date.ToShortDateString()}\n" +
                        $"Montant : {montant}\n" +
                        $"Code Postal : {codePostal}";

            return rep;
        }

        public double Montant { get => montant; set => montant = value; }
        public DateTime Date { get => date; set => date = value; }
        public string CodePostal { get => codePostal; set => codePostal = value; }
        public Personne Client { get => client; set => client = value; }
    }
}
