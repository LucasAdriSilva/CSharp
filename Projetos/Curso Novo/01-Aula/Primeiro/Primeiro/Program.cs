using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; // Para alterar o "." para ","

namespace Primeiro {
    internal class Program {
        static void Main(string[] args) {
            //Matéria ja aprendida -- O que for add aqui é por curiosidade
            char gen = '\u0041';
            Console.WriteLine(gen);


            double saldo = 10.65865;
            Console.WriteLine(saldo.ToString("F4")); // O "F" limita a quantidade de caracteres
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine($"{gen} e asdasdasdasda {saldo:F2}");

            /*PAra fazer a conversão é só colocar (tipo de variavel)
            string saldo = (int)saldo
            string saldo = (float)saldo
            int n1 = int.Parse(Console.WriteLine());
            char c1 = char.Parse(Console.WriteLine());
            double d1 = double.Parse(Console.WriteLine(), CultureInfo.InvariantCulture);
            */

            double a = 1.0;
            double b = -3.0;
            double c = -4.0;

            double res = (double)10.0 / 8;
            Console.WriteLine(res);
            Console.WriteLine("-----------------------------------------------");

            /*formulas mátematicas Bascara*/

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; //Exponenciação

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); //Raiz quadrada
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a); //Raiz quadrada

            Console.WriteLine($"{x1} e {x2}");



            /*Comando Split*/
            string s = Console.ReadLine();
            string[] vet = s.Split(' ');

            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine($"Testando {p1} uhasauhsuhas {p2} asuhausuahsuha {p3}");

            Console.ReadKey();
        }
    }
}
