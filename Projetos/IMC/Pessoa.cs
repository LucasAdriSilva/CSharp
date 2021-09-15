using System;

namespace IMC
{
    class Pessoa
    {
        public Pessoa()
        {
            this.Nome = "";
            this.peso = 0;
            this.altura = 0;
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


        private Double altura;
        public Double Altura
        {
            get { return altura; }
            set { altura = value; }
        }


        private Double peso;
        public Double Peso
        {
            get { return peso; }
            set { peso = value; }
        }


        //public Double Peso { get; set; }
        //public Double Altura { get; set; }        


        public Double Calculo
        {
            get { return peso / (altura * altura); }
        }

        //public void calcularImc(Double Peso, Double Altura) {
        //    var imc = peso / (altura*altura) ;
        //    Console.WriteLine("Seu IMC é: " +imc);

        //}


        public void ExibirDados()
        {
            Console.WriteLine("Olá " + this.Nome + " vc tem " + this.idade + "  anos e seu IMC é: " + Calculo);
        }
    }
}
