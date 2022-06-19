using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionInterestingStrings {
    internal class Program {
        static void Main(string[] args) {

            string origin = "abcsads ASD ABC abc DEFG      ";

            //Alterando tudo para maiusculo
            string s1 = origin.ToUpper();
            Console.WriteLine("ToUpper -" + s1 + "-");

            //Alterando tudo para minusculo
            string s2 = origin.ToLower();
            Console.WriteLine("ToLower -" + s2 + "-");

            //Apaga todos os espaços em branco tanto depois quanto an frente da string
            string s3 = origin.Trim();
            Console.WriteLine("Trim -" + s3 + "-");

            //Para procurar o primeiro caso
            int s4 = origin.IndexOf("bc");
            Console.WriteLine("IndexOf(bc) -" + s4 + "-");

            //Para procurar o ultimo caso
            int s5 = origin.LastIndexOf("bc");
            Console.WriteLine("LastIndexOf(bc) -" + s5 + "-");

            //recorta string primeiro aprametro corta apartir daquele ponto, segundo aprametro diz quantos caracteres vai ser cortado
            string s6 = origin.Substring(17, 2);
            Console.WriteLine("Substring(17, 2) -" + s6 + "-");

            //Subistuição 
            string s7 = origin.Replace("bc", "AAAA");
            Console.WriteLine("Replace('bc', 'AAAA') -" + s7 + "-");


            //Verificação se string não é vazia  
            bool s8 = String.IsNullOrEmpty(origin);
            Console.WriteLine("String.IsNullOrEmpty(origin) -" + s8 + "-");

            //Verificação se string tem espaço em branco 
            bool s9 = String.IsNullOrWhiteSpace(origin);
            Console.WriteLine("String.IsNullOrWhiteSpace(origin) -" + s9 + "-");

            //Recorta um string de e add em um array
            string[] s10 = origin.Split(' ');
            Console.WriteLine("Split(' ') -" + s10[0] + s10[1] + "-");

            // ******** usansdo metodo Compare(strin1 , posição de comapração da string 1,strin2 , posição de comapração da string 2, total de caracter, culture = null, options = como ignorar maiúsculas e minúsculas ou símbolos  )
            Console.WriteLine("---------------------------------------------------");
            string name1 = "Jack Smith";
            string name2 = "John Doe";

            // Pegar a proxima posição depois do espaço.
            int index1 = name1.IndexOf(" ");
            index1 = index1 < 0 ? 0 : ++index1;

            int index2 = name2.IndexOf(" ");
            index2 = index2 < 0 ? 0 : ++index2;

            // pegar o numero amior entre 2 length
            int length = Math.Max(name1.Length, name2.Length);

            Console.WriteLine("Sorted alphabetically by last name:");
            if (String.Compare(name1, index1, name2, index2, length) < 0)
                Console.WriteLine("{0}\n{1}", name1, name2);
            else
                Console.WriteLine($"{name2}\n{name1}");
            Console.WriteLine("---------------------------------------------------");


            // ***************************************************************** usansdo metodo Compare()



        }
    }
}
