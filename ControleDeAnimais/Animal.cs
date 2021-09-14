using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    public class Animal
    {   // Estrutura da propriedade
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }
        // Estrutura da propriedade

        private String tipo;

        public String Tipo
        {   // valores definidos pelo dev - Cachorro, Gato, Peixe
            get { return tipo; }
            set {
                if (value == "Cachorro" || value == "Gato" || value == "Peixe")
                {
                    tipo = value;
                }
                else {
                    tipo = "Peixe";
                }                   
            }
        }
    }
}
