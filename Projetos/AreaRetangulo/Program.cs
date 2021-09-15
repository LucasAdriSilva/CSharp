using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRetangulo
{
    class Program
    {
        static void Main()
        {
            Retangulo ret = new Retangulo();
            Console.WriteLine("Calcula a area de um RETANGULO");

            Console.Write("Informe a Altura: ");
            ret.Altura = Convert.ToInt32(Console.ReadLine());            

            Console.Write("Informe a Base: ");
            ret.Base = Convert.ToInt32(Console.ReadLine());
             

            ret.ExibeDados();
            Console.ReadKey();
        }
    }
}
