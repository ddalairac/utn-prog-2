using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    public class Moto : VehiculoTerrestre
    {
        public short cilindrada;
        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindrada = cilindrada;
        }
        public new string Mostrar()
        {
            StringBuilder str = new StringBuilder("MOTO: \n");
            str.AppendLine(base.Mostrar());
            str.AppendLine($"cilindrada: {this.cilindrada}");
            return str.ToString();
        }
    }
}
