using Practica1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Numero : Comparable
    {
        private int valor;

        public Numero(int valor) {
            this.valor = valor;
        }

        public int getValor() {
            return this.valor;
        }

        public bool sosIgual(Comparable comparable)
        {
            return this.valor == ((Numero)comparable).valor;
        }

        public bool sosMayor(Comparable comparable)
        {
            return this.valor > ((Numero)comparable).valor;
        }

        public bool sosMenor(Comparable comparable)
        {
            return this.valor < ((Numero)comparable).valor;
        }
    }
    /* Nota: asumiremos que el elemento que recibe el mensaje y 
     * el objeto recibido como parámetro son del "mismo tipo". */
}
