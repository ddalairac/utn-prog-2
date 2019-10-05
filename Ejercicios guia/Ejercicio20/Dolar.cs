using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar : Moneda
    {
        public Dolar(double cantidad) : base(cantidad) { }
        public Dolar() : this(0) { }


        // Convertir moneda
        public static double cotizRespectoDolar
        {
            get
            {
                return 1;
            }
        }
        public override double GetCotizacion()
        {
            double response = base.GetCantidad() * cotizRespectoDolar;
            return response;
        }
    }
}
