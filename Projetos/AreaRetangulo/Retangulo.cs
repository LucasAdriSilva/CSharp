using System;

namespace AreaRetangulo
{
    public class Retangulo
    {
        public Retangulo()
        {
            this.Base = 0;
            this.Altura = 0;
        }

        //Base do Retângulo
        private int baseret;
        public int Base
        {
            get { return baseret; }
            set
            {
                if (value >= 0) { baseret = value; }
                else baseret = 0;

            }
        }


        //Altura do Retângulo
        private int alturadoret;

        public int Altura
        {
            get { return alturadoret; }
            set
            {
                if (value >= 0) { alturadoret = value; }
                else alturadoret = 0;
            }
        }

        public int Area
        {
            get { return alturadoret * baseret; }
        }

        public void ExibeDados()
        {
            Console.WriteLine("-------------------^------------------");
            Console.WriteLine("Base: " + this.Base);
            Console.WriteLine("Altura: " + this.Altura);
            Console.WriteLine("Area: " + this.Area + "m²");


        }

    }
}
