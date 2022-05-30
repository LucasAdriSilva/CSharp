using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRet {
    internal class Retangulo {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double AreaRet() {
            return Base * Altura;
        }

        public double PerimetroRet() {
            return (2* Base) + (2* Altura);
        }

        public double DiagonaloRet() {
            return Math.Sqrt((Altura * Altura) + (Base * Base));
        }

    }
}
