using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewJogo
{
    public class Player
    {

        public Player()
        {
            this.Age = 0;
            this.Name = "";
            this.Alive = true;
            
        }
        public Player(String name, int age)
        {
            this.Age = age;
            this.Name = name;
            this.Pontos = 0;
            this.Alive = true;
            this.Skill = "";
        }

        public int Age{ get; set; }

        public String Name { get; set; }

        public String Skill { get; set; }

        private int pontos;

        public int Pontos
        {
            get { return pontos; }
            set { pontos = value; }
        }

        public Boolean Alive { get; set; }

    }
}
