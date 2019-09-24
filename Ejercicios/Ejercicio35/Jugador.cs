using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        private Jugador() : base(0, "")
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre) : base(dni, nombre)
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : base(dni, nombre)
        {
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
        }



        public int PartidosJugados
        {
            get { return this.partidosJugados; }
        }
        public int TotalGoles
        {
            get { return this.totalGoles; }
        }
        public float PromedioGoles
        {
            get { return (float)this.totalGoles / this.partidosJugados; }
        }


        public new string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.MostrarDatos());
            str.Append($"Partidos Jugados: {this.partidosJugados}\n");
            str.Append($"Total Goles: {this.totalGoles}\n");
            str.Append($"Promedio de goles: {this.PromedioGoles:#,###.00}\n");
            return str.ToString();
        }
        public static bool operator ==(Object o, Jugador j)
        {
            bool rta = false;
            if (!(o is null) && !(j is null))
            {
                if (o is Jugador)
                {
                    int oDni = (int)o.GetType().GetProperty("Dni").GetValue(o, null);
                    if (oDni == j.dni)
                    {
                        rta = true;
                    }
                }
            }
            return rta;
        }
        public static bool operator !=(Object o, Jugador j)
        {
            return !(o == j);
        }
        //public static bool operator ==(Jugador j1, Jugador j2)
        //{
        //    bool rta = false;
        //    if (!(j1 is null) && !(j2 is null))
        //    {
        //        if (j1.dni == j2.dni)
        //        {
        //            rta = true;
        //        }
        //    }
        //    return rta;
        //}
        //public static bool operator !=(Jugador j1, Jugador j2)
        //{
        //    bool rta = true;
        //    if (!(j1 is null) && !(j2 is null))
        //    {
        //        if (j1.dni == j2.dni)
        //        {
        //            rta = true;
        //        }
        //    }
        //    return rta;
        //}
    }
}
