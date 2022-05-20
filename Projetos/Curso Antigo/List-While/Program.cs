using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_While
{
    class Program
    {
        static void Main()
        {
            List<String> games = new List<string>();
            Console.WriteLine("Adicionando um item a lista");
            Console.Write("Informe a quantidade de jogs que quer adicionar: ");
            int x = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < x; i++)
            {
                Console.Write("Jogo "+(i+1)+":");
                games.Add(Console.ReadLine());
                Console.Clear();


            }
            games.Sort();
            Console.WriteLine("A lista tem " + games.Count + " itens");
           
            Console.ReadKey();

            Console.Clear();
            
            games.ForEach(y => Console.WriteLine(y));
            Console.WriteLine("---------" + games[1]);

            Console.ReadKey();


        }


    }
} 
