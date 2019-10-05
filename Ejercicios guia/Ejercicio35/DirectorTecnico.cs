using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaDeNacimiento;

        public DateTime FechaDeNacimiento
        {
            get { return this.fechaDeNacimiento; }
            //set { fechaDeNacimiento = value; }
        }

        public DirectorTecnico(string nombre) : base(nombre) { }
        public DirectorTecnico(string nombre, DateTime fechaDeNacimiento) : this(nombre)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        public new string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.MostrarDatos());
            str.Append($"fecha De Nacimiento: {this.fechaDeNacimiento}\n");
            return str.ToString();
        }
    }
}
