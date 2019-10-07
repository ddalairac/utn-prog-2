using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Clase Moto:
    a. El constructor de clase asignará el valor hora en 30.
    b. Por defecto, las ruedas serán 2 y se cargarán en el/los constructores que corresponda.
    c. ConsultarDatos retornará todos los datos de la Moto.
*/
namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private int valorHora;

        #region Constructores
        public Moto(string patente, int cilindrada, short ruedas, int valorHora)
            : base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = ruedas;
            this.valorHora = valorHora;
        }

        private Moto() : base("")
        {
            this.valorHora = 30;
        }
        public Moto(string patente, int cilindrada, short ruedas)
            : this(patente, cilindrada, ruedas, 30) { }

        public Moto(string patente, int cilindrada)
            : this(patente, cilindrada, 2, 30) { }

        #endregion

        #region Metodos
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ImprimirTicket());
            sb.AppendLine($"Cilindrada: {this.cilindrada}");
            sb.AppendLine($"Ruedas: {this.ruedas}");
            sb.AppendLine($"Valor Hora: {this.valorHora}");
            return sb.ToString();
        }
        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.ConsultarDatos());
            TimeSpan estadia = DateTime.Now - base.ingreso;
            sb.AppendLine($"Estadia: {estadia.Hours} horas");
            return sb.ToString();
        }
        #endregion
        public override bool Equals(Object obj)
        {
            if (!(obj is null) && obj is Moto)
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
