using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;
        private float promedioGoles;

        private Jugador() {
            this.dni = 0;
            this.nombre = "";
            this.partidosJugados = 0;
            this.totalGoles = 0;
            this.promedioGoles = 0;
        }
        public Jugador(int dni, string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni,nombre)
        {
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"Dni: {this.dni}\n");
            str.Append($"Nombre: {this.nombre}\n");
            str.Append($"Partidos Jugados: {this.partidosJugados}\n");
            str.Append($"Total Goles: {this.totalGoles}\n");
            str.Append($"Promedio de goles: {this.GetPromedioGoles():#,###.00}\n");
            return str.ToString();
        }
        public float GetPromedioGoles()
        {
            this.promedioGoles = (float) this.totalGoles / this.partidosJugados;
            return this.promedioGoles;
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool rta = false;
            if (!(j1 is null) && !(j2 is null)) {
                if(j1.dni == j2.dni)
                {
                    rta = true;
                }
            }
            return rta;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            bool rta = true;
            if (!(j1 is null) && !(j2 is null))
            {
                if (j1.dni == j2.dni)
                {
                    rta = true;
                }
            }
            return rta;
        }
    }
}
