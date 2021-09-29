using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewJogo
{
    public class F
    {
        //Para escrever
        public static void E(String texto) 
        {
            Console.WriteLine(texto);
        }

        //capturar uma String
        public static String C()
        {
            return Console.ReadLine();          
        }
       
        //capturar um Inteiro
        public static int c(int texto)
        {
            texto = Convert.ToInt32(Console.ReadLine());
            return texto;
        }

        //Para pausar
        public static void P()
        {
            Console.ReadKey();
        }

    }
}
