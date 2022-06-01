using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Encapsulamento {
    internal class Produto {
        private string _nome;                                        // Atributo privativo
        public double Preco { get; private set; } 

        public int Quantidade { get; private set; }                  // propriedades  alto emplementadas

        public Produto() { 
        }
        public Produto(string nome, double preco, int quantidade) {  // Construtores
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public string Nome {                                         //propriedades custumizadas 
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }
        public double ValorTotalEmEstoque() {                          // Medotos
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
