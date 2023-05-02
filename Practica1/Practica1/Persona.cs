using Practica1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Persona : Comparable
    {
        private string nombre;
        private int dni;

        public Persona(string nombre, int dni) {
            this.nombre = nombre;
            this.dni = dni;
        }

        public string Nombre
        {
            get { return nombre; } 
        }

        public int Dni
        {
            get { return dni; }
        }

        public bool sosIgual(Comparable comparable)
        {
            return this.dni == ((Persona)comparable).dni; 
        }

        public bool sosMayor(Comparable comparable)
        {
            return this.dni > ((Persona)comparable).dni;
        }

        public bool sosMenor(Comparable comparable)
        {
            return this.dni < ((Persona)comparable).dni;
        }
    }
}
