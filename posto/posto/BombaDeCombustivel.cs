using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto
{
    public class BombaDeCombustivel
    {
        private string tipoCombustivel;
        private double valorLitro;
        private double quantidadeCombustivel;

        public string TipoCombustivel { get { return TipoCombustivel; } set { TipoCombustivel = value; } }
        public double ValorLitro { get { return valorLitro; } set { ValorLitro = value; } }
        public double QuantidadeCombustivel { get { return QuantidadeCombustivel; } set { QuantidadeCombustivel = value; } }

        public BombaDeCombustivel (string tipoCombustivel, double valorLitro, double quantidadeCombustivel)
        {
            this.TipoCombustivel = tipoCombustivel;
            this.ValorLitro = valorLitro;
            this.QuantidadeCombustivel = quantidadeCombustivel;
        }

        private void AbastecerPorValor (double valordinheiro)
        {
         QuantidadeCombustivel = QuantidadeCombustivel - (valorLitro / valordinheiro); 
            
        }

        private void AbastecerPorLitro (double valordinheiro)
        {
            valordinheiro = quantidadeCombustivel - ValorLitro;
         
        }
         
        private void Alterarvalor (double altera)
        {
            valorLitro = altera;
            
        }
        
        private string AlterarCombustivel ()
        {
            return tipoCombustivel;
        }

        private void AlterarQuantidadeCombustivel (double novaqtd)
        {
           novaqtd =  quantidadeCombustivel;
        }

    }
}
