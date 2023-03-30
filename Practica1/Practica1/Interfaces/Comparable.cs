using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Interfaces
{
    public interface Comparable
    {
        public abstract bool sosIgual(Comparable comparable);
        public abstract bool sosMenor(Comparable comparable);
        public abstract bool sosMayor(Comparable comparable);

        /* Nota: asumiremos que el elemento que recibe el mensaje y
         el objeto recibido por párametro son del "mismo tipo". */
    }
    /* Una interface es una abstracción más abstracta que una clase 
     * abstracta.
     * 
     * Las interface son mecanismos diseñados por lenguajes como Java 
     * o C# para facilitar el diseño de sistemas que se implementan en 
     * el paradigma de la programacion orientada a objetos.
     * 
     * Pensar un diseño de objetos en terminos de interfaces es pensar 
     * el diseño en terminos de lo que tienen que hacer los objetos y 
     * de como colaboran entre si.
     * 
     * Una interface es un "tipo de dato". Es como declarar una clase 
     * abstracta pero sin ser superclase de una jerarquia.
     * 
     * Una interface solo define cual es el comportamiento que tienen 
     * que tener los objetos y como colaboran entre si.
     * 
     * Los metodos declarados en un interface son abstractos y publicos.
     * 
     * La interface dice que métodos deben implementar las clases que 
     * deseen "hacer" lo que define una interface.
     * 
     * Las clases pueden implementar cero, una o más interfaces. Las 
     * clases al implementar interfaces están obligadas a implementar 
     * todos los métodos declarados en las mismas.
     * 
     * (En lenguajes tipados) Se pueden declarar variables de tipo 
     * interface, pero solo se puede asignar instancias de las clases 
     * que la implementen.
     * 
     * Las interfaces NO se pueden instanciar. Esto se debe a que 
     * instanciar una interface es instanciar un objeto que no hace 
     * absolutamente nada, ya que en su cuerpo solo tiene declarado 
     * las firmas de los metodos, el desarrollo de cada uno de ellos 
     * va estar a cargo de las distintas clases que los implementen.
     * 
     * Un diseño de objetos pensado en interfaces es mucho mas facil
     * mantener y ampliar*/
}
