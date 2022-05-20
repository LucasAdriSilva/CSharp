using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooStatic
{
    public class Ferramenta
    {
        private static int NextID;
        public Ferramenta(String nome, int durabilidade)
        {
            try
            {
                NextID++;
            }
            catch 
            {
                NextID = 1;
            }
            this.ID = NextID;
            this.Durabilidade = durabilidade;
            this.Nome = nome;
        }
        public int ID { get; set; }

        public String Nome { get; set; }

        public int Durabilidade { get; set; }

        public void ExibirDados() 
        {
            Console.WriteLine("Nome: "+this.Nome+ " - ID: "+this.ID+ " - Durabilidade: "+this.Durabilidade);
        }



    }
}
