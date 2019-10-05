using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Sumador
    {
        public int cantidadSumas;
        public Sumador(int cant){
            this.cantidadSumas = cant;
        }
        public Sumador():this(0){ }

        public long Sumar(long a, long b) {
            cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            cantidadSumas++;
            return a + b;
        }
        public static long operator + (Sumador a, Sumador b)
        {
            return (long) a.cantidadSumas + b.cantidadSumas;
        }
        public static bool operator |(Sumador a, Sumador b)
        {
            return a.cantidadSumas == b.cantidadSumas;
        }
    }
}
