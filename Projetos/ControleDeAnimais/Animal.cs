using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    public enum TipoAnimal {Cachorro, Gato, Peixe};

    public class Animal
    {
        //Construtor
        public Animal()
        {
            this.Nome = "";
            this.Tipo = TipoAnimal.Peixe;
        }
        //Construtor sobrecarga
        public Animal(String nome, TipoAnimal tipo)
        {
            this.Nome = nome;
            this.Tipo = tipo;
        }
        
        
        
        // Estrutura da propriedade
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }
        // Estrutura da propriedade

        private TipoAnimal tipo;

        public TipoAnimal Tipo
        {   // valores definidos pelo dev - Cachorro, Gato, Peixe
            get { return tipo; }
            set { tipo = value;  }                   
            
        }
    }
}
