using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorok
{
    internal class operatorok
    {
        int opElso;
        string opJel;
        int opMas;

        public operatorok(int opElso, string opJel, int opMas)
        {
            this.opElso = opElso;
            this.opJel = opJel;
            this.opMas = opMas;
        }

        public int OpElso { get => opElso; }
        public string OpJel { get => opJel; }
        public int OpMas { get => opMas; }
    }
}
