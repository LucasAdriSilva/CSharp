using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorDeParam {
    class Calculator {

        //************************
        //************************ <Metodo errado>
        //************************
        public static int Sum(int n1, int n2) {
            return n1 + n2;
        }
        public static int Sum(int n1, int n2, int n3) {
            return n1 + n2 + n3;
        }
        //************************
        //************************ </Metodo errado>
        //************************


        //Usando paramns
        public static int Summ(params int[] numbers ) { 
            int sub = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sub += numbers[i];
            }
            return sub; 
        }

        //usando Ref necessário a variavel ser inciada 
        public static void Triple(ref int x) {
            x = x * 3;
        }



        //Usando out nao usando uma variavel iniciado
        public static void Triplee(int origin, out int res) {
            res = origin * 3;
        }
    }
}
