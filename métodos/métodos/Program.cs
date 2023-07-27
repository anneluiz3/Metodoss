using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("informe o primeiro valor:");
            double valor1= double.Parse(Console.ReadLine());
            Console.Write("informe o segundo valor:");
            double valor2= double.Parse(Console.ReadLine());

            Console.WriteLine("resultado: " + Somar(valor1, valor2));
        }
       
        static double Somar(double valor1, double valor2)
        {
            double resultado = valor1 + valor2;
            return resultado;

        }
    }
}
