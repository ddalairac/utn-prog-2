using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    public class Automovil : VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int cantidadPasajeros;
        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color,
            short cantidadMarchas, int cantidadPasajeros)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }
        public new string Mostrar()
        {
            StringBuilder str = new StringBuilder("AUTO: \n");
            str.AppendLine(base.Mostrar());
            str.AppendLine($"cantidadMarchas: {this.cantidadMarchas}");
            str.AppendLine($"cantidadPasajeros: {this.cantidadPasajeros}");
            return str.ToString();
        }
    }
}
