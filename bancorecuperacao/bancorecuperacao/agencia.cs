using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancorecuperacao
{
    public class agencia
    {
        private int numero;

        public int Numero { get { return numero; } set { numero = value; } }

        public agencia(int numero)
        {
            this.numero = numero;

        }

        public void DadosAg()
        {
            Console.WriteLine("\t\t---Dados da Agência---\n");
            Console.WriteLine($"Número: {numero}");
            Console.WriteLine("------------------------------");
        }
    }
}
