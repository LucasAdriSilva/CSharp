using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Vetores2 {
    internal class Program {
        static void Main(string[] args) {

            var n = int.Parse(Console.ReadLine());

            Produtc[] p = new Produtc[n];

            for (int i = 0; i < n; i++) {
                var name = Console.ReadLine();
                var price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p[i] = new Produtc { Name = name, Price = price };
            }

            double soma = 0.0;

            for (int i = 0; i < n; i++) {
                soma += p[i].Price;
            }

            double media = soma / n;

            Console.WriteLine($"Preço médio é: {media.ToString("F2")}");
            Console.ReadKey();
        }
    }
}
