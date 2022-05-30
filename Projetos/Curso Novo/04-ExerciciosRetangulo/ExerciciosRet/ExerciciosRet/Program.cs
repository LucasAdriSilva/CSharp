using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRet {
    internal class Program {
        static void Main(string[] args) {

            Retangulo r = new Retangulo();  

            Console.WriteLine("Digite o valores do retangulo");

            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine());

            Console.Write("Largura: ");
            r.Base = double.Parse(Console.ReadLine());

            Console.WriteLine($"De acordo com os dados, sua área é {r.AreaRet()}cm  e seu perimetro é {r.PerimetroRet()}cm² com uma diagonal de {r.DiagonaloRet()}cm");

        }
    }
}
