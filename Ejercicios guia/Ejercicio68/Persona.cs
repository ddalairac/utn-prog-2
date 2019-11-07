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

        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Appelido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Mostrar()
        {
            return "";
        }
        public event DelegadoString eventoString;
    }
}
