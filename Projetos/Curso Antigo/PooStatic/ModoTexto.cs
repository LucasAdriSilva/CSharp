using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooStatic
{
    public class ModoTexto
    {
        static public String log;
        static public void Escrever(String texto)
        {
            Console.WriteLine(texto);
        }
        static public void Pausar()
        {
            Console.ReadKey();
        }
        static public string Ler()
        {
            return Console.ReadLine(); 
        }
        static public string Ler(String texto)
        {
            Console.Write(texto);
            return Console.ReadLine();
        }
    }
}
