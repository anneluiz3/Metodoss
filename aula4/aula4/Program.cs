using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula4
{
    internal class Program
    {
        static void Main(string[] args)
        { 
           
            Alunos al1 = new Alunos();  
            Alunos al2 = new Alunos();

            Console.WriteLine("\t\t---Testa Aluno 01---\n");
            Console.Write("Nome: ");
            al1.nome = Console.ReadLine();
            Console.Write("RG: ");
            al1.RG = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            al1.dtNasc = Console.ReadLine();

            Console.WriteLine("\t\t---Testa Aluno 02---\n");
            Console.Write("Nome: ");
            al2.nome = Console.ReadLine();
            Console.Write("RG: ");
            al2.RG = Console.ReadLine();
            Console.Write("Data de Nascimento: \n");
            al2.dtNasc = Console.ReadLine();

            Console.WriteLine("\t\t---Imprimindo Informações de Alunos---\n");
            Console.WriteLine($"Nome: {al1.nome} \nRG: {al1.RG} \n Data de Nascimento: {al1.dtNasc}");
            Console.WriteLine($"Nome: {al2.nome} \nRG: {al2.RG} \n Data de Nascimento: {al2.dtNasc}");
           

            
            Funcionarios f1 = new Funcionarios();
            Funcionarios f2 = new Funcionarios();

            Console.WriteLine("\t\t---Testa Funcionario 01---\n");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Cargo: ");
            f1.cargo = Console.ReadLine();
            Console.Write("Salario: ");
            f1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("\t\t---Testa Funcionario 02---\n");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Cargo: ");
            f2.cargo = Console.ReadLine();
            Console.Write("Salario: ");
            f2.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("\t\t---Imprimindo Informações de Funcionarios---\n");
            Console.WriteLine($"Nome: {f1.nome} \nCargo: {f1.cargo} \nSalario: {f1.salario:c2}");
            Console.WriteLine($"Nome: {f1.nome} \nCargo: {f2.cargo} \nSalario: {f2.salario:c2}");
          
            
            Turms t1 = new Turms(); 
            Turms t2 = new Turms();

            Console.WriteLine("\t\t---Testar Turma 01---\n");
            Console.Write("Periodo: ");
            t1.periodo = Console.ReadLine();
            Console.Write("Serie: ");
            t1.serie = Console.ReadLine();
            Console.Write("Sigla: ");
            t1.sigla = Console.ReadLine();
            Console.Write("tipo: ");
            t1.tipo = Console.ReadLine();


            Console.WriteLine("\t\t---Testar Turma 02---\n");
            Console.Write("Periodo: ");
            t2.periodo = Console.ReadLine();
            Console.Write("Serie: ");
            t2.serie = Console.ReadLine();
            Console.Write("Sigla: ");
            t2.sigla = Console.ReadLine();
            Console.Write("Tipo: ");
            t2.tipo = Console.ReadLine();
           

            Console.WriteLine("\t\t---Imprimindo Turmas---\n");
            Console.WriteLine($"Periodo: {t1.periodo} \nSerie: {t1.serie} \nSigla: {t1.sigla} \nTipo: {t1.tipo}");
            Console.WriteLine($"Periodo: {t2.periodo} \nSerie: {t2.serie} \nSigla: {t2.sigla} \nTipo: {t2.tipo}");



        }
    }
}
