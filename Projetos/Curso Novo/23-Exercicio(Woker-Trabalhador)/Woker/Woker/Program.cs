using System;
using System.Globalization;
using Woker.Entites.Enuns;
using Woker.Entites;



namespace Woker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
           string departName =Console.ReadLine();

            Console.WriteLine("Enter woker data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            //Convertendoa  entrada para o tipo Enum
            Console.Write("Level: ");         
            WorkLevel level = (WorkLevel)Enum.Parse(typeof(WorkLevel), (Console.ReadLine().ToUpper()));

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Worker woker = new Worker(name, level, baseSalary);
            Department Depart = new Department(departName);

            Console.Write("How many contracts to this worker? ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"#{i} Contract data");

                Console.Write("Date DD/MM/YYYY");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contra = new HourContract(date, valuePerHour, hours);
                woker.addContract(contra);
            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.Clear();

            Console.WriteLine("Name : " + woker.Name);
            Console.WriteLine("Department: " + woker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + woker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
