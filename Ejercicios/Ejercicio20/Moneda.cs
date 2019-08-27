using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Moneda
    {
        protected double cantidad;
        public Moneda(double cantidad){
            this.cantidad = cantidad;
        }
        public Moneda(): this(0){ }
        public double GetCantiad()
        {
            return this.cantidad;
        }
        public static double operator +(Moneda a, Moneda b)
        {
            return a.cantidad + b.cantidad;
        }
        public static double operator -(Moneda a, Moneda b)
        {
            return a.cantidad - b.cantidad;
        }
        //public static bool operator ==(Moneda a, Moneda b)
        //{
        //    return a.cantidad == b.cantidad;
        //}
        //public static bool operator != (Moneda a, Moneda b)
        //{
        //    return a.cantidad != b.cantidad;
        //}
    }
}
