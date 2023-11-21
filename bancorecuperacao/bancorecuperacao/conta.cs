using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancorecuperacao
{
    public class conta
    {
        private int numero;
        private double saldo;
        private double limite = 100;
        private agencia agencia;
        private cliente cliente;


        public int Numero

        {
            get { return numero; }

        }

        public double Saldo

        {
            get { return saldo; }

        }
        public double Limite

        {
            get { return limite; }

        }

        public agencia Agencia
        {
            get { return agencia; }
        }
        public cliente Cliente
        {
            get { return cliente; }
        }

        public conta(int numero, double saldo, double limite, agencia agencia, cliente cliente)
        {
            this.numero = numero;
            this.saldo = saldo;
            this.limite = limite;
            this.agencia = agencia;
            this.cliente = cliente;

        }
        //Métodos
        public void Sacar(double sacar)
        {
            if (saldo >= sacar)
            {
                saldo = saldo - sacar;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }
        public void Transferir(double qRecebe, double valor)
        {
            saldo = saldo - valor;
            qRecebe = saldo + valor;
        }
        public void ImprimeExtrato()
        {
            Console.WriteLine("Saldo: " + saldo.ToString("c2"));
        }
        public void Dados()
        {
            Console.WriteLine("\t\t---Dados da Conta---\n");
            Console.WriteLine($"Numero: {numero}");
            Console.WriteLine($"Saldo: {saldo}");
            Console.WriteLine($"Limite: {limite}");
            Console.WriteLine($"Agencia: {agencia}");
            Console.WriteLine($"Cliente: {cliente}");
            Console.WriteLine("------------------------------");
        }
    }
}

    
        
   



