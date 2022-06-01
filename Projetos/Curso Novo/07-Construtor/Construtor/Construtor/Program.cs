using Course;
using System;
using System.Globalization;


namespace Construtor {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Quantidade no estoque: ");
            //int quantidade = int.Parse(Console.ReadLine());

            //Pegadno a entrada do usuário e colocando em váriaveis - depois usando uma isntancia com construtor 
            //Produto p = new Produto(nome, preco);


            Produto p = new Produto() { 
                Nome = "Tv", 
                Preco = 900.00, 
                Quantidade = 10 
            };

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
           
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p.ToString());
        }
    }
}
