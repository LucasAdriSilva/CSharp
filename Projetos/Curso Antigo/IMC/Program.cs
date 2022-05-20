using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Program
    {
        static void Main()
        {
            Pessoa p = new Pessoa();
            double x; ;
            Console.WriteLine("Calculando IMC");
            Console.WriteLine("-----------^-----------");

            Console.Write("Digite seu nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            p.Idade = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Digite o seu Peso: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(x);
            
            Console.Write("Digite o sua Altura: ");
            p.Altura = Convert.ToDouble(Console.ReadLine());            

            p.ExibirDados();
            
            Console.ReadKey();
            



        }
    }
}
