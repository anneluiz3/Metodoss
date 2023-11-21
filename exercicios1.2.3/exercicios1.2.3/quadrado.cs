using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios1._2._3
{

    public class quadrado
    {

        public double TamanhoDoLado;

        public quadrado(double TamanhoDoLado)
        {

            this.TamanhoDoLado = TamanhoDoLado;

        }

        public void MudarValor(double TamanhoDoLado)
        {
            this.TamanhoDoLado = TamanhoDoLado;


        }
        public double CalcularPerimetro()
        {
            return TamanhoDoLado * 4;
        }
        public double CalcularArea()
        {
            return TamanhoDoLado * 2; 
        }




    }
}


