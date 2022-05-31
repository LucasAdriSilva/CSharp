using System;
using System.Globalization;


namespace Conversor {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Qual é a cotação do dóler? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quanto você quer comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double res = ConversorDeMoeda.Conversor(quantia, cotacao);

            Console.WriteLine($"O valor é : {res}");
        }
    }
}
