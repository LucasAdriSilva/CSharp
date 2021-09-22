using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooZoologico
{
    public class Animal
    {
        public Animal()
        {
            this.Peso = 0;
            this.Especie = "";
        }
        public Animal(String especie, Double peso)
        {
            this.Especie = especie;
            this.Peso = peso;
        }
        public Double Peso { get; set; }
        public String Especie { get; set; }

    }
}
