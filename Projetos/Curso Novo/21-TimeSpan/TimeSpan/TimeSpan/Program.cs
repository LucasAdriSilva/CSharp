using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpans {
    internal class Program {
        static void Main(string[] args) {

            TimeSpan t1 = new TimeSpan(0,1,30);
            Console.WriteLine(t1);

            TimeSpan t2 = new TimeSpan();
            Console.WriteLine(t2);

            TimeSpan t3 = new TimeSpan(900000000l);
            Console.WriteLine(t3);

            TimeSpan t4 = new TimeSpan(2,15,35);
            Console.WriteLine(t4);

            TimeSpan t5 = new TimeSpan(10,2, 15, 35);
            Console.WriteLine(t5);

            TimeSpan t6 = new TimeSpan(1, 2, 15, 35, 321);
            Console.WriteLine(t6);
            Console.WriteLine("------------------------");

            TimeSpan a1 = TimeSpan.FromDays(1.5);
            Console.WriteLine(a1);

            TimeSpan a2 = TimeSpan.FromHours(1.5);
            Console.WriteLine(a2);

            TimeSpan a3 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(a3);

            TimeSpan a4 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(a4);

            TimeSpan a5 = TimeSpan.FromTicks(10000000000);
            Console.WriteLine(a5);
        }


    }
}
