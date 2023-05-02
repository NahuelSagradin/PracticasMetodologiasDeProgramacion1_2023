using Practica1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Alumno : Persona
    {
        /* En C#, los atributos se heredan automáticamente de una clase base a una clase derivada, a menos que se anulen explícitamente en la clase derivada.
         * Por ejemplo, si tienes una clase base llamada Persona con un atributo llamado Nombre, y una clase derivada llamada Alumno que hereda de Persona, la clase Alumno tendrá automáticamente el atributo Nombre.
         */

        private int legajo;
        private int promedio;

        /* Constructor: los constructores no se heredan de la clase base a la clase derivada. Sin embargo, es posible llamar al constructor de la clase base desde el constructor de la clase derivada utilizando la palabra clave base.
         * 
         * En este ejemplo, la clase Alumno hereda de la clase Persona. La clase Persona tiene un constructor que acepta un parámetro nombre, que se utiliza para inicializar el campo privado nombre.
         * La clase Alumano tiene su propio constructor que acepta un parámetro nombre. El constructor de la clase Alumno llama al constructor de la clase Persona utilizando la palabra clave base, y pasa el parámetro nombre al constructor de la clase Persona.
         * De esta manera, el constructor de la clase base se llama desde el constructor de la clase derivada, lo que permite inicializar los campos privados y cualquier otra lógica que se necesite en la clase base.
         */
        public Alumno(string nombre, int dni, int legajo, int promedio) : base(nombre, dni)
        { 
            
        }

        /* Propiedades: las propiedades se utilizan para encapsular los campos privados y proporcionar una forma controlada de acceder y modificar sus valores. Las propiedades se pueden definir en una clase utilizando los siguientes elementos:
         * 
         * - Un campo privado (o una expresión lambda) que contiene el valor de la propiedad.
         * - Un método get que devuelve el valor del campo privado.
         * - Un método set que establece el valor del campo privado.
         */

        public int Legajo {
            //get { return legajo; }
            get;
        } 

        public int Promedio {
            //get { return promedio; }
            get;
        }

        public bool sosIgual(Comparable comparable) {
            return this.promedio == ((Alumno)comparable).Promedio; //cuando hago referencia a una variable miembro, utilizo el atributo o la propiedad. Si utilizo la propiedad, hace falta poner el this??
        }
        public bool sosMenor(Comparable comparable) {
            return this.promedio < ((Alumno)comparable).Promedio;
        }
        public bool sosMayor(Comparable comparable) {
            return this.promedio > ((Alumno)comparable).Promedio;
        }
    }
}
