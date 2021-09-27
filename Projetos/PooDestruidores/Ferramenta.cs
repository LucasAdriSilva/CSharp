using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooDestruidores
{
    public class Ferramenta
    {
        public Ferramenta(String nome)
        {
            this.Nome = nome;
        }

        ~Ferramenta() 
        {
            Console.WriteLine("A sua ferramenta "+this.Nome+" foi destruida.");
        }
        public String Nome { get; set; }
    }
}
