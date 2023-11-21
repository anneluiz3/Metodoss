using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    internal class ContaCorrente : conta
    {
        private double limite;

        public double Limite { get { return limite; } set { limite = value; } }
    }
}
