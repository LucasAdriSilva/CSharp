using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DataTime {
    internal class Program {
        static void Main(string[] args) {


            DateTime d1 = DateTime.Now;

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);


            DateTime d2 = new DateTime(2018, 11,25);
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2018, 11, 25, 20,45,03);
            Console.WriteLine(d3);

            DateTime d4 = DateTime.Now;
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);

            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);



            DateTime FR = DateTime.Parse("2000-8-15");
            Console.WriteLine(FR);


            DateTime FR2 = DateTime.Parse("2000-8-15 13:05:58");
            Console.WriteLine(FR2);

            DateTime FR3 = DateTime.Parse("15/08/2000 20:50:30");
            Console.WriteLine(FR3);



            DateTime FR4 = DateTime.ParseExact("2022-12-15 13:05:56", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(FR4);


            Console.ReadKey();
        }
    }
}
