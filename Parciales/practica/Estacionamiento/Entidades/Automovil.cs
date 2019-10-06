using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Clase Automovil:
    a. El constructor de clase asignará el valor hora en 50.
    b. ConsultarDatos retornará todos los datos del Automovil.
*/
namespace Entidades
{
    public class Automovil : Vehiculo
    { 
        private ConsoleColor color;
        private int valorHora;

        #region Constructores
        public Automovil(string patente, ConsoleColor color, int valorHora)
            : base(patente)
        {
            this.color = color;
            this.valorHora = valorHora;
        }

        private Automovil() : base("")
        {
            this.valorHora = 70;
        }
        public Automovil(string patente, ConsoleColor color)
            : this(patente, color, 70) { }

        #endregion

        #region Metodos
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ImprimirTicket());
            sb.AppendLine($"Modelo: {this.color}");
            sb.AppendLine($"Valor Hora: {this.valorHora}");
            return sb.ToString();
        }
        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.ConsultarDatos());
            sb.AppendLine($"Estadia: {DateTime.Now - base.ingreso: hh}");
            return sb.ToString();
        }
        #endregion
        public override bool Equals(Object obj)
        {
            if (!(obj is null) && obj is Automovil && ((Automovil)obj) == this)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
