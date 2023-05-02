using Practica1.Interfaces;

namespace Practica1
{
    public class Cola : Coleccionable
    {
        /* Una cola es una estructura de datos en la cual los elementos 
         * almacenados en la misma se agregan al final y se sacan del 
         * principio de la cola. 
         * 
         * Esta caracteristica hace que el primer elemento insertado en 
         * la cola es el primero en salir, como en cualquier cola de la 
         * realidad (en un banco, en el cine, en el colectivo). 
         * 
         * Este tipo de estructuras se denominan FIFO (First In First 
         * Out). El primer elemento en entrar es el primer elemento en 
         * salir.*/

        /* Una Cola es una lista lineal de elementos en la que las 
         * operaciones de insertar y eliminar se hacen en diferentes extremos 
         * de la cola. 
         * 
         * Tipos: 
         * 
         * - Cola simple. 
         * - Cola Circular: representacion logica de una cola simple en un 
         * array. 
         * - Cola de Prioridades: los elementos se insertan en cualquier 
         * posicion, pero solo se remueven por el frente. 
         * - Cola Doble: los elementos se pueden agregar o quitar por 
         * cualquier extremo de la cola. 
         * 
         * Representacion de colas: 
         * 
         * - Memoria Fija: con Arrays de tamaño fijo y frente movil o fijo. 
         * - Memoria Dinamica: con listas enlazadas. */

        private List<Comparable> elementos;

        public Cola() { 
            elementos = new List<Comparable>();
        }   

        public List<Comparable> Elementos {
            get;
        }
        private void encolar(Comparable comparable) {
            elementos.Add(comparable);
        }

        public Comparable desencolar() {
            Comparable xElemento = null;
            if (tope() != null) {
                xElemento = tope();
                elementos.Remove(tope());
            }
            return xElemento;
        }

        public Comparable tope() {
            Comparable xElemento = null;
            if (!estaVacia()) {
                xElemento = elementos[0];
            }
            return xElemento;
        }

        public bool estaVacia() {
            return elementos.Count == 0;
        }
        
        // Metodos implementados de la interface coleccionable 
        public void agregar(Comparable comparable)
        {
            encolar(comparable);
        }

        public bool contiene(Comparable comparable)
        {
            bool contiene = false;

            for (int i = 0; i < cuantos(); i++)
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

            for (int i = 1; i < cuantos(); i++)
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
            for (int i = 1; i < cuantos(); i++)
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
