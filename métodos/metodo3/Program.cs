using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("\t---Inverter---\n");
                Console.Write("informe o primeiro valor:");
                double x = double.Parse(Console.ReadLine());
                Console.Write("informe o segundo valor:");
                double y = double.Parse(Console.ReadLine());


                Inverter(ref x, ref y);
                Console.WriteLine($"Inversos: X= {x}, Y = {y}");
                Console.ReadKey();
            }

        }
        static void Inverter(ref double x, ref double y)
        {

            double invert = x;
            x = y;
            y = invert; 



        }

    }
}
    

