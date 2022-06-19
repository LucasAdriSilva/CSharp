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
            Console.WriteLine("--------------------------------------------------------------------------------------");

            DateTime d = new DateTime(2011,8,15,13,45,58);
            Console.WriteLine(d);
            Console.WriteLine("1) Data: "+ d.Date);
            Console.WriteLine("2) Data: "+ d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);


            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.ReadKey();

            //Função para escrevcer a data por extenso DIA DA SEMANA, NUMERICO DO MES TAL DE TAL ANO
            string s1 = d.ToLongDateString();
            Console.WriteLine(s1);

            string s2 = d.ToLongTimeString();
            Console.WriteLine(s2);

            string s3 = d.ToShortDateString();
            Console.WriteLine(s3);

            string s4 = d.ToShortTimeString();
            Console.WriteLine(s4);

            string s5 = d.ToString();
            Console.WriteLine(s5);

            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(s6);

            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s7);

            Console.ReadKey();
        }
    }
}
