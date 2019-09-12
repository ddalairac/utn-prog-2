using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso : Moneda
    {
        public Peso(double cantidad) : base(cantidad) { }
        public Peso() : this(0) { }


        // Convertir moneda
        public static double cotizRespectoDolar
        {
            get
            {
                return 38.33;
            }
        }
        public override double GetCotizacion()
        {
            double response = base.GetCantidad() * cotizRespectoDolar;
            return response;
        }
        public static explicit operator Euro (Peso p) {
            double aux = 0;
            if (!(p is null))
            {
                aux = p.GetCotizacion();
                aux = aux * Euro.cotizRespectoDolar;
            }
            Euro eu = new Euro(aux);
            return eu;
        }
    }
}
