using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro : Moneda
    {
        public Euro(double cantidad) : base(cantidad) { }
        public Euro() : this(0) { }


        // Convertir moneda
        public static double cotizRespectoDolar
        {
            get
            {
                return 0.85;
            }
        }
        public override double GetCotizacion()
        {
            double response = base.GetCantidad() * cotizRespectoDolar;
            return response;
        }

        public static explicit operator Peso (Euro p)
        {
            double aux = 0;
            if (!(p is null))
            {
                aux = p.GetCotizacion();
                aux = aux * Peso.cotizRespectoDolar;
            }
            Peso eu = new Peso(aux);
            return eu;
        }
    }
}
