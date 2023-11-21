using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBJETOS
{
    internal class Gerente
    {
        public string nome;
            public double salario;

        public void AumentarSalario()
        {
            salario = salario + (salario * 0.10);

        }

        public void AumentarSalario(int taxa)

        {
            salario = salario + (salario * taxa / 100);

        }

        public void ImprimirDados()
        {
            Console.WriteLine("---Imprimir Dados");
            Console.WriteLine($"nome: {nome} \nsalario: {salario}");
        }
    }
}
