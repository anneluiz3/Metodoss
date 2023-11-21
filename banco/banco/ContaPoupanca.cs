using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    internal class ContaPoupanca: conta
    {
        private double aniver;

        public double Aniver { get { return aniver; } set { aniver = value; } }
    }
}
