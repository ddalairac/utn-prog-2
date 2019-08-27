using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar : Moneda
    {
        public Dolar(double cantidad):base(cantidad){ }
        public Dolar() : this(0) { }
        public static double cotizRespectoDolar = 1;

    }
    //public static double GetCotizacion()
    //{
    //    return cotizRespectoDolar;
    //}
}
