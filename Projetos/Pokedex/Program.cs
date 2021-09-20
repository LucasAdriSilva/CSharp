using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int resp = 100;
            while (resp !=0)
            {
                resp = Menu();
                if (resp == 1) 
                {
                    pokedex.ListarPokemons();
                }
                if (resp == 2)
                {
                    pokedex.ListarPokemons();
                    Console.Write("Digite o código do pokemon: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    
                    //Pegar o pokemon do player 
                    PokemonPlus pPlayer = pokedex.Pokemons[codigo];
                    
                    // Definir o pokemon do pc
                    Random r = new Random();
                    codigo = r.Next(0, pokedex.Pokemons.Count);
                    PokemonPlus pPc = pokedex.Pokemons[codigo];

                    //Batalha
                    if (pPlayer.Poder >= pPc.Poder)
                    {                        
                        Console.WriteLine("Parabens você ganhou!");              
                    }
                    else 
                    { 
                        Console.WriteLine("Que pena você perdeu :(");

                    }

                }
                Console.ReadKey();
                Console.Clear();

            }
            
            
        }

        static int Menu()
        {
            Console.WriteLine("Pokemon ----- Jogo de Batalha");
            Console.WriteLine("0 - Sair do Jogo");
            Console.WriteLine("1 - Listar Todos os Pokemons da Pokedex");
            Console.WriteLine("2 - batalhar");
            Console.WriteLine("-----------------------------------------");
            Console.Write("O que deseja fazer: ");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;


        }
    }
}
