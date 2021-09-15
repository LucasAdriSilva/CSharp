using System;

namespace Estudo_de_Class
{
    class Class1
    {   // Estrutura de propriedade
        private String propriedade;
        public String Propriedade
        {
            get { return this.propriedade; }
            set { this.propriedade = value.ToUpper(); }
        }
        // Estrutura de propriedade

    }
}
