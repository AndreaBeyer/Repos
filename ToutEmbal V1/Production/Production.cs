using ProductionCaisses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ProductionCaisses
{
    public class Production // : INotifyPropertyChanged
    {
        private EnumEtatProduction etatCourantDeLaProduction;
        private int nbCaissesProduite;
        private int nbCaissesNonConforme;
        private int nbCaissesAProduire;
        private int tpsEcouleDeProduction;

       // public event PropertyChangedEventHandler PropertyChanged;


        //protected void OnPropertyChanged()
        //{
        //    if(PropertyChanged != null)
        //    {
        //        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(null));
        //    }
        //}



        public int NbCaissesProduite
        {
            get { return nbCaissesProduite; }

            set
            {
                nbCaissesProduite = value;
                //OnPropertyChanged();
            }

        }
        public EnumEtatProduction EtatCourantDeLaProduction         
        { 
            get { return etatCourantDeLaProduction; }
            
            set
            {
                etatCourantDeLaProduction = value;
                //OnPropertyChanged();
            }
        
        }
        public int NbCaissesNonConforme { get => nbCaissesNonConforme; private set => nbCaissesNonConforme = value; }
        public int TpsEcouleDeProduction { get => tpsEcouleDeProduction; set => tpsEcouleDeProduction = value; }

        public Production():this(0)
        {
        }

        public Production(int _nbCaisseAProduire)
        {
            EtatCourantDeLaProduction = EnumEtatProduction.AttenteDemarrage;
            this.nbCaissesAProduire = _nbCaisseAProduire;
            this.NbCaissesProduite = this.NbCaissesNonConforme = this.TpsEcouleDeProduction = 0;
        }
    

    public void Demarrer()
        {
            //if(EtatCourantDeLaProduction == EnumEtatProduction.Termine)
            //{
            //    this.EtatCourantDeLaProduction = EnumEtatProduction.AttenteDemarrage;
            //}
            if(EtatCourantDeLaProduction == EnumEtatProduction.AttenteDemarrage)
            {
                this.EtatCourantDeLaProduction = EnumEtatProduction.EnCours;
            }

            
        }

        public void Suspendre()
        {
            if(EtatCourantDeLaProduction == EnumEtatProduction.EnCours)
            {
                this.EtatCourantDeLaProduction = EnumEtatProduction.Suspendu;
            }
        }

        public void Redemarrer()
        {
            if(EtatCourantDeLaProduction == EnumEtatProduction.Suspendu)
            {
                this.EtatCourantDeLaProduction = EnumEtatProduction.EnCours;
            }
        }

        public void AjouterDesCaisses()
        {

            if (EtatCourantDeLaProduction == EnumEtatProduction.EnCours)
            {
                Random random = new Random();

                if (random.Next(1, 11) > 2)
                {
                    NbCaissesProduite++;
                }
                else
                {
                    NbCaissesNonConforme++;
                }

                if (NbCaissesProduite == nbCaissesAProduire)
                {
                    this.EtatCourantDeLaProduction = EnumEtatProduction.Termine;
                }
            }
            
        }

        public int GetPourcentageProductionTerminate()
        {
            return NbCaissesProduite * 100 / nbCaissesAProduire;
        }
    }
}
