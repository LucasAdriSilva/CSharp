using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace vetores {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite a quantidade de pessoas: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Digite a altura da {i + 1} pessoa  ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double sum = 00.00;

            for (int i = 0; i < n; i++) {
                sum += vect[i];
            }
            double avg = sum / n;
            Console.WriteLine($"A média de altura é: {avg.ToString("F2")}");
            Console.ReadKey();
        }
    }
}