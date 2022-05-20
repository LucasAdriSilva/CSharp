using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Escolha a sua forma");
            //    Console.WriteLine("Triangulo - 1");
            //    Console.WriteLine("Quadrado - 2");
            //    Console.WriteLine("------------------------------------------------");
            //    Console.Write("A forma Geometrica que você deseja é: ");
            //    int res = Convert.ToInt32(Console.ReadLine());

            //    if (res == 1) {
            //        Console.Clear();
            //        triangulo t1 = new triangulo();
            //        Console.Write("Escreva a altura: ");
            //        t1.Altura = Convert.ToInt32(Console.ReadLine());
            //        Console.Write("Escreva a base: ");
            //        t1.Base = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("A sua area é: "+ t1.CalcularArea());

            //    }else{
            //        Console.Clear();
            //        Quadrado q1 = new Quadrado();
            //        Console.Write("Escreva a altura: ");
            //        q1.Altura = Convert.ToInt32(Console.ReadLine());
            //        Console.Write("Escreva a base: ");
            //        q1.Base = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("A sua area é: " + q1.CalcularArea());
            //    }
            Quadrado q1 = new Quadrado(2,2);
            Quadrado q2 = new Quadrado(3,3);
            Quadrado q3 = new Quadrado(10,10);

            triangulo t1 = new triangulo(2, 2);
            triangulo t2 = new triangulo(6, 6);
            triangulo t3 = new triangulo(10, 10);

            List<Formas> Formas = new List<Formas>();

            Formas.Add(q1);
            Formas.Add(q2);
            Formas.Add(q3);
            Formas.Add(t1);
            Formas.Add(t2);
            Formas.Add(t3);

            foreach (var item in Formas)
            {
                Console.WriteLine("Tipo da forma: "+item.FormaGeometrica);
                Console.WriteLine("Base: "+item.Base);
                Console.WriteLine("Altura: "+item.Altura);
                Console.WriteLine("Área: " + item.CalcularArea());
                Console.WriteLine("--------------------------------");

            }
            //ExibirDados(q1);

            //Static void ExibirDados(){
            //  Quadrado q = (Quadrado)forma;
            // q.Teste = "suhuhsa";
            // Console.WriteLine(q.Teste);
            // Console.WriteLine("Tipo da forma: "+forma.FormaGeometrica);
            //}
            Console.ReadKey();
        }
    }
}
