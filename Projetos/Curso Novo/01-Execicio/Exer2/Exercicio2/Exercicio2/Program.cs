using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double x;

            Console.Write("Digite o valor do raio: ");
            x = Convert.ToDouble(Console.ReadLine());

            double res = x * x * pi;

            Console.Write("O valor da area do seu circulo é: " + res);

            Console.ReadKey();


        }
    }
}
