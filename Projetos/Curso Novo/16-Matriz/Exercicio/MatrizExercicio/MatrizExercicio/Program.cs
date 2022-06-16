using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizExercicio {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o valor da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n,n];

            //Para trabalhar com matriz usamos a sequenciad e dois for um para a linha outro para a coluna matriz[i,j]
            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Main diagonal: ");


            for (int i = 0; i < n; i++) {
                Console.Write(matriz[i,i]+ " ");
            }

            Console.WriteLine(" ");
            int count = 0;


            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (matriz[i, j] < 0)
                        count++;
                }
            }
            Console.Write("Total de numeros negativos: " + count);

            Console.ReadKey();
        }
    }
}
