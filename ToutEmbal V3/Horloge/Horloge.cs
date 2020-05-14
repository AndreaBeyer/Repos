using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHorloge
{
    public static class Horloge
    {
        public static string GetStringFormat()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
