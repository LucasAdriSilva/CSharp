using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorDeParam {
    internal class Program {
        static void Main(string[] args) {

            int res;
            int s1 = Calculator.Sum(2, 5);
            Console.WriteLine(s1);

            int s2 = Calculator.Sum(2, 5,1);
            Console.WriteLine(s2);

            int s3 = Calculator.Sum(2, 5,1);
            Console.WriteLine(s3);

            int s4 = Calculator.Summ(2,3,6,5,8,9,1,2,3,3,3);

            Console.WriteLine(s4);

            //usando ref não precisa inicar a variavel
            Calculator.Triple(ref s4);
            Console.WriteLine(s4);

            //Usando out nao usando uma variavel iniciado
            Calculator.Triplee(s4, out res);
            Console.WriteLine(s4);


            Console.ReadKey();


        }
    }
}
