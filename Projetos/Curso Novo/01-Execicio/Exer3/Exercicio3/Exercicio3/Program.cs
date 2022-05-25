using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] table = new string[4, 2];

            table[0, 0] = "1"; table[1, 0] = "2"; table[2, 0] = "3"; table[3, 0] = "4";
            table[4, 0] = "5";

            table[0, 1] = "Cachorro Quente"; table[1, 1] = "X-Salada";table[2, 1] = "X-Bacon";
            table[3, 1] = "Torrada Simples";table[4, 1] = "Refrigerante";

            table[0, 2] = "4,00";table[1, 2] = "4,50";table[2, 2] = "5,00"; table[3, 2] = "2,00";
            table[4, 2] = "1,50";

            

            Console.WriteLine(table);

            Console.WriteLine("Escolah seu pedido: ");
            double var1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Deseja mais alguma coisa? Se sim escolha o código:  ");
            double var2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            //double res { }

            //Console.WriteLine("A conta deu: "+ res)
        }
    }
}
