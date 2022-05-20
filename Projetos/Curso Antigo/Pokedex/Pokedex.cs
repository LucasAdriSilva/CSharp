using System.Collections.Generic;
using System;

namespace Pokedex
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializaLista();
        }
        private List<PokemonPlus> pokemons;

        public List<PokemonPlus> Pokemons
        {
            get { return pokemons; }
        }

        private void InicializaLista()
        {
            this.pokemons = new List<PokemonPlus>(); // Instanciar a Lista
            PokemonPlus p = new PokemonPlus("Charmander", "Tipo Fogo",100);
            this.pokemons.Add(p);
            p = new PokemonPlus("Lizardon", "Tipo Água",90);
            this.pokemons.Add(p);
            p = new PokemonPlus("Ivysaur", "Tipo Planta",50);
            this.pokemons.Add(p);
            p = new PokemonPlus("Caterpie", "Tipo Inseto",95);
            this.pokemons.Add(p);
            p = new PokemonPlus("Beedril", "TipoInseto/Voador",10);
            this.pokemons.Add(p);
            p = new PokemonPlus("Nidoran♀", "Tipo Venenoso",54);
            this.pokemons.Add(p);
            p = new PokemonPlus("Gloom", "Tipo Planta",60);
            this.pokemons.Add(p);
            p = new PokemonPlus("Persian", "Tipo Normal",98);
            this.pokemons.Add(p);

        }

        public void ListarPokemons() {

            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                Console.WriteLine("Código do Pokemon: " + i);
                this.Pokemons[i].ExibirDadosPokemon();
            } 
            
        }

    }
}
