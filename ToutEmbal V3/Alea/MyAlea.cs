using System;

namespace Alea
{
    public class MyAlea : Random
    {
        private static MyAlea monAlea = null;
        private MyAlea()
        {
        }
        public static MyAlea Instance()
        {
            if (monAlea == null)
            {
                monAlea = new MyAlea();
            }
            return monAlea;
        }
        public int Nouveau(int valMin, int valMax)
        {
            return base.Next(valMin, valMax + 1);
        }
    }
}
