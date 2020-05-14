using ProductionCaisses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using Alea;


namespace ProductionCaisses
{
    public class Production
    {
        private EnumEtatProduction etatCourantDeLaProduction;
        private int nbCaissesProduite;
        private int nbCaissesNonConforme;
        private int nbCaissesAProduire;
        private int tpsEcouleDeProduction;
        private char type;

        public delegate void LaProductionAReussie(Production _prod, int _nouvelleQte, int _nouveauPourcentage, decimal _tauxErreurActuel);
        public delegate void UneErreurEstApparue(Production _prod, int _nbCaisseNonConforme, decimal _tauxErreurActuel);
        public delegate void LEtatDeLaProdAChange(Production _prod, EnumEtatProduction _nouvelEtat);

        public event LaProductionAReussie ProductionReussie;
        public event UneErreurEstApparue ErreurEstApparue;
        public event LEtatDeLaProdAChange EtatProductionChange;


        public int TpsEcouleDeProduction { get => tpsEcouleDeProduction; set => tpsEcouleDeProduction = value; }
        public char Type { get => type; }

        public int NbCaissesNonConforme
        {
            get { return nbCaissesNonConforme; }

            private set
            {
                nbCaissesNonConforme = value;
                NotificationErreurEstApparue();
            }

        }

        public int NbCaissesProduite
        {
            get { return nbCaissesProduite; }

            private set
            {
                nbCaissesProduite = value;
                NotificationProductionReussie();
            }

        }
        public EnumEtatProduction EtatCourantDeLaProduction
        {
            get { return etatCourantDeLaProduction; }

           private set
            {
                etatCourantDeLaProduction = value;
                NotificationChangementEtatProduction();
            }

        }

        public Production() : this(0, ' ')
        {
        }

        public Production(int _nbCaisseAProduire, char _type)
        {
            this.EtatCourantDeLaProduction = EnumEtatProduction.AttenteDemarrage;
            this.nbCaissesAProduire = _nbCaisseAProduire;
            this.type = _type;

            this.NbCaissesProduite = 0;
            this.NbCaissesNonConforme = 0;
            this.TpsEcouleDeProduction = 0;
        }

        private void NotificationProductionReussie()
        {
            if (ProductionReussie != null)
            {
                ProductionReussie(this, nbCaissesProduite, GetPourcentageProductionTerminate(), GetTauxErreurDemarrage());
            }
        }

        private void NotificationErreurEstApparue()
        {
            if (ErreurEstApparue != null)
            {
                ErreurEstApparue(this, nbCaissesNonConforme, GetTauxErreurDemarrage());
            }
        }

        private void NotificationChangementEtatProduction()
        {
            if (EtatProductionChange != null)
            {
                EtatProductionChange(this, EtatCourantDeLaProduction);
            }
        }
      
        public void Demarrer()
        {
            if (EtatCourantDeLaProduction == EnumEtatProduction.AttenteDemarrage)
            {
                this.EtatCourantDeLaProduction = EnumEtatProduction.EnCours;
                Thread th = new Thread(AjouterDesCaisses);
                th.Start();
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
            while (EtatCourantDeLaProduction != EnumEtatProduction.Termine)
            {
                if(EtatCourantDeLaProduction == EnumEtatProduction.EnCours)
                {
                    Thread.Sleep(10);

                    if (MyAlea.Instance().Nouveau(1, 11) > 2)
                    {
                        NbCaissesProduite++;
                    }
                    else
                    {
                        NbCaissesNonConforme++;
                    }

                    if (NbCaissesProduite == nbCaissesAProduire)
                    {
                        EtatCourantDeLaProduction = EnumEtatProduction.Termine;
                    }
                }
            }
        }

        public int GetPourcentageProductionTerminate()
        {
            return NbCaissesProduite * 100 / nbCaissesAProduire;
        }

        public decimal GetTauxErreurDemarrage()
        {
            if(nbCaissesProduite == 0)
            {
                return 0;
            }
            return NbCaissesNonConforme / (decimal)NbCaissesProduite * 100;
        }

    }
}
