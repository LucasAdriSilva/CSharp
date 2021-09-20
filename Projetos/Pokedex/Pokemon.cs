using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class Pokemon
    {   //Sobrecarga é crirar metodos que possuem o memso nome mas possuem parametros difrentescada um tendo um objetivo
        public Pokemon()
        {
            this.Nome = "";
            this.Descricao = "";
        }

        public Pokemon(String nome, String descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }

        private String nome;
        public String Nome
        {
            get { return this.nome; }
            set {
                String texto = value.ToUpper();
                this.nome = value; 
            }
        }


        private String descricao;// aramazena o valor da propriedade descrição
        public String Descricao // Representa a caracteristica Descrição do meu Pokemon
        {
            get { return this.descricao; }
            set { 
                this.descricao = value.ToUpper(); 
            }
        }

        public void ExibirDadosPokemon(){
            Console.WriteLine("Nome do Pokémon: "+ this.Nome);
            Console.WriteLine("Descrição do Pokémon: " + this.Descricao);
        }

        public void ExibirDadosPokemon(Boolean formatado)
        {
            if (formatado == true)
            {
                Console.WriteLine("Pokémon "+ this.Nome + ": " + this.Descricao.ToLower());
            }
            else
            {
                Console.WriteLine("Nome do Pokémon: " + this.Nome);
                Console.WriteLine("Descrição do Pokémon: " + this.Descricao);
            }
        }

    }
}
