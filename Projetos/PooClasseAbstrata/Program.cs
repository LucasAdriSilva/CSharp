using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Controle de matréria:");
            int op = 0;
            while (op != 5) {
                op = ExibirMenu();

                if (op == 1) { /*Exibir*/}
                if (op == 2) { /*Cadastrar*/}
                if (op == 3) { /*Alterar dados*/}
                if (op == 4) { /*Excluir uma das matérias*/}
                if (op == 5) { /*Sair*/}
            }
            Console.ReadKey();
        }

        static int ExibirMenu() {
            int op = 0;
            while (op < 1 || op > 5) {
                 Console.WriteLine("1 - Exibir Matérias"); 
                 Console.WriteLine("2 - Cadastrar"); 
                 Console.WriteLine("3 - Alterar dados das materias");
                 Console.WriteLine("4 - Excluir uma das matérias");
                 Console.WriteLine("5 - Sair");
                Console.WriteLine("--------------");
                 Console.Write("Opcão: ");
                op = Convert.ToInt32(Console.ReadLine());
              
            }
            return op;
        }
    }
}
