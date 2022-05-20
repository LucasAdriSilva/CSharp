using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewJogo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            Console.WriteLine("Começando o game");
            Console.Write("Digite o nome do player: ");
            p1.Name = Console.ReadLine();
            Console.Write("Ok, "+p1.Name+" vamos começar!");

            Metodos p = new Metodos();
            p.CriarLista();
            Console.WriteLine("Ola! "+p);
            




            Console.ReadKey();
        }
    }
}
