using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Lista {
    internal class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();

            List<string> list2 = new List<string> { "Maria", "Alex" };

            //****************** Add item a lista
            list.Add("Maria");
            list.Add("Aroldo");
            list.Add("Uche");


            //****************** Inserindo um item na lista em uma posição direcionada 
            list.Insert(2, "Arcoo");


            //****************** apresetnando todos os itns da lista 
            foreach (string s in list) {
                Console.WriteLine(s);
            }


            //****************** Numero da lista 
            Console.WriteLine($"A lista tem {list.Count} membros");


            //****************** Prucurando pelo primeiro 
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First A: " + s1);


            //****************** Prucurando pelo ultimo 
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("last A: " + s2);


            //****************** Em qual posição está o primeiro item que tem a inicial 'A'
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);


            //****************** Em qual posição está o primeiro item que tem a inicial 'A'
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);


            //****************** Filtro
            List<string> list3 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-----------------------------------");
            foreach (string x in list3) {
                Console.WriteLine(x);
            }


            //****************** Removendo itens da lista
            list.Remove("Arcoo");
            Console.WriteLine("-----------------------------------");
            foreach (string x in list) {
                Console.WriteLine(x);
            }


            //****************** Removendo todos os itens que começa com 'M'
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-----------------------------------");
            foreach (string x in list) {
                Console.WriteLine(x);
            }


            //****************** Removendo pelo index da lista
            list.RemoveAt(1);
            Console.WriteLine("-----------------------------------");
            foreach (string x in list) {
                Console.WriteLine(x);
            }


            //****************** Auxiliadores
            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
            list.Add("E");



            //****************** Removendo pelo index da lista
            list.RemoveRange(0, 4);
            Console.WriteLine("-----------------------------------");
            foreach (string x in list) {
                Console.WriteLine(x);
            }



        }

        //static bool Test(string s) {
        //    return s[0] == 'A';
        //}
    }
}
