using ProductionCaisses;
using System;
//using SerializableProd;

namespace ConsoleAppProd
{
    class Program
    {
        static void Main(string[] args)
        {

            //SerialProd prod = new SerialProd();
            //prod.Type = 'A';
            //prod.NbAProduire = 1000;

            //IFormatter formatter = new BinaryFormatter();
            //Stream stream = new FileStream("C:/Users/beyer/OneDrive/Travail/Repos/ToutEmbal V3/SerializableProd/data.txt", FileMode.Create, FileAccess.Write);

            //formatter.Serialize(stream, prod);

            //stream.Close();

            //stream = new FileStream("C:/Users/beyer/OneDrive/Travail/Repos/ToutEmbal V3/SerializableProd/data.txt", FileMode.Open, FileAccess.Read);

            //SerialProd prod1 = (SerialProd)formatter.Deserialize(stream);
            //stream.Close();

            //Console.WriteLine(prod1);

        }

        private static void Production_ErreurEstApparue(Production _prod, int _nbCaisseNonConforme, decimal _tauxErreurActuel)
        {
            Console.WriteLine($"Production échouée => Production {_prod.Type} Nombre d'erreurs : {_nbCaisseNonConforme} Taux d'erreur : {_tauxErreurActuel:0.0000}");
        }

        private static void Production_QteProductionChange(Production _prod, int _nouvelleQte, int _nouveauPourcentage, decimal _tauxErreurActuel)
        {
            Console.WriteLine($"Production réussie => Production {_prod.Type} Production Terminée : {_nouvelleQte} Pourcentage Terminé : {_nouveauPourcentage} Taux d'erreur : {_tauxErreurActuel:0.0000}");
        }

        private static void Production_EtatProductionChange(Production _senderProd, EnumEtatProduction _nouvelEtat)
        {
            Console.WriteLine($"Etat de la production {_senderProd.Type} : {_nouvelEtat}");
        }

    }
}
