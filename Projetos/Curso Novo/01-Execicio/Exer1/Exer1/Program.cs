using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int code1;
            int qty1;
            double valor1;

            int code2;
            int qty2;
            double valor2;
    

            Console.WriteLine("Digite o numero da primeira peça: ");
            code1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade da primeira peça: ");
            qty1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor da primeira peça: ");
            valor1 = Convert.ToDouble(Console.ReadLine());

            //--------------------------------------------


            Console.WriteLine("Digite o numero da segunda peça: ");
            code2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade da segunda peça: ");
            qty2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor da segunda peça: ");
            valor2 = Convert.ToDouble(Console.ReadLine());

            //--------------------------------------------

            double res = (qty1 * valor1) + (qty2 * valor2);

            Console.WriteLine("O resultado é: "+ res);
            Console.ReadKey();


        }
    }
}
