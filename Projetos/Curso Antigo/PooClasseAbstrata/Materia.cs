using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooClasseAbstrata
{
    public class Materia : ModeloMateria
    {
        public Materia()
        {
            this.Nome = "";
            this.Nota1 = 0;
            this.Nota2 = 0;
            this.MediaAprovacao = 5;
        }
        public Materia(String nome, Double nota1, Double nota2, Double mediaaprovacao )
        {
            this.Nome = nome;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.MediaAprovacao = mediaaprovacao;
        }

        public Double MediaAprovacao { get; set; }

        public Double Media {
            get { return (this.Nota1 + this.Nota2) / 2; }             
        }
        public override void ExibirDados()
        {
            Console.Clear();
            Console.WriteLine("Materia: "+this.Nome);
            Console.WriteLine("1º nota: "+this.Nota1);
            Console.WriteLine("1º nota: " + this.Nota2);
            Console.WriteLine("Media: "+this.Media);
            Console.WriteLine("Media para aprovação: "+this.MediaAprovacao);
            Console.WriteLine("Status da materia: " + this.res());

            Console.ReadKey();
        }

        public String res() {
            string msg = "Não aprovado";
            if (this.Media >= this.MediaAprovacao) { msg = "Aprovado"; }
            return msg;
        }
    }
}
