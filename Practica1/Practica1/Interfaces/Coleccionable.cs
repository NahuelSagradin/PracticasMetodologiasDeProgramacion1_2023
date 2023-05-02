using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Interfaces
{
    public interface Coleccionable
    {
        public abstract int cuantos();
        public abstract Comparable minimo();
        public abstract Comparable maximo();
        public abstract void agregar(Comparable comparable);
        public abstract bool contiene(Comparable comparable);
    }
}
