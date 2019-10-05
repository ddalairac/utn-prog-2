using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public short CaballosDeFuerza
        {
            get { return this.caballosDeFuerza; }
            set { this.caballosDeFuerza = value; }
        }
        public AutoF1(short numero, string escuderia) : base(numero, escuderia) { }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : base(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }
        public new string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(base.MostrarDatos());
            str.AppendLine($"caballosDeFuerza: {this.caballosDeFuerza}");
            return str.ToString();
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool rta = false;
            if (!(a1 is null) && !(a2 is null))
            {
                if (a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia && a1.caballosDeFuerza == a2.caballosDeFuerza)
                {
                    rta = true;
                }
            }
            return rta;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
