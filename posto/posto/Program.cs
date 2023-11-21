using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BombaDeCombustivel bomba = new BombaDeCombustivel("comum", 5, 100);

            Console.WriteLine("\t\t---Opções---\n" +
                "Quais das seguintes opções vc deseja\n" +
                "[1] AbastecerPorValor" +
                "[2] AbastecerPorLitro" +
                "[3] AlterarValor" +
                "[4] AlterarCombustivel" +
                "[5] AlterarQuantidadeCombustivel");
            string op = Console.ReadLine();
            bool continua = true;
            do
            {

            switch (op)
            {
                case "1":
                    Console.WriteLine("Qual valor desejado a ser abastecido:");
                    double valordin = double.Parse(Console.ReadLine());
                    break;
                case "2":
                    Console.WriteLine("qual valor vc deseja abastecer:");
                    double valorab = double.Parse(Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine("Quantos litros vc deseja abastecer:");
                    double qtdlitros = double.Parse(Console.ReadLine());
                    break;
                case "4":
                    Console.WriteLine(" para Qual combustivel vc deseja alterar:");
                    break;
                case "5":
                    Console.WriteLine("Altere sua quantidade de combustivel:");
                    double altereqtd = double.Parse(Console.ReadLine());
                    break ;
                default:
                    Console.WriteLine("opção invalida!!");
                    break;
            }
        } while (false);
            Console.WriteLine("deseja realizar outra operação?");
           
            Console.Clear();
            Console.ReadKey();

         

           

        }

    }
}
