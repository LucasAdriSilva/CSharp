using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ternaria {
    internal class Program {
        static void Main(string[] args) {

            var x = int.Parse(Console.ReadLine());

            //Ternário (condição) **?** Resultado positivo **:** Resultado Negativo;
            var t = x != 20 ? true : false;

            //Utilizando if com apenas um alinha de código 
            if (t) {
                Console.WriteLine("Hello x é diferente de 20");
            }
            else {
                Console.WriteLine(" x = 20");
            }

            Console.WriteLine("---------------");

            Console.WriteLine("Digite um preço");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;

            desconto = price < 20.0 ? price * 0.1 : price * 0.05;
            var res = desconto - price;

            Console.WriteLine($"Preço com desconto é {res} (Onde o valor total foi de {price} e o desconto foi de {desconto})");

            Console.ReadKey();

        }
    }
}
