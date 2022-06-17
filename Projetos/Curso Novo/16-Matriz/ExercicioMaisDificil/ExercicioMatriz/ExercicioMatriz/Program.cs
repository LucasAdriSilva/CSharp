using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMatriz {
    internal class Program {
        static void Main(string[] args) {
            string[] diretriz = Console.ReadLine().Split(' ');
            int num1 = int.Parse(diretriz[0]);
            int num2 = int.Parse(diretriz[1]);

            int[,] mat = new int[num1, num2];

            for (int i = 0; i < num1; i++) {
                string[] value = Console.ReadLine().Split(' ');
                for (int j = 0; j < num2; j++) {
                    mat[i, j] = int.Parse(value[j]);
                }
            }

            Console.Write("Escolha um valor: ");
            int chosed = int.Parse(Console.ReadLine());

            for (int i = 0; i < num1; i++) {
                for (int j = 0; j < num2; j++) {
                    if (mat[i, j] == chosed) {
                        Console.WriteLine();
                        Console.WriteLine($"Position {i},{j}");

                        if ((i - 1 >= 0)) {
                            var up =  mat[(i - 1), j];
                            //var up = i - 1 >= 0 ? mat[(i - 1), j] : 0; validação em 1 linha **FAIL**
                            Console.WriteLine($"Up: {up}");
                        }

                        if (j + 1 <= 3) {
                            var right = mat[i, (j + 1)];
                            Console.WriteLine($"Right: {right}");
                        }

                        if (i + 1 <= 2) {
                            var down = mat[(i + 1), j];
                            Console.WriteLine($"Down: {down}");
                        }

                        if (j - 1 >= 0) {

                            var left = mat[i, (j - 1)];
                            Console.WriteLine($"Left: {left}");
                        }
                    }
                }

            }



            Console.ReadKey();
        }
    }
}
