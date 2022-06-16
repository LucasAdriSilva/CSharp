using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulandoTXT {
    internal class Program {
        static void Main(string[] args) {
            string x = "Hello2";
            string line;

            //*************************** Trecho para criar
            try {
                //Open the File
                StreamWriter file = new StreamWriter("D:\\Test1.txt", false);
                file.WriteLine(x);
                file.WriteLine("Teste");
                file.WriteLine("Teste");

                file.Close();
            }
            catch (Exception e) {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally {
                Console.WriteLine("Finalizado");
            }


            // *************************** Trecho apra ler
            try {
                //Cria ou abre arquivo já criado
                StreamReader sr = new StreamReader("D:\\Test1.txt");

                //Lê a priemira linha
                line = sr.ReadLine();

                //Lógica para escrever a linah e depois ler a proxima linha
                while (line != null) {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e) {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
