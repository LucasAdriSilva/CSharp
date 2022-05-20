using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_de_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();



            Console.WriteLine("Olá, tudo bem ?");
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_");

            Console.Write("Escre algo: ");
            c1.Propriedade = Console.ReadLine();
            Console.WriteLine("Esse algo em maiusculosfica: "+c1.Propriedade);
            Console.ReadLine();
        }
    }
}
