﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPolimorfismo
{
    public class Formas
    {
        public Formas()
        {
            this.FormaGeometrica = "";
            this.Base = 0;
            this.Altura = 0;
        }
        public Formas(String Forma, Double Base, Double Altura)
        {
            this.FormaGeometrica = Forma;
            this.Base = Base;
            this.Altura = Altura;
        }
        public String FormaGeometrica { get; set; }
        public Double Base { get; set; }

        public Double Altura { get; set; }

        public virtual Double CalcularArea() 
        {
            return 0;
        }
    }
}
