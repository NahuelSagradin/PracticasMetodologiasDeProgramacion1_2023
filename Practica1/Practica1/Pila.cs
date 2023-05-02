using Practica1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Pila : Coleccionable
    {
        List<Comparable> elementos;

        public Pila() { 
            elementos = new List<Comparable>();
        }

        public List<Comparable> getElementos() {
            return elementos;
        }
        private void apilar(Comparable xComparable) {
            elementos.Add(xComparable);
        }

        public Comparable desapilar() {
            Comparable xElemeto = tope();
            elementos.Remove(tope());
            return xElemeto;
        }

        public Comparable tope() {
            return elementos[elementos.Count - 1];
        }

        public Boolean estaVacia() {
            return elementos.Count == 0;
        }


        public void agregar(Comparable comparable)
        {
            apilar(comparable);
        }

        public bool contiene(Comparable comparable)
        {
            bool contiene = false;

            for (int i = 0; i < this.cuantos(); i++)
            {
                if (elementos[i].sosIgual(comparable))
                {
                    contiene = true;
                }
            }
            return contiene;
        }

        public int cuantos()
        {
            return elementos.Count;
        }

        public Comparable maximo()
        {
            Comparable maximo = tope();
            for (int i = (cuantos() - 2); i >= 0; i--)
            {
                if (maximo.sosMenor(elementos[i]))
                {
                    maximo = elementos[i];
                }
            }
            return maximo;
        }

        public Comparable minimo()
        {
            Comparable minimo = tope();
            for (int i = (cuantos() - 2); i >= 0; i--)
            {
                if (minimo.sosMayor(elementos[i]))
                {
                    minimo = elementos[i];
                }
            }
            return minimo;
        }
    }
}
