using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MemberStatic {
    internal class Program {
        //static double Pi = 3.14;

        static void Main(string[] args) {

            

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circu(raio);
            Console.WriteLine("Circuferencia: "+ circ.ToString("F2", CultureInfo.InvariantCulture));

            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));






            //Console.Write("Entre o valor do raio: ");
            //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double circ = Circu(raio);
            //Console.WriteLine("Circuferencia: "+ circ.ToString("F2", CultureInfo.InvariantCulture));

            //double volume = Volume(raio);
            //Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            //Console.WriteLine("Valor de Pi: " + Pi);

        }

        //static double Circu(double r) { 
        //    return  2.0 * Pi * r;
        //}

        //static double Volume(double r) {
        //    return 4.0/3.0 * Pi * Math.Pow(r,3.0) ;
        //}


    }
}
