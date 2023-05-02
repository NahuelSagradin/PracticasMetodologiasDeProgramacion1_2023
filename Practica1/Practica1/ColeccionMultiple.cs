using Practica1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practica1
{
    public class ColeccionMultiple : Coleccionable 
    {
        private Coleccionable pila;
        private Coleccionable cola;

        public ColeccionMultiple(Coleccionable pila, Coleccionable cola) 
        { 
            this.pila = pila;
            this.cola = cola;
        }

        public void agregar(Comparable comparable)
        {
            throw new NotImplementedException();
        }

        public bool contiene(Comparable comparable)
        {
            bool contiene = false;
            if (pila.contiene(comparable) || cola.contiene(comparable))
            {
                contiene = true;
            }
            return contiene;
        }

        public int cuantos()
        {
            return pila.cuantos() + cola.cuantos();
        }

        public Comparable maximo()
        {
            Comparable maximo = pila.maximo();
            if (pila.maximo().sosMenor(cola.maximo()))
            {
                maximo = cola.maximo();
            }
            return maximo;
        }

        public Comparable minimo()
        {
            Comparable minimo = pila.minimo();
            if (pila.minimo().sosMayor(cola.minimo()))
            {
                minimo = cola.minimo();
            }
            return minimo;
        }
    }
}
