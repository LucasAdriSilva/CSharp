using System;

namespace ControleDeAnimais
{    class Program
    {
        static void Main()
        {
            Animal a1 = new Animal();

            int tlCachorro = 0, tlGato = 0, tlPeixe = 0;
            int i ;

            Console.WriteLine("Controle de Animais");
            Console.WriteLine("----------------------");

            //1º Animal
            Console.Write("Informe o nome do 1º Animal:");
            a1.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do 1º Animal(Cachorro-0, Gato-1 ou Peixe-2): ");

            try
            {
                i = Convert.ToInt32(Console.ReadLine());
                if (i < 0 ) i = 2;
                if (i > 2) i = 2;

            }
            catch
            {
                i = 2;
            }

            a1.Tipo = (TipoAnimal)i;

            Console.WriteLine("----------------------");

            //if (i == 0) a1.Tipo = TipoAnimal.Cachorro;
            //if (i == 1) a1.Tipo = TipoAnimal.Gato;
            //if (i == 2) a1.Tipo = TipoAnimal.Peixe;
            if (a1.Tipo == TipoAnimal.Cachorro) tlCachorro++;
            if (a1.Tipo == TipoAnimal.Gato) tlGato++;
            if (a1.Tipo == TipoAnimal.Peixe) tlPeixe++;


            //Resultado
            Console.WriteLine("Total de Animais");
            Console.WriteLine("----------------------");
            Console.WriteLine("Cachorros: " + tlCachorro + "\nGato: " + tlGato + "\nPeixes: " + tlPeixe);

            Console.ReadKey();
        }
    }
}
