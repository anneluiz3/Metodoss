using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            animal ani = new animal();
            ani.nome = "Rex";
            ani.Acordar();
            ani.Comer();
            ani.Dormir();
            Console.WriteLine(ani);


            mamifero mam = new mamifero();
            mam.nome = "Baleia";
           mam.Acordar();
            mam.Comer();
            mam.Dormir();
            Console.WriteLine(mam);

            morcego batman = new morcego();
            batman.nome = "Douglas";
            batman.Acordar();
            batman.Comer();
            batman.Dormir();
            Console.WriteLine(batman);

            baleia mutano = new baleia();
            mutano.nome = "jovem titan";
            mutano.Acordar();
            mutano.Comer();
            mutano.Dormir();
            Console.WriteLine(mutano);

            Console.ReadKey();
        }
    }
}
