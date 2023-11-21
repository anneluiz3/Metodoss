using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios1._2._3
{
    internal class retangulo
    {
        public double comprimento;
        public double largura;

        public retangulo(double comprimento, double largura)
        {
            this.comprimento = comprimento;
            this.largura = largura;
        }

        public void MudarComprimento(double comprimento)
        {
            this.comprimento = comprimento;
        }

        public void MudarLargura(double largura)
        {
            this.largura=largura;   
        }
        public double CalcularArea()
        {
            return comprimento * largura;
        }
        public double CalcularPerimetro()
        {
            return (comprimento * 2) + (largura * 2);
        }
    }
}
