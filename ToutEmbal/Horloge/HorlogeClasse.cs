using System;

namespace Horloge
{
    public static class HorlogeClasse
    {
        public new static string ToString()
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            return hour.ToString("D2") + ":" + minute.ToString("D2") + ":" + second.ToString("D2");
        }
    }
}
