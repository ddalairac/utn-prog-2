using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Clase Estacionamiento:
a. El constructor privado será el único lugar donde se instanciará la lista de Vehiculos.
b. El operador explícito retornará la información del Estacionamiento y los Vehiculos en su lista.
c. Un Estacionamiento y un Vehiculo será iguales si este último se encuentra dentro de la lista delprimero.
d. Se agregará un Vehiculo a la lista (+) siempre y cuando este:
    i. No figure previamente en la lista de Vehiculos.
    ii. Tenga una patente asignada.
    iii. La cantidad de espacio disponible del estacionamiento sea mayor a la cantidad de Vehiculos
    en la lista.
e. Al quitar un Vehiculo de la lista se retornará el ticket de cobro mediante el método ImprimirTicket.
    Caso contrario el método retornará: "El vehículo no es parte del estacionamiento".
*/
namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        #region Constructores
        public Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Estacionamiento(string nombre, int espacioDisponible) : this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region Operadores
        public static explicit operator string(Estacionamiento e)
        {
            return "";
        }
        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            bool isListed = false;
            if (!(e is null) && !(v is null))
            {
                foreach (Vehiculo item in e.vehiculos)
                {
                    if (item == v)
                    {
                        isListed = true;
                        break;
                    }
                }
            }

            return isListed;
        }
        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }
        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v)
        {
            if (!(e is null) && !(v is null))
            {
                if (e != v)
                {
                    e.vehiculos.Add(v);
                }
            }
            return e;
        }
        public static string operator -(Estacionamiento e, Vehiculo v)
        {
            StringBuilder sb = new StringBuilder();
            if (!(e is null) && !(v is null))
            {
                if (e == v)
                {
                    sb.Append(v.ImprimirTicket());
                    e.vehiculos.Remove(v);
                }
                else
                {
                    sb.Append("El vehículo no es parte del estacionamiento");
                }
            }

            return sb.ToString();
        }
        #endregion


    }
}
