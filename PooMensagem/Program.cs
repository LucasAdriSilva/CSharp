using System;

namespace PooMensagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1, msg2, res;
            msg1 = new Mensagem();
            msg2 = new Mensagem();
            res = new Mensagem();
            msg1.TextoMensagem = "Aló mundo!!!";
            msg1.ExibirMensagem();




            Console.ReadKey();
        }
    }
}
