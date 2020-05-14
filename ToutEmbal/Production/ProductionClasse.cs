using System;
using Caisse;


namespace Production
{
    public class ProductionClasse
    {
        int NbCaisseAToProduce;
        int NbCaisseBToProduce;
        int NbCaisseCToProduce;

        int nbCaisseALeft;
        int nbCaisseBLeft;
        int nbCaisseCLeft;


        bool ProduceAIsStart;
        bool ProduceBIsStart;
        bool ProduceCIsStart;

        bool ProduceAIsSuspend;
        bool ProduceBIsSuspend;
        bool ProduceCIsSuspend;

        bool ProduceAIsRestart;
        bool ProduceBIsRestart;
        bool ProduceCIsRestart;

        bool ProduceAIsFinish;
        bool ProduceBIsFinish;
        bool ProduceCIsFinish;

        CaisseClasse caisseA;
        CaisseClasse caisseB;
        CaisseClasse caisseC;

        int nbCaisseAProduct;
        int nbCaisseBProduct;
        int nbCaisseCProduct;

        static Random random;

        int tauxDerreurA;
        int tauxDerreurB;
        int tauxDerreurC;

        int nbErreurA, nbErreurB, nbErreurC;
        int counterA, counterB, counterC;


        public ProductionClasse()
        {
            NbCaisseAToProduce = NbCaisseBToProduce = NbCaisseCToProduce = NbCaisseAProduct = NbCaisseBProduct = NbCaisseCProduct = 0;
            ProduceAIsStart = ProduceBIsStart = ProduceCIsStart = ProduceAIsSuspend1 = ProduceBIsSuspend1 = ProduceCIsSuspend1 =
                ProduceAIsRestart1 = ProduceBIsRestart1 = ProduceCIsRestart1 = ProduceAIsFinish1 = ProduceBIsFinish1 = ProduceCIsFinish1 = false;

            nbErreurA = nbErreurB = nbErreurC = counterA = counterB = counterC = 0;

            random = new Random();
            TauxDerreurA = random.Next(1, 10);
            TauxDerreurB = random.Next(1, 10);
            TauxDerreurC = random.Next(1, 10);


        }

        public ProductionClasse(int nbCaisseAToProduce, int nbCaisseBToProduce, int nbCaisseCToProduce, bool produceAIsStart, bool produceBIsStart, bool produceCIsStart)
        {
            NbCaisseAProduct = NbCaisseBProduct = NbCaisseCProduct = 0;
            NbCaisseAToProduce1 = nbCaisseALeft = nbCaisseAToProduce;
            NbCaisseBToProduce1 = NbCaisseBLeft = nbCaisseBToProduce;
            NbCaisseCToProduce1 = nbCaisseCLeft = nbCaisseCToProduce;
            ProduceAIsStart1 = produceAIsStart;
            ProduceBIsStart1 = produceBIsStart;
            ProduceCIsStart1 = produceCIsStart;

            ProduceAIsSuspend1 = ProduceBIsSuspend1 = ProduceCIsSuspend1 =
                ProduceAIsRestart1 = ProduceBIsRestart1 = ProduceCIsRestart1 = ProduceAIsFinish1 = ProduceBIsFinish1 = ProduceCIsFinish1 = false;

            if(nbCaisseAToProduce > 0)
            {
                caisseA = new CaisseClasse('a', 1000);
            }
            if (nbCaisseBToProduce > 0)
            {
                caisseB = new CaisseClasse('b', 5000);
            }
            if (nbCaisseCToProduce > 0)
            {
                caisseC = new CaisseClasse('c', 10000);
            }

            random = new Random();

            TauxDerreurA = random.Next(1, 10);
            TauxDerreurB = random.Next(1, 10);
            TauxDerreurC = random.Next(1, 10);

            nbErreurA = nbErreurB = nbErreurC = counterA = counterB = counterC = 0;

        }


        public void StartProduction(char type)
        {
            switch (type)
            {
                case 'a':
                    ProduceAIsStart = true;
                    if (ProduceAIsFinish)
                    {
                        ProduceAIsFinish = false;
                        nbErreurA = NbCaisseAProduct = 0;
                        nbCaisseALeft = NbCaisseAToProduce;
                    }
                    break;
                case 'b':
                    ProduceBIsStart = true;
                    if (ProduceBIsFinish)
                    {
                        ProduceBIsFinish = false;
                        nbErreurB = NbCaisseBProduct = 0;
                        nbCaisseBLeft = NbCaisseBToProduce;
                    }
                    break;
                case 'c':
                    ProduceCIsStart = true;
                    if (ProduceCIsFinish)
                    {
                        ProduceCIsFinish = false;
                        nbErreurC = NbCaisseCProduct = 0;
                        nbCaisseCLeft = NbCaisseCToProduce;
                    }
                    break;
            }
        }

        public void SuspendProduction(char type)
        {
            switch (type)
            {
                case 'a':
                    if (ProduceAIsStart)
                    {
                        ProduceAIsSuspend1 = true;
                        ProduceAIsStart = false;
                    }
                    
                    break;
                case 'b':
                    if (ProduceBIsStart)
                    {
                        ProduceBIsSuspend1 = true;
                        ProduceBIsStart = false;
                    }
                    break;
                case 'c':
                    if (ProduceCIsStart)
                    {
                        ProduceCIsSuspend1 = true;
                        ProduceCIsStart = false;
                    }
                    break;
            }
        }

        public void RestartProduction(char type)
        {
            switch (type)
            {
                case 'a':
                    if (ProduceAIsSuspend1)
                    {
                        ProduceAIsSuspend1 = false;
                        ProduceAIsStart = true;
                    }
                    break;
                case 'b':
                    if (ProduceBIsSuspend1)
                    {
                        ProduceBIsSuspend1 = false;
                        ProduceBIsStart = true;
                    }
                    break;
                case 'c':
                    if (ProduceCIsSuspend1)
                    {
                        ProduceCIsSuspend1 = false;
                        ProduceCIsStart = true;
                    }
                    break;
            }
        }

        public double ProductNbMinutesGetError(char type, int minutes)
        {
            double counterFail = 0;
            for (int i = 0; i < minutes; i++)
            {
                if(ProduceOneMinute(type) == -1)
                {
                    counterFail++;
                }
            }

            return counterFail * 100 / minutes;
        }


        public int ProduceOneMinute(char type)
        {
            bool success = false;

            int tempTaux = random.Next(1,11);

            switch (type)
            {
                case 'a':
                    counterA++;
                    if (tempTaux > TauxDerreurA)
                    {
                        NbCaisseAProduct += caisseA.NbProduitPerHour;
                        nbCaisseALeft -= caisseA.NbProduitPerHour;
                        success = true;
                    }
                    else
                    {
                        nbErreurA++;
                    }
                   
                    if (nbCaisseALeft < 0)
                    {
                        nbCaisseALeft = 0;
                        ProduceAIsFinish = true;
                        ProduceAIsStart = false;
                        nbErreurA =counterA = 0;
                    }
                    break;
                case 'b':
                    counterB++;
                    if (tempTaux > TauxDerreurB)
                    {
                        NbCaisseBProduct += caisseB.NbProduitPerHour;
                        nbCaisseBLeft -= caisseB.NbProduitPerHour;
                        success = true;
                    }
                    else
                    {
                        nbErreurB++;
                    }
                    if (nbCaisseBLeft <= 0)
                    {
                        nbCaisseBLeft = 0;
                        ProduceBIsFinish = true;
                        ProduceBIsStart = false;
                        nbErreurB = counterB = 0;
                    }
                    break;
                case 'c':
                    counterC++;
                    if (tempTaux > TauxDerreurC)
                    {
                        NbCaisseCProduct += caisseC.NbProduitPerHour;
                        nbCaisseCLeft -= caisseC.NbProduitPerHour;
                        success = true;
                    }
                    else
                    {
                        nbErreurC++;
                    }
                    if (nbCaisseCLeft <= 0)
                    {
                        nbCaisseCLeft = 0;
                        ProduceCIsFinish = true;
                        ProduceCIsStart = false;
                        nbErreurC = counterC = 0;
                    }
                    break;

            }

            if (success)
            {
                return tempTaux;
            }
            else
            {
                return -1;
            }
        }

        public int GetPercentProduce(char type)
        {
            int percent = 0;
            switch (type)
            {
                case 'a':
                    percent = nbCaisseAProduct * 100 / NbCaisseAToProduce;
                    break;
                case 'b':
                    percent = nbCaisseBProduct * 100 / NbCaisseBToProduce;
                    break;
                case 'c':
                    percent = nbCaisseCProduct * 100 / NbCaisseCToProduce;
                    break;
            }
            if(percent > 100)
            {
                percent = 100;
            }
            return percent;
        }

        public double getTauxErreur(char type)
        {
            double result = 0;
            switch (type)
            {
                case 'a':
                    if(nbCaisseAProduct != 0)
                    {
                        result = (double)nbErreurA  / (double)counterA * 100;
                    }
                    break;
                case 'b':
                    if (nbCaisseBProduct != 0)
                    {
                        result = (double)nbErreurB / (double)counterB* 100;
                    }
                    break;
                case 'c':
                    if (nbCaisseCProduct != 0)
                    {
                        result = (double)nbErreurC / (double)counterC * 100;
                    }
                    break;

            }
            return result;
        }

        public double getTauxErreurByHeure(char type)
        {
            double result = 0;
            switch (type)
            {
                case 'a':
                    if (nbCaisseAProduct != 0)
                    {
                        result = (double)nbErreurA / (double)counterA * 100;
                    }
                    break;
                case 'b':
                    if (nbCaisseBProduct != 0)
                    {
                        result = (double)nbErreurB / (double)counterB * 100;
                    }
                    break;
                case 'c':
                    if (nbCaisseCProduct != 0)
                    {
                        result = (double)nbErreurC / (double)counterC * 100;
                    }
                    break;

            }
            return result;
        }

        public int NbCaisseAToProduce1 { get => NbCaisseAToProduce; set => NbCaisseAToProduce = value; }
        public int NbCaisseBToProduce1 { get => NbCaisseBToProduce; set => NbCaisseBToProduce = value; }
        public int NbCaisseCToProduce1 { get => NbCaisseCToProduce; set => NbCaisseCToProduce = value; }
        public bool ProduceAIsStart1 { get => ProduceAIsStart; set => ProduceAIsStart = value; }
        public bool ProduceBIsStart1 { get => ProduceBIsStart; set => ProduceBIsStart = value; }
        public bool ProduceCIsStart1 { get => ProduceCIsStart; set => ProduceCIsStart = value; }
        public bool ProduceAIsSuspend1 { get => ProduceAIsSuspend; set => ProduceAIsSuspend = value; }
        public bool ProduceBIsSuspend1 { get => ProduceBIsSuspend; set => ProduceBIsSuspend = value; }
        public bool ProduceCIsSuspend1 { get => ProduceCIsSuspend; set => ProduceCIsSuspend = value; }
        public bool ProduceAIsRestart1 { get => ProduceAIsRestart; set => ProduceAIsRestart = value; }
        public bool ProduceBIsRestart1 { get => ProduceBIsRestart; set => ProduceBIsRestart = value; }
        public bool ProduceCIsRestart1 { get => ProduceCIsRestart; set => ProduceCIsRestart = value; }
        public bool ProduceAIsFinish1 { get => ProduceAIsFinish; set => ProduceAIsFinish = value; }
        public bool ProduceBIsFinish1 { get => ProduceBIsFinish; set => ProduceBIsFinish = value; }
        public bool ProduceCIsFinish1 { get => ProduceCIsFinish; set => ProduceCIsFinish = value; }
        public int NbCaisseALeft { get => nbCaisseALeft; set => nbCaisseALeft = value; }
        public int NbCaisseBLeft { get => nbCaisseBLeft; set => nbCaisseBLeft = value; }
        public int NbCaisseCLeft { get => nbCaisseCLeft; set => nbCaisseCLeft = value; }
        public int NbCaisseAProduct { get => nbCaisseAProduct; set => nbCaisseAProduct = value; }
        public int NbCaisseBProduct { get => nbCaisseBProduct; set => nbCaisseBProduct = value; }
        public int NbCaisseCProduct { get => nbCaisseCProduct; set => nbCaisseCProduct = value; }
        public int TauxDerreurA { get => tauxDerreurA; set => tauxDerreurA = value; }
        public int TauxDerreurB { get => tauxDerreurB; set => tauxDerreurB = value; }
        public int TauxDerreurC { get => tauxDerreurC; set => tauxDerreurC = value; }
    }
    
}
