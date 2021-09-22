using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooZoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AnimalPlus> animais = new List<AnimalPlus>();
            int countCar=0, countHer=0;
            Console.WriteLine("Programa que conta os animais Carnivoros e Herbivoros");
            for (int i = 0; i < 4 ; i++)
            {
                AnimalPlus animal = new AnimalPlus();
                Console.Write("Especie: ");
                animal.Especie = Console.ReadLine();
                Console.Write("Peso: ");
                animal.Peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("Tipo de Alimentação: ");
                animal.TipoAlimentacao = Console.ReadLine();
                if (animal.TipoAlimentacao == "Carnivoro") { countCar++; } else { countHer++; }
                animais.Add(animal);
            }
            Console.WriteLine("------------------------------------------------" );

            Console.WriteLine("Total de animais Carnivoros: " + countCar);
            Console.WriteLine("Total de animais Herbivoros: " + countHer);
            Console.ReadKey();
        }
    }
}
