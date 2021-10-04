using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPolimorfismo
{
    public class Quadrado : Formas
    {
        public Quadrado() : base() { }
        public Quadrado(String Forma, Double Base, Double Altura) : base(Forma, Base, Altura) 
        { }

        private String formageometrica;

        public override string FormaGeometrica { 
            get => base.FormaGeometrica; 
            
        }
        

        public override Double CalcularArea() 
        {
            return this.Base * this.Altura;
        }
    }
}
