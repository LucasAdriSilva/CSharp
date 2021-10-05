using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a sua forma");
            Console.WriteLine("Triangulo - 1");
            Console.WriteLine("Quadrado - 2");
            Console.WriteLine("------------------------------------------------");
            Console.Write("A forma Geometrica que você deseja é: ");
            int res = Convert.ToInt32(Console.ReadLine());

            if (res == 1) {
                Console.Clear();
                triangulo t1 = new triangulo();
                Console.Write("Escreva a altura: ");
                t1.Altura = Convert.ToInt32(Console.ReadLine());
                Console.Write("Escreva a base: ");
                t1.Base = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A sua area é: "+ t1.CalcularArea());

            }else{
                Console.Clear();
                Quadrado q1 = new Quadrado();
                Console.Write("Escreva a altura: ");
                q1.Altura = Convert.ToInt32(Console.ReadLine());
                Console.Write("Escreva a base: ");
                q1.Base = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A sua area é: " + q1.CalcularArea());
            }

            Console.ReadKey();
        }
    }
}
