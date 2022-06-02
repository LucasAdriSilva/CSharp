using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Banco {
    internal class Program {
        static void Main(string[] args) {

            Cliente c = new Cliente();
            char resp;

            Console.Write("Entre com o número da conta: ");
            c.NumConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            c.NomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n) ?");
            resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S') {
                Console.Write("");
                Console.Write("Entre o valor de depósito inicial: ");
                double valorDep = double.Parse(Console.ReadLine());
                c.Depesito(valorDep);
                Console.WriteLine(c.ToString());
            }
            else {
                Console.Write("Dados da conta: ");
                Console.WriteLine(c.ToString());

            }


            Console.Write("Entre um valor para depósito: ");
            double d = double.Parse(Console.ReadLine());
            c.Depesito(d);
            Console.WriteLine(c.ToString());


            Console.Write("Entre um valor para saque: ");
            double s = double.Parse(Console.ReadLine());
            c.Saque(s);
            Console.WriteLine(c.ToString());








        }
    }
}
