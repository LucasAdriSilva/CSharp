using System;
using System.Globalization;


namespace Encapsulamento {
    internal class Program {
        static void Main(string[] args) {
            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("Tv 4K");
            Console.WriteLine(p.GetPreco());

            Console.WriteLine(p.ToString());
        }
    }
}
