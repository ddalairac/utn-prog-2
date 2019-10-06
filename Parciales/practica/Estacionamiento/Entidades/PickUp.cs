using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Clase PickUp:
    a. El constructor de clase asignará el valor hora en 70.
    b. ConsultarDatos retornará todos los datos de la PickUp.
*/
namespace Entidades
{
    public class PickUp:Vehiculo
    {
        private string modelo;
        private int valorHora;

        #region Constructores
        public PickUp(string patente, string modelo, int valorHora)
            : base(patente)
        {
            this.modelo = modelo;
            this.valorHora = valorHora;
        }

        private PickUp() : base("")
        {
            this.valorHora = 70;
        }
        public PickUp(string patente, string modelo)
            : this(patente, modelo, 70) { }

        #endregion

        #region Metodos
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ImprimirTicket());
            sb.AppendLine($"Modelo: {this.modelo}");
            sb.AppendLine($"Valor Hora: {this.valorHora}");
            return sb.ToString();
        }
        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder("*** TICKET ***\n");
            sb.Append(this.ConsultarDatos());
            sb.AppendLine($"Estadia: {DateTime.Now - base.ingreso: hh}");
            return sb.ToString();
        }
        #endregion
        public override bool Equals(Object obj)
        {
            if (!(obj is null) && obj is PickUp && ((PickUp)obj) == this)
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
