using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooContaEstudante
{
    class ContaBancaria
    {
        public Cliente Correntista { get; set; }

        public ContaBancaria()
        {
            this.saldo = 0;
            this.Correntista = new Cliente();

        }

        private Double saldo;
        public Double Saldo
        {
            get { return saldo; }

        }

        public void Depositar(Double valor) {
            this.saldo += valor;
        }
        public virtual Double Retirar(Double valor) 
        {
            if (this.saldo >= 0)
            {
                this.saldo -= valor;
            }
            else {
                throw new Exception("Saldo insuficiente");
            }
            return this.saldo;
        }

    }
}
