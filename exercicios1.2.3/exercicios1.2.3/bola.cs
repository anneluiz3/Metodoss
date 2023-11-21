using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios1._2._3
{
    public class bola
    {
        public string cor;
        public double circunferencia;
        public string material;

        public bola(string cor, double circunferencia, string material)
        {
            this.cor = cor;
            this.circunferencia = circunferencia;
            this.material = material;
        }

        public void AlterarCor(string novaCor)
        {
            cor = novaCor;

        }

        public void MostrarCor()
        {
            Console.WriteLine("Cor: " + cor);
        }

    }
}
