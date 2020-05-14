using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableProd
{
    [Serializable]
    public class SerialProd
    {
        private char type;
        private int nbAProduire;

        public int NbAProduire { get => nbAProduire; set => nbAProduire = value; }
        public char Type { get => type; set => type = value; }

        public override string ToString()
        {
            return $"Production {type} Nombre a produire {nbAProduire}";
        }

    }
}
