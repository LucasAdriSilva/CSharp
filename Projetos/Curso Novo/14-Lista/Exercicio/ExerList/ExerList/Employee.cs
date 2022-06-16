using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerList {
    internal class Employee {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;    
        }

        public void incrementSalary(double por) {
             Salary += Salary * por / 100;
        }

        public override string ToString() {
            return $"{Id}, {Name}, {Salary}";
        }
    }
}
