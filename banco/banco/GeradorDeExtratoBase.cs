using System;

namespace banco
{
    internal class GeradorDeExtratoBase
    {
        public void ImprimeExtrato(conta cp)
        {
            DateTime agora = DateTime.Now;
            string horario = String.Format("(0:d/int.MaxValue/yyyy HH/mm/ss)", agora);

            System.Console.WriteLine("DATA: " + horario);
            System.Console.WriteLine("SALDO: " + horario);

        }
    }
}