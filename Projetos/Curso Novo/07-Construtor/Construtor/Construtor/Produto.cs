using System.Globalization;
namespace Course {
    class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;
        public Produto() {
            this.Quantidade = 10;
        }

        public Produto(string nome, double preco) : this(){
            this.Nome = nome;
            this.Preco = preco;
        }

        //Usando o This para usar outro construtor
        public Produto(string nome, double preco, int quantidade) : this(nome,preco) {
            this.Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            //return Nome+ ", $ "+ Preco.ToString("F2", CultureInfo.InvariantCulture)+ ", "+ Quantidade+ " unidades, Total: $ "+ ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            return $"{Nome}, ${Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: ${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}