using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewJogo
{
    class Player
    {
        public Player(String name, int age)
        {
            this.Age = age;
            this.Name = name;
            this.Pontos = 0;
            this.Alive = true;
            this.Skill = "";
        }

        public int Age{ get; }

        public String Name { get;}

        public String Skill { get; set; }

        private int pontos;

        public int Pontos
        {
            get { return pontos; }
            set { pontos = value; }
        }

        private Boolean alive;

        public Boolean Alive
        {
            get { return alive; }
            set {
                if (alive == false) {
                    Console.WriteLine("Você morreu! Volte para o inicio!");
                   }
                }
        }

    }
}
