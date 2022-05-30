using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Produto {
    internal class Program {
        static void Main(string[] args) {

            Prod p = new Prod();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");  
            p.Name = Console.ReadLine();
            Console.Write("Preço: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto " + p);
            Console.WriteLine();

            Console.WriteLine("Digite o numero que você quer add ao estoque: ");
            int qte = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qte);

            Console.WriteLine("Dados atualizados "+ p);
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Digite o numero que você quer remover ao estoque: ");
            int qte2 = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qte2);

            Console.WriteLine("Dados atualizados " + p);
        }
    }
}
