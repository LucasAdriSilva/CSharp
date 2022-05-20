using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooStatic
{
    class Program
    {
        static void Main(string[] args)
        {

            Ferramenta f1 = new Ferramenta("Martelo", 100);            
            f1.ExibirDados();
            Ferramenta f2 = new Ferramenta("Prego", 100);
            f2.ExibirDados();
            Console.ReadKey();



















        //    String nome = "Lucas";
        //    ModoTexto.log = nome;
        //    //ModoTexto.Escrever("Qual é seu nome?");
        //    nome = ModoTexto.Ler("Qual é seu nome?: ");
        //    ModoTexto.Escrever("Olá " + ModoTexto.log + ", tudo bem ?");
        //    ModoTexto.Pausar();
        }
    }
}
