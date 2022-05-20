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
            ret.Altura = Convert.ToDouble(Console.ReadLine());            

            Console.Write("Informe a Base: ");
            ret.Base = Convert.ToDouble(Console.ReadLine());
            
            ret.ExibeDados();
            Console.ReadKey();
        }
    }
}
