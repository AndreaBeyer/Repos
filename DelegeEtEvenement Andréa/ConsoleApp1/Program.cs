using ClassLibraryMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Meteo laMeteoDuJour = new Meteo();

            //abonnement a l'evenement
            //laMeteoDuJour.LeSoleilVientDapparaitre += LaMeteoDuJour_LeSoleilVientDapparaitre;



            //Thread.Sleep(1000);
            //laMeteoDuJour.ChangeLetemps();

            laMeteoDuJour.LaTemperatureAChanger += LaTemperatureAChanger;

            Thread.Sleep(1000);
            laMeteoDuJour.ChangerTemperature(20m);

            Console.Read();


        }

        private static void LaMeteoDuJour_LeSoleilVientDapparaitre()
        {
            Console.WriteLine("cool .;je sors!");
        }

        private static void LaTemperatureAChanger(decimal _nouvelleTemperature)
        {
            Console.WriteLine($"La température a changé !\n" +
                $"Elle est dorénavant de {_nouvelleTemperature} degrées Celcius");
        }
    }
}
