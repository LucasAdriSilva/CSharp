using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooMensagem
{
    public class Mensagem
    {
        //private string TextoMensagem;

        public void ExibirMensagem(){
             Console.WriteLine(this.TextoMensagem);
         }

        // public String getTextoMensagem() {
        //     return this.TextoMensagem;
        // }

        // public void setTextoMensagem(String valor) {
        //     this.TextoMensagem = valor;
        // }
        private String textoMensagem;

        public String TextoMensagem {
            get {
                return this.textoMensagem;
            }
            set {
                this.textoMensagem = value;
            }
        
        
        
        }

    }
    
    }
