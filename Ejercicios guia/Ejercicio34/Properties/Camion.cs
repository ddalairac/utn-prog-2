using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    public class Camion : VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int pesoCarga;
        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, int pesoCarga)
                : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.pesoCarga = pesoCarga;
        }

        public new string Mostrar()
        {
            StringBuilder str = new StringBuilder("CAMION: \n");
            str.AppendLine(base.Mostrar());
            str.AppendLine($"cantidadMarchas: {this.cantidadMarchas}");
            str.AppendLine($"pesoCarga: {this.pesoCarga}");
            return str.ToString();
        }
    }
    public enum Colores { Rojo, Blanco, Azul, Gris, Negro }
}
