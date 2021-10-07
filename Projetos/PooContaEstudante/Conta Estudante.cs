using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooContaEstudante
{
    class Conta_Estudante : ContaBancaria
    {
        public Conta_Estudante(): base()
        {
            this.limite = 500;
        }

        private Double limite;
        public Double Limete {
            get{
                return this.limite;
            }

        }

        public override Double Retirar(Double valor)
        {
            if (this.saldo+this.limite >= valor)
            {
                this.saldo -= valor;
            }
            else
            {
                throw new Exception("Saldo insuficiente");
            }
            return this.saldo;
        }
        public void ExibirDadosBancarios() {
            Console.WriteLine("Dados do correntista: "+this.Correntista.Nome);
            Console.WriteLine("Saldo: "+this.Saldo);
            Console.WriteLine("Limite: "+this.Limete);
        }
    }
}
