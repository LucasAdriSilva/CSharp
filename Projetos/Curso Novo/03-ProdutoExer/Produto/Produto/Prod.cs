using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Produto {
    internal class Prod {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public double ValorTotalemEstoque() {
            return Price * Quantity;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantity += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantity -= quantidade;
        }

        public override string ToString() {
            return Name + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantity + " unidades, Total: $" + ValorTotalemEstoque();
        }
    }
}
