using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancorecuperacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            cliente c = new cliente("Annelubis", "07871091229");
            agencia ag = new agencia(11111);
            conta ct = new conta(11, 10000, 2022, ag, c);


            do
            {
                Console.WriteLine("\t\t---CONTA---\n");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1.Depositar");
                Console.WriteLine("2.Sacar");
                Console.WriteLine("3.Tranferir");
                Console.WriteLine("4.Consultar Saldo");
                Console.WriteLine("0. Sair");

                Console.Write("\nOpção escolhida: ");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Informe o valor a ser Depositado: ");
                        double valor = double.Parse(Console.ReadLine());
                        if (valor > 0)
                        {
                            Console.WriteLine(valor);
                            Console.WriteLine($"Operãção realizada, novo valor {valor}");
                        }

                        else
                        {
                            Console.WriteLine("Saldo insuficiente, valor precisa ser maior que zero!");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Informe o valor:");
                        valor = double.Parse(Console.ReadLine());
                        ct.Depositar(valor);
                        Console.WriteLine($"Operãção realizada, novo valor {valor}");
                 
                        break;
                    case 4:
                        ct.ImprimeExtrato();
                        break;

                    default:
                        Console.WriteLine("Opção Inválida, clique novamente para sair.");
                        break;

                }

            } while (true);




        }
       
    }
 
}





















