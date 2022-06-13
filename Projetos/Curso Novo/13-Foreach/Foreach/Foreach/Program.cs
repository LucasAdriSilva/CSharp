using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach {
    internal class Program {
        static void Main(string[] args) {

            string[] vect = new string[] { "Carlos", "Joao", "Maria" };

            for (int i = 0; i < vect.Length; i++) {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("-----------------");

            foreach (string var in vect)
                Console.WriteLine(var);
        }
    }
}
    

