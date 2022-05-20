using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class Conection
    {
        private const string servidor = "localhost";
        private const string bancoDados = "livros";
        private const string usuario = "root";
        private const string senha = "Uche@3517";

        static public string strConection = $"server={servidor}; User Id= {usuario};database={bancoDados}; password={senha}";

    }
}
