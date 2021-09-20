using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPerguntaeResposta
{
    class Program
    {
        static void Main(string[] args)
        {
            PerguntaPlus p = new PerguntaPlus();
            p.Texto = "Qual é o o site que possui um ótimo conteudo sobre programação?";
            p.Resposta = "www.google.com.br";
            p.Dica = "Você usa direto!";

            Console.WriteLine("Tente adivinhar a pergunta");
            Console.WriteLine("Perunta: "+p.Texto);
            Console.WriteLine("Dica: "+p.Dica);
            Console.Write("Resposta: ");
            String resposta = Console.ReadLine();

            if (p.Resposta.ToUpper() == resposta.ToUpper())
            {
                Console.WriteLine("Parabens você acertou");
            }
            else 
            {
                Console.WriteLine("ERRROOO");
                Console.WriteLine("Resposta certo é https:\\www.Dfilito.com.br... Animal ");
            }
            Console.ReadKey();
        }
    }
}
