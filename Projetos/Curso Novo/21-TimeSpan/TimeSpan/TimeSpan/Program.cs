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

            Console.WriteLine("----------------------------------------------------------------");
            Console.ReadKey();  

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

            Console.WriteLine("----------------------------------------------------------------");
            Console.ReadKey();

            TimeSpan h1 = TimeSpan.MaxValue;
            Console.WriteLine(h1);

            TimeSpan h2 = TimeSpan.MinValue;
            Console.WriteLine(h2);

            TimeSpan h3 = TimeSpan.Zero;
            Console.WriteLine(h3);


            Console.WriteLine("----------------------------------------------------------------");
            Console.ReadKey();

            TimeSpan te1 = new TimeSpan(2, 3, 15, 20);
            Console.WriteLine(te1);

            Console.WriteLine("Days: " + te1.Days);
            Console.WriteLine("Hours: " + te1.Hours);
            Console.WriteLine("Minutes: " + te1.Minutes);
            Console.WriteLine("Milliseconds: " + te1.Milliseconds);
            Console.WriteLine("Seconds: " + te1.Seconds);
            Console.WriteLine("Ticks: " + te1.Ticks);
            Console.WriteLine("TotalDays: " + te1.TotalDays);
            Console.WriteLine("TotalHours: " + te1.TotalHours);
            Console.WriteLine("TotalMinutes: " + te1.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + te1.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + te1.TotalMilliseconds);


            Console.WriteLine("----------------------------------------------------------------");
            Console.ReadKey();

            TimeSpan x = new TimeSpan(1, 30, 10);
            TimeSpan y = new TimeSpan(0, 10, 5);

            TimeSpan sum = x.Add(y);
            TimeSpan dif = x.Subtract(y);
            //TimeSpan mult = y.Multiply(2.0);
            //TimeSpan div = y.Divide(2.0);


            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            //Console.WriteLine(mult);
            //Console.WriteLine(div);

        }


    }
}
