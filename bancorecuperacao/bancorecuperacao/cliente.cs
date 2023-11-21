using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancorecuperacao
{
    public class cliente
    {
        private string nome;
        private string cpf;


        public string Nome { get { return nome; } set { nome = value; } }
        public string Cpf { get { return cpf; } set { nome = value; } }
        public cliente(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
           
        }

        public void Dados()
        {
            Console.WriteLine("\t\t---Dados do Cliente---\n");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Cpf: {cpf}");
            Console.WriteLine("------------------------------");
        }
    }
}
