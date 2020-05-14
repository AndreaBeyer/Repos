using System;
using System.Threading;
using Alea;

namespace ProductionCaisses
{
    [Serializable]
    public class Production
    {
        private EnumEtatProduction etatCourantDeLaProduction;
        private int nbCaissesProduite;
        private int nbCaissesNonConforme;
        private int NbCaissesAProduire;
        private int tpsEcouleDeProduction;
        private char type;

        public delegate void LaProductionAReussie(Production _prod, int _nouvelleQte, int _nouveauPourcentage, decimal _tauxErreurActuel);
        public delegate void UneErreurEstApparue(Production _prod, int _nbCaisseNonConforme, decimal _tauxErreurActuel);
        public delegate void LEtatDeLaProdAChange(Production _prod, EnumEtatProduction _nouvelEtat);

        [field: NonSerialized]
        public event LaProductionAReussie ProductionReussie;
        [field: NonSerialized]
        public event UneErreurEstApparue ErreurEstApparue;
        [field: NonSerialized]
        public event LEtatDeLaProdAChange EtatProductionChange;


        public int TpsEcouleDeProduction { get => tpsEcouleDeProduction; set => tpsEcouleDeProduction = value; }

        public int NbCaissesNonConforme
        {
            get { return nbCaissesNonConforme; }

            set
            {
                nbCaissesNonConforme = value;
                NotificationErreurEstApparue();
            }

        }

        public int NbCaissesProduite
        {
            get { return nbCaissesProduite; }

            set
            {
                nbCaissesProduite = value;
                NotificationProductionReussie();
            }

        }
        public EnumEtatProduction EtatCourantDeLaProduction
        {
            get { return etatCourantDeLaProduction; }

            set
            {
                etatCourantDeLaProduction = value;
                NotificationChangementEtatProduction();
            }

        }

        public char Type { get => type; set => type = value; }
        public int NbCaissesAProduire1 { get => NbCaissesAProduire; set => NbCaissesAProduire = value; }

        public Production() : this(0, ' ')
        {
        }


        public Production(int _nbCaisseAProduire, char _type)
        {
            this.EtatCourantDeLaProduction = EnumEtatProduction.AttenteDemarrage;
            this.NbCaissesAProduire1 = _nbCaisseAProduire;
            this.Type = _type;

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
            if (EtatCourantDeLaProduction == EnumEtatProduction.EnCours)
            {
                this.EtatCourantDeLaProduction = EnumEtatProduction.Suspendu;
            }
        }

        public void Redemarrer()
        {
            if (EtatCourantDeLaProduction == EnumEtatProduction.Suspendu)
            {
                this.EtatCourantDeLaProduction = EnumEtatProduction.EnCours;
                Thread th = new Thread(AjouterDesCaisses);
                th.Start();
            }
        }

        public void AjouterDesCaisses()
        {
            while (EtatCourantDeLaProduction != EnumEtatProduction.Termine)
            {
                if (EtatCourantDeLaProduction == EnumEtatProduction.EnCours)
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

                    if (NbCaissesProduite == NbCaissesAProduire1)
                    {
                        EtatCourantDeLaProduction = EnumEtatProduction.Termine;
                    }
                }
            }
        }

        public int GetPourcentageProductionTerminate()
        {
            if (NbCaissesAProduire1 == 0)
            {
                return 0;
            }
            return NbCaissesProduite * 100 / NbCaissesAProduire1;
        }

        public decimal GetTauxErreurDemarrage()
        {
            if (nbCaissesProduite == 0)
            {
                return 0;
            }
            return NbCaissesNonConforme / (decimal)NbCaissesProduite * 100;
        }

    }
}
