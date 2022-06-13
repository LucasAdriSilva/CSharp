﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores3 {
    internal class Program {
        static void Main(string[] args) {

            Student[] vect = new Student[10];

            Console.WriteLine("Quantos quartos serão alugados");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n ; i++) {
                Console.WriteLine();
                int correct = i + 1;
                Console.WriteLine($"Aluguel #{correct}");

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());

                vect[room] = new Student(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }

            }







        }
    }
}
