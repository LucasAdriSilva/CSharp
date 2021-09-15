using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Pessoa
    {
        public Pessoa() {
            this.Nome = "";
            this.peso = 0.;
            this.altura = 0.;
            this.idade = 0;
        }
        private int idade;

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        private String nome;
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }        

        public float peso { get; set; }
        public float altura { get; set; }
        
        public void ExibirDados() {
            Console.WriteLine("Olá "+this.Nome+" vc tem "+this.idade+ "  anos e seu Imc é: "+this.calcularImc(this.peso,this.altura));
            Console.ReadKey();
        }

        public float calcularImc(float peso, float altura) {
            var imc = peso / (altura*altura) ; 
            return imc;
        }
    }
}
