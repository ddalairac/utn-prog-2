using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio68
{
    class Persona
    {
        private string nombre;
        private string apellido;

        public Persona()
        {
            this.nombre = "";
            this.apellido = "";
        }
        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                if (value != "")
                {
                    this.nombre = value;
                    this.eventoString.Invoke($"nuevo nombre: {this.nombre}");
                }
            }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                if (value != "")
                {
                    this.apellido = value;
                    this.eventoString.Invoke($"nuevo apellido: {this.apellido}");
                }
            }
        }
        public string Mostrar()
        {
            return $"Nombre: {this.Nombre} - Apellido:{this.Apellido}";
        }
        public event DelegadoString eventoString;
    }
}
