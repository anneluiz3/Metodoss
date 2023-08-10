using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBJETOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            conta cc1 = new conta();
            cc1.numero = "12344";
            cc1.saldo = 1500;
            cc1.limite = 1000;

            conta cc2 = new conta();
            cc2.numero = "12473";
            cc2.saldo = 1500;
            cc2.limite = 1000;

            Console.WriteLine("\t\t---Dados da conta===\n");
            Console.WriteLine($"\nNumero: {cc1.numero}" +
                $"\nSaldo: {cc1.saldo.ToString("c2")}" +
                $"\nLiminte: {cc1.limite.ToString("c2")}");

            Console.WriteLine($"\nNumero: {cc2.numero}" +
               $"\nSaldo: {cc2.saldo.ToString("c2")}" +
               $"\nLiminte: {cc2.limite.ToString("c2")}");
        }
    }
}
