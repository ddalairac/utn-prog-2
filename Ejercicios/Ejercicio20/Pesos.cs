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
        private static double cotizRespectoDolar
        {
            get
            {
                return 38.33;
            }
        }
        public override double GetCotizacion()
        {
            double response = base.GetCantiad() * cotizRespectoDolar;
            return response;
        }
    }
}
