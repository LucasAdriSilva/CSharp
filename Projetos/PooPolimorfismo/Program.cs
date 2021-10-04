using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado q1 = new Quadrado("Quadrado",2,2);
            Console.WriteLine(q1.CalcularArea());
            Console.ReadKey();
        }
    }
}
