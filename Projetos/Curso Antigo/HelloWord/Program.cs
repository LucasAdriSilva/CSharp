using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    class Program
    {
        /* enum Cor { Azul, Verde, Amarelo, Vermelho };*/
         static void Main()
             {   /*Int - -156 <-> 123123
            Float - -15.5f <-> 2123123.6f
            Bool - True || False
            String - "palavra"
            Char - 'a'
            int segundaGuerraMundial = 1945;
            var cor_Favorita = "vermelho";
            dynamic cor_Favorita = "Vermelho";
            var meuTexo = "Hello Word - Testando";
            cor_Favorita = 123123;
            Console.WriteLine(cor_Favorita);
            const float PI = 3.145565656F;



            Console.WriteLine("Escreva seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Ola nome é :");
            Console.WriteLine(nome);
            Console.ReadLine();
            / * antes do + -
            int num1 = 20 + 20 - 10;
            int num2 = 30 + 20;
            float num3 = 5f / 3;
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num3);
             int idade;
            string name;
            Console.WriteLine("Digite a sua Nome:");
            name = Console.ReadLine();
            Console.WriteLine("Digite a sua Idade:");
            idade = int.Parse(Console.ReadLine());
            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Olá " + name + " você é Criança");
            }
            else if (idade >= 12 && idade <= 18)
            {
                Console.WriteLine("Olá " + name + " você é Adolecente");
            }
            else if (idade >= 19 && idade <= 60)
            {
                Console.WriteLine("Olá " + name + " você é Adulto");
            }
            else {
                Console.WriteLine("Olá " + name + " você é Idoso");
            }
            ExibirMsg();
            GerarPreco(-30);
            Console.ReadLine();

            Console.ReadLine();
            
            
            
            static void ExibirMsg() {
            Console.WriteLine("1º linha da função");
            Console.WriteLine("2º linha da função");
            Console.WriteLine("3º linha da função");
            
        }
            static void GerarPreco(int preco) {
            int precoabs = Math.Abs(preco);
            int valorfinal = precoabs + (2 * precoabs);
            Console.WriteLine("Preço final é " + valorfinal);
        }            
            int somar1 = Somar(1, 2, 3);
            int somar2 = Somar(6, 8, 600);
            int somar3 = Somar(-1, 22, 354);
            Console.WriteLine(somar1);
            Console.WriteLine(somar2);
            Console.WriteLine(somar3);
            Console.ReadLine(); 
        }    
        
        
        static int Somar(int a, int b, int c) {
            int resultadoFInal = a + b + c;
            return resultadoFInal;
            
            string[] produtos = new string[5] { "a", "b", "c", "d", "e" };
            int[] valores = {10,20,30,3,50};

            produtos[2] = "Fifa2021";

            Console.WriteLine(produtos[2]);
            Console.ReadLine();
            

            string cor = "Claro";
            switch (cor) {
                case "Vemelho":
                    Console.WriteLine("Sua corfavorita é Vermelho");
                    break;
                case "Roxo":
                    Console.WriteLine("Sua corfavorita é Roxo");
                    break;
                case "Verde":
                    Console.WriteLine("Sua corfavorita é Verde");
                    break;
                case "Violeta":
                    Console.WriteLine("Sua corfavorita é Violeta");
                    break;
                case "Azul":
                    Console.WriteLine("Sua corfavorita é Azul");
                    break;

                default:
                    Console.WriteLine("Cor não encontrada");
                    break;
                    

            };
            Console.ReadLine();

           

            Cor corFavorita = Cor.Verde;
            Cor corFavorita2 = Cor.Amarelo;

            Console.WriteLine((int)corFavorita2);
            Console.WriteLine(corFavorita2);
            Console.WriteLine((Cor)2);

            Console.ReadLine();
             

            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecioanda = (Opcao)index;

            switch (opcaoSelecioanda) {
                case Opcao.Criar:
                    Console.WriteLine("Criando Seu Projeto..");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Tem Certeza?");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Mudando");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("1-Chorar\n2-Deitar\n3-Comer\n4-Matar\n5-Tchau");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("Att em 3\n2\n1\nFOIIIII");
                    break;

            }
            */

            var lista = new List<String> { 1, 2, 3, 4, 5, 6, 7, 8 };
            var listaFiltrada = lista.Where(x => x < 4);

            Console.WriteLine(listaFiltrada);
            Console.ReadLine();







        }

    }
}
