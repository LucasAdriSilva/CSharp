using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressãoLambida
{
    class Program
    {
        static void Main()
        {
            var lista = new List<int>() {1,2,3,4,5,6,7,8 };
            var listaFiltrada = lista.Where(x => x > 4); ;
            listaFiltrada.ForEach(y => Console.WriteLine(y));
            Console.ReadKey();
        }
    }
}
