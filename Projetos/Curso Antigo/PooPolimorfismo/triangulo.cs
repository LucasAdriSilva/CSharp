using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPolimorfismo
{
    public class triangulo : Formas
    {
        public triangulo() :base()
        {
            base.FormaGeometrica = "Triangulo";
        }
        public triangulo(Double Base, Double Altura) : base("Triangulo", Base, Altura) { }

        public override string FormaGeometrica
        {
            //get => base.FormaGeometrica;
            get
            {
                return base.FormaGeometrica;
            }
        }
        public override Double CalcularArea()
        {
            return (this.Base * this.Altura)/2;
        }
    }
}
