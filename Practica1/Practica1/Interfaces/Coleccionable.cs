using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Interfaces
{
    internal interface Coleccionable
    {
        public abstract int cuantos();
        public abstract int minimo();
        public abstract int maximo();
        public abstract void agregar(Comparable comparable);
        public abstract bool contiene(Comparable comparable);
    }
}
