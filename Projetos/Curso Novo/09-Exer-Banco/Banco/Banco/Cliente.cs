using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco {
    class Cliente {

        public string NomeTitular { get; set; }
        public int NumConta { get; set; }
        public double Saldo { get; private set; }

        public double Depesito(double valor) {
            Saldo += valor;
            return Saldo;
        }

        public double Saque(double valor) {
            Saldo -= valor;
            return Saldo;
        }

        public override string ToString() {
            return $"Conta {NumConta}, Titular: {NomeTitular}, Saldo ${Saldo.ToString()}";
            //return "Conta "+ NumConta+ ", Titular: "+ NomeTitular+ ", Saldo: $ "+ Saldo.ToString();
        }







    }
}
