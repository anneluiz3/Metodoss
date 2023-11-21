using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios1._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bola bola = new bola("Branca", 70.0, "Couro");

            bola.MostrarCor();

            bola.AlterarCor("vemelho");
           
            bola.MostrarCor();

            //quadrado

            Console.WriteLine("\n--Quadrado--\n");
            quadrado quadrado = new quadrado(4);

            Console.WriteLine(quadrado.TamanhoDoLado);
            Console.WriteLine("{0} {1}", quadrado.CalcularPerimetro(), quadrado.CalcularArea() );
            quadrado.MudarValor(2); 
            Console.WriteLine(quadrado.TamanhoDoLado);
            Console.WriteLine("{0} {1}", quadrado.CalcularPerimetro(), quadrado.CalcularArea() );

            //retangulo
            Console.WriteLine("\n--Retangulo--\n");
            Console.Write("Informe a largura: ");
            double larg = double.Parse(Console.ReadLine());
            Console.Write("Informe a comprimento: ");
            double comp = double.Parse(Console.ReadLine());

            retangulo retangulo = new retangulo(comp, larg);

            Console.WriteLine("\n--Alterando medida do Retangulo--\n");
            Console.Write("Informe a nova medida: ");
            double nmed = double.Parse(Console.ReadLine());            
            retangulo.MudarLargura(nmed);

            Console.WriteLine("\n--Calcular área--\n");
            double area = retangulo.CalcularArea();
            Console.WriteLine($"Área: {area}");

            Console.WriteLine("\n--Calcular perimetro--\n");
            double perimetro = retangulo.CalcularPerimetro();
            Console.WriteLine($"Área: {perimetro}");

            Console.WriteLine("\n--Calcular Piso--\n");
            Console.WriteLine($"Piso: {area}");
            Console.Write("Informe a altura do rodapé (m): ");
            double altRodape = double.Parse(Console.ReadLine());
            Console.WriteLine($"Rodapé: {perimetro*altRodape}");




        }
    }
}
