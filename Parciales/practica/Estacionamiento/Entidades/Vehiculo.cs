using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Clase Vehiculo:
    a. En el constructor, la fecha de ingreso será cargada 3 horas previas a la creación del objeto mediante el método DateTime.Now.AddHours(-3).
    b. La propiedad Patente validará que la misma tenga 6 caracteres, caso contrario no la asignará.
    c. ConsultarDatos no tendrá implementación en Vehiculo.
    d. ToString utilizará el método Format de la clase String y retornará la Patente del Vehiculo con el siguiente formato: "Patente {0}".
    e. ImprimirTicket podrá ser anulado en las clases derivadas. Utilizará StringBuilder para retornar los 
       datos del Vehiculo (reutilizar ToString) y la fecha y hora de ingreso.
    f. Dos Vehiculos serán iguales si tienen la misma patente y son objetos de la misma clase (utilizar el
       Equals sobreescrito en las clases derivadas según corresponda).
General:
    a. El método ImprimirTicket de las siguientes clases agregará a la información descripta en Vehiculo el
      costo de la estadía, siendo este el resultado de la cantidad de horas desde su ingreso hasta ahora *
      el valor de la hora.
*/
namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public string Patente
        {
            get { return this.patente; }
            set
            {
                if (!(value is null) && value is string && ((string)value).Length == 6)
                {
                    this.patente = value;
                }
            }
        }
        public Vehiculo(string patente)
        {
            this.ingreso = DateTime.Now.AddHours(-3);
            this.patente = "";
            this.Patente = patente;
        }

        #region Metodos
        public abstract string ConsultarDatos();
        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ingreso: {this.ingreso:d dd ddd dddd hh}");
            sb.Append(this.ToString());
            return sb.ToString();
        }
        public override string ToString()
        {
            return string.Format("Patente: {0}", this.patente);
        }
        public override bool Equals(Object obj)
        {
            if (!(obj is null) && obj is Vehiculo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Operadores
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool aux = false;
            if (!(v1 is null) && !(v2 is null) && v1.Equals(v2) && v1.Patente == v2.Patente)
            {
                aux = true;
            };
            return aux;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion
    }
}
