using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMetier
{
    public class Meteo
    {
        private EnumTemps temps;
        private decimal temperature;
        public delegate void MonDelegatePourLeSoleilVientDapparaitre();
        public event MonDelegatePourLeSoleilVientDapparaitre LeSoleilVientDapparaitre;

        public delegate void MonDelegatePourTemperatureChange(decimal _temperature);
        public event MonDelegatePourTemperatureChange LaTemperatureAChanger;

        public Meteo():this(EnumTemps.Pluie,0)
        {
        }

        public Meteo(EnumTemps temps, decimal temperature)
        {
            this.temps = temps;
            this.temperature = temperature;
        }

        public EnumTemps Temps { get => temps; }

        public void ChangeLetemps()
        {
            this.temps = EnumTemps.Soleil;
            GenererEvenementLeSoleilVientDapparaitre();
        }

        private void GenererEvenementLeSoleilVientDapparaitre()
        {
            if (LeSoleilVientDapparaitre != null)//verifie que qq s'est enregistre sur l'evenement
            {
                LeSoleilVientDapparaitre();//genere l'evenement
            }
        }

        public void ChangerTemperature(decimal _nouvelleTemperature)
        {
            this.temperature = _nouvelleTemperature;
            GenererEvenementChangeTemperature(_nouvelleTemperature);
        }

        private void GenererEvenementChangeTemperature(decimal _nouvelleTemperature)
        {
            if(LaTemperatureAChanger != null)
            {
                LaTemperatureAChanger(_nouvelleTemperature);
            }
        }
    }
}
