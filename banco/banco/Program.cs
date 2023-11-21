using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeradorDeExtrato gerador = new GeradorDeExtrato();
            ContaPoupanca cp = new ContaPoupanca();
            cp.Saldo = 2000;
            ContaCorrente cc = new ContaCorrente();
            cc.Saldo = 1000;

            gerador.ImprimeExtrato(cp);
            gerador.ImprimeExtrato(cc);
        }
    }
}
