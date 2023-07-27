using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Maior Menor");
                Console.Write("informe o primeiro valor:");
                double valor1 = double.Parse(Console.ReadLine());
                Console.Write("informe o segundo valor:");
                double valor2 = double.Parse(Console.ReadLine());


                Console.WriteLine("resultado: " + CalcularDiferenca(valor1, valor2));
                Console.ReadKey();
            }

        }
            static double CalcularDiferenca(double x, double y)
            {
                if (x >= y)
                {
                    return x - y;
                }
                else
                {
                    return y - x;
                }

            }

        }
    }

    

