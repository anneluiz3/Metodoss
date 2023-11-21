using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    internal class GeradorDeExtrato
    {
        public void ImprimeExtrato(conta ct)
        {
            DateTime agora  = DateTime.Now;
            string horario = String.Format("(0:d/int.MaxValue/yyyy HH/mm/ss)", agora);

            System.Console.WriteLine("DATA: " + horario);
            System.Console.WriteLine("SALDO: " + horario);

        }
    }
}
