using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    public class animal
    {
        public string nome;

        public string Nome { get { return nome; } set { nome = value; } }

        public void Acordar()
        {
            Console.WriteLine("Acordando...");
        }

        public void Comer()
        {
            Console.WriteLine("Comendo...");
        }

        public void Dormir()
        {
            Console.WriteLine("Dormindo...");
        }

        public override string ToString()
        {
            return $"Nome: {Nome}";
        }
    }
}
