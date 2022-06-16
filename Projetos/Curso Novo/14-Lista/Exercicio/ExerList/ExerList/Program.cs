using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExerList {
    internal class Program {
        static void Main(string[] args) {

            List<Employee> employee = new List<Employee>();

            Console.Write("How may employees will be registered?: ");
            int repet = int.Parse(Console.ReadLine());

            for (int i = 0; i < repet; i++) {
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                 
                employee.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id thet will have salary increase: ");
            int ID = int.Parse(Console.ReadLine());
            Console.Write("Enter the percentaeg: ");
            double porcentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            var filter = employee.Find(x => x.Id == ID);

            if (filter != null) {
                filter.incrementSalary(porcentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }


            Console.WriteLine("----------------------------");
            foreach (Employee x in employee) {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
