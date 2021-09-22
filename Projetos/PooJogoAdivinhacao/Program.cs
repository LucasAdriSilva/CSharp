using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooJogoAdivinhacao
{
    class Program
    {
        static void Main()
        {   
            //Lista de Perguntas
            List<NovaPergunta> perguntas;
            perguntas = CriarPerguntas();

            //Pergunta que será exibida para o usuário
            Random r = new Random();
            int pos = r.Next(0,perguntas.Count);
            NovaPergunta pergunta = perguntas[pos];

            //Logica de resposta
            int tentativas = 0;
            Boolean flag = false;
            string res = "";
            while (tentativas < 3 && flag == false) 
            {
                Console.WriteLine("pergunta: " + pergunta.Pergunta);
                Console.Write("Resposta: ");
                res = Console.ReadLine();
                if (res == pergunta.Resposta)
                {
                    flag = true;
                }
                else 
                {
                    Console.WriteLine("Erro!!! Dica: " + pergunta.Dica);
                }
                tentativas++;
            }
            if (flag == true)
            {
                Console.WriteLine("Parabens acertou!");
            }
            else { Console.Write("Que pena vc perdeu !!S"); 
            }

            Console.ReadKey();
        }

        static List<NovaPergunta> CriarPerguntas() 
        {
            List<NovaPergunta> lista = new List<NovaPergunta>();
            NovaPergunta p = new NovaPergunta("Qual é cor do céu?","Azul","Começa com A");
            lista.Add(p);
            p = new NovaPergunta("Qual é cor da terra?", "Marrom", "Começa com m");
            lista.Add(p);
            p = new NovaPergunta("Qual é a soma de 20 + 60?", "80", "80");
            lista.Add(p);
            p = new NovaPergunta("Qual é a soma de 20 + 90?", "110", "110");
            lista.Add(p);
            p = new NovaPergunta("Qual é a soma de 20 + 5?", "25", "25");
            lista.Add(p);
            p = new NovaPergunta("Qual é a soma de 20 + 0?", "20", "2O");
            lista.Add(p);
            p = new NovaPergunta("Qual é a soma de 20 - 15?", "5", "5");
            lista.Add(p);
            p = new NovaPergunta("Qual é a soma de 20 + 5000?", "5020", "5020");
            lista.Add(p);

            lista.Add(new NovaPergunta("Aplicativo de assistir filmes", "Netflix", "net + flix"));
            return lista;
        }
    }
}
