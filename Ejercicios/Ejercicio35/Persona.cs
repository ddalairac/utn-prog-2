using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
    public class Persona
    {
        protected int dni;
        protected string nombre;

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public Persona(string nombre)
        {
            this.dni = 0;
            this.nombre = nombre;
        }
        public Persona(int dni, string nombre) : this(nombre)
        {
            this.dni = dni;
        }
        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"Dni: {this.dni}\n");
            str.Append($"Nombre: {this.nombre}");
            return str.ToString();
        }
    }
}
