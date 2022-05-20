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
            Conta_Estudante conta = new Conta_Estudante();            
            conta.Correntista.Nome = "Lucas Silva";
            int menu = 0;
            while (menu != 4)
            {
                Console.WriteLine("Menu de opções: ");
                Console.WriteLine("1 - Exibir dados: ");
                Console.WriteLine("2 - Depositar: ");
                Console.WriteLine("3 - Retirar: ");
                Console.WriteLine("4 - Sair: ");
                Console.Write("Opção: ");
                menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1) {
                    Console.Clear();
                    conta.ExibirDadosBancarios();
                    Console.ReadKey();
                }
                if (menu == 3) {
                    try
                    {
                        Console.Clear();

                        Console.WriteLine("Valor para retirada: ");
                        Double valor = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Saldo restante: " + conta.Retirar(valor));
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine("Ops, algo deu errado");
                        Console.WriteLine("Error: " + erro.Message);

                    }
                    Console.ReadKey();
                }
                if (menu == 2) {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Valor mpara deposito: ");
                        Double valor = Convert.ToDouble(Console.ReadLine());
                        conta.Depositar(valor);
                        Console.WriteLine("Saldo atual: " + conta.Saldo);
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine("Ops, algo deu errado");
                        Console.WriteLine("Error: " + erro.Message);

                    }
                    Console.ReadKey();
                }

            }
            
        }
    }
}
