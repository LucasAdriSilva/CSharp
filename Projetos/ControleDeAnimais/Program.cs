using System;

namespace ControleDeAnimais
{    class Program
    {
        static void Main()
        {
            Animal a; 
            int tl;
            int tlCachorro = 0, tlGato = 0, tlPeixe = 0;
            int i;
            Animal[] animais = new Animal[20]; // ?

            Console.WriteLine("Controle de Animais");            
            Console.WriteLine("-------------------------");

            try
            {
                Console.Write("Quantos animais desja informa (Max 20): " +
                    "");
                tl = Convert.ToInt32(Console.ReadLine());
                if (tl > 20)  tl = 20; 
            }
            catch {
                tl = 0;
            }
            for (int x = 0; x < tl; x++)
            {
                a = new Animal();
                Console.Write("Informe o nome do "+(x+1)+" Animal:");
                a.Nome = Console.ReadLine();
                Console.Write("Informe o tipo do "+(x+1)+" Animal(Cachorro-0, Gato-1 ou Peixe-2): ");

                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                    if (i < 0) i = 2;
                    if (i > 2) i = 2;

                }
                catch
                {
                    i = 2;
                }
                
                a.Tipo = (TipoAnimal)i;
                if (a.Tipo == TipoAnimal.Cachorro) tlCachorro++;
                if (a.Tipo == TipoAnimal.Gato) tlGato++;
                if (a.Tipo == TipoAnimal.Peixe) tlPeixe++;

                //Armazenar o animal no vetor/Array
                animais[x] = a;
                

            }     
            Console.WriteLine("----------------------");
            //Resultado
            Console.WriteLine("Total de Animais");
            Console.WriteLine("----------------------");
            Console.WriteLine("Cachorros: " + tlCachorro + "\nGato: " + tlGato + "\nPeixes: " + tlPeixe);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
