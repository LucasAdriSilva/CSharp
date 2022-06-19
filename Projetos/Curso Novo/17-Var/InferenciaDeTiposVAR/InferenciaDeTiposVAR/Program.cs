using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InferenciaDeTiposVAR {
    internal class Program {
        static void Main(string[] args) {

            //Utilização da palavra var
            var x = 10;
            var y = 20.0;
            var z = "Maria";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);


            //Utilização do Switch-case


            int sw = int.Parse(Console.ReadLine());
            string day;

            switch (sw) {
                case 1:
                    day = "Sanday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wenesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;

                default:
                    day = "Invalid value";
                    break;
            }

            Console.WriteLine(day);

            Console.ReadKey();
        }
    }
}
