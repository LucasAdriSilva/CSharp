using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            Console.WriteLine("Calculando IMC");
            Console.WriteLine("-----------------------");

            Console.Write("Digite seu nome: ");
            p.Nome = float.Parse(Console.ReadLine());

            Console.Write("Digite sua idade: ");
            p.Idade = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Digite o seu Peso: ");
            p.peso = Convert.ToInt32(Console.ReadLine());
            Convert.ToDouble(p.peso); 
            
            Console.Write("Digite o sua Atura: ");
            p.altura = Convert.ToInt32(Console.ReadLine());
            Convert.ToDouble(p.altura);

            p.ExibirDados();
            



        }
    }
}
