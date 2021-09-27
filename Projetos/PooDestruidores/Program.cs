using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooDestruidores
{
    class Program
    {
        static void Main(string[] args)
        {
            Ferramenta f1 = new Ferramenta("Alicate");
            Ferramenta f2 = new Ferramenta("Tesoura");

            f1 = null;
            f2 = new Ferramenta("Furadeira");
            GC.Collect();
            Console.ReadKey();
                

        }
    }
}
