using System;
using System.Collections.Generic;
using Woker.Entites.Enuns;

namespace Woker.Entites
{
    class Worker
    {
        public String Name { get; set; }

        public WorkLevel Level { get; set; }

        public double BaseSalary { get; set; }

        public Department Department { get; set; }

        public List<HourContract> Contracts { get; private set; } = new List<HourContract>(); 

        public Worker() { }

        public Worker(string name, WorkLevel workLevel, double salary)
        {
            Name = name;
            Level = workLevel;
            BaseSalary = salary;
        }

        public override string ToString()
        {
            return $"{Name}, {Level}, {BaseSalary}";
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.totalValue();
                }
            }
            return sum;
        }
    }
}
