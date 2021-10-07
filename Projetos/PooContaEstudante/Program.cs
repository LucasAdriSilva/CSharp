using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooContaEstudante
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();
            conta.Depositar(600);
            conta.Correntista.Nome = "Lucas Silva";

            try
            {
                Console.WriteLine("Valor mpara retirada: ");
                Double valor = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Saldo restante: " + conta.Retirar(valor));
            }
            catch (Exception erro) {
                Console.WriteLine("Ops, algo deu errado");
                Console.WriteLine("Error: "+ erro.Message);

            }
            Console.ReadKey();
        }
    }
}
