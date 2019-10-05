using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }
        public MotoCross(short numero, string escuderia) : base(numero, escuderia) { }
        public MotoCross(short numero, string escuderia, short cilindrada) : base(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }
        public new string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(base.MostrarDatos());
            str.AppendLine($"cilindrada: {this.cilindrada}");
            return str.ToString();
        }
        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            bool rta = false;
            if (!(a1 is null) && !(a2 is null))
            {
                if (a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia && a1.cilindrada == a2.cilindrada)
                {
                    rta = true;
                }
            }
            return rta;
        }
        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
    }
}
