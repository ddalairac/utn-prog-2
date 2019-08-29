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
        private static double cotizRespectoDolar
        {
            get
            {
                return 0.85;
            }
        }
        public override double GetCotizacion()
        {
            double response = base.GetCantiad() * cotizRespectoDolar;
            return response;
        }
    }
}
