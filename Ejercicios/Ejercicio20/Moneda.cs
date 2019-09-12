using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public abstract class Moneda
    {
        protected double cantidad;
        public Moneda(double cantidad){
            this.cantidad = cantidad;
        }
        public Moneda(): this(0){ }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        // Sobre escribir operadores
        public static double operator +(Moneda a, Moneda b)
        {
            return a.GetCotizacion() + b.GetCotizacion();
        }
        public static double operator -(Moneda a, Moneda b)
        {
            return a.GetCotizacion() - b.GetCotizacion();
        }
        public static double operator *(Moneda a, Moneda b)
        {
            return a.GetCotizacion() * b.GetCotizacion();
        }
        public static double operator /(Moneda a, Moneda b)
        {
            double response = 0;
            if(b.GetCantidad() != 0)
            {
                response = a.GetCotizacion() / b.GetCotizacion();
            }
            return response;
        }
        public static bool operator ==(Moneda a, Moneda b)
        {
            return a.GetCotizacion() == b.GetCotizacion();
        }
        public static bool operator != (Moneda a, Moneda b)
        {
            return a.GetCotizacion() != b.GetCotizacion();
        }
        // warning VS, sugeridos al sobreescribir los operadores == y !=
        public override bool Equals(object obj)
        {
            var moneda = obj as Moneda;
            return moneda != null &&
                   GetCantidad() == moneda.GetCantidad();
        }
        public override int GetHashCode()
        {
            return -639601069 + GetCantidad().GetHashCode();
        }
        public abstract double GetCotizacion();
    }
}
